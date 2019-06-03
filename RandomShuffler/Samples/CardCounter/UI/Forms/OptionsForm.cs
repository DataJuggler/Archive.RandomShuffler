 

#region using statements

using CardCounter.Objects;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using CardCounter.Security;
using DataJuggler.Core.UltimateHelper;
using CardCounter.UI.Controls;

#endregion

namespace CardCounter.UI.Forms
{

    #region class OptionsForm
    /// <summary>
    /// This form displays the current options and saves them in the ApplicationSettings
    /// if a user allowed that option.
    /// </summary>
    public partial class OptionsForm : Form, ITabHostControlParent
    {
        
        #region Private Variables
        private bool userCancelled;
        private TabButton optionsTabButton;
        private TabButton playersTabButton;
        private TabButton selectedTab;
        private const int DefaultDecksMinimum = 1;
        private const int DefaultDecksMaximum = 8;
        private const int DefaultDecksValue = 6;
        private const int DefaultSliderWidth = 640;
        private const int DefaultSliderLeftPanelWidth = 360;
        private GameManager gameManager;
        private MainForm table;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of an OptionsForm.
        /// </summary>
        public OptionsForm(MainForm table)
        {
            // Store the table
            this.Table = table;

            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region CancelButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'CancelButton' is clicked.
            /// </summary>
            private void CancelButton_Click(object sender, EventArgs e)
            {
                // Set to true
                this.UserCancelled = true;

                // Close this form
                this.Close();
            }
            #endregion
            
            #region OptionsForm_Load(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Options Form _ Load
            /// </summary>
            private void OptionsForm_Load(object sender, EventArgs e)
            {
                // Perform initializations for this object
                Init();
            }
            #endregion
            
            #region OptionsTabButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'OptionsTabButton' is clicked.
            /// </summary>
            void OptionsTabButton_Click(object sender, EventArgs e)
            {  
                // Hide the SelectPlayersControl
                this.SelectPlayersControl.Visible = false;
                
                // Show the Options Control
                this.OptionsControl.Visible = true;

                // Refresh the OptionsControl
                this.OptionsControl.Refresh();
                this.Refresh();
            }
            #endregion
            
            #region PlayersTabButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'PlayersTabButton' is clicked.
            /// </summary>
            void PlayersTabButton_Click(object sender, EventArgs e)
            {  
                // Hide the SelectPlayersControl
                this.OptionsControl.Visible = false;

                // Refresh this
                this.Refresh();
                
                // Show the Options Control
                this.SelectPlayersControl.Visible = true;

                // Refresh the SelectPlayersControl
                this.SelectPlayersControl.Refresh();
                this.Refresh();
            }
            #endregion
            
            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'SaveButton' is clicked.
            /// </summary>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // Capture the Game Manager from this form
                this.GameManager = CaptureGameManager();
                
                // If the GameManager object exists (should always be true)
                if (this.HasGameManager)
                {
                    // if the values needs to be saved on this computer
                    if (gameManager.HouseRules.SaveSettingsOnThisComputer)
                    {
                        // The gameManager needs to be converted to a SecureUserData (ApplicationSettings) object.
                        SecureUserData security = SecureUserDataFactory.Convert(gameManager);

                        // If the security object exists
                        if (NullHelper.Exists(security))
                        {
                            // set the LastSavedDate
                            security.LastSavedDate = DateTime.Now;

                            // save the values in the settings
                            security.Save();                            
                        }
                    }

                    // The user did not cancel
                    this.UserCancelled = false;

                    // Close this form
                    this.Close();
                }
            }
            #endregion

