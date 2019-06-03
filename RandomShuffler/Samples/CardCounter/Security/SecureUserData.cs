

#region using statements

using System;
using System.Configuration;
using CardCounter.Enumerations;

#endregion

namespace CardCounter.Security
{

    #region class SecureUserData
    /// <summary>
    /// This class is used to store the Options and Players in the Settings
    /// </summary>
    public class SecureUserData : ApplicationSettingsBase
    {  

        #region Properties

            #region AllowDoubleDown
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleDown'
            /// </summary>
            [UserScopedSetting()]
            public bool AllowDoubleDown
            {
                get
                {
                    // initial value (default to true unless turned off)
                    bool allowDoubleDown = true;

                    // if the AllowDoubleDown exists
                    if (this["AllowDoubleDown"] != null)
                    {
                        // set the allowDoubleDown
                        allowDoubleDown = (bool) this["AllowDoubleDown"];
                    }

                    // return value
                    return allowDoubleDown;
                }
                set
                {  
                    // set the value
                    this["AllowDoubleDown"] = value;
                }
            }
            #endregion

            #region AllowDoubleOnSplit
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleOnSplit'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowDoubleOnSplit
            {
                get
                {
                    // initial value
                    bool allowDoubleOnSplit = false;

                    // if the control exists
                    if (this["AllowDoubleOnSplit"] != null)
                    {
                        // set the return value
                        allowDoubleOnSplit = (bool) this["AllowDoubleOnSplit"];
                    }

                    // return value
                    return allowDoubleOnSplit;
                }
                set
                {
                    // set the value
                    this["AllowDoubleOnSplit"] = value;
                }
            }
            #endregion

            #region AllowDoubleOnTenOrElevenOnly
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleOnTenOrElevenOnly'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowDoubleOnTenOrElevenOnly
            {
                get
                {
                    // initial value
                    bool allowDoubleOnTenOrElevenOnly = false;

                    // if the control exists
                    if (this["AllowDoubleOnTenOrElevenOnly"] != null)
                    {
                        // set the return value
                        allowDoubleOnTenOrElevenOnly = (bool)this["AllowDoubleOnTenOrElevenOnly"];
                    }

                    // return value
                    return allowDoubleOnTenOrElevenOnly;
                }
                set
                {
                    // set the value
                    this["AllowDoubleOnTenOrElevenOnly"] = value;
                }
            }
            #endregion

            #region AllowInsurance
            /// <summary>
            /// This property gets or sets the value for 'AllowInsurance'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowInsurance
            {
                get
                {
                    // initial value
                    bool allowInsurance = false;

                    // if the control exists
                    if (this["AllowInsurance"] != null)
                    {
                        // set the return value
                        allowInsurance = (bool)this["AllowInsurance"];
                    }

                    // return value
                    return allowInsurance;
                }
                set
                {
                    // set the value
                    this["AllowInsurance"] = value;
                }
            }
            #endregion

            #region AllowResplitAces
            /// <summary>
            /// This property gets or sets the value for 'AllowResplitAces'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowResplitAces
            {
                get
                {
                    // initial value
                    bool allowResplitAces = false;

                    // if the control exists
                    if (this["AllowResplitAces"] != null)
                    {
                        // set the return value
                        allowResplitAces = (bool)this["AllowResplitAces"];
                    }

                    // return value
                    return allowResplitAces;
                }
                set
                {
                    // set the value
                    this["AllowResplitAces"] = value;
                }
            }
            #endregion

            #region AllowSplit
            /// <summary>
            /// This property gets or sets the value for 'AllowSplit'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowSplit
            {
                get
                {
                    // initial value
                    bool allowSplit = false;

                    // if the control exists
                    if (this["AllowSplit"] != null)
                    {
                        // set the return value
                        allowSplit = (bool) this["AllowSplit"];
                    }

                    // return value
                    return allowSplit;
                }
                set
                {
                    // set the value
                    this["AllowSplit"] = value;
                }
            }
            #endregion

