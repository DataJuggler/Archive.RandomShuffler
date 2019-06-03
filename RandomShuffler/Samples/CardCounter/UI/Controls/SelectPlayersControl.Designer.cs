

#region using statements

#endregion

namespace CardCounter.UI.Controls
{

    #region class SelectPlayersControl
    /// <summary>
    /// This class is the Designer for the SelectPlayersControl
    /// </summary>
    partial class SelectPlayersControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private PlayerEditorControl PlayerEditorControl1;
        private PlayerEditorControl PlayerEditorControl2;
        private PlayerEditorControl PlayerEditorControl3;
        private PlayerEditorControl PlayerEditorControl4;
        private PlayerEditorControl PlayerEditorControl5;
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
                this.PlayerEditorControl1 = new CardCounter.UI.Controls.PlayerEditorControl();
                this.PlayerEditorControl2 = new CardCounter.UI.Controls.PlayerEditorControl();
                this.PlayerEditorControl3 = new CardCounter.UI.Controls.PlayerEditorControl();
                this.PlayerEditorControl4 = new CardCounter.UI.Controls.PlayerEditorControl();
                this.PlayerEditorControl5 = new CardCounter.UI.Controls.PlayerEditorControl();
                this.SuspendLayout();
                // 
                // PlayerEditorControl1
                // 
                this.PlayerEditorControl1.BackColor = System.Drawing.Color.Transparent;
                this.PlayerEditorControl1.Dock = System.Windows.Forms.DockStyle.Top;
                this.PlayerEditorControl1.Location = new System.Drawing.Point(0, 0);
                this.PlayerEditorControl1.Name = "PlayerEditorControl1";
                this.PlayerEditorControl1.Player = null;
                this.PlayerEditorControl1.SeatNumber = 0;
                this.PlayerEditorControl1.Size = new System.Drawing.Size(704, 110);
                this.PlayerEditorControl1.TabIndex = 0;
                // 
                // PlayerEditorControl2
                // 
                this.PlayerEditorControl2.BackColor = System.Drawing.Color.Transparent;
                this.PlayerEditorControl2.Dock = System.Windows.Forms.DockStyle.Top;
                this.PlayerEditorControl2.Location = new System.Drawing.Point(0, 110);
                this.PlayerEditorControl2.Name = "PlayerEditorControl2";
                this.PlayerEditorControl2.Player = null;
                this.PlayerEditorControl2.SeatNumber = 0;
                this.PlayerEditorControl2.Size = new System.Drawing.Size(704, 110);
                this.PlayerEditorControl2.TabIndex = 1;
                // 
                // PlayerEditorControl3
                // 
                this.PlayerEditorControl3.BackColor = System.Drawing.Color.Transparent;
                this.PlayerEditorControl3.Dock = System.Windows.Forms.DockStyle.Top;
                this.PlayerEditorControl3.Location = new System.Drawing.Point(0, 220);
                this.PlayerEditorControl3.Name = "PlayerEditorControl3";
                this.PlayerEditorControl3.Player = null;
                this.PlayerEditorControl3.SeatNumber = 0;
                this.PlayerEditorControl3.Size = new System.Drawing.Size(704, 110);
                this.PlayerEditorControl3.TabIndex = 2;
                // 
                // PlayerEditorControl4
                // 
                this.PlayerEditorControl4.BackColor = System.Drawing.Color.Transparent;
                this.PlayerEditorControl4.Dock = System.Windows.Forms.DockStyle.Top;
                this.PlayerEditorControl4.Location = new System.Drawing.Point(0, 330);
                this.PlayerEditorControl4.Name = "PlayerEditorControl4";
                this.PlayerEditorControl4.Player = null;
                this.PlayerEditorControl4.SeatNumber = 0;
                this.PlayerEditorControl4.Size = new System.Drawing.Size(704, 110);
                this.PlayerEditorControl4.TabIndex = 3;
                // 
                // PlayerEditorControl5
                // 
                this.PlayerEditorControl5.BackColor = System.Drawing.Color.Transparent;
                this.PlayerEditorControl5.Dock = System.Windows.Forms.DockStyle.Top;
                this.PlayerEditorControl5.Location = new System.Drawing.Point(0, 440);
                this.PlayerEditorControl5.Name = "PlayerEditorControl5";
                this.PlayerEditorControl5.Player = null;
                this.PlayerEditorControl5.SeatNumber = 0;
                this.PlayerEditorControl5.Size = new System.Drawing.Size(704, 110);
                this.PlayerEditorControl5.TabIndex = 4;
                // 
                // SelectPlayersControl
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.Transparent;
                this.Controls.Add(this.PlayerEditorControl5);
                this.Controls.Add(this.PlayerEditorControl4);
                this.Controls.Add(this.PlayerEditorControl3);
                this.Controls.Add(this.PlayerEditorControl2);
                this.Controls.Add(this.PlayerEditorControl1);
                this.DoubleBuffered = true;
                this.Name = "SelectPlayersControl";
                this.Size = new System.Drawing.Size(704, 554);
                this.ResumeLayout(false);
                
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
