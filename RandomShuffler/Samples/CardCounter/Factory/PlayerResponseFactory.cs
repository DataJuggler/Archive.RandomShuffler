

#region using statements

using CardCounter.Actions;
using CardCounter.Enumerations;
using CardCounter.Interfaces;
using CardCounter.Objects;
using CardCounter.UI.Controls;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic;

#endregion

namespace CardCounter.Factory
{

    #region class PlayerResponseFactory
    /// <summary>
    /// This factory is used to create Responses based upon the ResponseType.
    /// </summary>
    public class PlayerResponseFactory
    {

        #region Private Variables
        public const int SlimButtonWidth = 80;
        public const int DefaultButtonWidth = 120;
        public const int WideButtonWidth = 160;
        public const int ExtraWideButtonWidth = 200;
        #endregion
        
        #region Methods

            #region CreateButtonDescriptors(List<ResponseTypeEnum> allowResponseTypes)
            /// <summary>
            /// This method creates the ButtonDescriptors for each ResposneType that could end up as a button click.
            /// This separates the presentation layer from the implementation of the response request in case it chances.
            /// </summary>
            internal static List<ButtonDescriptor> CreateButtonDescriptors(List<ResponseTypeEnum> allowResponseTypes)
            {
                // initial value
                List<ButtonDescriptor> buttonDescriptors = null;

                // If the allowResponseTypes collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(allowResponseTypes))
                {
                    // Create the return collection
                    buttonDescriptors = new List<ButtonDescriptor>();

                    // Iterate the collection of ResponseTypeEnum objects
                    foreach (ResponseTypeEnum allowedResponseType in allowResponseTypes)
                    {
                        switch (allowedResponseType)
                        {
                            case ResponseTypeEnum.PlaceBet:

                                // Create the buttonDescriptor
                                ButtonDescriptor placeBetButtonDescriptor = new ButtonDescriptor("Place Bet", DefaultButtonWidth);

                                // Add this item
                                buttonDescriptors.Add(placeBetButtonDescriptor);

                                // required
                                break;

                            case ResponseTypeEnum.SitOut:

                                // Create the buttonDescriptor
                                ButtonDescriptor sitOutButtonDescriptor = new ButtonDescriptor("Sit Out", DefaultButtonWidth);

                                // Add this item
                                buttonDescriptors.Add(sitOutButtonDescriptor);

                                // required
                                break;

                            case ResponseTypeEnum.Hit:

                                // Create the buttonDescriptor
                                ButtonDescriptor hitButtonDescriptor = new ButtonDescriptor("Hit", DefaultButtonWidth);

                                // Add this item
                                buttonDescriptors.Add(hitButtonDescriptor);

                                // required
                                break;

                            case ResponseTypeEnum.Stand:

                                // Create the buttonDescriptor
                                ButtonDescriptor standButtonDescriptor = new ButtonDescriptor("Stand", DefaultButtonWidth);

                                // Add this item
                                buttonDescriptors.Add(standButtonDescriptor);

                                // required
                                break;

                            case ResponseTypeEnum.Insurance:

                                // Create the buttonDescriptor
                                ButtonDescriptor insuranceButtonDescriptor = new ButtonDescriptor("Insurance?", ExtraWideButtonWidth);

                                // Add this item
                                buttonDescriptors.Add(insuranceButtonDescriptor);

                                // required
                                break;

                            case ResponseTypeEnum.No:

                                // Create the buttonDescriptor
                                ButtonDescriptor noButtonDescriptor = new ButtonDescriptor("No", SlimButtonWidth);

                                // Add this item
                                buttonDescriptors.Add(noButtonDescriptor);

                                // required
                                break;
                        }
                    }
                }

                // return value
                return buttonDescriptors;
            }
            #endregion

            #region CreatePlayerResponseRequest(ResponseRequestTypeEnum responseRequestType, PlayerResponseControl playerResponseControl, BlackJackPlayerControl1 blackJackPlayerControl, Options  houseRules)
            /// <summary>
            /// This method creates the Response Request before prompting the user for an Action.
            /// </summary>
            /// <param name="responseRequestType"></param>
            public static IPlayerResponseRequest CreatePlayerResponseRequest(ResponseRequestTypeEnum responseRequestType, PlayerResponseControl playerResponseControl, BlackJackPlayerControl blackJackPlayerControl, Options houseRules)
            {
                // initial valule
                IPlayerResponseRequest playerResponseRequest = null;

                // Determine the action by the responseRequestType
                switch (responseRequestType)
                {
                    case ResponseRequestTypeEnum.PlaceBet:

                        // Create a placeBetResponse
                        playerResponseRequest = new PlaceBetResponseRequest(houseRules);

                        // required
                        break;

                    case ResponseRequestTypeEnum.PlayHand:

                        // Create a placeBetResponse
                        playerResponseRequest = new PlayHandResponseRequest(houseRules);

                        // required
                        break;

                    case ResponseRequestTypeEnum.Insurance:

                        // Create a placeBetResponse
                        playerResponseRequest = new TakeInsuranceResponseRequest(houseRules);

                        // required
                        break;
                }

                // if the request exists
                if (NullHelper.Exists(playerResponseRequest))
                {
                    // Setup the controls
                    playerResponseRequest.BlackJackPlayerControl = blackJackPlayerControl;
                    playerResponseRequest.PlayerResponseControl = playerResponseControl;
                }

                // return value
                return playerResponseRequest;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
