

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;
using DataJuggler.Core.RandomShuffler.Enumerations;

#endregion

namespace CardCounter.Systems
{

    #region class HighOptI
    /// <summary>
    /// This class implements the High Opt 1
    /// </summary>
    public class HighOptISystem : CardCountingSystemBase, ICardCountingSystem
    {
        
        #region Private Variables
        private const string SystemName = "High Opt I";
        private const double DefaultValueOfTwo = 0;
        private const int DefaultValueOfAce = 0;
        private const string InnerNotes = "A & 2 = 0";
        private const string InnerHelpLink = "http://blackjack.co.za/card-counting/hi-opt-1-count/";
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

            #region GetCountValueOfTwo(SuitEnum side = SuitEnum.Unknown);
            /// <summary>
            /// This method return the value for twos. In KISS II Red 2's count as a 1
            /// and black 2's count as a zero
            /// </summary>
            public override double GetCountValueOfTwo(SuitEnum suit = SuitEnum.Unknown)
            {
                // initial value
                double valueOfTwo = DefaultValueOfTwo;

                // return the defaut value for an Two
                return valueOfTwo;
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
                    return CountingSystemLevelEnum.Standard;
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
