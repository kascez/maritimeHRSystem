using Client.UIControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmLogin : Form
    {
        private UICLogin uic = new UICLogin();
        public FrmLogin()
        {
            ConnectToServer();
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            if (Communication.Instance.Connect())
            {
                MessageBox.Show("Uspjesno ste se povezali na server!");
            } else
            {
                MessageBox.Show("Povezivanje na server nije bilo uspjesno!");
                Environment.Exit(0);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            uic.Login(txtUsr, txtPsw, chbLogin);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = SystemColors.ButtonFace;
        }
    }
}
