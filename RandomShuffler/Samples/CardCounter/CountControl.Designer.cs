namespace CardCounter
{
    partial class CountControl
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
            this.CountingSystemControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.labelCheckBoxControl1 = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.CountLabel = new System.Windows.Forms.Label();
            this.GuessCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.GuessCountTextBox = new System.Windows.Forms.TextBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.ResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CountingSystemControl
            // 
            this.CountingSystemControl.BackColor = System.Drawing.Color.Transparent;
            this.CountingSystemControl.ComboBoxLeftMargin = 1;
            this.CountingSystemControl.ComboBoxText = "";
            this.CountingSystemControl.ComoboBoxFont = null;
            this.CountingSystemControl.Editable = true;
            this.CountingSystemControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountingSystemControl.LabelBottomMargin = 0;
            this.CountingSystemControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.CountingSystemControl.LabelFont = null;
            this.CountingSystemControl.LabelText = "System:";
            this.CountingSystemControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CountingSystemControl.LabelTopMargin = 0;
            this.CountingSystemControl.LabelWidth = 100;
            this.CountingSystemControl.List = null;
            this.CountingSystemControl.Location = new System.Drawing.Point(20, 12);
            this.CountingSystemControl.Name = "CountingSystemControl";
            this.CountingSystemControl.SelectedIndex = -1;
            this.CountingSystemControl.SelectedIndexListener = null;
            this.CountingSystemControl.Size = new System.Drawing.Size(360, 28);
            this.CountingSystemControl.Sorted = true;
            this.CountingSystemControl.Source = null;
            this.CountingSystemControl.TabIndex = 0;
            // 
            // labelCheckBoxControl1
            // 
            this.labelCheckBoxControl1.BackColor = System.Drawing.Color.Transparent;
            this.labelCheckBoxControl1.CheckBoxVerticalOffSet = 4;
            this.labelCheckBoxControl1.CheckChangedListener = null;
            this.labelCheckBoxControl1.Checked = false;
            this.labelCheckBoxControl1.Editable = false;
            this.labelCheckBoxControl1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckBoxControl1.LabelColor = System.Drawing.SystemColors.ControlText;
            this.labelCheckBoxControl1.LabelFont = null;
            this.labelCheckBoxControl1.LabelText = "Show:";
            this.labelCheckBoxControl1.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelCheckBoxControl1.LabelWidth = 100;
            this.labelCheckBoxControl1.Location = new System.Drawing.Point(20, 48);
            this.labelCheckBoxControl1.Name = "labelCheckBoxControl1";
            this.labelCheckBoxControl1.Size = new System.Drawing.Size(128, 28);
            this.labelCheckBoxControl1.TabIndex = 1;
            // 
            // CountLabel
            // 
            this.CountLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(44, 80);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(100, 44);
            this.CountLabel.TabIndex = 2;
            this.CountLabel.Text = "0";
            this.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GuessCheckBox
            // 
            this.GuessCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.GuessCheckBox.CheckBoxVerticalOffSet = 4;
            this.GuessCheckBox.CheckChangedListener = null;
            this.GuessCheckBox.Checked = false;
            this.GuessCheckBox.Editable = false;
            this.GuessCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessCheckBox.LabelColor = System.Drawing.SystemColors.ControlText;
            this.GuessCheckBox.LabelFont = null;
            this.GuessCheckBox.LabelText = "Quiz:";
            this.GuessCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuessCheckBox.LabelWidth = 80;
            this.GuessCheckBox.Location = new System.Drawing.Point(156, 48);
            this.GuessCheckBox.Name = "GuessCheckBox";
            this.GuessCheckBox.Size = new System.Drawing.Size(100, 28);
            this.GuessCheckBox.TabIndex = 3;
            // 
            // GuessCountTextBox
            // 
            this.GuessCountTextBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessCountTextBox.Location = new System.Drawing.Point(260, 47);
            this.GuessCountTextBox.Name = "GuessCountTextBox";
            this.GuessCountTextBox.Size = new System.Drawing.Size(120, 31);
            this.GuessCountTextBox.TabIndex = 4;
            this.GuessCountTextBox.Visible = false;
            // 
            // GuessButton
            // 
            this.GuessButton.BackColor = System.Drawing.Color.Transparent;
            this.GuessButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.GuessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuessButton.FlatAppearance.BorderSize = 0;
            this.GuessButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.GuessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GuessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GuessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuessButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.GuessButton.Location = new System.Drawing.Point(284, 88);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(96, 32);
            this.GuessButton.TabIndex = 46;
            this.GuessButton.Text = "Guess";
            this.GuessButton.UseVisualStyleBackColor = false;
            this.GuessButton.Visible = false;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            this.GuessButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.GuessButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ResultsLabel
            // 
            this.ResultsLabel.Location = new System.Drawing.Point(152, 120);
            this.ResultsLabel.Name = "ResultsLabel";
            this.ResultsLabel.Size = new System.Drawing.Size(228, 28);
            this.ResultsLabel.TabIndex = 47;
            this.ResultsLabel.Text = "0 correct of 0 guesses";
            this.ResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultsLabel.Visible = false;
            // 
            // CountControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ResultsLabel);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.GuessCountTextBox);
            this.Controls.Add(this.GuessCheckBox);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.labelCheckBoxControl1);
            this.Controls.Add(this.CountingSystemControl);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CountControl";
            this.Size = new System.Drawing.Size(400, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataJuggler.Win.Controls.LabelComboBoxControl CountingSystemControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl labelCheckBoxControl1;
        private System.Windows.Forms.Label CountLabel;
        private DataJuggler.Win.Controls.LabelCheckBoxControl GuessCheckBox;
        private System.Windows.Forms.TextBox GuessCountTextBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label ResultsLabel;
    }
}
