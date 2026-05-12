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
            //set the private data members to the test data value
            mRoomID = 1;
            mTreatmentOver = false;
            mRoomEntryDate = Convert.ToDateTime("11/05/2026");
            mPatientID = 1;
            mRoomName = "ObiWan";
            mClinicalNotes = "Patient is doing well";

            //always return true
            return true;
        }
    }
}