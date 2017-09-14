using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Administration_Tool
{
    public partial class MainForm : Form
    {
        private Server server;

        public ListView ConnectionList
        {
            get
            {
                return connectionList;
            }
        }

        public void Log(string message)
        {
            console.Text += message + Environment.NewLine;
        }
 
        public MainForm()
        {
            InitializeComponent();

            server = new Server();
            Server.MainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            server.Start();
        }

        private void connectionsContext_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (connectionList.SelectedItems.Count > 0)
            {

            }
            else
                e.Cancel = true;
        }
    }
}
