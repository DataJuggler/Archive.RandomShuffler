

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCounter.Enumerations;

#endregion

namespace CardCounter.Actions
{

    #region class PlayerResponse
    /// <summary>
    /// This class represents a players response. 
    /// </summary>
    public class PlayerResponse
    {
        
        #region Private Variables
        private ResponseTypeEnum responseType;
        private ResponseRequestTypeEnum responseRequestType;
        private double betAmount;
        #endregion

        #region PlayerResponse(ResponseTypeEnum responseRequestType, double betAmount = 0)
        /// <summary>
        /// Create a new instance of a PlayerResponse object.
        /// </summary>
        /// <param name="responseRequestType"></param>
        public PlayerResponse(ResponseTypeEnum responseType, double betAmount = 0)
        {
            // Set the responseRequestType
            this.ResponseType = responseType;
            
            // Set the BetAmount in case it is used
            this.BetAmount = betAmount;
        }
        #endregion

        #region Properties

            #region BetAmount
            /// <summary>
            /// This property gets or sets the value for 'BetAmount'.
            /// </summary>
            public double BetAmount
            {
                get { return betAmount; }
                set { betAmount = value; }
            }
            #endregion
            
            #region HasBetAmount
            /// <summary>
            /// This property returns true if the 'BetAmount' is set.
            /// </summary>
            public bool HasBetAmount
            {
                get
                {
                    // initial value
                    bool hasBetAmount = (this.BetAmount > 0);
                    
                    // return value
                    return hasBetAmount;
                }
            }
            #endregion
            
            #region HasResponseRequestType
            /// <summary>
            /// This property returns true if this object has a 'ResponseRequestType'.
            /// </summary>
            public bool HasResponseRequestType
            {
                get
                {
                    // initial value
                    bool hasResponseRequestType = (this.ResponseRequestType != ResponseRequestTypeEnum.Unknown);
                    
                    // return value
                    return hasResponseRequestType;
                }
            }
            #endregion
            
            #region HasResponseType
            /// <summary>
            /// This property returns true if this object has a 'ResponseType'.
            /// </summary>
            public bool HasResponseType
            {
                get
                {
                    // initial value
                    bool hasResponseType = (this.ResponseType != ResponseTypeEnum.Unknown);
                    
                    // return value
                    return hasResponseType;
                }
            }
            #endregion
            
            #region ResponseRequestType
            /// <summary>
            /// This property gets or sets the value for 'ResponseRequestType'.
            /// </summary>
            public ResponseRequestTypeEnum ResponseRequestType
            {
                get { return responseRequestType; }
                set { responseRequestType = value; }
            }
            #endregion
            
            #region ResponseType
            /// <summary>
            /// This property gets or sets the value for 'ResponseType'.
            /// </summary>
            public ResponseTypeEnum ResponseType
            {
                get { return responseType; }
                set { responseType = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
