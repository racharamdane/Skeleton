using System;

namespace ClassLibrary
{
    public class clsRoomManagement
    {
        public DateTime RoomEntryDate { get; set; }
        public bool TreatmentOver { get; set; }
        public int RoomID { get; set; }
        public int PatientID { get; set; }
        public string RoomName { get; set; }
        public string ClinicalNotes { get; set; }
    }
}