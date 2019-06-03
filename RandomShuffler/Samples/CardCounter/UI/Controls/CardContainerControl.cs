

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
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.RandomShuffler.Enumerations;

#endregion

namespace CardCounter.UI.Controls
{

    #region class CardContainerControl
    /// <summary>
    /// This class is used to hold a series of card that are dealt.
    /// </summary>
    public partial class CardContainerControl : UserControl
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a CardContainerControl object.
        /// </summary>
        public CardContainerControl()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion

        #region Methods

            #region Clear()
            /// <summary>
            /// This method Clear
            /// </summary>
            internal void Clear()
            {
                // Hide the image
                this.CardImage1.BackgroundImage = null;
                this.CardImage1.Visible = false;
                this.CardImage2.BackgroundImage = null;
                this.CardImage2.Visible = false;
                this.CardImage3.BackgroundImage = null;
                this.CardImage3.Visible = false;
                this.CardImage4.BackgroundImage = null;
                this.CardImage4.Visible = false;
                this.CardImage5.BackgroundImage = null;
                this.CardImage5.Visible = false;
                this.CardImage6.BackgroundImage = null;
                this.CardImage6.Visible = false;
                this.CardImage7.BackgroundImage = null;
                this.CardImage7.Visible = false;
                this.CardImage8.BackgroundImage = null;
                this.CardImage8.Visible = false;
            }
            #endregion
            
