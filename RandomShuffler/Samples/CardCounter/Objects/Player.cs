

#region using statements


using CardCounter.Enumerations;
using CardCounter.Interfaces;
using CardCounter.UI.Controls;
using CardCounter.Actions;
using CardCounter.Factory;
using DataJuggler.Core.UltimateHelper;
using System.Drawing;
using DataJuggler.Core.RandomShuffler;
using DataJuggler.Core.RandomShuffler.Objects;

#endregion

namespace CardCounter.Objects
{

    #region class Player
    /// <summary>
    /// This class represents a player for the game of black jack.
    /// The Dealer is also a player, but when the IsDealer property
    /// is set to true the Dealer must play by a certain set of rules
    /// such as: 
    /// 1. A Dealer always hits on 16 or less where a player has an option.
    /// 2. Depending on the option for Dealer Must Hit Soft 17 the
    ///     dealer may or may not have to hit a soft (6 - Ace) 17.
    /// </summary>
    public class Player
    {
        
        #region Private Variables
        private string name;
        private double chips;
        private bool isDealer;
        private bool isComputerPlayer;
        private SeatNumberEnum seatNumber;
        private ICardCountingSystem cardCountingSystem;
        private bool sittingOut;
        private BlackJackPlayerControl playerControl;
        private DealerCardContainerControl dealerControl;
        private Hand currentHand;
        private double lastBetAmount;
        #endregion

        #region Constructor

            #region DefaultConstructor
            /// <summary>
            /// Create a player and designate that player as the dealer or not.
            /// </summary>
            /// <param name="isDealer"></param>
            public Player(bool isDealer = false)
            {
                // Create a player and designate that player as the dealer or not.
                this.IsDealer = isDealer;

                // If the value for the property this.IsDealer is true
                if (this.IsDealer)
                {
                    // Set the name to Dealer
                    this.Name = "Dealer";
                }
            }
            #endregion

            #region Parameterized Constructor(string name, double chips, bool isComputerPlayer, BlackJackPlayerControl1 playerControl)
            /// <summary>
            /// Create a new instance of a Player object
            /// </summary>
            /// <param name="name">The name of this player</param>
            /// <param name="chips">The chips on the table for this player.</param>
            /// <param name="isComputerPlayer">Is this a human (false) or a computer player (true)</param>
            public Player(string name, double chips, bool isComputerPlayer, BlackJackPlayerControl playerControl)
            {
                // store the arguments
                this.Name = name;
                this.Chips = chips;
                this.IsComputerPlayer = isComputerPlayer;
                this.PlayerControl = playerControl;
            }
            #endregion

        #endregion

        #region Methods

            #region IsInHand()
            /// <summary>
            /// This method returns the Valid Table
            /// </summary>
            private bool IsInHand()
            {
                // initial value
                bool isInHand = false;

                // set the return value to true if everything that needs to exist
                isInHand = ((this.HasCurrentHand) && (this.CurrentHand.HasAmountWagered) && (this.HasPlayerControl) && (this.PlayerControl.HasTable) && (this.PlayerControl.Table.HasGameManager) && (this.PlayerControl.Table.GameManager.HasShuffler) && (!this.SittingOut));

                // return value
                return isInHand;
            }
            #endregion
            
            #region PrepareForNewHand()
            /// <summary>
            /// This method Prepare For New Hand
            /// </summary>
            internal void PrepareForNewHand()
            {
                // If the PlayerControl object exists
                if (this.HasPlayerControl)
                {
                    // Prepare the control for a new hand
                    this.PlayerControl.PrepareForNewHand();
                }
            }
            #endregion
            
