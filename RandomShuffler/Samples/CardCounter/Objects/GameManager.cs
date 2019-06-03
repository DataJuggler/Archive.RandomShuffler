

#region using statements

using CardCounter.Actions;
using CardCounter.Delegates;
using CardCounter.Enumerations;
using CardCounter.Interfaces;
using CardCounter.UI.Controls;
using CardCounter.UI.Forms;
using DataJuggler.Core.RandomShuffler;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic; 
using CardCounter.Factory;
using CardCounter.Util;
using System;

#endregion

namespace CardCounter.Objects
{
   
    #region class GameManager
    /// <summary>
    /// This class represents the Dealer / House (Casino)
    /// </summary>
    public class GameManager
    {
        
        #region Private Variables
        private RandomShuffler shuffler;
        private RandomShuffler chipShuffler;
        private Options houseRules;       
        private List<Player> players;
        private bool paused;
        private bool quit;
        private Player dealer;
        private List<Inning> deckHistory;
        private List<Card> cards;
        private int timesToShuffle;
        private ShowShufflingCallBack shufflingCallBack;
        private RefreshUICallBack refreshMethod;
        private MainForm table;
        private bool shufflingInProgress;
        private bool interactionWithPlayerInProgress;
        private Hand currentHand;
        private DelayManager delayManager;
        private const int DelayMilliseconds = 2500;
        private const int CardsInDeck = 52;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a GameManager object.
        /// </summary>
        public GameManager(int timesToShuffle, MainForm table)
        {
            // Set the Table
            this.Table = table;

            // Set the TimesToShuffle
            this.TimesToShuffle = timesToShuffle;

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region ShufflingAnimationControl_VisibleChanged(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when Shuffling Animation Control _ Visible Changed
            /// </summary>
            void ShufflingAnimationControl_VisibleChanged(object sender, System.EventArgs e)
            {
                // Set ShufflingInProgress to true when the control is no longer visible
                this.ShufflingInProgress = this.ShufflingAnimationControl.Visible;
            }
            #endregion
            
        #endregion

        #region Methods
            
            #region ClearLastHand()
            /// <summary>
            /// This method Clear Last Hand
            /// </summary>
            private void ClearLastHand()
            {
                // Erase the current hand
                this.CurrentHand = null;

                // Clear each player first
                // iterate the players
                foreach (Player player in this.Players)
                {
                    // Erase the current hand
                    player.CurrentHand = null;

                    // prepare the control for a new hand
                    player.PrepareForNewHand();
                }

                // if the Dealer.DealerControl exists
                if ((this.HasDealer) && (this.Dealer.HasDealerControl))
                {
                    // Clear the Dealers
                    this.Dealer.DealerControl.Clear();
                }

                // if the Table exists
                if (this.HasTable)
                {
                    // Refresh the UI
                    this.Table.RefreshUI();
                }
            }
            #endregion
            
            #region CollectAllBets()
            /// <summary>
            /// This method Collect All Bets because the Dealer has a blackjack
            /// </summary>
            private void CollectAllBets()
            {
                // iterate the Players
                foreach (Player player in this.Players)
                {
                    // if the player exists and has a bet placed and is not sitting out
                    if ((player.HasCurrentHand) && (player.CurrentHand.HasAmountWagered) && (!player.SittingOut))
                    {
                        // if this player has a currentHand
                        if (player.CurrentHand.HasBlackJack)
                        {
                            // if the player has a PlayerControl
                            if (player.HasPlayerControl)
                            {
                                
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region CompleteActionAllPlayers()
            /// <summary>
            /// This method Complete Action All Players
            /// </summary>
            private void CompleteActionAllPlayers()
            {
                // if the Dealer exists and has a hand
                if ((this.HasDealer) && (this.Dealer.HasCurrentHand))
                {
                    // verify the Players exist
                    if (this.HasPlayers)
                    {
                        // iterate the Players
                        foreach (Player player in this.Players)
                        {
                            // if the player exists and has a bet placed and is not sitting out
                            if ((player.HasCurrentHand) && (player.CurrentHand.HasAmountWagered) && (!player.SittingOut))
                            {
                                // Delay the game for a little bit
                                Delay();

                                // if the player is a computer plraers
                                if (player.IsComputerPlayer)
                                {
                                }
                                else
                                {
                                    // We are interacting with this player
                                    this.InteractionWithPlayerInProgress = true;

                                    // Set the LastActionTime
                                    this.DelayManager.LastActionTime = DateTime.Now;

                                    // Create the ResponseRequest
                                    IPlayerResponseRequest playHandResponseRequest = PlayerResponseFactory.CreatePlayerResponseRequest(ResponseRequestTypeEnum.PlayHand, this.ResponseControl, player.PlayerControl, this.HouseRules);

                                    // Start the request
                                    playHandResponseRequest.Start(this.ResponseControl, player.PlayerControl);

                                    // Wait for the Interaction with this player to finish before we move on to the next player
                                    WaitForInteractionWithPlayerToFinish();
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region CreateChipShuffler()
            /// <summary>
            /// This method returns the Shuffler to be used for chip placement, 
            /// this is not the Shuffler for dealing cards.
            /// </summary>
            private RandomShuffler CreateChipShuffler()
            {
                // initial value
                RandomShuffler shuffler = null;

                // local
                int padding = 4;

                // if there are one or more players
                if (ListHelper.HasOneOrMoreItems(this.Players))
                {
                    // if the first player has a player control
                    if (Players[0].HasPlayerControl)
                    {
                        // get a local copy
                        BlackJackPlayerControl playerControl = this.Players[0].PlayerControl;

                        // get the height of the BetPanel minus a top and bottom padding
                        int height = playerControl.GetChipsPanelHeight() - padding;
                        int minValue = padding;
                        
                        // the maxValue is lower because of the height of the control has to be 
                        // fit in the bounds of the panel it is contained in
                        int maxValue = height - padding;
                        
                        // Since we are only creating 32 items in the chipShuffler, I am creating 100 sets so there are 100 of each number
                        // in the shufflers RandomIntStorage.
                        int setsToInitialize = 100;

                        // During the constructor shuffle is called 20 times to give it a thorough shuffle; 
                        // if you are using a large number of values and it gets slow, lower this number.
                        int initialShuffles = 20;

                        // Since we are not pulling the item out of the deck, that would not be true random after the first item is pulled
                        // the value is returned, but the item pulled is left in RandomIntStorage so it can be retreived again as equally
                        // as any other item. For this it doesn't really matter, I could have done it either way, but I already have an 
                        // examply doing it this way in the Cards shuffling. The 1 means shuffle the cards 1 time before each item
                        // is pulled. This number could be higher, or it defaults to zero as it is an optional parameter.
                        int beforeItemIsPulledShuffles = 1;

                        // Now create the chipShuffler
                        shuffler = new RandomShuffler(minValue, maxValue, setsToInitialize, initialShuffles, beforeItemIsPulledShuffles);
                    }
                }

                // return vale
                return shuffler;
            }
            #endregion
            
            #region DealCardToDealer(bool faceDown)
            /// <summary>
            /// This method returns the Card To Dealer
            /// </summary>
            private void DealCardToDealer(bool faceDown)
            {
                // if the Dealer
                if (!this.HasDealer)
                {
                    // Create the Dealer
                    this.Dealer = new Player(true);

                    // Return the DealerCardContainer control from the MainForm(table)
                    this.Dealer.DealerControl = this.Table.GetDealerControl();
                }

                // if not faceDown, then this is a new hand
                if (!faceDown)
                {
                    // Create the new hand
                    this.Dealer.CurrentHand = new Hand();

                    // Create a new Player to serve as the Dealer with IsDealer set to true
                    this.Dealer.CurrentHand.Player = new Player(true);

                    // If the CurrentInning object exists
                    if (this.HasCurrentInning)
                    {
                        // Add this hand to the Inning so the DeckPenetration is linked
                        this.CurrentInning.Hands.Add(this.Dealer.CurrentHand);
                    }
                }

                // If the Shuffler object exists
                if ((this.HasShuffler) && (this.HasDealer))
                {
                    // Pull the next card from the deck
                    Card card = this.Shuffler.PullNextCard();

                    // Add this Card
                    this.Dealer.CurrentHand.Cards.Add(card);

                    // Display the cards in the players hand
                    this.Dealer.ShowDealersCards();

                    // If the Table object exists
                    if (this.HasTable)
                    {
                        // Show the players cards
                        this.Table.Refresh();
                    }
                }
            }
            #endregion
            
            #region DealCardToPlayers()
            /// <summary>
            /// This method Deal Card To Players
            /// </summary>
            private void DealCardToPlayers()
            {
               // If the Shuffler object exists
               if (this.HasShuffler)
               {
                    // iterate the list of Players                    
                    foreach (Player player in this.Players)
                    {
                         // do not interact with teh player if they are sitting out
                        if (!player.SittingOut)
                        {
                            // Slow the game down a bit
                            Delay();

                            // if this player has Hand and has placed a bet
                            if ((player.HasCurrentHand) && (player.CurrentHand.HasAmountWagered))
                            {
                                // Pull the next card from the deck
                                Card card = this.Shuffler.PullNextCard();

                                // Add this Card
                                player.CurrentHand.Cards.Add(card);

                                // Display the cards in the players hand
                                player.ShowCards();

                                // If the Table object exists
                                if (this.HasTable)
                                {
                                    // Show the players cards
                                    this.Table.Refresh();
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region DealContinuously()
            /// <summary>
            /// This method Deal Continuously
            /// </summary>
            private void DealContinuously()
            {
                // if the ChipShuffler does not exist
                if (!this.HasChipShuffler)
                {
                    // Create a random chipShuffler
                    this.ChipShuffler = CreateChipShuffler();
                }

                do
                {
                    // If the HouseRules object exists
                    if ((this.HasHouseRules) && (this.HasShuffler) && (this.TimesToShuffle > 0))
                    {
                        // Clear the last hand played
                        ClearLastHand();

                        // Shuffle it is needed
                        ShuffleIfRequired();

                        // Wait for the shuffle control to go away
                        WaitForShuffleToFinish();

                        // Deal the next hand
                        DealHand();

                        // if we are using manuel deal than only one hand is dealt and then we exit
                        if (this.HouseRules.GameSpeed == Enumerations.GameSpeedEnum.Manuel_Deal)
                        {
                            // break out of the loop
                            break;
                        }

                        // Slow the game down a bit
                        Delay((int) GameSpeedEnum.Very_Fast);
                    }

                } while (!this.Quit);
            }
            #endregion

            #region DealHand()
            /// <summary>
            /// This method Deal Hand
            /// </summary>
            internal void DealHand()
            { 
                // If the Players object exists
                if ((ListHelper.HasOneOrMoreItems(this.Players)) && (this.HasDeckHistory) && (this.HasResponseControl) && (this.HasHouseRules) && (this.HasShuffler))
                {
                    // Create a new inning and add it to history
                    NewInning();
                    
                    // Prompt the players for bets to be dealt in
                    PromptPlayersForBets();

                    // Deal the first two cards
                    DealStartingHand();

                    // Prompt any players for Insurance. This only runs if the 
                    // dealers exposed card (the second card) is an Ace.
                    PromptPlayersForInsurance();

                    // If the value for the property dealer.HasBlackJack is true
                    if (dealer.CurrentHand.HasBlackJack)
                    {
                        // Pay off any insurance bets that were made if Dealer has Blackjack
                        PayOffInsurance();

                        // Collect All Bets Unless The Player Has Blackjack also, it is a push
                        CollectAllBets();
                    }
                    else
                    {
                        // Pay Off Any BlackJacks
                        PayOffBlackJacks(false);
                    }

                    // Complete the Action for All of the players
                    CompleteActionAllPlayers();

                    // Delay for a second
                    Delay((int) GameSpeedEnum.Slow);
                }
            }
            #endregion

            #region DealStartingHand()
            /// <summary>
            /// This method Deal Starting Hand
            /// </summary>
            private void DealStartingHand()
            {
                // If the Players object exists
                if ((this.HasPlayers) && (this.HasShuffler))
                {
                    // Deal a card to each player
                    DealCardToPlayers();

                    // Deal a card to the dealer
                    DealCardToDealer(false);

                    // Deal the second card to each player
                    DealCardToPlayers();

                    // Deal the second card to the dealer
                    DealCardToDealer(true);

                }
            }
            #endregion

            #region Delay(int gamePause = 0)
            /// <summary>
            /// This method Delays the game based upon the GamePause
            /// </summary>
            private void Delay(int gamePause = 0)
            {
                // If the DelayManager object exists
                if (this.HasDelayManager)
                {
                    // if the value is not set we need to look it up
                    if (gamePause == 0)
                    {
                        // get the gamePause
                        gamePause = GetGamePause();
                    }

                    // Delay
                    this.DelayManager.Delay(gamePause);
                }
            }
            #endregion
            
            #region GetGamePause()
            /// <summary>
            /// This method returns the Game Pause
            /// </summary>
            private int GetGamePause()
            {
                // Delay based upon the game speed
                int delay = (int)this.HouseRules.GameSpeed;

                // Get the number of milliseconds to pause
                // Dividing by 2 because the UI Refreshing already slows the game down quite a bit.
                // A faster computer might paint the UI faster than mine, my computer is about 10 
                // years old so this could be only my machine that needs this. 
                int gamePause = DelayMilliseconds - delay;
                
                // return value
                return gamePause;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create a new collection of 'Inning' objects.
                this.DeckHistory = new List<Inning>();

                // Create the HouseRules
                this.HouseRules = new Options();

                // If the ShufflingAnimationControl object exists
                if (this.HasShufflingAnimationControl)
                {
                    // Create the VisibleChanged event
                    this.ShufflingAnimationControl.VisibleChanged += ShufflingAnimationControl_VisibleChanged;
                }

                // Create the DelayManager
                this.DelayManager = new DelayManager();
            }
            #endregion
            
            #region NewInning()
            /// <summary>
            /// This method New Inning
            /// </summary>
            private void NewInning()
            {
                // Create a new Inning
                Inning inning = new Inning();

                // Add the Inning to the DeckHistory so that the DeckPenetration and InningNumber can be determined
                this.DeckHistory.Add(inning);

                // Set the InningNumber (the value equals the count of DeckHistory)
                inning.Number = this.InningNumber;
            }
            #endregion

            #region PayOffBlackJacks(bool dealerHasBlackJack)
            /// <summary>
            /// This method Pay Off Black Jacks
            /// </summary>
            private void PayOffBlackJacks(bool dealerHasBlackJack)
            {
                // verify the Players exist
                if (this.HasPlayers)
                {
                    // iterate the Players
                    foreach (Player player in this.Players)
                    {
                        // if the player exists and has a bet placed and is not sitting out
                        if ((player.HasCurrentHand) && (player.CurrentHand.HasAmountWagered) && (!player.SittingOut))
                        {
                            // if this player has a currentHand
                            if (player.CurrentHand.HasBlackJack)
                            {
                                bool isBlackJack = true;

                                this.Table.PayOffBet(player.SeatNumber, player.LastBetAmount, isBlackJack);
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region PayOffInsurance()
            /// <summary>
            /// This method Pay Off Insurance bets for any players that took Insurance
            /// </summary>
            private void PayOffInsurance()
            {
                 // if the Dealer exists and has a hand
                if ((this.HasDealer) && (this.Dealer.HasCurrentHand) && (this.Dealer.CurrentHand.UpCardIsAnAce) && (this.Dealer.CurrentHand.HasBlackJack))
                {
                    // verify the Players exist
                    if (this.HasPlayers)
                    {
                        // iterate the Players
                        foreach (Player player in this.Players)
                        {
                            // if the player exists and has a bet placed and is not sitting out
                            if ((player.HasCurrentHand) && (player.CurrentHand.HasAmountWagered) && (!player.SittingOut))
                            {
                                // if this player took insurance
                                if (player.TookInsurance)
                                {
                                    // Give the player their money back essentially
                                    player.Chips = player.Chips + ((player.CurrentHand.AmountWagered + player.CurrentHand.AmountWagered) / 2);

                                    // If the value for the property player.HasPlayerControl is true
                                    if (player.HasPlayerControl)
                                    {
                                        
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region PromptPlayersForBets()
            /// <summary>
            /// This method Prompt Players For Bets
            /// </summary>
            private void PromptPlayersForBets()
            {
                // If the Players object exists
                if (this.HasPlayers)
                {
                    // iterate the players
                    foreach (Player player in this.Players)
                    {
                        // do not interact with teh player if they are sitting out
                        if (!player.SittingOut)
                        {
                           // Delay the game a bit
                           Delay();

                            // We are interacting with this player
                            this.InteractionWithPlayerInProgress = true;

                            // Set the Last Action Time so the time out will fire in 15 seconds
                            this.DelayManager.LastActionTime = DateTime.Now;

                            // Create the ResponseRequest
                            IPlayerResponseRequest placeBetRequest = PlayerResponseFactory.CreatePlayerResponseRequest(ResponseRequestTypeEnum.PlaceBet, this.ResponseControl, player.PlayerControl, this.HouseRules);

                            // Setup the control
                            placeBetRequest.BlackJackPlayerControl = player.PlayerControl;

                            // Setup the Request
                            this.ResponseControl.ResponseRequest = placeBetRequest;

                            // Create a new instance of a 'Hand' object (even if not dealt in, the hand can still contain sitting out
                            // this way the history contains every seats history, although the name is a little deceptive)
                            Hand hand = new Hand();

                            // If the CurrentInning object exists
                            if (this.HasCurrentInning)
                            {
                                // Add this hand to history so it can be retrieved
                                this.CurrentInning.Hands.Add(hand);
                            }

                            // Set the current hand
                            this.CurrentHand = hand;

                            // Set the player.CurrentHand and hand.Player; this has to be set before calling 
                            // PromptForBet or else the GameManager cannot link the response to the player
                            player.CurrentHand = hand;

                            // Set the Player for the reason listed above
                            hand.Player = player;

                            // Deal the next hand to this player
                            player.PromptForBet(this.ResponseControl, hand, this.HouseRules);

                            // Wait for the Interaction with this player to finish before we move on to the next player
                            WaitForInteractionWithPlayerToFinish();
                        }
                    }
                }
            }
            #endregion

            #region PromptPlayersForDoubleDown()
            /// <summary>
            /// This method Prompt Players For Double Down
            /// </summary>
            private void PromptPlayersForDoubleDown()
            {
                // to do: prompt players to double down
            }
            #endregion
            
            #region PromptPlayersForInsurance()
            /// <summary>
            /// This method Prompt For Insurance
            /// </summary>
            private void PromptPlayersForInsurance()
            {
                // if the Dealer exists and has a hand
                if ((this.HasDealer) && (this.Dealer.HasCurrentHand) && (this.Dealer.CurrentHand.UpCardIsAnAce))
                {
                    // verify the Players exist
                    if (this.HasPlayers)
                    {
                        // iterate the Players
                        foreach (Player player in this.Players)
                        {
                            // if the player exists and has a bet placed and is not sitting out
                            if ((player.HasCurrentHand) && (player.CurrentHand.HasAmountWagered) && (!player.SittingOut))
                            {
                                // Delay the game for a little bit
                                Delay();

                                // We are interacting with this player
                                this.InteractionWithPlayerInProgress = true;

                                // Set the LastActionTime
                                this.DelayManager.LastActionTime = DateTime.Now;

                                // Create the ResponseRequest
                                IPlayerResponseRequest takeInsuranceRequest = PlayerResponseFactory.CreatePlayerResponseRequest(ResponseRequestTypeEnum.Insurance, this.ResponseControl, player.PlayerControl, this.HouseRules);

                                // Setup the control
                                takeInsuranceRequest.BlackJackPlayerControl = player.PlayerControl;

                                // Setup the Request
                                this.ResponseControl.ResponseRequest = takeInsuranceRequest;

                                // Deal the next hand to this player
                                player.PromptForInsurance(takeInsuranceRequest);

                                // Wait for the Interaction with this player to finish before we move on to the next player
                                WaitForInteractionWithPlayerToFinish();
                            }
                        }
                    }
                }
            }
            #endregion

            #region ReceiveResponse(PlayerResponse response)
            /// <summary>
            /// This method is used to get back a response from a player.
            /// </summary>
            /// <param name="response"></param>
            public void ReceiveResponse(PlayerResponse response)
            {
                // if the response object exists
                if (NullHelper.Exists(response))
                {
                    // if currently interacting with a player
                    if ((this.InteractionWithPlayerInProgress) && (this.HasCurrentHand) && (this.CurrentHand.HasPlayer) && (this.CurrentHand.Player.HasPlayerControl))
                    {
                        // if the Player placed a bet
                        if ((response.ResponseType == ResponseTypeEnum.PlaceBet) && (response.HasBetAmount))
                        {  
                            // set the bet amount
                            this.CurrentHand.AmountWagered = response.BetAmount;

                            // Remove the chips that were bet from the players balance for now
                            this.CurrentHand.Player.Chips = this.CurrentHand.Player.Chips - response.BetAmount;

                            // if the player of the current hand has a BlackJackPlayerControl1
                            if (this.CurrentHand.Player.HasPlayerControl)
                            {
                                // Display the players updated balance 
                                this.CurrentHand.Player.PlayerControl.DisplayChipBalance();
                            }

                            // We have the response from this player
                            this.InteractionWithPlayerInProgress = false;
                        }
                        // if the Player placed a bet
                        else if (response.ResponseType == ResponseTypeEnum.TimeOut)
                        {
                            // set the bet amount
                            this.CurrentHand.AmountWagered = 0;

                            // Hide the bet controls
                            this.CurrentHand.Player.PlayerControl.HideBetControls();

                            // This player is now sitting out
                            this.CurrentHand.Player.SittingOut = true;

                            // Now show a message this player took Insurance
                            if (this.HasTable)
                            {
                                // This player took insurance
                                this.Table.ShowActionMessage("Timed Out", this.CurrentHand.Player.SeatNumber);
                            }

                            // if the Player.PlayerControl exists
                            if (this.CurrentHand.Player.HasPlayerControl)
                            {
                                // Display the player as sitting out
                                this.CurrentHand.Player.PlayerControl.DisplayPlayer();
                            }

                            // We have the response from this player
                            this.InteractionWithPlayerInProgress = false;
                        }
                        else if ((response.ResponseType == ResponseTypeEnum.Insurance) && (response.HasBetAmount))
                        {
                            // The player took insurance
                            this.CurrentHand.Player.TookInsurance = true;

                            // Remove the chips that were bet from the players balance for now
                            this.CurrentHand.Player.Chips = this.CurrentHand.Player.Chips - response.BetAmount;

                            // if the player of the current hand has a BlackJackPlayerControl1
                            if (this.CurrentHand.Player.HasPlayerControl)
                            {
                                // Display the players updated balance 
                                this.CurrentHand.Player.PlayerControl.DisplayChipBalance();
                                
                                // Show the InsuranceIcon
                                this.CurrentHand.Player.PlayerControl.ShowInsuranceIcon(true);
                            }

                            // Now show a message this player took Insurance
                            if (this.HasTable)
                            {
                                // This player took insurance
                                this.Table.ShowActionMessage("Took Insurance", this.CurrentHand.Player.SeatNumber);
                            }

                            // We have the response from this player
                            this.InteractionWithPlayerInProgress = false;
                        }
                        else if (response.ResponseType == ResponseTypeEnum.No)
                        {
                            // The player said no to Insurance (or split, or double)

                            // If this is an Insurance Request
                            if (response.ResponseRequestType == ResponseRequestTypeEnum.Insurance)
                            {
                                // Now show a message this player took Insurance
                                if (this.HasTable)
                                {  
                                    // This player took insurance
                                    this.Table.ShowActionMessage("Declined Insurance", this.CurrentHand.Player.SeatNumber);
                                }
                            }

                            // We have the response from this player
                            this.InteractionWithPlayerInProgress = false;
                        }
                    }
                }
            }
            #endregion
            
            #region RequestNewShuffle()
            /// <summary>
            /// This method Request New Shuffle
            /// </summary>
            internal void RequestNewShuffle()
            {
                // If the Shuffler object exists
                if (this.HasShuffler)
                {
                    // reset the value of Shuffled
                    this.Shuffler.Shuffled = false;
                }
            }
            #endregion
            
            #region ShuffleIfRequired()
            /// <summary>
            /// This method Shuffle If Required
            /// </summary>
            private void ShuffleIfRequired()
            {
                // if the Penetration has been exceeded or the deck has not been Shuffled
                if ((this.DeckPenetration > this.Penetration) || (!this.Shuffled))
                {
                    // Since we are shuffling, we have to reset these values
                    this.DeckHistory = new List<Inning>();

                    // if the ShufflingCallBack exists
                    if (this.HasShuffingCallBack)
                    {
                        // show the ShufflingCallBack
                        this.ShufflingCallBack(true);
                    }

                    // Recreate the Cards
                    this.Shuffler.InitializeCards();

                    // Shuffle the cards
                    this.Shuffler.Shuffle(this.TimesToShuffle);
                }

                // If the RefreshMethod object exists
                if (this.HasRefreshMethod)
                {
                    // Call the Refresh Method so the UI is not left out of the loop
                    this.RefreshMethod();
                }
            }
            #endregion
            
            #region StartDealing()
            /// <summary>
            /// This method starts dealing and will not stop until Quit is called unless Manuel Deal is
            /// selected for the GameSpeed.
            /// </summary>
            public void StartDealing()
            {
                // BeginDealing
                DealContinuously();
            }
            #endregion

            #region StopDealing()
            /// <summary>
            /// This method stops dealing by setting Quit to true.
            /// Alternatively you can set Quit to true manually.
            /// </summary>
            private void StopDealing()
            {
                // Set the value for the property 'Quit' to true
                this.Quit = true;
            }
            #endregion

            #region TableMaximum
            /// <summary>
            /// This property gets or sets the value for 'TableMaximum'.
            /// </summary>
            public int TableMaximum
            {
                get
                {
                    // initial value
                    int tableMaximum = 10000;

                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the return value
                        tableMaximum = (int)HouseRules.TableMaximum;
                    }

                    // return value
                    return tableMaximum;
                }
                set
                {
                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the value
                        HouseRules.TableMaximum = value;
                    }
                }
            }
            #endregion

            #region TableMinimum
            /// <summary>
            /// This property gets or sets the value for 'TableMinimum'.
            /// </summary>
            public int TableMinimum
            {
                get
                {
                    // initial value
                    int tableMinimum = 5;

                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the return value
                        tableMinimum = (int)HouseRules.TableMinimum;
                    }

                    // return value
                    return tableMinimum;
                }
                set
                {
                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the value
                        HouseRules.TableMinimum = value;
                    }
                }
            }
            #endregion
            
            #region WaitForInteractionWithPlayerToFinish()
            /// <summary>
            /// This method Wait For Interaction With Player To Finish
            /// </summary>
            private void WaitForInteractionWithPlayerToFinish()
            {
                do
                {
                    // Set the timeout time
                    DateTime timeOutTime = this.DelayManager.LastActionTime.AddSeconds(15);

                    // if the user timed out
                    if (DateTime.Now > timeOutTime)
                    {
                        // Send a response this user timed out
                        PlayerResponse timedOutResponse = new PlayerResponse(ResponseTypeEnum.TimeOut);

                        // Send the response
                        this.ReceiveResponse(timedOutResponse);
                    }

                    // If the Table object exists
                    if (this.HasTable)
                    {
                        // Refresh the Table UI so it is not left out of the loop
                        this.Table.RefreshUI();
                    }
                } while (this.InteractionWithPlayerInProgress);
            }
            #endregion
            
            #region WaitForShuffleToFinish()
            /// <summary>
            /// This method Wait For Shuffle To Finish
            /// </summary>
            private void WaitForShuffleToFinish()
            {
                do
                {
                    // If the Table object exists
                    if (this.HasTable)
                    {
                        // Refresh the Table UI so it is not left out of the loop
                        this.Table.RefreshUI();
                    }
                } while (this.ShufflingInProgress);
            }
            #endregion
            
        #endregion

        #region Properties

            #region Cards
            /// <summary>
            /// This property gets or sets the value for 'Cards'.
            /// </summary>
            public List<Card> Cards
            {
                get { return cards; }
                set { cards = value; }
            }
            #endregion

            #region CardsDealt
            /// <summary>
            /// This read only property returns the number of cards that have already been dealt.
            /// </summary>
            public int CardsDealt
            {
                get
                {
                    // initial value
                    int cardsDealt = 0;

                    // if their is any DeckHistory available
                    if (ListHelper.HasOneOrMoreItems(this.DeckHistory))
                    {
                        // iterate the innings                        
                        foreach (Inning inning in this.DeckHistory)
                        {
                            // get the CardsDealt
                            cardsDealt += inning.CardsDealt;
                        }
                    }

                    // return value
                    return cardsDealt;
                }
            }
            #endregion

            #region ChipShuffler
            /// <summary>
            /// This property gets or sets the value for 'ChipShuffler'.
            /// </summary>
            public RandomShuffler ChipShuffler
            {
                get { return chipShuffler; }
                set { chipShuffler = value; }
            }
            #endregion
            
            #region CurrentHand
            /// <summary>
            /// This property gets or sets the value for 'CurrentHand'.
            /// </summary>
            public Hand CurrentHand
            {
                get { return currentHand; }
                set { currentHand = value; }
            }
            #endregion
                     
            #region CurrentInning
            /// <summary>
            /// This read only property returns the last inning in DeckHistory
            /// </summary>
            public Inning CurrentInning
            {
                get
                {
                    // initial value
                    Inning currentInning = null;

                    // If the DeckHistory object exists
                    if (ListHelper.HasOneOrMoreItems(this.DeckHistory))
                    {
                        // return the last item
                        currentInning = this.DeckHistory[this.DeckHistory.Count - 1];
                    }

                    // return value
                    return currentInning;
                }
            }
            #endregion
            
            #region Dealer
            /// <summary>
            /// This property gets or sets the value for 'Dealer'.
            /// </summary>
            public Player Dealer
            {
                get { return dealer; }
                set { dealer = value; }
            }
            #endregion
            
            #region DeckHistory
            /// <summary>
            /// This property gets or sets the value for 'DeckHistory'.
            /// </summary>
            public List<Inning> DeckHistory
            {
                get { return deckHistory; }
                set { deckHistory = value; }
            }
            #endregion

            #region DeckPenetration
            /// <summary>
            /// This read only property returns the percentage of cards dealt.
            /// When the DeckPenetration exceeds the HouseRules.Penetration
            /// the cards are reshuffled.
            /// </summary>
            public double DeckPenetration
            {
                get
                {
                    // initial value
                    double deckPenetration = 0;

                    // if there is an InitialCardsCount
                    if (this.InitialCardsCount > 0)
                    {
                        // get a local copy that is a double
                        double cardsInShoe = (double) this.InitialCardsCount;

                        // if there are no CardsDealt
                        if (this.CardsDealt > 0)
                        {
                            // set the return value
                            deckPenetration = (100 / cardsInShoe) *  CardsDealt;
                        }
                        else
                        {
                            // we have not dealt any cards so the value is 0
                            deckPenetration = 0;
                        }
                    }

                    // return value
                    return deckPenetration;
                }
            }
            #endregion
            
            #region DelayManager
            /// <summary>
            /// This property gets or sets the value for 'DelayManager'.
            /// </summary>
            public DelayManager DelayManager
            {
                get { return delayManager; }
                set { delayManager = value; }
            }
            #endregion
            
            #region HasCards
            /// <summary>
            /// This property returns true if this object has a 'Cards'.
            /// </summary>
            public bool HasCards
            {
                get
                {
                    // initial value
                    bool hasCards = (this.Cards != null);
                    
                    // return value
                    return hasCards;
                }
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
            
            #region HasCurrentInning
            /// <summary>
            /// This property returns true if this object has a 'CurrentInning'.
            /// </summary>
            public bool HasCurrentInning
            {
                get
                {
                    // initial value
                    bool hasCurrentInning = (this.CurrentInning != null);
                    
                    // return value
                    return hasCurrentInning;
                }
            }
            #endregion
            
            #region HasDealer
            /// <summary>
            /// This property returns true if this object has a 'Dealer'.
            /// </summary>
            public bool HasDealer
            {
                get
                {
                    // initial value
                    bool hasDealer = (this.Dealer != null);
                    
                    // return value
                    return hasDealer;
                }
            }
            #endregion
            
            #region HasDeckHistory
            /// <summary>
            /// This property returns true if this object has a 'DeckHistory'.
            /// </summary>
            public bool HasDeckHistory
            {
                get
                {
                    // initial value
                    bool hasDeckHistory = (this.DeckHistory != null);
                    
                    // return value
                    return hasDeckHistory;
                }
            }
            #endregion
            
            #region HasDelayManager
            /// <summary>
            /// This property returns true if this object has a 'DelayManager'.
            /// </summary>
            public bool HasDelayManager
            {
                get
                {
                    // initial value
                    bool hasDelayManager = (this.DelayManager != null);
                    
                    // return value
                    return hasDelayManager;
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
            
            #region HasPlayers
            /// <summary>
            /// This property returns true if this object has a 'Players'.
            /// </summary>
            public bool HasPlayers
            {
                get
                {
                    // initial value
                    bool hasPlayers = (this.Players != null);
                    
                    // return value
                    return hasPlayers;
                }
            }
            #endregion
            
            #region HasRefreshMethod
            /// <summary>
            /// This property returns true if this object has a 'RefreshMethod'.
            /// </summary>
            public bool HasRefreshMethod
            {
                get
                {
                    // initial value
                    bool hasRefreshMethod = (this.RefreshMethod != null);
                    
                    // return value
                    return hasRefreshMethod;
                }
            }
            #endregion
            
            #region HasResponseControl
            /// <summary>
            /// This property returns true if this object has a 'ResponseControl'.
            /// </summary>
            public bool HasResponseControl
            {
                get
                {
                    // initial value
                    bool hasResponseControl = (this.ResponseControl != null);
                    
                    // return value
                    return hasResponseControl;
                }
            }
            #endregion
            
            #region HasShuffingCallBack
            /// <summary>
            /// This property returns true if this object has a 'ShufflingCallBack'.
            /// </summary>
            public bool HasShuffingCallBack
            {
                get
                {
                    // initial value
                    bool hasShuffingCallBack = (this.ShufflingCallBack != null);
                    
                    // return value
                    return hasShuffingCallBack;
                }
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
            
            #region HasShufflingAnimationControl
            /// <summary>
            /// This property returns true if this object has a 'ShufflingAnimationControl'.
            /// </summary>
            public bool HasShufflingAnimationControl
            {
                get
                {
                    // initial value
                    bool hasShufflingAnimationControl = (this.ShufflingAnimationControl != null);
                    
                    // return value
                    return hasShufflingAnimationControl;
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
            
            #region InitialCardsCount
            /// <summary>
            /// This property gets or sets the value for 'InitialCardsCount'.
            /// </summary>
            public int InitialCardsCount
            {
                get 
                {
                    // initial value
                    int initialCardsCount = 0;

                    // If the HouseRules object exists
                    if (this.HasHouseRules)
                    {
                        // Set the return value
                        initialCardsCount = CardsInDeck * this.HouseRules.NumberDecks;
                    }

                    // return value
                    return initialCardsCount;
                }
            }
            #endregion

            #region InningNumber
            /// <summary>
            /// This property gets or sets the value for 'InningNumber'.
            /// </summary>
            public int InningNumber
            {
                get
                {
                    // initial value
                    int inningNumber = 0;

                    // if the control exists
                    if (DeckHistory != null)
                    {
                        // set the return value
                        inningNumber = (int) DeckHistory.Count;
                    }

                    // return value
                    return inningNumber;
                }
            }
            #endregion
            
            #region InteractionWithPlayerInProgress
            /// <summary>
            /// This property gets or sets the value for 'InteractionWithPlayerInProgress'.
            /// </summary>
            public bool InteractionWithPlayerInProgress
            {
                get { return interactionWithPlayerInProgress; }
                set { interactionWithPlayerInProgress = value; }
            }
            #endregion
            
            #region Paused
            /// <summary>
            /// This property gets or sets the value for 'Paused'.
            /// </summary>
            public bool Paused
            {
                get { return paused; }
                set { paused = value; }
            }
            #endregion

            #region Penetration
            /// <summary>
            /// This read only property returns the Penetration from the HouseRules
            /// </summary>
            public double Penetration
            {
                get
                {
                    // initial value
                    double penetration = 0;

                    // If the HouseRules object exists
                    if (this.HasHouseRules)
                    {
                        // set the penetration
                        penetration = this.HouseRules.Penetration;
                    }

                    // return value
                    return penetration;
                }
            }
            #endregion
            
            #region Players
            /// <summary>
            /// This property gets or sets the value for 'Players'.
            /// </summary>
            public List<Player> Players
            {
                get { return players; }
                set { players = value; }
            }
            #endregion
            
            #region Quit
            /// <summary>
            /// This property gets or sets the value for 'Quit'.
            /// </summary>
            public bool Quit
            {
                get { return quit; }
                set { quit = value; }
            }
            #endregion
           
            #region RefreshMethod
            /// <summary>
            /// This property gets or sets the value for 'RefreshMethod'.
            /// </summary>
            public RefreshUICallBack RefreshMethod
            {
                get { return refreshMethod; }
                set { refreshMethod = value; }
            }
            #endregion
            
            #region ResponseControl
            /// <summary>
            /// This property gets or sets the value for 'ResponseControl'.
            /// </summary>
            public PlayerResponseControl ResponseControl
            {
                get 
                { 
                    // initial value
                    PlayerResponseControl responseControl = null;

                    // If the Table object exists
                    if (this.HasTable)
                    {
                        // Get the PlayerResponseControl from the MainForm
                        responseControl = this.Table.GetPlayerResponseControl();
                    }

                    // return value
                    return responseControl; 
                }
            }
            #endregion
            
            #region ShufflingCallBack
            /// <summary>
            /// This property gets or sets the value for 'ShufflingCallBack'.
            /// </summary>
            public ShowShufflingCallBack ShufflingCallBack
            {
                get { return shufflingCallBack; }
                set { shufflingCallBack = value; }
            }
            #endregion
            
            #region Shuffled
            /// <summary>
            /// This property gets or sets the value for 'Shuffled'.
            /// </summary>
            public bool Shuffled
            {
                get
                {
                    // initial value
                    bool shuffled = false;

                    // if the control exists
                    if (Shuffler != null)
                    {
                        // set the return value
                        shuffled = (bool)Shuffler.Shuffled;
                    }

                    // return value
                    return shuffled;
                }
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

            #region ShufflingAnimationControl
            /// <summary>
            /// This property gets or sets the value for 'ShufflingAnimationControl'.
            /// </summary>
            public ShufflingAnimationControl ShufflingAnimationControl
            {
                get
                {
                    // initial value
                    ShufflingAnimationControl shufflingAnimationControl = null;

                    // if the control exists
                    if (Table != null)
                    {
                        // set the return value
                        shufflingAnimationControl = Table.GetShufflingAnimationControl();
                    }

                    // return value
                    return shufflingAnimationControl;
                }
            }
            #endregion

            #region ShufflingInProgress
            /// <summary>
            /// This property gets or sets the value for 'ShufflingInProgress'.
            /// </summary>
            public bool ShufflingInProgress
            {
                get { return shufflingInProgress; }
                set { shufflingInProgress = value; }
            }
            #endregion
            
            #region Table
            /// <summary>
            /// This property gets or sets the value for 'Table'.
            /// </summary>
            public MainForm Table
            {
                get { return table; }
                set { table = value; }
            }
            #endregion
            
            #region TimesToShuffle
            /// <summary>
            /// This property gets or sets the value for 'TimesToShuffle'.
            /// </summary>
            public int TimesToShuffle
            {
                get { return timesToShuffle; }
                set { timesToShuffle = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
