using System;

namespace ClassLibrary
{
    public class clsRoomManagement
    {
        //private data meber for the room id property
        
        public DateTime RoomEntryDate { get; set; }
        public bool TreatmentOver { get; set; }
        public Int32 mRoomID
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
        public int PatientID { get; set; }
        public string RoomName { get; set; }
        public string ClinicalNotes { get; set; }

        public bool Find(int roomID)
        {
            //always return true
            return true;
        }
    }
}