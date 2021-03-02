using Client.UIControllers;
using Domain;
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
    public partial class FrmAddNewCompany : Form
    {
        private UICAddNewCompany uic = new UICAddNewCompany();
        public FrmAddNewCompany()
        {
            InitializeComponent();
            dgvWorkplaces.DataSource = new BindingList<Workplace>();
        }

        private void btnAddWorkplace_Click(object sender, EventArgs e)
        {
            uic.AddWorkplace(dgvWorkplaces, txtWorkplaceName, txtNumberOfPlaces);
        }

        private void btnDeleteWorkplace_Click(object sender, EventArgs e)
        {
            uic.DeleteWorkplace(dgvWorkplaces);
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            uic.AddCompany(txtName, txtDateOfBirth, txtPIB, txtShipTypes, chbDaughter);
        }

        private void rbDaughter_Click(object sender, EventArgs e)
        {

        }

    }
}
