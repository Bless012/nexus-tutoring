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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Form1 fsHome = new Form1();
            fsHome.Show();
            this.Hide();
        }

        private void btnFindTutor_Click(object sender, EventArgs e)
        {
            FindATutor Ntutor = new FindATutor();
            Ntutor.Show();
            this.Hide();
        }
    }
}
