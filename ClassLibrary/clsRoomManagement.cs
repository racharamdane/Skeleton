using System;

namespace ClassLibrary
{
    public class clsRoomManagement
    {
        //private data meber for the room id property
        private Int32 mRoomID;
        private bool mTreatmentOver;
        private DateTime mRoomEntryDate;
        private Int32 mPatientID;
        private string mRoomName;
        private string mClinicalNotes;

        public DateTime RoomEntryDate
        {
            get
            {
               //this line of code sends data out of the property
                return mRoomEntryDate;
            }
            set
            {
                //this line of code allows data into the property
                mRoomEntryDate = value;
            }
        }
        public bool TreatmentOver
        {
            get
            {
                //this line of code sends data out of the property
                return mTreatmentOver;
            }
            set
            {
                //this line of code allows data into the property
                mTreatmentOver = value;
            }
        }
        public Int32 RoomID
        {
            get
            {
                //this line of code sends data out of the property
                return mRoomID;
            }
            set
            {
                //this line of code allows data into the property
                mRoomID = value;
            }
        }
        public int PatientID
        {
            get
            {
                //this line of code sends data out of the property
                return mPatientID;
            }
            set
            {
                //this line of code allows data into the property
                mPatientID = value;
            }
        }
        public string RoomName
        {
            get
            {
                //this line of code sends data out of the property
                return mRoomName;
            }
            set
            {
                //this line of code allows data into the property
                mRoomName = value;
            }
        }
        public string ClinicalNotes
        {
            get
            {
                //this line of code sends data out of the property
                return mClinicalNotes;
            }
            set
            {
                //this line of code allows data into the property
                mClinicalNotes = value;
            }
        }

        public bool Find(int roomID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the room id to search for
            DB.AddParameter("@RoomID", roomID);
            //execute the stored procedure
            DB.Execute("sproc_tblRoomManagement_FilterByRoomID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mRoomID = Convert.ToInt32(DB.DataTable.Rows[0]["RoomID"]);
                mTreatmentOver = Convert.ToBoolean(DB.DataTable.Rows[0]["TreatmentOver"]);
                mRoomEntryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RoomEntryDate"]);
                mPatientID = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mRoomName = Convert.ToString(DB.DataTable.Rows[0]["RoomName"]);
                mClinicalNotes = Convert.ToString(DB.DataTable.Rows[0]["ClinicalNotes"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}