

#region using statements

using DataJuggler.Core.UltimateHelper;
using PickADoorGame.Enumerations;
using System.Collections.Generic;

#endregion

namespace PickADoorGame
{

    #region class PickADoorSimulator
    /// <summary>
    /// This class is used to simulate the pick a door played on Let's Make a Deal and prove whether or not
    /// Always Swapping is better as has been suggested or if Never Swapping doesn't make any difference.
    /// </summary>
    public class PickADoorSimulator
    {
        
        #region Private Variables
        private int secretDoorNumberThatContainsCar;
        private DoorSelectOptionEnum doorSelectOption;
        private int selectedDoorOption;
        private bool swap;
        private bool correctGuess;
        private int doorNumberThatContainsAGoat;
        private List<Door> doors;
        private RandomDoorCallBack dealer;
        public const int MinValue = 1;
        public const int MaxValue = 3;
        public const int TimesToShuffle = 7;
        #endregion

        #region Parameterized Constructor(DoorSelectOptionEnum doorSelectOption, bool swap, RandomDoorCallBack dealer)
        /// <summary>
        /// Create a new instance of a PickADoorSimulator
        /// </summary>
        /// <param name="doorSelectOption"></param>
        public PickADoorSimulator(DoorSelectOptionEnum doorSelectOption, bool swap, RandomDoorCallBack dealer)
        {
            // Store the Dealer
            this.Dealer = dealer;

            // Create the doors collection
            this.Doors = CreateDoors();

            // If the Dealer object exists
            if (this.HasDealer)
            {
                // Store the value for DoorSelectOption
                this.DoorSelectOption = doorSelectOption;

                // Set the value for Swap
                this.Swap = swap;

                // Set the value for SecretDoorNumberThatContainsCar
                HideCarInSecretLocation();
            }
        }
        #endregion

        #region Methods

            #region CreateDoors()
            /// <summary>
            /// This method returns a list of Doors
            /// </summary>
            private List<Door> CreateDoors()
            {
                // Create the doors so they are only created once, not inside of a loop to improve performance slightly
                List<Door> doors = new List<Door>();

                // iterate up to the MaxValue
                for (int x = 0; x < PickADoorSimulator.MaxValue; x++)
                {
                    // Create a new door
                    Door door = new Door();

                    // Set the DoorNumber
                    door.DoorNumber = x + 1;

                    // Add this door
                    doors.Add(door);
                }

                // return value
                return doors;
            }
            #endregion
            
            #region GetRandomDoor()
            /// <summary>
            /// This method returns the Random Door
            /// </summary>
            private int GetRandomDoor()
            {
                // initial value
                int door = 0;
                
                // If the Dealer object exists
                if (this.HasDealer)
                {
                    // if the item can be pulled
                    if (this.Dealer.CanPullNextItem())
                    {  
                        // Pull the next item
                        door = this.Dealer.PullNextItem();
                    }
                }

                // return value
                return door;
            }
            #endregion
            
            #region GetSelectedDoorOption()
            /// <summary>
            /// This method returns the Selected Door Option - This is the door the contestant chooses
            /// </summary>
            private int GetSelectedDoorOption()
            {
                // initial value
                int selectedDoorOption = 0;

                // If a random number is selected
                if (this.DoorSelectOption == DoorSelectOptionEnum.Random)
                {
                    // Get a random door
                    selectedDoorOption = GetRandomDoor();
                }
                else
                {
                    // Set the value to the door selected
                    selectedDoorOption = (int) this.DoorSelectOption;
                }

                // If the Doors object exists
                if (this.HasDoors)
                {
                    // set the door
                    this.Doors[selectedDoorOption -1].UserSelected = true;
                }

                // return value
                return selectedDoorOption;
            }
            #endregion
            
            #region HideCarInSecretLocation()
            /// <summary>
            /// This method Hides the Car In a Secret Location
            /// </summary>
            private void HideCarInSecretLocation()
            {
                // If the Dealer object exists and the Doors collection exists
                if ((this.HasDealer) && (this.HasDoors))
                {
                    // Set the value for SecretDoorNumberThatContainsCar                
                    this.SecretDoorNumberThatContainsCar = GetRandomDoor();

                    // If the Doors object exists
                    if (this.SecretDoorNumberThatContainsCar <= this.Doors.Count)
                    {
                        // Get the door (minus 1 because the List is zero indexed
                        Door door = this.Doors[SecretDoorNumberThatContainsCar - 1];

                        // Hide the car
                        door.WhatIsBehind = BehindClosedDoorEnum.Car;
                    }
                }
            }
            #endregion

            #region OmniscientlyRemoveIncorrectValues()
            /// <summary>
            /// This is how my boss explained to me I am wrong. I wrote the first version of this program
            /// to prove I am write and I proved myself incorectly wrong with data. All I did was nothing here.
            /// Data can prove anything you try is the lesson here. What I have to do is remove the incorrect values
            /// </summary>
            private void OmniscientlyRemoveIncorrectValues()
            {
                // This method pulls out all of the incorrect values (the goats)
                if (this.HasDoors)
                {
                    // iterate backwards so removing an item will not affect the index
                    for (int x = this.Doors.Count - 1; x >= 0; x--)
                    {
                        // if the user did not select this door
                        if (!Doors[x].UserSelected)
                        {
                            // if this is a Goat remove it
                            if (this.Doors[x].WhatIsBehind == BehindClosedDoorEnum.Goat)
                            {
                                // Remove this door
                                this.Doors.RemoveAt(x);
                            }

                            // if we get down to 2 we have to stop; this means we have the users selection and 1 other Door
                            if (this.Doors.Count == 2)
                            {
                                // break out of the loop
                                break;
                            }
                        }
                    }
                }

                // At this point we only have two doors remaining
                // the user selected door and the car, all goats are gone
            }
            #endregion
            
