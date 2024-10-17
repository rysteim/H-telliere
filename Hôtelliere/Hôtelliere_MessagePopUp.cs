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
    public partial class Hôtelliere_MessagePopUp : Form
    {
        public Hôtelliere_MessagePopUp()
        {
            new Hôtelliere_MessagePopUp("","",1);
        }
        public Hôtelliere_MessagePopUp(String message,String title,int num)
        {
            InitializeComponent();
            this.Icon = new Icon(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Resources\\HôtellerieIcon.ico");
            this.BackColor = Color.Green;
            this.TransparencyKey = Color.Green;
            this.lblMessage.Text = message;
            this.lblTitle.Text = title;
            if (num == 1)
            {
                picImage.Image = global::Hôtelliere.Properties.Resources.PicInformation;
            }
            else if (num == 2)
            {
                picImage.Image = global::Hôtelliere.Properties.Resources.PicQues;
                btnOK.Visible=false;
                btnCancel.Visible = true;
                btnConfirm.Visible = true;
            }
            else
            {
                picImage.Image = global::Hôtelliere.Properties.Resources.PicWarning;
            }
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
