using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using WindowsFormsApp1.Business;
using WindowsFormsApp1.DB;


namespace WindowsFormsApp1.Presentation
{
    public partial class ReservationsLogic : UserControl
    {

        ReservationController rController;
        Reservation ress;

        

        public ReservationsLogic()
        {
            InitializeComponent();
            rController = new ReservationController();

        }

        public void setUpListViewOc(Collection<Reservation> ress) {

            reservationListView.View= View.Details;
            ListViewItem resDetails;
            reservationListView.Columns.Insert(0, "ID", 50, HorizontalAlignment.Left);
            reservationListView.Columns.Insert(1, "ClientID", 70, HorizontalAlignment.Left);
            reservationListView.Columns.Insert(2, "RoomID", 70, HorizontalAlignment.Left);
            reservationListView.Columns.Insert(3, "Start Date", 100, HorizontalAlignment.Left);
            reservationListView.Columns.Insert(4, "End Date", 100, HorizontalAlignment.Left);
            reservationListView.Columns.Insert(5, "Total Cost", 90, HorizontalAlignment.Left);
            reservationListView.Columns.Insert(6, "Deposit", 90, HorizontalAlignment.Center);

            foreach (Reservation r in ress)
            {
                resDetails= new ListViewItem();
                resDetails.Text= r.ReservationID.ToString();
                resDetails.SubItems.Add(r.ClientID.ToString());  
                resDetails.SubItems.Add(r.RoomID.ToString());
                resDetails.SubItems.Add(r.StartDate.ToString());
                resDetails.SubItems.Add(r.EndDate.ToString());
                resDetails.SubItems.Add(r.TotalCost.ToString());
                resDetails.SubItems.Add(r.DepositPaid.ToString());

                reservationListView.Items.Add(resDetails);

            }

            
            reservationListView.Refresh();
            reservationListView.GridLines = true;

        }
        public void setUpListViewSearch(Collection<Reservation> ress)
        {

            ResCliListView.View = View.Details;
            ListViewItem resDetails;
            ResCliListView.Columns.Insert(0, "ID", 50, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(1, "ClientID", 70, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(2, "RoomID", 70, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(3, "Start Date", 100, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(4, "End Date", 100, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(5, "Total Cost", 90, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(6, "Deposit", 80, HorizontalAlignment.Left);
            ResCliListView.Columns.Insert(7, "Room Service", 120, HorizontalAlignment.Center);


            foreach (Reservation r in ress)
            {
                resDetails = new ListViewItem();
                resDetails.Text = r.ReservationID.ToString();
                resDetails.SubItems.Add(r.ClientID.ToString());
                resDetails.SubItems.Add(r.RoomID.ToString());
                resDetails.SubItems.Add(r.StartDate.ToString());
                resDetails.SubItems.Add(r.EndDate.ToString());
                resDetails.SubItems.Add(r.TotalCost.ToString("F2"));
                resDetails.SubItems.Add(r.DepositPaid.ToString());
                resDetails.SubItems.Add(r.RoomService.ToString());

                ResCliListView.Items.Add(resDetails);

            }


            ResCliListView.Refresh();
            ResCliListView.GridLines = true;

        }

        public void ClearAll()
        {
            bookingphonetxt.Clear();
            roomCombo.Text = "";
            reservationListView.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            string phonNum = bookingphonetxt.Text;
            string id= ClientController.getID(phonNum);
            bool roomS= RoomServiceCheck.Checked;
            string roomID = roomCombo.Text.Trim();
            DateTime now = DateTime.Now;
            DateTime startDate = startdatepick1.Value.Date;
            DateTime endDate = enddatepick1.Value.Date;
            bool deposit = false;
            double total = (endDate.Subtract(startDate).TotalDays)+1;
            int price=0;
            int roomServiceCost = 0;
            //calc cost based when the start day is (low/mid/high season)
            if (roomS)
            {
                roomServiceCost = 250;
            }
            if (startDate.Day >= 1 && startDate.Day <= 7)  // Low Season
            {
                price = 550;
            }
            else if (startDate.Day >= 8 && startDate.Day <= 15)  // Mid Season
            {
                price = 750;
            }
            else if (startDate.Day >= 16 && startDate.Day <= 31)  // High Season
            {
                price = 995;
            }

            decimal cost = Convert.ToDecimal((total * price)+(total*roomServiceCost));
            //Validation
            if (id == null)
            {
                MessageBox.Show("Phone Number does not belong to an existing client");
                return;
            }
            if (!rController.validateRoom(roomID))
            {
                MessageBox.Show("Invalid room ID");

            }
            if (startDate > endDate || startDate <now)
            {
                MessageBox.Show("Invalid date");
                return; 
            }
            if (rController.isAvailable(startDate, endDate, roomID))
            {
                Reservation aRes = new Reservation((rController.index + 1).ToString(), id, roomID, startDate, endDate, cost, deposit, roomS);

                rController.AddToDataSet(aRes);
                rController.AddToCollection(aRes);
                rController.FinaliseChanges(aRes);

                ClearAll();
                MessageBox.Show("Successfully added to the database");
            }
            else
            {
                MessageBox.Show("Room is not available");
            }

        }

        private void bookingphonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void addreservationtab_Click(object sender, EventArgs e)
        {

        }

        private void availableListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reservationsearchbtn_Click(object sender, EventArgs e)
        {
            DateTime end = enddatepicker.Value;
            DateTime start= startdatepicker.Value;
            DateTime now= DateTime.Now;
            if (start > end || start< now)
            {
                MessageBox.Show("Invalid date");
                reservationListView.Items.Clear();
                return;
            }
            Collection<Reservation> match = rController.within(start, end);
           

            if (match.Count < 1)
            {
                MessageBox.Show("No reservations within selected time period");
                reservationListView.Items.Clear();
                return;

            }
            ClearAll();

            setUpListViewOc(match);


        }


        private void viewreservationstab_Click(object sender, EventArgs e)
        {

        }

        private void clientSearchbtn_Click(object sender, EventArgs e)
        {
            string ph= phonetxt.Text;
            string id = ClientController.getID(ph);
            //validation
            if (id == null)
            {
                MessageBox.Show("Invalid phone number");
                return;
            }
            Collection<Reservation> aMatches = rController.GetReservation(ph);
            ResCliListView.Clear();
            
            if (aMatches.Count < 1)
            {
                MessageBox.Show("No reservations found for that phone number");
                return;
            }
            setUpListViewSearch(aMatches);
        }

        private void ResCliListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ResCliListView.SelectedItems.Count > 0) // if you selected an item
            {
                ress = rController.GetByReservationId(ResCliListView.SelectedItems[0].Text);
                PopulateText();
            } 
        }

        public void PopulateText()
        {
            updateRoomCombo.Text= ress.RoomID;
            updateStartPicker.Value= ress.StartDate;
            updateEndPicker.Value = ress.EndDate;
            depositCombo.Text= Convert.ToString(ress.DepositPaid);
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string rid= updateRoomCombo.Text;
            DateTime now = DateTime.Now;
            DateTime upStart= updateStartPicker.Value.Date;
            DateTime upEnd = updateEndPicker.Value.Date;
            bool dep = Convert.ToBoolean(depositCombo.Text);

            if (upStart > upEnd|| upStart < now)
            {
                MessageBox.Show("Invalid date");
                ResCliListView.Items.Clear();
                return;
            }
            Reservation reserv= rController.GetByReservationId(ress.ReservationID);
            bool roomS = reserv.RoomService;
            double total = (upEnd.Subtract(upStart).TotalDays)+1;
            int price = 0;
            int roomServiceCost = 0;
            //calc cost based when the start day is (low/mid/high season)
            if (roomS)
            {
                roomServiceCost = 250;
            }
            if (upStart.Day >= 1 && upStart.Day <= 7)  // Low Season
            {
                price = 550;
            }
            else if (upStart.Day >= 8 && upStart.Day <= 15)  // Mid Season
            {
                price = 750;
            }
            else if (upStart.Day >= 16 && upStart.Day <= 31)  // High Season
            {
                price = 995;
            }
            decimal cost = Math.Round(((decimal)total * (decimal)price) + ((decimal)total * (decimal)roomServiceCost), 2, MidpointRounding.AwayFromZero);


            if (rController.isAvailable(upStart, upEnd, rid, reserv.ReservationID))
            {
                Reservation r = new Reservation(reserv.ReservationID, reserv.ClientID, rid, upStart, upEnd, cost, dep, reserv.RoomService);
                rController.DataMaintenance(r, "edit");
                rController.FinaliseChanges(r);

                ClearAll();
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Room is not available");

                return;
            }
            

            clientSearchbtn_Click(sender, e);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

            Reservation reserv = rController.GetByReservationId(ress.ReservationID);
            rController.DataMaintenance(reserv, "delete");
            rController.FinaliseChanges(reserv);

            ResCliListView.Items.Clear();
            MessageBox.Show("Succesfully deleted");

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            var monthlyCosts = rController.GetTotalCostPerMonthNextThreeMonths();

            // Set up the chart
            RevenueChart.Series.Clear(); // Clear any default series

            var series = new Series
            {
                Name = "Expected Booking Income",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Line
            };
            RevenueChart.Series.Add(series);

            // Add data points for each month
            foreach (var monthCost in monthlyCosts)
            {
                series.Points.AddXY(monthCost.Key.ToString("MMMM yyyy"), (double)monthCost.Value);
            }

            // Customize chart appearance
            RevenueChart.ChartAreas[0].AxisX.Title = "Month";
            RevenueChart.ChartAreas[0].AxisY.Title = "Total Cost";
            RevenueChart.ChartAreas[0].AxisX.Interval = 1; // Ensure each month is displayed
            RevenueChart.ChartAreas[0].AxisY.Minimum = 0;  // Adjust Y axis minimum
        }

        private void depositCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReservationsLogic_Load(object sender, EventArgs e)
        {

        }
    }
} 
