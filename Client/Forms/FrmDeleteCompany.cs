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
    public partial class FrmDeleteCompany : Form
    {
        private UICDeleteCompany uic = new UICDeleteCompany();
        public FrmDeleteCompany()
        {
            InitializeComponent();
            btnDeleteCompany.Enabled = false;
            btnFindCompanies.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uic.ReturnCompanies(dgvReturnCompanies);
            btnFindCompanies.Enabled = true;
        }

        private void btnFindCompanies_Click(object sender, EventArgs e)
        {
            uic.FindCompanies(txtCriteria, dgvFindCompanies);
            btnDeleteCompany.Enabled = true;
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            uic.DeleteMember(dgvFindCompanies);
        }
    }
}
