using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void urlBox_TextChanged(object sender, EventArgs e)
        {
            _connection = new ConnectToNet();
            _connection.SetUrl(urlBox.Text);
           
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
    }
}
