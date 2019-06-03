namespace CardCounter.UI.Controls
{
    partial class TableOptionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOptionsControl));
            this.DealButton = new System.Windows.Forms.Button();
            this.ShuffleButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.OffScreenTextBox = new System.Windows.Forms.TextBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.GameSpeedControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.SuspendLayout();
            // 
            // DealButton
            // 
            this.DealButton.BackColor = System.Drawing.Color.Transparent;
            this.DealButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.DealButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealButton.FlatAppearance.BorderSize = 0;
            this.DealButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DealButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DealButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DealButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DealButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DealButton.Location = new System.Drawing.Point(18, 45);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(76, 32);
            this.DealButton.TabIndex = 40;
            this.DealButton.Text = "Deal";
            this.ToolTip.SetToolTip(this.DealButton, "Deal the next hand.");
            this.DealButton.UseVisualStyleBackColor = false;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            this.DealButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.DealButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ShuffleButton
            // 
            this.ShuffleButton.BackColor = System.Drawing.Color.Transparent;
            this.ShuffleButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShuffleButton.FlatAppearance.BorderSize = 0;
            this.ShuffleButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ShuffleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShuffleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ShuffleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShuffleButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShuffleButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ShuffleButton.Location = new System.Drawing.Point(110, 45);
            this.ShuffleButton.Name = "ShuffleButton";
            this.ShuffleButton.Size = new System.Drawing.Size(76, 32);
            this.ShuffleButton.TabIndex = 42;
            this.ShuffleButton.Text = "Shuffle";
            this.ToolTip.SetToolTip(this.ShuffleButton, "Shuffle the cards and reset all counts.");
            this.ShuffleButton.UseVisualStyleBackColor = false;
            this.ShuffleButton.Click += new System.EventHandler(this.ShuffleButton_Click);
            this.ShuffleButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ShuffleButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.OptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.OptionsButton.Location = new System.Drawing.Point(202, 45);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(96, 32);
            this.OptionsButton.TabIndex = 45;
            this.OptionsButton.Text = "Options";
            this.ToolTip.SetToolTip(this.OptionsButton, "Choose players or change the game options.");
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            this.OptionsButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.OptionsButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // FirstButton
            // 
            this.FirstButton.BackColor = System.Drawing.Color.Transparent;
            this.FirstButton.BackgroundImage = global::CardCounter.Properties.Resources.FirstButtonGray;
            this.FirstButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FirstButton.FlatAppearance.BorderSize = 0;
            this.FirstButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.FirstButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.FirstButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.FirstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.FirstButton.Location = new System.Drawing.Point(20, 85);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(32, 32);
            this.FirstButton.TabIndex = 46;
            this.ToolTip.SetToolTip(this.FirstButton, "Move to the first hand.");
            this.FirstButton.UseVisualStyleBackColor = false;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            this.FirstButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.FirstButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PreviousButton
            // 
            this.PreviousButton.BackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.BackgroundImage = global::CardCounter.Properties.Resources.BackButtonGray;
            this.PreviousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreviousButton.FlatAppearance.BorderSize = 0;
            this.PreviousButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PreviousButton.Location = new System.Drawing.Point(69, 85);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(32, 32);
            this.PreviousButton.TabIndex = 47;
            this.ToolTip.SetToolTip(this.PreviousButton, "Move to the previous hand.");
            this.PreviousButton.UseVisualStyleBackColor = false;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButtonButton_Click);
            this.PreviousButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PreviousButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.Transparent;
            this.NextButton.BackgroundImage = global::CardCounter.Properties.Resources.NextButtonGray;
            this.NextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.NextButton.Location = new System.Drawing.Point(216, 85);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(32, 32);
            this.NextButton.TabIndex = 48;
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.NextButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.NextButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // LastButton
            // 
            this.LastButton.BackColor = System.Drawing.Color.Transparent;
            this.LastButton.BackgroundImage = global::CardCounter.Properties.Resources.LastButtonGray;
            this.LastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LastButton.FlatAppearance.BorderSize = 0;
            this.LastButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.LastButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LastButton.Location = new System.Drawing.Point(265, 85);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(32, 32);
            this.LastButton.TabIndex = 49;
            this.LastButton.UseVisualStyleBackColor = false;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            this.LastButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.LastButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // OffScreenTextBox
            // 
            this.OffScreenTextBox.Location = new System.Drawing.Point(-100, -100);
            this.OffScreenTextBox.Name = "OffScreenTextBox";
            this.OffScreenTextBox.Size = new System.Drawing.Size(100, 20);
            this.OffScreenTextBox.TabIndex = 50;
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.Color.Transparent;
            this.StartStopButton.BackgroundImage = global::CardCounter.Properties.Resources.PlayGray;
            this.StartStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartStopButton.FlatAppearance.BorderSize = 0;
            this.StartStopButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.StartStopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartStopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStopButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStopButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StartStopButton.Location = new System.Drawing.Point(118, 85);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(32, 32);
            this.StartStopButton.TabIndex = 51;
            this.ToolTip.SetToolTip(this.StartStopButton, "Stop Dealing");
            this.StartStopButton.UseVisualStyleBackColor = false;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            this.StartStopButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.StartStopButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PauseButton
            // 
            this.PauseButton.BackColor = System.Drawing.Color.Transparent;
            this.PauseButton.BackgroundImage = global::CardCounter.Properties.Resources.PauseGray;
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PauseButton.FlatAppearance.BorderSize = 0;
            this.PauseButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PauseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PauseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PauseButton.Location = new System.Drawing.Point(167, 85);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(32, 32);
            this.PauseButton.TabIndex = 52;
            this.PauseButton.UseVisualStyleBackColor = false;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            this.PauseButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.PauseButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // GameSpeedControl
            // 
            this.GameSpeedControl.BackColor = System.Drawing.Color.Transparent;
            this.GameSpeedControl.ComboBoxLeftMargin = 1;
            this.GameSpeedControl.ComboBoxText = "";
            this.GameSpeedControl.ComoboBoxFont = null;
            this.GameSpeedControl.Editable = true;
            this.GameSpeedControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameSpeedControl.LabelBottomMargin = 0;
            this.GameSpeedControl.LabelColor = System.Drawing.Color.White;
            this.GameSpeedControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameSpeedControl.LabelText = "Game Speed:";
            this.GameSpeedControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GameSpeedControl.LabelTopMargin = 0;
            this.GameSpeedControl.LabelWidth = 120;
            this.GameSpeedControl.List = null;
            this.GameSpeedControl.Location = new System.Drawing.Point(18, 11);
            this.GameSpeedControl.Name = "GameSpeedControl";
            this.GameSpeedControl.SelectedIndex = -1;
            this.GameSpeedControl.SelectedIndexListener = null;
            this.GameSpeedControl.Size = new System.Drawing.Size(280, 26);
            this.GameSpeedControl.Sorted = false;
            this.GameSpeedControl.Source = null;
            this.GameSpeedControl.TabIndex = 41;
            // 
            // TableOptionsControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartStopButton);
            this.Controls.Add(this.OffScreenTextBox);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.ShuffleButton);
            this.Controls.Add(this.GameSpeedControl);
            this.Controls.Add(this.DealButton);
            this.DoubleBuffered = true;
            this.Name = "TableOptionsControl";
            this.Size = new System.Drawing.Size(320, 128);
            this.Load += new System.EventHandler(this.TableOptionsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DealButton;
        private DataJuggler.Win.Controls.LabelComboBoxControl GameSpeedControl;
        private System.Windows.Forms.Button ShuffleButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.TextBox OffScreenTextBox;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
