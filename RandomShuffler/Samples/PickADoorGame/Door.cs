

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PickADoorGame.Enumerations;

#endregion

namespace PickADoorGame
{

    #region class Door
    /// <summary>
    /// This class respresents a door.
    /// </summary>
    public class Door
    {
        
        #region Private Variables
        private int doorNumber;
        private bool userSelected;
        private BehindClosedDoorEnum whatIsBehind;
        #endregion

        #region Methods

            #region ToString()
            /// <summary>
            /// This method returns the String
            /// </summary>
            public override string ToString()
            {
                // local
                string info = "";

                // If the value for the property this.UserSelected is true
                if (this.UserSelected)
                {
                    // initial value
                    info = "Door Number: " + this.DoorNumber.ToString() + " - What is behind: " + this.WhatIsBehind.ToString() + " (selected)";
                }
                else
                {
                    // initial value
                    info = "Door Number: " + this.DoorNumber.ToString() + " - What is behind: " + this.WhatIsBehind.ToString();
                }
                
                // return value
                return info;
            }
            #endregion
            
        #endregion
        
        #region Properties
            
            #region DoorNumber
            /// <summary>
            /// This property gets or sets the value for 'DoorNumber'.
            /// </summary>
            public int DoorNumber
            {
                get { return doorNumber; }
                set { doorNumber = value; }
            }
            #endregion
            
            #region UserSelected
            /// <summary>
            /// This property gets or sets the value for 'UserSelected'.
            /// </summary>
            public bool UserSelected
            {
                get { return userSelected; }
                set { userSelected = value; }
            }
            #endregion
            
            #region WhatIsBehind
            /// <summary>
            /// This property gets or sets the value for 'WhatIsBehind'.
            /// </summary>
            public BehindClosedDoorEnum WhatIsBehind
            {
                get { return whatIsBehind; }
                set { whatIsBehind = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
