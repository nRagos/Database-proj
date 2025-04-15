namespace WindowsFormsApp1
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.liveclocklbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homepanel = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.reservepanel = new System.Windows.Forms.Panel();
            this.mainmidpanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentLocpnl = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reservationlbl = new System.Windows.Forms.Label();
            this.clientlbl = new System.Windows.Forms.Label();
            this.Homelbl = new System.Windows.Forms.Label();
            this.reservationsLogic2 = new WindowsFormsApp1.Presentation.ReservationsLogic();
            this.clientLogic2 = new WindowsFormsApp1.Presentation.ClientLogic();
            this.reservationsLogic1 = new WindowsFormsApp1.Presentation.ReservationsLogic();
            this.clientLogic1 = new WindowsFormsApp1.Presentation.ClientLogic();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.homepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.reservepanel.SuspendLayout();
            this.mainmidpanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-11, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 51);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.minimize2;
            this.pictureBox2.Location = new System.Drawing.Point(1184, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(1230, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.liveclocklbl);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.homepanel);
            this.panel2.Controls.Add(this.reservepanel);
            this.panel2.Controls.Add(this.mainmidpanel);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(37, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1287, 681);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // liveclocklbl
            // 
            this.liveclocklbl.AutoSize = true;
            this.liveclocklbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveclocklbl.Location = new System.Drawing.Point(89, 27);
            this.liveclocklbl.Name = "liveclocklbl";
            this.liveclocklbl.Size = new System.Drawing.Size(0, 31);
            this.liveclocklbl.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1024, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group 17 INF2011S Semester Project";
            // 
            // homepanel
            // 
            this.homepanel.BackColor = System.Drawing.Color.MintCream;
            this.homepanel.Controls.Add(this.pictureBox12);
            this.homepanel.Controls.Add(this.pictureBox11);
            this.homepanel.Controls.Add(this.pictureBox10);
            this.homepanel.Controls.Add(this.pictureBox9);
            this.homepanel.Location = new System.Drawing.Point(133, 234);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(965, 351);
            this.homepanel.TabIndex = 0;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = global::WindowsFormsApp1.Properties.Resources.hotelPool;
            this.pictureBox12.Location = new System.Drawing.Point(513, 187);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(367, 151);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 3;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::WindowsFormsApp1.Properties.Resources.hotelOutside;
            this.pictureBox11.Location = new System.Drawing.Point(285, 16);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(195, 322);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 2;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::WindowsFormsApp1.Properties.Resources.hotelRoom;
            this.pictureBox10.Location = new System.Drawing.Point(513, 16);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(367, 153);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 1;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.logo1;
            this.pictureBox9.Location = new System.Drawing.Point(18, 16);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(233, 332);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // reservepanel
            // 
            this.reservepanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservepanel.Controls.Add(this.reservationsLogic2);
            this.reservepanel.Location = new System.Drawing.Point(121, 200);
            this.reservepanel.Name = "reservepanel";
            this.reservepanel.Size = new System.Drawing.Size(957, 417);
            this.reservepanel.TabIndex = 6;
            this.reservepanel.Visible = false;
            // 
            // mainmidpanel
            // 
            this.mainmidpanel.BackColor = System.Drawing.Color.Transparent;
            this.mainmidpanel.Controls.Add(this.clientLogic2);
            this.mainmidpanel.Location = new System.Drawing.Point(121, 200);
            this.mainmidpanel.Name = "mainmidpanel";
            this.mainmidpanel.Size = new System.Drawing.Size(957, 397);
            this.mainmidpanel.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.welcomelbl);
            this.panel8.Location = new System.Drawing.Point(82, 147);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(282, 60);
            this.panel8.TabIndex = 4;
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(16, 15);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(94, 32);
            this.welcomelbl.TabIndex = 0;
            this.welcomelbl.Text = "label2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.currentLocpnl);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.reservationlbl);
            this.panel3.Controls.Add(this.clientlbl);
            this.panel3.Controls.Add(this.Homelbl);
            this.panel3.Location = new System.Drawing.Point(82, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1113, 59);
            this.panel3.TabIndex = 3;
            // 
            // currentLocpnl
            // 
            this.currentLocpnl.BackColor = System.Drawing.Color.Gray;
            this.currentLocpnl.Location = new System.Drawing.Point(205, 19);
            this.currentLocpnl.Name = "currentLocpnl";
            this.currentLocpnl.Size = new System.Drawing.Size(3, 20);
            this.currentLocpnl.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(739, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 52);
            this.panel5.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(375, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 52);
            this.panel4.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.bed;
            this.pictureBox5.Location = new System.Drawing.Point(837, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.customer;
            this.pictureBox4.Location = new System.Drawing.Point(488, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.home;
            this.pictureBox3.Location = new System.Drawing.Point(115, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // reservationlbl
            // 
            this.reservationlbl.AutoSize = true;
            this.reservationlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationlbl.Location = new System.Drawing.Point(872, 18);
            this.reservationlbl.Name = "reservationlbl";
            this.reservationlbl.Size = new System.Drawing.Size(163, 30);
            this.reservationlbl.TabIndex = 3;
            this.reservationlbl.Text = "Reservations";
            this.reservationlbl.Click += new System.EventHandler(this.reservationlbl_Click);
            // 
            // clientlbl
            // 
            this.clientlbl.AutoSize = true;
            this.clientlbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlbl.Location = new System.Drawing.Point(518, 18);
            this.clientlbl.Name = "clientlbl";
            this.clientlbl.Size = new System.Drawing.Size(94, 30);
            this.clientlbl.TabIndex = 2;
            this.clientlbl.Text = "Clients";
            this.clientlbl.Click += new System.EventHandler(this.clientlbl_Click);
            // 
            // Homelbl
            // 
            this.Homelbl.AutoSize = true;
            this.Homelbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homelbl.Location = new System.Drawing.Point(144, 19);
            this.Homelbl.Name = "Homelbl";
            this.Homelbl.Size = new System.Drawing.Size(85, 30);
            this.Homelbl.TabIndex = 0;
            this.Homelbl.Text = "Home";
            this.Homelbl.Click += new System.EventHandler(this.Homelbl_Click);
            // 
            // reservationsLogic2
            // 
            this.reservationsLogic2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsLogic2.Location = new System.Drawing.Point(4, -42);
            this.reservationsLogic2.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsLogic2.Name = "reservationsLogic2";
            this.reservationsLogic2.Size = new System.Drawing.Size(933, 559);
            this.reservationsLogic2.TabIndex = 0;
            // 
            // clientLogic2
            // 
            this.clientLogic2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clientLogic2.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientLogic2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLogic2.Location = new System.Drawing.Point(4, 4);
            this.clientLogic2.Margin = new System.Windows.Forms.Padding(4);
            this.clientLogic2.Name = "clientLogic2";
            this.clientLogic2.Size = new System.Drawing.Size(957, 751);
            this.clientLogic2.TabIndex = 9;
            this.clientLogic2.Visible = false;
            this.clientLogic2.Load += new System.EventHandler(this.clientLogic2_Load_2);
            // 
            // reservationsLogic1
            // 
            this.reservationsLogic1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsLogic1.Location = new System.Drawing.Point(-33, 0);
            this.reservationsLogic1.Margin = new System.Windows.Forms.Padding(4);
            this.reservationsLogic1.Name = "reservationsLogic1";
            this.reservationsLogic1.Size = new System.Drawing.Size(1015, 501);
            this.reservationsLogic1.TabIndex = 0;
            // 
            // clientLogic1
            // 
            this.clientLogic1.Dock = System.Windows.Forms.DockStyle.Top;
            this.clientLogic1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLogic1.Location = new System.Drawing.Point(0, 0);
            this.clientLogic1.Margin = new System.Windows.Forms.Padding(4);
            this.clientLogic1.Name = "clientLogic1";
            this.clientLogic1.Size = new System.Drawing.Size(957, 751);
            this.clientLogic1.TabIndex = 1;
            this.clientLogic1.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.homepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.reservepanel.ResumeLayout(false);
            this.mainmidpanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Label reservationlbl;
        private System.Windows.Forms.Label clientlbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel currentLocpnl;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label welcomelbl;
        private System.Windows.Forms.Panel mainmidpanel;
        private Presentation.ClientLogic clientLogic1;
        private System.Windows.Forms.Panel homepanel;
        private System.Windows.Forms.Panel reservepanel;
        private Presentation.ReservationsLogic reservationsLogic1;
        private Presentation.ClientLogic clientLogic2;
        private Presentation.ReservationsLogic reservationsLogic2;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label liveclocklbl;
    }
}