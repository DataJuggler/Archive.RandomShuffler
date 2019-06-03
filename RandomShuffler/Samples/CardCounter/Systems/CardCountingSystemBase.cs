

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;
using DataJuggler.Core.RandomShuffler;
using DataJuggler.Core.RandomShuffler.Enumerations;
using DataJuggler.Core.RandomShuffler.Interfaces;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic;

#endregion

namespace CardCounter.Systems
{

    #region class CardCountingSystemBase
    /// <summary>
    /// This is the base class that makes it easy to implement any CardCountingSystem.
    /// You only have to override any properties that a system varies from the default system.
    /// The BaseClass and the HI-Lo system are identical. 
    /// </summary>
    public abstract class CardCountingSystemBase : ICardCountingSystem, ICardValueManager
    {
        
        #region Private Variables
        private bool isCounting;
        private int acesDealt;
        private int numberDecks;
        private int cardsDealt;
        private double count;
        // The Default Initial Count is 0
        internal const double DefaultInitialCount = 0;
        // Low cards are all 1
        private const double DefaultCountValueOfTwo = 1;
        private const double DefaultCountValueOfThree = 1;
        private const double DefaultCountValueOfFour = 1;
        private const double DefaultCountValueOfFive = 1;
        private const double DefaultCountValueOfSix = 1;
        private const double DefaultCountValueOfSeven = 0;
        private const double DefaultCountValueOfEight = 0;
        private const double DefaultCountValueOfNine = 0;
        // high cards are all -1
        private const double DefaultCountValueOfTenJackQueenKing = -1;
        private const double DefaultCountValueOfAce = -1;
        private const int LowValueOfAce = 1;
        private const int HighValueOfAce = 11;
        private const int DefaultValueOfTenJackQueenKing = 10;
        #endregion

        #region Methods

            #region GetCardCountValue(Card card)
            /// <summary>
            /// This method returns the card value based upon the current ICardValueManager.
            /// This is the value of the card for the game of black jack; not the value of the 
            /// card for the counting system. That is known as the CountValue of a card.
            /// Call the GetCountValue(Card) to get the count value.
            /// </summary>
            /// <param name="card"></param>
            /// <returns></returns>
            public double GetCardCountValue(Card card)
            {
                // initial value
                double cardValue = 0;

                // if the card exists
                if (NullHelper.Exists(card))
                {
                    // Determine the return value by the CardName
                    switch (card.CardName)
                    {
                        case CardEnum.Ace:

                            // Get the count value for this system
                            cardValue = GetCountValueOfAce(card.Suit);

                            // required
                            break;

                        case CardEnum.Two:

                            // Get the count value for this system
                            cardValue = GetCountValueOfTwo(card.Suit);

                            // required
                            break;

                        case CardEnum.Three:

                            // Get the count value for this system
                            cardValue = GetCountValueOfThree(card.Suit);

                            // required
                            break;

                        case CardEnum.Four:

                            // Get the count value for this system
                            cardValue = GetCountValueOfFour(card.Suit);

                            // required
                            break;

                        case CardEnum.Five:

                            // Get the count value for this system
                            cardValue = GetCountValueOfFive(card.Suit);

                            // required
                            break;

                        case CardEnum.Six:

                            // Get the count value for this system
                            cardValue = GetCountValueOfSix(card.Suit);

                            // required
                            break;

                        case CardEnum.Seven:

                            // Get the count value for this system
                            cardValue = GetCountValueOfSeven(card.Suit);

                            // required
                            break;

                        case CardEnum.Eight:

                            // Get the count value for this system
                            cardValue = GetCountValueOfEight(card.Suit);

                            // required
                            break;

                        case CardEnum.Nine:

                            // Get the count value for this system
                            cardValue = GetCountValueOfNine(card.Suit);

                            // required
                            break;

                        case CardEnum.Ten:
                        case CardEnum.Jack:
                        case CardEnum.Queen:
                        case CardEnum.King:

                            // Get the count value for this system
                            cardValue = GetCountValueOfTenJackQueenKing(card.Suit);

                            // required
                            break;
                    }
                }    

                // return value
                return cardValue;
            }
            #endregion

            #region GetCardValue(Card card, int currentValue = 0)
            /// <summary>
            /// This method returns the card value based upon the current ICardValueManager.
            /// This is the value of the card for the game of black jack; not the value of the 
            /// card for the counting system. That is known as the CountValue of a card.
            /// Call the GetCountValue(Card) to get the count value.
            /// </summary>
            /// <param name="card"></param>
            /// <returns></returns>
            public int GetCardValue(Card card, int currentValue = 0)
            {
                // initial value
                int cardValue = 0;

                // if the card exists
                if (NullHelper.Exists(card))
                {
                    // Determine the return value by the CardName
                    switch (card.CardName)
                    {
                        case CardEnum.Ace:

                            // if the value is already 11
                            if (currentValue >= 11)
                            {
                                // use 1
                                cardValue = LowValueOfAce;
                            }
                            else
                            {
                                // Use 11
                                cardValue = HighValueOfAce;
                            }

                            // required
                            break;

                        case CardEnum.Ten:
                        case CardEnum.Jack:
                        case CardEnum.Queen:
                        case CardEnum.King:
                            
                            // set the card value
                            cardValue = DefaultValueOfTenJackQueenKing;

                            // required
                            break;

                        default:

                            // set the value to the value of the card
                            cardValue = (int) card.CardName;

                            // required
                            break;
                    }
                }    

                // return value
                return cardValue;
            }
            #endregion

