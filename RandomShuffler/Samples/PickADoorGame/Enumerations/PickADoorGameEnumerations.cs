using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.Core.RandomShuffler;

namespace PickADoorGame.Enumerations
{

    #region DoorSelectOptionEnum : int
    /// <summary>
    /// This enum is used for the option of the users pick
    /// </summary>
    public enum DoorSelectOptionEnum : int
    {
        Random = 0,
        Always_Pick_Door_1 = 1,
        Always_Pick_Door_2 = 2,
        Always_Pick_Door_3 = 3
    }
    #endregion

    #region BehindClosedDoorEnum : int
    /// <summary>
    /// This enum is used to determine what is behind a door.
    /// </summary>
    public enum BehindClosedDoorEnum : int
    {
        Goat = 0,
        Car = 1
    }
    #endregion

}
