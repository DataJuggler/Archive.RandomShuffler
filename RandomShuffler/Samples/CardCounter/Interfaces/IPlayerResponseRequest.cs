

#region using statements

using CardCounter.Enumerations;
using CardCounter.Objects;
using CardCounter.Actions;
using CardCounter.UI.Controls;
using CardCounter.Delegates;
using DataJuggler.Core.RandomShuffler.Enumerations;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.RandomShuffler.Interfaces;
using System.Collections.Generic;

#endregion

namespace CardCounter.Interfaces
{

    #region interface ICardCountingSystem
    /// <summary>
    /// This is an interface all PlayerResponses must implement
    /// </summary>
    public interface IPlayerResponseRequest
    {
        
        #region Methods

            #region  SetupButtons();
            /// <summary>
            /// This method the response should determine which buttons need to be shown, setup the text, and the delegates
            /// for each button click that is handled.
            /// </summary>
            void SetupButtons();
            #endregion

            #region Start(PlayerResponseControl responseControl, BlackJackPlayerControl1 playerControl)
            /// <summary>
            /// The interface must have a Start method. This must be implemented in a derived class.
            /// </summary>
            PlayerResponse Start(PlayerResponseControl responseControl, BlackJackPlayerControl playerControl);
            #endregion

        #endregion

        #region Properties

            #region AllowedResponseTypes
            /// <summary>
            /// This interface must contain the allowed response types.
            /// this is used to determine which buttons to show
            /// </summary>
            List<ResponseTypeEnum> AllowedResponseTypes
            {
                get;
                set;
            }
            #endregion

            #region BlackJackPlayerControl1
            /// <summary>
            /// This is the control that displays the user and holds the BetTextBox
            /// </summary>
            BlackJackPlayerControl BlackJackPlayerControl
            {
                get;
                set;
            }
            #endregion
            
            #region ButtonClickHandler
            /// <summary>
            /// Each response must have a handler for each button.
            /// Any buttons that are visible must have a handler.
            /// </summary>
            ButtonClickHandler ButtonClickHandler
            {
                get;
                set;
            }
            #endregion

            #region HasAllowedResponseTypes
            /// <summary>
            /// This read only property must return true if the AllowedResponseTypes collection exists.
            /// </summary>
            bool HasAllowedResponseTypes
            {
                get;
            }
            #endregion

            #region HasBetAmount
            /// <summary>
            /// This read only property must return true if the BetAmount is set
            /// </summary>
            bool HasBetAmount
            {
                get;
            }
            #endregion

            #region HasBlackJackPlayerControl
            /// <summary>
            /// This read only property must return true if the BlackJackPlayerControl1 exists
            /// </summary>
            bool HasBlackJackPlayerControl
            {
                get;
            }
            #endregion

            #region HasButtonClickHandler
            /// <summary>
            /// This read only property must return true if the Button1ClickHandler exists
            /// </summary>
            bool HasButtonClickHandler
            {
                get;
            }
            #endregion

            #region HasRequestType
            /// <summary>
            /// This read only property must return true if the RequestType is anything but Unknown
            /// </summary>
            bool HasRequestType
            {
                get;
            }
            #endregion

            #region HasResponse
            /// <summary>
            /// This read only property must return true if the Response is anything but Unknown
            /// </summary>
            bool HasResponse
            {
                get;
            }
            #endregion

            #region HasPlayerResponseControl
            /// <summary>
            /// This read only property must return true if the PlayerResponseControl exists
            /// </summary>
            bool HasPlayerResponseControl
            {
                get;
            }
            #endregion

            #region PlayerResponseControl
            /// <summary>
            /// This is the controlt that is shown to the user to get the users response
            /// </summary>
            PlayerResponseControl PlayerResponseControl
            {
                get;
                set;
            }
            #endregion

            #region RequestType
            /// <summary>
            /// This is the type
            /// </summary>
            ResponseRequestTypeEnum RequestType
            {
                get;
                set;
            }
            #endregion

            #region Response
            /// <summary>
            /// This is the Response the user choose.
            /// </summary>
            PlayerResponse Response
            {
                get;
                set;
            }
            #endregion

            #region TableMaximum
            /// <summary>
            /// The maximum bet a player can make
            /// </summary>
            int TableMaximum
            {
                get;
            }
            #endregion

            #region TableMinimum
            /// <summary>
            /// The minimum bet a player can make
            /// </summary>
            int TableMinimum
            {
                get;
            }
            #endregion
        
        #endregion
            
    }
    #endregion

}
