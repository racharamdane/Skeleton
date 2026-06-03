using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsRoomManagementCollection
    {
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

        //private data member for the list
        List<clsRoomManagement> mRoomList = new List<clsRoomManagement>();
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
        public clsRoomManagement ThisRoom { get; set; }
    }
}