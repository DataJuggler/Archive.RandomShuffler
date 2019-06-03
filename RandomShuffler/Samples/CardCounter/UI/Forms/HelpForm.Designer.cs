

#region using statements


#endregion

namespace CardCounter.UI.Forms
{

    #region class HelpForm
    /// <summary>
    /// This is the designer for the HelpForm.
    /// </summary>
    partial class HelpForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private Controls.CountingSystemViewerControl engineViewerControl1;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.engineViewerControl1 = new CardCounter.UI.Controls.CountingSystemViewerControl();
            this.SuspendLayout();
            // 
            // engineViewerControl1
            // 
            this.engineViewerControl1.BackColor = System.Drawing.Color.White;
            this.engineViewerControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engineViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engineViewerControl1.Location = new System.Drawing.Point(0, 0);
            this.engineViewerControl1.Name = "engineViewerControl1";
            this.engineViewerControl1.Size = new System.Drawing.Size(840, 560);
            this.engineViewerControl1.TabIndex = 0;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.engineViewerControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(856, 599);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(856, 599);
            this.Name = "HelpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.ResumeLayout(false);

            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
