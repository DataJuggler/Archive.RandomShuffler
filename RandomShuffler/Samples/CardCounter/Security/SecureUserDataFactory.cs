

#region using statements

using CardCounter.Enumerations;
using CardCounter.Objects;
using CardCounter.Systems;
using CardCounter.Factory;
using DataJuggler.Core.UltimateHelper;
using System.Collections.Generic;
using DataJuggler.Core.RandomShuffler;
using CardCounter.UI.Controls;
using CardCounter.UI.Forms;

#endregion

namespace CardCounter.Security
{

    #region class SecureUserDataFactory
    /// <summary>
    /// This class is used to convert the HouseRules and Players collection to a SecureUserData
    /// object used for the settings.
    /// </summary>
    public class SecureUserDataFactory
    {
        
        #region Methods
            
            #region Convert(GameManager gameManager)
            /// <summary>
            /// This method converts a GameManager object to a SecureUserData object 
            /// so the Options and Players can be saved.
            /// </summary>
            /// <param name="gameManager"></param>
            /// <returns></returns>
            public static SecureUserData Convert(GameManager gameManager)
            {
                // initial value
                SecureUserData security = null;

                // locals
                Options houseRules = null;
                
                // If the gameManager object exists
                if (NullHelper.Exists(gameManager))
                {
                    // Create a new instance of a 'SecureUserData' object.
                    security = new SecureUserData();

                    // if the gameManager object contains a HouseRules object
                    if (gameManager.HasHouseRules)
                    {
                        // set the houseRules to make a typing a little shorter
                        houseRules = gameManager.HouseRules;

                        // set the value for each option
                        security.AllowDoubleDown = houseRules.AllowDoubleDown;
                        security.AllowDoubleOnSplit = houseRules.AllowDoubleOnSplit;
                        security.AllowDoubleOnTenOrElevenOnly = houseRules.AllowDoubleOnTenOrElevenOnly;
                        security.AllowInsurance = houseRules.AllowInsurance;
                        security.AllowResplitAces = houseRules.AllowResplitAces;
                        security.AllowSplit = houseRules.AllowSplit;
                        security.AllowSplitAces = houseRules.AllowSplitAces;
                        security.AllowSurrender = houseRules.AllowSurrender;
                        security.ComputerPlayersUnlimitedRebuys = houseRules.ComputerPlayersUnlimitedRebuys;
                        security.DealerMustHitSoft17 = houseRules.DealerMustHitSoft17;
                        security.DefaultBankRoll = houseRules.DefaultBankRoll;
                        security.DefaultComputerBankRoll = houseRules.DefaultComputerBankRoll;
                        security.GameSpeed = houseRules.GameSpeed;
                        security.HumanPlayerUnlimitedRebuys = houseRules.HumanPlayerUnlimitedRebuys;
                        security.NumberDecks = houseRules.NumberDecks;
                        security.Penetration = houseRules.Penetration;
                        security.SaveSettingsOnThisComputer = houseRules.SaveSettingsOnThisComputer;
                        security.TableMaximum = houseRules.TableMaximum;
                        security.TableMinimum = houseRules.TableMinimum;
                    }

                    // if the game manager has a list of players
                    if (gameManager.HasPlayers)
                    {
                        // we must make sure we have five players seated; this is to ensure if a player was removed
                        // we do not leave him seated
                        bool seat1IsEmpty = false;
                        bool seat2IsEmpty = false;
                        bool seat3IsEmpty = false;
                        bool seat4IsEmpty = false;
                        bool seat5IsEmpty = false;

                        // iterate the players
                        foreach (Player player in gameManager.Players)
                        {
                            // determine where to store which player by the seat number
                            switch (player.SeatNumber)
                            {

                                case SeatNumberEnum.Seat1:

                                    // this player is seated
                                    seat1IsEmpty = false;

                                    // Store the chips
                                    security.Player1Chips = player.Chips;
                                    
                                    // If the value for the property player.HasCardCountingSystem is true
                                    if (player.HasCardCountingSystem)
                                    {
                                        // store the system name
                                        security.Player1CountingSystem = player.CardCountingSystem.Name;
                                    }
                                    else
                                    {
                                        // store the system name
                                        security.Player1CountingSystem = null;
                                    }

                                    // set the value for IsComputerPlayer
                                    security.Player1IsComputerPlayer = player.IsComputerPlayer;
                                    
                                    // Store the name
                                    security.Player1Name = player.Name;

                                    // Is this player sitting out
                                    security.Player1SittingOut = player.SittingOut;

                                    // required
                                    break;

                                case SeatNumberEnum.Seat2:

                                    // this player is seated
                                    seat2IsEmpty = false;

                                    // Store the chips
                                    security.Player2Chips = player.Chips;

                                    // If the value for the property player.HasCardCountingSystem is true
                                    if (player.HasCardCountingSystem)
                                    {
                                        // store the system name
                                        security.Player2CountingSystem = player.CardCountingSystem.Name;
                                    }
                                    else
                                    {
                                        // store the system name
                                        security.Player2CountingSystem = null;
                                    }

                                    // set the value for IsComputerPlayer
                                    security.Player2IsComputerPlayer = player.IsComputerPlayer;

                                    // Store the name
                                    security.Player2Name = player.Name;

                                    // Is this player sitting out
                                    security.Player2SittingOut = player.SittingOut;

                                    // required
                                    break;

                                case SeatNumberEnum.Seat3:

                                    // this player is seated
                                    seat3IsEmpty = false;

                                    // Store the chips
                                    security.Player3Chips = player.Chips;

                                    // If the value for the property player.HasCardCountingSystem is true
                                    if (player.HasCardCountingSystem)
                                    {
                                        // store the system name
                                        security.Player3CountingSystem = player.CardCountingSystem.Name;
                                    }
                                    else
                                    {
                                        // store the system name
                                        security.Player3CountingSystem = null;
                                    }

                                    // set the value for IsComputerPlayer
                                    security.Player3IsComputerPlayer = player.IsComputerPlayer;

                                    // Store the name
                                    security.Player3Name = player.Name;

                                    // Is this player sitting out
                                    security.Player3SittingOut = player.SittingOut;

                                    // required
                                    break;

                                case SeatNumberEnum.Seat4:

                                    // this player is seated
                                    seat4IsEmpty = false;

                                    // Store the chips
                                    security.Player4Chips = player.Chips;

                                    // If the value for the property player.HasCardCountingSystem is true
                                    if (player.HasCardCountingSystem)
                                    {
                                        // store the system name
                                        security.Player4CountingSystem = player.CardCountingSystem.Name;
                                    }
                                    else
                                    {
                                        // store the system name
                                        security.Player4CountingSystem = null;
                                    }

                                    // set the value for IsComputerPlayer
                                    security.Player4IsComputerPlayer = player.IsComputerPlayer;

                                    // Store the name
                                    security.Player4Name = player.Name;

                                    // Is this player sitting out
                                    security.Player4SittingOut = player.SittingOut;

                                    // required
                                    break;

                                case SeatNumberEnum.Seat5:

                                    // this player is seated
                                    seat5IsEmpty = false;

                                    // Store the chips
                                    security.Player5Chips = player.Chips;

                                    // If the value for the property player.HasCardCountingSystem is true
                                    if (player.HasCardCountingSystem)
                                    {
                                        // store the system name
                                        security.Player5CountingSystem = player.CardCountingSystem.Name;
                                    }
                                    else
                                    {
                                        // store the system name
                                        security.Player5CountingSystem = null;
                                    }

                                    // set the value for IsComputerPlayer
                                    security.Player5IsComputerPlayer = player.IsComputerPlayer;

                                    // Store the name
                                    security.Player5Name = player.Name;

                                    // Is this player sitting out
                                    security.Player5SittingOut = player.SittingOut;

                                    // required
                                    break;
                            }
                        }

                        // if the value for seat1IsEmpty is true
                        if (seat1IsEmpty)
                        {
                            // Erase the chips
                            security.Player1Chips = 0;

                            // store the system name
                            security.Player1CountingSystem = null;
                            
                            // set the value for IsComputerPlayer
                            security.Player1IsComputerPlayer = false;

                            // Store the name
                            security.Player1Name = null;

                            // Is this player sitting out
                            security.Player1SittingOut = false;
                        }

                        // if the value for seat2IsEmpty is true
                        if (seat2IsEmpty)
                        {
                            // Erase the chips
                            security.Player2Chips = 0;

                            // store the system name
                            security.Player2CountingSystem = null;

                            // set the value for IsComputerPlayer
                            security.Player2IsComputerPlayer = false;

                            // Store the name
                            security.Player2Name = null;

                            // Is this player sitting out
                            security.Player2SittingOut = false;
                        }

                        // if the value for seat3IsEmpty is true
                        if (seat3IsEmpty)
                        {
                            // Erase the chips
                            security.Player3Chips = 0;

                            // store the system name
                            security.Player3CountingSystem = null;

                            // set the value for IsComputerPlayer
                            security.Player3IsComputerPlayer = false;

                            // Store the name
                            security.Player3Name = null;

                            // Is this player sitting out
                            security.Player3SittingOut = false;
                        }

                        // if the value for seat4IsEmpty is true
                        if (seat4IsEmpty)
                        {
                            // Erase the chips
                            security.Player4Chips = 0;

                            // store the system name
                            security.Player4CountingSystem = null;

                            // set the value for IsComputerPlayer
                            security.Player4IsComputerPlayer = false;

                            // Store the name
                            security.Player4Name = null;

                            // Is this player sitting out
                            security.Player4SittingOut = false;
                        }

                        // if the value for seat5IsEmpty is true
                        if (seat5IsEmpty)
                        {
                            // Erase the chips
                            security.Player5Chips = 0;

                            // store the system name
                            security.Player5CountingSystem = null;

                            // set the value for IsComputerPlayer
                            security.Player5IsComputerPlayer = false;

                            // Store the name
                            security.Player5Name = null;

                            // Is this player sitting out
                            security.Player5SittingOut = false;
                        }
                    }
                }

                // return value
                return security;
            }
            #endregion

