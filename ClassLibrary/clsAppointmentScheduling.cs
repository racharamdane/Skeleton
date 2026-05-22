using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsAppointmentScheduling
    {
        private bool mAvailability;
        public bool Availability { get; set; }
        private DateTime mAppointmentTime;
        public DateTime AppointmentTime { get; set; }
        private int mAppointmentId;
        public int AppointmentId { get; set; }
        private int mDoctorId;
        public int DoctorId { get; set; }
        private int mPatientId;
        public int PatientId { get; set; }
        private string mAppointmentNotes;
        public string AppointmentNotes { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool Find(int appointmentId) { /* implementation */ return false; }
        public string Valid(string doctorId, string patientId, string appointmentNotes, string appointmentDate, string appointmentTime, string availability) { /* implementation */ return ""; }
    }
}