            #region TabSelected(TabButton tabButton)
            /// <summary>
            /// A Tab was Selected in the TabHostControl
            /// </summary>
            /// <param name="tabButton"></param>
            public void TabSelected(TabButton tabButton)
            {
                // Set the tabButton
                this.SelectedTab = tabButton;

                // if this is Button 1
                if (this.SelectedTab.ButtonNumber == 1)
                {
                    // Call the PlayersTabButton_Click
                    this.PlayersTabButton_Click(this, new EventArgs());
                }
                else if (this.SelectedTab.ButtonNumber == 2)
                {
                    // Call the OptionsTabButton_Click
                    this.OptionsTabButton_Click(this, new EventArgs());
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region CaptureGameManager()
            /// <summary>
            /// This method returns the Game Manager
            /// </summary>
            private GameManager CaptureGameManager()
            {
                // initial value
                GameManager gameManager = null;
                
                // If the Table object exists
                if (this.HasTable)
                {
                    // Create the return value
                    gameManager = new GameManager(NumericHelper.ParseInteger(Properties.Resources.TimesToShuffle, 0, -1), this.Table);
                
                    // Capture the Seated Players
                    gameManager.Players = this.SelectPlayersControl.CaptureSeatedPlayers();

                    // Capture the House Rules
                    gameManager.HouseRules = this.OptionsControl.CaptureHouseRules();
                    gameManager.HouseRules.SaveSettingsOnThisComputer = this.SaveSettingsRadioButton.Checked;
                }

                // return value
                return gameManager;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // set the TopMargin & Left Margins
                this.TabHostControl.TopMargin = 16;
                this.TabHostControl.LeftMargin = 8;

                // Now Adding The TabButtons                
                int width = 200;

                // Add the tabButtons (in reverse order so they show up from left to right)
                this.OptionsTabButton = this.TabHostControl.AddTabButton(2, "Options", width, false);
                this.PlayersTabButton = this.TabHostControl.AddTabButton(1, "Players", width, true);

                // Setup the TabHostParent
                this.TabHostControl.TabHostParent = this;

                // Click the Players Tab
                this.PlayersTabButton_Click(this, new EventArgs());
            }
            #endregion
            
            #region Setup(GameManager gameManager)
            /// <summary>
            /// This method is used to setup this control.
            /// </summary>
            public void Setup(GameManager gameManager)
            {
                // store the GameManager
                this.GameManager = gameManager;

                // If the GameManager object exists
                if (this.HasGameManager)
                {
                    // Display the Players
                    this.SelectPlayersControl.DislayPlayers(this.GameManager.Players);

                    // Display the HouseRules
                    this.OptionsControl.DisplayHouseRules(this.GameManager.HouseRules);

                    // if the HouseRules exist
                    if (this.GameManager.HasHouseRules)
                    {
                        // Save Settings On This Computer
                        this.SaveSettingsRadioButton.Checked = this.GameManager.HouseRules.SaveSettingsOnThisComputer;
                    }
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

            #region GameManager
            /// <summary>
            /// This property gets or sets the value for 'GameManager'.
            /// </summary>
            public GameManager GameManager
            {
                get { return gameManager; }
                set { gameManager = value; }
            }
            #endregion
            
            #region HasGameManager
            /// <summary>
            /// This property returns true if this object has a 'GameManager'.
            /// </summary>
            public bool HasGameManager
            {
                get
                {
                    // initial value
                    bool hasGameManager = (this.GameManager != null);
                    
                    // return value
                    return hasGameManager;
                }
            }
            #endregion
            
            #region HasOptionsTabButton
            /// <summary>
            /// This property returns true if this object has an 'OptionsTabButton'.
            /// </summary>
            public bool HasOptionsTabButton
            {
                get
                {
                    // initial value
                    bool hasOptionsTabButton = (this.OptionsTabButton != null);
                    
                    // return value
                    return hasOptionsTabButton;
                }
            }
            #endregion
            
            #region HasPlayersTabButton
            /// <summary>
            /// This property returns true if this object has a 'PlayersTabButton'.
            /// </summary>
            public bool HasPlayersTabButton
            {
                get
                {
                    // initial value
                    bool hasPlayersTabButton = (this.PlayersTabButton != null);
                    
                    // return value
                    return hasPlayersTabButton;
                }
            }
            #endregion

            #region HasTable
            /// <summary>
            /// This property returns true if this object has a 'Table'.
            /// </summary>
            public bool HasTable
            {
                get
                {
                    // initial value
                    bool hasTable = (this.Table != null);
                    
                    // return value
                    return hasTable;
                }
            }
            #endregion
            
            #region HouseRules
            /// <summary>
            /// This property gets or sets the value for 'Options'.
            /// </summary>
            public Options HouseRules
            {
                get 
                {
                    // initial value
                    Options houseRules = null;

                    // If the GameManager object exists
                    if (this.HasGameManager)
                    {
                        // set the return value
                        houseRules = this.GameManager.HouseRules;
                    }

                    // return value
                    return houseRules;
                }
            }
            #endregion
            
            #region OptionsTabButton
            /// <summary>
            /// This property gets or sets the value for 'OptionsTabButton'.
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public TabButton OptionsTabButton
            {
                get { return optionsTabButton; }
                set { optionsTabButton = value; }
            }
            #endregion
            
            #region PlayersTabButton
            /// <summary>
            /// This property gets or sets the value for 'PlayersTabButton'.
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public TabButton PlayersTabButton
            {
                get { return playersTabButton; }
                set { playersTabButton = value; }
            }
            #endregion
            
            #region SelectedTab
            /// <summary>
            /// This property gets or sets the value for 'SelectedTab'.
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public TabButton SelectedTab
            {
                get { return selectedTab; }
                set { selectedTab = value; }
            }
            #endregion
            
            #region Table
            /// <summary>
            /// This property gets or sets the value for 'Table'.
            /// </summary>
            public MainForm Table
            {
                get { return table; }
                set { table = value; }
            }
            #endregion
            
            #region UserCancelled
            /// <summary>
            /// This property gets or sets the value for 'UserCancelled'.
            /// </summary>
            public bool UserCancelled
            {
                get { return userCancelled; }
                set { userCancelled = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
