

#region using statements

using CardCounter.Enumerations;
using CardCounter.Factory;
using CardCounter.Objects;
using CardCounter.UI.Forms;
using CardCounter.Util;
using DataJuggler.Core.RandomShuffler;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.UltimateHelper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace CardCounter.UI.Controls
{

    #region class BlackJackPlayerControl1
    /// <summary>
    /// This class represents someone dealt a Black Jack hand.
    /// This can be a human player, a computer player or 
    /// the dealer.
    /// </summary>
    public partial class BlackJackPlayerControl : UserControl
    {
        
        #region Private Variables
        private SeatNumberEnum seatNumber;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a BlackJackPlayer control
        /// </summary>
        public BlackJackPlayerControl()
        {
            // Create Controls
            InitializeComponent();
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
            
            #region ChipSelectorButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'ChipSelectorButton' is clicked.
            /// </summary>
            private void ChipSelectorButton_Click(object sender, EventArgs e)
            {
                // Show the Chips Selector
                ChipSelectorHelper.ShowChipSelector(this.BetAmountTextBox);
            }
            #endregion
            
        #endregion

        #region Methods

            #region DisplayCards(List<Card> cards)
            /// <summary>
            /// This method returns a list of Cards
            /// </summary>
            internal void DisplayCards(List<Card> cards)
            {
                // if the CardContainerControl exists                
                if (NullHelper.Exists(this.CardContainerControl))
                {
                    // Show the cards
                    this.CardContainerControl.DisplayCards(cards);
                }
            }
            #endregion
            
            #region DisplayChipBalance()
            /// <summary>
            /// This method Display Chip Balance
            /// </summary>
            public void DisplayChipBalance()
            {
                // locals
                double chips = 0;
                string formattedChips = "";

                // If the Player object exists
                if (this.HasPlayer)
                {
                    // get the chips
                    chips = this.Player.Chips;
                    
                    // now format the chips
                    formattedChips = "$" + String.Format("{0:n0}", chips);
                }

                // ensure the ChipsPanel is visible and not the BetPanel
                this.ChipsPanel.Visible = true;
                this.BetPanel.Visible = false;

                // Now display the value
                this.ChipsLabel.Visible = true;
                this.ChipsLabel.Text = formattedChips;

                // if the Table exists
                if (this.HasTable)
                {
                    // Refresh the ChipsLabel
                    this.ChipsLabel.Refresh();

                    // Refresh the Table
                    this.Table.Refresh();
                }
            }
            #endregion
            
            #region DisplayPlayer()
            /// <summary>
            /// This method Display Player
            /// </summary>
            internal void DisplayPlayer()
            {
                // locals
                string name = "";
                bool showComputerIcon = false;
                
                // If the Player object exists
                if (this.HasPlayer)
                {
                    // set the name
                    name = this.Player.Name;
                    showComputerIcon = this.Player.IsComputerPlayer;

                    // if this player is sitting out
                    if (this.Player.SittingOut)
                    {
                        // Append sitting out
                        name += " (Out)";
                    }
                }

                // display the PlayerName
                this.PlayerNameLabel.Text = name;
                this.ComputerIcon.Visible = showComputerIcon;
                
                // Display the Chips
                DisplayChipBalance();
            }
            #endregion

            #region GetBetAmount()
            /// <summary>
            /// This method returns the Bet Amount
            /// </summary>
            internal double GetBetAmount()
            {
                // initial value
                double betAmount = 0;
                
                // Remove any dollar signs or commas if present
                string betAmountText = this.BetAmountTextBox.Text.Replace("$", "").Replace(",", "");
                
                // set the return value
                betAmount = NumericHelper.ParseInteger(betAmountText, 0, -1);
               
                // return value
                return betAmount;
            }
            #endregion
            
            #region GetChipsPanelHeight()
            /// <summary>
            /// This method returns the ChipsPanel Height
            /// </summary>
            internal int GetChipsPanelHeight()
            {
                // initial value
                int chpsPanelHeight = 0;

                // if the ChipsPanel exists
                if (NullHelper.Exists(this.ChipsPanel))
                {
                    // Set the return value
                    chpsPanelHeight = this.ChipsPanel.Height;
                }

                // return the height of the ChipsPanel
                return chpsPanelHeight;
            }
            #endregion

            #region GetPlayerInfoPanelHeight()
            /// <summary>
            /// This method returns the Bottom Panel Height
            /// </summary>
            internal int GetPlayerInfoPanelHeight()
            {
                // initial value
                int playerInfoPanelHeight = 0;

                // if the PlayerInfoPanel exists
                if (NullHelper.Exists(this.PlayerInfoPanel))
                {
                    // Set the return value
                    playerInfoPanelHeight = this.PlayerInfoPanel.Height;
                }

                // return the height of the PlayerInfoPanel
                return this.PlayerInfoPanel.Height;
            }
            #endregion
            
            #region HideBetControls()
            /// <summary>
            /// This method Hide Bet Controls
            /// </summary>
            internal void HideBetControls()
            {
                // hide the bet controls
                this.ChipSelectorButton.Visible = false;
                this.BetAmountTextBox.Visible = false;
            }
            #endregion
            
            #region PrepareForNewHand()
            /// <summary>
            /// This method Prepare For New Hand
            /// </summary>
            internal void PrepareForNewHand()
            {
                // Restore the LeftBetPanel
                this.LeftBetPanel.Visible = true;
                this.BetAmountTextBox.Text = "$0";
                this.AmountWageredLabel.Visible = false;
                this.ChipsHostControl.Chips = null;
                this.ChipsHostControl.Visible = false;

                // if the value for isComputerPlayer is true
                this.ChipSelectorButton.Visible =false;
                this.LeftBetPanel.Width = 140;
                this.BetAmountTextBox.Visible = false;

                // Clear the Cards
                this.CardContainerControl.Clear();
            }
            #endregion
            
            #region PromptForBet()
            /// <summary>
            /// This method Prompt For Bet
            /// </summary>
            internal void PromptForBet()
            {
                // Setup the controls
                this.AmountWageredLabel.Visible = false;
                this.LeftBetPanel.Visible = true;
                this.BetPanel.Visible = true;
                this.BetAmountTextBox.Visible = true;
                this.ChipsHostControl.Visible = false;
                this.ChipsPanel.Visible = false;
                this.ChipSelectorButton.Visible = true;
                this.CardContainerControl.Visible = false;
                
                // if the Player exists
                if ((this.HasPlayer) && (this.Player.HasLastBetAmount))
                {
                    // Display the last bet
                    this.BetAmountTextBox.Text = "$" + String.Format("{0:n0}", this.Player.LastBetAmount);
                }
                else
                {
                    // Erase the textbox
                    this.BetAmountTextBox.Text = String.Empty;
                }

                // Set Focus to the TextBox
                this.BetAmountTextBox.Focus();
            }
            #endregion

            #region ShowActionMessage(string message)
            /// <summary>
            /// This method returns the Action Message
            /// </summary>
            internal void ShowActionMessage(string message)
            {
                // Show the Action Message
                this.ActionLabel.Text = message;
            }
            #endregion
            
            #region ShowAmountWagered(double amountWagered)
            /// <summary>
            /// This method returns the Bet Amount
            /// </summary>
            internal void ShowAmountWagered(double amountWagered)
            {
                // Hide the items in the way
                this.LeftBetPanel.Visible = false;
                this.BetAmountTextBox.Visible = false;
                this.ChipsHostControl.Visible = true;
                this.ChipSelectorButton.Visible = false;
                this.ChipsHostControl.Dock = DockStyle.Fill;
                this.ChipSelectorButton.Visible = false;

                // Display the text of the label
                this.AmountWageredLabel.Text = "$" + String.Format("{0:n0}", amountWagered);
                this.AmountWageredLabel.Visible = true;

                // Get the chips
                List<ImageEx> chips = ChipFactory.GetChipImages(amountWagered);

                // If the Table object exists
                if (this.HasTable)
                {
                    // If the chips collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(chips))
                    {
                        // Display the chips
                        this.ChipsHostControl.Chips = chips;
                    }

                    // Update everything so the controls show
                    this.Table.RefreshUI();
                }
            }
            #endregion
            
            #region ShowInsuranceIcon(bool tookInsurance)
            /// <summary>
            /// This method returns the Insurance Icon
            /// </summary>
            internal void ShowInsuranceIcon(bool tookInsurance)
            {
                // Show or hide the icon
                this.InsuranceIcon.Visible = tookInsurance;
            }
            #endregion
            
        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

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
                    if (Table != null)
                    {
                        // set the return value
                        gameManager = (GameManager)Table.GameManager;
                    }

                    // return value
                    return gameManager;
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
            
            #region HasPlayerIndex
            /// <summary>
            /// This property returns true if the 'PlayerIndex' is set.
            /// </summary>
            public bool HasPlayerIndex
            {
                get
                {
                    // initial value
                    bool hasPlayerIndex = (this.PlayerIndex >= 0);
                    
                    // return value
                    return hasPlayerIndex;
                }
            }
            #endregion
            
            #region HasSeatNumber
            /// <summary>
            /// This property returns true if this object has a 'SeatNumber'.
            /// </summary>
            public bool HasSeatNumber
            {
                get
                {
                    // initial value
                    bool hasSeatNumber = (this.SeatNumber != SeatNumberEnum.NotSeated);
                    
                    // return value
                    return hasSeatNumber;
                }
            }
            #endregion
            
            #region HasTable
            /// <summary>
            /// This property returns true if this object has a 'Table'.
            /// </summary>
            public bool HasTable
            {
                get
                {
                    // initial value
                    bool hasTable = (this.Table != null);
                    
                    // return value
                    return hasTable;
                }
            }
            #endregion
            
            #region Player
            /// <summary>
            /// This property gets or sets the value for 'Player'.
            /// </summary>
            public Player Player
            {
                get 
                { 
                    // initial value
                    Player player = null;

                    // if the GameManager exists and the SeatNumber is set
                    if ((this.HasGameManager) && (this.HasSeatNumber))
                    {
                        // verify the value is in range
                        if ((this.HasPlayerIndex) && (this.PlayerIndex < this.GameManager.Players.Count))
                        {
                            // Get the player at this index
                            player = this.GameManager.Players[this.PlayerIndex];
                        }
                    }

                    // return the player
                    return player; 
                }
            }
            #endregion

            #region PlayerIndex
            /// <summary>
            /// This read only property returns the SeatNumber - 1, which is the PlayerIndex
            /// </summary>
            public int PlayerIndex
            {
                get
                {
                    // initial value
                    int playerIndex = 0;
                    
                    // if the GameManager exists
                    if ((this.HasGameManager) && (this.GameManager.HasPlayers))
                    {
                        // set the PlayerIndex
                        playerIndex = (int) this.SeatNumber - 1;
                    }
                    
                    // return value
                    return playerIndex;
                }
            }
            #endregion
            
            #region SeatNumber
            /// <summary>
            /// This property gets or sets the value for 'SeatNumber'.
            /// </summary>
            public SeatNumberEnum SeatNumber
            {
                get { return seatNumber; }
                set { seatNumber = value; }
            }
            #endregion
            
            #region Table
            /// <summary>
            /// This read only property casts the ParentForm as a MainForm object.
            /// </summary>
            public MainForm Table
            {
                get
                {
                    // initial value
                    MainForm table = this.ParentForm as MainForm;

                    // return value
                    return table;
                }
            }
        #endregion

        #endregion
       
    }
    #endregion

}
