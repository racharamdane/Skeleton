using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class ClsPatientCollection
    {
        //private data member for the patient list
        List<ClsPatient> mPatientList = new List<ClsPatient>();
        //private member data for ThisPatient
        ClsPatient mThisPatient = new ClsPatient();

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
        //public property for this patient
        public ClsPatient ThisPatient
        {
            get
            {
                //return the private data
                return mThisPatient;
            }
            set
            {
                //set the private data
                mThisPatient = value;
            }
        }

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
                APatient.Treatment = Convert.ToBoolean(DB.DataTable.Rows[Index]["Patienttreatment"]);
                APatient.PatientID = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientID"]);
                APatient.FullName = Convert.ToString(DB.DataTable.Rows[Index]["Patientfullname"]);
                APatient.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["Patientregistrationdate"]);
                APatient.PatientGender = Convert.ToString(DB.DataTable.Rows[Index]["Patientgender"]);
                APatient.PatientPassword = Convert.ToString(DB.DataTable.Rows[Index]["Patientpassword"]);
                APatient.Email = Convert.ToString(DB.DataTable.Rows[Index]["PatientEmail"]);
                //add the patient to the private data member
                mPatientList.Add(APatient);
                //point to the next record
                Index++;
            }


        }
        public int Add()
        {
            //adds a record to the databse based on the values of mThisPatient
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Patientfullname", mThisPatient.FullName);
            DB.AddParameter("@Patientregistrationdate", mThisPatient.DateAdded);
            DB.AddParameter("@Patientgender", mThisPatient.PatientGender);
            DB.AddParameter("@Patientpassword", mThisPatient.PatientPassword);
            DB.AddParameter("@PatientEmail", mThisPatient.Email);
            DB.AddParameter("@Patienttreatment", mThisPatient.Treatment);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblPatientManagement_Insert");

        }
        public void Update()
        {
            //update an existing record based on the values of ThisPatient
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PatientID", mThisPatient.PatientID);
            DB.AddParameter("@Patientfullname", mThisPatient.FullName);
            DB.AddParameter("@Patientregistrationdate", mThisPatient.DateAdded);
            DB.AddParameter("@Patientgender", mThisPatient.PatientGender);
            DB.AddParameter("@Patientpassword", mThisPatient.PatientPassword);
            DB.AddParameter("@PatientEmail", mThisPatient.Email);
            DB.AddParameter("@Patienttreatment", mThisPatient.Treatment);
            //execute the query returning the primary key value
            DB.Execute("sproc_tblPatientManagement_Update");
        }
    }

}