            #region Export(SecureUserData security, List<BlackJackPlayerControl1> playerControls, MainForm table)
            /// <summary>
            /// This method is used to load a GameManager object from the values from this object
            /// so that the controls be can be loaded when the program starts
            /// </summary>
            /// <returns></returns>
            public static GameManager Export(SecureUserData security, List<BlackJackPlayerControl> playerControls, MainForm table)
            {
                // initial value
                GameManager gameManager = null;

                // local
                BlackJackPlayerControl playerControl = null;
                
                // If the security object exists
                if (NullHelper.Exists(security, playerControls, table))
                {
                    // Create a new instance of a 'GameManager' object.
                    gameManager = new GameManager(NumericHelper.ParseInteger(Properties.Resources.TimesToShuffle, 0, -1), table);

                    // create a houseRules object
                    Options houseRules = new Options();

                    // set the properties from this form
                    houseRules.AllowDoubleDown = security.AllowDoubleDown;
                    houseRules.AllowDoubleOnSplit = security.AllowDoubleOnSplit;
                    houseRules.AllowDoubleOnTenOrElevenOnly = security.AllowDoubleOnTenOrElevenOnly;
                    houseRules.AllowInsurance = security.AllowInsurance;
                    houseRules.AllowResplitAces = security.AllowResplitAces;
                    houseRules.AllowSplit = security.AllowSplit;
                    houseRules.AllowSplitAces = security.AllowSplitAces;
                    houseRules.AllowSurrender = security.AllowSurrender;
                    houseRules.ComputerPlayersUnlimitedRebuys = security.ComputerPlayersUnlimitedRebuys;
                    houseRules.DealerMustHitSoft17 = security.DealerMustHitSoft17;
                    houseRules.DefaultBankRoll = security.DefaultBankRoll;
                    houseRules.DefaultComputerBankRoll = security.DefaultComputerBankRoll;
                    houseRules.GameSpeed = security.GameSpeed;
                    houseRules.HumanPlayerUnlimitedRebuys = security.HumanPlayerUnlimitedRebuys;
                    houseRules.NumberDecks = security.NumberDecks;
                    houseRules.Penetration = security.Penetration;
                    houseRules.SaveSettingsOnThisComputer = security.SaveSettingsOnThisComputer;
                    houseRules.TableMaximum = security.TableMaximum;
                    houseRules.TableMinimum = security.TableMinimum;

                    // Create a list of players
                    List<Player> players = new List<Player>();

                    // if Player1's Name is set that is consider playing
                    if (TextHelper.Exists(security.Player1Name))
                    {
                        // Find the PlayerControl
                        playerControl = FindPlayerControl(playerControls, SeatNumberEnum.Seat1);

                        // if the control was found
                        if (NullHelper.Exists(playerControl))
                        {
                            // create player 1
                            Player player1 = new Player(security.Player1Name, security.Player1Chips, security.Player1IsComputerPlayer, playerControl);

                            // Setup the SeatNumber
                            player1.SeatNumber = SeatNumberEnum.Seat1;

                            // Is Player1 Sitting Out
                            player1.SittingOut = security.Player1SittingOut;

                            // Set the CountingSystem
                            string countingSystemName = security.Player1CountingSystem;
                            player1.CardCountingSystem = CardCountingSystemFactory.FindCardCountingSystem(countingSystemName);

                            // add this player
                            players.Add(player1);
                        }
                    }

                    // if Player2's Name is set that is consider playing
                    if (TextHelper.Exists(security.Player2Name))
                    {
                        // Find the PlayerControl
                        playerControl = FindPlayerControl(playerControls, SeatNumberEnum.Seat2);

                        // if the control was found
                        if (NullHelper.Exists(playerControl))
                        {
                            // create player 2
                            Player player2 = new Player(security.Player2Name, security.Player2Chips, security.Player2IsComputerPlayer, playerControl);

                            // Setup the SeatNumber
                            player2.SeatNumber = SeatNumberEnum.Seat2;

                            // Is Player2 Sitting Out
                            player2.SittingOut = security.Player2SittingOut;

                            // Set the CountingSystem
                            string countingSystemName = security.Player2CountingSystem;
                            player2.CardCountingSystem = CardCountingSystemFactory.FindCardCountingSystem(countingSystemName);

                            // add this player
                            players.Add(player2);
                        }
                    }

                    // if Player3's Name is set that is consider playing
                    if (TextHelper.Exists(security.Player3Name))
                    {
                        // Find the PlayerControl
                        playerControl = FindPlayerControl(playerControls, SeatNumberEnum.Seat3);

                        // if the control was found
                        if (NullHelper.Exists(playerControl))
                        {
                            // create player 3
                            Player player3 = new Player(security.Player3Name, security.Player3Chips, security.Player3IsComputerPlayer, playerControl);

                            // Setup the SeatNumber
                            player3.SeatNumber = SeatNumberEnum.Seat3;

                            // Is Player3 Sitting Out
                            player3.SittingOut = security.Player3SittingOut;

                            // Set the CountingSystem
                            string countingSystemName = security.Player3CountingSystem;
                            player3.CardCountingSystem = CardCountingSystemFactory.FindCardCountingSystem(countingSystemName);

                            // add this player
                            players.Add(player3);
                        }
                    }

                    // if Player4's Name is set that is consider playing
                    if (TextHelper.Exists(security.Player4Name))
                    {
                        // Find the PlayerControl
                        playerControl = FindPlayerControl(playerControls, SeatNumberEnum.Seat4);

                        // if the control was found
                        if (NullHelper.Exists(playerControl))
                        {
                            // create player 4
                            Player player4 = new Player(security.Player4Name, security.Player4Chips, security.Player4IsComputerPlayer, playerControl);

                            // Setup the SeatNumber
                            player4.SeatNumber = SeatNumberEnum.Seat4;

                            // Is Player4 Sitting Out
                            player4.SittingOut = security.Player4SittingOut;

                            // Set the CountingSystem
                            string countingSystemName = security.Player4CountingSystem;
                            player4.CardCountingSystem = CardCountingSystemFactory.FindCardCountingSystem(countingSystemName);

                            // add this player
                            players.Add(player4);
                        }
                    }

                    // if Player5's Name is set that is consider playing
                    if (TextHelper.Exists(security.Player5Name))
                    {
                        // Find the PlayerControl
                        playerControl = FindPlayerControl(playerControls, SeatNumberEnum.Seat5);

                        // if the control was found
                        if (NullHelper.Exists(playerControl))
                        {
                            // create player 5
                            Player player5 = new Player(security.Player5Name, security.Player5Chips, security.Player5IsComputerPlayer, playerControl);

                            // Setup the SeatNumber
                            player5.SeatNumber = SeatNumberEnum.Seat5;

                            // Is Player5 Sitting Out
                            player5.SittingOut = security.Player5SittingOut;

                            // Set the CountingSystem
                            string countingSystemName = security.Player5CountingSystem;
                            player5.CardCountingSystem = CardCountingSystemFactory.FindCardCountingSystem(countingSystemName);

                            // add this player
                            players.Add(player5);
                        }
                    }

                    // set the HouseRules & players
                    gameManager.HouseRules = houseRules;
                    gameManager.Players = players;

                    // if the HouseRules exist
                    if (gameManager.HasHouseRules)
                    {
                        // create
                        BlackJackCardValueBase blackJackCardValueBase = new BlackJackCardValueBase();

                        // Set the times to shuffle
                        int timesToShuffle = NumericHelper.ParseInteger(Properties.Resources.TimesToShuffle, 0, -1);

                        // Create the Shuffler
                        gameManager.Shuffler = new RandomShuffler(houseRules.NumberDecks, blackJackCardValueBase, 0);
                    }
                }

                // return value
                return gameManager;
            }
            #endregion

            #region FindPlayerControl(List<BlackJackPlayerControl1> playerControls, SeatNumberEnum seatNumber)
            /// <summary>
            /// This method returns the Player Control
            /// </summary>
            private static BlackJackPlayerControl FindPlayerControl(List<BlackJackPlayerControl> playerControls, SeatNumberEnum seatNumber)
            {
                // initial value
                BlackJackPlayerControl playerControl = null;

                // If the playerControls collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(playerControls))
                {
                    // Iterate the collection of BlackJackPlayerControl1 objects
                    foreach (BlackJackPlayerControl tempPlayerControl in playerControls)
                    {
                        // if this is the control being sought
                        if (tempPlayerControl.SeatNumber == seatNumber)
                        {
                            // Set the SeatNumber
                            playerControl = tempPlayerControl;

                            // break out of the loop
                            break;
                        }
                    }
                }

                // return value
                return playerControl;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
