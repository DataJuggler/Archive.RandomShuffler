

#region using statements

using CardCounter.Security;
using CardCounter.UI.Forms;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using CardCounter.Actions;
using CardCounter.Objects;
using CardCounter.Enumerations;

#endregion

namespace CardCounter.UI.Controls
{

    #region class ChipSelectorControl
    /// <summary>
    /// This class is used to select an amount of chips either to bet or as a starting bankroll.
    /// </summary>
    public partial class ChipSelectorControl : UserControl
    {
        
        #region Private Variables
        private double amountBet;
        private const int WhiteChipValue = 1;
        private const int RedChipValue = 5;
        private const int GreenChipValue = 25;
        private const int BlackChipValue = 100;
        private const int PurpleChipValue = 500;
        private const int GoldChipValue = 1000;
        private PlayerResponseControl playerResponseControl;
        private Options houseRules;
        private Button selectedButton;
        private bool userCancelled;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a Chip Selector Control.
        /// </summary>
        public ChipSelectorControl()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region AmountSelectedTextBox_Leave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Amount Selected Text Box _ Leave
            /// </summary>
            private void AmountSelectedTextBox_Leave(object sender, EventArgs e)
            {
                // local
                bool showMessage = false;

                // parse the amount amountBet
                double amountBet = NumericHelper.ParseDouble(this.AmountSelectedTextBox.Text.Replace(",", "").Replace("$", ""), 0, -1);

                // set the value
                if (amountBet < 1)
                {
                    // Set the value for the showMessage to true
                    showMessage = true;

                    // if we could not parse the number the amount goes to zero
                    amountBet = 0;
                }

                // set the value
                this.AmountBet = amountBet;

                // if the value for showMessage is true
                if (showMessage)
                {
                    // Show the user a message
                    MessageBoxHelper.ShowMessage("You must enter only numbers.", "Invalid Input");
                }
            }
            #endregion
            
            #region BlackChipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'BlackChipButton' is clicked.
            /// </summary>
            private void BlackChipButton_Click(object sender, EventArgs e)
            {
                // Add 100
                this.AmountBet += BlackChipValue;
            }
            #endregion
            
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
            
            #region CancelSelectButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'CancelSelectButton' is clicked.
            /// </summary>
            private void CancelSelectButton_Click(object sender, EventArgs e)
            {
                // the user did cancel
                this.UserCancelled = true;

                // If the ParentChipSelectorForm object exists
                if (this.HasParentChipSelectorForm)
                {
                    // close the parent form                    
                    this.ParentChipSelectorForm.Close();
                }
            }
            #endregion
            
            #region ChipSelectorControl_Load(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Chip Selector Control _ Load
            /// </summary>
            private void ChipSelectorControl_Load(object sender, EventArgs e)
            {
                // Perform initializations for this object
                Init();
            }
            #endregion
            
            #region ClearButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'ClearButton' is clicked.
            /// </summary>
            private void ClearButton_Click(object sender, EventArgs e)
            {
                // Erase the Amount Bet
                this.AmountBet = 0;
            }
            #endregion
            
            #region GoldChipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'GoldChipButton' is clicked.
            /// </summary>
            private void GoldChipButton_Click(object sender, EventArgs e)
            {  
                // Add 1,000
                this.AmountBet += GoldChipValue;
            }
            #endregion
            
            #region GreenChipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'GreenChipButton' is clicked.
            /// </summary>
            private void GreenChipButton_Click(object sender, EventArgs e)
            {
                // Add 25
                this.AmountBet += GreenChipValue;
            }
            #endregion
            
            #region PurpleChipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'PurpleChipButton' is clicked.
            /// </summary>
            private void PurpleChipButton_Click(object sender, EventArgs e)
            {
                // Add 500
                this.AmountBet += PurpleChipValue;
            }
            #endregion
            
            #region RedChipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'RedChipButton' is clicked.
            /// </summary>
            private void RedChipButton_Click(object sender, EventArgs e)
            {
                // Add 5
                this.AmountBet += RedChipValue;
            }
            #endregion

            #region SelectButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'SelectButton' is clicked.
            /// </summary>
            private void SelectButton_Click(object sender, EventArgs e)
            {
                // the user did not cancel
                this.UserCancelled = false;

                // If the ParentChipSelectorForm object exists
                if (this.HasParentChipSelectorForm)
                {
                    // if the PlayerResponseControl exists
                    if ((this.HasPlayerResponseControl) && (this.PlayerResponseControl.HasSendResponseCallBack) && (this.HasHouseRules))
                    {
                        // get the amountBet
                        double amountBet = this.AmountBet;

                        // Create a place bet response request
                        PlayerResponse playerResponse = new PlayerResponse(ResponseTypeEnum.PlaceBet, amountBet);

                        // Send the response
                        this.PlayerResponseControl.SendResponseCallBack(playerResponse);

                        // The response has been sent
                        this.PlayerResponseControl.ResponseSent = true;
                    }

                    // Close the parent form
                    this.ParentChipSelectorForm.Close();
                }
            }
            #endregion
            
            #region WhiteChipButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'WhiteChipButton' is clicked.
            /// </summary>
            private void WhiteChipButton_Click(object sender, EventArgs e)
            {
                // Add 1
                this.AmountBet += WhiteChipValue;
            }
            #endregion
            
        #endregion

        #region Methods

