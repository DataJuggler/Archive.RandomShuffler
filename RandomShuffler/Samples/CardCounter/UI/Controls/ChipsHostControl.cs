

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
using DataJuggler.Core.RandomShuffler;
using CardCounter.Objects;
using CardCounter.UI.Forms;

#endregion

namespace CardCounter.UI.Controls
{

    #region class ChipHostControl
    /// <summary>
    /// This class is used to host multiple chips
    /// </summary>
    public partial class ChipsHostControl : UserControl
    {
        
        #region Private Variables
        private List<ImageEx> chips;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a chip host control
        /// </summary>
        public ChipsHostControl()
        {
            // Create control
            InitializeComponent();
        }
        #endregion

        #region Events

            #region OnPaint(PaintEventArgs e)
            /// <summary>
            /// We have to manually paint using this control
            /// </summary>
            /// <param name="e"></param>
            protected override void OnPaint(PaintEventArgs e)
            {
                // If the Shuffler object exists
                if (this.HasChipShuffler)
                {
                    // iterate the chips
                    foreach (ImageEx chip in chips)
                    {
                        // If the chip does not already have a location (without this the repaint made the chips jump around)
                        if (!chip.HasLocation)
                        {
                            // get the location
                            chip.Location = GetRandomLocation(this.ChipShuffler);
                        }

                        // Draw this image
                        e.Graphics.DrawImage(chip.Image, chip.Location);
                    }
                }
            }     
            #endregion   
            
        #endregion

        #region Methods

            #region GetRandomLocation(RandomShuffler chipShuffler)
            /// <summary>
            /// This method returns the Random Location
            /// </summary>
            private Point GetRandomLocation(RandomShuffler shuffler)
            {
                // initial value (off screen)
                Point location = new Point(-1000, -1000);

                // locals
                int left = -1000;
                int top = -1000;

                // if the shuffler has been shuffled
                if (shuffler.Shuffled)
                {
                    // get the left
                    left = shuffler.PullNextItem(false);

                    // get the top
                    top = shuffler.PullNextItem(false);
                }

                // if the value is set
                if ((left > 0) && (top > 0))
                {
                    // the left can go wider, this spreads the chips out a little
                    left = left * 2;

                    // move items towards the center
                    left -= 20;

                    // move items up for the size of the chip and add a little padding
                    top -= 20;

                    // if top is less than padding
                    if (top < 4)
                    {
                        // reset
                        top = 4;
                    }

                    // if less than the padding value
                    if (left < 4)
                    {
                        // reset to padding
                        left = 4;
                    }

                    // create the location
                    location = new Point(left, top);
                }

                // return value
                return location;
            }
            #endregion

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup this object
                this.SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint |
               ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);

                // Set the BackColor
                this.BackColor = Color.Transparent;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Chips
            /// <summary>
            /// This property gets or sets the value for 'Chips'.
            /// </summary>
            public List<ImageEx> Chips
            {
                get { return chips; }
                set 
                { 
                    // set the value
                    chips = value; 

                    // Display the chips
                    this.Invalidate();
                }
            }
            #endregion

            #region ChipShuffler
            /// <summary>
            /// This property gets or sets the value for 'Shuffler'.
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
            public RandomShuffler ChipShuffler
            {
                get
                {
                    // local
                    RandomShuffler shuffler = null;
                    if (this.HasTable)
                    {
                        // get the Shuffler from there
                        shuffler = this.Table.ChipShuffler;
                    }

                    // return value
                    return shuffler;
                }
            }
            #endregion
            
            #region HasChipShuffler
            /// <summary>
            /// This property returns true if this object has a 'ChipShuffler'.
            /// </summary>
            public bool HasChipShuffler
            {
                get
                {
                    // initial value
                    bool hasChipShuffler = (this.ChipShuffler != null);
                    
                    // return value
                    return hasChipShuffler;
                }
            }
            #endregion
            
            #region HasTable
            /// <summary>
            /// This property returns true if this object has a 'Table'.
            /// </summary>
            public bool HasTable
            {
                get
                {
                    // initial value
                    bool hasTable = (this.Table != null);
                    
                    // return value
                    return hasTable;
                }
            }
            #endregion

            #region Table
            /// <summary>
            /// This read only property casts the ParentForm as a MainForm object.
            /// </summary>
            public MainForm Table
            {
                get
                {
                    // initial value
                    MainForm table = this.ParentForm as MainForm;

                    // return value
                    return table;
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