            #region AllowSplitAces
            /// <summary>
            /// This property gets or sets the value for 'AllowSplitAces'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowSplitAces
            {
                get
                {
                    // initial value
                    bool allowSplitAces = true;

                    // if the control exists
                    if (this["AllowSplitAces"] != null)
                    {
                        // set the return value
                        allowSplitAces = (bool)this["AllowSplitAces"];
                    }

                    // return value
                    return allowSplitAces;
                }
                set
                {
                    // set the value
                    this["AllowSplitAces"] = value;
                }
            }
            #endregion

            #region AllowSurrender
            /// <summary>
            /// This property gets or sets the value for 'AllowSurrender'.
            /// </summary>
            [UserScopedSetting()]
            public bool AllowSurrender
            {
                get
                {
                    // initial value
                    bool allowSurrender = false;

                    // if the control exists
                    if (this["AllowSurrender"] != null)
                    {
                        // set the return value
                        allowSurrender = (bool)this["AllowSurrender"];
                    }

                    // return value
                    return allowSurrender;
                }
                set
                {
                    // set the value
                    this["AllowSurrender"] = value;
                }
            }
            #endregion

            #region ComputerPlayersUnlimitedRebuys
            /// <summary>
            /// This property gets or sets the value for 'ComputerPlayersUnlimitedRebuys'.
            /// </summary>
            [UserScopedSetting()]
            public bool ComputerPlayersUnlimitedRebuys
            {
                get
                {
                    // initial value
                    bool computerPlayersUnlimitedRebuys = false;

                    // if the control exists
                    if (this["ComputerPlayersUnlimitedRebuys"] != null)
                    {
                        // set the return value
                        computerPlayersUnlimitedRebuys = (bool)this["ComputerPlayersUnlimitedRebuys"];
                    }

                    // return value
                    return computerPlayersUnlimitedRebuys;
                }
                set
                {
                    // set the value
                    this["ComputerPlayersUnlimitedRebuys"] = value;
                }
            }
            #endregion

            #region DealerMustHitSoft17
            /// <summary>
            /// This property gets or sets the value for 'DealerMustHitSoft17'.
            /// </summary>
            [UserScopedSetting()]
            public bool DealerMustHitSoft17
            {
                get
                {
                    // initial value
                    bool dealerMustHitSoft17 = false;

                    // if the control exists
                    if (this["DealerMustHitSoft17"] != null)
                    {
                        // set the return value
                        dealerMustHitSoft17 = (bool)this["DealerMustHitSoft17"];
                    }

                    // return value
                    return dealerMustHitSoft17;
                }
                set
                {
                    // set the value
                    this["DealerMustHitSoft17"] = value;
                }
            }
            #endregion

            #region DefaultBankRoll
            /// <summary>
            /// This property gets or sets the value for 'DefaultBankRoll'.
            /// </summary>
            [UserScopedSetting()]
            public double DefaultBankRoll
            {
                get
                {
                    // initial value
                    double defaultBankRoll = 1000;

                    // if the control exists
                    if (this["DefaultBankRoll"] != null)
                    {
                        // set the return value
                        defaultBankRoll = (double) this["DefaultBankRoll"];
                    }

                    // return value
                    return defaultBankRoll;
                }
                set
                {
                    // set the value
                    this["DefaultBankRoll"] = value;
                }
            }
            #endregion

            #region DefaultComputerBankRoll
            /// <summary>
            /// This property gets or sets the value for 'DefaultComputerBankRoll'.
            /// </summary>
            [UserScopedSetting()]
            public double DefaultComputerBankRoll
            {
                get
                {
                    // initial value
                    double defaultComputerBankRoll = 1000;

                    // if the control exists
                    if (this["DefaultComputerBankRoll"] != null)
                    {
                        // set the return value
                        defaultComputerBankRoll = (double) this["DefaultComputerBankRoll"];
                    }

                    // return value
                    return defaultComputerBankRoll;
                }
                set
                {
                    // set the value
                    this["DefaultComputerBankRoll"] = value;
                }
            }
            #endregion
            
