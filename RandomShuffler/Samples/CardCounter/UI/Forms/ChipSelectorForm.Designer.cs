

#region using statements


#endregion

namespace CardCounter.UI.Forms
{

    #region class ChipSelectorForm
    /// <summary>
    /// This class is the designer for the ChipSelectorForm
    /// </summary>
    partial class ChipSelectorForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private Controls.ChipSelectorControl ChipSelectorControl;
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
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChipSelectorForm));
                this.ChipSelectorControl = new CardCounter.UI.Controls.ChipSelectorControl();
                this.SuspendLayout();
                // 
                // ChipSelectorControl
                // 
                this.ChipSelectorControl.AmountBet = 0;
                this.ChipSelectorControl.BackColor = System.Drawing.Color.SteelBlue;
                this.ChipSelectorControl.Location = new System.Drawing.Point(0, 0);
                this.ChipSelectorControl.Name = "ChipSelectorControl";
                this.ChipSelectorControl.Size = new System.Drawing.Size(720, 320);
                this.ChipSelectorControl.TabIndex = 0;
                // 
                // ChipSelectorForm
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(718, 320);
                this.Controls.Add(this.ChipSelectorControl);
                this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
                this.Name = "ChipSelectorForm";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
                this.Text = "ChipSelectorForm";
                this.ResumeLayout(false);
                
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
