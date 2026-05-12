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
        public bool Find(int DoctorId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the docto id to search for
            DB.AddParameter("@DoctorId", DoctorId);
            //execute the stored procedure
            DB.Execute("sproc_tblDoctorManagement_FilterByDoctorId");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mDoctorId = Convert.ToInt32(DB.DataTable.Rows[0]["DoctorId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mContractDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ContractDate"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating there is a problem
                return false;
            }
        }

    }
}