

#region using statements

using CardCounter.Interfaces;
using CardCounter.Enumerations;
using CardCounter.UI.Controls;
using DataJuggler.Core.UltimateHelper;
using CardCounter.Delegates;
using CardCounter.Objects;
using System.Collections.Generic;
using CardCounter.Factory;
using System.Drawing;

#endregion

namespace CardCounter.Actions
{

    #region class PlayerResponseRequestBaseClass
    /// <summary>
    /// This class is used as the base class for all player response requests
    /// </summary>
    public abstract class PlayerResponseRequestBaseClass : IPlayerResponseRequest
    {
        
        #region Private Variables
        private ButtonClickHandler buttonClickHandler;
        private PlayerResponse response;
        private ResponseRequestTypeEnum requestType;
        private double betAmount;
        private PlayerResponseControl playerResponseControl;
        private BlackJackPlayerControl blackJackPlayerControl;
        private List<ResponseTypeEnum> allowedResponseTypes;
        private Options houseRules;
        #endregion

        #region Parameterized Constructor(Options houseRules)
        /// <summary>
        /// Create a new instance of a PlayerResponseRequest object.
        /// </summary>
        /// <param name="houseRules"></param>
        public PlayerResponseRequestBaseClass(Options houseRules)
        {
            // You have to have the houseRules
            this.HouseRules = houseRules;
        }
        #endregion

        #region Methods

            #region PositionResponseControl(PlayerResponseControl responseControl, BlackJackPlayerControl1 playerControl)
            /// <summary>
            /// This method returns the Response Control
            /// </summary>
            protected Point PositionResponseControl(PlayerResponseControl responseControl, BlackJackPlayerControl playerControl)
            {
                // Create the point
                Point point = new Point();

                // If the PlayerControl object exists
                if (NullHelper.Exists(playerControl, responseControl))
                {
                    // get half of this control
                    int halfPlayerControl = playerControl.Width / 2;
                    int halfResponseControl = responseControl.Width / 2;
                    int adjustment = halfPlayerControl - halfResponseControl;

                    // Set the Horizontal Position
                    point.X = playerControl.Left + adjustment;

                    // Set the Vertical Position
                    point.Y = playerControl.Top + playerControl.Height - playerControl.GetChipsPanelHeight() - playerControl.GetPlayerInfoPanelHeight() + responseControl.Height;
                }

                // return value
                return point;
            }
            #endregion

            #region SetupButtons()
            /// <summary>
            /// This method the response should determine which buttons need to be shown, for each button the text and width
            /// are set and the button click handler is set.
            /// </summary>
            public void SetupButtons()
            {
                // If the PlayerResponseControl object exists
                if ((this.HasPlayerResponseControl) && (this.HasAllowedResponseTypes))
                {
                    // Create the ButtonDescriptors
                    List<ButtonDescriptor> buttonDescriptors = PlayerResponseFactory.CreateButtonDescriptors(this.AllowedResponseTypes); 

                    // Setup the Buttons and the width of the control based upon the ButtonDescriptors
                    this.PlayerResponseControl.SetupButtons(buttonDescriptors);

                    // Tell it what button click handler to use
                    this.PlayerResponseControl.ButtonClickHandler = this.ButtonClickHandler;
                }
            }
            #endregion

            #region Start(PlayerResponseControl responseControl, BlackJackPlayerControl1 playerControl)
            /// <summary>
            /// This method is called by the GameManager to get a players response based upon the ResponseType.
            /// </summary>
            public abstract PlayerResponse Start(PlayerResponseControl responseControl, BlackJackPlayerControl playerControl);
            #endregion

        #endregion

        #region Properties
            
            #region AllowedResponseTypes
            /// <summary>
            /// This property gets or sets the value for 'AllowedResponseTypes'.
            /// </summary>
            public List<ResponseTypeEnum> AllowedResponseTypes
            {
                get { return allowedResponseTypes; }
                set { allowedResponseTypes = value; }
            }
            #endregion
            
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
            
            #region BlackJackPlayerControl1
            /// <summary>
            /// This property gets or sets the value for 'BlackJackPlayerControl1'.
            /// </summary>
            public BlackJackPlayerControl BlackJackPlayerControl
            {
                get { return blackJackPlayerControl; }
                set { blackJackPlayerControl = value; }
            }
            #endregion
            
            #region ButtonClickHandler
            /// <summary>
            /// This property gets or sets the value for 'Button1ClickHandler'.
            /// </summary>
            public ButtonClickHandler ButtonClickHandler
            {
                get { return buttonClickHandler; }
                set { buttonClickHandler = value; }
            }
            #endregion
            
