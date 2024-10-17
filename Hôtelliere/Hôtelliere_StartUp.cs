using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hôtelliere.Properties;

namespace Hôtelliere
{
    public partial class Hôtelliere_StartUp : Form
    {
        public static String ImageName = "null.png";
        public static int AccountID = 0;
        public Hôtelliere_StartUp()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Resources\\HôtellerieIcon.ico");
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
            LogIn();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tabLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }

        private void tabSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(us_LogIn.txtUser.Texts) || String.IsNullOrEmpty(us_LogIn.txtPass.Texts))
            {
                new Hôtelliere_MessagePopUp("Please input your Username and Password.", "Don't leave it blank", 3).ShowDialog();
                if (String.IsNullOrEmpty(us_LogIn.txtUser.Texts))
                {
                    us_LogIn.txtUser.Focus();
                }
                else
                {
                    us_LogIn.txtPass.Focus();
                }
            }
            else
            {
                logOn();
            }
        }
        private void logOn()
        {
            GlobalProcedure.checkDatabaseConnection();
            GlobalProcedure.sqlCommand.Parameters.Clear();
            GlobalProcedure.sqlCommand.CommandText = "proc_AccountLogIn";
            GlobalProcedure.sqlCommand.CommandType = CommandType.StoredProcedure;
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_username", us_LogIn.txtUser.Texts);
            GlobalProcedure.sqlCommand.Parameters.AddWithValue("p_password", us_LogIn.txtPass.Texts);
            GlobalProcedure.mySqlDataReader = GlobalProcedure.sqlCommand.ExecuteReader();
            GlobalProcedure.mySqlDataReader.Read();
            bool isNotNull = GlobalProcedure.mySqlDataReader.HasRows;
            if (isNotNull)
            {
                int id = Convert.ToInt32(GlobalProcedure.mySqlDataReader[0]);
                GlobalProcedure.mySqlDataReader.Close();
                us_LogIn.clear();

                this.Hide();
                new Hôtelliere_Dashboard().ShowDialog();
                this.Show();
            }
            else
            {
                new Hôtelliere_MessagePopUp("Incorrect Username or Password", "Access Denied", 1).ShowDialog();
                us_LogIn.txtUser.Select();
            }
            GlobalProcedure.mySqlDataReader.Close();
        }

        private void linkLogIn_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn();
        }
        private void LogIn()
        {
            this.panel2.BackgroundImage = global::Hôtelliere.Properties.Resources.Log_In;
            us_LogIn.BringToFront();
            btnSignUp.BringToFront();
            btnLogIn.BringToFront();
            us_LogIn.clear();
        }
        private void SignUp() { 
            this.panel2.BackgroundImage = global::Hôtelliere.Properties.Resources.Sign_Up;
            us_SignUp.BringToFront();
            linkLogIn.BringToFront();
            us_SignUp.clear();
        }
    }
}
