

#region using statements

using System;

#endregion

namespace CardCounter.Enumerations
{

    #region ChipEnum
    /// <summary>
    /// This is used by the chip factory to create the chip image
    /// </summary>
    public enum ChipEnum : int
    {
        Unknown = 0,
        WhiteChip = 1,
        RedChip = 5,
        GreenChip = 25,
        BlackChip = 100,
        PurpleChip = 500,
        GoldChip = 1000
    }
    #endregion

    #region CountingSystemLevelEnum : int
    /// <summary>
    /// What is the level of this CountingSystem
    /// </summary>
    public enum CountingSystemLevelEnum : int
    {
        Easy = 1,
        Standard = 2,
        Advanced = 3
    }
    #endregion

    #region HandResultEnum : int
    /// <summary>
    /// This enum is the possible results of a hand of black jack.
    /// Since enums do not allow doubles the values are multiplies by 2.
    /// This value is primarily used for History navigation, but it should
    /// be divided by 2 when being applied to bet pay offs.
    /// </summary>
    public enum HandResultEnum : int
    {
        NotStarted = -1000,
        DoubleDownLoss = -4,
        Loss = -2,
        Push = 0,
        Win = 2,
        BlackJack = 3,
        DoubleDownWin = 4
    }
    #endregion

    #region GameSpeedEnum : int
    /// <summary>
    /// This enumeration is used to designate how fast the Dealer should deal.
    /// Each of these values correspond to the Delay milliseconds the Dealer
    /// will pause in between cards. If the Game Speed is not Manuel then
    /// 2,500 Milliseconds is the base delay - the value of the GameSpeed.
    /// The reason the numbers are in this order is the combobox loads
    /// from easiest (slowest) to hardest (fastest) this way. Manuel Deal
    /// is the slowest as 2,500 - zero is 2 seconds per action (card dealt, computer player acting, etc.)
    /// In a casino you need to be able to operate at Fast or Very Fast to keep up and casinos
    /// are not as quite as where you probably practice so lots of practice is needed.
    /// The game delays is actually slower than this value because refreshing the UI in Windows is very consuming.
    /// </summary>
    public enum GameSpeedEnum : int
    {
        Manuel_Deal = 0,
        Very_Slow = 500,
        Slow = 1000,
        Normal = 1500,
        Fast = 2000,
        Very_Fast = 2500
    }
    #endregion

    #region ResponseRequestTypeEnum : int
    /// <summary>
    /// This enum is used to request a Players Response.
    /// This is eerily similar to the ResponseType enum 
    /// as originally requests and responses used
    /// ResponseTypeEnum, but I broke them apart
    /// to be more specific.
    /// </summary>
    public enum ResponseRequestTypeEnum : int
    {  
        Surrender = -2,
        Insurance = -1,
        Unknown = 0,
        PlaceBet = 1,
        StartingHand = 2,
        PlayHand = 3,
        DoubleDown = 4
    }
    #endregion

    #region ResponseTypeEnum : int
    /// <summary>
    /// This enum is used to return a Players Response
    /// </summary>
    public enum ResponseTypeEnum : int
    {  
        TimeOut = -100,
        SitOut = -10,
        No = -3,
        Surrender = -2,
        Insurance = -1,
        Unknown = 0,
        PlaceBet = 1,
        Stand = 2,
        DoubleDown = 3,
        Split = 4,
        Hit = 5
    }
    #endregion

    #region SeatNumberEnum : int
    /// <summary>
    /// This enum is used to set the SeatNumber in a range of 1 - 5
    /// </summary>
    public enum SeatNumberEnum : int
    {
        NotSeated = 0,
        Seat1 = 1,
        Seat2 = 2,
        Seat3 = 3,
        Seat4 = 4,
        Seat5 = 5,
        Dealer = 6
    }
    #endregion

}
