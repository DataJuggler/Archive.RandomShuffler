

#region using statements


#endregion

namespace CardCounter.UI.Controls
{

    #region class CountingSystemViewerControl
    /// <summary>
    /// This is the designer for the CountingSystemViewerControl
    /// </summary>
    partial class CountingSystemViewerControl
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.LinkLabel WikipediaLinkButton;
        private System.Windows.Forms.LinkLabel BlackJackCOZALinkButton;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.WikipediaLinkButton = new System.Windows.Forms.LinkLabel();
            this.BlackJackCOZALinkButton = new System.Windows.Forms.LinkLabel();
            this.DoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(25, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(354, 35);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Card Counting Systems";
            // 
            // ActionLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(25, 39);
            this.InfoLabel.Name = "ActionLabel";
            this.InfoLabel.Size = new System.Drawing.Size(780, 131);
            this.InfoLabel.TabIndex = 1;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.EnableHeadersVisualStyles = false;
            this.Grid.Location = new System.Drawing.Point(30, 170);
            this.Grid.Name = "Grid";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.Size = new System.Drawing.Size(778, 274);
            this.Grid.TabIndex = 3;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            this.Grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Grid_CellFormatting);
            this.Grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Grid_DataBindingComplete);
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.Location = new System.Drawing.Point(22, 474);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(224, 35);
            this.TitleLabel2.TabIndex = 4;
            this.TitleLabel2.Text = "To Learn More:";
            // 
            // WikipediaLinkButton
            // 
            this.WikipediaLinkButton.AutoSize = true;
            this.WikipediaLinkButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WikipediaLinkButton.Location = new System.Drawing.Point(26, 509);
            this.WikipediaLinkButton.Name = "WikipediaLinkButton";
            this.WikipediaLinkButton.Size = new System.Drawing.Size(248, 23);
            this.WikipediaLinkButton.TabIndex = 5;
            this.WikipediaLinkButton.TabStop = true;
            this.WikipediaLinkButton.Text = "Card Counting Wikipedia";
            this.WikipediaLinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WikipediaLinkButton_LinkClicked);
            // 
            // BlackJackCOZALinkButton
            // 
            this.BlackJackCOZALinkButton.AutoSize = true;
            this.BlackJackCOZALinkButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlackJackCOZALinkButton.Location = new System.Drawing.Point(322, 509);
            this.BlackJackCOZALinkButton.Name = "BlackJackCOZALinkButton";
            this.BlackJackCOZALinkButton.Size = new System.Drawing.Size(291, 23);
            this.BlackJackCOZALinkButton.TabIndex = 6;
            this.BlackJackCOZALinkButton.TabStop = true;
            this.BlackJackCOZALinkButton.Text = "Your Online Black Jack Guide";
            this.BlackJackCOZALinkButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BlackJackCOZALinkButton_LinkClicked);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.BackgroundImage = global::CardCounter.Properties.Resources.DarkBlueButton;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DoneButton.Location = new System.Drawing.Point(696, 509);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(112, 36);
            this.DoneButton.TabIndex = 40;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            this.DoneButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.DoneButton.MouseLeave += new System.EventHandler(this.DoneButton_MouseLeave);
            // 
            // CountingSystemViewerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.BlackJackCOZALinkButton);
            this.Controls.Add(this.WikipediaLinkButton);
            this.Controls.Add(this.TitleLabel2);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TitleLabel);
            this.DoubleBuffered = true;
            this.Name = "CountingSystemViewerControl";
            this.Size = new System.Drawing.Size(840, 560);
            this.Load += new System.EventHandler(this.CountingSystemViewerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }
            #endregion

            private System.Windows.Forms.Button DoneButton;
            
        #endregion
        
    }
    #endregion

}