            #region DisplayCards(List<Card> cards)
            /// <summary>
            /// This method displays a list of Cards
            /// </summary>
            internal void DisplayCards(List<Card> cards)
            {
                // locals
                PictureBox cardPictureBox = null;
                int cardNumber = 0;
                Image cardImage = null;

                // Clear any cards just to make sure nothing is visible
                this.Clear();

                // If the cards collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(cards))
                {
                    // Show this control so the cards show up
                    this.Visible = true;

                    // Iterate the collection of Card objects
                    foreach (Card card in cards)
                    {
                        // Increment the value for cardNumber
                        cardNumber++;

                        // Find the PictureBox for this cardNumber
                        cardPictureBox = FindCardPictureBox(cardNumber);

                        // If the cardPictureBox object exists
                        if (NullHelper.Exists(cardPictureBox))
                        {
                            // Find the image for this card
                            cardImage = FindCardImage(card);

                            // If the cardImage object exists
                            if (NullHelper.Exists(cardImage))
                            {
                                // set the BackgroundImage
                                cardPictureBox.BackgroundImage = cardImage;

                                // Show this image
                                cardPictureBox.Visible = true;
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region FindCardImage(Card card)
            /// <summary>
            /// This method returns the Card Image
            /// </summary>
            private Image FindCardImage(Card card)
            {
                // initial value
                Bitmap cardImage = null;

                // If the card object exists
                if (NullHelper.Exists(card))
                {
                    // determine the cardImage by the cardName
                    switch (card.CardFullName)
                    {
                        case "AceClubs":

                            // set the return value
                            cardImage = Properties.Resources.AceClubs;

                            // required
                            break;

                        case "AceDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.AceDiamonds;

                            // required
                            break;

                        case "AceHearts":

                            // set the return value
                            cardImage = Properties.Resources.AceHearts;

                            // required
                            break;

                        case "AceSpades":

                            // set the return value
                            cardImage = Properties.Resources.AceSpades;

                            // required
                            break;

                        case "TwoClubs":

                            // set the return value
                            cardImage = Properties.Resources.TwoClubs;

                            // required
                            break;

                        case "TwoDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.TwoDiamonds;

                            // required
                            break;

                        case "TwoHearts":

                            // set the return value
                            cardImage = Properties.Resources.TwoHearts;

                            // required
                            break;

                        case "TwoSpades":

                            // set the return value
                            cardImage = Properties.Resources.TwoSpades;

                            // required
                            break;

                        case "ThreeClubs":

                            // set the return value
                            cardImage = Properties.Resources.ThreeClubs;

                            // required
                            break;

                        case "ThreeDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.ThreeDiamonds;

                            // required
                            break;

                        case "ThreeHearts":

                            // set the return value
                            cardImage = Properties.Resources.ThreeHearts;

                            // required
                            break;

                        case "ThreeSpades":

                            // set the return value
                            cardImage = Properties.Resources.ThreeSpades;

                            // required
                            break;

                        case "FourClubs":

                            // set the return value
                            cardImage = Properties.Resources.FourClubs;

                            // required
                            break;

                        case "FourDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.FourDiamonds;

                            // required
                            break;

                        case "FourHearts":

                            // set the return value
                            cardImage = Properties.Resources.FourHearts;

                            // required
                            break;

                        case "FourSpades":

                            // set the return value
                            cardImage = Properties.Resources.FourSpades;

                            // required
                            break;

                        case "FiveClubs":

                            // set the return value
                            cardImage = Properties.Resources.FiveClubs;

                            // required
                            break;

                        case "FiveDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.FiveDiamonds;

                            // required
                            break;

                        case "FiveHearts":

                            // set the return value
                            cardImage = Properties.Resources.FiveHearts;

                            // required
                            break;

                        case "FiveSpades":

                            // set the return value
                            cardImage = Properties.Resources.FiveSpades;

                            // required
                            break;

                        case "SixClubs":

                            // set the return value
                            cardImage = Properties.Resources.SixClubs;

                            // required
                            break;

                        case "SixDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.SixDiamonds;

                            // required
                            break;

                        case "SixHearts":

                            // set the return value
                            cardImage = Properties.Resources.SixHearts;

                            // required
                            break;

                        case "SixSpades":

                            // set the return value
                            cardImage = Properties.Resources.SixSpades;

                            // required
                            break;

                        case "SevenClubs":

                            // set the return value
                            cardImage = Properties.Resources.SevenClubs;

                            // required
                            break;

                        case "SevenDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.SevenDiamonds;

                            // required
                            break;

                        case "SevenHearts":

                            // set the return value
                            cardImage = Properties.Resources.SevenHearts;

                            // required
                            break;

                        case "SevenSpades":

                            // set the return value
                            cardImage = Properties.Resources.SevenSpades;

                            // required
                            break;

                        case "EightClubs":

                            // set the return value
                            cardImage = Properties.Resources.EightClubs;

                            // required
                            break;

                        case "EightDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.EightDiamonds;

                            // required
                            break;

                        case "EightHearts":

                            // set the return value
                            cardImage = Properties.Resources.EightHearts;

                            // required
                            break;

                        case "EightSpades":

                            // set the return value
                            cardImage = Properties.Resources.EightSpades;

                            // required
                            break;

                        case "NineClubs":

                            // set the return value
                            cardImage = Properties.Resources.NineClubs;

                            // required
                            break;

                        case "NineDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.NineDiamonds;

                            // required
                            break;

                        case "NineHearts":

                            // set the return value
                            cardImage = Properties.Resources.NineHearts;

                            // required
                            break;

                        case "NineSpades":

                            // set the return value
                            cardImage = Properties.Resources.NineSpades;

                            // required
                            break;

                        case "TenClubs":

                            // set the return value
                            cardImage = Properties.Resources.TenClubs;

                            // required
                            break;

                        case "TenDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.TenDiamonds;

                            // required
                            break;

                        case "TenHearts":

                            // set the return value
                            cardImage = Properties.Resources.TenHearts;

                            // required
                            break;

                        case "TenSpades":

                            // set the return value
                            cardImage = Properties.Resources.TenSpades;

                            // required
                            break;

                        case "JackClubs":

                            // set the return value
                            cardImage = Properties.Resources.JackClubs;

                            // required
                            break;

                        case "JackDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.JackDiamonds;

                            // required
                            break;

                        case "JackHearts":

                            // set the return value
                            cardImage = Properties.Resources.JackHearts;

                            // required
                            break;

                        case "JackSpades":

                            // set the return value
                            cardImage = Properties.Resources.JackSpades;

                            // required
                            break;

                        case "QueenClubs":

                            // set the return value
                            cardImage = Properties.Resources.QueenClubs;

                            // required
                            break;

                        case "QueenDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.QueenDiamonds;

                            // required
                            break;

                        case "QueenHearts":

                            // set the return value
                            cardImage = Properties.Resources.QueenHearts;

                            // required
                            break;

                        case "QueenSpades":

                            // set the return value
                            cardImage = Properties.Resources.QueenSpades;

                            // required
                            break;

                        case "KingClubs":

                            // set the return value
                            cardImage = Properties.Resources.KingClubs;

                            // required
                            break;

                        case "KingDiamonds":

                            // set the return value
                            cardImage = Properties.Resources.KingDiamonds;

                            // required
                            break;

                        case "KingHearts":

                            // set the return value
                            cardImage = Properties.Resources.KingHearts;

                            // required
                            break;

                        case "KingSpades":

                            // set the return value
                            cardImage = Properties.Resources.KingSpades;

                            // required
                            break;

                    }
                }

                // return value
                return cardImage;
            }
            #endregion
            
            #region FindCardPictureBox(int cardNumber)
            /// <summary>
            /// This method returns the Card Picture Box
            /// </summary>
            private PictureBox FindCardPictureBox(int cardNumber)
            {
                // initial value
                PictureBox cardPictureBox = null;

                // Determine the action by the cardNumber
                switch (cardNumber)
                {
                    case 1:

                        // Set the return value
                        cardPictureBox = CardImage1;

                        // required
                        break;

                    case 2:

                        // Set the return value
                        cardPictureBox = CardImage2;

                        // required
                        break;

                    case 3:

                        // Set the return value
                        cardPictureBox = CardImage3;

                        // required
                        break;

                    case 4:

                        // Set the return value
                        cardPictureBox = CardImage4;

                        // required
                        break;

                    case 5:

                        // Set the return value
                        cardPictureBox = CardImage5;

                        // required
                        break;

                    case 6:

                        // Set the return value
                        cardPictureBox = CardImage6;

                        // required
                        break;

                    case 7:

                        // Set the return value
                        cardPictureBox = CardImage7;

                        // required
                        break;

                    case 8:

                        // Set the return value
                        cardPictureBox = CardImage8;

                        // required
                        break;
                }

                // return value
                return cardPictureBox;
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
