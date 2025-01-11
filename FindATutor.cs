using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEXUS_Tutoring_Services
{
    public partial class FindATutor : Form
    {
        public FindATutor()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string surname = surnametxt.Text;
            string UserEmail = Emailtxt.Text;
            string contantNo = contactnumbertxt.Text;
            string Institution = Institutiontxt.Text;
            string courses = Coursestxt.Text;
            string Hours = NoOfHourstxt.Text;
            string shortdescription = Shortdescriptiontxt.Text;

            bool blnValidInput = true;


            blnValidInput = ValidateFormInput(name, surname, UserEmail, contantNo, Institution, courses, Hours, shortdescription, cmbPreference);
            if (blnValidInput == true)
            {
                MessageBox.Show("Thank you for applying at Nexus Tutoring. We'll get back to you.", "Application Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool ValidateFormInput(string name, string surname, string UserEmail, string contantNo, string Institution, string courses, string Hours, string shortdescription, ComboBox cmbPreference)
        {

            bool blnValidInput = true;

            if (name == "")
            {
                MessageBox.Show("please enter your name");
                blnValidInput = false;
            }
            if (surname == "")
            {
                MessageBox.Show("please enter your surname");
                blnValidInput = false;
            }
            if (contantNo == "")
            {
                MessageBox.Show("please enter your Contact number");
                blnValidInput = false;
            }
            if (!Regex.IsMatch(UserEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email address.");
                blnValidInput = false;
            }
            if (Institution == "")
            {
                MessageBox.Show("please enter your imstitution");
                blnValidInput = false;
            }
            if (courses == "")
            {
                MessageBox.Show("please enter your course");
                blnValidInput = false;
            }
            if (Hours == "")
            {
                MessageBox.Show("hours should be atleast 1");
                blnValidInput = false;
            }
            if (shortdescription == "")
            {
                MessageBox.Show("please enter a short description of the course");
                blnValidInput = false;
            }
            if (cmbPreference.SelectedIndex == -1)
            {
                MessageBox.Show("please select your preference");
                blnValidInput = false;
            }

            return blnValidInput;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fgback = new Form1();
            fgback.Show();
            this.Hide();
        }
    }
}
