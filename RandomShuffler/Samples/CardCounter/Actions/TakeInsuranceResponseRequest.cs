

#region using statements

using CardCounter.Interfaces;
using CardCounter.Objects;
using CardCounter.UI.Controls;
using CardCounter.Enumerations;
using System.Drawing;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic;
using DataJuggler.Core.RandomShuffler;

#endregion

namespace CardCounter.Actions
{

    #region TakeInsuranceResponseRequest : PlayerResponseRequestBaseClass, IPlayerResponseRequest 
    /// <summary>
    ///  This class is used to get the users response if they want to Take Insurance or not.
    /// </summary>
    public class TakeInsuranceResponseRequest : PlayerResponseRequestBaseClass, IPlayerResponseRequest
    {

        #region Constructor
        /// <summary>
        /// Create a new instance of a PlaceBetResponseRequest
        /// </summary>
        /// <param name="houseRules"></param>
        public TakeInsuranceResponseRequest(Options houseRules) : base(houseRules)
        {
            // Setup the ButtonClickHandler
            base.ButtonClickHandler = this.ButtonClickHandler;
        }   
        #endregion

        #region Events

            #region ButtonClickHandler(int buttonNumber, string buttonText)
            /// <summary>
            /// Setup the ButtonClickHandler
            /// </summary>
            /// <param name="buttonNumber"></param>
            /// <param name="buttonText"></param>
            public new void ButtonClickHandler(int buttonNumber, string buttonText)
            {
                // Determine the action by the buttonNumber
                switch (buttonNumber)
                {
                    case 1:

                        // If the BlackJackPlayerControl1 object exists
                        if ((this.HasBlackJackPlayerControl) && (this.BlackJackPlayerControl.HasPlayer) && (this.BlackJackPlayerControl.Player.HasCurrentHand))
                        {
                            // Create the response
                            this.Response = new PlayerResponse(ResponseTypeEnum.Insurance);

                            // if the PlayerResponseControl exists
                            if ((this.HasPlayerResponseControl) && (this.PlayerResponseControl.HasSendResponseCallBack))
                            {
                                // Send the response
                                this.PlayerResponseControl.SendResponseCallBack(this.Response);

                                // Hide this control
                                this.PlayerResponseControl.Visible = false;
                            }
                        }

                        // required
                        break;

                     case 2:

                        // If the BlackJackPlayerControl1 object exists
                        if ((this.HasBlackJackPlayerControl) && (this.BlackJackPlayerControl.HasPlayer) && (this.BlackJackPlayerControl.Player.HasCurrentHand))
                        {
                            // Create the response
                            this.Response = new PlayerResponse(ResponseTypeEnum.No);

                            // if the PlayerResponseControl exists
                            if ((this.HasPlayerResponseControl) && (this.PlayerResponseControl.HasSendResponseCallBack))
                            {
                                // Send the response
                                this.PlayerResponseControl.SendResponseCallBack(this.Response);

                                // Hide this control
                                this.PlayerResponseControl.Visible = false;
                            }
                        }

                        // required
                        break;

                }
            }
            #endregion

        #endregion
        
        #region Methods

            #region Start(PlayerResponseControl responseControl, BlackJackPlayerControl1 playerControl)
            /// <summary>
            /// This method is used to get the users response.
            /// </summary>
            /// <returns></returns>
            public override PlayerResponse Start(PlayerResponseControl responseControl, BlackJackPlayerControl playerControl)
            {
                // Set the ResponseControl
                this.PlayerResponseControl = responseControl;

                // Create the AllowResponses
                this.AllowedResponseTypes = new List<ResponseTypeEnum>();
                this.AllowedResponseTypes.Add(ResponseTypeEnum.Insurance);
                this.AllowedResponseTypes.Add(ResponseTypeEnum.No);

                // Set the Request Type
                this.RequestType = ResponseRequestTypeEnum.Insurance;
                
                // Setup the Button
                this.SetupButtons();

                // position the responseControl based upon the SeatNumber
                responseControl.Location = PositionResponseControl(responseControl, playerControl);

                // Show the ResponseControl
                responseControl.Show();

                // Make sure Show toggles this
                responseControl.Visible = true;

                // return this object
                return this.Response;
            }
            #endregion

        #endregion
        
    }
    #endregion

}
