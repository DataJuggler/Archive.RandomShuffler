

#region using statements


#endregion

namespace CardCounter.UI.Controls
{

    #region class BlackJackPlayerControl1
    /// <summary>
    /// This is the Designer for the BlackJackPlayerControl1
    /// </summary>
    partial class BlackJackPlayerControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
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
            this.components = new System.ComponentModel.Container();
            this.SpacerPanel = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DoubleDownIcon = new System.Windows.Forms.PictureBox();
            this.InsuranceIcon = new System.Windows.Forms.PictureBox();
            this.ComputerIcon = new System.Windows.Forms.PictureBox();
            this.SpacerPanel5 = new System.Windows.Forms.Panel();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.SpacerPanel4 = new System.Windows.Forms.Panel();
            this.PlayerInfoPanel = new System.Windows.Forms.Panel();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.PlayerNamePanel = new System.Windows.Forms.Panel();
            this.ChipsLabel = new System.Windows.Forms.Label();
            this.ActionIconsPanel = new System.Windows.Forms.Panel();
            this.ComputerIconPanel = new System.Windows.Forms.Panel();
            this.SpacerPanel3 = new System.Windows.Forms.Panel();
            this.SpacerPanel6 = new System.Windows.Forms.Panel();
            this.ChipSelectorButton = new System.Windows.Forms.Button();
            this.BetPanel = new System.Windows.Forms.Panel();
            this.ChipsPanel = new System.Windows.Forms.Panel();
            this.ChipsHostControl = new CardCounter.UI.Controls.ChipsHostControl();
            this.AmountWageredLabel = new System.Windows.Forms.Label();
            this.CardContainerControl = new CardCounter.UI.Controls.CardContainerControl();
            this.LeftBetPanel = new System.Windows.Forms.Panel();
            this.BetAmountTextBox = new System.Windows.Forms.TextBox();
            this.SpacerPanel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleDownIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerIcon)).BeginInit();
            this.PlayerInfoPanel.SuspendLayout();
            this.PlayerNamePanel.SuspendLayout();
            this.ActionIconsPanel.SuspendLayout();
            this.ComputerIconPanel.SuspendLayout();
            this.BetPanel.SuspendLayout();
            this.ChipsPanel.SuspendLayout();
            this.LeftBetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SpacerPanel
            // 
            this.SpacerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpacerPanel.Location = new System.Drawing.Point(0, 0);
            this.SpacerPanel.Name = "SpacerPanel";
            this.SpacerPanel.Size = new System.Drawing.Size(180, 4);
            this.SpacerPanel.TabIndex = 14;
            // 
            // DoubleDownIcon
            // 
            this.DoubleDownIcon.BackgroundImage = global::CardCounter.Properties.Resources.DoubleDown1;
            this.DoubleDownIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleDownIcon.Location = new System.Drawing.Point(4, 34);
            this.DoubleDownIcon.Name = "DoubleDownIcon";
            this.DoubleDownIcon.Size = new System.Drawing.Size(16, 16);
            this.DoubleDownIcon.TabIndex = 11;
            this.DoubleDownIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.DoubleDownIcon, "This player doubled down this hand.");
            this.DoubleDownIcon.Visible = false;
            // 
            // InsuranceIcon
            // 
            this.InsuranceIcon.BackgroundImage = global::CardCounter.Properties.Resources.InusranceIcon;
            this.InsuranceIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InsuranceIcon.Location = new System.Drawing.Point(4, 10);
            this.InsuranceIcon.Name = "InsuranceIcon";
            this.InsuranceIcon.Size = new System.Drawing.Size(16, 16);
            this.InsuranceIcon.TabIndex = 2;
            this.InsuranceIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.InsuranceIcon, "This player took insurance this hand.");
            this.InsuranceIcon.Visible = false;
            // 
            // ComputerIcon
            // 
            this.ComputerIcon.BackgroundImage = global::CardCounter.Properties.Resources.Computer;
            this.ComputerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComputerIcon.Location = new System.Drawing.Point(2, 24);
            this.ComputerIcon.Name = "ComputerIcon";
            this.ComputerIcon.Size = new System.Drawing.Size(16, 16);
            this.ComputerIcon.TabIndex = 1;
            this.ComputerIcon.TabStop = false;
            this.ToolTip.SetToolTip(this.ComputerIcon, "This is a computer player.");
            this.ComputerIcon.Visible = false;
            // 
            // SpacerPanel5
            // 
            this.SpacerPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpacerPanel5.Location = new System.Drawing.Point(0, 492);
            this.SpacerPanel5.Name = "SpacerPanel5";
            this.SpacerPanel5.Size = new System.Drawing.Size(180, 4);
            this.SpacerPanel5.TabIndex = 19;
            // 
            // ActionLabel
            // 
            this.ActionLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ActionLabel.Location = new System.Drawing.Point(0, 460);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(180, 32);
            this.ActionLabel.TabIndex = 24;
            this.ActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpacerPanel4
            // 
            this.SpacerPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpacerPanel4.Location = new System.Drawing.Point(0, 456);
            this.SpacerPanel4.Name = "SpacerPanel4";
            this.SpacerPanel4.Size = new System.Drawing.Size(180, 4);
            this.SpacerPanel4.TabIndex = 30;
            // 
            // PlayerInfoPanel
            // 
            this.PlayerInfoPanel.BackgroundImage = global::CardCounter.Properties.Resources.MidnightBlueGradientWithBorder;
            this.PlayerInfoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerInfoPanel.Controls.Add(this.PlayerNameLabel);
            this.PlayerInfoPanel.Controls.Add(this.PlayerNamePanel);
            this.PlayerInfoPanel.Controls.Add(this.ActionIconsPanel);
            this.PlayerInfoPanel.Controls.Add(this.ComputerIconPanel);
            this.PlayerInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerInfoPanel.Location = new System.Drawing.Point(0, 392);
            this.PlayerInfoPanel.Name = "PlayerInfoPanel";
            this.PlayerInfoPanel.Size = new System.Drawing.Size(180, 64);
            this.PlayerInfoPanel.TabIndex = 31;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PlayerNameLabel.Location = new System.Drawing.Point(22, 0);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(136, 32);
            this.PlayerNameLabel.TabIndex = 7;
            this.PlayerNameLabel.Text = "PlayerName";
            this.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerNamePanel
            // 
            this.PlayerNamePanel.Controls.Add(this.ChipsLabel);
            this.PlayerNamePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayerNamePanel.Location = new System.Drawing.Point(22, 32);
            this.PlayerNamePanel.Name = "PlayerNamePanel";
            this.PlayerNamePanel.Size = new System.Drawing.Size(136, 32);
            this.PlayerNamePanel.TabIndex = 5;
            // 
            // ChipsLabel
            // 
            this.ChipsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChipsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChipsLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ChipsLabel.Location = new System.Drawing.Point(0, 0);
            this.ChipsLabel.Name = "ChipsLabel";
            this.ChipsLabel.Size = new System.Drawing.Size(136, 32);
            this.ChipsLabel.TabIndex = 10;
            this.ChipsLabel.Text = "$0";
            this.ChipsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActionIconsPanel
            // 
            this.ActionIconsPanel.Controls.Add(this.DoubleDownIcon);
            this.ActionIconsPanel.Controls.Add(this.InsuranceIcon);
            this.ActionIconsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ActionIconsPanel.Location = new System.Drawing.Point(0, 0);
            this.ActionIconsPanel.MaximumSize = new System.Drawing.Size(22, 64);
            this.ActionIconsPanel.MinimumSize = new System.Drawing.Size(22, 64);
            this.ActionIconsPanel.Name = "ActionIconsPanel";
            this.ActionIconsPanel.Size = new System.Drawing.Size(22, 64);
            this.ActionIconsPanel.TabIndex = 0;
            // 
            // ComputerIconPanel
            // 
            this.ComputerIconPanel.Controls.Add(this.ComputerIcon);
            this.ComputerIconPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ComputerIconPanel.Location = new System.Drawing.Point(158, 0);
            this.ComputerIconPanel.MaximumSize = new System.Drawing.Size(22, 64);
            this.ComputerIconPanel.MinimumSize = new System.Drawing.Size(22, 64);
            this.ComputerIconPanel.Name = "ComputerIconPanel";
            this.ComputerIconPanel.Size = new System.Drawing.Size(22, 64);
            this.ComputerIconPanel.TabIndex = 6;
            // 
            // SpacerPanel3
            // 
            this.SpacerPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpacerPanel3.Location = new System.Drawing.Point(0, 388);
            this.SpacerPanel3.Name = "SpacerPanel3";
            this.SpacerPanel3.Size = new System.Drawing.Size(180, 4);
            this.SpacerPanel3.TabIndex = 32;
            // 
            // SpacerPanel6
            // 
            this.SpacerPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SpacerPanel6.Location = new System.Drawing.Point(0, 340);
            this.SpacerPanel6.Name = "SpacerPanel6";
            this.SpacerPanel6.Size = new System.Drawing.Size(180, 4);
            this.SpacerPanel6.TabIndex = 35;
            // 
            // ChipSelectorButton
            // 
            this.ChipSelectorButton.BackColor = System.Drawing.Color.Transparent;
            this.ChipSelectorButton.BackgroundImage = global::CardCounter.Properties.Resources.Chip_Rack;
            this.ChipSelectorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChipSelectorButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChipSelectorButton.FlatAppearance.BorderSize = 0;
            this.ChipSelectorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChipSelectorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChipSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChipSelectorButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipSelectorButton.Location = new System.Drawing.Point(110, 0);
            this.ChipSelectorButton.MaximumSize = new System.Drawing.Size(70, 44);
            this.ChipSelectorButton.MinimumSize = new System.Drawing.Size(70, 44);
            this.ChipSelectorButton.Name = "ChipSelectorButton";
            this.ChipSelectorButton.Size = new System.Drawing.Size(70, 44);
            this.ChipSelectorButton.TabIndex = 58;
            this.ChipSelectorButton.UseVisualStyleBackColor = false;
            this.ChipSelectorButton.Visible = false;
            this.ChipSelectorButton.Click += new System.EventHandler(this.ChipSelectorButton_Click);
            this.ChipSelectorButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ChipSelectorButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // BetPanel
            // 
            this.BetPanel.Controls.Add(this.LeftBetPanel);
            this.BetPanel.Controls.Add(this.ChipSelectorButton);
            this.BetPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BetPanel.Location = new System.Drawing.Point(0, 344);
            this.BetPanel.Name = "BetPanel";
            this.BetPanel.Size = new System.Drawing.Size(180, 44);
            this.BetPanel.TabIndex = 33;
            this.BetPanel.Visible = false;
            // 
            // ChipsPanel
            // 
            this.ChipsPanel.Controls.Add(this.ChipsHostControl);
            this.ChipsPanel.Controls.Add(this.AmountWageredLabel);
            this.ChipsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChipsPanel.Location = new System.Drawing.Point(0, 304);
            this.ChipsPanel.Name = "ChipsPanel";
            this.ChipsPanel.Size = new System.Drawing.Size(180, 36);
            this.ChipsPanel.TabIndex = 52;
            this.ChipsPanel.Visible = false;
            // 
            // ChipsHostControl
            // 
            this.ChipsHostControl.BackColor = System.Drawing.Color.Transparent;
            this.ChipsHostControl.Chips = null;
            this.ChipsHostControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChipsHostControl.Location = new System.Drawing.Point(96, 0);
            this.ChipsHostControl.Name = "ChipsHostControl";
            this.ChipsHostControl.Size = new System.Drawing.Size(84, 36);
            this.ChipsHostControl.TabIndex = 64;
            // 
            // AmountWageredLabel
            // 
            this.AmountWageredLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountWageredLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AmountWageredLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountWageredLabel.ForeColor = System.Drawing.Color.White;
            this.AmountWageredLabel.Location = new System.Drawing.Point(0, 0);
            this.AmountWageredLabel.Name = "AmountWageredLabel";
            this.AmountWageredLabel.Size = new System.Drawing.Size(96, 36);
            this.AmountWageredLabel.TabIndex = 63;
            this.AmountWageredLabel.Text = "$500";
            this.AmountWageredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AmountWageredLabel.Visible = false;
            // 
            // CardContainerControl
            // 
            this.CardContainerControl.BackColor = System.Drawing.Color.Transparent;
            this.CardContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardContainerControl.Location = new System.Drawing.Point(0, 4);
            this.CardContainerControl.Name = "CardContainerControl";
            this.CardContainerControl.Size = new System.Drawing.Size(180, 300);
            this.CardContainerControl.TabIndex = 53;
            // 
            // LeftBetPanel
            // 
            this.LeftBetPanel.Controls.Add(this.BetAmountTextBox);
            this.LeftBetPanel.Controls.Add(this.SpacerPanel2);
            this.LeftBetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftBetPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftBetPanel.Name = "LeftBetPanel";
            this.LeftBetPanel.Size = new System.Drawing.Size(110, 44);
            this.LeftBetPanel.TabIndex = 59;
            // 
            // BetAmountTextBox
            // 
            this.BetAmountTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BetAmountTextBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetAmountTextBox.Location = new System.Drawing.Point(0, 8);
            this.BetAmountTextBox.Name = "BetAmountTextBox";
            this.BetAmountTextBox.Size = new System.Drawing.Size(110, 33);
            this.BetAmountTextBox.TabIndex = 7;
            this.BetAmountTextBox.Text = "$0";
            this.BetAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SpacerPanel2
            // 
            this.SpacerPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpacerPanel2.Location = new System.Drawing.Point(0, 0);
            this.SpacerPanel2.Name = "SpacerPanel2";
            this.SpacerPanel2.Size = new System.Drawing.Size(110, 8);
            this.SpacerPanel2.TabIndex = 5;
            // 
            // BlackJackPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.CardContainerControl);
            this.Controls.Add(this.ChipsPanel);
            this.Controls.Add(this.SpacerPanel6);
            this.Controls.Add(this.BetPanel);
            this.Controls.Add(this.SpacerPanel3);
            this.Controls.Add(this.PlayerInfoPanel);
            this.Controls.Add(this.SpacerPanel4);
            this.Controls.Add(this.ActionLabel);
            this.Controls.Add(this.SpacerPanel5);
            this.Controls.Add(this.SpacerPanel);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(180, 496);
            this.MinimumSize = new System.Drawing.Size(180, 496);
            this.Name = "BlackJackPlayerControl";
            this.Size = new System.Drawing.Size(180, 496);
            ((System.ComponentModel.ISupportInitialize)(this.DoubleDownIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerIcon)).EndInit();
            this.PlayerInfoPanel.ResumeLayout(false);
            this.PlayerNamePanel.ResumeLayout(false);
            this.ActionIconsPanel.ResumeLayout(false);
            this.ComputerIconPanel.ResumeLayout(false);
            this.BetPanel.ResumeLayout(false);
            this.ChipsPanel.ResumeLayout(false);
            this.LeftBetPanel.ResumeLayout(false);
            this.LeftBetPanel.PerformLayout();
            this.ResumeLayout(false);

            }
            #endregion


        #endregion

            private System.Windows.Forms.Panel SpacerPanel;
            private System.Windows.Forms.ToolTip ToolTip;
            private System.Windows.Forms.Panel SpacerPanel5;
            private System.Windows.Forms.Label ActionLabel;
            private System.Windows.Forms.Panel SpacerPanel4;
            private System.Windows.Forms.Panel PlayerInfoPanel;
            private System.Windows.Forms.Label PlayerNameLabel;
            private System.Windows.Forms.Panel PlayerNamePanel;
            private System.Windows.Forms.Label ChipsLabel;
            private System.Windows.Forms.Panel ActionIconsPanel;
            private System.Windows.Forms.PictureBox DoubleDownIcon;
            private System.Windows.Forms.PictureBox InsuranceIcon;
            private System.Windows.Forms.Panel ComputerIconPanel;
            private System.Windows.Forms.PictureBox ComputerIcon;
            private System.Windows.Forms.Panel SpacerPanel3;
            private System.Windows.Forms.Panel SpacerPanel6;
            private System.Windows.Forms.Button ChipSelectorButton;
            private System.Windows.Forms.Panel BetPanel;
            private System.Windows.Forms.Panel ChipsPanel;
            private ChipsHostControl ChipsHostControl;
            private System.Windows.Forms.Label AmountWageredLabel;
            private CardContainerControl CardContainerControl;
        private System.Windows.Forms.Panel LeftBetPanel;
        private System.Windows.Forms.TextBox BetAmountTextBox;
        private System.Windows.Forms.Panel SpacerPanel2;
    }
    #endregion

}
