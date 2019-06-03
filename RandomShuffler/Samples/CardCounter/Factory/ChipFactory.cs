

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CardCounter.Enumerations;
using DataJuggler.Core.UltimateHelper;
using CardCounter.UI.Controls;
using CardCounter.Objects;

#endregion

namespace CardCounter.Factory
{

    #region class ChipFactory
    /// <summary>
    /// This class is used to create Chip picture boxes in 
    /// denominations that add up to the chipAmount.
    /// </summary>
    public class ChipFactory
    {
        
        #region Private Variables
        private const int ChipSize = 24;
        #endregion
        
        #region Methods
            
            #region AddChips(List<ChipImage> chips, ChipEnum chip, ref double amount)
            /// <summary>
            /// This method returns the Chips
            /// </summary>
            private static List<ImageEx> AddChips(List<ImageEx> chips, ChipEnum chip, ref double amount)
            {
                // local
                int chipValue = 0;

                // If the chips object exists
                if ((NullHelper.Exists(chips)) && (chip != ChipEnum.Unknown) && (amount > 0))
                {
                    // get the chipValue
                    chipValue = (int) chip;

                    // if the amount is greater than this chip
                    if (amount >= chipValue)
                    {
                        do
                        {
                            // Create the image based upo the chip type
                            Image chipPic = new Bitmap(GetChipImage(chip), new Size(24, 24));
                            
                            // Cast the chipImage as an ImageEx
                            ImageEx chipImage = new ImageEx(chipPic);
                            
                            // Ad this image
                            chips.Add(chipImage);
                            
                            // subtract the value of htis chip from amount
                            amount -= chipValue;

                        } while (amount >= chipValue);
                    }
                }

                // return value
                return chips;
            }
            #endregion
            
            #region GetChipImage(ChipEnum chip)
            /// <summary>
            /// This method returns the Chip Image
            /// </summary>
            internal static Image GetChipImage(ChipEnum chip)
            {
                // initial value
                Image chipImage = null;

                switch (chip)
                {
                    case ChipEnum.WhiteChip:

                        // set the image
                        chipImage = Properties.Resources.WhiteChip;
                        
                        // required
                        break;

                    case ChipEnum.RedChip:

                        // set the image
                        chipImage = Properties.Resources.RedChip;

                        // required
                        break;

                    case ChipEnum.GreenChip:

                        // set the image
                        chipImage = Properties.Resources.GreenChip;

                        // required
                        break;

                    case ChipEnum.BlackChip:

                        // set the image
                        chipImage = Properties.Resources.BlackChip;

                        // required
                        break;

                    case ChipEnum.PurpleChip:

                        // set the image
                        chipImage = Properties.Resources.PurpleChip;

                        // required
                        break;

                    case ChipEnum.GoldChip:

                        // set the image
                        chipImage = Properties.Resources.GoldChip;

                        // required
                        break;
                }

                // return value
                return chipImage;
            }
            #endregion
            
            #region GetChipImages(double amount)
            /// <summary>
            /// This method returns a list of images that need to be added to the table in front of the player
            /// to simulate either a bet, a double down or split, or a bet pay off if you win.
            /// </summary>
            /// <param name="amountBet"></param>
            /// <returns></returns>
            public static List<ImageEx> GetChipImages(double amount)
            {
                // create the chips collection
                List<ImageEx> chips = new List<ImageEx>();

                // Get the chips
                chips = AddChips(chips, ChipEnum.GoldChip, ref amount);
                chips = AddChips(chips, ChipEnum.PurpleChip, ref amount);
                chips = AddChips(chips, ChipEnum.BlackChip, ref amount);
                chips = AddChips(chips, ChipEnum.GreenChip, ref amount);
                chips = AddChips(chips, ChipEnum.RedChip, ref amount);
                chips = AddChips(chips, ChipEnum.WhiteChip, ref amount);

                // return value
                return chips;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
