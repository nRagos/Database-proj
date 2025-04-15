using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Presentation;

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {

        private string username;
        private Timer clockTimer;

        public HomePage(string username)
        {
         

            InitializeComponent();
            this.username = username;
            welcomelbl.Text = "Welcome: "+username;

            //Below assists in the dragging logic (Allows mouse interactions with top panel of window)
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            panel1.MouseUp += new MouseEventHandler(panel1_MouseUp);
        }

        public HomePage() // Designer-safe constructor
        {
            username = "Developer"; // Dummy value for design-time
            InitializeComponent();

            if (!this.DesignMode)
            {
                welcomelbl.Text = "Welcome: " + username;
            }

            // You can keep the panel dragging logic; it's safe in the designer
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            panel1.MouseUp += new MouseEventHandler(panel1_MouseUp);
        }
        #region Dragging logic
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;

            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                // Calculate the new position of the form
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging
            dragging = false;
        }
        #endregion

        private void HomePage_Load(object sender, EventArgs e)
        {
            clockTimer = new Timer();
            clockTimer.Interval = 1000; 
            clockTimer.Tick += new EventHandler(UpdateClock); 
            clockTimer.Start(); 
        }

        private void UpdateClock(object sender, EventArgs e)
        {
            liveclocklbl.Text = DateTime.Now.ToString("MMMM dd, yyyy hh:mm:ss tt");
        }
        private void changeLocationPanel(Control label)
        {
            currentLocpnl.Left = label.Right;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();   //Closes entire application
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void clientlbl_Click(object sender, EventArgs e)
        {
            changeLocationPanel(clientlbl);
            clientLogic2.Visible = true;
            homepanel.Visible = false;
            //optionsspanel.Visible = false;
            //roomspanel.Visible = false;
            reservepanel.Visible = false;
        }

        private void Homelbl_Click(object sender, EventArgs e)
        {
            changeLocationPanel(Homelbl);
            clientLogic2.Visible = false;
            homepanel.Visible = true;
            //optionsspanel.Visible = false;
            reservepanel.Visible = false;
            //roomspanel.Visible = false;




        }

        private void roomlbl_Click(object sender, EventArgs e)
        {
            //changeLocationPanel(roomlbl);
            clientLogic2.Visible = false;
            homepanel.Visible = false;
            //optionsspanel.Visible = false;
            reservepanel.Visible = false;
            //roomspanel.Visible = true;


        }

        private void reservationlbl_Click(object sender, EventArgs e)
        {
            changeLocationPanel(reservationlbl);
            clientLogic2.Visible = false;
            homepanel.Visible = false;
            //optionsspanel.Visible = false;
            reservepanel.Visible = true;
            //roomspanel.Visible = false;



        }

        private void optionslbl_Click(object sender, EventArgs e)
        {
            //changeLocationPanel(optionslbl);
            clientLogic2.Visible = false;
            homepanel.Visible = false;
            //optionsspanel.Visible = true;
            reservepanel.Visible = false;
            //roomspanel.Visible = false;



        }

        private void clientLogic2_Load(object sender, EventArgs e)
        {

        }

        private void clientLogic2_Load_1(object sender, EventArgs e)
        {

        }

        private void bookavailablerooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void clientLogic2_Load_2(object sender, EventArgs e)
        {

        }
    }
}
