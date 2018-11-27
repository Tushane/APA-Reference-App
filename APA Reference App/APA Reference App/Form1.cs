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
           outbox.Text = _connection.GetWebData();
        }

        private void copybutton_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text,outbox.Text);
            clearConnectToNet();
        }

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
    }
}
