using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class clsAppointmentScheduling
    {
        private Boolean mAvailability;
        public bool Availability
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailability;
            }

            set
            {
                //this line of code allows data into the property
                mAvailability = value;
            }
        }

//        private DateTime mAppointmentDate;
//        public DateTime AppointmentDate
//t charg        {
//            get
//            {
//                //this line of code sends data out of the property
//                return mAppointmentDate;
//            }

//            set
//            {
//                //this line of code allows data into the property
//                mAppointmentDate = value;
//            }
//        }
        private DateTime mAppointmentTime;
        public DateTime AppointmentTime
        {
            get
            {
                //this line of code sends data out of the property
                return mAppointmentTime;
            }

            set
            {
                //this line of code allows data into the property
                mAppointmentTime = value;
            }
        }


        private int mAppointmentId;
        public int AppointmentId
        {
            get
            {
                //this line of code sends data out of the property
                return mAppointmentId;
            }

            set
            {
                //this line of code allows data into the property
                mAppointmentId = value;
            }

        }
        private int mDoctorId;
        public int DoctorId
        {
            get
            {
                //this line of code sends data out of the property
                return mDoctorId;
            }

            set
            {
                //this line of code allows data into the property
                mDoctorId = value;
            }

        }
        private int mPatientId;
        public int PatientId
        {
            get
            {
                //this line of code sends data out of the property
                return mPatientId;
            }

            set
            {
                //this line of code allows data into the property
                mPatientId = value;
            }

        }
        private string mAppointmentNotes;
        public string AppointmentNotes
        {
            get
            {
                //this line of code sends data out of the property
                return mAppointmentNotes;
            }

            set
            {
                //this line of code allows data into the property
                mAppointmentNotes = value;
            }

        }
        /****** FIND METHOD ******/


        public bool Find(int patientId)
        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the patient id to search for
            DB.AddParameter("@AppointmentId", AppointmentId);
            // execute the stored procedure
            DB.Execute("sproc_tblPatientManagement_FilterByAppointmentId");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members 
                mAppointmentId = Convert.ToInt32(DB.DataTable.Rows[0]["AppointmentId"]);
                mDoctorId = Convert.ToInt32(DB.DataTable.Rows[0]["DoctorId"]);
                mPatientId = Convert.ToInt32(DB.DataTable.Rows[0]["PatientId"]);
                mAppointmentNotes = Convert.ToString(DB.DataTable.Rows[0]["Appointment Notes"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                //mAppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Appointment Date"]);
                mAppointmentTime = Convert.ToDateTime(DB.DataTable.Rows[0]["Appointment Time"]);
                // return that everything worked OK
                return true;
            }
            // if no record is found
            else
            {
                // return false indicating a problem
                return false;
            }
        }
    }
}
