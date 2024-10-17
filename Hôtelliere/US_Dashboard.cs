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
    public partial class US_Dashboard : UserControl
    {
        public US_Dashboard()
        {
            InitializeComponent();
        }

        private void uS_DBMinimized_Click(object sender, EventArgs e)
        {
            pnlExpand.Visible = true;
            uS_DBMinimized.Visible = false;
        }

        private void US_Dashboard_Load(object sender, EventArgs e)
        {
            pnlExpand.Visible = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            pnlExpand.Visible = false;
            uS_DBMinimized.Visible = true;
        }
    }
}
