namespace Hôtelliere
{
    partial class US_Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Dashboard));
            this.btnDashboard = new System.Windows.Forms.Label();
            this.btnRooms = new System.Windows.Forms.Label();
            this.btnTenants = new System.Windows.Forms.Label();
            this.btnPersonnel = new System.Windows.Forms.Label();
            this.btnReservations = new System.Windows.Forms.Label();
            this.btnAP = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.pnlExpand = new System.Windows.Forms.Panel();
            this.uS_DBMinimized = new Hôtelliere.US_DBMinimized();
            this.pnlExpand.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Location = new System.Drawing.Point(0, 79);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(329, 53);
            this.btnDashboard.TabIndex = 0;
            // 
            // btnRooms
            // 
            this.btnRooms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRooms.Location = new System.Drawing.Point(2, 135);
            this.btnRooms.Name = "btnRooms";
            this.btnRooms.Size = new System.Drawing.Size(327, 52);
            this.btnRooms.TabIndex = 1;
            // 
            // btnTenants
            // 
            this.btnTenants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTenants.Location = new System.Drawing.Point(0, 202);
            this.btnTenants.Name = "btnTenants";
            this.btnTenants.Size = new System.Drawing.Size(329, 44);
            this.btnTenants.TabIndex = 2;
            // 
            // btnPersonnel
            // 
            this.btnPersonnel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonnel.Location = new System.Drawing.Point(2, 258);
            this.btnPersonnel.Name = "btnPersonnel";
            this.btnPersonnel.Size = new System.Drawing.Size(327, 48);
            this.btnPersonnel.TabIndex = 3;
            // 
            // btnReservations
            // 
            this.btnReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservations.Location = new System.Drawing.Point(0, 314);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(329, 56);
            this.btnReservations.TabIndex = 4;
            // 
            // btnAP
            // 
            this.btnAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAP.Location = new System.Drawing.Point(0, 373);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(329, 52);
            this.btnAP.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(0, 543);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(329, 44);
            this.btnLogout.TabIndex = 6;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Location = new System.Drawing.Point(0, 16);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(329, 53);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlExpand
            // 
            this.pnlExpand.BackgroundImage = global::Hôtelliere.Properties.Resources.DashboardMenu1;
            this.pnlExpand.Controls.Add(this.btnLogout);
            this.pnlExpand.Controls.Add(this.btnMinimize);
            this.pnlExpand.Controls.Add(this.btnDashboard);
            this.pnlExpand.Controls.Add(this.btnRooms);
            this.pnlExpand.Controls.Add(this.btnAP);
            this.pnlExpand.Controls.Add(this.btnTenants);
            this.pnlExpand.Controls.Add(this.btnReservations);
            this.pnlExpand.Controls.Add(this.btnPersonnel);
            this.pnlExpand.Location = new System.Drawing.Point(0, 3);
            this.pnlExpand.Name = "pnlExpand";
            this.pnlExpand.Size = new System.Drawing.Size(332, 590);
            this.pnlExpand.TabIndex = 9;
            // 
            // uS_DBMinimized
            // 
            this.uS_DBMinimized.BackColor = System.Drawing.Color.Transparent;
            this.uS_DBMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uS_DBMinimized.BackgroundImage")));
            this.uS_DBMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uS_DBMinimized.Location = new System.Drawing.Point(0, 3);
            this.uS_DBMinimized.Name = "uS_DBMinimized";
            this.uS_DBMinimized.Size = new System.Drawing.Size(101, 590);
            this.uS_DBMinimized.TabIndex = 8;
            this.uS_DBMinimized.Click += new System.EventHandler(this.uS_DBMinimized_Click);
            // 
            // US_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.uS_DBMinimized);
            this.Controls.Add(this.pnlExpand);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "US_Dashboard";
            this.Size = new System.Drawing.Size(332, 590);
            this.Load += new System.EventHandler(this.US_Dashboard_Load);
            this.pnlExpand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnDashboard;
        private System.Windows.Forms.Label btnRooms;
        private System.Windows.Forms.Label btnTenants;
        private System.Windows.Forms.Label btnPersonnel;
        private System.Windows.Forms.Label btnReservations;
        private System.Windows.Forms.Label btnAP;
        private System.Windows.Forms.Label btnLogout;
        public System.Windows.Forms.Label btnMinimize;
        private US_DBMinimized uS_DBMinimized;
        public System.Windows.Forms.Panel pnlExpand;
    }
}
