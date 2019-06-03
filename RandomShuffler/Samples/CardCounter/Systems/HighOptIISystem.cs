

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;
using DataJuggler.Core.RandomShuffler.Enumerations;

#endregion

namespace CardCounter.Systems
{

    #region class HighOptIISystem
    /// <summary>
    /// This class implements the High Opt 2 System
    /// </summary>
    public class HighOptIISystem : CardCountingSystemBase, ICardCountingSystem
    {
        
        #region Private Variables
        private const string SystemName = "High Opt II";
        private const double DefaultValueOfFour = 2;
        private const double DefaultValueOfFive = 2;
        private const double DefaultValueOfSeven = 1;
        private const double DefaultValueOfTenJackQueenKing = -2;
        private const double DefaultValueOfAce = 0;
        private const string InnerNotes = "-2, O, 1, or 2";
        private const string InnerHelpLink = "http://blackjack.co.za/card-counting/hi-opt-2-count/";
        #endregion

        #region Methods

            #region GetInitialCount(int numberDecks);
            /// <summary>
            /// This is needed for some Systems like KISS II that 
            /// starts off at -2 per deck.
            /// </summary>
            /// <param name="numberDecks"></param>
            /// <returns></returns>
            public override double GetInitialCount(int numberDecks)
            {
                // return the Default Initial Count (0)
                return (DefaultInitialCount * numberDecks);
            }
            #endregion

            #region GetCountValueOfAce(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This interface returns the value for an Ace.
            /// </summary>
            public override double GetCountValueOfAce(SuitEnum side = SuitEnum.Unknown)
            {
                // return the defaut value for an Ace
                return DefaultValueOfAce;
            }
            #endregion

            #region GetCountValueOfFour(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This interface returns the value for a Four
            /// </summary>
            public override double GetCountValueOfFour(SuitEnum side = SuitEnum.Unknown)
            {
                // return the defaut value for an Ace
                return DefaultValueOfFour;
            }
            #endregion

            #region GetCountValueOfFive(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This method return the value for twos. 
            /// </summary>
            public override double GetCountValueOfFive(SuitEnum suit = SuitEnum.Unknown)
            {
                // initial value
                double valueOfFive = DefaultValueOfFive;

                // return the defaut value for an Two
                return valueOfFive;
            }
            #endregion

            #region GetCountValueOfSeven(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This method return the value for seven. 
            /// </summary>
            public override double GetCountValueOfSeven(SuitEnum suit = SuitEnum.Unknown)
            {
                // initial value
                double valueOfSeven = DefaultValueOfSeven;

                // return the defaut value for a Seven
                return valueOfSeven;
            }
            #endregion

            #region GetCountValueOfTenJackQueenKing(SuitEnum suit = SuitEnum.Unknown);
            /// <summary>
            /// This interface must return a value for tens
            /// </summary>
            public override double GetCountValueOfTenJackQueenKing(SuitEnum suit = SuitEnum.Unknown)
            {
                // return the default value for tens, jacks, queens aned kings
                return DefaultValueOfTenJackQueenKing;
            }
            #endregion

        #endregion

        #region Properties

            #region BalancedSystem
            /// <summary>
            /// Is this system a Balanced System or not.
            /// In Balanced Systems the count will end up at zero if all of the cards are dealt out.
            /// </summary>
            public override bool BalancedSystem
            {
                get
                {
                    // this is a balanced system
                    return true;
                }
            }
            #endregion

            #region HelpLink
            /// <summary>
            /// This property returns the Name of this object.
            /// </summary>
            public override string HelpLink
            {
                get
                {
                    // return the name of this system
                    return InnerHelpLink;
                }
            }
            #endregion

            #region Level
            /// <summary>
            /// This read only property returns the difficulty of this system.
            /// </summary>
            public override CountingSystemLevelEnum Level
            {
                get
                {
                    // this is not for beginners, but it is not that complex.
                    return CountingSystemLevelEnum.Advanced;
                }
            }
            #endregion

            #region Name
            /// <summary>
            /// This property returns the Name of this object.
            /// </summary>
            public override string Name
            {
                get
                {
                    // return the name of this system
                    return SystemName;
                }
            }
            #endregion

            #region Notes
            /// <summary>
            /// This read only property returns any notes about a system
            /// </summary>
            public override string Notes
            {
                get
                {
                    // return any notes about this system
                    return InnerNotes;
                }
            }
            #endregion

        #endregion
        
    }
    #endregion

}
