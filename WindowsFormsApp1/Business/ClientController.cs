using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DB;

namespace WindowsFormsApp1.Business
{
    public class ClientController
    {
        //This class is incharge of intracting with EmployeeDB and handles the CRUD functionality

        #region Data
        ClientDB clientDB;
        static Collection<Client> clients;
        #endregion

        #region get collection
        public Collection<Client> Clients
        {
            get { return clients; }
        }

        #endregion

        public ClientController()
        {
            //Creates ClientDB instance
            clientDB = new ClientDB();
            clients = clientDB.Clients; //Copies the collection using ClientDB's getter
        }

        #region Communication with DB
        public void AddToDataSet(Client aClient)
        {
            //Updates both the dataSet as well as the clients collection
            clientDB.UpdateDataSet(aClient);
            clients.Add(aClient);
        }

        public void AddToCollection(Client aClient)
        {
            clientDB.Clients.Add(aClient);
           
        }

        public bool FinaliseChanges(Client aClient)
        {
            //ClientDB has a method 'UpdateDataSource' that commits all changes to the dataset
            return clientDB.UpdateDataSource(aClient);
        }
        #endregion


        public Client GetByPhone(string phone)
        {
            foreach (Client client in clients)
            {
                if (phone == client.ClientPhone)
                {
                    
                    return client;
                }
            }
            return null;
        }

        public static string getID(string phone)
        {
            foreach (Client client in clients)
            {
                if (phone == client.ClientPhone)
                {

                    return client.ClientID;
                }
            }
            return null;
        }






    }
}
