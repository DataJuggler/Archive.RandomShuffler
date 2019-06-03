

#region using statements

using System;
using System.Windows.Forms;
using CardCounter.UI.Forms;

#endregion

namespace CardCounter
{

    #region class Program
    /// <summary>
    /// This class is the entry point for this program.
    /// </summary>
    static class Program
    {
        
        #region Methods
            
            #region Main
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
