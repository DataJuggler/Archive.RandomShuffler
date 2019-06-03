

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls;
using PickADoorGame.Enumerations;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.RandomShuffler;
using DataJuggler.Core.RandomShuffler.Reports;

#endregion

namespace PickADoorGame
{

    

    #region class MainForm
    /// <summary>
    /// This is the MainForm for this application.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private List<PickADoorSimulator> simulationsNotSwapping;
        private List<PickADoorSimulator> simulationsSwapping;
        private int swapCorrect;
        private int swapWrong;
        private int doNotSwapCorrect;
        private int doNotSwapWrong;
        private const int Simulations = 3000;
        private RandomShuffler shuffler;
        private RandomReport report;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a MainForm object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region DoneButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'DoneButton' is clicked.
            /// </summary>
            private void DoneButton_Click(object sender, EventArgs e)
            {
                // Exit the app
                Environment.Exit(0);
            }
            #endregion
            
            #region MainForm_FormClosed(object sender, FormClosedEventArgs e)
            /// <summary>
            /// This event is fired when Main Form _ Form Closed
            /// </summary>
            private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                // Close this app
                Environment.Exit(0);
            }
            #endregion
            
            #region StartSimulationButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'StartSimulationButton' is clicked.
            /// </summary>
            private void StartSimulationButton_Click(object sender, EventArgs e)
            {
                // Start the simulation
                StartSimulation();
            }
            #endregion
            
        #endregion

        #region Methods

            #region CanPullNextItem()
            /// <summary>
            /// This method returns true if the Shuffler.CanPullNextItem returns true
            /// </summary>
            /// <returns></returns>
            public bool CanPullNextItem()
            {
                // initial value
                bool canPullNextItem = false;

                // If the Shuffler object exists
                if (this.HasShuffler)
                {
                    // set the return value
                    canPullNextItem = this.Shuffler.CanPullNextItem();
                }

                // return value
                return canPullNextItem;
            }
            #endregion

            #region GetDoorSelectOption()
            /// <summary>
            /// This method returns the Door Select Option
            /// </summary>
            private DoorSelectOptionEnum GetDoorSelectOption()
            {
                // initial value
                DoorSelectOptionEnum doorSelectOption = DoorSelectOptionEnum.Random;

                // if less than Random
                if (this.SelectDoorNumberControl.SelectedIndex < 3)
                {
                    // Cast the SelectedIndex (+1) as the enum
                    doorSelectOption = (DoorSelectOptionEnum) (this.SelectDoorNumberControl.SelectedIndex + 1);
                }

                // return the selected index
                return doorSelectOption;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Set the default value
                this.SimulationsControl.Text = String.Format("{0:n0}", Simulations);
                
                // Load the choices and select Random
                this.SelectDoorNumberControl.LoadItems(typeof(DoorSelectOptionEnum));

                // Select Random
                this.SelectDoorNumberControl.SelectedIndex = 3;
            }
            #endregion
            
            #region PullNextItem()
            /// <summary>
            /// This method returns the Next Item
            /// </summary>
            public int PullNextItem()
            {
                // initial value
                int nextItem = 0;

                // If the Shuffler object exists
                if (this.HasShuffler)
                {
                    // pull the next item
                    nextItem = this.Shuffler.PullNextItem(false);
                }
                
                // return value
                return nextItem;
            }
            #endregion
            
            #region RefreshUI()
            /// <summary>
            /// This method Refresh UI
            /// </summary>
            private void RefreshUI()
            {
                // Refresh everything
                this.Refresh();
                Application.DoEvents();
                this.InitializingLabel.Refresh();
                this.Graph.Refresh();
            }
            #endregion
            
            #region StartSimulation()
            /// <summary>
            /// This method Start Simulation
            /// </summary>
            private void StartSimulation()
            {
                // Create a 
                RandomDoorCallBack dealer = new RandomDoorCallBack(CanPullNextItem, PullNextItem);

                // Create a report
                this.Report = new RandomReport(PickADoorSimulator.MinValue, PickADoorSimulator.MaxValue);
                
                // You can't start a second simulation without restarting.
                this.StartSimulationButton.Enabled = false;

                // Show the initializing label
                this.InitializingLabel.Visible = true;
                this.Graph.Visible = true;

                // Show the Setup
                RefreshUI();

                // locals
                DoorSelectOptionEnum doorSelectOption = GetDoorSelectOption();                
                PickADoorSimulator simulatorWithoutSwap = null;
                PickADoorSimulator simulatorWithSwap = null;
                
                // Get the number of simulations to run
                int simulations =  NumericHelper.ParseInteger(this.SimulationsControl.Text.Replace(",", ""), 0, -1);

                // If the value for simulations is greater than zero
                if (simulations > 0)
                {
                    // create the total possibilities to choose from
                    int possibilities = PickADoorSimulator.MaxValue * 10;

                    // Create a Shuffler
                    this.Shuffler = new RandomShuffler(PickADoorSimulator.MinValue, PickADoorSimulator.MaxValue, possibilities, PickADoorSimulator.TimesToShuffle, 1);

                     // Set the report
                     this.Shuffler.Report = this.Report;

                    // Create the two lists
                    this.SimulationsSwapping = new List<PickADoorSimulator>();
                    this.SimulationsNotSwapping = new List<PickADoorSimulator>();

                    // Set the maximum
                    this.Graph.Maximum = simulations;

                    // iterate the number of simuations to create them
                    for (int x = 1; x <= simulations; x++)
                    {
                        // Create a simulation for Without Swap
                        simulatorWithoutSwap = new PickADoorSimulator(doorSelectOption, false, dealer);

                        // Create a simulation for Swap
                        simulatorWithSwap = new PickADoorSimulator(doorSelectOption, true, dealer);

                        // Add each simulation
                        this.SimulationsNotSwapping.Add(simulatorWithoutSwap);
                        this.SimulationsSwapping.Add(simulatorWithSwap);

                        // Set the graph value
                        this.Graph.Value = x;

                        // Refresh everything
                        this.RefreshUI();
                    }

                    // Hide the setup
                    this.InitializingLabel.Visible = false;
                    this.Graph.Visible = false;

                    // refresh the UI
                    RefreshUI();

                    // for debugging only
                    // StringBuilder sb = new StringBuilder();

                    // Now run the simulations
                    for (int x = 0; x < simulations; x++)
                    {
                        // Run the simulations
                        this.SimulationsNotSwapping[x].RunSimulation();
                        this.SimulationsSwapping[x].RunSimulation();

                        // if it was a correct guess
                        if (this.SimulationsNotSwapping[x].CorrectGuess)
                        {
                            // Increment the value for this
                            this.DoNotSwapCorrect++;
                        }
                        else
                        {
                            // Increment the value for this
                            this.DoNotSwapWrong++;
                        }

                        // if it was a correct guess
                        if (this.SimulationsSwapping[x].CorrectGuess)
                        {
                            // Increment the value for this
                            this.SwapCorrect++;
                        }
                        else
                        {
                            // Increment the value for this
                            this.SwapWrong++;
                        }

                        // Display the results
                        this.DoNotSwapCorrectValueLabel.Text = String.Format("{0:n0}", DoNotSwapCorrect);
                        this.DoNotSwapWrongValueLabel.Text = String.Format("{0:n0}", DoNotSwapWrong);
                        this.SwapCorrectValueLabel.Text = String.Format("{0:n0}", SwapCorrect);
                        this.SwapWrongValueLabel.Text = String.Format("{0:n0}", SwapWrong);

                        // refresh the user interface
                        RefreshUI();
                    }

                    // Get the report
                    if (this.Report.HasOccurrences)
                    {
                        // local
                        int tempCount = 0;

                        // iterate the occurrences
                        foreach (NumberOccurrence occurrence in this.Report.Occurrences)
                        {
                            // local
                            int thisNumber = occurrence.Number;
                            tempCount = occurrence.Count;

                            // write out the number
                            Console.WriteLine(thisNumber + ": " + tempCount + " of " + this.Report.TotalItemsPulled);
                        }
                    }             
                }
                else
                {  
                    // Show the user a message
                    MessageBoxHelper.ShowMessage("You must enter the number of simulations", "Invalid Input");
                }
                
                // Add Finished so we know it is done.
                this.Text = this.Text + " - Finished";           
            }
            #endregion
            
        #endregion
        
        #region Properties

            #region DoNotSwapCorrect
            /// <summary>
            /// This property gets or sets the value for 'DoNotSwapCorrect'.
            /// </summary>
            public int DoNotSwapCorrect
            {
                get { return doNotSwapCorrect; }
                set { doNotSwapCorrect = value; }
            }
            #endregion
            
            #region DoNotSwapWrong
            /// <summary>
            /// This property gets or sets the value for 'DoNotSwapWrong'.
            /// </summary>
            public int DoNotSwapWrong
            {
                get { return doNotSwapWrong; }
                set { doNotSwapWrong = value; }
            }
            #endregion
            
            #region HasShuffler
            /// <summary>
            /// This property returns true if this object has a 'Shuffler'.
            /// </summary>
            public bool HasShuffler
            {
                get
                {
                    // initial value
                    bool hasShuffler = (this.Shuffler != null);
                    
                    // return value
                    return hasShuffler;
                }
            }
            #endregion
            
            #region Report
            /// <summary>
            /// This property gets or sets the value for 'Report'.
            /// </summary>
            public RandomReport Report
            {
                get { return report; }
                set { report = value; }
            }
            #endregion
            
            #region Shuffler
            /// <summary>
            /// This property gets or sets the value for 'Shuffler'.
            /// </summary>
            public RandomShuffler Shuffler
            {
                get { return shuffler; }
                set { shuffler = value; }
            }
            #endregion
           
            #region SimulationsNotSwapping
            /// <summary>
            /// This property gets or sets the value for 'SimulationsNotSwapping'.
            /// </summary>
            public List<PickADoorSimulator> SimulationsNotSwapping
            {
                get { return simulationsNotSwapping; }
                set { simulationsNotSwapping = value; }
            }
            #endregion
            
            #region SimulationsSwapping
            /// <summary>
            /// This property gets or sets the value for 'SimulationsSwapping'.
            /// </summary>
            public List<PickADoorSimulator> SimulationsSwapping
            {
                get { return simulationsSwapping; }
                set { simulationsSwapping = value; }
            }
            #endregion
            
            #region SwapCorrect
            /// <summary>
            /// This property gets or sets the value for 'SwapCorrect'.
            /// </summary>
            public int SwapCorrect
            {
                get { return swapCorrect; }
                set { swapCorrect = value; }
            }
            #endregion
            
            #region SwapWrong
            /// <summary>
            /// This property gets or sets the value for 'SwapWrong'.
            /// </summary>
            public int SwapWrong
            {
                get { return swapWrong; }
                set { swapWrong = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
