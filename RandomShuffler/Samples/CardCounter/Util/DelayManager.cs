

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

#endregion

namespace CardCounter.Util
{

    #region class DelayManager
    /// <summary>
    /// This class is used to replace System.Threading.Sleep because Sleep adds a delay plus any time that was lost 
    /// displaying any graphics or other long running processes. This class keeps track of the LastActionTime and 
    /// adds the milliseconds of the new ActionTime in an attempt to speed the game up.
    /// </summary>
    public class DelayManager
    {
        
        #region Private Variables
        private DateTime lastActionTime;
        #endregion

        #region Methods

            #region Delay(int gamePause)
            /// <summary>
            /// This method delays the game until the LastActionTime + gamePause (milliseconds) is reached.
            /// </summary>
            /// <param name="gamePause"></param>
            public void Delay(int gamePause)
            {
                DateTime nextActionTime = new DateTime(1900, 1, 1);

                // set the LastActionTime
                if (this.HasLastActionTime)
                {
                    // add the milliseconds 
                    nextActionTime = this.LastActionTime.AddMilliseconds(gamePause);
                }
                else
                {
                    // add the milliseconds 
                    nextActionTime = DateTime.Now.AddMilliseconds(gamePause);
                }

                do
                {  
                    // exit the loop
                    if (DateTime.Now > nextActionTime)
                    {
                        // break out of the loop
                        break;
                    }

                    // Sleep for 250 milliseconds
                    System.Threading.Thread.Sleep(250);

                } while (true);

                // Set the LastActionTime
                this.LastActionTime = DateTime.Now;
            }
            #endregion

        #endregion

        #region Properties

            #region HasLastActionTime
            /// <summary>
            /// This property returns true if this object has a 'LastActionTime' set
            /// </summary>
            public bool HasLastActionTime
            {
                get
                {
                    // initial value
                    bool hasLastActionTime = (this.LastActionTime.Year >= (DateTime.Now.Year - 1));
                    
                    // return value
                    return hasLastActionTime;
                }
            }
            #endregion
            
            #region LastActionTime
            /// <summary>
            /// This property gets or sets the value for 'LastActionTime'.
            /// </summary>
            public DateTime LastActionTime
            {
                get { return lastActionTime; }
                set { lastActionTime = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
