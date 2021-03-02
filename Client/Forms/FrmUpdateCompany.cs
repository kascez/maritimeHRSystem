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
    public partial class FrmUpdateCompany : Form
    {
        private UICChangeCompany uic = new UICChangeCompany();
        public FrmUpdateCompany()
        {
            InitializeComponent();
            btnFindCompanies.Enabled = false;
            btnChooseCompany.Enabled = false;
            btnSaveChanges.Enabled = false;
        }

        private void dgvFindCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uic.ReturnCompanies(dgvReturnCompanies);
            btnFindCompanies.Enabled = true;
        }

        private void btnFindCompanies_Click(object sender, EventArgs e)
        {
            uic.FindCompanies(txtCriteria, dgvFindCompanies);
            btnChooseCompany.Enabled = true;
        }

        private void btnChooseCompany_Click(object sender, EventArgs e)
        {
            uic.ChooseCompany(dgvFindCompanies, txtName, txtPIB, txtShipsType, chbDaughter);
            btnSaveChanges.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            uic.UpdateCompany(txtName, txtPIB, txtShipsType, chbDaughter);
        }
    }
}
