

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardCounter.Interfaces;
using CardCounter.Objects;
using CardCounter.Systems;
using CardCounter.Factory;
using DataJuggler.Core.UltimateHelper;

#endregion

namespace CardCounter.UI.Controls
{

    #region class CountingSystemViewerControl
    /// <summary>
    /// This class serves two purposes. First is used to help players learn about
    /// counting systems, but also it gives you away to view the values from
    /// each each engine to make sure they were implemented property.
    /// </summary>
    public partial class CountingSystemViewerControl : UserControl
    {
        
        #region Private Variables
        private const string WikipediaCardCountingSystemArticle = "http://en.wikipedia.org/wiki/Card_counting";
        private const string BlackJackCOZACountingSystemArticle = "http://blackjack.co.za/card-counting/";
        private Image headerImage;
        private bool linkColumnAdded;
        private List<CountingSystemView> countingSystems;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of an CountingSystemViewerControl
        /// </summary>
        public CountingSystemViewerControl()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion

        #region Events
            
            #region BlackJackCOZALinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            /// <summary>
            /// This event is fired when Black Jack COZA Link Button _ Link Clicked
            /// </summary>
            private void BlackJackCOZALinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                // Send the user to the link
                System.Diagnostics.Process.Start(BlackJackCOZACountingSystemArticle);
            }
            #endregion
            
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
            
            #region CountingSystemViewerControl_Load(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Counting System Viewer Control _ Load
            /// </summary>
            private void CountingSystemViewerControl_Load(object sender, EventArgs e)
            {
                // Now load the grid
                Init();
            }
            #endregion
            
            #region DoneButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'DoneButton' is clicked.
            /// </summary>
            private void DoneButton_Click(object sender, EventArgs e)
            {
                // if the ParentForm exists
                if (NullHelper.Exists(this.ParentForm))
                {
                    // Close the form that this control is hosted on
                    this.ParentForm.Close();    
                }
            }
            #endregion
            
            #region DoneButton_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Done Button _ Mouse Leave
            /// </summary>
            private void DoneButton_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
            /// <summary>
            /// This event is fired when Grid _ Cell Content Click
            /// </summary>
            private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                // Get the columnIndex
                int columnIndex = e.ColumnIndex;