            #region GameSpeed
            /// <summary>
            /// This property gets or sets the value for 'GameSpeed'.
            /// </summary>
            [UserScopedSetting()]
            public GameSpeedEnum GameSpeed
            {
                get
                {
                    // initial value
                    GameSpeedEnum gameSpeed = GameSpeedEnum.Normal;

                    // if the control exists
                    if (this["GameSpeed"] != null)
                    {
                        // set the return value
                        gameSpeed = (GameSpeedEnum)this["GameSpeed"];
                    }

                    // return value
                    return gameSpeed;
                }
                set
                {
                    // set the value
                    this["GameSpeed"] = value;
                }
            }
            #endregion

            #region HumanPlayerUnlimitedRebuys
            /// <summary>
            /// This property gets or sets the value for 'HumanPlayerUnlimitedRebuys'.
            /// </summary>
            [UserScopedSetting()]
            public bool HumanPlayerUnlimitedRebuys
            {
                get
                {
                    // initial value
                    bool humanPlayerUnlimitedRebuys = false;

                    // if the control exists
                    if (this["HumanPlayerUnlimitedRebuys"] != null)
                    {
                        // set the return value
                        humanPlayerUnlimitedRebuys = (bool) this["HumanPlayerUnlimitedRebuys"];
                    }

                    // return value
                    return humanPlayerUnlimitedRebuys;
                }
                set
                {
                    // set the value
                    this["HumanPlayerUnlimitedRebuys"] = value;
                }
            }
            #endregion

            #region HasLastSavedDate
            /// <summary>
            /// This property returns true if this object has a 'LastSavedDate'.
            /// </summary>
            public bool HasLastSavedDate
            {
                get
                {
                    // initial value
                    bool hasLastSavedDate = (this.LastSavedDate.Year > 2000);
                    
                    // return value
                    return hasLastSavedDate;
                }
            }
            #endregion
            
            #region LastSavedDate
            /// <summary>
            /// This property gets or sets the value for 'LastSavedDate'
            /// </summary>
            [UserScopedSetting()]
            public DateTime LastSavedDate
            {
                get
                {
                    // initial value (default to true unless turned off)
                    DateTime lastSaveDate = new DateTime(1900, 1, 1);

                    // if the LastSaveDate exists
                    if (this["LastSavedDate"] != null)
                    {
                        // set the allowDoubleDown
                        lastSaveDate = (DateTime) this["LastSavedDate"];
                    }

                    // return value
                    return lastSaveDate;
                }
                set
                {
                    // set the value
                    this["LastSavedDate"] = value;
                }
            }
            #endregion

            #region NumberDecks
            /// <summary>
            /// This property gets or sets the value for 'NumberDecks'.
            /// </summary>
            [UserScopedSetting()]
            public int NumberDecks
            {
                get
                {
                    // initial value
                    int numberDecks = 4;

                    // if the control exists
                    if (this["NumberDecks"] != null)
                    {
                        // set the return value
                        numberDecks = (int)this["NumberDecks"];
                    }

                    // return value
                    return numberDecks;
                }
                set
                {
                    // set the value
                    this["NumberDecks"] = value;
                }
            }
            #endregion

            #region Penetration
            /// <summary>
            /// This property gets or sets the value for 'Penetration'.
            /// </summary>
            [UserScopedSetting()]
            public int Penetration
            {
                get
                {
                    // initial value
                    int penetration = 60;

                    // if the control exists
                    if (this["Penetration"] != null)
                    {
                        // set the return value
                        penetration = (int) this["Penetration"];
                    }

                    // return value
                    return penetration;
                }
                set
                {
                    // set the value
                    this["Penetration"] = value;
                }
            }
            #endregion

            #region Player1Chips
            /// <summary>
            /// This property gets or sets the value for 'Player1Chips'.
            /// </summary>
            [UserScopedSetting()]
            public double Player1Chips
            {
                get
                {
                    // initial value
                    double player1Chips = 0;

                    // if the control exists
                    if (this["Player1Chips"] != null)
                    {
                        // set the return value
                        player1Chips = (double)this["Player1Chips"];
                    }

                    // return value
                    return player1Chips;
                }
                set
                {
                    // set the value
                    this["Player1Chips"] = value;
                }
            }
            #endregion

