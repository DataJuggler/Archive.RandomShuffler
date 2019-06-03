

#region using statements

using System.Windows.Forms;
using DataJuggler.Core.UltimateHelper;
using CardCounter.Objects;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using CardCounter.Util;
using System.Drawing;

#endregion

namespace CardCounter.UI.Controls
{

    #region class OptionsControl
    /// <summary>
    /// This class is used to edit the 'GameOptions'.
    /// </summary>
    public partial class OptionsControl : UserControl, ICheckChangedListener
    {
        
        #region Private Variables
        private const int DefaultPenetrationMinimum = 40;
        private const int DefaultPenetrationMaximum = 80;
        private const int DefaultPenetrationValue = 60;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a GameOptionsControl object.
        /// </summary>
        public OptionsControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Button_MouseEnter(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, System.EventArgs e)
            {
                // Change the cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, System.EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region DefaultBankRollComputerChipSelector_Click(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the 'DefaultBankRollComputerChipSelector' is clicked.
            /// </summary>
            private void DefaultBankRollComputerChipSelector_Click(object sender, System.EventArgs e)
            {
                // Show the ChipSelector
                ChipSelectorHelper.ShowChipSelector(this.DefaultBankRollComputerControl);
            }
            #endregion
            
            #region DefaultBankRollHumanChipSelector_Click(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the 'DefaultBankRollHumanChipSelector' is clicked.
            /// </summary>
            private void DefaultBankRollHumanChipSelector_Click(object sender, System.EventArgs e)
            {
                // Show the ChipSelector
                ChipSelectorHelper.ShowChipSelector(this.DefaultBankRollHumanControl);
            }
            #endregion

            #region OnCheckChanged(LabelCheckBoxControl sender, bool isChecked);
            /// <summary>
            /// The checkbox has been checked or unchecked.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="selectedIndex"></param>
            public void OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            {
                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region TableMaximumChipSelector_Click(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the 'TableMaximumChipSelector' is clicked.
            /// </summary>
            private void TableMaximumChipSelector_Click(object sender, System.EventArgs e)
            {
                // Show the ChipSelector
                ChipSelectorHelper.ShowChipSelector(this.TableMaximumControl);
            }
            #endregion
            
            #region TableMinimumChipSelector_Click(object sender, System.EventArgs e)
            /// <summary>
            /// This event is fired when the 'TableMinimumChipSelector' is clicked.
            /// </summary>
            private void TableMinimumChipSelector_Click(object sender, System.EventArgs e)
            {
                // Show the ChipSelector
                ChipSelectorHelper.ShowChipSelector(this.TableMinimumControl);
            }
            #endregion
            
        #endregion

        #region Methods

            #region CaptureHouseRules()
            /// <summary>
            /// This method returns the House Rules
            /// </summary>
            internal Options CaptureHouseRules()
            {
                // initial value
                Options options = new Options();

                // set the value for each property
                options.AllowDoubleDown = this.AllowDoubleDownControl.Checked;
                options.AllowDoubleOnSplit = this.AllowDoubleOnSplitControl.Checked;
                options.AllowDoubleOnTenOrElevenOnly = this.DoubleOnTenOrElevenControl.Checked;
                options.AllowInsurance = this.AllowInsuranceControl.Checked;
                options.AllowResplitAces = this.AllowReSplitAcesControl.Checked;
                options.AllowSplit = this.AllowSplitControl.Checked;
                options.AllowSplitAces = this.AllowSplitAcesControl.Checked;
                options.AllowSurrender = this.AllowSplitAcesControl.Checked;
                options.ComputerPlayersUnlimitedRebuys = this.UnlimitedRebuysComputerControl.Checked;
                options.DealerMustHitSoft17 = this.DealerMustHitSoft17Control.Checked;
                options.DefaultBankRoll = this.DefaultBankRollHumanControl.IntValue;
                options.DefaultComputerBankRoll = this.DefaultBankRollComputerControl.IntValue;
                options.HumanPlayerUnlimitedRebuys = this.UnlimitedRebuysUserControl.Checked;
                options.NumberDecks = this.NumberDecksControl.SliderValue;
                options.Penetration = this.PenetrationControl.SliderValue;
                options.TableMinimum = this.TableMinimumControl.IntValue;
                options.TableMaximum = this.TableMaximumControl.IntValue;

                // return value
                return options;
            }
            #endregion
            
            #region DisplayHouseRules(Options options)
            /// <summary>
            /// This method returns the House Rules
            /// </summary>
            internal void DisplayHouseRules(Options options)
            {
                // Create a DefaultOptions class to use for the default values
                Options defaultOptions = Options.CreateDefault();

                // locals
                bool allowDoubleDown = defaultOptions.AllowDoubleDown;
                bool allowDoubleOnTenOrElevenOnly = defaultOptions.AllowDoubleOnTenOrElevenOnly;
                bool allowSplit = defaultOptions.AllowSplit;
                bool allowDoubleOnSplit = defaultOptions.AllowDoubleOnSplit;
                bool allowSplitAces = defaultOptions.AllowSplitAces;
                bool allowResplitAces = defaultOptions.AllowResplitAces;
                bool allowInsurance = defaultOptions.AllowInsurance;
                bool allowSurrender = defaultOptions.AllowSurrender;
                bool dealerMustHitSof17 = defaultOptions.DealerMustHitSoft17;
                double defaultBankRoll = defaultOptions.DefaultBankRoll;
                bool unlimitedRebuysUser = defaultOptions.HumanPlayerUnlimitedRebuys;
                double defaultComputerBankRoll = defaultOptions.DefaultComputerBankRoll;
                bool unlimitedRebuysComputer = defaultOptions.ComputerPlayersUnlimitedRebuys;
                int numberDecks = defaultOptions.NumberDecks;
                int penetration = defaultOptions.Penetration;
                int minBet = defaultOptions.TableMinimum;
                int maxBet = defaultOptions.TableMaximum;

                // if the options exist
                if (NullHelper.Exists(options))
                {
                    // set each value
                    allowDoubleDown = options.AllowDoubleDown;
                    allowDoubleOnTenOrElevenOnly = options.AllowDoubleOnTenOrElevenOnly;
                    allowSplit = options.AllowSplit;
                    allowDoubleOnSplit = options.AllowDoubleOnSplit;
                    allowSplitAces = options.AllowSplitAces;
                    allowResplitAces = options.AllowResplitAces;
                    allowInsurance = options.AllowInsurance;
                    allowSurrender = options.AllowSurrender;
                    dealerMustHitSof17 = options.DealerMustHitSoft17;
                    defaultBankRoll = options.DefaultBankRoll;
                    unlimitedRebuysUser = options.HumanPlayerUnlimitedRebuys;
                    defaultComputerBankRoll = options.DefaultComputerBankRoll;
                    unlimitedRebuysComputer = options.ComputerPlayersUnlimitedRebuys;
                    numberDecks = options.NumberDecks;
                    penetration = options.Penetration;
                    minBet = options.TableMinimum;
                    maxBet = options.TableMaximum;
                }

                // display the values
                this.AllowDoubleDownControl.Checked = allowDoubleDown;
                this.DoubleOnTenOrElevenControl.Checked = allowDoubleOnTenOrElevenOnly;
                this.AllowSplitControl.Checked = allowSplit;
                this.AllowReSplitAcesControl.Checked = allowResplitAces;
                this.AllowDoubleOnSplitControl.Checked = allowDoubleOnSplit;
                this.AllowSplitAcesControl.Checked = allowSplitAces;
                this.AllowInsuranceControl.Checked = allowInsurance;
                this.AllowSurrenderControl.Checked = allowSurrender;
                this.DealerMustHitSoft17Control.Checked = dealerMustHitSof17;
                this.DefaultBankRollHumanControl.Text = defaultBankRoll.ToString();
                this.UnlimitedRebuysUserControl.Checked = unlimitedRebuysUser;
                this.DefaultBankRollComputerControl.Text = defaultComputerBankRoll.ToString();
                this.UnlimitedRebuysComputerControl.Checked = unlimitedRebuysComputer;
                this.NumberDecksControl.SliderValue = numberDecks;
                this.PenetrationControl.SliderValue = penetration;
                this.TableMinimumControl.Text = minBet.ToString();
                this.TableMaximumControl.Text = maxBet.ToString();
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the SliderControl
                this.NumberDecksControl.Setup(1, 8, 1);

                // Show the Slider Control
                this.NumberDecksControl.ShowSliderControl();

                // Setup the Penetration Settings
                this.PenetrationControl.Setup(DefaultPenetrationMinimum, DefaultPenetrationMaximum, DefaultPenetrationValue);

                // Setup the CheckChangedListeners
                this.AllowDoubleDownControl.CheckChangedListener = this;
                this.AllowSplitControl.CheckChangedListener = this;
            }
            #endregion

            #region UIEnable()
            /// <summary>
            /// This method Enables the controls
            /// </summary>
            public void UIEnable()
            {  
                // locals
                Color labelColor = Color.Black;
                Color labelColorDark = Color.DarkGray;

                // These two controls enable what other controls can be enabled
                bool allowDoubleDown = this.AllowDoubleDownControl.Checked;
                bool allowSplit = this.AllowSplitControl.Checked;
                bool allowDoubleOnSplit = (allowDoubleDown && allowSplit);

                // Enable or Disable the DoubleOnTenOrElevenControl
                this.DoubleOnTenOrElevenControl.LabelColor = allowDoubleDown ? labelColor : labelColorDark;
                this.DoubleOnTenOrElevenControl.Enabled = allowDoubleDown;
                this.DoubleOnTenOrElevenControl.Editable = allowDoubleDown;

                // if you cannot double down it means the user turned this off, so they also have to turn this back on
                if (!allowDoubleDown)
                {
                    // This can't be checked if not eneabled
                    this.DoubleOnTenOrElevenControl.Checked = false;
                }

                // Enable or Disable the AllowDoubleOnSplitControl
                this.AllowSplitAcesControl.LabelColor = allowSplit ? labelColor : labelColorDark;
                this.AllowSplitAcesControl.Enabled = allowSplit;
                this.AllowSplitAcesControl.Editable = allowSplit;

                // Enable or Disable the AllowReSplitAcesControl
                this.AllowReSplitAcesControl.LabelColor = allowSplit ? labelColor : labelColorDark;
                this.AllowReSplitAcesControl.Enabled = allowSplit;
                this.AllowReSplitAcesControl.Editable = allowSplit;

                // if you cannot split it means the user turned this off, so they also have to turn this back on
                if (!allowSplit)
                {
                    // This can't be checked if not eneabled
                    this.AllowSplitAcesControl.Checked = false;
                    this.AllowReSplitAcesControl.Checked = false;
                }

                // Enable or Disable the AllowDoubleOnSplitControl
                this.AllowDoubleOnSplitControl.LabelColor = allowSplit ? labelColor : labelColorDark;
                this.AllowDoubleOnSplitControl.Enabled = allowDoubleOnSplit;
                this.AllowDoubleOnSplitControl.Editable = allowDoubleOnSplit;
                
                // if you cannot double on split it means the user turned this off, so they also have to turn this back on
                if (!allowDoubleOnSplit)
                {
                    // This can't be checked if not eneabled
                    this.AllowDoubleOnSplitControl.Checked = false;
                }

                


            }
            #endregion
            
        #endregion

    }
    #endregion

}
