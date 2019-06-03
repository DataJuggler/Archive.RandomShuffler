

#region using statements


#endregion

namespace CardCounter.UI.Forms
{

    #region class MainForm
    /// <summary>
    /// This is the designer for the MainForm.
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private Controls.DealerCardContainerControl DealerCardContainerControl;
        private Controls.PayOffBetControl PayOffBetControl;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel MainPanel;
        private Controls.BlackJackPlayerControl BlackJackPlayerControl5;
        private Controls.PlayerResponseControl PlayerResponseControl;
        private Controls.ShufflingAnimationControl ShufflingAnimationControl;
        private Controls.BlackJackPlayerControl BlackJackPlayerControl1;
        private Controls.BlackJackPlayerControl BlackJackPlayerControl2;
        private Controls.BlackJackPlayerControl BlackJackPlayerControl3;
        private Controls.BlackJackPlayerControl BlackJackPlayerControl4;
        private System.Windows.Forms.Panel LeftMarginPanel;
        private System.Windows.Forms.Panel LeftPanel2;
        private System.Windows.Forms.Panel BottomMarginPanel;
        private System.Windows.Forms.Panel SpacerPanel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Diagnostics.Stopwatch stopwatch1 = new System.Diagnostics.Stopwatch();
            this.PayOffBetControl = new CardCounter.UI.Controls.PayOffBetControl();
            this.DealerCardContainerControl = new CardCounter.UI.Controls.DealerCardContainerControl();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableOptionsControl = new CardCounter.UI.Controls.TableOptionsControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cardCounterControl1 = new CardCounter.UI.Controls.CardCounterControl();
            this.SeperatorPanel = new System.Windows.Forms.Panel();
            this.BottomMarginPanel = new System.Windows.Forms.Panel();
            this.LeftPanel2 = new System.Windows.Forms.Panel();
            this.LeftMarginPanel = new System.Windows.Forms.Panel();
            this.SpacerPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BlackJackPlayerControl5 = new CardCounter.UI.Controls.BlackJackPlayerControl();
            this.PlayerResponseControl = new CardCounter.UI.Controls.PlayerResponseControl();
            this.ShufflingAnimationControl = new CardCounter.UI.Controls.ShufflingAnimationControl();
            this.BlackJackPlayerControl1 = new CardCounter.UI.Controls.BlackJackPlayerControl();
            this.BlackJackPlayerControl2 = new CardCounter.UI.Controls.BlackJackPlayerControl();
            this.BlackJackPlayerControl3 = new CardCounter.UI.Controls.BlackJackPlayerControl();
            this.BlackJackPlayerControl4 = new CardCounter.UI.Controls.BlackJackPlayerControl();
            this.LeftPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PayOffBetControl
            // 
            this.PayOffBetControl.BackColor = System.Drawing.Color.Transparent;
            this.PayOffBetControl.Location = new System.Drawing.Point(0, 120);
            this.PayOffBetControl.Name = "PayOffBetControl";
            this.PayOffBetControl.Size = new System.Drawing.Size(238, 80);
            this.PayOffBetControl.TabIndex = 22;
            this.PayOffBetControl.Visible = false;
            // 
            // DealerCardContainerControl
            // 
            this.DealerCardContainerControl.BackColor = System.Drawing.Color.Transparent;
            this.DealerCardContainerControl.GameManager = null;
            this.DealerCardContainerControl.Location = new System.Drawing.Point(534, 126);
            this.DealerCardContainerControl.Name = "DealerCardContainerControl";
            this.DealerCardContainerControl.Size = new System.Drawing.Size(524, 136);
            this.DealerCardContainerControl.TabIndex = 15;
            this.DealerCardContainerControl.Visible = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Black;
            this.LeftPanel.Controls.Add(this.panel2);
            this.LeftPanel.Controls.Add(this.TableOptionsControl);
            this.LeftPanel.Controls.Add(this.panel1);
            this.LeftPanel.Controls.Add(this.cardCounterControl1);
            this.LeftPanel.Controls.Add(this.SeperatorPanel);
            this.LeftPanel.Controls.Add(this.BottomMarginPanel);
            this.LeftPanel.Controls.Add(this.LeftPanel2);
            this.LeftPanel.Controls.Add(this.LeftMarginPanel);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(420, 941);
            this.LeftPanel.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(50, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 16);
            this.panel2.TabIndex = 43;
            // 
            // TableOptionsControl
            // 
            this.TableOptionsControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TableOptionsControl.BackgroundImage")));
            this.TableOptionsControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TableOptionsControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableOptionsControl.GameManager = null;
            this.TableOptionsControl.Location = new System.Drawing.Point(50, 192);
            this.TableOptionsControl.MaximumSize = new System.Drawing.Size(320, 128);
            this.TableOptionsControl.MinimumSize = new System.Drawing.Size(320, 128);
            this.TableOptionsControl.Name = "TableOptionsControl";
            this.TableOptionsControl.Size = new System.Drawing.Size(320, 128);
            this.TableOptionsControl.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(50, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 16);
            this.panel1.TabIndex = 41;
            // 
            // cardCounterControl1
            // 
            this.cardCounterControl1.BackColor = System.Drawing.Color.Transparent;
            this.cardCounterControl1.BackgroundImage = global::CardCounter.Properties.Resources.MidnightBlueGradient;
            this.cardCounterControl1.Count = 0;
            this.cardCounterControl1.CountingSystems = null;
            this.cardCounterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardCounterControl1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardCounterControl1.ForeColor = System.Drawing.Color.LemonChiffon;
            this.cardCounterControl1.Location = new System.Drawing.Point(50, 16);
            this.cardCounterControl1.MaximumSize = new System.Drawing.Size(320, 160);
            this.cardCounterControl1.MinimumSize = new System.Drawing.Size(320, 160);
            this.cardCounterControl1.Name = "cardCounterControl1";
            this.cardCounterControl1.SelectedCountingSystem = null;
            this.cardCounterControl1.ShowCount = true;
            this.cardCounterControl1.Size = new System.Drawing.Size(320, 160);
            this.cardCounterControl1.TabIndex = 39;
            // 
            // SeperatorPanel
            // 
            this.SeperatorPanel.BackColor = System.Drawing.Color.Transparent;
            this.SeperatorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SeperatorPanel.Location = new System.Drawing.Point(50, 0);
            this.SeperatorPanel.Name = "SeperatorPanel";
            this.SeperatorPanel.Size = new System.Drawing.Size(370, 16);
            this.SeperatorPanel.TabIndex = 38;
            // 
            // BottomMarginPanel
            // 
            this.BottomMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomMarginPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomMarginPanel.Location = new System.Drawing.Point(50, 937);
            this.BottomMarginPanel.Name = "BottomMarginPanel";
            this.BottomMarginPanel.Size = new System.Drawing.Size(370, 4);
            this.BottomMarginPanel.TabIndex = 32;
            // 
            // LeftPanel2
            // 
            this.LeftPanel2.BackColor = System.Drawing.Color.Transparent;
            this.LeftPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel2.Location = new System.Drawing.Point(10, 0);
            this.LeftPanel2.Name = "LeftPanel2";
            this.LeftPanel2.Size = new System.Drawing.Size(40, 941);
            this.LeftPanel2.TabIndex = 31;
            // 
            // LeftMarginPanel
            // 
            this.LeftMarginPanel.BackColor = System.Drawing.Color.Transparent;
            this.LeftMarginPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMarginPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftMarginPanel.Name = "LeftMarginPanel";
            this.LeftMarginPanel.Size = new System.Drawing.Size(10, 941);
            this.LeftMarginPanel.TabIndex = 26;
            // 
            // SpacerPanel
            // 
            this.SpacerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SpacerPanel.Location = new System.Drawing.Point(50, 8);
            this.SpacerPanel.Name = "SpacerPanel";
            this.SpacerPanel.Size = new System.Drawing.Size(370, 16);
            this.SpacerPanel.TabIndex = 35;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.ForestGreen;
            this.MainPanel.BackgroundImage = global::CardCounter.Properties.Resources.Black_Jack_Table;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.BlackJackPlayerControl5);
            this.MainPanel.Controls.Add(this.PlayerResponseControl);
            this.MainPanel.Controls.Add(this.ShufflingAnimationControl);
            this.MainPanel.Controls.Add(this.BlackJackPlayerControl1);
            this.MainPanel.Controls.Add(this.BlackJackPlayerControl2);
            this.MainPanel.Controls.Add(this.BlackJackPlayerControl3);
            this.MainPanel.Controls.Add(this.BlackJackPlayerControl4);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(420, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1205, 941);
            this.MainPanel.TabIndex = 26;
            // 
            // BlackJackPlayerControl5
            // 
            this.BlackJackPlayerControl5.BackColor = System.Drawing.Color.Transparent;
            this.BlackJackPlayerControl5.Location = new System.Drawing.Point(1059, 145);
            this.BlackJackPlayerControl5.MaximumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl5.MinimumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl5.Name = "BlackJackPlayerControl5";
            this.BlackJackPlayerControl5.SeatNumber = CardCounter.Enumerations.SeatNumberEnum.Seat1;
            this.BlackJackPlayerControl5.Size = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl5.TabIndex = 29;
            this.BlackJackPlayerControl5.Visible = false;
            // 
            // PlayerResponseControl
            // 
            this.PlayerResponseControl.BackColor = System.Drawing.Color.Transparent;
            this.PlayerResponseControl.ButtonClickHandler = null;
            this.PlayerResponseControl.Location = new System.Drawing.Point(773, 593);
            this.PlayerResponseControl.Name = "PlayerResponseControl";
            this.PlayerResponseControl.ResponseSent = false;
            this.PlayerResponseControl.SendResponseCallBack = null;
            this.PlayerResponseControl.Size = new System.Drawing.Size(528, 80);
            this.PlayerResponseControl.Stopwatch = stopwatch1;
            this.PlayerResponseControl.TabIndex = 24;
            this.PlayerResponseControl.Visible = false;
            // 
            // ShufflingAnimationControl
            // 
            this.ShufflingAnimationControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShufflingAnimationControl.BackgroundImage")));
            this.ShufflingAnimationControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ShufflingAnimationControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShufflingAnimationControl.Count = 9;
            this.ShufflingAnimationControl.Location = new System.Drawing.Point(322, 163);
            this.ShufflingAnimationControl.Name = "ShufflingAnimationControl";
            this.ShufflingAnimationControl.Size = new System.Drawing.Size(402, 90);
            this.ShufflingAnimationControl.TabIndex = 23;
            this.ShufflingAnimationControl.Visible = false;
            // 
            // BlackJackPlayerControl1
            // 
            this.BlackJackPlayerControl1.BackColor = System.Drawing.Color.Transparent;
            this.BlackJackPlayerControl1.Location = new System.Drawing.Point(34, 108);
            this.BlackJackPlayerControl1.MaximumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl1.MinimumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl1.Name = "BlackJackPlayerControl1";
            this.BlackJackPlayerControl1.SeatNumber = CardCounter.Enumerations.SeatNumberEnum.Seat5;
            this.BlackJackPlayerControl1.Size = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl1.TabIndex = 25;
            this.BlackJackPlayerControl1.Visible = false;
            // 
            // BlackJackPlayerControl2
            // 
            this.BlackJackPlayerControl2.BackColor = System.Drawing.Color.Transparent;
            this.BlackJackPlayerControl2.Location = new System.Drawing.Point(195, 145);
            this.BlackJackPlayerControl2.MaximumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl2.MinimumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl2.Name = "BlackJackPlayerControl2";
            this.BlackJackPlayerControl2.SeatNumber = CardCounter.Enumerations.SeatNumberEnum.Seat4;
            this.BlackJackPlayerControl2.Size = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl2.TabIndex = 26;
            this.BlackJackPlayerControl2.Visible = false;
            // 
            // BlackJackPlayerControl3
            // 
            this.BlackJackPlayerControl3.BackColor = System.Drawing.Color.Transparent;
            this.BlackJackPlayerControl3.Location = new System.Drawing.Point(483, 145);
            this.BlackJackPlayerControl3.MaximumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl3.MinimumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl3.Name = "BlackJackPlayerControl3";
            this.BlackJackPlayerControl3.SeatNumber = CardCounter.Enumerations.SeatNumberEnum.Seat3;
            this.BlackJackPlayerControl3.Size = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl3.TabIndex = 27;
            this.BlackJackPlayerControl3.Visible = false;
            // 
            // BlackJackPlayerControl4
            // 
            this.BlackJackPlayerControl4.BackColor = System.Drawing.Color.Transparent;
            this.BlackJackPlayerControl4.Location = new System.Drawing.Point(771, 145);
            this.BlackJackPlayerControl4.MaximumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl4.MinimumSize = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl4.Name = "BlackJackPlayerControl4";
            this.BlackJackPlayerControl4.SeatNumber = CardCounter.Enumerations.SeatNumberEnum.Seat2;
            this.BlackJackPlayerControl4.Size = new System.Drawing.Size(180, 496);
            this.BlackJackPlayerControl4.TabIndex = 28;
            this.BlackJackPlayerControl4.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1625, 941);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.PayOffBetControl);
            this.Controls.Add(this.DealerCardContainerControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Counter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Resize);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.LeftPanel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }
        #endregion

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Controls.TableOptionsControl TableOptionsControl;
        private System.Windows.Forms.Panel panel1;
        private Controls.CardCounterControl cardCounterControl1;
        private System.Windows.Forms.Panel SeperatorPanel;
    }
    #endregion

}