            #region PromptForBet(PlayerResponseControl responseControl, Hand hand, Options houseRules)
            /// <summary>
            /// This method returns the For Bet
            /// </summary>
            internal void PromptForBet(PlayerResponseControl responseControl, Hand hand, Options houseRules)
            {
                // locals
                PlaceBetResponseRequest placeBetResponseRequest = null;
                PlayerResponse playerResponse = null;
                double amountWagered = 0;

                // If the responseControl object exists
                if ((NullHelper.Exists(responseControl)) && (responseControl.HasResponseRequest))
                {
                    // get a local copy so the type is shorter
                    placeBetResponseRequest = responseControl.ResponseRequest as PlaceBetResponseRequest;

                    // if the responseRequest exists
                    if (NullHelper.Exists(placeBetResponseRequest))
                    {
                        // if this is a computer player
                        if (this.IsComputerPlayer)
                        {  
                            // if the SendResponseCallBack exists
                            if (responseControl.HasSendResponseCallBack)
                            {
                                // To Do: Create a computer logic, this is just a stub for now
                                amountWagered = placeBetResponseRequest.TableMinimum * 7;

                                // If the PlayerControl object exists
                                if (this.HasPlayerControl)
                                {
                                    // Show the amount the computer player bet
                                    this.PlayerControl.ShowAmountWagered(amountWagered);
                                }

                                // Create the PlayerResponse
                                playerResponse = new PlayerResponse(ResponseTypeEnum.PlaceBet, amountWagered);      

                                // Set the responseCallBack
                                responseControl.SendResponseCallBack(playerResponse);
                            }
                        }
                        else
                        {
                            // not a computer player, this is a human the dealer must interact with

                            // If the PlayerControl object exists
                            if ((this.HasPlayerControl) && (NullHelper.Exists(responseControl)))
                            {
                                // Create a new hand
                                hand.Player = this;

                                // Show the Chip Selector and the Amount Bet TextBox
                                this.PlayerControl.PromptForBet();

                                // Create the response and cast it as a PlaceBetResponse
                                PlaceBetResponseRequest request = PlayerResponseFactory.CreatePlayerResponseRequest(ResponseRequestTypeEnum.PlaceBet, responseControl, this.PlayerControl, houseRules) as PlaceBetResponseRequest;

                                // if the request exists
                                if (NullHelper.Exists(request))
                                {
                                    // Setup the Response before showing
                                    responseControl.ResponseRequest = request;

                                    // Prompt the user for a response
                                    playerResponse = request.Start(responseControl, this.PlayerControl);
                                }
                            }
                            else
                            {
                                // this must be sitting out
                                hand.SittingOut = true;
                                hand.Player.SittingOut = true;
                            }
                        }
                    }
                    else
                    {
                        // Without a ResponseRequest they are sitting out
                        this.SittingOut = true;
                        hand.Player.SittingOut = true;
                    }
                }

                // Change the status of this player if it changed
                this.SittingOut = hand.SittingOut;
            }
            #endregion
            
