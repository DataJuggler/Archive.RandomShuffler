

#region using statements

using CardCounter.Enumerations;
using DataJuggler.Core.RandomShuffler.Enumerations;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.RandomShuffler.Interfaces;

#endregion

namespace CardCounter.Interfaces
{

    #region interface ICardCountingSystem
    /// <summary>
    /// This interface must be implemented by all card counting systems.
    /// </summary>
    public interface ICardCountingSystem : ICardValueManager
    {
        
        #region Methods

            #region GetCardCountValue(Card card);
            /// <summary>
            /// This method calls the appropriate method based on the CardName
            /// </summary>
            /// <param name="card"></param>
            /// <returns></returns>
            double GetCardCountValue(Card card);
            #endregion

            #region GetDeckPenetration();
            /// <summary>
            /// This returns what percentage of the deck has been dealt.
            /// </summary>
            /// <returns></returns>
            double GetDeckPenetration();
            #endregion
            
            #region GetInitialCount(int numberDecks);
            /// <summary>
            /// This is needed for some Systems like KISS II that 
            /// starts off at -2 per deck.
            /// </summary>
            /// <param name="numberDecks"></param>
            /// <returns></returns>
            double GetInitialCount(int numberDecks);
            #endregion

            #region GetCountValueOfAce(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for twos
            /// </summary>
            double GetCountValueOfAce(SuitEnum side = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfTwo(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for twos
            /// </summary>
            double GetCountValueOfTwo(SuitEnum side = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfThree(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for threes
            /// </summary>
            double GetCountValueOfThree(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfFour(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for fours
            /// </summary>
            double GetCountValueOfFour(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfFive(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for fives
            /// </summary>
            double GetCountValueOfFive(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfSix(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for sixes
            /// </summary>
            double GetCountValueOfSix(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfSeven(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for sevens
            /// </summary>
            double GetCountValueOfSeven(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfEight(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for eights
            /// </summary>
            double GetCountValueOfEight(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfNine(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for nines
            /// </summary>
            double GetCountValueOfNine(SuitEnum suit = SuitEnum.Unknown);
            #endregion

            #region GetCountValueOfTenJackQueenKing(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for tens
            /// </summary>
            double GetCountValueOfTenJackQueenKing(SuitEnum suit = SuitEnum.Unknown);
            #endregion
            
            #region Initialize(int numberDecks);
            /// <summary>
            /// This method is called when the System is initialized
            /// </summary>
            /// <param name="numberDecks"></param>
            void Initialize(int numberDecks);
            #endregion

        #endregion

        #region Properties

            #region AcesDealt
            /// <summary>
            /// This property gets or sets the value for the number of Aces Dealt.
            /// </summary>
            int AcesDealt
            {
                get;
                set;
            }
            #endregion

            #region AcesRemaining
            /// <summary>
            /// This read only property returns the number of Aces left in the deck
            /// </summary>
            int AcesRemaining
            {
                get;
            }
            #endregion

            #region BalancedSystem
            /// <summary>
            /// Is this system a Balanced System or not.
            /// In Balanced Systems the count will end up at zero if all of the cards are dealt out.
            /// </summary>
            bool BalancedSystem
            {
                get;
            }
            #endregion

            #region CardsDealt
            /// <summary>
            /// This property returns the number of cards that have been dealt.
            /// Each time GetCardValue is called this number is incremented.
            /// </summary>
            int CardsDealt
            {
                get;
            }
            #endregion

            #region CardsRemainingInDeck
            /// <summary>
            /// This read only property returns the number of cards left in the deck.
            /// </summary>
            int CardsRemainingInDeck
            {
                get;
            }
            #endregion

            #region Count
            /// <summary>
            /// Every system has to return the Count.
            /// </summary>
           double Count
           {
                get;
                set;
           }
           #endregion

            #region DecksDealt
            /// <summary>
            /// This read only property returns the number of decks that have been dealt.
            /// </summary>
            int DecksDealt
            {
                get;
            }
            #endregion

            #region DecksRemaining
            /// <summary>
            /// This read only property returns the number of decks that have not been dealt.
            /// </summary>
            int DecksRemaining
            {
                get;
            }
            #endregion

            #region HelpLink
            /// <summary>
            /// The system must return its HelpLink
            /// </summary>
            string HelpLink
            {
                get;
            }
            #endregion

            #region InitialAcesInDeck
            /// <summary>
            /// This read only property returns the number of Aces when the Deck or Shoe is filled
            /// </summary>
            int InitialAcesInDeck
            {
                get;               
            }
            #endregion
            
            #region InitialCardsInDeck
            /// <summary>
            /// This read only property returns the number of cards left in the deck.
            /// </summary>
            int InitialCardsInDeck
            {
                get;
            }
            #endregion

            #region IsCounting
            /// <summary>
            /// This is really only needed for the Do Not Count interface.
            /// </summary>
            bool IsCounting
            {
                get;
                set;
            }
            #endregion

            #region Level
            /// <summary>
            /// This needs to be Simple, Average or Advanced, etc.
            /// </summary>
            CountingSystemLevelEnum Level
            {
                get;
            }
            #endregion

            #region Name
            /// <summary>
            /// The system must return its name.
            /// </summary>
            string Name
            {
                get;
            }
            #endregion

            #region Notes
            /// <summary>
            /// This is a very short text describing unique items about a counting system.
            /// </summary>
            string Notes
            {
                get;
            }
            #endregion

            #region NumberDecks
            /// <summary>
            /// We must know how many decks we are playing
            /// </summary>
            int NumberDecks
            {
                get;
                set;
            }
            #endregion

            #region TrueCount
            /// <summary>
            /// This value takes into account the count * the percentage of the way we are through the deck.
            /// This property only applies to Balanced systems.
            /// </summary>
            double TrueCount
            {
                get;  
            }
            #endregion

        #endregion
            
    }
    #endregion

}
