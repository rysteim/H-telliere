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
    public partial class Hôtelliere_ImagePopUp : Form
    {
        public static bool ok = false;
        public string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\MlbbHeroes";
        public Hôtelliere_ImagePopUp()
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
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = directory;
            openFileDialog.Filter = "Images Files (*.png;*.jpg;)|*.png;.jpg;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Hôtelliere_StartUp.ImageName = Path.GetFileName(openFileDialog.FileName);
                picProfile.Image = new Bitmap(openFileDialog.FileName);
                picProfile.BackgroundImage = null;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }

        private void picProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
