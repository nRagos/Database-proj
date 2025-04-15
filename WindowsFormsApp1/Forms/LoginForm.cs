using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //For database communication and access
using System.Data;              //For local database management (include definition for dataset)
using WindowsFormsApp1.Business;
using WindowsFormsApp1.DB;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        UserDB userDB;
        DataSet ds = new DataSet();    //We need a dataset to be active for the entire lifespan of the program (so we can access it for various events)
        
        //Below code ensures this can run on any computer (uses relative path for database instead of absolute)
        //Connection is needed to access/connect to the database

        SqlDataAdapter adapter = new SqlDataAdapter();



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

        public LoginForm()
        {
            InitializeComponent();

            //Below assists in the dragging logic (Allows mouse interactions with top panel of window)
            panel1.MouseDown += new MouseEventHandler(panel1_MouseDown);
            panel1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            panel1.MouseUp += new MouseEventHandler(panel1_MouseUp);
            userDB= new UserDB();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_MouseHover(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();   //Closes entire application

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            string username = usernametxtbox.Text;
            //DEBUGGING
            //HomePage home = new HomePage(username);
            //home.Show();
            //this.Hide();
            string password = passwordtxtbox.Text;
            if(username.Trim() == string.Empty || password.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill in all fields ");
                return;

            }
            // Simple query that counts matching rows
            // Not safe against sql injections
            bool userB = false;
            for(int i=0; i< userDB.Users.Count;i++)
            {
                if (username == userDB.Users[i] && password == userDB.Passwords[i]) {
                   userB = true;
                    break;
                }
            }

            if (userB)
            {
                MessageBox.Show("Login successful!\n Welcome " + username);
                HomePage home = new HomePage(username);
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            //string query = $"SELECT COUNT(1) FROM Users WHERE Username = '{username}' AND Password = '{password}'";

            //try
            //{
            //    connection.Open();

            //    using (SqlCommand command = new SqlCommand(query, connection))   //"Using" ensures the command object is destroyed after the block
            //    {
            //        // Use ExecuteScalar to get a single result (1 or 0)
            //        // ExecuteScalar checks to see if the one row i requsted was present or not.
            //        // 1 = present 0 = Non existent
            //        int count = (int)command.ExecuteScalar();

            //        if (count == 1)
            //        {
            //            MessageBox.Show("Login successful!\n Welcome "+username);
            //            HomePage home = new HomePage(username);
            //            home.Show();
            //            this.Hide();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Invalid username and/or password.\nPlease try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show("An error has occured");
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }

        private void usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginbox_Enter(object sender, EventArgs e)
        {

        }
    }
}
