using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hôtelliere
{
    public partial class US_LogIn : UserControl
    {
        public US_LogIn()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtUser.Texts=string.Empty;
            txtPass.Texts = string.Empty;
            txtUser.Focus();
        }
    }
}
