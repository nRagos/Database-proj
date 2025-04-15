using System;

namespace WindowsFormsApp1.Business
{
    public class Reservation
    {
        #region Data Members
        private string reservationID;
        private string clientID;
        private string roomID;
        private DateTime startDate;
        private DateTime endDate;
        private decimal totalCost;
        private bool depositPaid;
        private bool roomService;
        #endregion

        #region Getters and Setters
        public string ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }
        public bool RoomService
        {
            get { return roomService; }
            set { roomService = value; }
        }
        public string ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public string RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }

        public bool DepositPaid
        {
            get { return depositPaid; }
            set { depositPaid = value; }
        }
        #endregion

        #region Constructors

        // Regular constructor (constructor with parameters)
        public Reservation(string reservationID, string clientID, string roomID, DateTime startDate, DateTime endDate, decimal totalCost, bool depositPaid, bool roomService)
        {
            this.reservationID = reservationID;
            this.clientID = clientID;
            this.roomID = roomID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.totalCost = totalCost;
            this.depositPaid = depositPaid;
            this.roomService = roomService;
        }
        #endregion
    }
}