            #region ClearSelectedButton()
            /// <summary>
            /// This method Clear Selected Button
            /// </summary>
            private void ClearSelectedButton()
            {
                // Clear each button
                this.WhiteChipButton.FlatAppearance.BorderSize = 0;
                this.RedChipButton.FlatAppearance.BorderSize = 0;
                this.GreenChipButton.FlatAppearance.BorderSize = 0;
                this.BlackChipButton.FlatAppearance.BorderSize = 0;
                this.PurpleChipButton.FlatAppearance.BorderSize = 0;
                this.GoldChipButton.FlatAppearance.BorderSize = 0;
            }
            #endregion
            
            #region DisplayAmountBet()
            /// <summary>
            /// This method Display the Amount Bet
            /// </summary>
            public void DisplayAmountBet()
            {
                // Format the text with commas
                this.AmountSelectedTextBox.Text = "$" + String.Format("{0:n0}", this.AmountBet);
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Default to user cancelled
                this.UserCancelled = true;
            }
            #endregion
            
            #region SelectThisButton(Button selectedButton)
            /// <summary>
            /// This method returns the This Button
            /// </summary>
            private void SelectThisButton(Button selectedButton)
            {
                // If the selectedButton object exists
                if (NullHelper.Exists(selectedButton))
                {
                    // determine which control is selected by the name                    
                    switch (selectedButton.Name)
                    {
                        case "WhiteChipButton":

                            // set the Border Size and Color
                            this.WhiteChipButton.FlatAppearance.BorderSize = 1;
                            this.WhiteChipButton.FlatAppearance.BorderColor = Color.LemonChiffon;

                            // required
                            break;

                        case "RedChipButton":

                            // set the Border Size and Color
                            this.RedChipButton.FlatAppearance.BorderSize = 1;
                            this.RedChipButton.FlatAppearance.BorderColor = Color.LemonChiffon;

                            // required
                            break;

                        case "GreenChipButton":

                            // set the Border Size and Color
                            this.GreenChipButton.FlatAppearance.BorderSize = 1;
                            this.GreenChipButton.FlatAppearance.BorderColor = Color.LemonChiffon;

                            // required
                            break;

                        case "BlackChipButton":

                            // set the Border Size and Color
                            this.BlackChipButton.FlatAppearance.BorderSize = 1;
                            this.BlackChipButton.FlatAppearance.BorderColor = Color.LemonChiffon;

                            // required
                            break;

                        case "PurpleChipButton":

                            // set the Border Size and Color
                            this.PurpleChipButton.FlatAppearance.BorderSize = 1;
                            this.PurpleChipButton.FlatAppearance.BorderColor = Color.LemonChiffon;

                            // required
                            break;

                        case "GoldChipButton":

                            // set the Border Size and Color
                            this.GoldChipButton.FlatAppearance.BorderSize = 1;
                            this.GoldChipButton.FlatAppearance.BorderColor = Color.LemonChiffon;

                            // required
                            break;
                    }
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region AmountBet
            /// <summary>
            /// This property gets or sets the value for 'AmountBet'.
            /// </summary>
            public double AmountBet
            {
                get { return amountBet; }
                set 
                { 
                    // set the amountBet value
                    amountBet = value;

                    // Display the value
                    DisplayAmountBet();
            }
            }
            #endregion
            
            #region HasHouseRules
            /// <summary>
            /// This property returns true if this object has a 'HouseRules'.
            /// </summary>
            public bool HasHouseRules
            {
                get
                {
                    // initial value
                    bool hasHouseRules = (this.HouseRules != null);
                    
                    // return value
                    return hasHouseRules;
                }
            }
            #endregion
            
            #region HasParentChipSelectorForm
            /// <summary>
            /// This property returns true if this object has a 'ParentChipSelectorForm'.
            /// </summary>
            public bool HasParentChipSelectorForm
            {
                get
                {
                    // initial value
                    bool hasParentChipSelectorForm = (this.ParentChipSelectorForm != null);
                    
                    // return value
                    return hasParentChipSelectorForm;
                }
            }
            #endregion

            #region HasPlayerResponseControl
            /// <summary>
            /// This property returns true if this object has a 'PlayerResponseControl'.
            /// </summary>
            public bool HasPlayerResponseControl
            {
                get
                {
                    // initial value
                    bool hasPlayerResponseControl = (this.PlayerResponseControl != null);
                    
                    // return value
                    return hasPlayerResponseControl;
                }
            }
            #endregion
            
            #region HouseRules
            /// <summary>
            /// This property gets or sets the value for 'HouseRules'.
            /// </summary>
            public Options HouseRules
            {
                get { return houseRules; }
                set { houseRules = value; }
            }
            #endregion
            
            #region ParentChipSelectorForm
            /// <summary>
            /// This read only property returns the value for 'ParentChipSelectorForm'.
            /// </summary>
            public ChipSelectorForm ParentChipSelectorForm
            {
                get
                {
                    // initial value
                    ChipSelectorForm chipSelectorForm = this.Parent as ChipSelectorForm;
                    
                    // return value
                    return chipSelectorForm;
                }
            }
            #endregion
            
            #region PlayerResponseControl
            /// <summary>
            /// This property gets or sets the value for 'PlayerResponseControl'.
            /// </summary>
            public PlayerResponseControl PlayerResponseControl
            {
                get { return playerResponseControl; }
                set { playerResponseControl = value; }
            }
            #endregion
            
            #region SelectedButton
            /// <summary>
            /// This property gets or sets the value for 'SelectedButton'.
            /// </summary>
            public Button SelectedButton
            {
                get { return selectedButton; }
                set { selectedButton = value; }
            }
            #endregion
            
            #region UserCancelled
            /// <summary>
            /// This property gets or sets the value for 'UserCancelled'.
            /// </summary>
            public bool UserCancelled
            {
                get { return userCancelled; }
                set { userCancelled = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
