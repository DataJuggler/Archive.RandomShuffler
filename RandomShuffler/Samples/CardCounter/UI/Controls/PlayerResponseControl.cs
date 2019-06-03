

#region using statements

using CardCounter.Delegates;
using CardCounter.Enumerations;
using CardCounter.Interfaces;
using CardCounter.Objects;
using CardCounter.UI.Forms;
using DataJuggler.Core.UltimateHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

#endregion

namespace CardCounter.UI.Controls
{

    #region class PlayerResponseControl
    /// <summary>
    /// This class is used to get a players response.
    /// </summary>
    public partial class PlayerResponseControl : UserControl
    {
        
        #region Private Variables
        private IPlayerResponseRequest responseRequest;
        private Stopwatch stopwatch;
        private SendResponseCallBack sendResponseCallBack;
        public const int ButtonSeperatorWidth = 16;
        private const int TimerDuration = 15;
        private bool responseSent;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a PlayerResponseControl
        /// </summary>
        public PlayerResponseControl()
        {
            // Create Controls
            InitializeComponent();
        }
        #endregion
        
        #region Events
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region Button1_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'Button1' is clicked.
            /// </summary>
            private void Button1_Click(object sender, EventArgs e)
            {
                // If the ButtonClickHandler object exists
                if (this.HasButtonClickHandler)
                {
                    // Call the ClickHandler
                    this.ButtonClickHandler(1, this.Button1.Text);
                }
            }
            #endregion
            
            #region Button2_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'Button2' is clicked.
            /// </summary>
            private void Button2_Click(object sender, EventArgs e)
            {
                // If the ButtonClickHandler object exists
                if (this.HasButtonClickHandler)
                {
                    // Call the ClickHandler
                    this.ButtonClickHandler(2, this.Button2.Text);
                }
            }
            #endregion
            
            #region Button3_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'Button3' is clicked.
            /// </summary>
            private void Button3_Click(object sender, EventArgs e)
            {
                // If the ButtonClickHandler object exists
                if (this.HasButtonClickHandler)
                {
                    // Call the ClickHandler
                    this.ButtonClickHandler(3, this.Button3.Text);
                }
            }
            #endregion
            
            #region Button4_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'Button4' is clicked.
            /// </summary>
            private void Button4_Click(object sender, EventArgs e)
            {
                // If the ButtonClickHandler object exists
                if (this.HasButtonClickHandler)
                {
                    // Call the ClickHandler
                    this.ButtonClickHandler(4, this.Button4.Text);
                }
            }
            #endregion
            
            #region Graph_VisibleChanged(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Graph _ Visible Changed
            /// </summary>
            private void Graph_VisibleChanged(object sender, EventArgs e)
            {
                // if this object just became visible
                if (this.Visible)
                {
                    // Create a new instance of a 'Stopwatch' object.
                    this.Stopwatch = new Stopwatch();

                    // Start the StopWatch
                    this.Stopwatch.Start();

                    // Set the value to 100%
                    this.Graph.Value = this.Graph.Maximum;
                }
                else
                {
                    // Stop the timer
                    this.GraphTimer.Enabled = false;
                }

                // Do not enable the timer during design mode
                if (!DesignMode)
                {
                    // The Timer is only enabled if this object is visible
                    this.GraphTimer.Enabled = this.Visible;
                }
            }
            #endregion
            