            #region GetCardValues(Card card, int currentValue = 0)
            /// <summary>
            /// This method returns the card value based upon the current ICardValueManager.
            /// This is the value of the card for the game of black jack; not the value of the 
            /// card for the counting system. That is known as the CountValue of a card.
            /// Call the GetCountValue(Card) to get the count value.
            /// </summary>
            /// <param name="card"></param>
            /// <returns></returns>
            public List<int> GetCardValues(Card card)
            {
                // initial value
                List<int> cardValues = new List<int>();

                // if the card exists
                if (NullHelper.Exists(card))
                {
                    // Determine the return value by the CardName
                    switch (card.CardName)
                    {
                        case CardEnum.Ace:

                            // Add the low value of Ace
                            cardValues.Add(LowValueOfAce);
                            cardValues.Add(HighValueOfAce);

                            // required
                            break;

                        default:

                            // get the cardValue
                            int cardValue = GetCardValue(card, 0);

                            // Add this value
                            cardValue.CompareTo(cardValue);

                            // required
                            break;
                    }
                }

                // return value
                return cardValues;
            }
            #endregion

            #region GetDeckPenetration();
            /// <summary>
            /// This returns what percentage of the deck has been dealt.
            /// </summary>
            /// <returns></returns>
            public double GetDeckPenetration()
            {
                // initial value
                double deckPenetration = (this.InitialCardsInDeck / 100) * CardsDealt;

                // return value
                return deckPenetration;
            }
            #endregion

            #region GetInitialCount(int numberDecks);
            /// <summary>
            /// This is needed for some Systems like KISS II that 
            /// starts off at -2 per deck.
            /// </summary>
            /// <param name="numberDecks"></param>
            /// <returns></returns>
            public virtual double GetInitialCount(int numberDecks)
            {
                // return the Default Initial Count (0)
                return DefaultInitialCount;
            }
            #endregion

            #region GetCountValueOfAce(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for twos
            /// </summary>
            public virtual double GetCountValueOfAce(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the defaut value for an Ace
                return DefaultCountValueOfAce;
            }
            #endregion

            #region GetCountValueOfTwo(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for twos
            /// </summary>
            public virtual double GetCountValueOfTwo(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the defaut value for an Two
                return DefaultCountValueOfTwo;
            }
            #endregion

            #region GetCountValueOfThree(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for threes
            /// </summary>
            public virtual double GetCountValueOfThree(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for a three
                return DefaultCountValueOfThree;
            }
            #endregion

            #region GetCountValueOfFour(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for four
            /// </summary>
            public virtual double GetCountValueOfFour(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value of four
                return DefaultCountValueOfFour;
            }
            #endregion

            #region GetCountValueOfFive(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for fives
            /// </summary>
            public virtual double GetCountValueOfFive(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for a five
                return DefaultCountValueOfFive;
            }
            #endregion

            #region GetCountValueOfSix(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for sixes
            /// </summary>
            public virtual double GetCountValueOfSix(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for six
                return DefaultCountValueOfSix;
            }
            #endregion

            #region GetCountValueOfSeven(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for sevens
            /// </summary>
            public virtual double GetCountValueOfSeven(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for seven
                return DefaultCountValueOfSeven;
            }
            #endregion

            #region GetCountValueOfEight(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for eights
            /// </summary>
            public virtual double GetCountValueOfEight(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for eights
                return DefaultCountValueOfEight;
            }
            #endregion

            #region GetCountValueOfNine(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for nines
            /// </summary>
            public virtual double GetCountValueOfNine(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for nines
                return DefaultCountValueOfNine;
            }
            #endregion

            #region GetCountValueOfTenJackQueenKing(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for tens
            /// </summary>
            public virtual double GetCountValueOfTenJackQueenKing(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for tens, jacks, queens aned kings
                return DefaultCountValueOfTenJackQueenKing;
            }
            #endregion

            #region Initialize(int numberDecks)
            /// <summary>
            /// This method sets the initial cards in the deck
            /// </summary>
            public void Initialize(int numberDecks)
            {
                // Default to counting
                this.IsCounting = true;

                // Set the number of decks
                this.NumberDecks = numberDecks;
            }
            #endregion
            
            #region ToString()
            /// <summary>
            /// This method is used so the combo box will display the name of this system when added.                                                                  
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                // return the name of this object
                return this.Name;
            }
            #endregion

        #endregion

        #region Properties

