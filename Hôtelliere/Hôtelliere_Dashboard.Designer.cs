namespace Hôtelliere
{
    partial class Hôtelliere_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.picProfile = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.logoHome = new System.Windows.Forms.PictureBox();
            this.btnHide = new RJCodeAdvance.RJControls.RJButton();
            this.btnMinimize = new RJCodeAdvance.RJControls.RJButton();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.uS_Dashboard1 = new Hôtelliere.US_Dashboard();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Hôtelliere.Properties.Resources.DashboardBG;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.uS_Dashboard1);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblFname);
            this.panel2.Controls.Add(this.picProfile);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 627);
            this.panel2.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(897, 78);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(158, 26);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Sample Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFname
            // 
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Black;
            this.lblFname.Location = new System.Drawing.Point(897, 46);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(158, 32);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "Sample Name";
            this.lblFname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picProfile
            // 
            this.picProfile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picProfile.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.picProfile.BorderColor2 = System.Drawing.Color.SpringGreen;
            this.picProfile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picProfile.BorderSize = 3;
            this.picProfile.GradientAngle = 50F;
            this.picProfile.Location = new System.Drawing.Point(828, 41);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(63, 63);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 1;
            this.picProfile.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.logoHome);
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 39);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(46, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 27);
            this.title.TabIndex = 16;
            this.title.Text = "Hôtellerie - Dashboard";
            // 
            // logoHome
            // 
            this.logoHome.BackgroundImage = global::Hôtelliere.Properties.Resources.HôtellerieIcon;
            this.logoHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoHome.Location = new System.Drawing.Point(4, 2);
            this.logoHome.Name = "logoHome";
            this.logoHome.Size = new System.Drawing.Size(35, 35);
            this.logoHome.TabIndex = 15;
            this.logoHome.TabStop = false;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundImage = global::Hôtelliere.Properties.Resources.minus_;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHide.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHide.BorderRadius = 0;
            this.btnHide.BorderSize = 0;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.ForeColor = System.Drawing.Color.White;
            this.btnHide.Location = new System.Drawing.Point(934, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(35, 35);
            this.btnHide.TabIndex = 14;
            this.btnHide.TextColor = System.Drawing.Color.White;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = global::Hôtelliere.Properties.Resources.minimize_;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(975, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Hôtelliere.Properties.Resources.close_;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1016, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // uS_Dashboard1
            // 
            this.uS_Dashboard1.BackColor = System.Drawing.Color.Transparent;
            this.uS_Dashboard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uS_Dashboard1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uS_Dashboard1.Location = new System.Drawing.Point(1, 36);
            this.uS_Dashboard1.Name = "uS_Dashboard1";
            this.uS_Dashboard1.Size = new System.Drawing.Size(332, 588);
            this.uS_Dashboard1.TabIndex = 4;
            // 
            // Hôtelliere_Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 634);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Hôtelliere_Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Hôtelliere";
            this.Load += new System.EventHandler(this.Hôtelliere_Dashboard_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private RJCodeAdvance.RJControls.RJButton btnHide;
        private RJCodeAdvance.RJControls.RJButton btnMinimize;
        private System.Windows.Forms.PictureBox logoHome;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblFname;
        private RJCodeAdvance.RJControls.RJCircularPictureBox picProfile;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.Panel panel2;
        private US_Dashboard uS_Dashboard1;
    }
}