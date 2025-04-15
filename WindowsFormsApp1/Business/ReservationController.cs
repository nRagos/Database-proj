using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DB;

namespace WindowsFormsApp1.Business
{
    public class ReservationController
    {
        #region Data
        private ReservationsDB reservationsDB;
        private Collection<Reservation> reservations;
        private Collection<string> rooms;
        public int index = 0; //debugging
        #endregion

        #region Getters
        public Collection<Reservation> Reservations
        {
            get { return reservations; }
        }
        #endregion

        #region Constructor
        public ReservationController()
        {
            // Create reservationsDB instance and load the reservations collection
            reservationsDB = new ReservationsDB();
            rooms = reservationsDB.Rooms;
            reservations = reservationsDB.Reservations; // Load reservations from the DB into the collection
            index = reservationsDB.Reservations.Count;
        }
        #endregion

        #region Reservation Analysis

        // Method to get total costs of reservations for the next 3 months, grouped by month
        public Dictionary<DateTime, decimal> GetTotalCostPerMonthNextThreeMonths()
        {
            DateTime now = DateTime.Now;
            DateTime startOfCurrentMonth = new DateTime(now.Year, now.Month, 1); // Start of the current month
            DateTime threeMonthsLater = startOfCurrentMonth.AddMonths(3).AddDays(-1); // End of the last month

            // Pre-populate dictionary with 0 values for the next 3 months
            Dictionary<DateTime, decimal> monthlyCosts = new Dictionary<DateTime, decimal>();
            for (int i = 0; i < 3; i++)
            {
                var month = startOfCurrentMonth.AddMonths(i);
                monthlyCosts[month] = 0;
            }

            // Filter reservations within the next 3 months
            var reservationsNextThreeMonths = reservations
                .Where(r => r.StartDate >= startOfCurrentMonth && r.StartDate <= threeMonthsLater)
                .ToList();

            // Group reservations by month and sum the total cost per month
            var actualMonthlyCosts = reservationsNextThreeMonths
                .GroupBy(r => new { r.StartDate.Year, r.StartDate.Month })
                .Select(g => new
                {
                    Month = new DateTime(g.Key.Year, g.Key.Month, 1), // First day of the month
                    TotalCost = g.Sum(res => res.TotalCost)
                })
                .ToDictionary(x => x.Month, x => x.TotalCost);

            // Merge the actualMonthlyCosts with the pre-populated monthlyCosts
            foreach (var actualCost in actualMonthlyCosts)
            {
                monthlyCosts[actualCost.Key] = actualCost.Value; // Replace the 0 value with the actual cost
            }

            return monthlyCosts
                .OrderBy(x => x.Key) // Ensure the data is ordered by month
                .ToDictionary(x => x.Key, x => x.Value); // Convert to dictionary
        }

        #endregion
        #region Communication with DB
        public void AddToDataSet(Reservation aReservation)
        {
            // Update both the dataSet and the reservations collection
            reservationsDB.UpdateDataSet(aReservation, "add");
            //reservations.Add(aReservation); // Add to local collection
            index=reservationsDB.Reservations.Count;
        }
        public void EditToDataSet(Reservation aReservation)
        {
            reservationsDB.UpdateDataSet(aReservation, "edit");
        }

        public void AddToCollection(Reservation aReservation)
        {
            reservationsDB.Reservations.Add(aReservation);
            reservations = reservationsDB.Reservations;
            index = reservations.Count;
        }

        public bool FinaliseChanges(Reservation aReservation)
        {
            // Use reservationsDB's UpdateDataSource method to save changes to the data source
            return reservationsDB.UpdateDataSource(aReservation);
        }

        public void DataMaintenance(Reservation reservat, string op)
        {
            if (op == "edit")
            {
                reservationsDB.UpdateDataSet(reservat, "edit");
                for (int i = 0; i < reservations.Count; i++)
                {
                    if (reservationsDB.Reservations[i].ReservationID == reservat.ReservationID)
                    {
                        // Replace the reservation by removing and inserting the new one
                        reservationsDB.Reservations.RemoveAt(i);

                        index = i;//debugging
                        reservationsDB.Reservations.Insert(i, reservat);

                        break;
                    }
                }
            }
            else if (op == "delete")
            {
                reservationsDB.UpdateDataSet(reservat, "delete");
                for (int i = 0; i < reservations.Count; i++)
                {
                    if (reservationsDB.Reservations[i].ReservationID == reservat.ReservationID)
                    {
                        // Replace the reservation by removing and inserting the new one
                        reservationsDB.Reservations.RemoveAt(i);

                    }
                }
                reservations = reservationsDB.Reservations;
            }
        }
        #endregion

        #region Helper Methods
        public Reservation GetByReservationId(string reservationId)
        {
            reservations = reservationsDB.Reservations;
            // Find the reservation by its unique ID
            foreach (Reservation reservation in reservations)
            {
                if (reservationId == reservation.ReservationID)
                {
                    
                    return reservation;
                }
            }
            return null;
        }

        public Collection<Reservation >GetReservation(string clientPhone)
        {
            reservations = reservationsDB.Reservations;
            Collection<Reservation> matches= new Collection<Reservation>();
            string identity= ClientController.getID(clientPhone);
            for (int i = 0; i < reservations.Count; i++)
            {

                if (identity == reservations[i].ClientID)
                {

                   // System.Diagnostics.Debug.WriteLine(reservations[i].ReservationID); debugging
                    matches.Add(reservations[i]);
                }
            }

            return matches;

        }

        public bool isAvailable(DateTime startDate, DateTime endDate, string roomID)
        {
            foreach (Reservation reservation in reservations)
            {
                if (roomID == reservation.RoomID)
                {
                    if (startDate >= reservation.StartDate && startDate < reservation.EndDate)
                    {
                        return false;
                    }

                    if (endDate >= reservation.StartDate && endDate < reservation.EndDate)
                    {
                        return false;
                    }
                    if (startDate < reservation.StartDate && endDate > reservation.EndDate)
                    {
                        return false;

                    }


                }

            }
            return true;

           
        }

        public bool isAvailable(DateTime startDate, DateTime endDate, string roomID, string bookingID)
        {

            foreach (Reservation reservation in reservations)
            {
                if (reservation.ReservationID== bookingID)
                {
                    continue;
                }
                if (roomID == reservation.RoomID)
                {
                    if (startDate >= reservation.StartDate && startDate < reservation.EndDate)
                    {
                        return false;
                    }

                    if (endDate >= reservation.StartDate && endDate < reservation.EndDate)
                    {
                        return false;
                    }
                    if (startDate < reservation.StartDate && endDate > reservation.EndDate)
                    {
                        return false;

                    }


                }

            }
            return true;
        }
        #endregion

        #region validations
        public Collection<Reservation> within(DateTime startDate, DateTime endDate)
        {
            Collection<Reservation> matches = new Collection<Reservation>();
            foreach (Reservation res in reservations)
            {
                if ((res.StartDate <= endDate && res.EndDate >= startDate))
                {
                    matches.Add(res);

                }
            }
            return matches;
        }

        public bool validateRoom(string rid)
        {
            foreach (Reservation res in reservations)
            {
                if (res.RoomID == rid)
                {
                    return true;
                }
            }
            return false;
        }
        
        #endregion
    }
}