            #region Player1CountingSystem
            /// <summary>
            /// This property gets or sets the value for 'Player1CountingSystem'.
            /// </summary>
            [UserScopedSetting()]
            public string Player1CountingSystem
            {
                get
                {
                    // initial value
                    string player1CountingSystem = "";

                    // if the control exists
                    if (this["Player1CountingSystem"] != null)
                    {
                        // set the return value
                        player1CountingSystem = (string)this["Player1CountingSystem"];
                    }

                    // return value
                    return player1CountingSystem;
                }
                set
                {
                    // set the value
                    this["Player1CountingSystem"] = value;
                }
            }
            #endregion

            #region Player1IsComputerPlayer
            /// <summary>
            /// This property gets or sets the value for 'Player1IsComputerPlayer'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player1IsComputerPlayer
            {
                get
                {
                    // initial value
                    bool player1IsComputerPlayer = false;

                    // if the control exists
                    if (this["Player1IsComputerPlayer"] != null)
                    {
                        // set the return value
                        player1IsComputerPlayer = (bool) this["Player1IsComputerPlayer"];
                    }

                    // return value
                    return player1IsComputerPlayer;
                }
                set
                {
                    // set the value
                    this["Player1IsComputerPlayer"] = value;
                }
            }
            #endregion

            #region Player1Name
            /// <summary>
            /// This property gets or sets the value for 'Player1Name'.
            /// </summary>
            [UserScopedSetting()]
            public string Player1Name
            {
                get
                {
                    // initial value
                    string player1Name = "";

                    // if the control exists
                    if (this["Player1Name"] != null)
                    {
                        // set the return value
                        player1Name = (string)this["Player1Name"];
                    }

                    // return value
                    return player1Name;
                }
                set
                {
                    // set the value
                    this["Player1Name"] = value;
                }
            }
            #endregion

            #region Player1SittingOut
            /// <summary>
            /// This property gets or sets the value for 'Player1SittingOut'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player1SittingOut
            {
                get
                {
                    // initial value
                    bool player1SittingOut = false;

                    // if the control exists
                    if (this["Player1SittingOut"] != null)
                    {
                        // set the return value
                        player1SittingOut = (bool)this["Player1SittingOut"];
                    }

                    // return value
                    return player1SittingOut;
                }
                set
                {
                    // set the value
                    this["Player1SittingOut"] = value;
                }
            }
            #endregion

            #region Player2Chips
            /// <summary>
            /// This property gets or sets the value for 'Player2Chips'.
            /// </summary>
            [UserScopedSetting()]
            public double Player2Chips
            {
                get
                {
                    // initial value
                    double player2Chips = 0;

                    // if the control exists
                    if (this["Player2Chips"] != null)
                    {
                        // set the return value
                        player2Chips = (double)this["Player2Chips"];
                    }

                    // return value
                    return player2Chips;
                }
                set
                {
                    // set the value
                    this["Player2Chips"] = value;
                }
            }
            #endregion

            #region Player2CountingSystem
            /// <summary>
            /// This property gets or sets the value for 'Player2CountingSystem'.
            /// </summary>
            [UserScopedSetting()]
            public string Player2CountingSystem
            {
                get
                {
                    // initial value
                    string player2CountingSystem = "";

                    // if the control exists
                    if (this["Player2CountingSystem"] != null)
                    {
                        // set the return value
                        player2CountingSystem = (string)this["Player2CountingSystem"];
                    }

                    // return value
                    return player2CountingSystem;
                }
                set
                {
                    // set the value
                    this["Player2CountingSystem"] = value;
                }
            }
            #endregion

