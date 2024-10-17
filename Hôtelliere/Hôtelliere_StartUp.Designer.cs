namespace Hôtelliere
{
    partial class Hôtelliere_StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hôtelliere_StartUp));
            this.panel2 = new System.Windows.Forms.Panel();
            this.TabSignUp = new System.Windows.Forms.Label();
            this.TabLogIn = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnLogIn = new RJCodeAdvance.RJControls.RJButton();
            this.btnSignUp = new RJCodeAdvance.RJControls.RJButton();
            this.linkLogIn = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHide = new RJCodeAdvance.RJControls.RJButton();
            this.btnMinimize = new RJCodeAdvance.RJControls.RJButton();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.us_LogIn = new Hôtelliere.US_LogIn();
            this.us_SignUp = new Hôtelliere.US_SignUp();
            this.panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Hôtelliere.Properties.Resources.Log_In;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.TabSignUp);
            this.panel2.Controls.Add(this.TabLogIn);
            this.panel2.Controls.Add(this.MainPanel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 627);
            this.panel2.TabIndex = 1;
            // 
            // TabSignUp
            // 
            this.TabSignUp.Location = new System.Drawing.Point(317, 266);
            this.TabSignUp.Name = "TabSignUp";
            this.TabSignUp.Size = new System.Drawing.Size(142, 56);
            this.TabSignUp.TabIndex = 9;
            this.TabSignUp.Click += new System.EventHandler(this.tabSignUp_Click);
            // 
            // TabLogIn
            // 
            this.TabLogIn.Location = new System.Drawing.Point(317, 203);
            this.TabLogIn.Name = "TabLogIn";
            this.TabLogIn.Size = new System.Drawing.Size(142, 56);
            this.TabLogIn.TabIndex = 8;
            this.TabLogIn.Click += new System.EventHandler(this.tabLogIn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.btnLogIn);
            this.MainPanel.Controls.Add(this.btnSignUp);
            this.MainPanel.Controls.Add(this.us_LogIn);
            this.MainPanel.Controls.Add(this.us_SignUp);
            this.MainPanel.Controls.Add(this.linkLogIn);
            this.MainPanel.Location = new System.Drawing.Point(465, 38);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(614, 511);
            this.MainPanel.TabIndex = 7;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BackgroundImage = global::Hôtelliere.Properties.Resources.btnLogIn;
            this.btnLogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogIn.BorderRadius = 20;
            this.btnLogIn.BorderSize = 0;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(431, 376);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(116, 48);
            this.btnLogIn.TabIndex = 14;
            this.btnLogIn.TextColor = System.Drawing.Color.Transparent;
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.BorderSize = 0;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignUp.Image = global::Hôtelliere.Properties.Resources.btnSign_Up;
            this.btnSignUp.Location = new System.Drawing.Point(292, 376);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(116, 48);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.TextColor = System.Drawing.Color.Transparent;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.tabSignUp_Click);
            // 
            // linkLogIn
            // 
            this.linkLogIn.ActiveLinkColor = System.Drawing.Color.Silver;
            this.linkLogIn.AutoSize = true;
            this.linkLogIn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogIn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLogIn.LinkColor = System.Drawing.Color.White;
            this.linkLogIn.Location = new System.Drawing.Point(24, 471);
            this.linkLogIn.Name = "linkLogIn";
            this.linkLogIn.Size = new System.Drawing.Size(235, 17);
            this.linkLogIn.TabIndex = 11;
            this.linkLogIn.TabStop = true;
            this.linkLogIn.Text = "Already have an account? Log in here...";
            this.linkLogIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogIn_Clicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.pictureBox1);
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
            this.title.Location = new System.Drawing.Point(60, 6);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 27);
            this.title.TabIndex = 19;
            this.title.Text = "Hôtellerie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Hôtelliere.Properties.Resources.HôtellerieIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(19, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
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
            this.btnHide.Location = new System.Drawing.Point(916, 1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(35, 35);
            this.btnHide.TabIndex = 17;
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
            this.btnMinimize.Location = new System.Drawing.Point(957, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 16;
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
            this.btnClose.Location = new System.Drawing.Point(998, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 15;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // us_LogIn
            // 
            this.us_LogIn.BackColor = System.Drawing.Color.Transparent;
            this.us_LogIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("us_LogIn.BackgroundImage")));
            this.us_LogIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.us_LogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.us_LogIn.Location = new System.Drawing.Point(0, 0);
            this.us_LogIn.Name = "us_LogIn";
            this.us_LogIn.Size = new System.Drawing.Size(614, 511);
            this.us_LogIn.TabIndex = 12;
            // 
            // us_SignUp
            // 
            this.us_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.us_SignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("us_SignUp.BackgroundImage")));
            this.us_SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.us_SignUp.Location = new System.Drawing.Point(3, 0);
            this.us_SignUp.Name = "us_SignUp";
            this.us_SignUp.Size = new System.Drawing.Size(603, 515);
            this.us_SignUp.TabIndex = 15;
            // 
            // Hôtelliere_StartUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 634);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Hôtelliere_StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Hôtelliere";
            this.panel2.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.LinkLabel linkLogIn;
        private US_LogIn us_LogIn;
        private RJCodeAdvance.RJControls.RJButton btnSignUp;
        private RJCodeAdvance.RJControls.RJButton btnHide;
        private RJCodeAdvance.RJControls.RJButton btnMinimize;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private System.Windows.Forms.Label TabLogIn;
        private System.Windows.Forms.Label TabSignUp;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RJCodeAdvance.RJControls.RJButton btnLogIn;
        private US_SignUp us_SignUp;
    }
}