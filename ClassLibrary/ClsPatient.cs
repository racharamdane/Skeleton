using System;

namespace ClassLibrary
{
    public class ClsPatient
    {

        //private dara member for the address id patient
        private Int32 mPatientID;
        //patientId public 
        public int PatientID
        {
            get
            {
                //this line of code sends data out of the patient 
                return mPatientID;
            }
            set
            {
                //this line of code allows data into the property
                mPatientID = value;
            }
        }
        //private data member for the patient full name
        private string mFullName;
        //full name public property
        public string FullName
        {
            get
            {
                //this line of code sends data out of the property
                return mFullName;
            }
            set
            {
                //this line of code allows data into the property
                mFullName = value;

            }
        }
        //private data member for the treatment property
        private Boolean mTreatment;
        //Treatment public property
        public bool Treatment
        {
            get
            {
                //this line of code sends data out of the property
                return mTreatment;
            }
            set
            {
                //this line of code allows data into the property
                mTreatment = value;
            }
        }
        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //private data member for the Patient Gender property
        private string mPatientGender;
        //patient gender public property
        public string PatientGender
        {
            get
            {
                //this line of code sends data out of the property
                return mPatientGender;
            }
            set
            {
                //this line of code allows data into the property
                mPatientGender = value;
            }
        }
        //private data member for the patient email property
        private string mEmail;
        //patient email public property
        public string Email
        {
            get
            {
                //this line of code sends data out of the property
                return mEmail;
            }
            set
            {
                //this line of code allows data into the property
                mEmail = value;
            }
        }
        //private data member for the patient password property
        private string mPatientPassword;
        //patient password public property
        public string PatientPassword
        {
            get
            {
                //this line of code sends data out of the property
                return mPatientPassword;
            }
            set
            {
                //this line of code allows data into the property
                mPatientPassword = value;
            }
        }


        /****** FIND METHOD ******/


        public bool Find(int patientId)
        {
            // create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the patient id to search for
            DB.AddParameter("@PatientID", patientId);
            // execute the stored procedure
            DB.Execute("sproc_tblPatientManagement_FilterByPatientID");
            //If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // copy the data from the database to the private data members 
                mPatientID = Convert.ToInt32(DB.DataTable.Rows[0]["PatientID"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["Patient full name"]);
                mTreatment = Convert.ToBoolean(DB.DataTable.Rows[0]["Patient treatment"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["Patient date of birth"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Patient Email"]);
                mPatientGender = Convert.ToString(DB.DataTable.Rows[0]["Patient gender"]);
                mPatientPassword = Convert.ToString(DB.DataTable.Rows[0]["Patient password"]);
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

        public string Valid(string patientfullname, string patientEmail, string patientgender, string patientpassword)
       {
            //create a string variable to store the error
            String Error = "";
            //if the patient full name is blank
            if (patientfullname.Length == 0)
            {
                //record the error
                Error = Error + "The patient full name may not be blank : ";
            }
            // if the patient name is greater than 50 characters
            if (patientfullname.Length > 50)
            {
                //record the error
                Error = Error + "The patient full name must be less than 50 characters : ";
            }
            //return any error messages
            return Error;
       }
    }
}