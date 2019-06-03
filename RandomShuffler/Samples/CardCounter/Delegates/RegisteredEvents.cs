

#region using statements

using CardCounter.Interfaces;
using CardCounter.Actions;

#endregion


namespace CardCounter.Delegates
{
    
    #region Delegates

        #region ButtonClickHandler(int buttonNumber, string buttonText);
        /// <summary>
        /// This delegate is used to handle multiple button clicks.
        /// Determine the action by the buttonNumber or buttonText.
        /// </summary>
        /// <param name="buttonNumber"></param>
        /// <param name="buttonText"></param>
        public delegate void ButtonClickHandler(int buttonNumber, string buttonText);
        #endregion

        #region RefreshUICallBack();
        /// <summary>
        /// This callback is used to show or hide the Shuffling control
        /// </summary>
        /// <param name="showShufflingImage"></param>
        public delegate void RefreshUICallBack();
        #endregion

        #region SendResponseCallBack(PlayerResponse response);
        /// <summary>
        /// This is used to send the response back from the ResponseControl.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public delegate void SendResponseCallBack(PlayerResponse response);
        #endregion

        #region ShowShufflingCallBack(bool showShufflingImage);
        /// <summary>
        /// This callback is used to show or hide the Shuffling control
        /// </summary>
        /// <param name="showShufflingImage"></param>
        public delegate void ShowShufflingCallBack(bool showShufflingImage);
        #endregion

    #endregion
        
}
