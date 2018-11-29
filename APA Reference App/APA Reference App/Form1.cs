using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APA_Reference_App
{
    public partial class MainScreen : Form
    {
        private ConnectToNet _connection; //variable that can store an instance of the ConnectToNet class
        private Point prev_MousePosition = new Point(0, 0);
        private bool moving = false;

        public MainScreen()
        {
            //setting up the display for the main screen
            InitializeComponent();
           
        }

        //checking and setting the url input 
        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            _connection = new ConnectToNet();
            _connection.SetUrl(urlBox.Text);
           
        }

        //handles the clicking of the GetData Button
        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (statusbar.Value > 0)
                {

                    statusbar.Value = 0;
                    TrackProgress(10);
                    this.SetState("Process Starting");
                    Thread.Sleep(100);

                }
                else
                {
                    TrackProgress(10);
                }
                    await _connection.NewGetWebDatam();

                } catch(NullReferenceException ez)
            {
                outbox.Text = ez.ToString();//returning the error message in the outbox section
            }
        }

        //the event for the copy button that handles the copying
        private void copybutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text,outbox.Text);
            clearConnectToNet();
        }

        //the method that handles the clear of both terminals
        private void clearbutton_Click(object sender, EventArgs e)
        {
            urlBox.Text = string.Empty;
            outbox.Text = string.Empty;
            statusbar.Value = 0;
            clearConnectToNet();
        }

        //clearing the variable that store the instantiated ConnectToNet class
        private void clearConnectToNet()
        {
            _connection = null;
        }

        //function that put data within the output box 
        public void SetOutput(string data)
        {
          outbox.Text = data;
        }

        //function that handles the disabling and enabling of specific components
        public void ComponentState(bool temp)
        {
            clearbutton.Enabled = temp;
            button1.Enabled = temp;
            urlBox.Enabled = temp;
        }

        //handles the closing of the application
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //handles the minimization of the application
        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region The Code that Handles the moving of the application
        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!moving)
            {
                moving = true;
                prev_MousePosition = new Point(e.X, e.Y);
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                Point next_MousePosition = PointToScreen(e.Location);
                Location = new Point(next_MousePosition.X - this.prev_MousePosition.X,
                                             next_MousePosition.Y - this.prev_MousePosition.Y);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
        }
        #endregion

        //function that handles the tracking of the formating progress
        public void TrackProgress(int currentProgress)
        {
            statusbar.Increment(currentProgress);
        }

        //function that state where the progress is at
        public async void SetState(string state)
        {
            label4.Text = state;
        }
    }
}
