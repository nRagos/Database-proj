using System;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Business;

namespace WindowsFormsApp1.Presentation
{
    public partial class ClientLogic : UserControl
    {

        private ClientController cController;
        private Client client;
        public ClientLogic()
        {
            InitializeComponent();
            cController = new ClientController();
            client= new Client();
        }

        public void setUpListView()
        {
            clientListView.View = View.Details;
            ListViewItem clientdetails;
            clientListView.Clear();

            clientListView.Columns.Insert(0, "ID", 120, HorizontalAlignment.Left);
            clientListView.Columns.Insert(1, "Name", 120, HorizontalAlignment.Left);
            clientListView.Columns.Insert(2, "Phone", 90, HorizontalAlignment.Left);
            clientListView.Columns.Insert(3, "Email", 200, HorizontalAlignment.Center);

            clientdetails = new ListViewItem();
            clientdetails.Text = client.ClientID.ToString();
            clientdetails.SubItems.Add(client.ClientName.ToString());
            clientdetails.SubItems.Add(client.ClientPhone.ToString());
            clientdetails.SubItems.Add((client.ClientEmail.ToString()));

            clientListView.Items.Add(clientdetails);
            clientListView.Refresh();
            clientListView.GridLines = true;
        }

        private void addclientbtn_Click_1(object sender, EventArgs e)
        {

            // Gets the user input
            string name = nametxt.Text.Trim();
            string phone = phonetxt.Text.Trim();
            string email = emailtxt.Text.Trim(); // Optional, can be empty (Not all clients may have/want to give their email)
            bool isValid = email.Contains("@") && email.Contains(".");//check email valid
            Client check = cController.GetByPhone(phone);

            // Below ensures non null values are placed in the database
            if (string.IsNullOrEmpty(name) || name.Any(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }
            if (!isValid)
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }
            if (string.IsNullOrEmpty(phone) || phone.Length != 10 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }
            if (check !=null)
            {
                MessageBox.Show("There is an existing client with this phone number");
                return;
            }
            Client client = new Client((cController.Clients.Count+1).ToString(), name, phone, email);
            cController.AddToDataSet(client);
            cController.AddToCollection(client);
            cController.FinaliseChanges(client);

            ClearAll();
            MessageBox.Show("Successfully added to the database");


        }


       

        public void ClearAll()
        {
            nametxt.Text = "";
            emailtxt.Text = "";
            phonetxt.Text = "";
            phonesearchtxt.Text = "";

        }


        // Other event handlers
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Handle text change if needed
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Handle label click if needed
        }


        //Need to implement


        //Need to implement


        //Need to implement
        Collection<Client> clients;
        private void clientsearchbtn_Click(object sender, EventArgs e)
        {
            string phoneSearch = phonesearchtxt.Text.Trim();

            Client aclient = cController.GetByPhone(phoneSearch);
            client= aclient;
            if (aclient == null)
            {
                MessageBox.Show("Client does not exist.");
                return;
            }
            
            //MessageBox.Show(aclient.ClientName);

            namelbl.Text = "Name:     "+aclient.ClientName;
            phonelbl.Text = "Phone:    "+aclient.ClientPhone;
            emaillbl.Text = "Email:    "+aclient.ClientEmail;

            setUpListView();

        }

        private void Searchclienttab_Click(object sender, EventArgs e)
        {

        }

        private void phonesearchtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addclienttab_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientLogic_Load(object sender, EventArgs e)
        {

        }
    }
}
