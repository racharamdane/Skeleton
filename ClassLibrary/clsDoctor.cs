using System;
using System.Data;

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
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["PPassword"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mContractDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ContractDate"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["AAvailability"]);
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

        public string Valid(string fullName, string password, string email, string department, string contractDate)
        {
            //create a string variable to store the error
            string Error = "";

            //create a temporary variable to store the data values
            DateTime DateTemp;

            //if the FullName is blank
            if (fullName.Length == 0)
            {
                //record the error
                Error = Error + "The full name may not be blank : ";
            }
            if (fullName.Length > 50)
            {
                //record the error
                Error = Error + "The full name must be less than 50 characters : ";
            }

            //if the Password is blank
            if (password.Length == 0)
            {
                //record the error
                Error = Error + "The password may not be blank : ";
            }
            if (password.Length > 50)
            {
                //record the error
                Error = Error + "The password must be less than 50 characters : ";
            }

            //if the Email is blank
            if (email.Length == 0)
            {
                //record the error
                Error = Error + "The email may not be blank : ";
            }
            if (email.Length > 50)
            {
                //record the error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //if the Department is blank
            if (department.Length == 0)
            {
                //record the error
                Error = Error + "The department may not be blank : ";
            }
            if (department.Length > 50)
            {
                //record the error
                Error = Error + "The department must be less than 50 characters : ";
            }

            //create an instance of DateTime to compare with DateTemp
            //in the if statements
            DateTime DateComp = DateTime.Now.Date;

            try
            {

                //copy the ContractDate value to the DateTemp variable
                DateTemp = Convert.ToDateTime(contractDate);

                //check to see if the date is less than todays date
                if (DateTemp < DateComp) //compare contractDate with Date
                {
                    //record the error
                    Error = Error + "The contract date cannot be in the past : ";
                }

                //check to see if the date is greater than todays date
                if (DateTemp > DateComp)
                {
                    //record the error
                    Error = Error + "The contract date cannot be in the future : ";
                }

            }

            catch
            {
                // record the error
                Error = Error + "The contract date was not a valid date : ";
            }

            //return any error message
            return Error;
        }

        /****** Statistics Grouped by Department METHOD ******/
        public DataTable StatisticsGroupedByDepartment()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblDoctorManagement_Count_GroupByDepartment");
            //There should be either zero, one or more records
            return DB.DataTable;
        }

        /****** Statistics Grouped by ContractDate METHOD ******/
        public DataTable StatisticsGroupedContactDate()
            {
                //create an instance of the data connection
                clsDataConnection DB = new clsDataConnection();

                //execute the stored procedure
                DB.Execute("sproc_tblDoctorManagement_Count_GroupContractDate");
                //There should be either zero, one or more records
                return DB.DataTable;
            }
    }
}
