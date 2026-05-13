using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsPatientCollection
    {
        //private data member for the patient list
        List<ClsPatient> mPatientList = new List<ClsPatient>();

        // public property for the patient list
        public List<ClsPatient> PatientList 
            {
            get
            {
                //return the private data
                return mPatientList;
            }
            set
            {
                //set the private data
                mPatientList = value;
            }
        }
        // public property for count of patients
        public int Count 
            {
            get
            {
                //return the count of the list
                return PatientList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        public ClsPatient ThisPatient { get; set; }

        //constructor for the class

        public ClsPatientCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onjection for data connection
              clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblPatientManagement_SelectAll");
            //get the count of records returned
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                 //create a blank patient
                ClsPatient APatient = new ClsPatient();
                //read in the fields from the current record
                APatient.Treatment = Convert.ToBoolean(DB.DataTable.Rows[Index]["Patient treatment"]);
                APatient.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                APatient.FullName = Convert.ToString(DB.DataTable.Rows[Index]["Patient full name"]);
                APatient.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["Patient registration date"]);
                APatient.PatientGender = Convert.ToString(DB.DataTable.Rows[Index]["Patient gender"]);
                APatient.PatientPassword = Convert.ToString(DB.DataTable.Rows[Index]["Patient password"]);
                APatient.Email = Convert.ToString(DB.DataTable.Rows[Index]["Patient Email"]);
                //add the patient to the private data member
                mPatientList.Add(APatient);
                //point to the next record
                Index++;
            }
            

        }
    }

}