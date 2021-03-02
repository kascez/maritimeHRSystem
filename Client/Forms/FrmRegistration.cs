using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Client.UIControllers;

namespace Client.Forms
{
    public partial class FrmRegistration : Form
    {
        private UICRegistration uic = new UICRegistration();
        public FrmRegistration()
        {
            InitializeComponent();
            try
            {
                cbCountry.DataSource = Communication.Instance.ReturnCountries();
                cbRank.DataSource = Communication.Instance.ReturnRanks();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Greska prilikom ucitavanja lista!");
                return;
            }
        }

        private void btnAddSailor_Click(object sender, EventArgs e)
        {
            uic.AddSailor(txtUsername, txtPassword, txtName, txtSurname, txtEmail, txtLicence, cbCountry, cbRank);
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cbRank.SelectedIndex = -1;
            cbCountry.SelectedIndex = -1;
        }
    }
}
