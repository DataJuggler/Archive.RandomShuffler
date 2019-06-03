

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCounter.Enumerations;

#endregion

namespace CardCounter.Objects
{

    #region class Options
    /// <summary>
    /// This class represents the current set of rules known as the 'House Rules'.
    /// As with all casinos the house has the right to refuse service to anyone
    /// for any reason, so if the 'Eye in the Sky' does not want to take your action
    /// you might get asked to leave even if you are losing.
    /// </summary>
    
    public class Options
    {
    
        #region Private Variables
        private bool allowSplitAces;
        private bool allowDoubleDown;
        private bool allowDoubleOnSplit;
        private bool allowDoubleOnTenOrElevenOnly;       
        private bool allowInsurance;
        private bool allowSplit;    
        private bool allowSurrender;
        private bool dealerMustHitSoft17;
        private bool allowResplitAces;
        private int penetration;
        private double defaultBankRoll;
        private double defaultComputerBankRoll;
        private bool computerPlayersUnlimitedRebuys;
        private bool humanPlayerUnlimitedRebuys;
        private int tableMinimum;
        private int tableMaximum;
        private GameSpeedEnum gameSpeed;
        private bool saveSettingsOnThisComputer;
        private int numberDecks;
        private bool dontShowChipSelectorInstructions;
        #endregion

        #region Methods

            #region CreateDefault()
            /// <summary>
            /// This method returns a default 'Options' instance.
            /// </summary>
            /// <returns></returns>
            public static Options CreateDefault()
            {
                // initial value
                Options defaultOptions = new Options();

                // Now set all the Default Options
                defaultOptions.AllowDoubleDown = true;
                defaultOptions.AllowDoubleOnSplit = true;
                defaultOptions.AllowDoubleOnTenOrElevenOnly = false;
                defaultOptions.AllowInsurance = true;
                defaultOptions.AllowResplitAces = true;
                defaultOptions.AllowSplit = true;
                defaultOptions.allowSplitAces = true;
                defaultOptions.AllowSurrender = true;
                defaultOptions.ComputerPlayersUnlimitedRebuys = true;
                defaultOptions.HumanPlayerUnlimitedRebuys = true;
                defaultOptions.DealerMustHitSoft17 = true;
                defaultOptions.DefaultBankRoll = 1000;
                defaultOptions.DefaultComputerBankRoll = 1000;
                defaultOptions.GameSpeed = GameSpeedEnum.Normal;
                defaultOptions.Penetration = 60;
                defaultOptions.SaveSettingsOnThisComputer = true;
                defaultOptions.TableMinimum = 5;
                defaultOptions.TableMaximum = 10000;
                
                // return value
                return defaultOptions;
            }
            #endregion

        #endregion

        #region Properties

            #region AllowDoubleDown
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleDown'.
            /// </summary>
            public bool AllowDoubleDown
            {
                get { return allowDoubleDown; }
                set { allowDoubleDown = value; }
            }
            #endregion
            
            #region AllowDoubleOnSplit
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleOnSplit'.
            /// </summary>
            public bool AllowDoubleOnSplit
            {
                get { return allowDoubleOnSplit; }
                set { allowDoubleOnSplit = value; }
            }
            #endregion
            
            #region AllowDoubleOnTenOrElevenOnly
            /// <summary>
            /// This property gets or sets the value for 'AllowDoubleOnTenOrElevenOnly'.
            /// </summary>
            public bool AllowDoubleOnTenOrElevenOnly
            {
                get { return allowDoubleOnTenOrElevenOnly; }
                set { allowDoubleOnTenOrElevenOnly = value; }
            }
            #endregion
            
            #region AllowInsurance
            /// <summary>
            /// This property gets or sets the value for 'AllowInsurance'.
            /// </summary>
            public bool AllowInsurance
            {
                get { return allowInsurance; }
                set { allowInsurance = value; }
            }
            #endregion

            #region AllowResplitAces
            /// <summary>
            /// This property gets or sets the value for 'AllowResplitAces'.
            /// </summary>
            public bool AllowResplitAces
            {
                get { return allowResplitAces; }
                set { allowResplitAces = value; }
            }
            #endregion

            #region AllowSplit
            /// <summary>
            /// This property gets or sets the value for 'AllowSplit'.
            /// </summary>
            public bool AllowSplit
            {
                get { return allowSplit; }
                set { allowSplit = value; }
            }
            #endregion
            
