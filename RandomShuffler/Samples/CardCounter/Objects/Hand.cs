

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.Core.RandomShuffler.Objects;
using CardCounter.Enumerations;
using DataJuggler.Core.UltimateHelper;

#endregion

namespace CardCounter.Objects
{

    #region class BlackJackHand
    /// <summary>
    /// This class represents the cards dealt to a player durring one 'Inning' of play.
    /// </summary>
    public class Hand
    {
        
        #region Private Variables
        private double amountWagered;
        private double betPayOff;
        private List<Card> cards;
        private double netProfit;
        private Player player;
        private HandResultEnum result;
        private Hand splitHand;
        private Hand parentHand;
        private Hand baseHand;
        private Guid handID;
        private Guid baseHandID;
        private int level;
        private int levelsInBaseHand;
        private List<ResponseTypeEnum> responses;
        private bool sittingOut;
        private SeatNumberEnum seatNumber;
        private bool completed;
        private int number;
        private Inning inning;
        private bool playerActionComplete;
        private bool tookInsurance;
        private bool doubledDown;
        #endregion

        #region Default Constructor
        /// <summary>
        /// Create a new instance of a BlackJackHand object.
        /// </summary>
        public Hand()
        {
            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region GetSplitHands(ref List<BlackJackHand> splitHands)
            /// <summary>
            /// This method returns the SplitHands recursively until there any more split hands found.
            /// </summary>
            /// <returns></returns>
            public List<Hand> GetSplitHands(ref List<Hand> splitHands)
            {
                // if the splitHands collection exists
                if (NullHelper.Exists(splitHands))
                {
                    // If the SplitHand object exists
                    if (this.HasSplitHand)
                    {
                        // add this hand
                        splitHands.Add(this.SplitHand);

                        // Now call this method on the Split hand in case it has a Split hand.
                        // This will eventually stop as there are only so many split hands possible.
                        this.SplitHand.GetSplitHands(ref splitHands);
                    }
                }

                // return the collection
                return splitHands;
            }
            #endregion

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create a new HandID                
                this.HandID = Guid.NewGuid();

                // Create any collections
                this.Cards = new List<Card>();
                this.responses = new List<ResponseTypeEnum>();
            }
            #endregion
            
        #endregion

        #region Properties

            #region AmountWagered
            /// <summary>
            /// This property gets or sets the value for 'AmountWagered'.
            /// </summary>
            public double AmountWagered
            {
                get { return amountWagered; }
                set { amountWagered = value; }
            }
            #endregion
            
            #region BaseHand
            /// <summary>
            /// This property gets or sets the value for 'BaseHand'.
            /// The BaseHand is the hand dealt to the Seat at the beginning of the hand.
            /// A non base hand is a Split hand 
            /// </summary>
            public Hand BaseHand
            {
                get { return baseHand; }
                set { baseHand = value; }
            }
            #endregion
            
            #region BaseHandID
            /// <summary>
            /// This property gets or sets the value for 'BaseHandID'.
            /// The BaseHand is the hand dealt to the Seat at the beginning of the hand.
            /// A non base hand is a Split hand 
            /// </summary>
            public Guid BaseHandID
            {
                get { return baseHandID; }
                set { baseHandID = value; }
            }
            #endregion
            
            #region BetPayOff
            /// <summary>
            /// This property gets or sets the value for 'BetPayOff'.
            /// </summary>
            public double BetPayOff
            {
                get { return betPayOff; }
                set { betPayOff = value; }
            }
            #endregion
            
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
            
            #region Completed
            /// <summary>
            /// This property gets or sets the value for 'Completed'.
            /// </summary>
            public bool Completed
            {
                get { return completed; }
                set { completed = value; }
            }
            #endregion
            
            #region DoubledDown
            /// <summary>
            /// This property gets or sets the value for 'DoubledDown'.
            /// </summary>
            public bool DoubledDown
            {
                get { return doubledDown; }
                set { doubledDown = value; }
            }
            #endregion
            
            #region HandID
            /// <summary>
            /// This property gets or sets the value for 'HandID'.
            /// </summary>
            public Guid HandID
            {
                get { return handID; }
                set { handID = value; }
            }
            #endregion
            
            #region HandValue
            /// <summary>
            /// This read only property returns the value for 'HandValue'.
            /// </summary>
            public int HandValue
            {
                get
                {
                    // initial value
                    int handValue = 0;
                    
                    // if the CardsCollection exists
                    if (this.HasCards)
                    {
                        // Iterate the collection of Card objects
                        foreach (Card card in cards)
                        {
                            // add to the return value
                            handValue += card.CardValue;
                        }
                    }
                    
                    // return value
                    return handValue;
                }
            }
            #endregion
            
            #region HasAmountWagered
            /// <summary>
            /// This property returns true if the 'AmountWagered' is set.
            /// </summary>
            public bool HasAmountWagered
            {
                get
                {
                    // initial value
                    bool hasAmountWagered = (this.AmountWagered > 0);
                    
                    // return value
                    return hasAmountWagered;
                }
            }
            #endregion

