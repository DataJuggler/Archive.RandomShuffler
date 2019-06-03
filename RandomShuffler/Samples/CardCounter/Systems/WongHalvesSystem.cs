

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;
using DataJuggler.Core.RandomShuffler.Enumerations;

#endregion

namespace CardCounter.Systems
{

    #region class WongHalvesSystem
    /// <summary>
    /// This class is a level 3 system that uses half points. 
    /// </summary>
    public class WongHalvesSystem : CardCountingSystemBase, ICardCountingSystem
    {
        
        #region Private Variables
         private const string SystemName = "Wong Halves";
         private const double DefaultValueOfTwo = .5;
         private const double DefaultValueOfSeven = .5;
         private const double DefaultValueOfFive = 1.5;
         private const double DefaultValueOfNine = -5;
         private const string InnerNotes = "Uses Fractions";
         private const string InnerHelpLink = "http://www.blackjackage.com/wong-halves.php";
        #endregion

        #region Methods

             #region GetCountValueOfTwo(SuitEnum side = SuitEnum.Unknown);
             /// <summary>
             /// This method return the value for twos. In the Wong Halves System 2's count as a .5.
             /// </summary>
             public override double GetCountValueOfTwo(SuitEnum suit = SuitEnum.Unknown)
             {
                 // return the DefaultValueOfTwo (.5)
                 return DefaultValueOfTwo;
             }
             #endregion

             #region GetCountValueOfFive(SuitEnum side = SuitEnum.Unknown);
             /// <summary>
             /// This method return the value for Five. In the Wong Halves System 5's count as a 1.5.
             /// </summary>
             public override double GetCountValueOfFive(SuitEnum suit = SuitEnum.Unknown)
             {
                 // return the DefaultValueOfFive (1.5)
                 return DefaultValueOfFive;
             }
             #endregion

             #region GetCountValueOfSeven(SuitEnum side = SuitEnum.Unknown);
             /// <summary>
             /// This method return the value for sevens. In the Wong Halves System 7's count as a .5.
             /// </summary>
             public override double GetCountValueOfSeven(SuitEnum suit = SuitEnum.Unknown)
             {
                 // return the DefaultValueOfSeven (.5)
                 return DefaultValueOfSeven;
             }
             #endregion

             #region GetCountValueOfNine(SuitEnum side = SuitEnum.Unknown);
             /// <summary>
             /// This method return the value for nines. In the Wong Halves System 9's count as a -.5.
             /// </summary>
             public override double GetCountValueOfNine(SuitEnum suit = SuitEnum.Unknown)
             {
                 // return the DefaultValueOfNine (-.5)
                 return DefaultValueOfNine;
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
