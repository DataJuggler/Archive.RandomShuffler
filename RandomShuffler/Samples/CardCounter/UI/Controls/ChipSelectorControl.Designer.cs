

#region using statements


#endregion

namespace CardCounter.UI.Controls
{

    #region class ChipSelectorControl
    /// <summary>
    /// This is the Designer File for the ChipSelectorControl
    /// </summary>
    partial class ChipSelectorControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button RedChipButton;
        private System.Windows.Forms.Button WhiteChipButton;
        private System.Windows.Forms.Button GreenChipButton;
        private System.Windows.Forms.Button PurpleChipButton;
        private System.Windows.Forms.Button GoldChipButton;
        private System.Windows.Forms.TextBox AmountSelectedTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CancelSelectButton;
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
            this.GoldChipButton = new System.Windows.Forms.Button();
            this.PurpleChipButton = new System.Windows.Forms.Button();
            this.GreenChipButton = new System.Windows.Forms.Button();
            this.WhiteChipButton = new System.Windows.Forms.Button();
            this.RedChipButton = new System.Windows.Forms.Button();
            this.AmountSelectedTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CancelSelectButton = new System.Windows.Forms.Button();
            this.BlackChipButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoldChipButton
            // 
            this.GoldChipButton.BackColor = System.Drawing.Color.Transparent;
            this.GoldChipButton.BackgroundImage = global::CardCounter.Properties.Resources.GoldNoPlus;
            this.GoldChipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GoldChipButton.FlatAppearance.BorderSize = 0;
            this.GoldChipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GoldChipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GoldChipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoldChipButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoldChipButton.Location = new System.Drawing.Point(290, 174);
            this.GoldChipButton.Name = "GoldChipButton";
            this.GoldChipButton.Size = new System.Drawing.Size(128, 128);
            this.GoldChipButton.TabIndex = 5;
            this.GoldChipButton.Tag = "1000";
            this.GoldChipButton.Text = "1K";
            this.GoldChipButton.UseVisualStyleBackColor = false;
            this.GoldChipButton.Click += new System.EventHandler(this.GoldChipButton_Click);
            this.GoldChipButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.GoldChipButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PurpleChipButton
            // 
            this.PurpleChipButton.BackColor = System.Drawing.Color.Transparent;
            this.PurpleChipButton.BackgroundImage = global::CardCounter.Properties.Resources.PurpleChipNoPlus;
            this.PurpleChipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PurpleChipButton.FlatAppearance.BorderSize = 0;
            this.PurpleChipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PurpleChipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PurpleChipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PurpleChipButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurpleChipButton.Location = new System.Drawing.Point(152, 174);
            this.PurpleChipButton.Name = "PurpleChipButton";
            this.PurpleChipButton.Size = new System.Drawing.Size(128, 128);
            this.PurpleChipButton.TabIndex = 4;
            this.PurpleChipButton.Tag = "500";
            this.PurpleChipButton.Text = "500";
            this.PurpleChipButton.UseVisualStyleBackColor = false;
            this.PurpleChipButton.Click += new System.EventHandler(this.PurpleChipButton_Click);
            this.PurpleChipButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PurpleChipButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // GreenChipButton
            // 
            this.GreenChipButton.BackColor = System.Drawing.Color.Transparent;
            this.GreenChipButton.BackgroundImage = global::CardCounter.Properties.Resources.GreenChipNoPlus;
            this.GreenChipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GreenChipButton.FlatAppearance.BorderSize = 0;
            this.GreenChipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GreenChipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GreenChipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenChipButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenChipButton.Location = new System.Drawing.Point(290, 18);
            this.GreenChipButton.Name = "GreenChipButton";
            this.GreenChipButton.Size = new System.Drawing.Size(128, 128);
            this.GreenChipButton.TabIndex = 2;
            this.GreenChipButton.Tag = "25";
            this.GreenChipButton.Text = "25";
            this.GreenChipButton.UseVisualStyleBackColor = false;
            this.GreenChipButton.Click += new System.EventHandler(this.GreenChipButton_Click);
            this.GreenChipButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.GreenChipButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // WhiteChipButton
            // 
            this.WhiteChipButton.BackColor = System.Drawing.Color.Transparent;
            this.WhiteChipButton.BackgroundImage = global::CardCounter.Properties.Resources.WhiteChipNoPlus;
            this.WhiteChipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WhiteChipButton.FlatAppearance.BorderSize = 0;
            this.WhiteChipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.WhiteChipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.WhiteChipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WhiteChipButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteChipButton.Location = new System.Drawing.Point(14, 18);
            this.WhiteChipButton.Name = "WhiteChipButton";
            this.WhiteChipButton.Size = new System.Drawing.Size(128, 128);
            this.WhiteChipButton.TabIndex = 1;
            this.WhiteChipButton.Tag = "1";
            this.WhiteChipButton.Text = "1";
            this.WhiteChipButton.UseVisualStyleBackColor = false;
            this.WhiteChipButton.Click += new System.EventHandler(this.WhiteChipButton_Click);
            this.WhiteChipButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.WhiteChipButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // RedChipButton
            // 
            this.RedChipButton.BackColor = System.Drawing.Color.Transparent;
            this.RedChipButton.BackgroundImage = global::CardCounter.Properties.Resources.RedChipNoPlus;
            this.RedChipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedChipButton.FlatAppearance.BorderSize = 0;
            this.RedChipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RedChipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RedChipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedChipButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedChipButton.Location = new System.Drawing.Point(152, 18);
            this.RedChipButton.Name = "RedChipButton";
            this.RedChipButton.Size = new System.Drawing.Size(128, 128);
            this.RedChipButton.TabIndex = 0;
            this.RedChipButton.Tag = "5";
            this.RedChipButton.Text = "5";
            this.RedChipButton.UseVisualStyleBackColor = false;
            this.RedChipButton.Click += new System.EventHandler(this.RedChipButton_Click);
            this.RedChipButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.RedChipButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // AmountSelectedTextBox
            // 
            this.AmountSelectedTextBox.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountSelectedTextBox.Location = new System.Drawing.Point(441, 57);
            this.AmountSelectedTextBox.Name = "AmountSelectedTextBox";
            this.AmountSelectedTextBox.Size = new System.Drawing.Size(256, 46);
            this.AmountSelectedTextBox.TabIndex = 6;
            this.AmountSelectedTextBox.Text = "1,000,000";
            this.AmountSelectedTextBox.Leave += new System.EventHandler(this.AmountSelectedTextBox_Leave);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.ClearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ClearButton.Location = new System.Drawing.Point(577, 110);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(120, 36);
            this.ClearButton.TabIndex = 40;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ClearButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // CancelSelectButton
            // 
            this.CancelSelectButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelSelectButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.CancelSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelSelectButton.FlatAppearance.BorderSize = 0;
            this.CancelSelectButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.CancelSelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CancelSelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CancelSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelSelectButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelSelectButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CancelSelectButton.Location = new System.Drawing.Point(577, 270);
            this.CancelSelectButton.Name = "CancelSelectButton";
            this.CancelSelectButton.Size = new System.Drawing.Size(120, 36);
            this.CancelSelectButton.TabIndex = 42;
            this.CancelSelectButton.Text = "Cancel";
            this.CancelSelectButton.UseVisualStyleBackColor = false;
            this.CancelSelectButton.Click += new System.EventHandler(this.CancelSelectButton_Click);
            this.CancelSelectButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CancelSelectButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // BlackChipButton
            // 
            this.BlackChipButton.BackColor = System.Drawing.Color.Transparent;
            this.BlackChipButton.BackgroundImage = global::CardCounter.Properties.Resources.BlackChipNoPlus;
            this.BlackChipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BlackChipButton.FlatAppearance.BorderSize = 0;
            this.BlackChipButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BlackChipButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BlackChipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlackChipButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackChipButton.Location = new System.Drawing.Point(14, 174);
            this.BlackChipButton.Name = "BlackChipButton";
            this.BlackChipButton.Size = new System.Drawing.Size(128, 128);
            this.BlackChipButton.TabIndex = 3;
            this.BlackChipButton.Tag = "100";
            this.BlackChipButton.Text = "100";
            this.BlackChipButton.UseVisualStyleBackColor = false;
            this.BlackChipButton.Click += new System.EventHandler(this.BlackChipButton_Click);
            this.BlackChipButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.BlackChipButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.SelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectButton.FlatAppearance.BorderSize = 0;
            this.SelectButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SelectButton.Location = new System.Drawing.Point(441, 270);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(120, 36);
            this.SelectButton.TabIndex = 41;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            this.SelectButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.SelectButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ChipSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.CancelSelectButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AmountSelectedTextBox);
            this.Controls.Add(this.GoldChipButton);
            this.Controls.Add(this.PurpleChipButton);
            this.Controls.Add(this.BlackChipButton);
            this.Controls.Add(this.GreenChipButton);
            this.Controls.Add(this.WhiteChipButton);
            this.Controls.Add(this.RedChipButton);
            this.Name = "ChipSelectorControl";
            this.Size = new System.Drawing.Size(720, 320);
            this.Load += new System.EventHandler(this.ChipSelectorControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }
        #endregion

        #endregion

        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button BlackChipButton;
    }
    #endregion

}
