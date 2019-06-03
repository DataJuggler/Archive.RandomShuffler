namespace PickADoorGame
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartSimulationButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.DividerPanel = new System.Windows.Forms.Panel();
            this.AlwaysSwapLabel = new System.Windows.Forms.Label();
            this.SwapWrongValueLabel = new System.Windows.Forms.Label();
            this.SwapCorrectValueLabel = new System.Windows.Forms.Label();
            this.WrongGuessLabel2 = new System.Windows.Forms.Label();
            this.CorrectGuessLabel2 = new System.Windows.Forms.Label();
            this.DontSwapLabel = new System.Windows.Forms.Label();
            this.DoNotSwapWrongValueLabel = new System.Windows.Forms.Label();
            this.DoNotSwapCorrectValueLabel = new System.Windows.Forms.Label();
            this.WrongGuessLabel = new System.Windows.Forms.Label();
            this.CorrectGuessLabel = new System.Windows.Forms.Label();
            this.SimulationsControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.SelectDoorNumberControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.InitializingLabel = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartSimulationButton
            // 
            this.StartSimulationButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartSimulationButton.Location = new System.Drawing.Point(462, 175);
            this.StartSimulationButton.Name = "StartSimulationButton";
            this.StartSimulationButton.Size = new System.Drawing.Size(80, 32);
            this.StartSimulationButton.TabIndex = 1;
            this.StartSimulationButton.Text = "Start";
            this.StartSimulationButton.UseVisualStyleBackColor = true;
            this.StartSimulationButton.Click += new System.EventHandler(this.StartSimulationButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(550, 175);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(80, 32);
            this.DoneButton.TabIndex = 14;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.DividerPanel);
            this.TopPanel.Controls.Add(this.AlwaysSwapLabel);
            this.TopPanel.Controls.Add(this.SwapWrongValueLabel);
            this.TopPanel.Controls.Add(this.SwapCorrectValueLabel);
            this.TopPanel.Controls.Add(this.WrongGuessLabel2);
            this.TopPanel.Controls.Add(this.CorrectGuessLabel2);
            this.TopPanel.Controls.Add(this.DontSwapLabel);
            this.TopPanel.Controls.Add(this.DoNotSwapWrongValueLabel);
            this.TopPanel.Controls.Add(this.DoNotSwapCorrectValueLabel);
            this.TopPanel.Controls.Add(this.WrongGuessLabel);
            this.TopPanel.Controls.Add(this.CorrectGuessLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(772, 160);
            this.TopPanel.TabIndex = 15;
            // 
            // DividerPanel
            // 
            this.DividerPanel.BackColor = System.Drawing.Color.Black;
            this.DividerPanel.Location = new System.Drawing.Point(360, -130);
            this.DividerPanel.Name = "DividerPanel";
            this.DividerPanel.Size = new System.Drawing.Size(4, 420);
            this.DividerPanel.TabIndex = 26;
            // 
            // AlwaysSwapLabel
            // 
            this.AlwaysSwapLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlwaysSwapLabel.Location = new System.Drawing.Point(382, 9);
            this.AlwaysSwapLabel.Name = "AlwaysSwapLabel";
            this.AlwaysSwapLabel.Size = new System.Drawing.Size(206, 32);
            this.AlwaysSwapLabel.TabIndex = 24;
            this.AlwaysSwapLabel.Text = "Always Swap";
            this.AlwaysSwapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwapWrongValueLabel
            // 
            this.SwapWrongValueLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapWrongValueLabel.Location = new System.Drawing.Point(557, 100);
            this.SwapWrongValueLabel.Name = "SwapWrongValueLabel";
            this.SwapWrongValueLabel.Size = new System.Drawing.Size(180, 32);
            this.SwapWrongValueLabel.TabIndex = 23;
            this.SwapWrongValueLabel.Text = "0";
            this.SwapWrongValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SwapCorrectValueLabel
            // 
            this.SwapCorrectValueLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapCorrectValueLabel.Location = new System.Drawing.Point(557, 51);
            this.SwapCorrectValueLabel.Name = "SwapCorrectValueLabel";
            this.SwapCorrectValueLabel.Size = new System.Drawing.Size(180, 32);
            this.SwapCorrectValueLabel.TabIndex = 22;
            this.SwapCorrectValueLabel.Text = "0";
            this.SwapCorrectValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WrongGuessLabel2
            // 
            this.WrongGuessLabel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongGuessLabel2.Location = new System.Drawing.Point(371, 100);
            this.WrongGuessLabel2.Name = "WrongGuessLabel2";
            this.WrongGuessLabel2.Size = new System.Drawing.Size(180, 32);
            this.WrongGuessLabel2.TabIndex = 21;
            this.WrongGuessLabel2.Text = "Wrong Guess:";
            this.WrongGuessLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CorrectGuessLabel2
            // 
            this.CorrectGuessLabel2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectGuessLabel2.Location = new System.Drawing.Point(371, 51);
            this.CorrectGuessLabel2.Name = "CorrectGuessLabel2";
            this.CorrectGuessLabel2.Size = new System.Drawing.Size(180, 32);
            this.CorrectGuessLabel2.TabIndex = 20;
            this.CorrectGuessLabel2.Text = "Correct Guess:";
            this.CorrectGuessLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DontSwapLabel
            // 
            this.DontSwapLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DontSwapLabel.Location = new System.Drawing.Point(24, 9);
            this.DontSwapLabel.Name = "DontSwapLabel";
            this.DontSwapLabel.Size = new System.Drawing.Size(256, 32);
            this.DontSwapLabel.TabIndex = 18;
            this.DontSwapLabel.Text = "Do Not Swap";
            this.DontSwapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DoNotSwapWrongValueLabel
            // 
            this.DoNotSwapWrongValueLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoNotSwapWrongValueLabel.Location = new System.Drawing.Point(198, 100);
            this.DoNotSwapWrongValueLabel.Name = "DoNotSwapWrongValueLabel";
            this.DoNotSwapWrongValueLabel.Size = new System.Drawing.Size(156, 32);
            this.DoNotSwapWrongValueLabel.TabIndex = 17;
            this.DoNotSwapWrongValueLabel.Text = "0";
            this.DoNotSwapWrongValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DoNotSwapCorrectValueLabel
            // 
            this.DoNotSwapCorrectValueLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoNotSwapCorrectValueLabel.Location = new System.Drawing.Point(198, 51);
            this.DoNotSwapCorrectValueLabel.Name = "DoNotSwapCorrectValueLabel";
            this.DoNotSwapCorrectValueLabel.Size = new System.Drawing.Size(156, 32);
            this.DoNotSwapCorrectValueLabel.TabIndex = 16;
            this.DoNotSwapCorrectValueLabel.Text = "0";
            this.DoNotSwapCorrectValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WrongGuessLabel
            // 
            this.WrongGuessLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongGuessLabel.Location = new System.Drawing.Point(12, 100);
            this.WrongGuessLabel.Name = "WrongGuessLabel";
            this.WrongGuessLabel.Size = new System.Drawing.Size(180, 32);
            this.WrongGuessLabel.TabIndex = 15;
            this.WrongGuessLabel.Text = "Wrong Guess:";
            this.WrongGuessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CorrectGuessLabel
            // 
            this.CorrectGuessLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectGuessLabel.Location = new System.Drawing.Point(12, 51);
            this.CorrectGuessLabel.Name = "CorrectGuessLabel";
            this.CorrectGuessLabel.Size = new System.Drawing.Size(180, 32);
            this.CorrectGuessLabel.TabIndex = 14;
            this.CorrectGuessLabel.Text = "Correct Guess:";
            this.CorrectGuessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SimulationsControl
            // 
            this.SimulationsControl.BackColor = System.Drawing.Color.Transparent;
            this.SimulationsControl.BottomMargin = 0;
            this.SimulationsControl.Editable = true;
            this.SimulationsControl.Encrypted = false;
            this.SimulationsControl.LabelBottomMargin = 0;
            this.SimulationsControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.SimulationsControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulationsControl.LabelText = "Simulations:";
            this.SimulationsControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SimulationsControl.LabelTopMargin = 0;
            this.SimulationsControl.LabelWidth = 180;
            this.SimulationsControl.Location = new System.Drawing.Point(12, 175);
            this.SimulationsControl.MultiLine = false;
            this.SimulationsControl.Name = "SimulationsControl";
            this.SimulationsControl.OnTextChangedListener = null;
            this.SimulationsControl.PasswordMode = false;
            this.SimulationsControl.Size = new System.Drawing.Size(438, 32);
            this.SimulationsControl.TabIndex = 20;
            this.SimulationsControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SimulationsControl.TextBoxBottomMargin = 0;
            this.SimulationsControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.SimulationsControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.SimulationsControl.TextBoxFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulationsControl.TextBoxTopMargin = 0;
            // 
            // SelectDoorNumberControl
            // 
            this.SelectDoorNumberControl.BackColor = System.Drawing.Color.Transparent;
            this.SelectDoorNumberControl.ComboBoxLeftMargin = 1;
            this.SelectDoorNumberControl.ComboBoxText = "";
            this.SelectDoorNumberControl.ComoboBoxFont = null;
            this.SelectDoorNumberControl.Editable = true;
            this.SelectDoorNumberControl.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDoorNumberControl.LabelBottomMargin = 0;
            this.SelectDoorNumberControl.LabelColor = System.Drawing.SystemColors.ControlText;
            this.SelectDoorNumberControl.LabelFont = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDoorNumberControl.LabelText = "Select Door:";
            this.SelectDoorNumberControl.LabelTextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectDoorNumberControl.LabelTopMargin = 4;
            this.SelectDoorNumberControl.LabelWidth = 180;
            this.SelectDoorNumberControl.List = null;
            this.SelectDoorNumberControl.Location = new System.Drawing.Point(12, 225);
            this.SelectDoorNumberControl.Name = "SelectDoorNumberControl";
            this.SelectDoorNumberControl.SelectedIndex = -1;
            this.SelectDoorNumberControl.SelectedIndexListener = null;
            this.SelectDoorNumberControl.Size = new System.Drawing.Size(438, 32);
            this.SelectDoorNumberControl.Sorted = true;
            this.SelectDoorNumberControl.Source = null;
            this.SelectDoorNumberControl.TabIndex = 21;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(462, 234);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(275, 23);
            this.Graph.TabIndex = 22;
            this.Graph.Visible = false;
            // 
            // InitializingLabel
            // 
            this.InitializingLabel.AutoSize = true;
            this.InitializingLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitializingLabel.Location = new System.Drawing.Point(462, 213);
            this.InitializingLabel.Name = "InitializingLabel";
            this.InitializingLabel.Size = new System.Drawing.Size(96, 18);
            this.InitializingLabel.TabIndex = 23;
            this.InitializingLabel.Text = "Initializing";
            this.InitializingLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(772, 275);
            this.Controls.Add(this.InitializingLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.SelectDoorNumberControl);
            this.Controls.Add(this.SimulationsControl);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.StartSimulationButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pick A Door Simulator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartSimulationButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel DividerPanel;
        private System.Windows.Forms.Label AlwaysSwapLabel;
        private System.Windows.Forms.Label SwapWrongValueLabel;
        private System.Windows.Forms.Label SwapCorrectValueLabel;
        private System.Windows.Forms.Label WrongGuessLabel2;
        private System.Windows.Forms.Label CorrectGuessLabel2;
        private System.Windows.Forms.Label DontSwapLabel;
        private System.Windows.Forms.Label DoNotSwapWrongValueLabel;
        private System.Windows.Forms.Label DoNotSwapCorrectValueLabel;
        private System.Windows.Forms.Label WrongGuessLabel;
        private System.Windows.Forms.Label CorrectGuessLabel;
        private DataJuggler.Win.Controls.LabelTextBoxControl SimulationsControl;
        private DataJuggler.Win.Controls.LabelComboBoxControl SelectDoorNumberControl;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label InitializingLabel;
    }
}

