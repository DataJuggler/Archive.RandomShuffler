

#region using statements


#endregion

namespace CardCounter.UI.Controls
{

    #region class OptionsControl
    /// <summary>
    /// This class is the designer for the OptionsControl
    /// </summary>
    partial class OptionsControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelSliderControl PenetrationControl;
        private DataJuggler.Win.Controls.LabelSliderControl NumberDecksControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl UnlimitedRebuysComputerControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl UnlimitedRebuysUserControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl DealerMustHitSoft17Control;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowSurrenderControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowSplitControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowInsuranceControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl DoubleOnTenOrElevenControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowDoubleOnSplitControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowDoubleDownControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowReSplitAcesControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl AllowSplitAcesControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl DefaultBankRollHumanControl;
        private System.Windows.Forms.Button DefaultBankRollHumanChipSelector;
        private System.Windows.Forms.Button DefaultBankRollComputerChipSelector;
        private DataJuggler.Win.Controls.LabelTextBoxControl DefaultBankRollComputerControl;
        private System.Windows.Forms.Button TableMinimumChipSelector;
        private DataJuggler.Win.Controls.LabelTextBoxControl TableMinimumControl;
        private System.Windows.Forms.Button TableMaximumChipSelector;
        private DataJuggler.Win.Controls.LabelTextBoxControl TableMaximumControl;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary> 
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #endregion
            
