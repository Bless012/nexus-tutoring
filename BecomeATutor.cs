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
    public partial class BecomeATutor : Form
    {
        public BecomeATutor()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fgback = new Form1();
            fgback.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string surname = surnametxt.Text;
            string UserEmail = Emailtxt.Text;
            string Institution = Institutiontxt.Text;
            string coursetutoring = coursetutoringtxt.Text;


            bool blnValidInput = true;


            blnValidInput = ValidateFormInput(name, surname, UserEmail, Institution, cmbLevelofstudy, coursetutoring, cmbYearofstudy, cmbTutresources);
            if (blnValidInput == true)
            {
                MessageBox.Show("Thank you for applying to become a tutor at Nexus Tutoring. We'll review your application and get back to you.",
                                "Application Submitted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        private bool ValidateFormInput(string name, string surname, string UserEmail, string Institution, ComboBox cmbLevelofstudy, string coursetutoring, ComboBox cmbYearofstudy, ComboBox cmbTutresources)
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
            if (cmbLevelofstudy.SelectedIndex == -1)
            {
                MessageBox.Show("please select your level of study");
                blnValidInput = false;
            }
            if (coursetutoring == "")
            {
                MessageBox.Show("please enter your the course you would like to tutor");
                blnValidInput = false;
            }

            if (cmbYearofstudy.SelectedIndex == -1)
            {
                MessageBox.Show("please select year of study");
                blnValidInput = false;
            }
            if (cmbTutresources.SelectedIndex == -1)
            {
                MessageBox.Show("please select resources you have");
                blnValidInput = false;
            }

            return blnValidInput;
        }

        private void btnChoosefile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Select a Document",
                    Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Word Files (*.docx)|*.docx",
                    FilterIndex = 1,
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while selecting the file: " + ex.Message);
            }
        }
    }
}
