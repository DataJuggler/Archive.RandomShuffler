

#region using statements

using System;
using System.Windows.Forms;
using CardCounter.Enumerations;
using CardCounter.Objects;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System.Drawing;
using CardCounter.UI.Forms;
using DataJuggler.Core.UltimateHelper;
using CardCounter.Security;

#endregion

namespace CardCounter.UI.Controls
{

    #region class TableOptionsControl
    /// <summary>
    /// This class is used to handle options that show on the Black Jack table.
    /// </summary>
    public partial class TableOptionsControl : UserControl, ISelectedIndexListener
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a TableOptionsControl
        /// </summary>
        public TableOptionsControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region DealButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'DealButton' is clicked.
            /// </summary>
            private void DealButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // If the ParentMainForm object exists
                if (this.HasParentMainForm)
                {
                    // Deal the next hand
                    this.ParentMainForm.StartDealing();
                }
            }
            #endregion
            
            #region FirstButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'FirstButton' is clicked.
            /// </summary>
            private void FirstButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // test message
                MessageBoxHelper.ShowMessage("This feature is not implemented yet.", "Coming Soon!");
            }
            #endregion
            
            #region LastButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'LastButton' is clicked.
            /// </summary>
            private void LastButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // test message
                MessageBoxHelper.ShowMessage("This feature is not implemented yet.", "Coming Soon!");
            }
            #endregion
            
            #region NextButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'NextButton' is clicked.
            /// </summary>
            private void NextButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // test message
                MessageBoxHelper.ShowMessage("This feature is not implemented yet.", "Coming Soon!");
            }
            #endregion

            #region OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem);
            /// <summary>
            /// The Selected has changed.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="selectedIndex"></param>
            public void OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            {
                // if Manuel Deal 
                if (selectedIndex == 0)
                {
                    // change out the button to blue and enable the button
                    this.DealButton.BackgroundImage = Properties.Resources.DarkBlueButton;
                    this.DealButton.ForeColor = Color.LemonChiffon;
                    
                    // Put the events back (the appearance changes if you just disable the button)
                    this.DealButton.Click += DealButton_Click;
                    this.DealButton.MouseEnter += Button_MouseEnter;
                    this.DealButton.MouseLeave += Button_MouseLeave;
                }   
                else
                {
                    // use the dark button and disable the button
                    this.DealButton.BackgroundImage = Properties.Resources.DarkButton;
                    this.DealButton.ForeColor = Color.LightGray;

                    // Remove the events (the appearance changes if you just disable the button)
                    this.DealButton.Click -= DealButton_Click;
                    this.DealButton.MouseEnter -= Button_MouseEnter;
                    this.DealButton.MouseLeave -= Button_MouseLeave;
                }

                // If the GameManager object exists
                if ((this.HasGameManager) &&  (this.HasParentMainForm))
                {
                    // Set the GameSpeed
                    this.GameManager.HouseRules.GameSpeed = ParseGameSpeed(selectedItem);

                    // now save the value in the settings
                    SecureUserData security = new SecureUserData();

                    // Set the value for DontShowChipSelectorInstructions
                    security.GameSpeed = this.GameManager.HouseRules.GameSpeed;

                    // Save the settings with this value not showing again
                    security.Save();

                    // if we are not on ManuelDeal
                    if (this.GameManager.HouseRules.GameSpeed != GameSpeedEnum.Manuel_Deal)
                    {
                        // Start Dealing
                        this.ParentMainForm.StartDealing();
                    }
                }
            }
            #endregion
            
            #region OptionsButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'OptionsButton' is clicked.
            /// </summary>
            private void OptionsButton_Click(object sender, EventArgs e)
            {
                // remove focus from this item
                this.OffScreenTextBox.Focus();

                // Handle showing the options
                this.ParentMainForm.HandleOptions();
            }
            #endregion
            
            #region PauseButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'PauseButton' is clicked.
            /// </summary>
            private void PauseButton_Click(object sender, EventArgs e)
            {
                
            }
            #endregion
            
            #region PreviousButtonButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'PreviousButtonButton' is clicked.
            /// </summary>
            private void PreviousButtonButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // test message
                MessageBoxHelper.ShowMessage("This feature is not implemented yet.", "Coming Soon!");
            }
            #endregion
            
            #region QuizButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'QuizButton' is clicked.
            /// </summary>
            private void QuizButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // test message
                MessageBoxHelper.ShowMessage("This feature is not implemented yet.", "Coming Soon!");
            }
            #endregion
            
            #region ShowCountButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'ShowCountButton' is clicked.
            /// </summary>
            private void ShowCountButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // test message
                MessageBoxHelper.ShowMessage("This feature is not implemented yet.", "Coming Soon!");
            }
            #endregion
            
            #region ShuffleButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'ShuffleButton' is clicked.
            /// </summary>
            private void ShuffleButton_Click(object sender, EventArgs e)
            {
                // remove focus from thsi button
                this.OffScreenTextBox.Focus();

                // If the ParentMainForm object exists
                if (this.HasParentMainForm)
                {
                    // Shuffle a new deck
                    this.ParentMainForm.Shuffle();
                }
            }
            #endregion
            
            #region StartStopButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'StartStopButton' is clicked.
            /// </summary>
            private void StartStopButton_Click(object sender, EventArgs e)
            {
                
            }
            #endregion
            
            #region TableOptionsControl_Load(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Table Options Control _ Load
            /// </summary>
            private void TableOptionsControl_Load(object sender, EventArgs e)
            {
                // Get the GameSpeed from the Security
                SecureUserData security = new SecureUserData();

                // set the gameSpeed
                GameSpeedEnum gameSpeed = security.GameSpeed;

                // Setup the GameSpeedControl
                this.GameSpeedControl.SelectedIndex = FindGameSpeedIndex(gameSpeed);
                this.GameSpeedControl.SelectedIndexListener = this;
            }
            #endregion
            
        #endregion

        #region Methods

            #region FindGameSpeedIndex(Enumerations.GameSpeedEnum gameSpeed)
            /// <summary>
            /// This method returns the Game Speed Index
            /// </summary>
            private int FindGameSpeedIndex(Enumerations.GameSpeedEnum gameSpeed)
            {
                // initial value
                int index = -1;

                // Determine the action by the gameSpeed
                switch (gameSpeed)
                {
                    case GameSpeedEnum.Manuel_Deal:

                        // set the index to zero
                        index = 0;

                        // required
                        break;

                    case GameSpeedEnum.Very_Slow:

                        // set the index to zero
                        index = 1;

                        // required
                        break;

                    case GameSpeedEnum.Slow:

                        // set the index to zero
                        index = 2;

                        // required
                        break;

                    case GameSpeedEnum.Normal:

                        // set the index to zero
                        index = 3;

                        // required
                        break;

                    case GameSpeedEnum.Fast:

                        // set the index to zero
                        index = 4;

                        // required
                        break;

                    case GameSpeedEnum.Very_Fast:

                        // set the index to zero
                        index = 5;

                        // required
                        break;
                }

                // return value
                return index;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Load the GameSpeed Control
                this.GameSpeedControl.LoadItems(typeof(GameSpeedEnum));
            }
            #endregion
            
            #region ParseGameSpeed(object selectedItem)
            /// <summary>
            /// This method returns the Game Speed
            /// </summary>
            private GameSpeedEnum ParseGameSpeed(object selectedItem)
            {
                // initial value
                GameSpeedEnum gameSpeed = GameSpeedEnum.Manuel_Deal;

                // If the selectedItem object exists
                if (NullHelper.Exists(selectedItem))
                {
                    // set the dataType
                    string gameSpeedString = selectedItem.ToString();

                    // Determine the action by the gameSpeedString
                    switch (gameSpeedString)
                    {
                        case "Manuel Deal":

                            // set the return value
                            gameSpeed = GameSpeedEnum.Manuel_Deal;

                            // required
                            break;

                        case "Very Slow":

                            // set the return value
                            gameSpeed = GameSpeedEnum.Very_Slow;

                            // required
                            break;

                        case "Slow":

                            // set the return value
                            gameSpeed = GameSpeedEnum.Slow;

                            // required
                            break;

                        case "Normal":

                            // set the return value
                            gameSpeed = GameSpeedEnum.Normal;

                            // required
                            break;

                        case "Fast":

                            // set the return value
                            gameSpeed = GameSpeedEnum.Fast;

                            // required
                            break;

                        case "Very Fast":

                            // set the return value
                            gameSpeed = GameSpeedEnum.Very_Fast;

                            // required
                            break;
                    }
                }

                // parse the gameSpeed
                return gameSpeed;
            }
            #endregion
            
        #endregion

        #region Properties

            #region GameManager
            /// <summary>
            /// This property gets or sets the value for 'GameManager'.
            /// </summary>
            public GameManager GameManager
            {
                get
                {
                    // initial value
                    GameManager gameManager = null;

                    // if the control exists
                    if (ParentMainForm != null)
                    {
                        // set the return value
                        gameManager = (GameManager) ParentMainForm.GameManager;
                    }

                    // return value
                    return gameManager;
                }
                set
                {
                    // if the control exists
                    if (ParentMainForm != null)
                    {
                        // set the value
                        ParentMainForm.GameManager = value;
                    }
                }
            }
            #endregion

            #region HasGameManager
            /// <summary>
            /// This property returns true if this object has a 'GameManager'.
            /// </summary>
            public bool HasGameManager
            {
                get
                {
                    // initial value
                    bool hasGameManager = (this.GameManager != null);
                    
                    // return value
                    return hasGameManager;
                }
            }
            #endregion
            
            #region HasParentMainForm
            /// <summary>
            /// This property returns true if this object has a 'ParentMainForm'.
            /// </summary>
            public bool HasParentMainForm
            {
                get
                {
                    // initial value
                    bool hasParentMainForm = (this.ParentMainForm != null);
                    
                    // return value
                    return hasParentMainForm;
                }
            }
            #endregion
            
            #region ParentMainForm
            /// <summary>
            /// This read only property returns the value for 'ParentMainForm'.
            /// </summary>
            public MainForm ParentMainForm
            {
                get
                {
                    // initial value
                    MainForm parentMainForm = this.ParentForm as MainForm;
                    
                    // return value
                    return parentMainForm;
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
