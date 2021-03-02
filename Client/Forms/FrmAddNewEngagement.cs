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
    public partial class FrmAddNewEngagement : Form
    {
        private UICAddNewEngagement uic = new UICAddNewEngagement();
        public FrmAddNewEngagement()
        {
            InitializeComponent();
            btnFindSailors.Enabled = false;
            btnFindWorkplaces.Enabled = false;
            btnChooseSailor.Enabled = false;
            btnChooseWorkplace.Enabled = false;
            btnSaveChanges.Enabled = false;
            btnReturnSailors.Enabled = false;
        }

        private void btnReturnWorplaces_Click(object sender, EventArgs e)
        {
            uic.ReturnWorkplaces(dgvReturnWorkplaces);
            btnFindWorkplaces.Enabled = true;
        }

        private void btnFindWorkplaces_Click(object sender, EventArgs e)
        {
            uic.FindWorkplaces(txtCriteria, dgvFindWorkplaces);
            btnChooseWorkplace.Enabled = true;
        }

        private void btnChooseWorkplace_Click(object sender, EventArgs e)
        {
            uic.ChooseWorkplace(dgvFindWorkplaces, lblWorkplace);
            btnReturnSailors.Enabled = true;
        }

        private void btnReturnSailors_Click(object sender, EventArgs e)
        {
            uic.ReturnSailors(dgvReturnSailors);
            btnFindSailors.Enabled = true;
        }

        private void btnFindSailors_Click(object sender, EventArgs e)
        {
            uic.FindSailors(txtCriteriaSailor, dgvFindSailors);
            btnChooseSailor.Enabled = true;
        }

        private void btnChooseSailor_Click(object sender, EventArgs e)
        {
            uic.ChooseSailor(dgvFindSailors, lblSailor);
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            uic.AddEngagement(txtDateFrom, txtDateTo, txtSalary);
        }

        private void FrmAddNewEngagement_Load(object sender, EventArgs e)
        {

        }
    }
}
