namespace WindowsFormsApp1.Presentation
{
    partial class ClientLogic
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
            this.clienttabcontrol = new System.Windows.Forms.TabControl();
            this.Addclienttab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.addclientbtn = new System.Windows.Forms.Button();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Searchclienttab = new System.Windows.Forms.TabPage();
            this.clientListView = new System.Windows.Forms.ListView();
            this.emaillbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.clientsearchbtn = new System.Windows.Forms.Button();
            this.phonesearchtxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.usersTableAdapter1 = new WindowsFormsApp1.Hotel_SystemDataSet1TableAdapters.UsersTableAdapter();
            this.usersTableAdapter2 = new WindowsFormsApp1.Hotel_SystemDataSet1TableAdapters.UsersTableAdapter();
            this.clienttabcontrol.SuspendLayout();
            this.Addclienttab.SuspendLayout();
            this.Searchclienttab.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienttabcontrol
            // 
            this.clienttabcontrol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clienttabcontrol.Controls.Add(this.Addclienttab);
            this.clienttabcontrol.Controls.Add(this.Searchclienttab);
            this.clienttabcontrol.Location = new System.Drawing.Point(19, 4);
            this.clienttabcontrol.Margin = new System.Windows.Forms.Padding(4);
            this.clienttabcontrol.Name = "clienttabcontrol";
            this.clienttabcontrol.SelectedIndex = 0;
            this.clienttabcontrol.Size = new System.Drawing.Size(789, 442);
            this.clienttabcontrol.TabIndex = 0;
            // 
            // Addclienttab
            // 
            this.Addclienttab.Controls.Add(this.label4);
            this.Addclienttab.Controls.Add(this.addclientbtn);
            this.Addclienttab.Controls.Add(this.emailtxt);
            this.Addclienttab.Controls.Add(this.phonetxt);
            this.Addclienttab.Controls.Add(this.nametxt);
            this.Addclienttab.Controls.Add(this.label3);
            this.Addclienttab.Controls.Add(this.label2);
            this.Addclienttab.Controls.Add(this.label1);
            this.Addclienttab.Location = new System.Drawing.Point(4, 30);
            this.Addclienttab.Margin = new System.Windows.Forms.Padding(4);
            this.Addclienttab.Name = "Addclienttab";
            this.Addclienttab.Padding = new System.Windows.Forms.Padding(4);
            this.Addclienttab.Size = new System.Drawing.Size(781, 408);
            this.Addclienttab.TabIndex = 0;
            this.Addclienttab.Text = "Add Client";
            this.Addclienttab.UseVisualStyleBackColor = true;
            this.Addclienttab.Click += new System.EventHandler(this.Addclienttab_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add New Client";
            // 
            // addclientbtn
            // 
            this.addclientbtn.BackColor = System.Drawing.Color.Silver;
            this.addclientbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addclientbtn.Location = new System.Drawing.Point(133, 324);
            this.addclientbtn.Name = "addclientbtn";
            this.addclientbtn.Size = new System.Drawing.Size(144, 35);
            this.addclientbtn.TabIndex = 6;
            this.addclientbtn.Text = "Add Client";
            this.addclientbtn.UseVisualStyleBackColor = false;
            this.addclientbtn.Click += new System.EventHandler(this.addclientbtn_Click_1);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(406, 131);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(262, 27);
            this.emailtxt.TabIndex = 5;
            this.emailtxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(134, 253);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(172, 27);
            this.phonetxt.TabIndex = 4;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(134, 131);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(172, 27);
            this.nametxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // Searchclienttab
            // 
            this.Searchclienttab.Controls.Add(this.clientListView);
            this.Searchclienttab.Controls.Add(this.emaillbl);
            this.Searchclienttab.Controls.Add(this.phonelbl);
            this.Searchclienttab.Controls.Add(this.namelbl);
            this.Searchclienttab.Controls.Add(this.clientsearchbtn);
            this.Searchclienttab.Controls.Add(this.phonesearchtxt);
            this.Searchclienttab.Controls.Add(this.label12);
            this.Searchclienttab.Controls.Add(this.label11);
            this.Searchclienttab.Location = new System.Drawing.Point(4, 30);
            this.Searchclienttab.Name = "Searchclienttab";
            this.Searchclienttab.Size = new System.Drawing.Size(781, 408);
            this.Searchclienttab.TabIndex = 3;
            this.Searchclienttab.Text = "Client Search";
            this.Searchclienttab.UseVisualStyleBackColor = true;
            this.Searchclienttab.Click += new System.EventHandler(this.Searchclienttab_Click);
            // 
            // clientListView
            // 
            this.clientListView.HideSelection = false;
            this.clientListView.Location = new System.Drawing.Point(46, 198);
            this.clientListView.Name = "clientListView";
            this.clientListView.Size = new System.Drawing.Size(533, 174);
            this.clientListView.TabIndex = 24;
            this.clientListView.UseCompatibleStateImageBehavior = false;
            this.clientListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(58, 309);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(0, 21);
            this.emaillbl.TabIndex = 23;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(58, 259);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(0, 21);
            this.phonelbl.TabIndex = 22;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(58, 206);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(0, 21);
            this.namelbl.TabIndex = 21;
            // 
            // clientsearchbtn
            // 
            this.clientsearchbtn.BackColor = System.Drawing.Color.Silver;
            this.clientsearchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientsearchbtn.Location = new System.Drawing.Point(277, 113);
            this.clientsearchbtn.Name = "clientsearchbtn";
            this.clientsearchbtn.Size = new System.Drawing.Size(136, 36);
            this.clientsearchbtn.TabIndex = 19;
            this.clientsearchbtn.Text = "Search";
            this.clientsearchbtn.UseVisualStyleBackColor = false;
            this.clientsearchbtn.Click += new System.EventHandler(this.clientsearchbtn_Click);
            // 
            // phonesearchtxt
            // 
            this.phonesearchtxt.Location = new System.Drawing.Point(46, 118);
            this.phonesearchtxt.Name = "phonesearchtxt";
            this.phonesearchtxt.Size = new System.Drawing.Size(197, 27);
            this.phonesearchtxt.TabIndex = 17;
            this.phonesearchtxt.TextChanged += new System.EventHandler(this.phonesearchtxt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Enter phone number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 33);
            this.label11.TabIndex = 9;
            this.label11.Text = "Client Search";
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // ClientLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clienttabcontrol);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientLogic";
            this.Size = new System.Drawing.Size(812, 751);
            this.Load += new System.EventHandler(this.ClientLogic_Load);
            this.clienttabcontrol.ResumeLayout(false);
            this.Addclienttab.ResumeLayout(false);
            this.Addclienttab.PerformLayout();
            this.Searchclienttab.ResumeLayout(false);
            this.Searchclienttab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl clienttabcontrol;
        private System.Windows.Forms.TabPage Addclienttab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Button addclientbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage Searchclienttab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox phonesearchtxt;
        private System.Windows.Forms.Label label12;
        private Hotel_SystemDataSet1TableAdapters.UsersTableAdapter usersTableAdapter1;
        private Hotel_SystemDataSet1TableAdapters.UsersTableAdapter usersTableAdapter2;
        private System.Windows.Forms.Button clientsearchbtn;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.ListView clientListView;
    }
}
