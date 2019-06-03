

#region using statements

using CardCounter.UI.Forms;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Win.Controls;
using System.Windows.Forms;
using System;

#endregion

namespace CardCounter.Util
{

    #region class ChipSelectorHelper
    /// <summary>
    /// This class is used to make it simpler to show a ChipSelectorr wherever it is needed.
    /// </summary>
    public class ChipSelectorHelper
    {
        
        #region Methods

            #region ShowChipSelector(LabelTextBoxControl textBox)
            /// <summary>
            /// This method shows a ChipRack and the value is set in the LabelTextBox.Text
            /// </summary>
            /// <param name="labelTextBox"></param>
            public static void ShowChipSelector(LabelTextBoxControl textBox)
            {
                // If the textBox object exists
                if (NullHelper.Exists(textBox))
                {
                    // Create a chipSelector control
                    ChipSelectorForm chipSelectorForm = new ChipSelectorForm();

                    // Show the ChipSelectorForm
                    chipSelectorForm.ShowDialog();

                    // if the user did not cancel
                    if (!chipSelectorForm.UserCancelled)
                    {
                        // get the amount selected
                        int amountSelected = chipSelectorForm.AmountBet;

                        // set the amount selected
                        textBox.Text = "$" + String.Format("{0:n0}", amountSelected);
                        textBox.Refresh();
                    }
                }
            }
            #endregion

            #region ShowChipSelector(TextBox textBox)
            /// <summary>
            /// This method shows a ChipRack and the value is set in the TextBox.Text
            /// </summary>
            /// <param name="labelTextBox"></param>
            public static void ShowChipSelector(TextBox textBox)
            {
                // If the textBox object exists
                if (NullHelper.Exists(textBox))
                {
                    // Create a chipSelector control
                    ChipSelectorForm chipSelectorForm = new ChipSelectorForm();

                    // Show the ChipSelectorForm
                    chipSelectorForm.ShowDialog();

                    // if the user did not cancel
                    if (!chipSelectorForm.UserCancelled)
                    {
                        // get the amount selected
                        int amountSelected = chipSelectorForm.AmountBet;

                        // set the amount selected
                        textBox.Text = "$" + String.Format("{0:n0}", amountSelected);
                        textBox.Refresh();
                    }
                }
            }
            #endregion

        #endregion
        
    }
    #endregion

}
