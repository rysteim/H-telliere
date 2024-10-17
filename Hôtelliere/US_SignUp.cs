using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hôtelliere
{
    public partial class US_SignUp : UserControl
    {
        public US_SignUp()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        public void clear()
        {
            txtFname.Texts = string.Empty;
            txtLname.Texts = string.Empty;
            txtEmail.Texts = string.Empty;
            txtAddress.Texts = string.Empty;
            cmbGender.Text=string.Empty;
            dateBirthdate.Value = DateTime.Now;
            txtUser.Texts = string.Empty;
            txtPass.Texts = string.Empty;
            txtFname.Focus();
        }
        private bool checkField()
        {
            bool result = false;
            if (String.IsNullOrEmpty(txtFname.Texts))
            {
                new Hôtelliere_MessagePopUp("Your Firstname must not be empty.", "For your Information", 3).ShowDialog();
                txtFname.Focus();
            }
            else if (String.IsNullOrEmpty(txtLname.Texts))
            {
                new Hôtelliere_MessagePopUp("Your Lastname must not be empty.", "For your Information", 3).ShowDialog();
                txtLname.Focus();
            }
            else if (String.IsNullOrEmpty(txtUser.Texts))
            {
                new Hôtelliere_MessagePopUp("Your Username must not be empty.", "For your Information", 3).ShowDialog();
                txtUser.Focus();
            }
            else if (String.IsNullOrEmpty(txtPass.Texts))
            {
                new Hôtelliere_MessagePopUp("Your Password must not be empty.", "For your Information", 3).ShowDialog();
                txtPass.Focus();
            }
            else if (String.IsNullOrEmpty(txtEmail.Texts))
            {
                new Hôtelliere_MessagePopUp("Your Email Address must not be empty.", "For your Information", 3).ShowDialog();
                txtEmail.Focus();
            }
            else if (String.IsNullOrEmpty(txtAddress.Texts))
            {
                new Hôtelliere_MessagePopUp("Your Address must not be empty.", "For your Information", 3).ShowDialog();
                txtAddress.Focus();
            }
            else if (String.IsNullOrEmpty(cmbGender.Text))
            {
                new Hôtelliere_MessagePopUp("Your Gender must not be empty.", "For your Information", 1).ShowDialog();
                cmbGender.Focus();
            }
            else
            {
                result = true;
            }
            return result;
        }
        private void btnToSignIn_Click(object sender, EventArgs e)
        {
            if (checkField() == true)
            {
                new Hôtelliere_ImagePopUp().ShowDialog();
                if (Hôtelliere_ImagePopUp.ok)
                {
                    Hôtelliere_ImagePopUp.ok = false;
                    addAccount();
                }
            }
        }
        private void addAccount()
        {
            GlobalProcedure.checkDatabaseConnection();
            GlobalProcedure.sqlCommand.Parameters.Clear();
            GlobalProcedure.sqlCommand.CommandText = "proc_AccountSignUp";
            GlobalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_username", txtUser.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_password", txtPass.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_email", txtEmail.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_address", txtAddress.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_firstname", txtFname.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_lastname", txtLname.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_birthdate", dateBirthdate.Value);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_gender", cmbGender.Text);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_image", Hôtelliere_StartUp.ImageName);

            GlobalProcedure.sqlCommand.ExecuteNonQuery();
            new Hôtelliere_MessagePopUp("Customer is added Successfully", "Success", 1).ShowDialog();

        }
    }
}
