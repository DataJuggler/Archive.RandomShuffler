

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;

#endregion

namespace CardCounter.Systems
{

    #region class BasicStrategySystem
    /// <summary>
    /// This class is used to not count, and used the tables for basic strategy.
    /// </summary>
    public class BasicStrategySystem : CardCountingSystemBase, ICardCountingSystem
    {
        
        #region Private Variables
         private const string SystemName = "Basic Strategy (No Count)";
         private const bool DoNotCountValue = false;
         private const string InternalNotes = "No Count";
         private const string InnerHelpLink = "http://www.blackjackinstitute.com/store/Basic_Strategy_Chart.php";
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
                    // does not apply to this
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
            
            #region IsCounting
            /// <summary>
            /// This property always returns false
            /// </summary>
            public new bool IsCounting
            {
                get 
                {
                    // always return false
                    return DoNotCountValue;
                }
                set 
                { 
                    // nothing happens here
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
                    // this is not a counting system, but it is still easy to learn and implement
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
            /// This read only property returns any notes for this system.
            /// </summary>
            public override string Notes
            {
                get
                {
                    // this is not a counting system, but it is still easy to learn and implement
                    return InternalNotes;
                }
            }
            #endregion

        #endregion
        
    }
    #endregion

}
