

#region using statements

using System.Windows.Forms;

#endregion

namespace CardCounter.UI.Forms
{

    #region class HelpForm
    /// <summary>
    /// This class is used to host the Counting System Viewer Control.
    /// </summary>
    public partial class HelpForm : Form
    {
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a HelpForm object.
        /// </summary>
        public HelpForm()
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

        #endregion
        
    }
    #endregion

}
