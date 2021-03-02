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
    public partial class FrmUpdateWorkplace : Form
    {
        private UICUpdateWorkplace uic = new UICUpdateWorkplace();
        public FrmUpdateWorkplace()
        {
            InitializeComponent();
            btnChooseWorkplace.Enabled = false;
            btnFindWorkplaces.Enabled = false;
            btnSaveChanges.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCriteria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindCompanies_Click(object sender, EventArgs e)
        {
            uic.FindWorkplaces(txtCriteria, dgvFindWorkplaces);
            btnChooseWorkplace.Enabled = true;
        }

        private void btnReturnWorplaces_Click(object sender, EventArgs e)
        {
            uic.ReturnWorkplaces(dgvReturnWorkplaces);
            btnFindWorkplaces.Enabled = true;
        }

        private void btnChooseWorkplace_Click(object sender, EventArgs e)
        {
            uic.ChooseWorkplace(txtName, txtNumberOfPlaces, dgvFindWorkplaces);
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            uic.UpdateWorkplace(txtName, txtNumberOfPlaces);
        }
    }
}
