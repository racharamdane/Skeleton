using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ClsAppointmentScheduling
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

        private DateTime mAppointmentDate;
        public DateTime AppointmentDate
        {
            get
            {
                //this line of code sends data out of the property
                return mAppointmentDate;
            }

            set
            {
                //this line of code allows data into the property
                mAppointmentDate = value;
            }
        }
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


        public bool Find(int AppointmentId)
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
                mAppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Appointment Date"]);
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

        public string Valid(string appointmentNotes, string appointmentDate, string appointmentTime)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            DateTime TimeTemp;
            //if the appointment notes is blank
            if (appointmentNotes.Length == 0)
            {
                //record the error
                Error = Error + "The appointment notes may not be blank : ";
            }
            //if the appointment date is blank
            if (appointmentDate.Length == 0)
            {
                //record the error
                Error = Error + "The appointment date may not be blank : ";
            }
            else
            {
                try
                {
                    //copy the appointment date value to the DateTemp variable
                    DateTemp = Convert.ToDateTime(appointmentDate);
                    //check to see if the date is in the past
                    if (DateTemp < DateTime.Now.Date)
                    {
                        //record the error
                        Error = Error + "The appointment date cannot be in the past : ";
                    }
                    //check to see if the date is more than 1 year in the future
                    if (DateTemp > DateTime.Now.Date.AddYears(1))
                    {
                        //record the error
                        Error = Error + "The appointment date cannot be more than 1 year in the future : ";
                    }
                }
                catch
                {
                    //record the error
                    Error = Error + "The appointment date was not a valid date : ";
                }
            }
            if (appointmentTime.Length == 0)
            {
                //record the error
                Error = Error + "The appointment time may not be blank : ";
            }
            else
            {
                try
                {
                    TimeTemp = Convert.ToDateTime(appointmentTime);
                }
                catch
                {
                    //record the error
                    Error = Error + "The appointment time" + " was not a valid time : ";
                }
            }
            return Error;
        }

        public string Valid(string doctorId, string patientId, string appointmentNotes, string appointmentDate, string appointmentTime, string availability)
        {
            throw new NotImplementedException();
        }
    }
}
