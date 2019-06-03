

#region using statements

using CardCounter.Enumerations;
using CardCounter.Factory;
using CardCounter.Interfaces;
using CardCounter.Objects;
using CardCounter.Systems;
using CardCounter.UI.Forms;
using CardCounter.Util;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

#endregion

namespace CardCounter.UI.Controls
{

    #region class PlayerEditorControl
    /// <summary>
    /// This class is used to edit a player seated at a black jack table.
    /// </summary>
    public partial class PlayerEditorControl : UserControl, ICheckChangedListener
    {
        
        #region Private Variables
        private Player player;
        private int seatNumber;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a PlayerEditorControl
        /// </summary>
        public PlayerEditorControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events
            
            #region Button_MouseEnter(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, System.EventArgs e)
            {
                // Change the cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, System.EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region ChipSelectorButton_Click(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the 'ChipRackButton' is clicked.
            /// </summary>
            private void ChipSelectorButton_Click(object sender, System.EventArgs e)
            {
                // Show the Chips Selector
                ChipSelectorHelper.ShowChipSelector(this.ChipsControl);
            }
            #endregion

            #region HelpButton_Click(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the 'HelpButton' is clicked.
            /// </summary>
            private void HelpButton_Click(object sender, System.EventArgs e)
            {
                // Create a new instance of a 'HelpForm' object.
                HelpForm helpForm = new HelpForm();

                // Show the HelpForm
                helpForm.ShowDialog();
            }
            #endregion
            
            #region OnCheckChanged(LabelCheckBoxControl sender, bool isChecked);
            /// <summary>
            /// The checkbox has been checked or unchecked.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="selectedIndex"></param>
            public void OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            {
                // set the value for enabled
                bool enabled = isChecked;

                // locals
                Color labelColor = Color.Black;

                // use gray if not enabled
                if (!enabled)
                {
                    // use dark gray
                    labelColor = Color.DarkGray;
                }

                // set the label color
                this.NameControl.LabelColor = labelColor;
                this.ChipsControl.LabelColor = labelColor;
                this.IsComputerPlayerCheckBox.LabelColor = labelColor;
                
                // enable each of the controls
                this.CountingSystemControl.Enabled = enabled;
                this.CountingSystemControl.Editable = enabled;
                this.NameControl.Enabled = enabled;
                this.NameControl.Editable = enabled;
                this.ChipsControl.Enabled = enabled;
                this.ChipsControl.Editable = enabled;
                this.IsComputerPlayerCheckBox.Enabled = enabled;
                this.IsComputerPlayerCheckBox.Editable = enabled;
            }
            #endregion
            
        #endregion

        #region Methods

            #region CapturePlayer()
            /// <summary>
            /// This method returns the Player
            /// </summary>
            internal Player CapturePlayer()
            {
                // initial value
                Player player = null;
                
                // If the Player object exists
                if (this.HasPlayer)
                {
                     // use the existing player
                     player = this.Player;
                }
                else
                {
                    // Create a new instance of a 'Player' object.
                    player = new Player();
                }

                // is this player seated
                player.SeatNumber = (SeatNumberEnum) this.SeatNumber;

                // if there is a selected card counting system
                if (this.CountingSystemControl.HasSelectedObject)
                {
                    // Set the CardCountingSystem
                    player.CardCountingSystem = CardCountingSystemFactory.FindCardCountingSystem(this.CountingSystemControl.SelectedObject.ToString());
                }

                // Set the players name
                player.Name = this.NameControl.Text;

                // Get the current chips
                player.Chips = NumericHelper.ParseDouble(this.ChipsControl.Text.Replace(",", "").Replace("$", ""), 0, -1);

                // Is this a computer player
                player.IsComputerPlayer = this.IsComputerPlayerCheckBox.Checked;

                // return value
                return player;
            }
            #endregion
            
            #region DisplayPlayer()
            /// <summary>
            /// This method Display Player
            /// </summary>
            private void DisplayPlayer()
            {
                // locals
                bool isSeated = false;
                bool isComputerPlayer = false;
                int countSystemIndex = -1;
                string name = "";
                string chips = "$.0.00";

                // If the Player object exists
                if (this.HasPlayer)
                {
                    // set the values
                    isSeated = this.Player.Seated;
                    ICardCountingSystem countingSystem = this.Player.CardCountingSystem;
                    name = this.Player.Name;
                    chips = "$" + String.Format("{0:n0}", this.Player.Chips);
                    isComputerPlayer = this.Player.IsComputerPlayer;

                    // if the countingSystem exists
                    if (NullHelper.Exists(countingSystem))
                    {
                        // Find the countSystemIndex
                        countSystemIndex = FindCountSystemIndex(countingSystem);
                    }
                    else
                    {
                        // Find the countSystemIndex
                        HighLowSystem highLow = new HighLowSystem();
                        countSystemIndex = FindCountSystemIndex(highLow);
                    }
                }

                // Check the box if seated
                this.IsComputerPlayerCheckBox.Checked = isComputerPlayer;
                this.SeatNumberCheckBox.Checked = isSeated;
                this.CountingSystemControl.SelectedIndex = countSystemIndex;
                this.NameControl.Text = name;
                this.ChipsControl.Text = chips;
            }
            #endregion
            
            #region FindCountSystemIndex(ICardCountingSystem countingSystem)
            /// <summary>
            /// This method returns the Count System Index
            /// </summary>
            private int FindCountSystemIndex(ICardCountingSystem countingSystem)
            {
                // initial value
                int countSystemIndex = -1;

                // locals
                int index = -1;

                // If the countingSystem object exists
                if (NullHelper.Exists(countingSystem))
                {
                    // iterate the items in this controls
                    foreach (object item in this.CountingSystemControl.Items)
                    {
                        // Increment the value for index
                        index++;

                        // cast the item as an ICardCountingSystem object
                        string name = item.ToString();

                        // If the tempCountingSystem object exists
                        if (TextHelper.Exists(name))
                        {
                            // if this is the item being sought
                            if (TextHelper.IsEqual(name, countingSystem.Name))
                            {
                                // set the return value
                                countSystemIndex = index;

                                // break out of the loop
                                break;
                            }
                        }
                    }
                }

                // return value
                return countSystemIndex;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create each of the systems
                List<ICardCountingSystem> countingSystems = CardCountingSystemFactory.LoadCardCountingSystems();

                // load the combo box
                this.CountingSystemControl.LoadItems(countingSystems);

                // Select High Low
                this.CountingSystemControl.SelectedIndex = 0;

                // Wire up the Check Changed Listener
                this.SeatNumberCheckBox.CheckChangedListener = this;
            }
            #endregion
            
        #endregion

        #region Properties

            #region HasPlayer
            /// <summary>
            /// This property returns true if this object has a 'Player'.
            /// </summary>
            public bool HasPlayer
            {
                get
                {
                    // initial value
                    bool hasPlayer = (this.Player != null);
                    
                    // return value
                    return hasPlayer;
                }
            }
            #endregion
            
            #region Player
            /// <summary>
            /// This property gets or sets the value for 'Player'.
            /// </summary>
            public Player Player
            {
                get { return player; }
                set 
                { 
                    // set the value
                    player = value;

                    // display the values
                    this.DisplayPlayer();
                }
            }
            #endregion
            
            #region SeatNumber
            /// <summary>
            /// This property gets or sets the value for 'SeatNumber'.
            /// </summary>
            public int SeatNumber
            {
                get { return seatNumber; }
                set 
                { 
                    // set the value
                    seatNumber = value;

                    // Set the LabelText based upon the SeatNumber
                    this.SeatNumberCheckBox.LabelText = "Seat " + seatNumber.ToString() + ":";
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