            #region RunSimulation()
            /// <summary>
            /// This event is fired when Run Simulation
            /// </summary>
            public void RunSimulation()
            {
                // Set the SelectedDoorOption - This is what door the contestant chooses
                this.SelectedDoorOption = GetSelectedDoorOption();

                // Now that the user has selected a door, show the incorrect value
                // the only thing this does is reveal a goat
                OmniscientlyRemoveIncorrectValues();

                // If the value is supposed to swap in this simulation
                if (this.Swap)
                {
                    // Swap out the selected guess with the only secret door remaining
                    this.SelectedDoorOption = SwapSelectedGuess();
                }

                // Did the user guess correctly?
                this.CorrectGuess = (this.SecretDoorNumberThatContainsCar == this.SelectedDoorOption);
            }
            #endregion
            
            #region SwapSelectedGuess()
            /// <summary>
            /// Here is where I was wrong again, I was just swapping the value, but I have to 
            /// assign the value to the only remaining door that is not UserSelected.
            /// </summary>
            private int SwapSelectedGuess()
            {
                // If the Doors object exists and there are exactly two choices by now
                if ((this.HasDoors) && (this.Doors.Count == 2))
                { 
                    // do the swap now
                    foreach (Door door in this.Doors)
                    {
                        // Swap the value
                        door.UserSelected = !door.UserSelected;

                        // if the door is selected
                        if (door.UserSelected)
                        {
                            // Change the value
                            this.SelectedDoorOption = door.DoorNumber;
                        }
                    }
                }               
                else
                {
                    // Something went wrong, there are two many choices here
                    MessageBoxHelper.ShowMessage("There are too many items remaining in the SwapSelectedGuess method.", "Invalid Swap Values");
                }

                // return value
                return this.SelectedDoorOption;
            }
            #endregion
            
        #endregion

        #region Properties

            #region CorrectGuess
            /// <summary>
            /// This property gets or sets the value for 'CorrectGuess'.
            /// </summary>
            public bool CorrectGuess
            {
                get { return correctGuess; }
                set { correctGuess = value; }
            }
            #endregion
            
            #region Dealer
            /// <summary>
            /// This property gets or sets the value for 'Dealer'.
            /// </summary>
            public RandomDoorCallBack Dealer
            {
                get { return dealer; }
                set { dealer = value; }
            }
            #endregion
            
            #region DoorNumberThatContainsAGoat
            /// <summary>
            /// This property gets or sets the value for 'DoorNumberThatContainsAGoat'.
            /// </summary>
            public int DoorNumberThatContainsAGoat
            {
                get { return doorNumberThatContainsAGoat; }
                set { doorNumberThatContainsAGoat = value; }
            }
            #endregion
            
            #region Doors
            /// <summary>
            /// This property gets or sets the value for 'Doors'.
            /// </summary>
            public List<Door> Doors
            {
                get { return doors; }
                set { doors = value; }
            }
            #endregion
            
            #region DoorSelectOption
            /// <summary>
            /// This property gets or sets the value for 'DoorSelectOption'.
            /// </summary>
            public DoorSelectOptionEnum DoorSelectOption
            {
                get { return doorSelectOption; }
                set { doorSelectOption = value; }
            }
            #endregion
            
            #region HasDealer
            /// <summary>
            /// This property returns true if this object has a 'Dealer'.
            /// </summary>
            public bool HasDealer
            {
                get
                {
                    // initial value
                    bool hasDealer = (this.Dealer != null);
                    
                    // return value
                    return hasDealer;
                }
            }
            #endregion
            
            #region HasDoors
            /// <summary>
            /// This property returns true if this object has a 'Doors'.
            /// </summary>
            public bool HasDoors
            {
                get
                {
                    // initial value
                    bool hasDoors = (this.Doors != null);
                    
                    // return value
                    return hasDoors;
                }
            }
            #endregion
            
            #region SecretDoorNumberThatContainsCar
            /// <summary>
            /// This property gets or sets the value for 'SecretDoorNumberThatContainsCar'.
            /// </summary>
            public int SecretDoorNumberThatContainsCar
            {
                get { return secretDoorNumberThatContainsCar; }
                set { secretDoorNumberThatContainsCar = value; }
            }
            #endregion
            
            #region SelectedDoorOption
            /// <summary>
            /// This property gets or sets the value for 'SelectedDoorOption'.
            /// </summary>
            public int SelectedDoorOption
            {
                get { return selectedDoorOption; }
                set { selectedDoorOption = value; }
            }
            #endregion
            
            #region Swap
            /// <summary>
            /// This property gets or sets the value for 'Swap'.
            /// </summary>
            public bool Swap
            {
                get { return swap; }
                set { swap = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