            #region PromptPlayersForInsurance(IPlayerResponseRequest takeInsuranceRequest)
            /// <summary>
            /// This method returns the For Insurance
            /// </summary>
            internal void PromptForInsurance(IPlayerResponseRequest takeInsuranceRequest)
            {
                // verify this player is in this hand (has a hand and the GameMagager.Shuffler exists)
                bool isInHand = IsInHand();

                // If this player is dealt in
                if ((isInHand) && (this.HasPlayerControl) && (this.PlayerControl.HasTable))
                {
                    // if this is a computer player
                    if (this.IsComputerPlayer)
                    {
                        // Find the Shuffler to use
                        RandomShuffler chipShuffler = this.PlayerControl.Table.ChipShuffler;

                        // if the Shuffler exists
                        if ((chipShuffler.HasRandomIntStorage) && (chipShuffler.CanPullNextItem()))
                        {
                            // get a randomIntValue
                            int randomIntValue = chipShuffler.PullNextItem(false);

                            // Take Insurance if the random value is an even number
                            bool takeInsurance = ((randomIntValue % 2) == 0);

                            // Send the response
                            PlayerResponse response = null;

                            // if this player choose to takeInsurance
                            if (takeInsurance)
                            {
                                // the player choose to take insurance

                                // Create a response this player took insurance
                                response = new PlayerResponse(ResponseTypeEnum.Insurance, this.CurrentHand.AmountWagered / 2);

                                // This was an insurance request
                                response.ResponseRequestType = ResponseRequestTypeEnum.Insurance;

                                // Get a reference to the PlayerResponseControl
                                PlayerResponseControl playerResponseControl = this.PlayerControl.Table.GetPlayerResponseControl();

                                // If the playerResponseControl object exists
                                if (NullHelper.Exists(playerResponseControl))
                                {
                                    // If the value for the property playerResponseControl.HasSendResponseCallBack is true
                                    if (playerResponseControl.HasSendResponseCallBack)
                                    {
                                        // Send the response back
                                        playerResponseControl.SendResponseCallBack(response);
                                    }
                                }
                            }
                            else
                            {
                                // the player declined taking insurance

                                // Create a response this player took insurance
                                response = new PlayerResponse(ResponseTypeEnum.No);

                                // This was an insurance request
                                response.ResponseRequestType = ResponseRequestTypeEnum.Insurance;

                                // Get a reference to the PlayerResponseControl
                                PlayerResponseControl playerResponseControl = this.PlayerControl.Table.GetPlayerResponseControl();

                                // If the playerResponseControl object exists
                                if (NullHelper.Exists(playerResponseControl))
                                {
                                    // If the value for the property playerResponseControl.HasSendResponseCallBack is true
                                    if (playerResponseControl.HasSendResponseCallBack)
                                    {
                                        // Send the response back
                                        playerResponseControl.SendResponseCallBack(response);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        // This is a human so start the ResponseRequest
                        takeInsuranceRequest.Start(this.PlayerControl.Table.GameManager.ResponseControl, this.PlayerControl);
                    }
                }
            }
            #endregion
            
            #region ShowCards()
            /// <summary>
            /// This method returns the Card
            /// </summary>
            internal void ShowCards()
            {
                // If the card object exists and the PlayerControl exists
                if ((this.HasPlayerControl) && (this.HasCurrentHand) && (this.CurrentHand.HasCards) && (!this.SittingOut))
                {
                    // Now display this card
                    this.PlayerControl.DisplayCards(this.CurrentHand.Cards);

                    // if the PlayerControl.Table exists
                    if (this.PlayerControl.HasTable)
                    {
                        // Refresh the UI so the cards show up
                        this.PlayerControl.Table.Refresh();
                    }
                }
            }
            #endregion
            
            #region ShowDealersCards()
            /// <summary>
            /// This method Show Dealers Cards
            /// </summary>
            internal void ShowDealersCards()
            {
                // If the card object exists and the PlayerControl exists
                if ((this.HasDealerControl) && (this.HasCurrentHand) && (this.CurrentHand.HasCards))
                {
                    // Show the Dealers cards
                    this.DealerControl.Visible = true;

                    // Now display this card
                    this.DealerControl.DisplayCards(this.CurrentHand.Cards);

                    // if the PlayerControl.Table exists
                    if (this.DealerControl.HasTable)
                    {
                        // Refresh the UI so the cards show up
                        this.DealerControl.Table.Refresh();
                    }
                }
            }
            #endregion
            
            #region ToString()
            /// <summary>
            /// This method returns the String
            /// </summary>
            public override string ToString()
            {
                // return the name of this play
                return this.Name;
            }
            #endregion
            
        #endregion

        #region Properties

            #region CardCountingSystem
            /// <summary>
            /// This property gets or sets the value for 'CardCountingSystem'.
            /// </summary>
            public ICardCountingSystem CardCountingSystem
            {
                get { return cardCountingSystem; }
                set { cardCountingSystem = value; }
            }
            #endregion
            
            #region Chips
            /// <summary>
            /// This property gets or sets the value for 'Chips'.
            /// </summary>
            public double Chips
            {
                get { return chips; }
                set { chips = value; }
            }
            #endregion
            
            #region CurrentHand
            /// <summary>
            /// This property gets or sets the value for 'CurrentHand'.
            /// </summary>
            public Hand CurrentHand
            {
                get { return currentHand; }
                set 
                {
                    // set the value
                    currentHand = value;
                }
            }
            #endregion
            
            #region DealerControl
            /// <summary>
            /// This property gets or sets the value for 'DealerControl'.
            /// </summary>
            public DealerCardContainerControl DealerControl
            {
                get { return dealerControl; }
                set { dealerControl = value; }
            }
            #endregion
            
            #region HasCardCountingSystem
            /// <summary>
            /// This property returns true if this object has a 'CardCountingSystem'.
            /// </summary>
            public bool HasCardCountingSystem
            {
                get
                {
                    // initial value
                    bool hasCardCountingSystem = (this.CardCountingSystem != null);
                    
                    // return value
                    return hasCardCountingSystem;
                }
            }
            #endregion
            
            #region HasCurrentHand
            /// <summary>
            /// This property returns true if this object has a 'CurrentHand'.
            /// </summary>
            public bool HasCurrentHand
            {
                get
                {
                    // initial value
                    bool hasCurrentHand = (this.CurrentHand != null);
                    
                    // return value
                    return hasCurrentHand;
                }
            }
            #endregion
            
            #region HasDealerControl
            /// <summary>
            /// This property returns true if this object has a 'DealerControl'.
            /// </summary>
            public bool HasDealerControl
            {
                get
                {
                    // initial value
                    bool hasDealerControl = (this.DealerControl != null);
                    
                    // return value
                    return hasDealerControl;
                }
            }
            #endregion
            
            #region HasLastBetAmount
            /// <summary>
            /// This property returns true if the 'LastBetAmount' is set.
            /// </summary>
            public bool HasLastBetAmount
            {
                get
                {
                    // initial value
                    bool hasLastBetAmount = (this.LastBetAmount > 0);
                    
                    // return value
                    return hasLastBetAmount;
                }
            }
            #endregion
            
            #region HasPlayerControl
            /// <summary>
            /// This property returns true if this object has a 'PlayerControl'.
            /// </summary>
            public bool HasPlayerControl
            {
                get
                {
                    // initial value
                    bool hasPlayerControl = (this.PlayerControl != null);
                    
                    // return value
                    return hasPlayerControl;
                }
            }
            #endregion
            
            #region IsComputerPlayer
            /// <summary>
            /// This property gets or sets the value for 'IsComputerPlayer'.
            /// </summary>
            public bool IsComputerPlayer
            {
                get { return isComputerPlayer; }
                set { isComputerPlayer = value; }
            }
            #endregion
            
            #region IsDealer
            /// <summary>
            /// This property gets or sets the value for 'IsDealer'.
            /// </summary>
            public bool IsDealer
            {
                get { return isDealer; }
                set { isDealer = value; }
            }
            #endregion
                        
            #region LastBetAmount
            /// <summary>
            /// This property gets or sets the value for 'LastBetAmount'.
            /// </summary>
            public double LastBetAmount
            {
                get { return lastBetAmount; }
                set { lastBetAmount = value; }
            }
            #endregion
            
            #region Name
            /// <summary>
            /// This property gets or sets the value for 'Name'.
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            #endregion
            
            #region PlayerControl
            /// <summary>
            /// This property gets or sets the value for 'PlayerControl'.
            /// </summary>
            public BlackJackPlayerControl PlayerControl
            {
                get { return playerControl; }
                set { playerControl = value; }
            }
            #endregion
            
            #region Seated
            /// <summary>
            /// This property gets or sets the value for 'Seated'.
            /// </summary>
            public bool Seated
            {
                get 
                { 
                    // initial value
                    bool seated = (this.SeatNumber != SeatNumberEnum.NotSeated);

                    // return value
                    return seated;
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
            
            #region SittingOut
            /// <summary>
            /// This property gets or sets the value for 'SittingOut'.
            /// </summary>
            public bool SittingOut
            {
                get { return sittingOut; }
                set { 
                        // set the value
                        sittingOut = value; 

                        // if sitting out
                        if (sittingOut)
                        {
                            // break point only
                            sittingOut = !(!sittingOut);
                        }
                    }
            }
            #endregion

            #region TookInsurance
            /// <summary>
            /// This property gets or sets the value for 'TookInsurance'.
            /// </summary>
            public bool TookInsurance
            {
                get
                {
                    // initial value
                    bool tookInsurance = false;

                    // if the CurrentHand exists
                    if (this.HasCurrentHand)
                    {
                        // set the return value
                        tookInsurance = (bool) CurrentHand.TookInsurance;
                    }

                    // return value
                    return tookInsurance;
                }
                set
                {
                    // if the CurrentHand exists
                    if (HasCurrentHand)
                    {
                        // set the value
                        CurrentHand.TookInsurance = value;
                    }
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
