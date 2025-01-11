using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS_Tutoring_Services
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOurservice_Click(object sender, EventArgs e)
        {
            Services service = new Services();
            service.Show();
            this.Hide();
        }

        private void btnFindTutor_Click(object sender, EventArgs e)
        {
            FindATutor Tutor = new FindATutor();
            Tutor.Show();
            this.Hide();
        }

        private void btnApplyTutor_Click(object sender, EventArgs e)
        {
            BecomeATutor Btutor = new BecomeATutor();
            Btutor.Show();
            this.Hide();
        }

        private void btnCONTACTS_Click(object sender, EventArgs e)
        {
            Contacts details = new Contacts();
            details.Show();
            this.Hide();
        }
    }
}
