

#region using statements


#endregion

namespace CardCounter.UI.Forms
{

    #region class OptionsForm
    /// <summary>
    /// This is the designer file for the Options Form.
    /// </summary>
    partial class OptionsForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.TabHostControl TabHostControl;
        private System.Windows.Forms.Panel BottomButtonPanel;
        private System.Windows.Forms.RadioButton StoreInMemoryRadioButton;
        private System.Windows.Forms.RadioButton SaveSettingsRadioButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private Controls.OptionsControl OptionsControl;
        private Controls.SelectPlayersControl SelectPlayersControl;
        private System.Windows.Forms.PictureBox TipImage;
        private System.Windows.Forms.Label TipTextLabel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.BottomButtonPanel = new System.Windows.Forms.Panel();
            this.TipTextLabel = new System.Windows.Forms.Label();
            this.TipImage = new System.Windows.Forms.PictureBox();
            this.StoreInMemoryRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveSettingsRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TabHostControl = new DataJuggler.Win.Controls.TabHostControl();
            this.SelectPlayersControl = new CardCounter.UI.Controls.SelectPlayersControl();
            this.OptionsControl = new CardCounter.UI.Controls.OptionsControl();
            this.BottomButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomButtonPanel
            // 
            this.BottomButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomButtonPanel.Controls.Add(this.TipTextLabel);
            this.BottomButtonPanel.Controls.Add(this.TipImage);
            this.BottomButtonPanel.Controls.Add(this.StoreInMemoryRadioButton);
            this.BottomButtonPanel.Controls.Add(this.SaveSettingsRadioButton);
            this.BottomButtonPanel.Controls.Add(this.CancelButton);
            this.BottomButtonPanel.Controls.Add(this.SaveButton);
            this.BottomButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomButtonPanel.Location = new System.Drawing.Point(0, 633);
            this.BottomButtonPanel.Name = "BottomButtonPanel";
            this.BottomButtonPanel.Size = new System.Drawing.Size(704, 108);
            this.BottomButtonPanel.TabIndex = 44;
            // 
            // TipTextLabel
            // 
            this.TipTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipTextLabel.Location = new System.Drawing.Point(91, 0);
            this.TipTextLabel.Name = "TipTextLabel";
            this.TipTextLabel.Size = new System.Drawing.Size(483, 23);
            this.TipTextLabel.TabIndex = 44;
            this.TipTextLabel.Text = "Click the chips rack to select amounts without typing.\r\n\r\n";
            // 
            // TipImage
            // 
            this.TipImage.BackgroundImage = global::CardCounter.Properties.Resources.Tip;
            this.TipImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TipImage.Location = new System.Drawing.Point(57, 0);
            this.TipImage.Name = "TipImage";
            this.TipImage.Size = new System.Drawing.Size(32, 32);
            this.TipImage.TabIndex = 43;
            this.TipImage.TabStop = false;
            // 
            // StoreInMemoryRadioButton
            // 
            this.StoreInMemoryRadioButton.AutoSize = true;
            this.StoreInMemoryRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.StoreInMemoryRadioButton.Checked = true;
            this.StoreInMemoryRadioButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreInMemoryRadioButton.Location = new System.Drawing.Point(57, 75);
            this.StoreInMemoryRadioButton.Name = "StoreInMemoryRadioButton";
            this.StoreInMemoryRadioButton.Size = new System.Drawing.Size(281, 27);
            this.StoreInMemoryRadioButton.TabIndex = 42;
            this.StoreInMemoryRadioButton.TabStop = true;
            this.StoreInMemoryRadioButton.Text = "Save for this session only.";
            this.StoreInMemoryRadioButton.UseVisualStyleBackColor = false;
            // 
            // SaveSettingsRadioButton
            // 
            this.SaveSettingsRadioButton.AutoSize = true;
            this.SaveSettingsRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveSettingsRadioButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsRadioButton.Location = new System.Drawing.Point(57, 46);
            this.SaveSettingsRadioButton.Name = "SaveSettingsRadioButton";
            this.SaveSettingsRadioButton.Size = new System.Drawing.Size(326, 27);
            this.SaveSettingsRadioButton.TabIndex = 41;
            this.SaveSettingsRadioButton.Text = "Save options on this computer.";
            this.SaveSettingsRadioButton.UseVisualStyleBackColor = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton.Location = new System.Drawing.Point(548, 64);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 36);
            this.CancelButton.TabIndex = 40;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            this.CancelButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CancelButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.Location = new System.Drawing.Point(402, 64);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(132, 36);
            this.SaveButton.TabIndex = 39;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            this.SaveButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SaveButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // TabHostControl
            // 
            this.TabHostControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TabHostControl.BackgroundImage")));
            this.TabHostControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabHostControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TabHostControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabHostControl.LeftMargin = 20;
            this.TabHostControl.Location = new System.Drawing.Point(0, 0);
            this.TabHostControl.Name = "TabHostControl";
            this.TabHostControl.Size = new System.Drawing.Size(704, 64);
            this.TabHostControl.TabHostParent = null;
            this.TabHostControl.TabIndex = 20;
            this.TabHostControl.TopMargin = 16;
            // 
            // SelectPlayersControl
            // 
            this.SelectPlayersControl.BackColor = System.Drawing.Color.Transparent;
            this.SelectPlayersControl.Location = new System.Drawing.Point(0, 80);
            this.SelectPlayersControl.Name = "SelectPlayersControl";
            this.SelectPlayersControl.Size = new System.Drawing.Size(704, 554);
            this.SelectPlayersControl.TabIndex = 46;
            this.SelectPlayersControl.Visible = false;
            // 
            // OptionsControl
            // 
            this.OptionsControl.BackColor = System.Drawing.Color.Transparent;
            this.OptionsControl.Location = new System.Drawing.Point(0, 80);
            this.OptionsControl.Name = "OptionsControl";
            this.OptionsControl.Size = new System.Drawing.Size(704, 554);
            this.OptionsControl.TabIndex = 45;
            this.OptionsControl.Visible = false;
            // 
            // OptionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 741);
            this.Controls.Add(this.TabHostControl);
            this.Controls.Add(this.BottomButtonPanel);
            this.Controls.Add(this.SelectPlayersControl);
            this.Controls.Add(this.OptionsControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(720, 780);
            this.MinimumSize = new System.Drawing.Size(720, 780);
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "House Rules / Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.BottomButtonPanel.ResumeLayout(false);
            this.BottomButtonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TipImage)).EndInit();
            this.ResumeLayout(false);

            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
