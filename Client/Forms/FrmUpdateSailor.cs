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
    public partial class FrmUpdateSailor : Form
    {
        private UICUpdateSailor uic = new UICUpdateSailor();
        public FrmUpdateSailor()
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
            btnChooseSailor.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnFindSailors.Enabled = false;
        }

        private void btnReturnSailors_Click(object sender, EventArgs e)
        {
            uic.ReturnSailors(dgvReturnSailors);
            btnFindSailors.Enabled = true;
        }

        private void btnFindSailors_Click(object sender, EventArgs e)
        {
            uic.FindSailors(txtCriteria, dgvFindSailors);
            btnChooseSailor.Enabled = true;
        }

        private void btnChooseSailor_Click(object sender, EventArgs e)
        {
            uic.ChooseSailor(txtUsername, txtPassword, txtName, txtSurname, txtEmail, txtLicence, cbCountry, cbRank, dgvFindSailors);
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            uic.UpdateSailor(txtUsername, txtPassword, txtName, txtSurname, txtEmail, txtLicence, cbCountry, cbRank);
        }

        private void FrmUpdateSailor_Load(object sender, EventArgs e)
        {
            cbRank.SelectedIndex = -1;
            cbCountry.SelectedIndex = -1;
        }
    }
}
