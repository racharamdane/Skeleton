using System;

namespace ClassLibrary
{
    public class ClsPatient
    {
        public DateTime DateAdded { get; set; }       
        public string PatientGender { get; set; }
        public string PatientPassword { get; set; }
        public bool Treatment { get; set; }
        public string FullName { get; set; }
        public int PatientId { get; set; }
        public string Email { get; set; }
    }
}