                // if this is the LinkButton
                if (e.ColumnIndex == 0)
                {
                    // we must get the name of the selected System
                    string systemName = FindSystemName(e.RowIndex);

                    // If the systemName string exists
                    if (TextHelper.Exists(systemName))
                    {
                        // Find this system
                        ICardCountingSystem selectedSystem = CardCountingSystemFactory.FindCardCountingSystem(systemName);

                        // If the selectedSystem object exists
                        if (NullHelper.Exists(selectedSystem))
                        {
                            // get the helpLink
                            string helpLink = selectedSystem.HelpLink;

                            // if the helpLink exists
                            if (TextHelper.Exists(helpLink))
                            {
                                // Open a browser wined                                                                                   
                                System.Diagnostics.Process.Start(helpLink);
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            /// <summary>
            /// This event is fired when Grid _ Cell Formatting
            /// </summary>
            private void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
            {
                // if this is the System column
                if (this.Grid.Columns[e.ColumnIndex].HeaderText == "System")
                {
                    // get the current rowIndex
                    int rowIndex = e.RowIndex;

                    // Find the SystemName for thisRow
                    string systemName = FindSystemName(rowIndex);

                    // test only
                    e.Value = systemName;
                }
            }
            #endregion
            
            #region Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            /// <summary>
            /// This event is fired when Grid _ Data Binding Complete
            /// </summary>
            private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
            {
                // locals
                int colWidth = 37;
                int largeColWidth =140;
                int levelWidth = 84;
                
                // Add the LinkColumn
                AddLinkColumn();

                // if there are at least 7 items
                if (this.Grid.Columns.Count >= 14)
                {
                    // before values
                    string nameColumn = this.Grid.Columns[6].Name;
                    string systemColumn = this.Grid.Columns[14].Name;

                    // if this is the name column already
                    if (systemColumn == String.Empty)
                    {
                        // Set the Name property as Reflection misses a Name called Name it looks like.
                        this.Grid.Columns[6].Name = "Name";
                        this.Grid.Columns[14].Name = "System";
                    }

                    // after values for testing
                    nameColumn = this.Grid.Columns[6].Name;
                    systemColumn = this.Grid.Columns[14].Name;
                }

                // Set the Font
                float size = 11F;
                Grid.Font = new System.Drawing.Font("Verdana", size);

                // Set the SelectionMode
                Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Hide the RowSelector
                Grid.RowHeadersVisible = false;

                // Change the Name to be the first column
                Grid.Columns["Name"].Visible = false;
                Grid.Columns["System"].DisplayIndex = 0;
                Grid.Columns["Level"].DisplayIndex = 1;
                Grid.Columns["Balanced"].DisplayIndex = 2;
                Grid.Columns["Two"].DisplayIndex = 3;
                Grid.Columns["Three"].DisplayIndex = 4;
                Grid.Columns["Four"].DisplayIndex = 5;
                Grid.Columns["Five"].DisplayIndex = 6;
                Grid.Columns["Six"].DisplayIndex = 7;
                Grid.Columns["Seven"].DisplayIndex = 8;
                Grid.Columns["Eight"].DisplayIndex = 9;
                Grid.Columns["Nine"].DisplayIndex = 10;
                Grid.Columns["Ten"].DisplayIndex = 11;
                Grid.Columns["Ace"].DisplayIndex = 12;
                Grid.Columns["Notes"].DisplayIndex = 13;

                // Now set the column widths
                Grid.Columns["Level"].Width = levelWidth;
                Grid.Columns["Balanced"].Width = colWidth;
                Grid.Columns["Two"].Width = colWidth;
                Grid.Columns["Three"].Width = colWidth;
                Grid.Columns["Four"].Width = colWidth;
                Grid.Columns["Five"].Width = colWidth;
                Grid.Columns["Six"].Width = colWidth;
                Grid.Columns["Seven"].Width = colWidth;
                Grid.Columns["Eight"].Width = colWidth;
                Grid.Columns["Nine"].Width = colWidth;
                Grid.Columns["Ten"].Width = colWidth;
                Grid.Columns["Ace"].Width = colWidth;
                Grid.Columns["Notes"].Width = largeColWidth;

                // Change the Captions
                Grid.Columns["Balanced"].HeaderText = "Bal";
                Grid.Columns["Two"].HeaderText = "2";
                Grid.Columns["Three"].HeaderText = "3";
                Grid.Columns["Four"].HeaderText = "4";
                Grid.Columns["Five"].HeaderText = "5";
                Grid.Columns["Six"].HeaderText = "6";
                Grid.Columns["Seven"].HeaderText = "7";
                Grid.Columns["Eight"].HeaderText = "8";
                Grid.Columns["Nine"].HeaderText = "9";
                Grid.Columns["Ten"].HeaderText = "10";
                Grid.Columns["Ace"].HeaderText = "A";

                // Center the Headers
                Grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Center the text for the value columns
                Grid.Columns["Two"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Three"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Four"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Five"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Six"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Seven"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Eight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Nine"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Ten"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                Grid.Columns["Ace"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                
                // Change the selected style
                Grid.DefaultCellStyle.SelectionBackColor = Color.LemonChiffon;
                Grid.DefaultCellStyle.SelectionForeColor = Color.Black;
                Grid.AllowUserToResizeRows = false;

                // Set the Height of the Header
                Grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                Grid.ColumnHeadersHeight = 30;

                // Remove the first row from being selected
                Grid.ClearSelection();
            }
            #endregion
            
            #region WikipediaLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            /// <summary>
            /// This event is fired when Wikipedia Link Button _ Link Clicked
            /// </summary>
            private void WikipediaLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                // Send the user to the link
                System.Diagnostics.Process.Start(WikipediaCardCountingSystemArticle);
            }
            #endregion

        #endregion

        #region Methods

            #region AddLinkColumn()
            /// <summary>
            /// This method adds a link column to the Grid
            /// </summary>
            private void AddLinkColumn()
            {
                // if the LinkColumn has not been added yet
                if (!this.LinkColumnAdded)
                {
                    // Create a new instance of a 'DataGridViewLinkColumn' object.
                    DataGridViewLinkColumn systemNameLink = new DataGridViewLinkColumn();

                    // Format
                    systemNameLink.UseColumnTextForLinkValue = true;
                    systemNameLink.HeaderText = "System";
                    systemNameLink.ActiveLinkColor = Color.Navy;
                    systemNameLink.LinkBehavior = LinkBehavior.AlwaysUnderline;
                    systemNameLink.LinkColor = Color.Blue;
                    systemNameLink.TrackVisitedState = false;
                    systemNameLink.DisplayIndex = 0;
                    systemNameLink.Width = 140;
                    systemNameLink.Visible = true;

                    // Add this column
                    this.Grid.Columns.Add(systemNameLink);

                    // Set to true
                    this.LinkColumnAdded = true;
                }
            }
            #endregion

            #region FindColumnIndex(string columnName)
            /// <summary>
            /// This method returns the Column Index
            /// </summary>
            private int FindColumnIndex(string columnName)
            {
                // initial value
                int columnIndex = -1;

                // get the value of the 7th column
                for (int x = 0; x < this.Grid.Columns.Count; x++)
                {
                    // set the columnName
                    string tempColumnName = Grid.Columns[x].HeaderText;

                    // output test
                    if (TextHelper.Exists(tempColumnName))
                    {
                        // if this is the field being sought
                        if (TextHelper.IsEqual(tempColumnName, columnName))
                        {
                            // set the return value
                            columnIndex = x;

                            // break out of the loop
                            break;
                        }
                    }
                }

                // return value
                return columnIndex;
            }
            #endregion
            
            #region FindSystemName(int rowIndex)
            /// <summary>
            /// This method returns the System Name
            /// </summary>
            private string FindSystemName(int rowIndex)
            {
                // initial value
                string systemName = "";

                try
                {
                    // local
                    string columnName = "Name";

                    // find the NameColumnIndex
                    int nameColumnIndex = FindColumnIndex(columnName);

                    // if the nameColumnIndex was found
                    if (nameColumnIndex >= 0)
                    {
                        // set the systemName
                        systemName = (string)Grid.Rows[rowIndex].Cells[nameColumnIndex].Value;
                    }
                }
                catch (Exception error)
                {
                    // for debugging only
                    string err = error.ToString();
                }

                // return value
                return systemName;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Do not allow edits
                this.Grid.ReadOnly = true;

                // Create the HeaderImage
                this.HeaderImage = Properties.Resources.DeepGray;

                // Create the countingSystemsList
                List<ICardCountingSystem> countingSystemsList = CardCountingSystemFactory.LoadCardCountingSystems();

                // convert the list of countingSystems
                this.CountingSystems = CountingSystemViewFactory.Convert(countingSystemsList);

                // Set the Column Header Height
                Grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.LemonChiffon;

                // Size the Height of the Rows
                Grid.RowTemplate.Height = 30;
                Grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

                // Set the DataSource
                this.Grid.DataSource = countingSystems;
            }
            #endregion
            
        #endregion

        #region Properties

            #region CountingSystems
            /// <summary>
            /// This property gets or sets the value for 'CountingSystems'.
            /// </summary>
            public List<CountingSystemView> CountingSystems
            {
                get { return countingSystems; }
                set { countingSystems = value; }
            }
            #endregion
                        
            #region HasCountingSystems
            /// <summary>
            /// This property returns true if this object has a 'CountingSystems'.
            /// </summary>
            public bool HasCountingSystems
            {
                get
                {
                    // initial value
                    bool hasCountingSystems = (this.CountingSystems != null);
                    
                    // return value
                    return hasCountingSystems;
                }
            }
            #endregion
            
            #region HasHeaderImage
            /// <summary>
            /// This property returns true if this object has a 'HeaderImage'.
            /// </summary>
            public bool HasHeaderImage
            {
                get
                {
                    // initial value
                    bool hasHeaderImage = (this.HeaderImage != null);
                    
                    // return value
                    return hasHeaderImage;
                }
            }
            #endregion
            
            #region HeaderImage
            /// <summary>
            /// This property gets or sets the value for 'HeaderImage'.
            /// </summary>
            public Image HeaderImage
            {
                get { return headerImage; }
                set { headerImage = value; }
            }
            #endregion
            
            #region LinkColumnAdded
            /// <summary>
            /// This property gets or sets the value for 'LinkColumnAdded'.
            /// </summary>
            public bool LinkColumnAdded
            {
                get { return linkColumnAdded; }
                set { linkColumnAdded = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
