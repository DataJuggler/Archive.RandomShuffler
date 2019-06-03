

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace CardCounter.Objects
{

    #region class AllowedResponseManager
    /// <summary>
    /// This class is created by the dealer and before a 'Player' is prompted for a response
    /// there will always be an AllowedResponseManager created before the user is asked to decide.
    /// A player can always 'Hit' or 'Stand' so those choices are not listed in this class.
    /// </summary>
    public class AllowedResponseManager
    {           
            
        #region Private Variables
        private bool allowSplit;
        private bool allowDoubleDown;
        private bool allowSurrender;
        private bool allowInsurance;
        #endregion

        #region Constructors
            
            #region Default Constructor
        
                #region AllowedResponseManager()
                /// <summary>
                /// Create a new instance of an AllowedResponseManager object
                /// </summary>
                public AllowedResponseManager()
                {
                    
                }
                #endregion

                #region Parameterized Constructor((bool allowDoubleDown, bool allowInsurance, bool allowSplit, bool allowSurrender)
                /// <summary>
                /// Create a new instance of an AllowResponse object and set the values for the allowed responses.
                /// </summary>
                /// <param name="allowDoubleDown">This is only true if the Options class has AllowDoubleDown set to true
                /// and if the Player has only been dealt two cards. </param>
                /// <param name="allowInsurance"></param>
                /// <param name="allowSplit"></param>
                /// <param name="allowSurrender"></param>
                public AllowedResponseManager(bool allowDoubleDown, bool allowInsurance, bool allowSplit, bool allowSurrender)
                {
                    this.AllowDoubleDown = allowDoubleDown;
                    this.AllowInsurance = allowInsurance;
                    this.AllowSplit = allowSplit;
                    this.AllowSurrender = allowSurrender;
                }
                #endregion

            #endregion

        #endregion

        #region Properties

            #region AllowDoubleDown
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleDown'.
            /// </summary>
            public bool AllowDoubleDown
            {
                get { return allowDoubleDown; }
                set { allowDoubleDown = value; }
            }
            #endregion

            #region AllowInsurance
            /// <summary>
            /// This property gets or sets the value for 'AllowInsurance'.
            /// </summary>
            public bool AllowInsurance
            {
                get { return allowInsurance; }
                set { allowInsurance = value; }
            }
            #endregion

            #region AllowSplit
            /// <summary>
            /// This property gets or sets the value for 'AllowSplit'.
            /// </summary>
            public bool AllowSplit
            {
                get { return allowSplit; }
                set { allowSplit = value; }
            }
            #endregion

            #region AllowSurrender
            /// <summary>
            /// This property gets or sets the value for 'AllowSurrender'.
            /// </summary>
            public bool AllowSurrender
            {
                get { return allowSurrender; }
                set { allowSurrender = value; }
            }
            #endregion

        #endregion

    }
    #endregion

}
