

#region using statements


#endregion

namespace CardCounter.UI.Controls
{

    #region class PlayerResponseControl
    /// <summary>
    /// This method [Enter Method Description]
    /// </summary>
    partial class PlayerResponseControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Panel FillerPanel3;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Panel FillerPanel2;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Panel FillerPanel1;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Panel TopMarginPanel;
        private System.Windows.Forms.Timer GraphTimer;
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
                this.ButtonPanel = new System.Windows.Forms.Panel();
                this.Button4 = new System.Windows.Forms.Button();
                this.FillerPanel3 = new System.Windows.Forms.Panel();
                this.Button3 = new System.Windows.Forms.Button();
                this.FillerPanel2 = new System.Windows.Forms.Panel();
                this.Button2 = new System.Windows.Forms.Button();
                this.FillerPanel1 = new System.Windows.Forms.Panel();
                this.Button1 = new System.Windows.Forms.Button();
                this.Graph = new System.Windows.Forms.ProgressBar();
                this.TopMarginPanel = new System.Windows.Forms.Panel();
                this.GraphTimer = new System.Windows.Forms.Timer(this.components);
                this.ButtonPanel.SuspendLayout();
                this.SuspendLayout();
                // 
                // ButtonPanel
                // 
                this.ButtonPanel.Controls.Add(this.Button4);
                this.ButtonPanel.Controls.Add(this.FillerPanel3);
                this.ButtonPanel.Controls.Add(this.Button3);
                this.ButtonPanel.Controls.Add(this.FillerPanel2);
                this.ButtonPanel.Controls.Add(this.Button2);
                this.ButtonPanel.Controls.Add(this.FillerPanel1);
                this.ButtonPanel.Controls.Add(this.Button1);
                this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
                this.ButtonPanel.Location = new System.Drawing.Point(0, 0);
                this.ButtonPanel.Name = "ButtonPanel";
                this.ButtonPanel.Size = new System.Drawing.Size(568, 48);
                this.ButtonPanel.TabIndex = 11;
                // 
                // Button4
                // 
                this.Button4.BackgroundImage = global::CardCounter.Properties.Resources.DarkButton1;
                this.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.Button4.Dock = System.Windows.Forms.DockStyle.Left;
                this.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Button4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Button4.ForeColor = System.Drawing.Color.White;
                this.Button4.Location = new System.Drawing.Point(428, 0);
                this.Button4.MaximumSize = new System.Drawing.Size(140, 48);
                this.Button4.MinimumSize = new System.Drawing.Size(140, 48);
                this.Button4.Name = "Button4";
                this.Button4.Size = new System.Drawing.Size(140, 48);
                this.Button4.TabIndex = 17;
                this.Button4.Text = "Insurance";
                this.Button4.UseVisualStyleBackColor = true;
                this.Button4.Click += new System.EventHandler(this.Button4_Click);
                this.Button4.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.Button4.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // FillerPanel3
                // 
                this.FillerPanel3.Dock = System.Windows.Forms.DockStyle.Left;
                this.FillerPanel3.Location = new System.Drawing.Point(412, 0);
                this.FillerPanel3.Name = "FillerPanel3";
                this.FillerPanel3.Size = new System.Drawing.Size(16, 48);
                this.FillerPanel3.TabIndex = 16;
                // 
                // Button3
                // 
                this.Button3.BackgroundImage = global::CardCounter.Properties.Resources.DarkButton1;
                this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
                this.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Button3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Button3.ForeColor = System.Drawing.Color.White;
                this.Button3.Location = new System.Drawing.Point(272, 0);
                this.Button3.MaximumSize = new System.Drawing.Size(140, 48);
                this.Button3.MinimumSize = new System.Drawing.Size(140, 48);
                this.Button3.Name = "Button3";
                this.Button3.Size = new System.Drawing.Size(140, 48);
                this.Button3.TabIndex = 15;
                this.Button3.Text = "Surrender";
                this.Button3.UseVisualStyleBackColor = true;
                this.Button3.Click += new System.EventHandler(this.Button3_Click);
                this.Button3.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.Button3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // FillerPanel2
                // 
                this.FillerPanel2.Dock = System.Windows.Forms.DockStyle.Left;
                this.FillerPanel2.Location = new System.Drawing.Point(256, 0);
                this.FillerPanel2.Name = "FillerPanel2";
                this.FillerPanel2.Size = new System.Drawing.Size(16, 48);
                this.FillerPanel2.TabIndex = 14;
                // 
                // Button2
                // 
                this.Button2.BackgroundImage = global::CardCounter.Properties.Resources.DarkButton1;
                this.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.Button2.Dock = System.Windows.Forms.DockStyle.Left;
                this.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Button2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Button2.ForeColor = System.Drawing.Color.White;
                this.Button2.Location = new System.Drawing.Point(136, 0);
                this.Button2.MaximumSize = new System.Drawing.Size(120, 48);
                this.Button2.MinimumSize = new System.Drawing.Size(120, 48);
                this.Button2.Name = "Button2";
                this.Button2.Size = new System.Drawing.Size(120, 48);
                this.Button2.TabIndex = 13;
                this.Button2.Text = "Sit Out";
                this.Button2.UseVisualStyleBackColor = true;
                this.Button2.Click += new System.EventHandler(this.Button2_Click);
                this.Button2.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.Button2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // FillerPanel1
                // 
                this.FillerPanel1.Dock = System.Windows.Forms.DockStyle.Left;
                this.FillerPanel1.Location = new System.Drawing.Point(120, 0);
                this.FillerPanel1.Name = "FillerPanel1";
                this.FillerPanel1.Size = new System.Drawing.Size(16, 48);
                this.FillerPanel1.TabIndex = 12;
                // 
                // Button1
                // 
                this.Button1.BackgroundImage = global::CardCounter.Properties.Resources.DarkButton1;
                this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
                this.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
                this.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
                this.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
                this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.Button1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Button1.ForeColor = System.Drawing.Color.White;
                this.Button1.Location = new System.Drawing.Point(0, 0);
                this.Button1.MaximumSize = new System.Drawing.Size(120, 48);
                this.Button1.MinimumSize = new System.Drawing.Size(120, 48);
                this.Button1.Name = "Button1";
                this.Button1.Size = new System.Drawing.Size(120, 48);
                this.Button1.TabIndex = 11;
                this.Button1.Text = "Place Bet";
                this.Button1.UseVisualStyleBackColor = true;
                this.Button1.Click += new System.EventHandler(this.Button1_Click);
                this.Button1.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
                this.Button1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
                // 
                // Graph
                // 
                this.Graph.Dock = System.Windows.Forms.DockStyle.Fill;
                this.Graph.Location = new System.Drawing.Point(0, 48);
                this.Graph.Maximum = 15000;
                this.Graph.Name = "Graph";
                this.Graph.Size = new System.Drawing.Size(568, 32);
                this.Graph.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
                this.Graph.TabIndex = 12;
                this.Graph.VisibleChanged += new System.EventHandler(this.Graph_VisibleChanged);
                // 
                // TopMarginPanel
                // 
                this.TopMarginPanel.Dock = System.Windows.Forms.DockStyle.Top;
                this.TopMarginPanel.Location = new System.Drawing.Point(0, 48);
                this.TopMarginPanel.Name = "TopMarginPanel";
                this.TopMarginPanel.Size = new System.Drawing.Size(568, 8);
                this.TopMarginPanel.TabIndex = 13;
                // 
                // GraphTimer
                // 
                this.GraphTimer.Tick += new System.EventHandler(this.GraphTimer_Tick);
                // 
                // PlayerResponseControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(this.TopMarginPanel);
                this.Controls.Add(this.Graph);
                this.Controls.Add(this.ButtonPanel);
                this.DoubleBuffered = true;
                this.Name = "PlayerResponseControl";
                this.Size = new System.Drawing.Size(568, 80);
                this.ButtonPanel.ResumeLayout(false);
                this.ResumeLayout(false);
                
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
