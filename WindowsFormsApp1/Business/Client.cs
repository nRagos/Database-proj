using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Business
{
    public class Client
    {
        #region Data Members
        private string clientID;
        private string clientName;
        private string clientEmail;
        private string clientPhone;
        #endregion

        #region getters and setters

        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string ClientEmail
        {
            get { return clientEmail; }
            set { clientEmail = value; }
        }
        public string ClientPhone
        {
            get { return clientPhone; }
            set { clientPhone = value; }
        }

        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
        #endregion

        #region Constructor
        public Client(string clientID, string clientName, string clientPhone, string clientEmail)
        {
            this.clientID = clientID; //Null cause database auto increments ID
            this.clientName = clientName;
            this.clientEmail = clientEmail;
            this.clientPhone = clientPhone;
        }
        public Client()
        {
            clientID = null;
            clientName = null;
            clientEmail = null;
            clientPhone = null;
        }

        #endregion
    }
}
