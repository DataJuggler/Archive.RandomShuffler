

#region using statements

using System.Collections.Generic;
using System.Windows.Forms;
using CardCounter.Objects;
using DataJuggler.Core.UltimateHelper;
using CardCounter.Enumerations;

#endregion

namespace CardCounter.UI.Controls
{

    #region class SelectPlayersControl
    /// <summary>
    /// This class is used to edit the players who are seated at the table.
    /// </summary>
    public partial class SelectPlayersControl : UserControl
    {
        
        #region Private Variables
        private const int MaxPlayers = 5;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'SelectPlayersControl' object.
        /// </summary>
        public SelectPlayersControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region CaptureSeatedPlayers()
            /// <summary>
            /// This method returns a list of Seated Players
            /// </summary>
            internal List<Player> CaptureSeatedPlayers()
            {
                // initial value
                List<Player> seatedPlayers = new List<Player>();

                // Capture the player seated at each control
                Player player1 = this.PlayerEditorControl1.CapturePlayer();
                Player player2 = this.PlayerEditorControl2.CapturePlayer();
                Player player3 = this.PlayerEditorControl3.CapturePlayer();
                Player player4 = this.PlayerEditorControl4.CapturePlayer();
                Player player5 = this.PlayerEditorControl5.CapturePlayer();

                // if player1 exists and is seated
                if ((NullHelper.Exists(player1)) && (player1.Seated))
                {
                    // Add this player
                    seatedPlayers.Add(player1);
                }

                // if player2 exists and is seated
                if ((NullHelper.Exists(player2)) && (player2.Seated))
                {
                    // Add this player
                    seatedPlayers.Add(player2);
                }

                // if player3 exists and is seated
                if ((NullHelper.Exists(player3)) && (player3.Seated))
                {
                    // Add this player
                    seatedPlayers.Add(player3);
                }

                // if player4 exists and is seated
                if ((NullHelper.Exists(player4)) && (player4.Seated))
                {
                    // Add this player
                    seatedPlayers.Add(player4);
                }

                // if player5 exists and is seated
                if ((NullHelper.Exists(player5)) && (player5.Seated))
                {
                    // Add this player
                    seatedPlayers.Add(player5);
                }

                // return value
                return seatedPlayers;
            }
            #endregion
            
            #region DislayPlayers(System.Collections.Generic.List<Player> players)
            /// <summary>
            /// This method returns a list of Seated Players
            /// </summary>
            internal void DislayPlayers(System.Collections.Generic.List<Player> players)
            {
                // local
                PlayerEditorControl playerEditor = null;

                // if there are one or more players
                if (ListHelper.HasOneOrMoreItems(players))
                {
                    // Iterate the collection of Player objects
                    foreach (Player player in players)
                    {
                        // if the player is in a seat
                        if (player.Seated)
                        {
                            // attempt to find the PlayerEditorControl
                            playerEditor = GetPlayerEditorControl(player.SeatNumber);

                            // If the playerEditor object exists
                            if (NullHelper.Exists(playerEditor))
                            {
                                // Set the Player on the PlayerEditor; this displays the values
                                playerEditor.Player = player;
                            }
                        }
                    }
                }
            }
            #endregion

            #region GetPlayerEditorControl(SeatNumberEnum seatNumber)
            /// <summary>
            /// This method returns the Player Editor Control
            /// </summary>
            internal PlayerEditorControl GetPlayerEditorControl(SeatNumberEnum seatNumber)
            {
                // initial value
                PlayerEditorControl playerEditor = null;

                // get the value of seatNumber
                int seatNumberValue = (int) seatNumber;

                // call the overload
                playerEditor = GetPlayerEditorControl(seatNumberValue);

                // return value
                return playerEditor;
            }
            #endregion
            
            #region GetPlayerEditorControl(int seatNumber)
            /// <summary>
            /// This method returns the Player Editor Control
            /// </summary>
            internal PlayerEditorControl GetPlayerEditorControl(int seatNumber)
            {
                // initial value
                PlayerEditorControl playerEditor = null;

                // Determine the action by the seatNumber
                switch (seatNumber)
                {
                    case 1:

                        // set the return value
                        playerEditor = this.PlayerEditorControl1;

                        // required
                        break;

                    case 2:

                        // set the return value
                        playerEditor = this.PlayerEditorControl2;

                        // required
                        break;

                    case 3:

                        // set the return value
                        playerEditor = this.PlayerEditorControl3;

                        // required
                        break;

                    case 4:

                        // set the return value
                        playerEditor = this.PlayerEditorControl4;

                        // required
                        break;

                    case 5:

                        // set the return value
                        playerEditor = this.PlayerEditorControl5;

                        // required
                        break;
                }

                // return value
                return playerEditor;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // local
                PlayerEditorControl playerEditor = null;

                // iterate from 1 - 5
                for (int x = 1; x <= MaxPlayers; x++)
                {
                    int seatNumber = x;
                    playerEditor = GetPlayerEditorControl(seatNumber);

                    // If the playerEditor object exists
                    if (NullHelper.Exists(playerEditor))
                    {
                        // set the seatNumber on each playerEditor
                        playerEditor.SeatNumber = seatNumber;
                    }
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
