using System;

namespace ClassLibrary
{
    public class clsDoctor
    {
        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }

            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }

        private DateTime mContractDate;
        public DateTime ContractDate
        {
            get
            {
                //this line of code sends data out of the property
                return mContractDate;
            }

            set
            {
                //this line of code allows data into the property
                mContractDate = value;
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
        private string mFullName;
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
        private string mDepartment;
        public string Department 
        {
            get
            {
                //this line of code sends data out of the property
                return mDepartment;
            }

            set
            {
                //this line of code allows data into the property
                mDepartment = value;
            }

        }
        private string mEmail;
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
        private string mPassword;
        public string Password 
        {
            get
            {
                //this line of code sends data out of the property
                return mPassword;
            }

            set
            {
                //this line of code allows data into the property
                mPassword = value;
            }

        }
        public bool Find(int doctorId)
        {
            //set the private data members to the test data value
            mDoctorId = 14;
            mFullName = "Jess Simpson";
            mPassword = "JS6";
            mEmail = "js@gmail.com";
            mDepartment = "Dermatology";
            mContractDate = Convert.ToDateTime("08/05/2026");
            mAvailable = true;

            // always return true
            return true;
        }

    }
}