            #region Player2IsComputerPlayer
            /// <summary>
            /// This property gets or sets the value for 'Player2IsComputerPlayer'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player2IsComputerPlayer
            {
                get
                {
                    // initial value
                    bool player2IsComputerPlayer = false;

                    // if the control exists
                    if (this["Player2IsComputerPlayer"] != null)
                    {
                        // set the return value
                        player2IsComputerPlayer = (bool)this["Player2IsComputerPlayer"];
                    }

                    // return value
                    return player2IsComputerPlayer;
                }
                set
                {
                    // set the value
                    this["Player2IsComputerPlayer"] = value;
                }
            }
            #endregion

            #region Player2Name
            /// <summary>
            /// This property gets or sets the value for 'Player2Name'.
            /// </summary>
            [UserScopedSetting()]
            public string Player2Name
            {
                get
                {
                    // initial value
                    string player2Name = "";

                    // if the control exists
                    if (this["Player2Name"] != null)
                    {
                        // set the return value
                        player2Name = (string)this["Player2Name"];
                    }

                    // return value
                    return player2Name;
                }
                set
                {
                    // set the value
                    this["Player2Name"] = value;
                }
            }
            #endregion

            #region Player2SittingOut
            /// <summary>
            /// This property gets or sets the value for 'Player2SittingOut'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player2SittingOut
            {
                get
                {
                    // initial value
                    bool player2SittingOut = false;

                    // if the control exists
                    if (this["Player2SittingOut"] != null)
                    {
                        // set the return value
                        player2SittingOut = (bool)this["Player2SittingOut"];
                    }

                    // return value
                    return player2SittingOut;
                }
                set
                {
                    // set the value
                    this["Player2SittingOut"] = value;
                }
            }
            #endregion

            #region Player3Chips
            /// <summary>
            /// This property gets or sets the value for 'Player3Chips'.
            /// </summary>
            [UserScopedSetting()]
            public double Player3Chips
            {
                get
                {
                    // initial value
                    double player3Chips = 0;

                    // if the control exists
                    if (this["Player3Chips"] != null)
                    {
                        // set the return value
                        player3Chips = (double)this["Player3Chips"];
                    }

                    // return value
                    return player3Chips;
                }
                set
                {
                    // set the value
                    this["Player3Chips"] = value;
                }
            }
            #endregion

            #region Player3CountingSystem
            /// <summary>
            /// This property gets or sets the value for 'Player3CountingSystem'.
            /// </summary>
            [UserScopedSetting()]
            public string Player3CountingSystem
            {
                get
                {
                    // initial value
                    string player3CountingSystem = "";

                    // if the control exists
                    if (this["Player3CountingSystem"] != null)
                    {
                        // set the return value
                        player3CountingSystem = (string)this["Player3CountingSystem"];
                    }

                    // return value
                    return player3CountingSystem;
                }
                set
                {
                    // set the value
                    this["Player3CountingSystem"] = value;
                }
            }
            #endregion

            #region Player3IsComputerPlayer
            /// <summary>
            /// This property gets or sets the value for 'Player3IsComputerPlayer'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player3IsComputerPlayer
            {
                get
                {
                    // initial value
                    bool player3IsComputerPlayer = false;

                    // if the control exists
                    if (this["Player3IsComputerPlayer"] != null)
                    {
                        // set the return value
                        player3IsComputerPlayer = (bool)this["Player3IsComputerPlayer"];
                    }

                    // return value
                    return player3IsComputerPlayer;
                }
                set
                {
                    // set the value
                    this["Player3IsComputerPlayer"] = value;
                }
            }
            #endregion

            #region Player3Name
            /// <summary>
            /// This property gets or sets the value for 'Player3Name'.
            /// </summary>
            [UserScopedSetting()]
            public string Player3Name
            {
                get
                {
                    // initial value
                    string player3Name = "";

                    // if the control exists
                    if (this["Player3Name"] != null)
                    {
                        // set the return value
                        player3Name = (string)this["Player3Name"];
                    }

                    // return value
                    return player3Name;
                }
                set
                {
                    // set the value
                    this["Player3Name"] = value;
                }
            }
            #endregion

