

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
using DataJuggler.Core.UltimateHelper;

#endregion

namespace CardCounter.UI.Controls
{

    #region class ShufflingAnimationControl
    /// <summary>
    /// This class is used to show a series of images that spell out the word Shuffling.
    /// Perhaps someday a better version can be created, but this is good for now.
    /// </summary>
    public partial class ShufflingAnimationControl : UserControl
    {
        
        #region Private Variables
        private int count;
        private const int MaxCount = 13;
        private const int TimerInterval = 420;
        private bool hideThisControlAtEnd;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of an ShufflingAnimationControl
        /// </summary>
        public ShufflingAnimationControl()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region AnimationTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Animation Timer _ Tick
            /// </summary>
            private void AnimationTimer_Tick(object sender, EventArgs e)
            {
                // If Design Time
                if (this.DesignMode)
                {
                    // if the count is not already 9
                    if (this.Count != 9)
                    {
                        // Stay on 9
                        this.Count = 9;
                    }
                }
                else
                {
                    // Increment the value for Count (this changes the background image)
                    this.Count++;

                    // Make sure the timer uses this value, in case any designers have their own values
                    this.AnimationTimer.Interval = TimerInterval;
                }
            }
            #endregion
            
            #region ShufflingAnimationControl_VisibleChanged(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Shuffling Animation Control _ Visible Changed
            /// </summary>
            private void ShufflingAnimationControl_VisibleChanged(object sender, EventArgs e)
            {
                // Enable the timer when this control is visible
                this.AnimationTimer.Enabled = this.Visible;

                // reset the count
                this.Count = 0;
            }
            #endregion
            
        #endregion

        #region Methods

            #region DisplayImage()
            /// <summary>
            /// This method Display Image
            /// </summary>
            private void DisplayImage()
            {
                // locals
                Image image = null;
                int delay = 0;

                // determine what image to show
                switch (this.Count)
                {
                    case 0:
                    case 10:
                    case 12:

                        // Set the image
                        image = Properties.Resources.YellowBox;

                        // use the Delay on 10 only so nothing is held up until it starts
                        if (this.Count > 0)
                        {
                            // set the delay
                            delay = TimerInterval;
                        }

                        // required
                        break;

                    case 1:

                        // Set the image
                        image = Properties.Resources.S;

                        // required
                        break;

                    case 2:

                        // Set the image
                        image = Properties.Resources.Sh;

                        // required
                        break;

                    case 3:

                        // Set the image
                        image = Properties.Resources.Shu;

                        // required
                        break;

                    case 4:

                        // Set the image
                        image = Properties.Resources.Shuf;

                        // required
                        break;

                    case 5:

                        // Set the image
                        image = Properties.Resources.Shuff;

                        // required
                        break;

                    case 6:

                        // Set the image
                        image = Properties.Resources.Shuffl;

                        // required
                        break;

                    case 7:

                        // Set the image
                        image = Properties.Resources.Shuffli;

                        // required
                        break;

                    case 8:

                        // Set the image
                        image = Properties.Resources.Shufflin;

                        // required
                        break;

                    case 9:
                    case 11:
                    case 13:

                        // Set the image
                        image = Properties.Resources.Shuffling;

                        // Stay on the word Shuffling for an extra half a second
                        delay = TimerInterval;

                        // required
                        break;
                }

                // If the image object exists
                if (NullHelper.Exists(image))
                {
                    // set the image
                    this.BackgroundImage = image;

                    // Refresh this object
                    this.Refresh();
                   
                    // if the ParentForm exists
                    if (NullHelper.Exists(this.ParentForm))
                    {
                        // Refresh the parent form
                        this.ParentForm.Refresh();
                        
                        // Refersh everything
                        Application.DoEvents();

                        // if the delay is set
                        if (delay > 0)
                        {
                            // Delay for a second
                            System.Threading.Thread.Sleep(delay);
                        }
                    }
                }
            }
            #endregion
            
            #region HideAtEnd()
            /// <summary>
            /// This method Hide At End
            /// </summary>
            internal void HideAtEnd()
            {
                // Set to true
                this.HideThisControlAtEnd = true;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Count
            /// <summary>
            /// This property gets or sets the value for 'Count'.
            /// </summary>
            public int Count
            {
                get { return count; }
                set 
                { 
                    // increment the count
                    count = value;

                    // if we have reached the end
                    if ((HideThisControlAtEnd) && (count > MaxCount))
                    {
                        // Hide this control
                        this.Visible = false;

                        // Refresh this form
                        this.Refresh();
                        
                        // if the ParentForm exists
                        if (NullHelper.Exists(this.ParentForm))
                        {
                            // refresh the ParentForm
                            this.ParentForm.Refresh();

                            // Refresh the app
                            Application.DoEvents();
                        }
                    }
                    else
                    {
                        // if the count goes over the limit
                        if (count > MaxCount)
                        {
                            // reset to 0
                            count = 0;
                        }
                    }

                    // display the current image
                    DisplayImage();
                }
            }
            #endregion
            
            #region HideThisControlAtEnd
            /// <summary>
            /// This property gets or sets the value for 'HideThisControlAtEnd'.
            /// </summary>
            private bool HideThisControlAtEnd
            {
                get { return hideThisControlAtEnd; }
                set { hideThisControlAtEnd = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
