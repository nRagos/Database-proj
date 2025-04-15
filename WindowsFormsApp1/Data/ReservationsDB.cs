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
    public class ReservationsDB : DB
    {
        #region Data

        private string reservationTable = "Reservations";
        private string queryMain = "SELECT * FROM Reservations";
        private Collection<Reservation> reservations;
        private Collection<string> rooms;

        #endregion

        #region getters
        public Collection<Reservation> Reservations
        {
            get { return reservations; }
        }

        public Collection<string> Rooms
        {
            get { return rooms; }
        }

        #endregion

        #region Constructor
        // Constructor calls parent's constructor, creates connection, and fills the dataset with current info
        public ReservationsDB() : base()
        {
            reservations = new Collection<Reservation>();
            rooms = new Collection<string>();
            FillDataSet(queryMain, reservationTable);
            AddReservationToCollection(reservationTable);
        }
        #endregion

        #region Utility Methods
        public DataSet getDataSet()
        {
            return dataSetMain;
        }
        private void AddRoomsToCollection(string aTable)
        {
            DataRow row = null;
            int r =0;

            foreach (DataRow i in dataSetMain.Tables[aTable].Rows)
            {
                row = i;
                if (!(row.RowState == DataRowState.Deleted))
                {
                    string roomID = Convert.ToString(row["RoomID"]).TrimEnd();

                    rooms.Add(roomID);
                }

            }
        }


        private void AddReservationToCollection(string aTable)
        {
            DataRow row = null;
            Reservation aReservation;

            foreach (DataRow i in dataSetMain.Tables[aTable].Rows)
            {
                row = i;
                if (!(row.RowState == DataRowState.Deleted))
                {
                    // Populate the reservation object from the data row
                    string resID = Convert.ToString(row["ReservationID"]).TrimEnd();
                    string cID = Convert.ToString(row["ClientID"]).TrimEnd();
                    string roomID = Convert.ToString(row["RoomID"]).TrimEnd();
                    DateTime sDate = Convert.ToDateTime(row["StartDate"]);
                    DateTime eDate = Convert.ToDateTime(row["EndDate"]);
                    decimal totCost = Convert.ToDecimal(row["TotalCost"]);
                    bool dPaid = Convert.ToInt32(row["DepositPaid"]) == 1;
                    bool rService = Convert.ToInt32(row["RoomService"]) == 1;

                    // Create a new Reservation object and add it to the collection
                    aReservation = new Reservation(resID, cID, roomID, sDate, eDate, totCost, dPaid, rService);
                    reservations.Add(aReservation);
                }
            }
        }

        private void FillRow(DataRow aRow, Reservation aReservation)
        {
            aRow["ReservationID"] = aReservation.ReservationID;
            aRow["ClientID"] = aReservation.ClientID;
            aRow["RoomID"] = aReservation.RoomID;
            aRow["StartDate"] = aReservation.StartDate;
            aRow["EndDate"] = aReservation.EndDate;
            aRow["TotalCost"] = aReservation.TotalCost;
            aRow["DepositPaid"] = aReservation.DepositPaid ? 1 : 0; // Convert bool to tinyint (0 or 1)
            aRow["RoomService"] = aReservation.DepositPaid ? 1 : 0;
        }

        public int getRow(Reservation aReservation)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dataSetMain.Tables[reservationTable].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aReservation.ReservationID == Convert.ToString(dataSetMain.Tables[reservationTable].Rows[rowIndex]["ReservationID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }

        public void UpdateDataSet(Reservation aReservation, string op)
        {
            DataRow row = null;
            string dataTable = reservationTable;

            if (op == "add")
            {
                row = dataSetMain.Tables[dataTable].NewRow();
                FillRow(row, aReservation);
                dataSetMain.Tables[dataTable].Rows.Add(row);
            }
            else if(op == "edit")
            {
                row = dataSetMain.Tables[dataTable].Rows[getRow(aReservation)];
                FillRow(row, aReservation);
            }else if (op == "delete")
            {
                row = dataSetMain.Tables[dataTable].Rows[getRow(aReservation)];
                dataSetMain.Tables[dataTable].Rows.Remove(row);
            }
        }

        #endregion

        #region Build, Create, and Update

        public void Build_UPDATE_Parameters(Reservation aReservation)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 20, "ReservationID");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ClientID", SqlDbType.NVarChar, 20, "ClientID");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 20, "RoomID");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 20, "StartDate");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 20, "EndDate");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalCost", SqlDbType.Decimal, 20, "TotalCost");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.TinyInt, 1, "DepositPaid");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomService", SqlDbType.TinyInt, 1, "RoomService");
            param.SourceVersion = DataRowVersion.Current;
            dataAdapterMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Reservation aReservation)
        {
            dataAdapterMain.UpdateCommand = new SqlCommand(
                "UPDATE Reservations SET ClientID = @ClientID, RoomID = @RoomID, StartDate = @StartDate, EndDate = @EndDate, " +
                "TotalCost = @TotalCost, DepositPaid = @DepositPaid, RoomService= @RoomService WHERE ReservationID = @Original_ID", connectionMain);

            Build_UPDATE_Parameters(aReservation);
        }

        private void Build_INSERT_Parameters(Reservation aReservation)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@ReservationID", SqlDbType.NVarChar, 20, "ReservationID");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ClientID", SqlDbType.NVarChar, 20, "ClientID");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomID", SqlDbType.NVarChar, 20, "RoomID");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 20, "StartDate");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 20, "EndDate");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalCost", SqlDbType.Decimal, 20, "TotalCost");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DepositPaid", SqlDbType.TinyInt, 1, "DepositPaid");
            dataAdapterMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomService", SqlDbType.TinyInt, 1, "RoomService");
            dataAdapterMain.InsertCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Reservation aReservation)
        {
            dataAdapterMain.InsertCommand = new SqlCommand(
                "INSERT INTO Reservations (ReservationID, ClientID, RoomID, StartDate, EndDate, TotalCost, DepositPaid, RoomService) " +
                "VALUES (@ReservationID, @ClientID, @RoomID, @StartDate, @EndDate, @TotalCost, @DepositPaid, @RoomService)", connectionMain);

            Build_INSERT_Parameters(aReservation);
        }

        public bool UpdateDataSource(Reservation aReservation)
        {
            bool success = true;

            Create_INSERT_Command(aReservation);
            Create_UPDATE_Command(aReservation);

            success = UpdateDataSource(queryMain, reservationTable);
            return success;
        }
        #endregion


    }
}
