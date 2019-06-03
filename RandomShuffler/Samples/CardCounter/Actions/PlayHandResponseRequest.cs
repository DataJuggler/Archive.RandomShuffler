

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

    #region PlaceBetResponseRequest : PlayerResponseRequestBaseClass, IPlayerResponseRequest 
    /// <summary>
    ///     This class is used to get the users response(s) after 'Take Insurance', 'Split'
    ///     and / or Double Down have completed. This request will keep prompting
    ///     the player to either Hit or Stand until the player stands or busts (exceeds 21).
    /// </summary>
    public class PlayHandResponseRequest : PlayerResponseRequestBaseClass, IPlayerResponseRequest
    {

        #region Constructor
        /// <summary>
        /// Create a new instance of a PlaceBetResponseRequest
        /// </summary>
        /// <param name="houseRules"></param>
        public PlayHandResponseRequest(Options houseRules) : base(houseRules)
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
                // local
                Player player = null;

                 // If the BlackJackPlayerControl1 object exists
                if ((this.HasBlackJackPlayerControl) && (this.BlackJackPlayerControl.HasPlayer))
                {
                    // Set the Player
                    player = this.BlackJackPlayerControl.Player;
                }

                // if the player exists and he/she has a CurrentHand and they are not sitting out
                if ((NullHelper.Exists(player)) && (player.HasCurrentHand) && (!player.CurrentHand.SittingOut))
                {
                    // Determine the action by the buttonNumber
                    switch (buttonNumber)
                    {
                        case 1:

                            // Hit

                            // Create the response
                            this.Response = new Actions.PlayerResponse(ResponseTypeEnum.Hit);
                                                        
                            // required
                            break;

                        case 2:

                            // Create the response
                            this.Response = new Actions.PlayerResponse(ResponseTypeEnum.Stand);

                            // required
                            break;
                    }
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
                this.AllowedResponseTypes.Add(ResponseTypeEnum.Hit);
                this.AllowedResponseTypes.Add(ResponseTypeEnum.Stand);
                
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
