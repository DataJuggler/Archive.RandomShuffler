namespace CardCounter.UI.Controls
{
    partial class CardCounterControl
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
            this.SystemControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.CountLabel = new System.Windows.Forms.Label();
            this.QuizButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.ShowCountCheckbox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.QuizModeCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.QuizResultsLabel = new System.Windows.Forms.Label();
            this.LeftMarginPanel = new System.Windows.Forms.Panel();
            this.RightMarginPanel = new System.Windows.Forms.Panel();
            this.TopMarginPanel = new System.Windows.Forms.Panel();
            this.BottomMarginPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SystemControl
            // 
            this.SystemControl.BackColor = System.Drawing.Color.Transparent;
            this.SystemControl.ComboBoxLeftMargin = 1;
            this.SystemControl.ComboBoxText = "";
            this.SystemControl.ComoboBoxFont = null;
            this.SystemControl.Editable = true;
            this.SystemControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemControl.HideLabel = false;
            this.SystemControl.LabelBottomMargin = 0;
            this.SystemControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SystemControl.LabelFont = null;
            this.SystemControl.LabelText = "System:";
            this.SystemControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SystemControl.LabelTopMargin = 4;
            this.SystemControl.LabelWidth = 100;
            this.SystemControl.List = null;
            this.SystemControl.Location = new System.Drawing.Point(12, 14);
            this.SystemControl.Name = "SystemControl";
            this.SystemControl.SelectedIndex = -1;
            this.SystemControl.SelectedIndexListener = null;
            this.SystemControl.Size = new System.Drawing.Size(288, 28);
            this.SystemControl.Sorted = true;
            this.SystemControl.Source = null;
            this.SystemControl.TabIndex = 0;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountLabel.Location = new System.Drawing.Point(32, 56);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(37, 38);
            this.CountLabel.TabIndex = 1;
            this.CountLabel.Text = "0";
            // 
            // QuizButton
            // 
            this.QuizButton.BackColor = System.Drawing.Color.Transparent;
            this.QuizButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.QuizButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuizButton.FlatAppearance.BorderSize = 0;
            this.QuizButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.QuizButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.QuizButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.QuizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuizButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.QuizButton.Location = new System.Drawing.Point(224, 110);
            this.QuizButton.Name = "QuizButton";
            this.QuizButton.Size = new System.Drawing.Size(76, 32);
            this.QuizButton.TabIndex = 44;
            this.QuizButton.Text = "Quiz";
            this.QuizButton.UseVisualStyleBackColor = false;
            this.QuizButton.Visible = false;
            this.QuizButton.Click += new System.EventHandler(this.QuizButton_Click);
            this.QuizButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.QuizButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.ShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ShowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ShowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ShowButton.Location = new System.Drawing.Point(16, 110);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(76, 32);
            this.ShowButton.TabIndex = 43;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Visible = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            this.ShowButton.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ShowButton.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // ShowCountCheckbox
            // 
            this.ShowCountCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ShowCountCheckbox.CheckBoxVerticalOffSet = 4;
            this.ShowCountCheckbox.CheckChangedListener = null;
            this.ShowCountCheckbox.Checked = true;
            this.ShowCountCheckbox.Editable = false;
            this.ShowCountCheckbox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCountCheckbox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ShowCountCheckbox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCountCheckbox.LabelText = "Show Count:";
            this.ShowCountCheckbox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowCountCheckbox.LabelWidth = 140;
            this.ShowCountCheckbox.Location = new System.Drawing.Point(102, 45);
            this.ShowCountCheckbox.Name = "ShowCountCheckbox";
            this.ShowCountCheckbox.Size = new System.Drawing.Size(166, 28);
            this.ShowCountCheckbox.TabIndex = 45;
            // 
            // QuizModeCheckBox
            // 
            this.QuizModeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.QuizModeCheckBox.CheckBoxVerticalOffSet = 4;
            this.QuizModeCheckBox.CheckChangedListener = null;
            this.QuizModeCheckBox.Checked = false;
            this.QuizModeCheckBox.Editable = false;
            this.QuizModeCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizModeCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.QuizModeCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizModeCheckBox.LabelText = "Quiz Mode:";
            this.QuizModeCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.QuizModeCheckBox.LabelWidth = 140;
            this.QuizModeCheckBox.Location = new System.Drawing.Point(102, 71);
            this.QuizModeCheckBox.Name = "QuizModeCheckBox";
            this.QuizModeCheckBox.Size = new System.Drawing.Size(166, 28);
            this.QuizModeCheckBox.TabIndex = 46;
            // 
            // QuizResultsLabel
            // 
            this.QuizResultsLabel.Location = new System.Drawing.Point(94, 110);
            this.QuizResultsLabel.Name = "QuizResultsLabel";
            this.QuizResultsLabel.Size = new System.Drawing.Size(134, 32);
            this.QuizResultsLabel.TabIndex = 47;
            this.QuizResultsLabel.Text = "0 out of 0";
            this.QuizResultsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.QuizResultsLabel.Visible = false;
            // 
            // LeftMarginPanel
            // 
            this.LeftMarginPanel.BackColor = System.Drawing.Color.White;
            this.LeftMarginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMarginPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMarginPanel.Name = "LeftMarginPanel";
            this.LeftMarginPanel.Size = new System.Drawing.Size(1, 160);
            this.LeftMarginPanel.TabIndex = 48;
            // 
            // RightMarginPanel
            // 
            this.RightMarginPanel.BackColor = System.Drawing.Color.White;
            this.RightMarginPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightMarginPanel.Location = new System.Drawing.Point(319, 0);
            this.RightMarginPanel.Name = "RightMarginPanel";
            this.RightMarginPanel.Size = new System.Drawing.Size(1, 160);
            this.RightMarginPanel.TabIndex = 49;
            // 
            // TopMarginPanel
            // 
            this.TopMarginPanel.BackColor = System.Drawing.Color.White;
            this.TopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMarginPanel.Location = new System.Drawing.Point(1, 0);
            this.TopMarginPanel.Name = "TopMarginPanel";
            this.TopMarginPanel.Size = new System.Drawing.Size(318, 1);
            this.TopMarginPanel.TabIndex = 50;
            // 
            // BottomMarginPanel
            // 
            this.BottomMarginPanel.BackColor = System.Drawing.Color.White;
            this.BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMarginPanel.Location = new System.Drawing.Point(1, 159);
            this.BottomMarginPanel.Name = "BottomMarginPanel";
            this.BottomMarginPanel.Size = new System.Drawing.Size(318, 1);
            this.BottomMarginPanel.TabIndex = 51;
            // 
            // CardCounterControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.BottomMarginPanel);
            this.Controls.Add(this.TopMarginPanel);
            this.Controls.Add(this.RightMarginPanel);
            this.Controls.Add(this.LeftMarginPanel);
            this.Controls.Add(this.QuizResultsLabel);
            this.Controls.Add(this.QuizModeCheckBox);
            this.Controls.Add(this.ShowCountCheckbox);
            this.Controls.Add(this.QuizButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.CountLabel);
            this.Controls.Add(this.SystemControl);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Name = "CardCounterControl";
            this.Size = new System.Drawing.Size(320, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataJuggler.Win.Controls.LabelComboBoxControl SystemControl;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button QuizButton;
        private System.Windows.Forms.Button ShowButton;
        private DataJuggler.Win.Controls.LabelCheckBoxControl ShowCountCheckbox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl QuizModeCheckBox;
        private System.Windows.Forms.Label QuizResultsLabel;
        private System.Windows.Forms.Panel LeftMarginPanel;
        private System.Windows.Forms.Panel RightMarginPanel;
        private System.Windows.Forms.Panel TopMarginPanel;
        private System.Windows.Forms.Panel BottomMarginPanel;
    }
}
