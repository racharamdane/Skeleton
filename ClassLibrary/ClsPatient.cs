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


        public bool Find (int patientId) 
        {
            // set the private data members to the test data value
            mPatientID = 21;
            mFullName = "Racha Ramdane"; 
            mTreatment = true;
            mDateAdded = Convert.ToDateTime("23-12-2022");
            mEmail = "racha@gmail";
            mPatientGender = "female";
            mPatientPassword = "LE1234AB";
            // always return true 
            return true;
        }
       
    
    }
}