            #region AllowSplitAces
            /// <summary>
            /// This property gets or sets the value for 'AllowSplitAces'.
            /// </summary>
            public bool AllowSplitAces
            {
                get { return allowSplitAces; }
                set { allowSplitAces = value; }
            }
            #endregion
            
            #region AllowSurrender
            /// <summary>
            /// This property gets or sets the value for 'AllowSurrender'.
            /// </summary>
            public bool AllowSurrender
            {
                get { return allowSurrender; }
                set { allowSurrender = value; }
            }
            #endregion
            
            #region ComputerPlayersUnlimitedRebuys
            /// <summary>
            /// This property gets or sets the value for 'ComputerPlayersUnlimitedRebuys'.
            /// </summary>
            public bool ComputerPlayersUnlimitedRebuys
            {
                get { return computerPlayersUnlimitedRebuys; }
                set { computerPlayersUnlimitedRebuys = value; }
            }
            #endregion
            
            #region DealerMustHitSoft17
            /// <summary>
            /// This property gets or sets the value for 'DealerMustHitSoft17'.
            /// </summary>
            public bool DealerMustHitSoft17
            {
                get { return dealerMustHitSoft17; }
                set { dealerMustHitSoft17 = value; }
            }
            #endregion
            
            #region DefaultBankRoll
            /// <summary>
            /// This property gets or sets the value for 'DefaultBankRoll'.
            /// </summary>
            public double DefaultBankRoll
            {
                get { return defaultBankRoll; }
                set { defaultBankRoll = value; }
            }
            #endregion
            
            #region DefaultComputerBankRoll
            /// <summary>
            /// This property gets or sets the value for 'DefaultComputerBankRoll'.
            /// </summary>
            public double DefaultComputerBankRoll
            {
                get { return defaultComputerBankRoll; }
                set { defaultComputerBankRoll = value; }
            }
            #endregion
            
            #region DontShowChipSelectorInstructions
            /// <summary>
            /// This property gets or sets the value for 'DontShowChipSelectorInstructions'.
            /// </summary>
            public bool DontShowChipSelectorInstructions
            {
                get { return dontShowChipSelectorInstructions; }
                set { dontShowChipSelectorInstructions = value; }
            }
            #endregion
            
            #region GameSpeed
            /// <summary>
            /// This property gets or sets the value for 'GameSpeed'.
            /// </summary>
            public GameSpeedEnum GameSpeed
            {
                get { return gameSpeed; }
                set { gameSpeed = value; }
            }
            #endregion
            
            #region HumanPlayerUnlimitedRebuys
            /// <summary>
            /// This property gets or sets the value for 'HumanPlayerUnlimitedRebuys'.
            /// </summary>
            public bool HumanPlayerUnlimitedRebuys
            {
                get { return humanPlayerUnlimitedRebuys; }
                set { humanPlayerUnlimitedRebuys = value; }
            }
            #endregion
            
            #region NumberDecks
            /// <summary>
            /// This property gets or sets the value for 'NumberDecks'.
            /// </summary>
            public int NumberDecks
            {
                get { return numberDecks; }
                set { numberDecks = value; }
            }
            #endregion
            
            #region Penetration
            /// <summary>
            /// This property gets or sets the value for 'Penetration'.
            /// This value must be in the 0 - 100 range and determines
            /// when the 'items' are reshuffled;  For example: 
            /// Most casinos will reshuffle somewhere between 50% and 80% 
            /// of the way through a Shoe. The higher the number
            /// the better it is for counters as more cards are known thus the
            /// remaining cards are less random. This also affects AceCounts as
            /// the further you are through a deck the more it affects the odds of
            /// an Ace when the number of Aces is > than a 1 / 13 ratio.
            /// </summary>
            public int Penetration
            {
                get { return penetration; }
                set { penetration = value; }
            }
            #endregion
            
            #region SaveSettingsOnThisComputer
            /// <summary>
            /// This property gets or sets the value for 'SaveSettingsOnThisComputer'.
            /// </summary>
            public bool SaveSettingsOnThisComputer
            {
                get { return saveSettingsOnThisComputer; }
                set { saveSettingsOnThisComputer = value; }
            }
            #endregion
            
            #region TableMaximum
            /// <summary>
            /// This property gets or sets the value for 'TableMaximum'.
            /// </summary>
            public int TableMaximum
            {
                get { return tableMaximum; }
                set { tableMaximum = value; }
            }
            #endregion
            
            #region TableMinimum
            /// <summary>
            /// This property gets or sets the value for 'TableMinimum'.
            /// </summary>
            public int TableMinimum
            {
                get { return tableMinimum; }
                set { tableMinimum = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
