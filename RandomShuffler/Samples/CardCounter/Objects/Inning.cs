

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardCounter.Enumerations;
using DataJuggler.Core.UltimateHelper;

#endregion

namespace CardCounter.Objects
{

    #region class Inning
    /// <summary>
    /// This class represents 1 hand of BlackJack being dealt to a dealer and all seated players.
    /// </summary>
    public class Inning
    {
        
        #region Private Variables
        private List<Hand> hands;
        private int number;
        #endregion

        #region Default Constructor
        /// <summary>
        /// Create a new instance of an Inning object.
        /// </summary>
        public Inning()
        {
            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods
            
            #region GetHand(SeatNumberEnum seatNumber)
            /// <summary>
            /// This method returns the hand for the SeatNumber given.
            /// If there is not a player seated at this seat or if he is sitting
            /// out this hand may return null so always test it exists before
            /// reffering to it.
            /// </summary>
            /// <param name="seatNumber"></param>
            /// <returns></returns>
            public Hand GetHand(SeatNumberEnum seatNumber)
            {
                // initial value
                Hand hand = null;

                // If the Hands object exists
                if (this.HasHands)
                {
                    // iterate the hands collection                    
                    foreach (Hand tempHand in this.Hands)
                    {
                        // If the value for the property tempHand.HasPlayer is true
                        if (tempHand.HasPlayer)
                        {
                            // if this is the SeatNumber given
                            if (tempHand.Player.SeatNumber == seatNumber)
                            {
                                // set the return value
                                hand = tempHand;

                                // break out of the loop
                                break;
                            }
                        }
                    }
                }

                // return value
                return hand;
            }
            #endregion

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create a new collection of 'Hand' objects.
                this.Hands = new List<Hand>();
            }
            #endregion
            
        #endregion

        #region Properties

            #region AllPlayersActionComplete
            /// <summary>
            /// This read only property returns true if all players hands have completed their action.
            /// </summary>
            public bool AllPlayersActionComplete
            {
                get
                {
                    // initial value
                    bool allPlayersActionComplete = false;

                    // local
                    int countCompleted = 0;

                    // if the Hands collection exists
                    if (ListHelper.HasOneOrMoreItems(this.Hands))
                    {
                        // iterate the Hands
                        foreach (Hand hand in this.Hands)
                        {
                            // if this hand has completed the PlayerAction
                            if (hand.PlayerActionComplete)
                            {
                                // Increment the value for countCompleted
                                countCompleted++;
                            }
                        }

                        // if all hands have completed return true
                        allPlayersActionComplete = (countCompleted == this.Hands.Count);
                    }
                    else
                    {
                        // there are no hands, so yes
                        allPlayersActionComplete = true;
                    }

                    // return value
                    return allPlayersActionComplete;
                }
            }
            #endregion

            #region CardsDealt
            /// <summary>
            /// This read only property returns the number of cards that have already been dealt.
            /// </summary>
            public int CardsDealt
            {
                get
                {
                    // initial value
                    int cardsDealt = 0;

                    // if their is any DeckHistory available
                    if (ListHelper.HasOneOrMoreItems(this.Hands))
                    {
                        // iterate the innings                        
                        foreach (Hand hand in this.Hands)
                        {
                            // get the CardsDealt
                            cardsDealt += hand.Cards.Count;
                        }
                    }

                    // return value
                    return cardsDealt;
                }
            }
            #endregion

            #region Hands
            /// <summary>
            /// This property gets or sets the value for 'Hands'.
            /// </summary>
            public List<Hand> Hands
            {
                get { return hands; }
                set { hands = value; }
            }
            #endregion
            
            #region HasHands
            /// <summary>
            /// This property returns true if this object has a 'Hands'.
            /// </summary>
            public bool HasHands
            {
                get
                {
                    // initial value
                    bool hasHands = (this.Hands != null);
                    
                    // return value
                    return hasHands;
                }
            }
            #endregion
            
            #region Number
            /// <summary>
            /// This property gets or sets the value for 'Number'.
            /// </summary>
            public int Number
            {
                get { return number; }
                set { number = value; }
            }
            #endregion

            
            
        #endregion
        
    }
    #endregion

}
