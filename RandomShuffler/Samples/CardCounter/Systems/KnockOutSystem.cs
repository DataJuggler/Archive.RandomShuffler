

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;
using DataJuggler.Core.RandomShuffler.Enumerations;

#endregion

namespace CardCounter.Systems
{

    #region class KnockOutSystem
    /// <summary>
    /// This class is a very simple counting system for beginning counters.
    /// The advantage of the KnockoutSystem is there is only One Count, there is not a true count and a running count.
    /// </summary>
    public class KnockOutSystem : CardCountingSystemBase, ICardCountingSystem
    {
        
        #region Private Variables
         private const string SystemName = "Knock Out";
         private const double DefaultValueOfSeven = 1;
         private const string InnerNotes = "7 = +1";
         private const string InnerHelpLink = "http://blackjack.co.za/card-counting/ko-count/";
        #endregion

        #region Methods

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
                    // this is not a balanced system
                    return false;
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
                    // this is an easy system to learn
                    return CountingSystemLevelEnum.Easy;
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