            #region Player3SittingOut
            /// <summary>
            /// This property gets or sets the value for 'Player3SittingOut'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player3SittingOut
            {
                get
                {
                    // initial value
                    bool player3SittingOut = false;

                    // if the control exists
                    if (this["Player3SittingOut"] != null)
                    {
                        // set the return value
                        player3SittingOut = (bool)this["Player3SittingOut"];
                    }

                    // return value
                    return player3SittingOut;
                }
                set
                {
                    // set the value
                    this["Player3SittingOut"] = value;
                }
            }
            #endregion

            #region Player4Chips
            /// <summary>
            /// This property gets or sets the value for 'Player4Chips'.
            /// </summary>
            [UserScopedSetting()]
            public double Player4Chips
            {
                get
                {
                    // initial value
                    double player4Chips = 0;

                    // if the control exists
                    if (this["Player4Chips"] != null)
                    {
                        // set the return value
                        player4Chips = (double)this["Player4Chips"];
                    }

                    // return value
                    return player4Chips;
                }
                set
                {
                    // set the value
                    this["Player4Chips"] = value;
                }
            }
            #endregion

            #region Player4CountingSystem
            /// <summary>
            /// This property gets or sets the value for 'Player4CountingSystem'.
            /// </summary>
            [UserScopedSetting()]
            public string Player4CountingSystem
            {
                get
                {
                    // initial value
                    string player4CountingSystem = "";

                    // if the control exists
                    if (this["Player4CountingSystem"] != null)
                    {
                        // set the return value
                        player4CountingSystem = (string)this["Player4CountingSystem"];
                    }

                    // return value
                    return player4CountingSystem;
                }
                set
                {
                    // set the value
                    this["Player4CountingSystem"] = value;
                }
            }
            #endregion

            #region Player4IsComputerPlayer
            /// <summary>
            /// This property gets or sets the value for 'Player4IsComputerPlayer'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player4IsComputerPlayer
            {
                get
                {
                    // initial value
                    bool player4IsComputerPlayer = false;

                    // if the control exists
                    if (this["Player4IsComputerPlayer"] != null)
                    {
                        // set the return value
                        player4IsComputerPlayer = (bool)this["Player4IsComputerPlayer"];
                    }

                    // return value
                    return player4IsComputerPlayer;
                }
                set
                {
                    // set the value
                    this["Player4IsComputerPlayer"] = value;
                }
            }
            #endregion

            #region Player4Name
            /// <summary>
            /// This property gets or sets the value for 'Player4Name'.
            /// </summary>
            [UserScopedSetting()]
            public string Player4Name
            {
                get
                {
                    // initial value
                    string player4Name = "";

                    // if the control exists
                    if (this["Player4Name"] != null)
                    {
                        // set the return value
                        player4Name = (string)this["Player4Name"];
                    }

                    // return value
                    return player4Name;
                }
                set
                {
                    // set the value
                    this["Player4Name"] = value;
                }
            }
            #endregion

            #region Player4SittingOut
            /// <summary>
            /// This property gets or sets the value for 'Player4SittingOut'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player4SittingOut
            {
                get
                {
                    // initial value
                    bool player4SittingOut = false;

                    // if the control exists
                    if (this["Player4SittingOut"] != null)
                    {
                        // set the return value
                        player4SittingOut = (bool)this["Player4SittingOut"];
                    }

                    // return value
                    return player4SittingOut;
                }
                set
                {
                    // set the value
                    this["Player4SittingOut"] = value;
                }
            }
            #endregion

            #region Player5Chips
            /// <summary>
            /// This property gets or sets the value for 'Player5Chips'.
            /// </summary>
            [UserScopedSetting()]
            public double Player5Chips
            {
                get
                {
                    // initial value
                    double player5Chips = 0;

                    // if the control exists
                    if (this["Player5Chips"] != null)
                    {
                        // set the return value
                        player5Chips = (double)this["Player5Chips"];
                    }

                    // return value
                    return player5Chips;
                }
                set
                {
                    // set the value
                    this["Player5Chips"] = value;
                }
            }
            #endregion

