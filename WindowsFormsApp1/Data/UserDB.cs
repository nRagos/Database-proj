using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Business;

namespace WindowsFormsApp1.DB
{
    internal class UserDB: DB
    {
        #region Data 
        private string userTable = "Users";
        private string queryMain = "SELECT * FROM Users";
        private Collection<String> users; //This collection is used so we can access the data in here as opposed to directl from the DB 
        private Collection<String> passwords;
        #endregion

        #region Clients getter
        public Collection<string> Users
        {
            get { return users; }
        }

        public Collection<String> Passwords
        {
            get { return passwords; }
        }
        #endregion

        #region Constructor
        //Constructor calls parent's constructor (creates connection and dataset) and then fills the dataset with all current info
        //that is within the client's table.
        public UserDB() : base()
        {
            users = new Collection<string>();
            passwords = new Collection<string>();
            users.Clear();
            FillDataSet(queryMain, userTable);
            AddUserToCollection(userTable); // Fill the clients collection with the dataset data
        }
        #endregion

        private void AddUserToCollection(string aTable)
        {
            //Create a new reference
            DataRow row = null;
            //Now we need to read from the table to populate collection
            foreach (DataRow i in dataSetMain.Tables[aTable].Rows) //Each data row is being taken from the client database (from the dataset)
            {
                row = i;
                if (!(row.RowState == DataRowState.Deleted))//As long as the row is not marked at deleted:
                {

                    users.Add(Convert.ToString(row["Username"]).TrimEnd());
                    passwords.Add(Convert.ToString(row["Password"]).TrimEnd());
                }
            }
        }
    }
}
