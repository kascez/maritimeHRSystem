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

namespace Server
{
    public partial class FrmServer : Form
    {
        private Server s;
        Thread serverThread;
        public FrmServer()
        {
            InitializeComponent();
            btnStop.Enabled = false;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.RunServer())
            {
                serverThread = new Thread(s.Listen);
                serverThread.IsBackground = true;
                serverThread.Start();
                MessageBox.Show("The server is running!");
                btnRun.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("The server is not running!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Server.connectedClients.Count > 0)
            {
                MessageBox.Show("There are some clients that are logged in!");
                return;
            }
            if (s.StopServer())
            {
                MessageBox.Show("The server is not running anymore!");
                btnRun.Enabled = true;
                btnStop.Enabled = false;
            }
        }
    }
}
