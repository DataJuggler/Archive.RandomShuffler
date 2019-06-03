

#region using statements

using CardCounter.Enumerations;
using CardCounter.Objects;
using CardCounter.Interfaces;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace CardCounter.UI.Controls
{

    #region class CardCounterControl
    /// <summary>
    /// This control is used to let the user select which counting system they want to use, and options to show the
    /// count or hide it, and it set QuizMode or not.
    /// </summary>
    public partial class CardCounterControl : UserControl
    {
        
        #region Private Variables
        private List<CountingSystemView> countingSystems;
        private CountingSystemView selectedCountingSystem;
        private int count;
        private bool showCount;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CardCounterControl' object.
        /// </summary>
        public CardCounterControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region QuizButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'QuizButton' is clicked.
            /// </summary>
            private void QuizButton_Click(object sender, EventArgs e)
            {
                
            }
            #endregion
            
            #region ShowButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ShowButton' is clicked.
            /// </summary>
            private void ShowButton_Click(object sender, EventArgs e)
            {
                // Toggle the value
                ShowCount = !ShowCount;

                // Setup the UserInterface based upon ShowCount
                UIControl();
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Load the systems
                List<ICardCountingSystem> systems = Factory.CardCountingSystemFactory.LoadCardCountingSystems();

                // Load the combobox
                SystemControl.LoadItems(systems);

                // Default to true
                ShowCount = true;
            }
            #endregion
            
            #region UIControl()
            /// <summary>
            /// This method UI Control
            /// </summary>
            public void UIControl()
            {
                // if ShowCount is true
                if (ShowCount)
                {
                    // Show the Count Label
                    CountLabel.Visible = true;

                    // Change the text to Hide
                    ShowButton.Text = "Hide";
                }
                else
                {
                    // Show the Count Label
                    CountLabel.Visible = true;

                    // Change the text to Hide
                    ShowButton.Text = "false";
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region Count
            /// <summary>
            /// This property gets or sets the value for 'Count'.
            /// </summary>
            public int Count
            {
                get { return count; }
                set 
                { 
                    // set the value
                    count = value;

                    // Display the Count, even if the label is not visible
                    CountLabel.Text = value.ToString();
                }
            }
            #endregion
            
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
            
            #region SelectedCountingSystem
            /// <summary>
            /// This property gets or sets the value for 'SelectedCountingSystem'.
            /// </summary>
            public CountingSystemView SelectedCountingSystem
            {
                get { return selectedCountingSystem; }
                set { selectedCountingSystem = value; }
            }
        #endregion

            #region ShowCount
            /// <summary>
            /// This property gets or sets the value for 'ShowCount'.
            /// </summary>
            public bool ShowCount
            {
                get { return showCount; }
                set { showCount = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
