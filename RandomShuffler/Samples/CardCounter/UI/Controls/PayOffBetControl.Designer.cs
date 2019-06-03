namespace CardCounter.UI.Controls
{
    partial class PayOffBetControl
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
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ChipsHostControl = new CardCounter.UI.Controls.ChipsHostControl();
            this.AmountWageredLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ChipsHostControl);
            this.BottomPanel.Controls.Add(this.AmountWageredLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 46);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(240, 36);
            this.BottomPanel.TabIndex = 0;
            // 
            // ChipsHostControl
            // 
            this.ChipsHostControl.BackColor = System.Drawing.Color.Transparent;
            this.ChipsHostControl.Chips = null;
            this.ChipsHostControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChipsHostControl.Location = new System.Drawing.Point(120, 0);
            this.ChipsHostControl.Name = "ChipsHostControl";
            this.ChipsHostControl.Size = new System.Drawing.Size(120, 36);
            this.ChipsHostControl.TabIndex = 68;
            // 
            // AmountWageredLabel
            // 
            this.AmountWageredLabel.BackColor = System.Drawing.Color.Transparent;
            this.AmountWageredLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AmountWageredLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountWageredLabel.ForeColor = System.Drawing.Color.White;
            this.AmountWageredLabel.Location = new System.Drawing.Point(0, 0);
            this.AmountWageredLabel.Name = "AmountWageredLabel";
            this.AmountWageredLabel.Size = new System.Drawing.Size(120, 36);
            this.AmountWageredLabel.TabIndex = 67;
            this.AmountWageredLabel.Text = "$500";
            this.AmountWageredLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AmountWageredLabel.Visible = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.MessageLabel.Location = new System.Drawing.Point(0, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(240, 46);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Winner!";
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PayOffBetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.BottomPanel);
            this.Name = "PayOffBetControl";
            this.Size = new System.Drawing.Size(240, 82);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Label AmountWageredLabel;
        private ChipsHostControl ChipsHostControl;
    }
}
