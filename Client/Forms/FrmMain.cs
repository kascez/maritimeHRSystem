using Client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
            if (Controller.Controller.Instance.Administrator == null)
            {
                btnAddCompany.Enabled = false;
                btnDeleteCompany.Enabled = false;
                btnUpdateCompany.Enabled = false;
                btnUpdateWorkplace.Enabled = false;
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddNewCompany addCompany = new FrmAddNewCompany();
                addCompany.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                FrmRegistration registration = new FrmRegistration();
                registration.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateCompany updateCompany = new FrmUpdateCompany();
                updateCompany.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnUpdateWorkplace_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateWorkplace updateWorkplace = new FrmUpdateWorkplace();
                updateWorkplace.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnUpdateSailor_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateSailor updateSailor = new FrmUpdateSailor();
                updateSailor.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            try
            {
                FrmDeleteCompany deleteCompany = new FrmDeleteCompany();
                deleteCompany.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnAddNewEngagement_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddNewEngagement addEngagement = new FrmAddNewEngagement();
                addEngagement.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void btnViewOfHistory_Click(object sender, EventArgs e)
        {
            try
            {
                FrmViewOfHistory viewOfHistory = new FrmViewOfHistory();
                viewOfHistory.ShowDialog();
            }
            catch (System.IO.IOException)
            {
                MessageBox.Show("Sistem ne moze da pokrene formu!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FrmClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
