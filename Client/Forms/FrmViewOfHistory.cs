using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UIControllers;
using Domain;

namespace Client.Forms
{
    public partial class FrmViewOfHistory : Form
    {
        UICViewOfHistory uic = new UICViewOfHistory();
        public FrmViewOfHistory()
        {
            InitializeComponent();
            btnFindSailors.Enabled = false;
            btnChooseSailor.Enabled = false;
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
            uic.ChooseSailor(dgvFindSailors, dgvViewOfHistory);
        }

        private void dgvReturnSailors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFindSailors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
