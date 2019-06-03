

#region using statements

using CardCounter.Enumerations;
using CardCounter.Objects;
using CardCounter.Security;
using CardCounter.UI.Controls;
using DataJuggler.Core.UltimateHelper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataJuggler.Core.RandomShuffler;

#endregion

namespace CardCounter.UI.Forms
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm for this application.
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        private GameManager gameManager;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a MainForm object
        /// </summary>
        public MainForm()
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
            
            #region DataJugglerButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'DataJugglerButton' is clicked.
            /// </summary>
            private void DataJugglerButton_Click(object sender, EventArgs e)
            {
                // Send the user to my website
                System.Diagnostics.Process.Start("http://www.datajuggler.com");
            }
            #endregion
            
            #region DataJugglerButton_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Data Juggler Button _ Mouse Leave
            /// </summary>
            private void DataJugglerButton_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region MainForm_FormClosed(object sender, FormClosedEventArgs e)
            /// <summary>
            /// This event is fired when Main Form _ Form Closed
            /// </summary>
            private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
            {
                // End this program
                Environment.Exit(0);
            }
            #endregion
            
            #region MainForm_Load(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Main Form _ Load
            /// </summary>
            private void MainForm_Load(object sender, EventArgs e)
            {
                // call resize now that everything is loaded
                MainForm_Resize(this, new EventArgs());

                // Handle the options being shown and applied
                // this seats the players
                HandleOptions();

                // if the GameManager exists
                if (this.HasGameManager)
                {
                    // Setup the ShufflintgCallBack
                    this.GameManager.ShufflingCallBack = this.ShowShufflingAnimation; 

                    // Setup the RefreshMethod
                    this.GameManager.RefreshMethod = this.RefreshUI;
                }

                // if the HouseRules exist
                if ((this.HasHouseRules) && (this.HouseRules.GameSpeed != GameSpeedEnum.Manuel_Deal))
                {  
                    // Start Dealing
                    StartDealing();
                }
            }
            #endregion
            
            #region MainForm_Resize(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the MainForm Resizes
            /// </summary>
            private void MainForm_Resize(object sender, System.EventArgs e)
            {
                // ensure not minimized
                if (this.WindowState != FormWindowState.Minimized)
                {
                    // get the width of this Form
                    int center = MainPanel.Width / 2;

                    // adjust the center
                    center = (int) (center - (MainPanel.Width * .05));

                    // locals
                    int controlHeight =BlackJackPlayerControl1.Height;
                    int controlWidth = BlackJackPlayerControl1.Width;
                    int totalSpaceForAllMargins = MainPanel.Width - (controlWidth * 5);

                    // - 24 to create a little more room on each side
                    int margin = (totalSpaceForAllMargins / 6) - 24;
                    int halfControlWidth = controlWidth / 2;
                    int halfControlHeight = controlHeight / 2;
                    int vMargin = 28;
                    
                    // Get the vertical center
                    int vCenter = MainPanel.Height / 2;

                    // Set the Lefts
                    this.BlackJackPlayerControl1.Left = center - halfControlWidth - margin - controlWidth - margin -controlWidth;
                    this.BlackJackPlayerControl2.Left = center - halfControlWidth - margin - controlWidth;
                    this.BlackJackPlayerControl3.Left = center - halfControlWidth;
                    this.BlackJackPlayerControl4.Left = center + halfControlWidth + margin;
                    this.BlackJackPlayerControl5.Left = center + halfControlWidth + margin + controlWidth + margin;

                    // Set the Tops
                    this.BlackJackPlayerControl1.Top = vCenter - halfControlHeight + vMargin;
                    this.BlackJackPlayerControl2.Top = vCenter - halfControlHeight + 80 + vMargin;
                    this.BlackJackPlayerControl3.Top = vCenter - halfControlHeight + 160 + vMargin;
                    this.BlackJackPlayerControl4.Top = this.BlackJackPlayerControl2.Top;
                    this.BlackJackPlayerControl5.Top = this.BlackJackPlayerControl1.Top;
                    
                    // Center the Shuffling Animation Control
                    this.ShufflingAnimationControl.Left = center - (ShufflingAnimationControl.Width / 2);
                    this.ShufflingAnimationControl.Top = (int) (MainPanel.Height * .212);

                    // Position the Dealers Cards
                    this.DealerCardContainerControl.Left = center - (DealerCardContainerControl.Width / 2);
                }
            }
            #endregion
            
        #endregion        

        #region Methods

            #region CreateDefaultPlayers(Options houseRules)
            /// <summary>
            /// This method returns a list of Default Players
            /// </summary>
            private List<Player> CreateDefaultPlayers(Options houseRules)
            {
                // initial value
                List<Player> players = new List<Player>();

                // Create each computer player
                Player computerPlayer1 = CreatePlayer(houseRules.DefaultComputerBankRoll, true, 1, 1);
                Player computerPlayer2 = CreatePlayer(houseRules.DefaultComputerBankRoll, true, 2, 2);
                Player computerPlayer3 = CreatePlayer(houseRules.DefaultComputerBankRoll, true, 4, 3);
                Player computerPlayer4 = CreatePlayer(houseRules.DefaultComputerBankRoll, true, 5, 4);

                // The human player is seated in the middle (seat 3)
                Player humanPlayer = CreatePlayer(houseRules.DefaultBankRoll, false, 3, 0);
                
                // now add each player
                players.Add(computerPlayer1);
                players.Add(computerPlayer2);
                players.Add(humanPlayer);
                players.Add(computerPlayer3);
                players.Add(computerPlayer4);

                // return value
                return players;
            }
            #endregion

            #region CreatePlayer(double bankRoll, bool computerPlayer, int seatNumber, int computerPlayerNumber, bool isDealer = false)
            /// <summary>
            /// This method creates a new 'Player' object.
            /// </summary>
            private Player CreatePlayer(double bankRoll, bool computerPlayer, int seatNumber, int computerPlayerNumber, bool isDealer = false)
            {
                // initial value
                Player player = new Player();

                // Set the properties for the new player
                player.Chips = bankRoll;
                player.IsComputerPlayer = computerPlayer;
                player.IsDealer = isDealer;
                
                // set the name based upon Computer or Human Player
                if (computerPlayer)
                {  
                    // Set the Name to 'Computer Player 1' for example
                    player.Name = "Computer Player " + computerPlayerNumber.ToString();
                }
                else
                {
                    // Set the Name to 'Human Player 1' for example
                    player.Name = "Human Player";
                }

                // Set the SeatNumber
                player.SeatNumber = (SeatNumberEnum) seatNumber;

                // return value
                return player;
            }
            #endregion

            #region FindBlackJackPlayerControl(SeatNumberEnum seatNumber)
            /// <summary>
            /// This method returns the Black Jack Player Control
            /// </summary>
            private BlackJackPlayerControl FindBlackJackPlayerControl(SeatNumberEnum seatNumber)
            {
                // initial value
                BlackJackPlayerControl blackJackPlayerControl = null;

                // Determine the action by the seatNumber
                switch (seatNumber)
                {
                    case SeatNumberEnum.Seat1:

                        // set the control
                        blackJackPlayerControl = this.BlackJackPlayerControl1;

                        // required
                        break;

                    case SeatNumberEnum.Seat2:

                        // set the control
                        blackJackPlayerControl = this.BlackJackPlayerControl2;

                        // required
                        break;

                    case SeatNumberEnum.Seat3:

                        // set the control
                        blackJackPlayerControl = this.BlackJackPlayerControl3;

                        // required
                        break;

                    case SeatNumberEnum.Seat4:

                        // set the control
                        blackJackPlayerControl = this.BlackJackPlayerControl4;

                        // required
                        break;

                    case SeatNumberEnum.Seat5:

                        // set the control
                        blackJackPlayerControl = this.BlackJackPlayerControl5;

                        // required
                        break;
                }

                // return value
                return blackJackPlayerControl;
            }
            #endregion
            
            #region GetDealerControl()
            /// <summary>
            /// This method returns the Dealer Control
            /// </summary>
            internal UI.Controls.DealerCardContainerControl GetDealerControl()
            {
                // return the Dealers Card                                    
                return this.DealerCardContainerControl;
            }
            #endregion
            
            #region GetPlayerControls()
            /// <summary>
            /// This method returns a list of Player Controls
            /// </summary>
            private List<BlackJackPlayerControl> GetPlayerControls()
            {
                // initial value
                List<BlackJackPlayerControl> playerControls = new List<BlackJackPlayerControl>();

                // Add each control
                playerControls.Add(this.BlackJackPlayerControl1);
                playerControls.Add(this.BlackJackPlayerControl2);
                playerControls.Add(this.BlackJackPlayerControl3);
                playerControls.Add(this.BlackJackPlayerControl4);
                playerControls.Add(this.BlackJackPlayerControl5);

                // return value
                return playerControls;
            }
            #endregion
            
            #region GetPlayerResponseControl()
            /// <summary>
            /// This method returns the Player Response Control
            /// </summary>
            internal PlayerResponseControl GetPlayerResponseControl()
            {
                // initial value
                PlayerResponseControl responseControl = this.PlayerResponseControl;

                // return value
                return responseControl;
            }
            #endregion
            
            #region GetShufflingAnimationControl()
            /// <summary>
            /// This method returns the Shuffling Animation Control
            /// </summary>
            internal ShufflingAnimationControl GetShufflingAnimationControl()
            {
                // return the ShufflingAnimationControl
                return this.ShufflingAnimationControl;
            }
            #endregion
            
            #region HandleOptions()
            /// <summary>
            /// This method Handle Options
            /// </summary>
            internal void HandleOptions()
            {
                // Set the Game Options
                this.GameManager = LoadGameManager();

                // if the GameManager exists
                if (this.HasGameManager)
                {
                    // iterate the players
                    foreach (Player player in this.GameManager.Players)
                    {
                        // Find the blackJackPlayerControl at this seat number
                        BlackJackPlayerControl blackJackPlayerControl = FindBlackJackPlayerControl(player.SeatNumber);

                        // If the blackJackPlayerControl object exists
                        if (NullHelper.Exists(blackJackPlayerControl))
                        {
                            // Setup the blackJackPlayerControl
                            blackJackPlayerControl.DisplayPlayer();
                        }
                    }

                    // Show or hide controls based upon the number of players
                    UIVisibility();
                }
            }
            #endregion
            
            #region LoadGameManager()
            /// <summary>
            /// This method returns the GameManager. It first attempts to load the values from the settings
            /// and if not found the default GameManager.Options and GameManager.Players are created.
            /// </summary>
            private GameManager LoadGameManager()
            {
                // initial value
                GameManager gameManager = null;

                // local so the Settings file only has to be loaded once
                SecureUserData security = new SecureUserData();

                // this is used during development so everything default is restored, this has to be taken out or commented out
                // security.LastSavedDate = new DateTime(1900, 1, 1);

                // save (this needs to be taken out or commented out also)
                // security.Save();

                // We must load our five PlayerControls
                List<BlackJackPlayerControl> playerControls = GetPlayerControls();

                // if the security object has a LastSavedDate we can load a GameManager from it
                if (security.HasLastSavedDate)
                {
                    // convert the settings to a gameManager object
                    gameManager = SecureUserDataFactory.Export(security, playerControls, this);
                }
                else
                {
                    // Create a new instance of a 'GameManager' object.
                    gameManager = new GameManager(NumericHelper.ParseInteger(Properties.Resources.TimesToShuffle, 0, -1), this);

                    // Now we must load the Options and Players from the Settings
                    gameManager.HouseRules = Options.CreateDefault();

                    // Load the players from the Settings or create them
                    gameManager.Players = CreateDefaultPlayers(gameManager.HouseRules);
                }

                //// Create a new instance of an 'OptionsForm' object.
                OptionsForm optionsForm = new OptionsForm(this);

                // Setup the form
                optionsForm.Setup(gameManager);

                //// Show the dialog
                optionsForm.ShowDialog();

                // if the user did not cancel
                if (!optionsForm.UserCancelled)
                {
                    // set the return value
                    this.GameManager = optionsForm.GameManager;
                }
                else
                {
                    // if the GameManager does not exist
                    if (!this.HasGameManager)
                    {
                        // Close this app
                        Environment.Exit(0);
                    }
                }

                // return value
                return gameManager;
            }
            #endregion
            
            #region LoadPlayersFromSettings()
            /// <summary>
            /// This method returns a list of Players From Settings
            /// </summary>
            private List<Player> LoadPlayersFromSettings()
            {
                // initial value
                List<Player> players = null;
                
                // return value
                return players;
            }
            #endregion

            #region PayOffBet(SeatNumberEnum seatNumber, double lastBetAmount, bool isBlackJack = false)
            /// <summary>
            /// method pays Off player's Bet
            /// </summary>
            internal void PayOffBet(SeatNumberEnum seatNumber, double lastBetAmount, bool isBlackJack = false)
            {
                
            }
            #endregion
            
            #region RefreshUI()
            /// <summary>
            /// This method refresh this user interface and the application
            /// </summary>
            public void RefreshUI()
            {
                // Refresh everything
                this.Refresh();
                Application.DoEvents();
            }
            #endregion

            #region ShowActionMessage(string message, SeatNumberEnum seatNumber)
            /// <summary>
            /// This method shows an Action Message
            /// </summary>
            internal void ShowActionMessage(string message, SeatNumberEnum seatNumber)
            {
                // Find the playerControl
                BlackJackPlayerControl playerControl = FindBlackJackPlayerControl(seatNumber);

                // If the playerControl object exists
                if (NullHelper.Exists(playerControl))
                {
                    // Show the action message
                    playerControl.ShowActionMessage(message);
                }
            }
            #endregion
            
            #region ShowShufflingAnimation(bool showAnimationControl)
            /// <summary>
            /// This method Deal
            /// </summary>
            internal void ShowShufflingAnimation(bool showAnimationControl)
            {
                // if the value for showAnimationControl is true
                if (showAnimationControl)
                {
                    // Show the Shuffle Animation Control
                    this.ShufflingAnimationControl.HideAtEnd();
                    this.ShufflingAnimationControl.Visible = true;
                    this.ShufflingAnimationControl.Refresh();
                    this.Refresh();
                }
                else
                {
                    // Hide the control when the end is reached
                    this.ShufflingAnimationControl.HideAtEnd();

                    // The shuffling is actually much faster than the animation is displayed unless
                    // you shuffle thousands of times. For a faster shuffle change the above line to:
                    // this.ShufflingAnimationControl.Visible = false; 
                }
            }
            #endregion

            #region Shuffle()
            /// <summary>
            /// This method Shuffle
            /// </summary>
            internal void Shuffle()
            {
                if (this.HasGameManager)
                {
                    // Request a new shuffle at the end of the current hand
                    this.GameManager.RequestNewShuffle();
                }
            }
            #endregion
            
            #region StartDealing()
            /// <summary>
            /// This method Start Dealing
            /// </summary>
            internal void StartDealing()
            {
                // If the GameManager object exists
                if (this.HasGameManager)
                {
                    // Setup the CallBackDelegate
                    this.PlayerResponseControl.SendResponseCallBack = GameManager.ReceiveResponse;

                    // Start dealing
                    this.GameManager.StartDealing();
                }
            }
        #endregion

            #region UIVisibility()
            /// <summary>
            /// This method UI Visibility
            /// </summary>
            private void UIVisibility()
            {
                // Show the control if it has a player
                this.BlackJackPlayerControl1.Visible = this.BlackJackPlayerControl1.HasPlayer;
                this.BlackJackPlayerControl2.Visible = this.BlackJackPlayerControl2.HasPlayer;
                this.BlackJackPlayerControl3.Visible = this.BlackJackPlayerControl3.HasPlayer;
                this.BlackJackPlayerControl4.Visible = this.BlackJackPlayerControl4.HasPlayer;
                this.BlackJackPlayerControl5.Visible = this.BlackJackPlayerControl5.HasPlayer;
            }
            #endregion
            
        #endregion

        #region Properties

            #region ChipShuffler
            /// <summary>
            /// This property gets or sets the value for 'ChipShuffler'.
            /// </summary>
            public RandomShuffler ChipShuffler
            {
                get
                {
                    // initial value
                    RandomShuffler chipShuffler = null;

                    // if the control exists
                    if (GameManager != null)
                    {
                        // set the return value
                        chipShuffler = (RandomShuffler)GameManager.ChipShuffler;
                    }

                    // return value
                    return chipShuffler;
                }
                set
                {
                    // if the control exists
                    if (GameManager != null)
                    {
                        // set the value
                        GameManager.ChipShuffler = value;
                    }
                }
            }
            #endregion
            
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
                get { return gameManager; }
                set { gameManager = value; }
            }
            #endregion
            
            #region HasChipShuffler
            /// <summary>
            /// This property returns true if this object has a 'ChipShuffler'.
            /// </summary>
            public bool HasChipShuffler
            {
                get
                {
                    // initial value
                    bool hasChipShuffler = (this.ChipShuffler != null);
                    
                    // return value
                    return hasChipShuffler;
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
            
            #region HouseRules
            /// <summary>
            /// This read only property returns the houseRules from the GameManager
            /// </summary>
            public Options HouseRules
            {
                get 
                { 
                    // initial value
                    Options houseRules = null;

                    // If the GameManager object exists
                    if (this.HasGameManager)
                    {
                        // set the return value
                        houseRules = this.GameManager.HouseRules;
                    }
                    
                    // return value
                    return houseRules;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