            #region Player5CountingSystem
            /// <summary>
            /// This property gets or sets the value for 'Player5CountingSystem'.
            /// </summary>
            [UserScopedSetting()]
            public string Player5CountingSystem
            {
                get
                {
                    // initial value
                    string player5CountingSystem = "";

                    // if the control exists
                    if (this["Player5CountingSystem"] != null)
                    {
                        // set the return value
                        player5CountingSystem = (string)this["Player5CountingSystem"];
                    }

                    // return value
                    return player5CountingSystem;
                }
                set
                {
                    // set the value
                    this["Player5CountingSystem"] = value;
                }
            }
            #endregion

            #region Player5IsComputerPlayer
            /// <summary>
            /// This property gets or sets the value for 'Player5IsComputerPlayer'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player5IsComputerPlayer
            {
                get
                {
                    // initial value
                    bool player5IsComputerPlayer = false;

                    // if the control exists
                    if (this["Player5IsComputerPlayer"] != null)
                    {
                        // set the return value
                        player5IsComputerPlayer = (bool)this["Player5IsComputerPlayer"];
                    }

                    // return value
                    return player5IsComputerPlayer;
                }
                set
                {
                    // set the value
                    this["Player5IsComputerPlayer"] = value;
                }
            }
            #endregion

            #region Player5Name
            /// <summary>
            /// This property gets or sets the value for 'Player5Name'.
            /// </summary>
            [UserScopedSetting()]
            public string Player5Name
            {
                get
                {
                    // initial value
                    string player5Name = "";

                    // if the control exists
                    if (this["Player5Name"] != null)
                    {
                        // set the return value
                        player5Name = (string)this["Player5Name"];
                    }

                    // return value
                    return player5Name;
                }
                set
                {
                    // set the value
                    this["Player5Name"] = value;
                }
            }
            #endregion

            #region Player5SittingOut
            /// <summary>
            /// This property gets or sets the value for 'Player5SittingOut'.
            /// </summary>
            [UserScopedSetting()]
            public bool Player5SittingOut
            {
                get
                {
                    // initial value
                    bool player5SittingOut = false;

                    // if the control exists
                    if (this["Player5SittingOut"] != null)
                    {
                        // set the return value
                        player5SittingOut = (bool)this["Player5SittingOut"];
                    }

                    // return value
                    return player5SittingOut;
                }
                set
                {
                    // set the value
                    this["Player5SittingOut"] = value;
                }
            }
            #endregion

            #region SaveSettingsOnThisComputer
            /// <summary>
            /// This property gets or sets the value for FontName
            /// </summary>
            [UserScopedSetting()]
            [DefaultSettingValue("True")]
            public bool SaveSettingsOnThisComputer
            {
                get
                {
                    // return the value for StoreConnectionStrings
                    return (bool) this["SaveSettingsOnThisComputer"];
                }
                set
                {
                    // set the value
                    this["SaveSettingsOnThisComputer"] = value;
                }   
            }
            #endregion

            #region TableMaximum
            /// <summary>
            /// This property gets or sets the value for 'TableMaximum'.
            /// </summary>
            [UserScopedSetting()]
            public int TableMaximum
            {
                get
                {
                    // initial value
                    int tableMaximum = 10000;

                    // if the control exists
                    if (this["TableMaximum"] != null)
                    {
                        // set the return value
                        tableMaximum = (int)this["TableMaximum"];
                    }

                    // return value
                    return tableMaximum;
                }
                set
                {
                    // set the value
                    this["TableMaximum"] = value;
                }
            }
            #endregion

            #region TableMinimum
            /// <summary>
            /// This property gets or sets the value for 'TableMinimum'.
            /// </summary>
            [UserScopedSetting()]
            public int TableMinimum
            {
                get
                {
                    // initial value
                    int tableMinimum = 5;

                    // if the control exists
                    if (this["TableMinimum"] != null)
                    {
                        // set the return value
                        tableMinimum = (int)this["TableMinimum"];
                    }

                    // return value
                    return tableMinimum;
                }
                set
                {
                    // set the value
                    this["TableMinimum"] = value;
                }
            }
            #endregion

        #endregion
        
    }
    #endregion

}