            #region AcesDealt
            /// <summary>
            /// This property gets or sets the value for 'AcesDealt'.
            /// </summary>
            public int AcesDealt
            {
                get { return acesDealt; }
                set { acesDealt = value; }
            }
            #endregion

            #region AcesRemaining
            /// <summary>
            /// This read only property returns the number of Aces remaining in the deck.
            /// </summary>
            public int AcesRemaining
            {
                get 
                {   
                    // initial value
                    int acesRemaining = this.InitialAcesInDeck - this.AcesDealt;

                    // return value
                    return acesRemaining;
                }
            }
            #endregion
            
            #region BalancedSystem
            /// <summary>
            /// This property gets or sets the value for 'BalancedSystem'.
            /// </summary>
            public abstract bool BalancedSystem
            {
                get;
            }
            #endregion
            
            #region CardsDealt
            /// <summary>
            /// This property gets or sets the value for 'CardsDealt'.
            /// </summary>
            public int CardsDealt
            {
                get { return cardsDealt; }
                set { cardsDealt = value; }
            }
            #endregion
            
            #region CardsRemainingInDeck
            /// <summary>
            /// This property gets or sets the value for 'CardsRemainingInDeck'.
            /// </summary>
            public int CardsRemainingInDeck
            {
                get 
                {
                    // initial value
                    int cardsRemainingInDeck = this.InitialCardsInDeck - this.CardsDealt;

                    // return value
                    return cardsRemainingInDeck;
                }
            }
            #endregion
            
            #region Count
            /// <summary>
            /// This property gets or sets the value for 'Count'.
            /// </summary>
            public double Count
            {
                get { return count; }
                set { count = value; }
            }
            #endregion

            #region DecksDealt
            /// <summary>
            /// This read only property returns the number of decks that have been dealt.
            /// </summary>
            public int DecksDealt
            {
                get
                {
                    // initial value
                    int decksDealt = 0;
                    
                    // set the cardsDealt and take off any off number of cards that do not make a full deck
                    int cardsDealt = this.CardsDealt - (this.CardsDealt % RandomShuffler.CardsInDeck);

                    // now we can set the return value
                    decksDealt = (cardsDealt / RandomShuffler.CardsInDeck);

                    // return value
                    return decksDealt;
                }
            }
            #endregion

            #region DecksRemaining
            /// <summary>
            /// This read only property returns the number of decks that have not been dealt.
            /// </summary>
            public int DecksRemaining
            {
                get
                {
                    // initial value
                    int decksRemaining = this.NumberDecks - this.DecksDealt;

                    // return value
                    return decksRemaining;
                }
            }
            #endregion

            #region HelpLink
            /// <summary>
            /// This method returns the HelpLink for this System.
            /// </summary>
            public abstract string HelpLink
            {
                get;
            }
            #endregion

            #region InitialAcesInDeck
            /// <summary>
            /// This readonly property returns the value for 'InitialAcesInDeck'.
            /// This is calculated by the NumberDecks by the Suits in Deck (4).
            /// </summary>
            public int InitialAcesInDeck
            {
                get 
                {
                    // initial value
                    int initialAcesInDeck = this.NumberDecks * RandomShuffler.SuitsInDeck;

                    // return value
                    return initialAcesInDeck;
                }
            }
            #endregion
            
            #region InitialCardsInDeck
            /// <summary>
            /// This property gets or sets the value for 'InitialCardsInDeck'.
            /// </summary>
            public int InitialCardsInDeck
            {
                get
                { 
                    // initial value
                    int initialCardsInDeck = this.NumberDecks * RandomShuffler.CardsInDeck;

                    // return value
                    return initialCardsInDeck;
                }                
            }
            #endregion
            
            #region IsCounting
            /// <summary>
            /// This property gets or sets the value for 'IsCounting'.
            /// </summary>
            public bool IsCounting
            {
                get { return isCounting; }
                set { isCounting = value; }
            }
            #endregion

            #region Level
            /// <summary>
            /// This must be implemented in a derived class.
            /// </summary>
            public abstract CountingSystemLevelEnum Level
            {
                get;
            }
            #endregion
            
            #region Name
            /// <summary>
            /// This read only property returns the name of the System.
            /// </summary>
            public abstract string Name
            {
                // the name property must be implemented in a derived class
                get;
            }
            #endregion

            #region Notes
            /// <summary>
            /// This must be implemented in a derived class.
            /// </summary>
            public abstract string Notes
            {
                get;
            }
            #endregion

            #region NumberDecks
            /// <summary>
            /// This property gets or sets the value for 'NumberDecks'.
            /// </summary>
            public int NumberDecks
            {
                get { return numberDecks; }
                set { numberDecks = value; }
            }
            #endregion
            
            #region TrueCount
            /// <summary>
            /// This method returns the count * the percentage of the way through the deck
            /// </summary>
            public double TrueCount
            {
                get
                {
                    // initial value
                    double trueCount = this.Count / this.DecksRemaining;

                    // return value
                    return trueCount;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
