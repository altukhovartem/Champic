using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if(ValidateForm())
            {
                PersonModel p = new PersonModel();
                p.FirstName = firstNameValueTextBox.Text;
                p.LastName = lastNameValueTextbox.Text;
                p.EmailAddress = emailValue.Text;
                p.CellphoneNumber = cellPhoneValue.Text;

                GlobalConfig.Connection.CreatePerson(p);
                firstNameValueTextBox.Text = "";
                lastNameValueTextbox.Text = "";
                emailValue.Text = "";
                cellPhoneValue.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields");
            }
        }

        public bool ValidateForm()
        {
            // TODO - Addvalidation ot the form

            if(firstNameValueTextBox.Text.Length == 0)
            {
                return false;
            }

            if (lastNameValueTextbox.Text.Length == 0)
            {
                return false;
            }

            if (emailValue.Text.Length == 0)
            {
                return false;
            }

            if (cellPhoneValue.Text.Length == 0)
            {
                return false;
            }

            return true;
        }
    }
}
