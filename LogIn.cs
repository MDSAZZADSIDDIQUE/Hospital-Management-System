using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital_Management_System
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '\u25CF';
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {
            cmbUserRole.Items.Add("Admin");
            cmbUserRole.Items.Add("Doctor");
            cmbUserRole.Items.Add("Accountant");
            cmbUserRole.Items.Add("Nurse");
            cmbUserRole.Items.Add("Receptionist");
            cmbUserRole.Items.Add("Patient");
        }

        SqlConnection sqlConnection = new SqlConnection("Data Source=Likhon;Initial Catalog=Hospital Management System;Integrated Security=True");
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtEmailAddress.Text == "")
                MessageBox.Show("E-mail Address is empty");
            else if (txtPassword.Text == "")
                MessageBox.Show("Password is empty");
            else if (cmbUserRole.SelectedIndex == -1)
                MessageBox.Show("User Role is empty");
            else
            {
                bool validEmail = EmailValidation.verifyEmail(txtEmailAddress.Text);
                if (!validEmail)
                    MessageBox.Show("Invalid E-mail Address");
                else
                {
                    if (PasswordValidation.verifyPassword(txtEmailAddress.Text, txtPassword.Text))
                    {
                        this.Hide();
                        Home home = new Home();

                        if (cmbUserRole.SelectedIndex > -1)
                        {
                            string selectedItem = cmbUserRole.Items[cmbUserRole.SelectedIndex].ToString();
                            if (selectedItem == "Admin")
                                home.userRole = "Admin";
                            else if (selectedItem == "Doctor")
                                home.userRole = "Doctor";
                            else if (selectedItem == "Accountant")
                                home.userRole = "Accountant";
                            else if (selectedItem == "Nurse")
                                home.userRole = "Nurse";
                            else if (selectedItem == "Receptionist")
                                home.userRole = "Receptionist";
                            else if (selectedItem == "Patient")
                                home.userRole = "Patient";

                            home.Show();
                        }


                        else
                            MessageBox.Show("Enter User Role!");



                    }
                    else
                    {
                        MessageBox.Show("Incorrect E-mail Address or Password!");
                    }
                }
            }
            
        }

        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '\u25CF';
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
