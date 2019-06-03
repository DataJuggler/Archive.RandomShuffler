

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace PickADoorGame
{

    #region CanPullNextItemCallBack();
    /// <summary>
    /// This delegate is used to pull an item from the same shuffler.
    /// Each time a PickADoorSimulator needs an item it calls back to this method;
    /// since there are multiple simulations that each need 4 values you should set
    /// the total simulations to a higher number so you get more randomness.    /// 
    /// </summary>
    /// <returns></returns>
    public delegate bool CanPullNextItemCallBack();
    #endregion

    #region PullNextItemCallBack();
    /// <summary>
    /// This delegate is used to pull an item from the same shuffler.
    /// Each time a PickADoorSimulator needs an item it calls back to this method;
    /// since there are multiple simulations that each need 4 values you should set
    /// the total simulations to a higher number so you get more randomness.    /// 
    /// </summary>
    /// <returns></returns>
    public delegate int PullNextItemCallBack();
    #endregion

    #region class RandomDoorCallBack
    /// <summary>
    /// This class is used so two delegates can be passed to a simulator as one object.
    /// </summary>
    public class RandomDoorCallBack
    {
        
        #region Private Variables
        private CanPullNextItemCallBack canPullNextItemCallBack;
        private PullNextItemCallBack pullNextItemCallBack;
        #endregion

        #region Parameterized Constructor(CanPullNextItemCallBack canPullNextItemCallBack, PullNextItemCallBack pullNextItemCallBack)
        /// <summary>
        /// Create a new instance of a RandomDoorCallBack
        /// </summary>
        /// <param name="canPullNextItemCallBack"></param>
        /// <param name="pullNextItemCallBack"></param>
        public RandomDoorCallBack(CanPullNextItemCallBack canPullNextItemCallBack, PullNextItemCallBack pullNextItemCallBack)
        {
            // Store the parameters
            this.CanPullNextItemCallBack = canPullNextItemCallBack;
            this.PullNextItemCallBack = pullNextItemCallBack;
        }
        #endregion

        #region Methods

            #region CanPullNextItem()
            /// <summary>
            /// This read only method returns true if the CanPullNextItemCallBack exists and if it returns true.
            /// </summary>
            /// <returns></returns>
            public bool CanPullNextItem()
            {
                // initial value
                bool canPullNextItem = false;

                // If the CanPullNextItemCallBack object exists
                if (this.HasCanPullNextItemCallBack)
                {
                    // set the return value
                    canPullNextItem = this.CanPullNextItemCallBack();
                }

                // return value
                return canPullNextItem;
            }
            #endregion

            #region PullNextItem()
            /// <summary>
            /// This read only method returns true if the CanPullNextItemCallBack exists and if it returns true.
            /// </summary>
            /// <returns></returns>
            public int PullNextItem()
            {
                // initial value
                int nextItem = 0;

                // If the PullNextItemCallBack object exists
                if (this.HasPullNextItemCallBack)
                {
                    // set the return value
                    nextItem = this.PullNextItemCallBack();
                }

                // return value
                return nextItem;
            }
            #endregion

        #endregion

        #region Properties
          
            #region CanPullNextItemCallBack
            /// <summary>
            /// This property gets or sets the value for 'CanPullNextItemCallBack'.
            /// </summary>
            private CanPullNextItemCallBack CanPullNextItemCallBack
            {
                get { return canPullNextItemCallBack; }
                set { canPullNextItemCallBack = value; }
            }
            #endregion
            
            #region HasCanPullNextItemCallBack
            /// <summary>
            /// This property returns true if this object has a 'CanPullNextItemCallBack'.
            /// </summary>
            private bool HasCanPullNextItemCallBack
            {
                get
                {
                    // initial value
                    bool hasCanPullNextItemCallBack = (this.CanPullNextItemCallBack != null);
                    
                    // return value
                    return hasCanPullNextItemCallBack;
                }
            }
            #endregion
            
            #region HasPullNextItemCallBack
            /// <summary>
            /// This property returns true if this object has a 'PullNextItemCallBack'.
            /// </summary>
            private bool HasPullNextItemCallBack
            {
                get
                {
                    // initial value
                    bool hasPullNextItemCallBack = (this.PullNextItemCallBack != null);
                    
                    // return value
                    return hasPullNextItemCallBack;
                }
            }
            #endregion
            
            #region PullNextItemCallBack
            /// <summary>
            /// This property gets or sets the value for 'PullNextItemCallBack'.
            /// </summary>
            private PullNextItemCallBack PullNextItemCallBack
            {
                get { return pullNextItemCallBack; }
                set { pullNextItemCallBack = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
