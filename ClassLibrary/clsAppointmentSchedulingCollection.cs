using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class clsAppointmentSchedulingCollection
    {
        //private data member for the list 
        List<clsAppointmentScheduling> mAppointmentSchedulingList = new List<clsAppointmentScheduling>();

        //public property for the Appointment list
        public List<clsAppointmentScheduling> AppointmentSchedulingList
        {
            get
            {
                //return the private data
                return mAppointmentSchedulingList;
            }
            set
            {
                //set the private data
                mAppointmentSchedulingList = value;
            }
        }

        //public doctor property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAppointmentSchedulingList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsAppointmentScheduling ThisAppointmentScheduling { get; set; }

        public clsAppointmentSchedulingCollection()
        {
            //variable for the index           
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAppointmentScheduling_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsAppointmentScheduling AAppointmentScheduling = new clsAppointmentScheduling();
                AAppointmentScheduling.AppointmentId = Convert.ToInt32(DB.DataTable.Rows[Index]["AppointmentId"]);
                AAppointmentScheduling.DoctorId = Convert.ToInt32(DB.DataTable.Rows[Index]["DoctorId"]);
                AAppointmentScheduling.PatientId = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientId"]);
                AAppointmentScheduling.AppointmentNotes = Convert.ToString(DB.DataTable.Rows[Index]["Appointment Notes"]);
                AAppointmentScheduling.AppointmentDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Appointment Date"]);
                AAppointmentScheduling.AppointmentTime = Convert.ToDateTime(DB.DataTable.Rows[Index]["Appointment Time"]);
                AAppointmentScheduling.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);

                //add the record to the private data member
                mAppointmentSchedulingList.Add(AAppointmentScheduling);

                //point at the next record
                Index++;
            }

        }
    }
}