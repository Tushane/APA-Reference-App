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
        ConnectToNet _connection;

        public MainScreen()
        {
            InitializeComponent();
           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            _connection = new ConnectToNet();
            _connection.SetUrl(richTextBox1.Text);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.GetNewWebData();

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
            richTextBox1.Text = string.Empty;
            outbox.Text = string.Empty;
            clearConnectToNet();
        }

        private void clearConnectToNet()
        {
            _connection = null;
        }

        public void SetOutput(string data)
        {
          outbox.Text = data;
        }
    }
}
