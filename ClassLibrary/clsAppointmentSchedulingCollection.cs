using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsAppointmentSchedulingCollection
    {
        //private data member for the list 
        List<clsAppointmentScheduling> mAppointmentList = new List<clsAppointmentScheduling>();
        //private member data for ThisAppointmentScheduling
        clsAppointmentScheduling mThisAppointmentScheduling = new clsAppointmentScheduling();
        //public property for the Appointment list
        public List<clsAppointmentScheduling> AppointmentList
        {
            get
            {
                //return the private data
                return mAppointmentList;
            }
            set
            {
                //set the private data
                mAppointmentList = value;
            }
        }

        //public doctor property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mAppointmentList.Count;
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
                mAppointmentList.Add(AAppointmentScheduling);

                //point at the next record
                Index++;
            }
        }
        
            public int Add()
        {
            //adds a record to the databse based on the values of mThisAppointmentScheduling
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentDate", mThisAppointmentScheduling.AppointmentDate);
            DB.AddParameter("@AppointmentTime", mThisAppointmentScheduling.AppointmentTime);
            DB.AddParameter("@AppointmentNotes", mThisAppointmentScheduling.AppointmentNotes);
            DB.AddParameter("@Availability", mThisAppointmentScheduling.Availability);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblAppointmentScheduling_Insert");

        }
        public void Update()
        {
            //update an existing record based on the values of ThisAppointmentScheduling    
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentId", mThisAppointmentScheduling.AppointmentId);
            DB.AddParameter("@DoctorId", mThisAppointmentScheduling.DoctorId);
            DB.AddParameter("@PatientId", mThisAppointmentScheduling.PatientId);
            DB.AddParameter("@AppointmentDate", mThisAppointmentScheduling.AppointmentDate);
            DB.AddParameter("@AppointmentTime", mThisAppointmentScheduling.AppointmentTime);
            DB.AddParameter("@AppointmentNotes", mThisAppointmentScheduling.AppointmentNotes);
            DB.AddParameter("@Availability", mThisAppointmentScheduling.Availability);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblAppointmentScheduling_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisAppointmentScheduling
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@AppointmentId", mThisAppointmentScheduling.AppointmentId);
            //execute the stored procedure
            DB.Execute("sproc_tblAppointmentScheduling_Delete");
        }

        public static implicit operator clsAppointmentSchedulingCollection(clsAppointmentScheduling v)
        {
            throw new NotImplementedException();
        }
    }

}
    