            #region HasAllowedResponseTypes
            /// <summary>
            /// This property returns true if this object has an 'AllowedResponseTypes'.
            /// </summary>
            public bool HasAllowedResponseTypes
            {
                get
                {
                    // initial value
                    bool hasAllowedResponseTypes = (this.AllowedResponseTypes != null);
                    
                    // return value
                    return hasAllowedResponseTypes;
                }
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
            
            #region HasBlackJackPlayerControl
            /// <summary>
            /// This property returns true if this object has a 'BlackJackPlayerControl1'.
            /// </summary>
            public bool HasBlackJackPlayerControl
            {
                get
                {
                    // initial value
                    bool hasBlackJackPlayerControl = (this.BlackJackPlayerControl != null);
                    
                    // return value
                    return hasBlackJackPlayerControl;
                }
            }
            #endregion
            
            #region HasButtonClickHandler
            /// <summary>
            /// This property returns true if this object has a 'Button1ClickHandler'.
            /// </summary>
            public bool HasButtonClickHandler
            {
                get
                {
                    // initial value
                    bool hasButtonClickHandler = NullHelper.Exists(this.ButtonClickHandler);
                    
                    // return value
                    return hasButtonClickHandler;
                }
            }
            #endregion
            
            #region HasHouseRules
            /// <summary>
            /// This property returns true if this object has a 'HouseRules'.
            /// </summary>
            public bool HasHouseRules
            {
                get
                {
                    // initial value
                    bool hasHouseRules = (this.HouseRules != null);
                    
                    // return value
                    return hasHouseRules;
                }
            }
            #endregion
            
            #region HasPlayerResponseControl
            /// <summary>
            /// This property returns true if this object has a 'PlayerResponseControl'.
            /// </summary>
            public bool HasPlayerResponseControl
            {
                get
                {
                    // initial value
                    bool hasPlayerResponseControl = (this.PlayerResponseControl != null);
                    
                    // return value
                    return hasPlayerResponseControl;
                }
            }
            #endregion
            
            #region HasRequestType
            /// <summary>
            /// This property returns true if this object has a 'RequestType'.
            /// </summary>
            public bool HasRequestType
            {
                get
                {
                    // initial value
                    bool hasRequestType = (this.RequestType != ResponseRequestTypeEnum.Unknown);
                    
                    // return value
                    return hasRequestType;
                }
            }
            #endregion
            
            #region HasResponse
            /// <summary>
            /// This property returns true if this object has a 'Response'.
            /// </summary>
            public bool HasResponse
            {
                get
                {
                    // initial value
                    bool hasResponse = (this.Response != null);
                    
                    // return value
                    return hasResponse;
                }
            }
            #endregion
            
            #region HouseRules
            /// <summary>
            /// This property gets or sets the value for 'HouseRules'.
            /// </summary>
            public Options HouseRules
            {
                get { return houseRules; }
                set { houseRules = value; }
            }
            #endregion
            
            #region PlayerResponseControl
            /// <summary>
            /// This property gets or sets the value for 'PlayerResponseControl'.
            /// </summary>
            public PlayerResponseControl PlayerResponseControl
            {
                get { return playerResponseControl; }
                set { playerResponseControl = value; }
            }
            #endregion
            
            #region RequestType
            /// <summary>
            /// This property gets or sets the value for 'RequestType'.
            /// </summary>
            public ResponseRequestTypeEnum RequestType
            {
                get { return requestType; }
                set { requestType = value; }
            }
            #endregion
            
            #region Response
            /// <summary>
            /// This property gets or sets the value for 'Response'.
            /// </summary>
            public PlayerResponse Response
            {
                get { return response; }
                set { response = value; }
            }
            #endregion

            #region TableMaximum
            /// <summary>
            /// This property gets or sets the value for 'TableMaximum'.
            /// </summary>
            public int TableMaximum
            {
                get
                {
                    // initial value
                    int tableMaximum = 10000;

                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the return value
                        tableMaximum = (int) HouseRules.TableMaximum;
                    }

                    // return value
                    return tableMaximum;
                }
                set
                {
                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the value
                        HouseRules.TableMaximum = value;
                    }
                }
            }
            #endregion

            #region TableMinimum
            /// <summary>
            /// This property gets or sets the value for 'TableMinimum'.
            /// </summary>
            public int TableMinimum
            {
                get
                {
                    // initial value
                    int tableMinimum = 5;

                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the return value
                        tableMinimum = (int)HouseRules.TableMinimum;
                    }

                    // return value
                    return tableMinimum;
                }
                set
                {
                    // if the control exists
                    if (HouseRules != null)
                    {
                        // set the value
                        HouseRules.TableMinimum = value;
                    }
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
