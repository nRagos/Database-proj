namespace WindowsFormsApp1.Presentation
{
    partial class ReservationsLogic
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
            System.Windows.Forms.Label roomidbooktxt;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label Deposittxt;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.reservationstab = new System.Windows.Forms.TabControl();
            this.addreservationtab = new System.Windows.Forms.TabPage();
            this.RoomServiceCheck = new System.Windows.Forms.CheckBox();
            this.enddatepick1 = new System.Windows.Forms.DateTimePicker();
            this.startdatepick1 = new System.Windows.Forms.DateTimePicker();
            this.reserveButton = new System.Windows.Forms.Button();
            this.bookingphonetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewreservationstab = new System.Windows.Forms.TabPage();
            this.depositCombo = new System.Windows.Forms.ComboBox();
            this.updateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.updateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.ResCliListView = new System.Windows.Forms.ListView();
            this.clientSearchbtn = new System.Windows.Forms.Button();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.clientSearchtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchreservationstab = new System.Windows.Forms.TabPage();
            this.reservationListView = new System.Windows.Forms.ListView();
            this.reservationsearchbtn = new System.Windows.Forms.Button();
            this.enddatepicker = new System.Windows.Forms.DateTimePicker();
            this.enddatesearch = new System.Windows.Forms.Label();
            this.startdatepicker = new System.Windows.Forms.DateTimePicker();
            this.startdatesearch = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MonthlyReport = new System.Windows.Forms.TabPage();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Revlbl = new System.Windows.Forms.Label();
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.updateRoomCombo = new System.Windows.Forms.ComboBox();
            roomidbooktxt = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            Deposittxt = new System.Windows.Forms.Label();
            this.reservationstab.SuspendLayout();
            this.addreservationtab.SuspendLayout();
            this.viewreservationstab.SuspendLayout();
            this.searchreservationstab.SuspendLayout();
            this.MonthlyReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // roomidbooktxt
            // 
            roomidbooktxt.AutoSize = true;
            roomidbooktxt.Location = new System.Drawing.Point(72, 130);
            roomidbooktxt.Name = "roomidbooktxt";
            roomidbooktxt.Size = new System.Drawing.Size(136, 21);
            roomidbooktxt.TabIndex = 15;
            roomidbooktxt.Text = "Select room ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(429, 184);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(93, 21);
            label10.TabIndex = 19;
            label10.Text = "End date:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(429, 65);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(101, 21);
            label11.TabIndex = 20;
            label11.Text = "Start date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(585, 169);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(101, 21);
            label9.TabIndex = 30;
            label9.Text = "Start date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(585, 233);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(93, 21);
            label12.TabIndex = 29;
            label12.Text = "End date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(583, 25);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(136, 21);
            label13.TabIndex = 25;
            label13.Text = "Select room ID:";
            // 
            // Deposittxt
            // 
            Deposittxt.AutoSize = true;
            Deposittxt.Location = new System.Drawing.Point(583, 103);
            Deposittxt.Name = "Deposittxt";
            Deposittxt.Size = new System.Drawing.Size(181, 21);
            Deposittxt.TabIndex = 31;
            Deposittxt.Text = "Enter Deposit status:";
            // 
            // reservationstab
            // 
            this.reservationstab.Controls.Add(this.addreservationtab);
            this.reservationstab.Controls.Add(this.viewreservationstab);
            this.reservationstab.Controls.Add(this.searchreservationstab);
            this.reservationstab.Controls.Add(this.MonthlyReport);
            this.reservationstab.Location = new System.Drawing.Point(51, 44);
            this.reservationstab.Margin = new System.Windows.Forms.Padding(4);
            this.reservationstab.Name = "reservationstab";
            this.reservationstab.SelectedIndex = 0;
            this.reservationstab.Size = new System.Drawing.Size(914, 440);
            this.reservationstab.TabIndex = 0;
            // 
            // addreservationtab
            // 
            this.addreservationtab.Controls.Add(this.roomCombo);
            this.addreservationtab.Controls.Add(this.RoomServiceCheck);
            this.addreservationtab.Controls.Add(label11);
            this.addreservationtab.Controls.Add(label10);
            this.addreservationtab.Controls.Add(this.enddatepick1);
            this.addreservationtab.Controls.Add(this.startdatepick1);
            this.addreservationtab.Controls.Add(roomidbooktxt);
            this.addreservationtab.Controls.Add(this.reserveButton);
            this.addreservationtab.Controls.Add(this.bookingphonetxt);
            this.addreservationtab.Controls.Add(this.label3);
            this.addreservationtab.Controls.Add(this.label4);
            this.addreservationtab.Location = new System.Drawing.Point(4, 30);
            this.addreservationtab.Margin = new System.Windows.Forms.Padding(4);
            this.addreservationtab.Name = "addreservationtab";
            this.addreservationtab.Padding = new System.Windows.Forms.Padding(4);
            this.addreservationtab.Size = new System.Drawing.Size(906, 406);
            this.addreservationtab.TabIndex = 0;
            this.addreservationtab.Text = "Book a room";
            this.addreservationtab.UseVisualStyleBackColor = true;
            this.addreservationtab.Click += new System.EventHandler(this.addreservationtab_Click);
            // 
            // RoomServiceCheck
            // 
            this.RoomServiceCheck.AutoSize = true;
            this.RoomServiceCheck.Location = new System.Drawing.Point(75, 228);
            this.RoomServiceCheck.Name = "RoomServiceCheck";
            this.RoomServiceCheck.Size = new System.Drawing.Size(144, 25);
            this.RoomServiceCheck.TabIndex = 21;
            this.RoomServiceCheck.Text = "Room Service";
            this.RoomServiceCheck.UseVisualStyleBackColor = true;
            // 
            // enddatepick1
            // 
            this.enddatepick1.Location = new System.Drawing.Point(433, 224);
            this.enddatepick1.Name = "enddatepick1";
            this.enddatepick1.Size = new System.Drawing.Size(242, 27);
            this.enddatepick1.TabIndex = 18;
            // 
            // startdatepick1
            // 
            this.startdatepick1.Location = new System.Drawing.Point(433, 106);
            this.startdatepick1.Name = "startdatepick1";
            this.startdatepick1.Size = new System.Drawing.Size(242, 27);
            this.startdatepick1.TabIndex = 17;
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.Silver;
            this.reserveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reserveButton.Location = new System.Drawing.Point(531, 306);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(144, 35);
            this.reserveButton.TabIndex = 14;
            this.reserveButton.Text = "Submit reservation";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserveButton_Click);
            // 
            // bookingphonetxt
            // 
            this.bookingphonetxt.Location = new System.Drawing.Point(75, 94);
            this.bookingphonetxt.Name = "bookingphonetxt";
            this.bookingphonetxt.Size = new System.Drawing.Size(172, 27);
            this.bookingphonetxt.TabIndex = 13;
            this.bookingphonetxt.TextChanged += new System.EventHandler(this.bookingphonetxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter clients phone number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Book a room";
            // 
            // viewreservationstab
            // 
            this.viewreservationstab.Controls.Add(this.updateRoomCombo);
            this.viewreservationstab.Controls.Add(this.depositCombo);
            this.viewreservationstab.Controls.Add(Deposittxt);
            this.viewreservationstab.Controls.Add(label9);
            this.viewreservationstab.Controls.Add(label12);
            this.viewreservationstab.Controls.Add(this.updateEndPicker);
            this.viewreservationstab.Controls.Add(this.updateStartPicker);
            this.viewreservationstab.Controls.Add(label13);
            this.viewreservationstab.Controls.Add(this.Updatebtn);
            this.viewreservationstab.Controls.Add(this.deletebtn);
            this.viewreservationstab.Controls.Add(this.ResCliListView);
            this.viewreservationstab.Controls.Add(this.clientSearchbtn);
            this.viewreservationstab.Controls.Add(this.phonetxt);
            this.viewreservationstab.Controls.Add(this.clientSearchtxt);
            this.viewreservationstab.Controls.Add(this.label1);
            this.viewreservationstab.Location = new System.Drawing.Point(4, 30);
            this.viewreservationstab.Margin = new System.Windows.Forms.Padding(4);
            this.viewreservationstab.Name = "viewreservationstab";
            this.viewreservationstab.Padding = new System.Windows.Forms.Padding(4);
            this.viewreservationstab.Size = new System.Drawing.Size(906, 406);
            this.viewreservationstab.TabIndex = 1;
            this.viewreservationstab.Text = "View and Edit reservations";
            this.viewreservationstab.UseVisualStyleBackColor = true;
            this.viewreservationstab.Click += new System.EventHandler(this.viewreservationstab_Click);
            // 
            // depositCombo
            // 
            this.depositCombo.FormattingEnabled = true;
            this.depositCombo.Items.AddRange(new object[] {
            "True",
            "False"});
            this.depositCombo.Location = new System.Drawing.Point(589, 127);
            this.depositCombo.Name = "depositCombo";
            this.depositCombo.Size = new System.Drawing.Size(121, 29);
            this.depositCombo.TabIndex = 32;
            this.depositCombo.SelectedIndexChanged += new System.EventHandler(this.depositCombo_SelectedIndexChanged);
            // 
            // updateEndPicker
            // 
            this.updateEndPicker.Location = new System.Drawing.Point(587, 267);
            this.updateEndPicker.Name = "updateEndPicker";
            this.updateEndPicker.Size = new System.Drawing.Size(242, 27);
            this.updateEndPicker.TabIndex = 28;
            // 
            // updateStartPicker
            // 
            this.updateStartPicker.Location = new System.Drawing.Point(587, 198);
            this.updateStartPicker.Name = "updateStartPicker";
            this.updateStartPicker.Size = new System.Drawing.Size(242, 27);
            this.updateStartPicker.TabIndex = 27;
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Silver;
            this.Updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Updatebtn.Location = new System.Drawing.Point(566, 322);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(134, 35);
            this.Updatebtn.TabIndex = 22;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Silver;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.Location = new System.Drawing.Point(737, 322);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(133, 35);
            this.deletebtn.TabIndex = 21;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // ResCliListView
            // 
            this.ResCliListView.HideSelection = false;
            this.ResCliListView.Location = new System.Drawing.Point(30, 198);
            this.ResCliListView.Name = "ResCliListView";
            this.ResCliListView.Size = new System.Drawing.Size(517, 159);
            this.ResCliListView.TabIndex = 20;
            this.ResCliListView.UseCompatibleStateImageBehavior = false;
            this.ResCliListView.SelectedIndexChanged += new System.EventHandler(this.ResCliListView_SelectedIndexChanged);
            // 
            // clientSearchbtn
            // 
            this.clientSearchbtn.BackColor = System.Drawing.Color.Silver;
            this.clientSearchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientSearchbtn.Location = new System.Drawing.Point(270, 133);
            this.clientSearchbtn.Name = "clientSearchbtn";
            this.clientSearchbtn.Size = new System.Drawing.Size(144, 35);
            this.clientSearchbtn.TabIndex = 19;
            this.clientSearchbtn.Text = "Search";
            this.clientSearchbtn.UseVisualStyleBackColor = false;
            this.clientSearchbtn.Click += new System.EventHandler(this.clientSearchbtn_Click);
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(30, 133);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(172, 27);
            this.phonetxt.TabIndex = 17;
            // 
            // clientSearchtxt
            // 
            this.clientSearchtxt.AutoSize = true;
            this.clientSearchtxt.Location = new System.Drawing.Point(26, 88);
            this.clientSearchtxt.Name = "clientSearchtxt";
            this.clientSearchtxt.Size = new System.Drawing.Size(238, 21);
            this.clientSearchtxt.TabIndex = 16;
            this.clientSearchtxt.Text = "Enter Client Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "View all reservations";
            // 
            // searchreservationstab
            // 
            this.searchreservationstab.Controls.Add(this.reservationListView);
            this.searchreservationstab.Controls.Add(this.reservationsearchbtn);
            this.searchreservationstab.Controls.Add(this.enddatepicker);
            this.searchreservationstab.Controls.Add(this.enddatesearch);
            this.searchreservationstab.Controls.Add(this.startdatepicker);
            this.searchreservationstab.Controls.Add(this.startdatesearch);
            this.searchreservationstab.Controls.Add(this.label2);
            this.searchreservationstab.Location = new System.Drawing.Point(4, 30);
            this.searchreservationstab.Margin = new System.Windows.Forms.Padding(4);
            this.searchreservationstab.Name = "searchreservationstab";
            this.searchreservationstab.Size = new System.Drawing.Size(906, 406);
            this.searchreservationstab.TabIndex = 2;
            this.searchreservationstab.Text = "Reservation Occupancy";
            this.searchreservationstab.UseVisualStyleBackColor = true;
            // 
            // reservationListView
            // 
            this.reservationListView.HideSelection = false;
            this.reservationListView.Location = new System.Drawing.Point(30, 165);
            this.reservationListView.Name = "reservationListView";
            this.reservationListView.Size = new System.Drawing.Size(470, 164);
            this.reservationListView.TabIndex = 19;
            this.reservationListView.UseCompatibleStateImageBehavior = false;
            // 
            // reservationsearchbtn
            // 
            this.reservationsearchbtn.BackColor = System.Drawing.Color.Silver;
            this.reservationsearchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationsearchbtn.Location = new System.Drawing.Point(701, 97);
            this.reservationsearchbtn.Name = "reservationsearchbtn";
            this.reservationsearchbtn.Size = new System.Drawing.Size(144, 35);
            this.reservationsearchbtn.TabIndex = 18;
            this.reservationsearchbtn.Text = "Search";
            this.reservationsearchbtn.UseVisualStyleBackColor = false;
            this.reservationsearchbtn.Click += new System.EventHandler(this.reservationsearchbtn_Click);
            // 
            // enddatepicker
            // 
            this.enddatepicker.Location = new System.Drawing.Point(361, 101);
            this.enddatepicker.Name = "enddatepicker";
            this.enddatepicker.Size = new System.Drawing.Size(246, 27);
            this.enddatepicker.TabIndex = 17;
            // 
            // enddatesearch
            // 
            this.enddatesearch.AutoSize = true;
            this.enddatesearch.Location = new System.Drawing.Point(358, 71);
            this.enddatesearch.Name = "enddatesearch";
            this.enddatesearch.Size = new System.Drawing.Size(142, 21);
            this.enddatesearch.TabIndex = 16;
            this.enddatesearch.Text = "Enter end date:";
            // 
            // startdatepicker
            // 
            this.startdatepicker.Location = new System.Drawing.Point(48, 101);
            this.startdatepicker.Name = "startdatepicker";
            this.startdatepicker.Size = new System.Drawing.Size(246, 27);
            this.startdatepicker.TabIndex = 15;
            // 
            // startdatesearch
            // 
            this.startdatesearch.AutoSize = true;
            this.startdatesearch.Location = new System.Drawing.Point(45, 71);
            this.startdatesearch.Name = "startdatesearch";
            this.startdatesearch.Size = new System.Drawing.Size(147, 21);
            this.startdatesearch.TabIndex = 14;
            this.startdatesearch.Text = "Enter start date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reservation search";
            // 
            // MonthlyReport
            // 
            this.MonthlyReport.Controls.Add(this.LoadBtn);
            this.MonthlyReport.Controls.Add(this.RevenueChart);
            this.MonthlyReport.Controls.Add(this.Revlbl);
            this.MonthlyReport.Location = new System.Drawing.Point(4, 30);
            this.MonthlyReport.Name = "MonthlyReport";
            this.MonthlyReport.Size = new System.Drawing.Size(906, 406);
            this.MonthlyReport.TabIndex = 3;
            this.MonthlyReport.Text = "Monthly Revenue Report";
            this.MonthlyReport.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.Silver;
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadBtn.Location = new System.Drawing.Point(667, 85);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(144, 35);
            this.LoadBtn.TabIndex = 22;
            this.LoadBtn.Text = "Load Graph";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // RevenueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RevenueChart.Legends.Add(legend2);
            this.RevenueChart.Location = new System.Drawing.Point(55, 135);
            this.RevenueChart.Name = "RevenueChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.RevenueChart.Series.Add(series2);
            this.RevenueChart.Size = new System.Drawing.Size(643, 242);
            this.RevenueChart.TabIndex = 21;
            this.RevenueChart.Text = "Revenue";
            this.RevenueChart.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Revlbl
            // 
            this.Revlbl.AutoSize = true;
            this.Revlbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Revlbl.Location = new System.Drawing.Point(49, 45);
            this.Revlbl.Name = "Revlbl";
            this.Revlbl.Size = new System.Drawing.Size(549, 33);
            this.Revlbl.TabIndex = 11;
            this.Revlbl.Text = "Expected Revenue for the next 3 months";
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(416, 512);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(150, 150);
            this.userControl1.TabIndex = 1;
            // 
            // roomCombo
            // 
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.roomCombo.Location = new System.Drawing.Point(75, 167);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(121, 29);
            this.roomCombo.TabIndex = 33;
            // 
            // updateRoomCombo
            // 
            this.updateRoomCombo.FormattingEnabled = true;
            this.updateRoomCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.updateRoomCombo.Location = new System.Drawing.Point(589, 60);
            this.updateRoomCombo.Name = "updateRoomCombo";
            this.updateRoomCombo.Size = new System.Drawing.Size(121, 29);
            this.updateRoomCombo.TabIndex = 34;
            // 
            // ReservationsLogic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.reservationstab);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservationsLogic";
            this.Size = new System.Drawing.Size(1037, 559);
            this.Load += new System.EventHandler(this.ReservationsLogic_Load);
            this.reservationstab.ResumeLayout(false);
            this.addreservationtab.ResumeLayout(false);
            this.addreservationtab.PerformLayout();
            this.viewreservationstab.ResumeLayout(false);
            this.viewreservationstab.PerformLayout();
            this.searchreservationstab.ResumeLayout(false);
            this.searchreservationstab.PerformLayout();
            this.MonthlyReport.ResumeLayout(false);
            this.MonthlyReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl reservationstab;
        private System.Windows.Forms.TabPage addreservationtab;
        private System.Windows.Forms.TabPage viewreservationstab;
        private System.Windows.Forms.TabPage searchreservationstab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookingphonetxt;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.DateTimePicker startdatepicker;
        private System.Windows.Forms.Label startdatesearch;
        private System.Windows.Forms.DateTimePicker enddatepicker;
        private System.Windows.Forms.Label enddatesearch;
        private System.Windows.Forms.Button reservationsearchbtn;
        private System.Windows.Forms.DateTimePicker enddatepick1;
        private System.Windows.Forms.DateTimePicker startdatepick1;
        private System.Windows.Forms.UserControl userControl1;
        private System.Windows.Forms.ListView reservationListView;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label clientSearchtxt;
        private System.Windows.Forms.ListView ResCliListView;
        private System.Windows.Forms.Button clientSearchbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DateTimePicker updateEndPicker;
        private System.Windows.Forms.DateTimePicker updateStartPicker;
        private System.Windows.Forms.ComboBox depositCombo;
        private System.Windows.Forms.CheckBox RoomServiceCheck;
        private System.Windows.Forms.TabPage MonthlyReport;
        private System.Windows.Forms.Label Revlbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.ComboBox roomCombo;
        private System.Windows.Forms.ComboBox updateRoomCombo;
    }
}