            #region HasBlackJack
            /// <summary>
            /// This read only property returns true if this Hand has a black jack.
            /// </summary>
            public bool HasBlackJack
            {
                get
                {
                    // initial value
                    bool hasBlackJack = false;

                    // If the Cards object exists
                    if (this.HasCards)
                    {
                        // if there are exactly two cards and the value totals 21
                        hasBlackJack = ((this.Cards.Count == 2) && (this.HandValue == 21));
                    }

                    // return value
                    return hasBlackJack;
                }
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
            
            #region HasSplitHand
            /// <summary>
            /// This property returns true if this object has a 'SplitHand'.
            /// </summary>
            public bool HasSplitHand
            {
                get
                {
                    // initial value
                    bool hasSplitHand = (this.SplitHand != null);
                    
                    // return value
                    return hasSplitHand;
                }
            }
            #endregion
            
            #region HasUpCard
            /// <summary>
            /// This property returns true if this object has an 'UpCard'.
            /// </summary>
            public bool HasUpCard
            {
                get
                {
                    // initial value
                    bool hasUpCard = (this.UpCard != null);
                    
                    // return value
                    return hasUpCard;
                }
            }
            #endregion
            
            #region Inning
            /// <summary>
            /// This property gets or sets the value for 'Inning'.
            /// </summary>
            public Inning Inning
            {
                get { return inning; }
                set { inning = value; }
            }
            #endregion
            
            #region IsBaseHand
            /// <summary>
            /// This read only property returns true if the baseHand.ID matches this HandID
            /// </summary>
            public bool IsBaseHand
            {
                get
                {
                    // return true if the BaseHandID matches this HandID
                    return (this.BaseHandID == this.HandID);
                }
            }
            #endregion

            #region IsDealer
            /// <summary>
            /// This read only property returns true if this Player is a Dealer.
            /// </summary>
            public bool IsDealer
            {
                get
                {
                    // initial value
                    bool isDealer = false;

                    // if the Player exists
                    if (Player != null)
                    {
                        // set the return value
                        isDealer = (bool)Player.IsDealer;
                    }

                    // return value
                    return isDealer;
                }
            }
            #endregion
            
            #region Level
            /// <summary>
            /// This property gets or sets the value for 'Level'.
            /// </summary>
            public int Level
            {
                get { return level; }
                set { level = value; }
            }
            #endregion
            
            #region LevelsInBaseHand
            /// <summary>
            /// This property gets or sets the value for 'LevelsInBaseHand'.
            /// </summary>
            public int LevelsInBaseHand
            {
                get { return levelsInBaseHand; }
                set { levelsInBaseHand = value; }
            }
            #endregion
            
            #region NetProfit
            /// <summary>
            /// This property gets or sets the value for 'NetProfit'.
            /// </summary>
            public double NetProfit
            {
                get { return netProfit; }
                set { netProfit = value; }
            }
            #endregion
            
            #region Number
            /// <summary>
            /// This property gets or sets the value for 'Number'.
            /// </summary>
            public int Number
            {
                get { return number; }
                set { number = value; }
            }
            #endregion
            
            #region ParentHand
            /// <summary>
            /// This property gets or sets the value for 'ParentHand'.
            /// </summary>
            public Hand ParentHand
            {
                get { return parentHand; }
                set { parentHand = value; }
            }
            #endregion
            
            #region Player
            /// <summary>
            /// This property gets or sets the value for 'Player'.
            /// </summary>
            public Player Player
            {
                get { return player; }
                set { player = value; }
            }
            #endregion
            
            #region PlayerActionComplete
            /// <summary>
            /// This property gets or sets the value for 'PlayerActionComplete'.
            /// </summary>
            public bool PlayerActionComplete
            {
                get { return playerActionComplete; }
                set { playerActionComplete = value; }
            }
            #endregion
            
            #region Responses
            /// <summary>
            /// This property gets or sets the value for 'Responses'.
            /// </summary>
            public List<ResponseTypeEnum> Responses
            {
                get { return responses; }
                set { responses = value; }
            }
            #endregion
            
            #region Result
            /// <summary>
            /// This property gets or sets the value for 'Result'.
            /// </summary>
            public HandResultEnum Result
            {
                get { return result; }
                set { result = value; }
            }
            #endregion
            
            #region SeatNumber
            /// <summary>
            /// This property is used to keep track of the player and the seat number in history just in case
            /// player changes seats (possible future enhacement, it happens in casinos).
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
                set { sittingOut = value; }
            }
            #endregion
            
            #region SplitHand
            /// <summary>
            /// This property gets or sets the value for 'SplitHand'.
            /// </summary>
            public Hand SplitHand
            {
                get { return splitHand; }
                set { splitHand = value; }
            }
            #endregion

            #region TookInsurance
            /// <summary>
            /// This property gets or sets the value for 'TookInsurance'.
            /// </summary>
            public bool TookInsurance
            {
                get { return tookInsurance; }
                set { tookInsurance = value; }
            }
            #endregion
            
            #region UpCard
            /// <summary>
            /// This property gets or sets the value for 'UpCard'.
            /// </summary>
            public Card UpCard
            {
                get
                {
                    // initial value
                    Card upCard = null;

                    // if the Cards collection exists
                    if ((this.HasPlayer) && (this.Player.IsDealer) && (Cards != null) && (Cards.Count >= 2))
                    {
                        // set the return value
                        upCard = Cards[1];
                    }

                    // return value
                    return upCard;
                }
            }
            #endregion

            #region UpCardIsAnAce
            /// <summary>
            /// This read only property returns true if the Upcard is an Ace.
            /// </summary>
            public bool UpCardIsAnAce
            {
                get
                {
                    // initial value
                    bool upCardIsAnAce = false;

                    // if there is an Upcard to this hand
                    if (this.HasUpCard)
                    {
                        // set the return value to true if the UpCard is an Ace
                        upCardIsAnAce = (this.UpCard.CardName == DataJuggler.Core.RandomShuffler.Enumerations.CardEnum.Ace);
                    }

                    // return value
                    return upCardIsAnAce;
                }
            }
            
            #endregion
            
        #endregion
        
    }
    #endregion

}
