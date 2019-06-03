

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

#endregion

namespace CardCounter
{

    #region class CountControl
    /// <summary>
    /// This control is used to contain the Selected counting system and to display the count and to offer quizes.
    /// </summary>
    public partial class CountControl : UserControl
    {
        
        #region Private Variables
        private ICardCountingSystem selectedSystem;
        private List<ICardCountingSystem> allSystems;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'CountControl' object.
        /// </summary>
        public CountControl()
        {
            // Create Controls
            InitializeComponent();
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
            
            #region GuessButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'GuessButton' is clicked.
            /// </summary>
            private void GuessButton_Click(object sender, EventArgs e)
            {
                
            }
            #endregion
            
        #endregion
        
        #region Methods

        #endregion

        #region Properties

            #region AllSystems
            /// <summary>
            /// This property gets or sets the value for 'AllSystems'.
            /// </summary>
            public List<ICardCountingSystem> AllSystems
            {
                get { return allSystems; }
                set { allSystems = value; }
            }
            #endregion
            
            #region SelectedSystem
            /// <summary>
            /// This property gets or sets the value for 'SelectedSystem'.
            /// </summary>
            public ICardCountingSystem SelectedSystem
            {
                get { return selectedSystem; }
                set { selectedSystem = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
