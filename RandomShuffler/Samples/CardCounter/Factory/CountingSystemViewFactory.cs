

#region using statements

using CardCounter.Enumerations;
using CardCounter.Interfaces;
using CardCounter.Objects;
using DataJuggler.Core.RandomShuffler.Enumerations;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic;

#endregion

namespace CardCounter.Factory
{

    #region class CountingSystemViewFactory
    /// <summary>
    /// This class is used to convert an ICardCountingSystem to a CardCountingView object.
    /// </summary>
    public class CountingSystemViewFactory
    {
        
        #region Methods
   
            #region Convert(System.Collections.Generic.List<ICardCountingSystem> countingSystemsList)
            /// <summary>
            /// This method returns a list of
            /// </summary>
            internal static List<CountingSystemView> Convert(System.Collections.Generic.List<ICardCountingSystem> countingSystemsList)
            {
                // list of counting systems
                List<CountingSystemView> countingSystems = new List<CountingSystemView>();

                // local
                CountingSystemView countingSystem = null;

                // If the countingSystemsList collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(countingSystemsList))
                {
                    // Iterate the collection of ICardCountingSystem objects
                    foreach (ICardCountingSystem countingSystemRaw in countingSystemsList)
                    {
                        // convert the ICardCountingSystem to a CountingSystemView object
                        countingSystem = Convert(countingSystemRaw);

                        // Add this system
                        countingSystems.Add(countingSystem);
                    }
                }

                // return value
                return countingSystems;
            }
            #endregion
            
            #region Convert(ICardCountingSystem countingSystem)
            /// <summary>
            /// This method converts an ICardCountingSystem to a CardCoutnignView object.
            /// </summary>
            /// <param name="countingSystem"></param>
            /// <returns></returns>
            public static CountingSystemView Convert(ICardCountingSystem countingSystem)
            {
                // initial value
                CountingSystemView countingSystemView = null;
                
                // If the countingSystem object exists
                if (NullHelper.Exists(countingSystem))
                {
                    // Create a new instance of a 'CountingSystemView' object.
                    countingSystemView = new CountingSystemView();

                    // Set the value for each property
                    countingSystemView.Balanced = countingSystem.BalancedSystem;
                    countingSystemView.Name = countingSystem.Name;
                    countingSystemView.Level = ConvertLevel(countingSystem.Level);
                    countingSystemView.Notes = countingSystem.Notes;

                    // Now set the Card Values; we have to set each value with a red and black card in case this
                    // counting system returns different values.
                    countingSystemView.Ace = ConvertCard(CardEnum.Ace, countingSystem);
                    countingSystemView.Two = ConvertCard(CardEnum.Two, countingSystem);
                    countingSystemView.Three = ConvertCard(CardEnum.Three, countingSystem);
                    countingSystemView.Four = ConvertCard(CardEnum.Four, countingSystem);
                    countingSystemView.Five = ConvertCard(CardEnum.Five, countingSystem);
                    countingSystemView.Six = ConvertCard(CardEnum.Six, countingSystem);
                    countingSystemView.Seven = ConvertCard(CardEnum.Seven, countingSystem);
                    countingSystemView.Eight = ConvertCard(CardEnum.Eight, countingSystem);
                    countingSystemView.Nine = ConvertCard(CardEnum.Nine, countingSystem);
                    countingSystemView.Ten = ConvertCard(CardEnum.Ten, countingSystem);
                }

                // return value
                return countingSystemView;
            }

            #endregion

            #region ConvertCard(CardEnum card, ICardCountingSystem countingSystem)
            /// <summary>
            /// This method returns the Card
            /// </summary>
            private static string ConvertCard(CardEnum card, ICardCountingSystem countingSystem)
            {
                // initial value
                string cardValue = "";

                // locals
                Card redCard = null;
                Card blackCard = null;
                string redCardValue = "";
                string blackCardValue = "";

                // create a red and black card
                redCard = new Card(SuitEnum.Hearts, card, countingSystem);
                blackCard = new Card(SuitEnum.Spades, card, countingSystem);
                redCardValue = GetCardValue(redCard, countingSystem);
                blackCardValue = GetCardValue(blackCard, countingSystem);

                // if the values are the same
                if (redCardValue == blackCardValue)
                {
                    // Set the value
                    cardValue = redCardValue.ToString();
                }
                else
                {
                    // Set both values
                    cardValue = redCardValue.ToString() + @"/" + blackCardValue.ToString();
                }

                // return value
                return cardValue;
            }
            #endregion

            #region CountingSystemLevelEnum(Enumerations.LevelEnum level)
            /// <summary>
            /// This method returns the Level
            /// </summary>
            private static string ConvertLevel(CountingSystemLevelEnum level)
            {
                // initial value
                string levelDescription = "";

                switch (level)
                {
                    case CountingSystemLevelEnum.Easy:

                        // set the return value
                        levelDescription = "Easy";

                        // required
                        break;

                    case CountingSystemLevelEnum.Standard:

                        // set the return value
                        levelDescription = "Standard";

                        // required
                        break;

                    case CountingSystemLevelEnum.Advanced:

                        // set the return value
                        levelDescription = "Advanced";

                        // required
                        break;
                }

                // return value
                return levelDescription;
            }
            #endregion
            
            #region GetCardValue(CardEnum card)
            /// <summary>
            /// This method returns the Card Value
            /// </summary>
            private static string GetCardValue(Card card, ICardCountingSystem countingSystem)
            {
                // initial value
                string cardValueAsString = "";

                // If the countingSystem object exists
                if (NullHelper.Exists(countingSystem, card))
                {
                    // Call the counting system to get the CardValue
                    double cardValue = countingSystem.GetCardCountValue(card);

                    // now convert the value to a string
                    cardValueAsString = cardValue.ToString();
                }

                // return value
                return cardValueAsString;
            }
            #endregion
            
        #endregion

    }
    #endregion

}