            #region GraphTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Graph Timer _ Tick
            /// </summary>
            private void GraphTimer_Tick(object sender, EventArgs e)
            {  
                // if the StopWatch exists
                if (this.HasStopwatch)
                {
                    // if the response has been sent
                    if (this.ResponseSent)
                    {
                        // hide this control
                        this.Visible = false;
                    }

                    // Get the amount of time that has elapsed
                    TimeSpan timeSpan = this.Stopwatch.Elapsed;

                    // if the TotalMilliseconds is greater than zero
                    if (timeSpan.TotalMilliseconds > 0)
                    {
                        // if we have not exceeded our match
                        if (timeSpan.TotalMilliseconds < this.Graph.Maximum)
                        {
                            // get the value
                            int value = (int) timeSpan.TotalMilliseconds;

                            // if the value is in range
                            if ((value > 0) && (value <= this.Graph.Maximum))
                            {
                                // Set the value
                                this.Graph.Value = (this.Graph.Maximum - value);

                                // Show the graph if it is greater than zero
                                this.Graph.Visible = (timeSpan.TotalSeconds < TimerDuration);

                                // Refresh the Graph
                                this.Graph.Refresh();

                                //// If the Table object exists
                                //if (this.HasTable)
                                //{
                                //    // Refresh the UI
                                //    this.Table.RefreshUI();
                                //}
                            }
                            else
                            {
                                // Hide this control
                                this.Visible = false;
                            }
                        }
                        else
                        {
                            // The 15 seconds has expired, sit out this player
                            OnTimeOut();

                            // Hide this control
                            this.Visible = false;
                        }
                    }
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region GetButton(int buttonNumber)
            /// <summary>
            /// This method returns the Button
            /// </summary>
            private Button GetButton(int buttonNumber)
            {
                // initial value
                Button button = null;

                // Determine the action by the buttonNumber
                switch (buttonNumber)
                {
                    case 1:

                        // Set the Button
                        button = this.Button1;

                        // required
                        break;

                    case 2:

                        // Set the Button
                        button = this.Button2;

                        // required
                        break;

                    case 3:

                        // Set the Button
                        button = this.Button3;

                        // required
                        break;

                    case 4:

                        // Set the Button
                        button = this.Button4;

                        // required
                        break;
                }

                // return value
                return button;
            }
            #endregion
            
            #region HideAllButtons()
            /// <summary>
            /// This method Hide All Buttons
            /// </summary>
            private void HideAllButtons()
            {
                // hide each button
                this.Button1.Visible = false;
                this.Button2.Visible = false;
                this.Button3.Visible = false;
                this.Button4.Visible = false;
            }
            #endregion
            
            #region HideButton(int buttonNumber)
            /// <summary>
            /// This method returns the Button
            /// </summary>
            private void HideButton(int buttonNumber)
            {
                // get the button
                Button button = GetButton(buttonNumber);

                // If the button object exists
                if (NullHelper.Exists(button))
                {
                    // hide this button
                    button.Visible = false;
                }
            }
            #endregion

            #region OnTimeOut()
            /// <summary>
            /// This method On Time Out
            /// </summary>
            private void OnTimeOut()
            {
                // If the SendResponseCallBack object exists
                if ((this.HasSendResponseCallBack) && (this.HasResponseRequest))
                {
                    // Create the Response
                    this.ResponseRequest.Response = new Actions.PlayerResponse(ResponseTypeEnum.TimeOut);

                    // Send the Response
                    this.SendResponseCallBack(this.ResponseRequest.Response);
                }
            }
            #endregion
            
            #region SetupButton(int buttonNumber, ButtonDescriptor buttonDescriptor)
            /// <summary>
            /// This method sets up the Button object corresponding to the buttonNumber
            /// </summary>
            private void SetupButton(int buttonNumber, ButtonDescriptor buttonDescriptor)
            {
                // local
                Button button = GetButton(buttonNumber);

                // if this is Insurance
                if (this.ResponseRequest.RequestType == ResponseRequestTypeEnum.Insurance)
                {
                    // break point only
                    this.ResponseRequest.RequestType = ResponseRequestTypeEnum.Insurance;
                }

                // If the button object exists
                if (NullHelper.Exists(button))
                {
                    // If the buttonDescriptor object exists
                    if (NullHelper.Exists(buttonDescriptor))
                    {
                        // setup this control
                        button.Text = buttonDescriptor.Text;
                        button.Width = buttonDescriptor.Width;
                        button.Visible = true;
                    }
                    else
                    {
                        // hide this button
                        button.Visible = false;
                    }
                }
            }
            #endregion

            #region SetupButtons(List<ButtonDescriptor> buttonDescriptors)
            /// <summary>
            /// This method sets up the Button object corresponding to the buttonNumber
            /// </summary>
            internal void SetupButtons(List<ButtonDescriptor> buttonDescriptors)
            {
                // Hide all the buttons
                this.HideAllButtons();

                // local
                int buttonNumber = 0;

                // If the button object exists
                if (ListHelper.HasOneOrMoreItems(buttonDescriptors))
                {
                    // Iterate the collection of ButtonDescriptor objects
                    foreach (ButtonDescriptor buttonDescriptor in buttonDescriptors)
                    {
                        // Increment the value for buttonNumber
                        buttonNumber++;

                        // find the button
                        this.SetupButton(buttonNumber, buttonDescriptor);
                    }

                    // Now set the width of this control
                    this.Width = this.SetWidth(buttonDescriptors);
                }
            }
            #endregion

            #region SetWidth(List<ButtonDescriptor> buttonDescriptors)
            /// <summary>
            /// This method returns the Width
            /// </summary>
            private int SetWidth(List<ButtonDescriptor> buttonDescriptors)
            {
                // initial value
                int width = 0;

                // local
                int buttonNumber = 0;

                // if the responseRequest exists
                if (ListHelper.HasOneOrMoreItems(buttonDescriptors))
                {
                    // Iterate the collection of ButtonDescriptor objects
                    foreach (ButtonDescriptor buttonDescriptor in buttonDescriptors)
                    {
                        // increment buttonNumber
                        buttonNumber++;

                        // after the first button we need to add a seperator width
                        if (buttonNumber > 1)
                        {
                            // Add the width of the seperator
                            width += ButtonSeperatorWidth;
                        }

                        // Add the width for the space
                        width += buttonDescriptor.Width;
                    }
                }

                // return value
                return width;
            }
            #endregion
            
        #endregion

        #region Properties

            #region ButtonClickHandler
            /// <summary>
            /// This property gets or sets the value for 'ButtonClickHandler'.
            /// </summary>
            public ButtonClickHandler ButtonClickHandler
            {
                get
                {
                    // initial value
                    ButtonClickHandler buttonClickHandler = null;

                    // if the ResponseRequest exists
                    if (HasResponseRequest)
                    {
                        // set the return value
                        buttonClickHandler = this.ResponseRequest.ButtonClickHandler;
                    }

                    // return value
                    return buttonClickHandler;
                }
                set
                {
                    // if the ResponseRequest exists
                    if (this.ResponseRequest != null)
                    {
                        // set the value
                        ResponseRequest.ButtonClickHandler = value;
                    }
                }
            }
            #endregion

            #region HasButtonClickHandler
            /// <summary>
            /// This property returns true if this object has a 'ButtonClickHandler'.
            /// </summary>
            public bool HasButtonClickHandler
            {
                get
                {
                    // initial value
                    bool hasButtonClickHandler = (this.ButtonClickHandler != null);
                    
                    // return value
                    return hasButtonClickHandler;
                }
            }
            #endregion
            
            #region HasResponseRequest
            /// <summary>
            /// This property returns true if this object has a 'ResponseRequest'.
            /// </summary>
            public bool HasResponseRequest
            {
                get
                {
                    // initial value
                    bool hasResponseRequest = (this.ResponseRequest != null);
                    
                    // return value
                    return hasResponseRequest;
                }
            }
            #endregion
            
            #region HasSendResponseCallBack
            /// <summary>
            /// This property returns true if this object has a 'SendResponseCallBack'.
            /// </summary>
            public bool HasSendResponseCallBack
            {
                get
                {
                    // initial value
                    bool hasSendResponseCallBack = (this.SendResponseCallBack != null);
                    
                    // return value
                    return hasSendResponseCallBack;
                }
            }
            #endregion
            
            #region HasStopwatch
            /// <summary>
            /// This property returns true if this object has a 'Stopwatch'.
            /// </summary>
            public bool HasStopwatch
            {
                get
                {
                    // initial value
                    bool hasStopwatch = (this.Stopwatch != null);
                    
                    // return value
                    return hasStopwatch;
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
            
            #region ResponseSent
            /// <summary>
            /// This property gets or sets the value for 'ResponseSent'.
            /// </summary>
            public bool ResponseSent
            {
                get { return responseSent; }
                set { responseSent = value; }
            }
            #endregion
            
            #region SendResponseCallBack
            /// <summary>
            /// This property gets or sets the value for 'SendResponseCallBack'.
            /// </summary>
            public SendResponseCallBack SendResponseCallBack
            {
                get { return sendResponseCallBack; }
                set { sendResponseCallBack = value; }
            }
            #endregion
            
            #region Stopwatch
            /// <summary>
            /// This property gets or sets the value for 'Stopwatch'.
            /// </summary>
            public Stopwatch Stopwatch
            {
                get { return stopwatch; }
                set { stopwatch = value; }
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

            #region ResponseRequest
            /// <summary>
            /// This property gets or sets the value for 'Response'.
            /// </summary>
            [Browsable(false)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public IPlayerResponseRequest ResponseRequest
            {
                get { return responseRequest; }
                set { responseRequest = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
