

#region using statements

#endregion

namespace CardCounter.Objects
{

    #region class ButtonDescriptor
    /// <summary>
    /// This struct is used to pass in the text and the width in one property
    /// </summary>
    public class ButtonDescriptor
    {
        
        #region Private Variables
        private string text;
        private int width;
        #endregion

        #region ButtonDescriptor(string text, int width)
        /// <summary>
        /// Create a new instance of a ButtonDescriptor object.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        public ButtonDescriptor(string text, int width)
        {
            // Store the arguments
            this.Text = text;
            this.Width = width;
        }
        #endregion

        #region Properties

            #region Text
            /// <summary>
            /// This property gets or sets the value for 'Text'.
            /// </summary>
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            #endregion
            
            #region Width
            /// <summary>
            /// This property gets or sets the value for 'Width'.
            /// </summary>
            public int Width
            {
                get { return width; }
                set { width = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
