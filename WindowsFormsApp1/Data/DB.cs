using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DB
{
    public class DB
    {
        // This creates a connection that works on any computer (uses bin not main file)
        static string baseDir = AppDomain.CurrentDomain.BaseDirectory;
        static string dbFile = Path.Combine(baseDir, @"Hotel System.mdf");
        public SqlConnection connectionMain= new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Hotel System.mdf;Integrated Security=True");

        protected DataSet dataSetMain;
        protected SqlDataAdapter dataAdapterMain;


        public DB()
        {
            try
            {
                //Below creates the connection when DB is creates. 
                //Because a local database is used,dbFile (relative path string) is used
                dataSetMain = new DataSet();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        //Below populates the dataset, sqlQuery refers to a query retrieving the rows and columns we want, table is the 
        //sort of local table we are putting this in. the table belongs in the dataset and not the database
        public void FillDataSet(string sqlQuery, string table)
        {
            try
            {
                dataAdapterMain = new SqlDataAdapter(sqlQuery, connectionMain);
                connectionMain.Open();

                dataSetMain.Clear();  //Clears the dataset so only the current retrieved data is present
                dataAdapterMain.Fill(dataSetMain, table); //Fills the dataset with the relavent rows. The table is called whatever was placed in 'table'

                connectionMain.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message + "  " + err.StackTrace);

            }
            
            

        }


        //Below takes th current dataset (presumabl edited by the user in some way) and pushes those changes to the actual database
        protected bool UpdateDataSource(string sqlQuery, string table)
        {
            bool success;
            try
            {
                //Connects to the database, updates the data on the DB (based off of changes made on the dataset),
                //then closes the connection.
                connectionMain.Open();
                dataAdapterMain.Update(dataSetMain, table);
                connectionMain.Close();

                //Need to refresh the dataset. sqlQuery is a query string that is placed in to retrieve info from the db
                //immediately after its updated
                FillDataSet(sqlQuery, table);
                success = true;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message + "  " + err.StackTrace);
                success = false;
            }
            return success;
        }

    }
}
