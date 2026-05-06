using System;

namespace ClassLibrary
{
    public class clsMedicalRecord
    {
        public DateTime DateAdded { get; set; }
        public int IdAdded { get; set; }
        public string MedsAdded { get; set; }
        public string DiagsAdded { get; set; }
        public bool SexAdded { get; set; }
        public string NotesAdded { get; set; }
        public string PrescriptionsAdded { get; set; }
    }
}