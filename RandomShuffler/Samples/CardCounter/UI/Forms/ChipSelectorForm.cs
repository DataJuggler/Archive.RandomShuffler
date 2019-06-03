

#region using statements

using System.Windows.Forms;

#endregion

namespace CardCounter.UI.Forms
{

    #region class ChipSelectorForm
    /// <summary>
    /// This class is used to host the Chip Selector Control which is used to select chips amounts
    /// for bets or starting bankrolls.
    /// </summary>
    public partial class ChipSelectorForm : Form
    {
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a ChipSelectorForm
        /// </summary>
        public ChipSelectorForm()
        {
            // Create Controls
            InitializeComponent();
        }
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

            #region AmountBet
            /// <summary>
            /// This property gets or sets the value for 'AmountSelected'.
            /// </summary>
            public int AmountBet
            {
                get
                {
                    // initial value
                    int amountBet = 0;

                    // if the control exists
                    if (ChipSelectorControl != null)
                    {
                        // set the return value
                        amountBet = (int) ChipSelectorControl.AmountBet;
                    }

                    // return value
                    return amountBet;
                }
                set
                {
                    // if the control exists
                    if (ChipSelectorControl != null)
                    {        
                        // set the value
                        ChipSelectorControl.AmountBet = value;
                    }
                }
            }
            #endregion

            #region UserCancelled
            /// <summary>
            /// This property gets or sets the value for 'UserCancelled'.
            /// </summary>
            public bool UserCancelled
            {
                get
                {
                    // initial value
                    bool userCancelled = false;

                    // if the control exists
                    if (ChipSelectorControl != null)
                    {
                        // set the return value
                        userCancelled = (bool)ChipSelectorControl.UserCancelled;
                    }

                    // return value
                    return userCancelled;
                }
                set
                {
                    // if the control exists
                    if (ChipSelectorControl != null)
                    {
                        // set the value
                        ChipSelectorControl.UserCancelled = value;
                    }
                }
            }
            #endregion

        #endregion
        
    }
    #endregion

}
