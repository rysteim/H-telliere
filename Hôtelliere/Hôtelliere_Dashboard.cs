using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hôtelliere
{
    public partial class Hôtelliere_Dashboard : Form
    {
        public Hôtelliere_Dashboard()
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Resources\\HôtellerieIcon.ico");
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
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

        private void Hôtelliere_Dashboard_Load(object sender, EventArgs e)
        {
            profile();
        }

        public void profile()
        {
            lblFname.Text = "Kyrelle";
            lblStatus.Text = "Tenant";
        }
    }
}
