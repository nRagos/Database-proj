using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Business;

namespace WindowsFormsApp1.DB
{
    public class ClientDB:DB
    {
        #region information
        //This class is where we do all the client database access and manipulation
        #endregion

        #region Data
        //All we really care about is the one client table here and the simple query string retrieving all its contents
        private string clientTable = "Clients";
        private string queryMain = "SELECT * FROM Clients";
        private Collection<Client> clients; //This collection is used so we can access the data in here as opposed to directl from the DB 
        #endregion

        #region Clients getter
        public Collection<Client> Clients
        {
            get { return clients; }
        }
        #endregion

        #region Constructor
        //Constructor calls parent's constructor (creates connection and dataset) and then fills the dataset with all current info
        //that is within the client's table.
        public ClientDB() : base() 
        {
            clients = new Collection<Client>();
            clients.Clear();
            FillDataSet(queryMain, clientTable);
            AddClientToCollection(clientTable); // Fill the clients collection with the dataset data
        }
        #endregion

        #region Utility methods
        //These methods help with general clientDB functionality
        public DataSet getDataSet()
        {
            return dataSetMain;
        }

        private void AddClientToCollection(string aTable)
        {
            //Create a new reference
            DataRow row = null;
            Client aClient;
            //Now we need to read from the table to populate collection
            foreach(DataRow i in dataSetMain.Tables[aTable].Rows) //Each data row is being taken from the client database (from the dataset)
            {
                row = i;
                if(!(row.RowState == DataRowState.Deleted))//As long as the row is not marked at deleted:
                {
                    //Create a new client object
                    aClient = new Client();
                    //Grab each attribute from the specific field in th row in the table
                    aClient.ClientID = Convert.ToString(row["ClientID"]).TrimEnd();  //We may need the id when adding to the list, but we dont need it when adding to dataset
                    aClient.ClientName = Convert.ToString(row["Name"]).TrimEnd();
                    aClient.ClientPhone = Convert.ToString(row["Phone"]).TrimEnd();
                    aClient.ClientEmail = Convert.ToString(row["Email"]).TrimEnd();

                    clients.Add(aClient); //Adds the client to the collection
                }
            }
        }

        private void FillRow(DataRow aRow, Client aClient)
        {
            aRow["ClientID"] = (clients.Count + 1).ToString();
            aRow["Name"] = aClient.ClientName;
            aRow["Phone"] = aClient.ClientPhone;
            aRow["Email"] = aClient.ClientEmail;
        }

        //Below takes in a client object and adds it's details to a row in the DataSet
        public void UpdateDataSet(Client aClient)
        {
            //A DataRow is an object reprsenting a row in the DataSet
            DataRow row = null; 
            string dataTable = clientTable;

            //Create a new row by using the main dataset object referring to the client table
            row = dataSetMain.Tables[dataTable].NewRow();
            FillRow(row, aClient); //uses above FillRow method to populate the row in the DataSet

            dataSetMain.Tables[dataTable].Rows.Add(row); //Adds the row with the client object details to the database


        }
        #endregion

        #region Build, create and update
        //The below methods are incharge of setting parameters for insertion, creating the sql query using those parameters,
        //update the data


        public void Build_UPDATE_Parameters(Client aClient)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 20, "ClientID");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 20, "Name");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Client aClient)
        {
            dataAdapterMain.UpdateCommand = new SqlCommand("UPDATE Client SET Name =@Name, Phone =@Phone, Email =@Email" + "WHERE ClientID =@Original_ID", connectionMain);
            Build_UPDATE_Parameters(aClient); //Not needed really
        }


        private void Build_INSERT_Parameters(Client aclient)
        {
            //Sets the parameter to the default(null) which will be used and modified later
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ClientID", SqlDbType.NVarChar, 20, "ClientID");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 20, "Name");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Phone", SqlDbType.NVarChar, 10, "Phone");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            dataAdapterMain.InsertCommand.Parameters.Add(param);
            //All parameters are set in this method. If we use this, we are safe against sql injections.
       
        
        }

        private void Create_INSERT_Command(Client aClient)
        {
            //Simply creates the sql query statement and uses the dataadapter to insert
            //NB this prepares the command but its not actually executed yet.
            dataAdapterMain.InsertCommand = new SqlCommand("INSERT INTO Clients (ClientID, Name, Phone, Email) VALUES (@ClientID, @Name, @Phone, @Email)", connectionMain);
            //Below sets up the parameters that was defined in the line above
            Build_INSERT_Parameters(aClient);
        }

        //Below takes the client and adds them to the database by executing the command in the previous method.
        //This method is public as it is actually what will be accessed outside this class, the previous two are its helper methods
        public bool UpdateDataSource(Client aClient)
        {
     
            bool success = true;
            Create_INSERT_Command(aClient);
            Create_UPDATE_Command(aClient);

            success = UpdateDataSource(queryMain, clientTable);

            return success;
                
    
        }

        #endregion

        #region validity checks
        //Below checks to see if a client is already on the system based off of their phone number and email.
        //can be used when adding a clint so we can first check if they exist, and can also be used when deleting a client.
        public bool CheckClientExists(string phoneNumber, string email)
        {
            //Loops through each DataRow in the client table
            foreach (DataRow row in dataSetMain.Tables[clientTable].Rows)
            {
                //Checks to see if the current row's Phone or Email matches the provided values
                if (row.Field<string>("Phone") == phoneNumber || row.Field<string>("Email") == email)
                {
                    // Return true if a match is found
                    return true;
                }
            }

            // Return false if no matches were found
            return false;
        }


        #endregion
    }
}
