using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsRoomManagementCollection
    {
        //private data member for the list
        List<clsRoomManagement> mRoomList = new List<clsRoomManagement>();
        //private data member for thisRoom
        clsRoomManagement mThisRoom = new clsRoomManagement();

        //constructor for the class
        public clsRoomManagementCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connect
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblRoomManagement_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank room
                clsRoomManagement ARoom = new clsRoomManagement();
                //read in the fields from the current record
                ARoom.RoomID = Convert.ToInt32(DB.DataTable.Rows[Index]["RoomID"]);
                ARoom.TreatmentOver = Convert.ToBoolean(DB.DataTable.Rows[Index]["TreatmentOver"]);
                ARoom.RoomEntryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RoomEntryDate"]);
                ARoom.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                ARoom.RoomName = Convert.ToString(DB.DataTable.Rows[Index]["RoomName"]);
                ARoom.ClinicalNotes = Convert.ToString(DB.DataTable.Rows[Index]["ClinicalNotes"]);
                //add the record to the private data member
                mRoomList.Add(ARoom);
                //point at the next record
                Index++;
            }
        }

        //public property for the room list
        public List<clsRoomManagement> RoomList
        {
            get
            {
                //return the private data
                return mRoomList;
            }
            set
            {
                //set the private data
                mRoomList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mRoomList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        public clsRoomManagement ThisRoom
        {
            get
            {
                //return the private data
                return mThisRoom;
            }
            set
            {
                //set the private data
                mThisRoom = value;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisRoom
            //connect to the databaseq
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@RoomID", mThisRoom.RoomID);
            DB.AddParameter("@RoomName", mThisRoom.RoomName);
            DB.AddParameter("@PatientID", mThisRoom.PatientID);
            DB.AddParameter("@RoomEntryDate", mThisRoom.RoomEntryDate);
            DB.AddParameter("@ClinicalNotes", mThisRoom.ClinicalNotes);
            DB.AddParameter("@TreatmentOver", mThisRoom.TreatmentOver);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblRoomManagement_Insert");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}