

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;

#endregion

namespace CardCounter.Systems
{

    #region class HighLowSystem
    /// <summary>
    /// This class is a very simple counting system for beginning counters.
    /// </summary>
    public class HighLowSystem : CardCountingSystemBase, ICardCountingSystem
    {
        
        #region Private Variables
        private const string SystemName = "High - Low";
        private const string InnerNotes = "For Beginners";
        private const string InnerHelpLink = "http://blackjack.co.za/card-counting/high-low-count/";
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