            #region InitializeComponent()
            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.DefaultBankRollHumanChipSelector = new System.Windows.Forms.Button();
                this.DefaultBankRollComputerChipSelector = new System.Windows.Forms.Button();
                this.TableMinimumChipSelector = new System.Windows.Forms.Button();
                this.TableMaximumChipSelector = new System.Windows.Forms.Button();
                this.TableMaximumControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.TableMinimumControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.DefaultBankRollComputerControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.DefaultBankRollHumanControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
                this.AllowReSplitAcesControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.AllowSplitAcesControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.PenetrationControl = new DataJuggler.Win.Controls.LabelSliderControl();
                this.NumberDecksControl = new DataJuggler.Win.Controls.LabelSliderControl();
                this.UnlimitedRebuysComputerControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.UnlimitedRebuysUserControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.DealerMustHitSoft17Control = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.AllowSurrenderControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.AllowSplitControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.AllowInsuranceControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.DoubleOnTenOrElevenControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.AllowDoubleOnSplitControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.AllowDoubleDownControl = new DataJuggler.Win.Controls.LabelCheckBoxControl();
                this.SuspendLayout();
                // 
                // DefaultBankRollHumanChipSelector
                // 
                this.DefaultBankRollHumanChipSelector.BackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollHumanChipSelector.BackgroundImage = global::CardCounter.Properties.Resources.Chip_Rack;
                this.DefaultBankRollHumanChipSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.DefaultBankRollHumanChipSelector.FlatAppearance.BorderSize = 0;
                this.DefaultBankRollHumanChipSelector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollHumanChipSelector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollHumanChipSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.DefaultBankRollHumanChipSelector.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollHumanChipSelector.Location = new System.Drawing.Point(433, 200);
                this.DefaultBankRollHumanChipSelector.Name = "DefaultBankRollHumanChipSelector";
                this.DefaultBankRollHumanChipSelector.Size = new System.Drawing.Size(70, 40);
                this.DefaultBankRollHumanChipSelector.TabIndex = 49;
                this.DefaultBankRollHumanChipSelector.UseVisualStyleBackColor = false;
                this.DefaultBankRollHumanChipSelector.Click += new System.EventHandler(this.DefaultBankRollHumanChipSelector_Click);
                this.DefaultBankRollHumanChipSelector.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.DefaultBankRollHumanChipSelector.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // DefaultBankRollComputerChipSelector
                // 
                this.DefaultBankRollComputerChipSelector.BackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollComputerChipSelector.BackgroundImage = global::CardCounter.Properties.Resources.Chip_Rack;
                this.DefaultBankRollComputerChipSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.DefaultBankRollComputerChipSelector.FlatAppearance.BorderSize = 0;
                this.DefaultBankRollComputerChipSelector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollComputerChipSelector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollComputerChipSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.DefaultBankRollComputerChipSelector.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollComputerChipSelector.Location = new System.Drawing.Point(433, 282);
                this.DefaultBankRollComputerChipSelector.Name = "DefaultBankRollComputerChipSelector";
                this.DefaultBankRollComputerChipSelector.Size = new System.Drawing.Size(70, 40);
                this.DefaultBankRollComputerChipSelector.TabIndex = 51;
                this.DefaultBankRollComputerChipSelector.UseVisualStyleBackColor = false;
                this.DefaultBankRollComputerChipSelector.Click += new System.EventHandler(this.DefaultBankRollComputerChipSelector_Click);
                this.DefaultBankRollComputerChipSelector.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.DefaultBankRollComputerChipSelector.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // TableMinimumChipSelector
                // 
                this.TableMinimumChipSelector.BackColor = System.Drawing.Color.Transparent;
                this.TableMinimumChipSelector.BackgroundImage = global::CardCounter.Properties.Resources.Chip_Rack;
                this.TableMinimumChipSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.TableMinimumChipSelector.FlatAppearance.BorderSize = 0;
                this.TableMinimumChipSelector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.TableMinimumChipSelector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.TableMinimumChipSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.TableMinimumChipSelector.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMinimumChipSelector.Location = new System.Drawing.Point(433, 456);
                this.TableMinimumChipSelector.Name = "TableMinimumChipSelector";
                this.TableMinimumChipSelector.Size = new System.Drawing.Size(70, 40);
                this.TableMinimumChipSelector.TabIndex = 53;
                this.TableMinimumChipSelector.UseVisualStyleBackColor = false;
                this.TableMinimumChipSelector.Click += new System.EventHandler(this.TableMinimumChipSelector_Click);
                this.TableMinimumChipSelector.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.TableMinimumChipSelector.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // TableMaximumChipSelector
                // 
                this.TableMaximumChipSelector.BackColor = System.Drawing.Color.Transparent;
                this.TableMaximumChipSelector.BackgroundImage = global::CardCounter.Properties.Resources.Chip_Rack;
                this.TableMaximumChipSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.TableMaximumChipSelector.FlatAppearance.BorderSize = 0;
                this.TableMaximumChipSelector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.TableMaximumChipSelector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.TableMaximumChipSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.TableMaximumChipSelector.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMaximumChipSelector.Location = new System.Drawing.Point(433, 504);
                this.TableMaximumChipSelector.Name = "TableMaximumChipSelector";
                this.TableMaximumChipSelector.Size = new System.Drawing.Size(70, 40);
                this.TableMaximumChipSelector.TabIndex = 55;
                this.TableMaximumChipSelector.UseVisualStyleBackColor = false;
                this.TableMaximumChipSelector.Click += new System.EventHandler(this.TableMaximumChipSelector_Click);
                this.TableMaximumChipSelector.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.TableMaximumChipSelector.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // TableMaximumControl
                // 
                this.TableMaximumControl.BackColor = System.Drawing.Color.Transparent;
                this.TableMaximumControl.BottomMargin = 0;
                this.TableMaximumControl.Editable = true;
                this.TableMaximumControl.Encrypted = false;
                this.TableMaximumControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMaximumControl.LabelBottomMargin = 0;
                this.TableMaximumControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.TableMaximumControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMaximumControl.LabelText = "Table Maximum:";
                this.TableMaximumControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.TableMaximumControl.LabelTopMargin = 4;
                this.TableMaximumControl.LabelWidth = 300;
                this.TableMaximumControl.Location = new System.Drawing.Point(27, 510);
                this.TableMaximumControl.MultiLine = false;
                this.TableMaximumControl.Name = "TableMaximumControl";
                this.TableMaximumControl.OnTextChangedListener = null;
                this.TableMaximumControl.PasswordMode = false;
                this.TableMaximumControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TableMaximumControl.Size = new System.Drawing.Size(400, 32);
                this.TableMaximumControl.TabIndex = 54;
                this.TableMaximumControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                this.TableMaximumControl.TextBoxBottomMargin = 0;
                this.TableMaximumControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.TableMaximumControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.TableMaximumControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMaximumControl.TextBoxTopMargin = 4;
                // 
                // TableMinimumControl
                // 
                this.TableMinimumControl.BackColor = System.Drawing.Color.Transparent;
                this.TableMinimumControl.BottomMargin = 0;
                this.TableMinimumControl.Editable = true;
                this.TableMinimumControl.Encrypted = false;
                this.TableMinimumControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMinimumControl.LabelBottomMargin = 0;
                this.TableMinimumControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.TableMinimumControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMinimumControl.LabelText = "Table Minimum:";
                this.TableMinimumControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.TableMinimumControl.LabelTopMargin = 4;
                this.TableMinimumControl.LabelWidth = 300;
                this.TableMinimumControl.Location = new System.Drawing.Point(27, 462);
                this.TableMinimumControl.MultiLine = false;
                this.TableMinimumControl.Name = "TableMinimumControl";
                this.TableMinimumControl.OnTextChangedListener = null;
                this.TableMinimumControl.PasswordMode = false;
                this.TableMinimumControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.TableMinimumControl.Size = new System.Drawing.Size(400, 32);
                this.TableMinimumControl.TabIndex = 52;
                this.TableMinimumControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                this.TableMinimumControl.TextBoxBottomMargin = 0;
                this.TableMinimumControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.TableMinimumControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.TableMinimumControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.TableMinimumControl.TextBoxTopMargin = 4;
                // 
                // DefaultBankRollComputerControl
                // 
                this.DefaultBankRollComputerControl.BackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollComputerControl.BottomMargin = 0;
                this.DefaultBankRollComputerControl.Editable = true;
                this.DefaultBankRollComputerControl.Encrypted = false;
                this.DefaultBankRollComputerControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollComputerControl.LabelBottomMargin = 0;
                this.DefaultBankRollComputerControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.DefaultBankRollComputerControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollComputerControl.LabelText = "Default Bank Roll (comp):";
                this.DefaultBankRollComputerControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.DefaultBankRollComputerControl.LabelTopMargin = 4;
                this.DefaultBankRollComputerControl.LabelWidth = 300;
                this.DefaultBankRollComputerControl.Location = new System.Drawing.Point(27, 288);
                this.DefaultBankRollComputerControl.MultiLine = false;
                this.DefaultBankRollComputerControl.Name = "DefaultBankRollComputerControl";
                this.DefaultBankRollComputerControl.OnTextChangedListener = null;
                this.DefaultBankRollComputerControl.PasswordMode = false;
                this.DefaultBankRollComputerControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.DefaultBankRollComputerControl.Size = new System.Drawing.Size(400, 32);
                this.DefaultBankRollComputerControl.TabIndex = 50;
                this.DefaultBankRollComputerControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                this.DefaultBankRollComputerControl.TextBoxBottomMargin = 0;
                this.DefaultBankRollComputerControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.DefaultBankRollComputerControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.DefaultBankRollComputerControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollComputerControl.TextBoxTopMargin = 4;
                // 
                // DefaultBankRollHumanControl
                // 
                this.DefaultBankRollHumanControl.BackColor = System.Drawing.Color.Transparent;
                this.DefaultBankRollHumanControl.BottomMargin = 0;
                this.DefaultBankRollHumanControl.Editable = true;
                this.DefaultBankRollHumanControl.Encrypted = false;
                this.DefaultBankRollHumanControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollHumanControl.LabelBottomMargin = 0;
                this.DefaultBankRollHumanControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.DefaultBankRollHumanControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollHumanControl.LabelText = "Default Bank Roll (user):";
                this.DefaultBankRollHumanControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.DefaultBankRollHumanControl.LabelTopMargin = 4;
                this.DefaultBankRollHumanControl.LabelWidth = 300;
                this.DefaultBankRollHumanControl.Location = new System.Drawing.Point(27, 208);
                this.DefaultBankRollHumanControl.MultiLine = false;
                this.DefaultBankRollHumanControl.Name = "DefaultBankRollHumanControl";
                this.DefaultBankRollHumanControl.OnTextChangedListener = null;
                this.DefaultBankRollHumanControl.PasswordMode = false;
                this.DefaultBankRollHumanControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
                this.DefaultBankRollHumanControl.Size = new System.Drawing.Size(400, 32);
                this.DefaultBankRollHumanControl.TabIndex = 45;
                this.DefaultBankRollHumanControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                this.DefaultBankRollHumanControl.TextBoxBottomMargin = 0;
                this.DefaultBankRollHumanControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
                this.DefaultBankRollHumanControl.TextBoxEditableColor = System.Drawing.Color.White;
                this.DefaultBankRollHumanControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DefaultBankRollHumanControl.TextBoxTopMargin = 4;
                // 
                // AllowReSplitAcesControl
                // 
                this.AllowReSplitAcesControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowReSplitAcesControl.CheckBoxVerticalOffSet = 6;
                this.AllowReSplitAcesControl.CheckChangedListener = null;
                this.AllowReSplitAcesControl.Checked = false;
                this.AllowReSplitAcesControl.Editable = true;
                this.AllowReSplitAcesControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowReSplitAcesControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowReSplitAcesControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowReSplitAcesControl.LabelText = "Allow Re-Split Aces:";
                this.AllowReSplitAcesControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowReSplitAcesControl.LabelWidth = 300;
                this.AllowReSplitAcesControl.Location = new System.Drawing.Point(351, 88);
                this.AllowReSplitAcesControl.Name = "AllowReSplitAcesControl";
                this.AllowReSplitAcesControl.Size = new System.Drawing.Size(320, 32);
                this.AllowReSplitAcesControl.TabIndex = 5;
                // 
                // AllowSplitAcesControl
                // 
                this.AllowSplitAcesControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowSplitAcesControl.CheckBoxVerticalOffSet = 6;
                this.AllowSplitAcesControl.CheckChangedListener = null;
                this.AllowSplitAcesControl.Checked = false;
                this.AllowSplitAcesControl.Editable = true;
                this.AllowSplitAcesControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowSplitAcesControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowSplitAcesControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowSplitAcesControl.LabelText = "Allow Split Aces:";
                this.AllowSplitAcesControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowSplitAcesControl.LabelWidth = 300;
                this.AllowSplitAcesControl.Location = new System.Drawing.Point(27, 88);
                this.AllowSplitAcesControl.Name = "AllowSplitAcesControl";
                this.AllowSplitAcesControl.Size = new System.Drawing.Size(320, 32);
                this.AllowSplitAcesControl.TabIndex = 4;
                // 
                // PenetrationControl
                // 
                this.PenetrationControl.BackColor = System.Drawing.Color.Transparent;
                this.PenetrationControl.Increments = 0;
                this.PenetrationControl.LabelBottomMargin = 0;
                this.PenetrationControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.PenetrationControl.LabelText = "Reshuffle Penetration:";
                this.PenetrationControl.LabelTextBoxControlEditable = false;
                this.PenetrationControl.LabelTextBoxControlHeight = 0;
                this.PenetrationControl.LabelTextBoxControlWidth = 0;
                this.PenetrationControl.LabelTopMargin = 2;
                this.PenetrationControl.LabelWidth = 300;
                this.PenetrationControl.LargeChange = 5;
                this.PenetrationControl.LeftPanelWidth = 400;
                this.PenetrationControl.Location = new System.Drawing.Point(27, 412);
                this.PenetrationControl.Name = "PenetrationControl";
                this.PenetrationControl.RightMargin = 0;
                this.PenetrationControl.Size = new System.Drawing.Size(646, 36);
                this.PenetrationControl.SliderMaximum = 80;
                this.PenetrationControl.SliderMinimum = 40;
                this.PenetrationControl.SliderValue = 40;
                this.PenetrationControl.SmallChange = 1;
                this.PenetrationControl.TabIndex = 14;
                this.PenetrationControl.TextBoxBottomMargin = 0;
                this.PenetrationControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
                this.PenetrationControl.TextBoxEditableColor = System.Drawing.Color.Empty;
                this.PenetrationControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.PenetrationControl.TextBoxRightMargin = 8;
                this.PenetrationControl.TextBoxTopMargin = 4;
                this.PenetrationControl.TopMargin = 0;
                this.PenetrationControl.ValueChangedListener = null;
                // 
                // NumberDecksControl
                // 
                this.NumberDecksControl.BackColor = System.Drawing.Color.Transparent;
                this.NumberDecksControl.Increments = 0;
                this.NumberDecksControl.LabelBottomMargin = 0;
                this.NumberDecksControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.NumberDecksControl.LabelText = "Number of Decks:";
                this.NumberDecksControl.LabelTextBoxControlEditable = false;
                this.NumberDecksControl.LabelTextBoxControlHeight = 0;
                this.NumberDecksControl.LabelTextBoxControlWidth = 0;
                this.NumberDecksControl.LabelTopMargin = 2;
                this.NumberDecksControl.LabelWidth = 300;
                this.NumberDecksControl.LargeChange = 1;
                this.NumberDecksControl.LeftPanelWidth = 400;
                this.NumberDecksControl.Location = new System.Drawing.Point(27, 368);
                this.NumberDecksControl.Name = "NumberDecksControl";
                this.NumberDecksControl.RightMargin = 0;
                this.NumberDecksControl.Size = new System.Drawing.Size(646, 36);
                this.NumberDecksControl.SliderMaximum = 8;
                this.NumberDecksControl.SliderMinimum = 1;
                this.NumberDecksControl.SliderValue = 1;
                this.NumberDecksControl.SmallChange = 1;
                this.NumberDecksControl.TabIndex = 13;
                this.NumberDecksControl.TextBoxBottomMargin = 0;
                this.NumberDecksControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
                this.NumberDecksControl.TextBoxEditableColor = System.Drawing.Color.Empty;
                this.NumberDecksControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.NumberDecksControl.TextBoxRightMargin = 8;
                this.NumberDecksControl.TextBoxTopMargin = 4;
                this.NumberDecksControl.TopMargin = 0;
                this.NumberDecksControl.ValueChangedListener = null;
                // 
                // UnlimitedRebuysComputerControl
                // 
                this.UnlimitedRebuysComputerControl.BackColor = System.Drawing.Color.Transparent;
                this.UnlimitedRebuysComputerControl.CheckBoxVerticalOffSet = 6;
                this.UnlimitedRebuysComputerControl.CheckChangedListener = null;
                this.UnlimitedRebuysComputerControl.Checked = true;
                this.UnlimitedRebuysComputerControl.Editable = true;
                this.UnlimitedRebuysComputerControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.UnlimitedRebuysComputerControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.UnlimitedRebuysComputerControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.UnlimitedRebuysComputerControl.LabelText = "Unlimited Rebuys (comp):";
                this.UnlimitedRebuysComputerControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.UnlimitedRebuysComputerControl.LabelWidth = 300;
                this.UnlimitedRebuysComputerControl.Location = new System.Drawing.Point(27, 328);
                this.UnlimitedRebuysComputerControl.Name = "UnlimitedRebuysComputerControl";
                this.UnlimitedRebuysComputerControl.Size = new System.Drawing.Size(320, 32);
                this.UnlimitedRebuysComputerControl.TabIndex = 12;
                // 
                // UnlimitedRebuysUserControl
                // 
                this.UnlimitedRebuysUserControl.BackColor = System.Drawing.Color.Transparent;
                this.UnlimitedRebuysUserControl.CheckBoxVerticalOffSet = 6;
                this.UnlimitedRebuysUserControl.CheckChangedListener = null;
                this.UnlimitedRebuysUserControl.Checked = true;
                this.UnlimitedRebuysUserControl.Editable = true;
                this.UnlimitedRebuysUserControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.UnlimitedRebuysUserControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.UnlimitedRebuysUserControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.UnlimitedRebuysUserControl.LabelText = "Unlimited Rebuys (user):";
                this.UnlimitedRebuysUserControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.UnlimitedRebuysUserControl.LabelWidth = 300;
                this.UnlimitedRebuysUserControl.Location = new System.Drawing.Point(27, 248);
                this.UnlimitedRebuysUserControl.Name = "UnlimitedRebuysUserControl";
                this.UnlimitedRebuysUserControl.Size = new System.Drawing.Size(320, 32);
                this.UnlimitedRebuysUserControl.TabIndex = 10;
                // 
                // DealerMustHitSoft17Control
                // 
                this.DealerMustHitSoft17Control.BackColor = System.Drawing.Color.Transparent;
                this.DealerMustHitSoft17Control.CheckBoxVerticalOffSet = 6;
                this.DealerMustHitSoft17Control.CheckChangedListener = null;
                this.DealerMustHitSoft17Control.Checked = true;
                this.DealerMustHitSoft17Control.Editable = true;
                this.DealerMustHitSoft17Control.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DealerMustHitSoft17Control.LabelColor = System.Drawing.SystemColors.ControlText;
                this.DealerMustHitSoft17Control.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DealerMustHitSoft17Control.LabelText = "Dealer Must Hit Soft 17:";
                this.DealerMustHitSoft17Control.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.DealerMustHitSoft17Control.LabelWidth = 300;
                this.DealerMustHitSoft17Control.Location = new System.Drawing.Point(27, 168);
                this.DealerMustHitSoft17Control.Name = "DealerMustHitSoft17Control";
                this.DealerMustHitSoft17Control.Size = new System.Drawing.Size(320, 32);
                this.DealerMustHitSoft17Control.TabIndex = 8;
                // 
                // AllowSurrenderControl
                // 
                this.AllowSurrenderControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowSurrenderControl.CheckBoxVerticalOffSet = 6;
                this.AllowSurrenderControl.CheckChangedListener = null;
                this.AllowSurrenderControl.Checked = false;
                this.AllowSurrenderControl.Editable = true;
                this.AllowSurrenderControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowSurrenderControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowSurrenderControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowSurrenderControl.LabelText = "Allow Surrender:";
                this.AllowSurrenderControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowSurrenderControl.LabelWidth = 300;
                this.AllowSurrenderControl.Location = new System.Drawing.Point(351, 128);
                this.AllowSurrenderControl.Name = "AllowSurrenderControl";
                this.AllowSurrenderControl.Size = new System.Drawing.Size(320, 32);
                this.AllowSurrenderControl.TabIndex = 7;
                // 
                // AllowSplitControl
                // 
                this.AllowSplitControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowSplitControl.CheckBoxVerticalOffSet = 6;
                this.AllowSplitControl.CheckChangedListener = null;
                this.AllowSplitControl.Checked = true;
                this.AllowSplitControl.Editable = true;
                this.AllowSplitControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowSplitControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowSplitControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowSplitControl.LabelText = "Allow Split:";
                this.AllowSplitControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowSplitControl.LabelWidth = 300;
                this.AllowSplitControl.Location = new System.Drawing.Point(27, 48);
                this.AllowSplitControl.Name = "AllowSplitControl";
                this.AllowSplitControl.Size = new System.Drawing.Size(320, 32);
                this.AllowSplitControl.TabIndex = 2;
                // 
                // AllowInsuranceControl
                // 
                this.AllowInsuranceControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowInsuranceControl.CheckBoxVerticalOffSet = 6;
                this.AllowInsuranceControl.CheckChangedListener = null;
                this.AllowInsuranceControl.Checked = false;
                this.AllowInsuranceControl.Editable = true;
                this.AllowInsuranceControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowInsuranceControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowInsuranceControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowInsuranceControl.LabelText = "Allow Insurance:";
                this.AllowInsuranceControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowInsuranceControl.LabelWidth = 300;
                this.AllowInsuranceControl.Location = new System.Drawing.Point(27, 128);
                this.AllowInsuranceControl.Name = "AllowInsuranceControl";
                this.AllowInsuranceControl.Size = new System.Drawing.Size(320, 32);
                this.AllowInsuranceControl.TabIndex = 6;
                // 
                // DoubleOnTenOrElevenControl
                // 
                this.DoubleOnTenOrElevenControl.BackColor = System.Drawing.Color.Transparent;
                this.DoubleOnTenOrElevenControl.CheckBoxVerticalOffSet = 6;
                this.DoubleOnTenOrElevenControl.CheckChangedListener = null;
                this.DoubleOnTenOrElevenControl.Checked = false;
                this.DoubleOnTenOrElevenControl.Editable = true;
                this.DoubleOnTenOrElevenControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DoubleOnTenOrElevenControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.DoubleOnTenOrElevenControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.DoubleOnTenOrElevenControl.LabelText = "Double On 10 or 11 Only:";
                this.DoubleOnTenOrElevenControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.DoubleOnTenOrElevenControl.LabelWidth = 300;
                this.DoubleOnTenOrElevenControl.Location = new System.Drawing.Point(351, 8);
                this.DoubleOnTenOrElevenControl.Name = "DoubleOnTenOrElevenControl";
                this.DoubleOnTenOrElevenControl.Size = new System.Drawing.Size(320, 32);
                this.DoubleOnTenOrElevenControl.TabIndex = 1;
                // 
                // AllowDoubleOnSplitControl
                // 
                this.AllowDoubleOnSplitControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowDoubleOnSplitControl.CheckBoxVerticalOffSet = 6;
                this.AllowDoubleOnSplitControl.CheckChangedListener = null;
                this.AllowDoubleOnSplitControl.Checked = false;
                this.AllowDoubleOnSplitControl.Editable = true;
                this.AllowDoubleOnSplitControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowDoubleOnSplitControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowDoubleOnSplitControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowDoubleOnSplitControl.LabelText = "Allow Double On Split:";
                this.AllowDoubleOnSplitControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowDoubleOnSplitControl.LabelWidth = 300;
                this.AllowDoubleOnSplitControl.Location = new System.Drawing.Point(351, 48);
                this.AllowDoubleOnSplitControl.Name = "AllowDoubleOnSplitControl";
                this.AllowDoubleOnSplitControl.Size = new System.Drawing.Size(320, 32);
                this.AllowDoubleOnSplitControl.TabIndex = 3;
                // 
                // AllowDoubleDownControl
                // 
                this.AllowDoubleDownControl.BackColor = System.Drawing.Color.Transparent;
                this.AllowDoubleDownControl.CheckBoxVerticalOffSet = 6;
                this.AllowDoubleDownControl.CheckChangedListener = null;
                this.AllowDoubleDownControl.Checked = true;
                this.AllowDoubleDownControl.Editable = true;
                this.AllowDoubleDownControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowDoubleDownControl.LabelColor = System.Drawing.SystemColors.ControlText;
                this.AllowDoubleDownControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.AllowDoubleDownControl.LabelText = "Allow Double Down:";
                this.AllowDoubleDownControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
                this.AllowDoubleDownControl.LabelWidth = 300;
                this.AllowDoubleDownControl.Location = new System.Drawing.Point(27, 8);
                this.AllowDoubleDownControl.Name = "AllowDoubleDownControl";
                this.AllowDoubleDownControl.Size = new System.Drawing.Size(320, 32);
                this.AllowDoubleDownControl.TabIndex = 0;
                // 
                // OptionsControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(this.TableMaximumChipSelector);
                this.Controls.Add(this.TableMaximumControl);
                this.Controls.Add(this.TableMinimumChipSelector);
                this.Controls.Add(this.TableMinimumControl);
                this.Controls.Add(this.DefaultBankRollComputerChipSelector);
                this.Controls.Add(this.DefaultBankRollComputerControl);
                this.Controls.Add(this.DefaultBankRollHumanChipSelector);
                this.Controls.Add(this.DefaultBankRollHumanControl);
                this.Controls.Add(this.AllowReSplitAcesControl);
                this.Controls.Add(this.AllowSplitAcesControl);
                this.Controls.Add(this.PenetrationControl);
                this.Controls.Add(this.NumberDecksControl);
                this.Controls.Add(this.UnlimitedRebuysComputerControl);
                this.Controls.Add(this.UnlimitedRebuysUserControl);
                this.Controls.Add(this.DealerMustHitSoft17Control);
                this.Controls.Add(this.AllowSurrenderControl);
                this.Controls.Add(this.AllowSplitControl);
                this.Controls.Add(this.AllowInsuranceControl);
                this.Controls.Add(this.DoubleOnTenOrElevenControl);
                this.Controls.Add(this.AllowDoubleOnSplitControl);
                this.Controls.Add(this.AllowDoubleDownControl);
                this.DoubleBuffered = true;
                this.Name = "OptionsControl";
                this.Size = new System.Drawing.Size(702, 552);
                this.ResumeLayout(false);
                
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
