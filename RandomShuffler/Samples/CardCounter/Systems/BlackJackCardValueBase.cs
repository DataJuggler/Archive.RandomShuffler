using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.Core.RandomShuffler.Interfaces;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.RandomShuffler.Objects;
using DataJuggler.Core.RandomShuffler.Enumerations;

namespace CardCounter.Systems
{

    #region BlackJackCardValueBase : ICardValueManager
    /// <summary>
    /// This class is used to create the values for the cards without being tied to a Counting System
    /// </summary>
    public class BlackJackCardValueBase : ICardValueManager
    {

        #region Private Variables
        // The Default Initial Count is 0
        internal const double DefaultInitialCount = 0;
        // Low cards are all 1
        private const double DefaultCountValueOfTwo = 1;
        private const double DefaultCountValueOfThree = 1;
        private const double DefaultCountValueOfFour = 1;
        private const double DefaultCountValueOfFive = 1;
        private const double DefaultCountValueOfSix = 1;
        private const double DefaultCountValueOfSeven = 0;
        private const double DefaultCountValueOfEight = 0;
        private const double DefaultCountValueOfNine = 0;
        // high cards are all -1
        private const double DefaultCountValueOfTenJackQueenKing = -1;
        private const double DefaultCountValueOfAce = -1;
        private const int LowValueOfAce = 1;
        private const int HighValueOfAce = 11;
        private const int DefaultValueOfTenJackQueenKing = 10;
        #endregion
        
        #region Methods

            #region GetCardValue(Card card, int currentValue = 0)
            /// <summary>
            /// This method returns the card value based upon the current ICardValueManager.
            /// This is the value of the card for the game of black jack; not the value of the 
            /// card for the counting system. That is known as the CountValue of a card.
            /// Call the GetCountValue(Card) to get the count value.
            /// </summary>
            /// <param name="card"></param>
            /// <returns></returns>
            public int GetCardValue(Card card, int currentValue = 0)
            {
                // initial value
                int cardValue = 0;

                // if the card exists
                if (NullHelper.Exists(card))
                {
                    // Determine the return value by the CardName
                    switch (card.CardName)
                    {
                        case CardEnum.Ace:

                            // if the value is already 11
                            if (currentValue >= 11)
                            {
                                // use 1
                                cardValue = LowValueOfAce;
                            }
                            else
                            {
                                // Use 11
                                cardValue = HighValueOfAce;
                            }

                            // required
                            break;

                        case CardEnum.Ten:
                        case CardEnum.Jack:
                        case CardEnum.Queen:
                        case CardEnum.King:
                            
                            // set the card value
                            cardValue = DefaultValueOfTenJackQueenKing;

                            // required
                            break;

                        default:

                            // set the value to the value of the card
                            cardValue = (int) card.CardName;

                            // required
                            break;
                    }
                }    

                // return value
                return cardValue;
            }
            #endregion

            #region GetCardValues(Card card, int currentValue = 0)
            /// <summary>
            /// This method returns the card value based upon the current ICardValueManager.
            /// This is the value of the card for the game of black jack; not the value of the 
            /// card for the counting system. That is known as the CountValue of a card.
            /// Call the GetCountValue(Card) to get the count value.
            /// </summary>
            /// <param name="card"></param>
            /// <returns></returns>
            public List<int> GetCardValues(Card card)
            {
                // initial value
                List<int> cardValues = new List<int>();

                // if the card exists
                if (NullHelper.Exists(card))
                {
                    // Determine the return value by the CardName
                    switch (card.CardName)
                    {
                        case CardEnum.Ace:

                            // Add the low value of Ace
                            cardValues.Add(LowValueOfAce);
                            cardValues.Add(HighValueOfAce);

                            // required
                            break;

                        default:

                            // get the cardValue
                            int cardValue = GetCardValue(card, 0);

                            // Add this value
                            cardValue.CompareTo(cardValue);

                            // required
                            break;
                    }
                }

                // return value
                return cardValues;
            }
            #endregion

        #endregion

    }
    #endregion

}
