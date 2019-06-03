

#region using statements


#endregion

namespace CardCounter.UI.Controls
{

    #region class PlayerEditorControl
    /// <summary>
    /// This class is the Designer for the PlayerEditorControl
    /// </summary>
    partial class PlayerEditorControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private DataJuggler.Win.Controls.LabelTextBoxControl NameControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl IsComputerPlayerCheckBox;
        private DataJuggler.Win.Controls.LabelCheckBoxControl SeatNumberCheckBox;
        private DataJuggler.Win.Controls.LabelComboBoxControl CountingSystemControl;
        private System.Windows.Forms.Button ChipSelectorButton;
        private DataJuggler.Win.Controls.LabelTextBoxControl ChipsControl;
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
            this.NameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.IsComputerPlayerCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.SeatNumberCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.CountingSystemControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.ChipsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.HelpButton = new System.Windows.Forms.Button();
            this.ChipSelectorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameControl
            // 
            this.NameControl.BackColor = System.Drawing.Color.Transparent;
            this.NameControl.BottomMargin = 0;
            this.NameControl.Editable = true;
            this.NameControl.Encrypted = false;
            this.NameControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameControl.LabelBottomMargin = 0;
            this.NameControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.NameControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameControl.LabelText = "Name:";
            this.NameControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NameControl.LabelTopMargin = 4;
            this.NameControl.LabelWidth = 100;
            this.NameControl.Location = new System.Drawing.Point(16, 31);
            this.NameControl.MultiLine = false;
            this.NameControl.Name = "NameControl";
            this.NameControl.OnTextChangedListener = null;
            this.NameControl.PasswordMode = false;
            this.NameControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NameControl.Size = new System.Drawing.Size(385, 32);
            this.NameControl.TabIndex = 2;
            this.NameControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameControl.TextBoxBottomMargin = 0;
            this.NameControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.NameControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.NameControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameControl.TextBoxTopMargin = 4;
            // 
            // IsComputerPlayerCheckBox
            // 
            this.IsComputerPlayerCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.IsComputerPlayerCheckBox.CheckBoxVerticalOffSet = 4;
            this.IsComputerPlayerCheckBox.CheckChangedListener = null;
            this.IsComputerPlayerCheckBox.Checked = false;
            this.IsComputerPlayerCheckBox.Editable = true;
            this.IsComputerPlayerCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsComputerPlayerCheckBox.LabelColor = System.Drawing.SystemColors.ControlText;
            this.IsComputerPlayerCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsComputerPlayerCheckBox.LabelText = "Computer Player:";
            this.IsComputerPlayerCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IsComputerPlayerCheckBox.LabelWidth = 200;
            this.IsComputerPlayerCheckBox.Location = new System.Drawing.Point(465, 4);
            this.IsComputerPlayerCheckBox.Name = "IsComputerPlayerCheckBox";
            this.IsComputerPlayerCheckBox.Size = new System.Drawing.Size(220, 24);
            this.IsComputerPlayerCheckBox.TabIndex = 4;
            // 
            // SeatNumberCheckBox
            // 
            this.SeatNumberCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.SeatNumberCheckBox.CheckBoxVerticalOffSet = 4;
            this.SeatNumberCheckBox.CheckChangedListener = null;
            this.SeatNumberCheckBox.Checked = false;
            this.SeatNumberCheckBox.Editable = true;
            this.SeatNumberCheckBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNumberCheckBox.LabelColor = System.Drawing.SystemColors.ControlText;
            this.SeatNumberCheckBox.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNumberCheckBox.LabelText = "Seat 1:";
            this.SeatNumberCheckBox.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SeatNumberCheckBox.LabelWidth = 80;
            this.SeatNumberCheckBox.Location = new System.Drawing.Point(16, 2);
            this.SeatNumberCheckBox.Name = "SeatNumberCheckBox";
            this.SeatNumberCheckBox.Size = new System.Drawing.Size(148, 24);
            this.SeatNumberCheckBox.TabIndex = 0;
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
            this.CountingSystemControl.LabelText = null;
            this.CountingSystemControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CountingSystemControl.LabelTopMargin = 0;
            this.CountingSystemControl.LabelWidth = 0;
            this.CountingSystemControl.List = null;
            this.CountingSystemControl.Location = new System.Drawing.Point(116, 0);
            this.CountingSystemControl.Name = "CountingSystemControl";
            this.CountingSystemControl.SelectedIndex = -1;
            this.CountingSystemControl.SelectedIndexListener = null;
            this.CountingSystemControl.Size = new System.Drawing.Size(285, 28);
            this.CountingSystemControl.Sorted = true;
            this.CountingSystemControl.Source = null;
            this.CountingSystemControl.TabIndex = 1;
            // 
            // ChipsControl
            // 
            this.ChipsControl.BackColor = System.Drawing.Color.Transparent;
            this.ChipsControl.BottomMargin = 0;
            this.ChipsControl.Editable = true;
            this.ChipsControl.Encrypted = false;
            this.ChipsControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsControl.LabelBottomMargin = 0;
            this.ChipsControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.ChipsControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsControl.LabelText = "Chips:";
            this.ChipsControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChipsControl.LabelTopMargin = 4;
            this.ChipsControl.LabelWidth = 100;
            this.ChipsControl.Location = new System.Drawing.Point(16, 66);
            this.ChipsControl.MultiLine = false;
            this.ChipsControl.Name = "ChipsControl";
            this.ChipsControl.OnTextChangedListener = null;
            this.ChipsControl.PasswordMode = false;
            this.ChipsControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ChipsControl.Size = new System.Drawing.Size(385, 32);
            this.ChipsControl.TabIndex = 3;
            this.ChipsControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChipsControl.TextBoxBottomMargin = 0;
            this.ChipsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ChipsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ChipsControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipsControl.TextBoxTopMargin = 4;
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Transparent;
            this.HelpButton.BackgroundImage = global::CardCounter.Properties.Resources.HelpSmall;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HelpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton.Location = new System.Drawing.Point(407, 0);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(32, 32);
            this.HelpButton.TabIndex = 49;
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            this.HelpButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.HelpButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ChipSelectorButton
            // 
            this.ChipSelectorButton.BackColor = System.Drawing.Color.Transparent;
            this.ChipSelectorButton.BackgroundImage = global::CardCounter.Properties.Resources.Chip_Rack;
            this.ChipSelectorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChipSelectorButton.FlatAppearance.BorderSize = 0;
            this.ChipSelectorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ChipSelectorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ChipSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChipSelectorButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChipSelectorButton.Location = new System.Drawing.Point(408, 58);
            this.ChipSelectorButton.Name = "ChipSelectorButton";
            this.ChipSelectorButton.Size = new System.Drawing.Size(70, 40);
            this.ChipSelectorButton.TabIndex = 48;
            this.ChipSelectorButton.UseVisualStyleBackColor = false;
            this.ChipSelectorButton.Click += new System.EventHandler(this.ChipSelectorButton_Click);
            this.ChipSelectorButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ChipSelectorButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // PlayerEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.ChipsControl);
            this.Controls.Add(this.ChipSelectorButton);
            this.Controls.Add(this.CountingSystemControl);
            this.Controls.Add(this.NameControl);
            this.Controls.Add(this.IsComputerPlayerCheckBox);
            this.Controls.Add(this.SeatNumberCheckBox);
            this.DoubleBuffered = true;
            this.Name = "PlayerEditorControl";
            this.Size = new System.Drawing.Size(704, 100);
            this.ResumeLayout(false);

            }
            #endregion

            private System.Windows.Forms.Button HelpButton;
            
        #endregion
        
    }
    #endregion

}
