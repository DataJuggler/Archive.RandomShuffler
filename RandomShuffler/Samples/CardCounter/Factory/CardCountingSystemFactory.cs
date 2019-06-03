

#region using statements

using CardCounter.Interfaces;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic;
using CardCounter.Systems;

#endregion

namespace CardCounter.Factory
{

    #region class CardCountingSystemFactory
    /// <summary>
    /// This class is used to return a collection of CardCountingSystems.
    /// </summary>
    public class CardCountingSystemFactory
    {
        
        #region Methods
        
            #region FindCardCountingSystem(string countingSystemName)
            /// <summary>
            /// This method returns the Card Counting System
            /// </summary>
            internal static ICardCountingSystem FindCardCountingSystem(string countingSystemName)
            {
                // initial value
                ICardCountingSystem countingSystem = null;

                // If the countingSystemName string exists
                if (TextHelper.Exists(countingSystemName))
                {
                    // determine the CountingSystem to return based upon the CountingSystemName
                    switch (countingSystemName)
                    {
                        case "Basic Strategy (No Count)":

                            // Create this countingSystem
                            countingSystem = new BasicStrategySystem();

                            // required
                            break;


                        case "High - Low":

                            // Create this countingSystem
                            countingSystem = new HighLowSystem();

                            // required
                            break;

                        case "High Opt I":

                            // Create this countingSystem
                            countingSystem = new HighOptISystem();

                            // required
                            break;

                        case "High Opt II":

                            // Create this countingSystem
                            countingSystem = new HighOptIISystem();

                            // required
                            break;

                        case "KISS II":

                            // Create this countingSystem
                            countingSystem = new KISSIISystem();

                            // required
                            break;

                        case "KISS III":

                            // Create this countingSystem
                            countingSystem = new KISSIIISystem();

                            // required
                            break;

                        case "Wong Halves":

                            // Create this countingSystem
                            countingSystem = new WongHalvesSystem();

                            // required
                            break;

                        case "Knock Out":

                            // Create this countingSystem
                            countingSystem = new KnockOutSystem();

                            // required
                            break;
                    }
                }  

                // return value
                return countingSystem;
            }
            #endregion
            
            #region LoadCardCountingSystems()
            /// <summary>
            /// This method returns any CardCountingSystems you want to show up as an option.
            /// </summary>
            /// <returns></returns>
            public static List<ICardCountingSystem> LoadCardCountingSystems()
            {
                // Create the return value
                List<ICardCountingSystem> cardCountingSystems = new List<ICardCountingSystem>();

                // Create all the card counting systems
                BasicStrategySystem basicStrategySystem = new BasicStrategySystem();
                HighLowSystem highLowSystem = new HighLowSystem();
                KnockOutSystem knockOutSystem = new KnockOutSystem();
                KISSIISystem kissIISystem = new KISSIISystem();
                KISSIIISystem kissIIISystem = new KISSIIISystem();
                HighOptISystem highOpt1System = new HighOptISystem();
                HighOptIISystem highOpt2System = new HighOptIISystem();
                WongHalvesSystem wongHalvesSystem = new WongHalvesSystem();

                // add each system
                cardCountingSystems.Add(basicStrategySystem);
                cardCountingSystems.Add(highLowSystem);
                cardCountingSystems.Add(knockOutSystem);
                cardCountingSystems.Add(kissIISystem);
                cardCountingSystems.Add(kissIIISystem);
                cardCountingSystems.Add(highOpt1System);
                cardCountingSystems.Add(highOpt2System);
                cardCountingSystems.Add(wongHalvesSystem);

                // return value
                return cardCountingSystems;
            }
            #endregion

        #endregion

    }
    #endregion

}
