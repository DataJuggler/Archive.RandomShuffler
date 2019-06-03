

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace CardCounter.Objects
{

    #region class ImageEx
    /// <summary>
    /// This class hosts an Image with a location
    /// </summary>
    public class ImageEx
    {
        
        #region Private Variables
        private Image image;
        private Point location;
        #endregion

        #region Parameterized Constructor(Image image)
        /// <summary>
        /// Create a new instance of an ImageEx object
        /// </summary>
        /// <param name="image"></param>
        /// <param name="location"></param>
        public ImageEx(Image image)
        {
            // Set the image
            this.Image = image;
        }
        #endregion

        #region Properties

            #region HasImage
            /// <summary>
            /// This property returns true if this object has an 'Image'.
            /// </summary>
            public bool HasImage
            {
                get
                {
                    // initial value
                    bool hasImage = (this.Image != null);
                    
                    // return value
                    return hasImage;
                }
            }
            #endregion
            
            #region HasLocation
            /// <summary>
            /// This property returns true if this object has a 'Location'.
            /// </summary>
            public bool HasLocation
            {
                get
                {
                    // initial value
                    bool hasLocation = (this.Location != Point.Empty);
                    
                    // return value
                    return hasLocation;
                }
            }
            #endregion
            
            #region Image
            /// <summary>
            /// This property gets or sets the value for 'Image'.
            /// </summary>
            public Image Image
            {
                get { return image; }
                set { image = value; }
            }
            #endregion
            
            #region Location
            /// <summary>
            /// This property gets or sets the value for 'Location'.
            /// </summary>
            public Point Location
            {
                get { return location; }
                set { location = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
