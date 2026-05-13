using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDoctorCollection
    {
        //private data member for the list 
        List<clsDoctor> mDoctorList = new List<clsDoctor>();

        //public property for the doctor list
        public List<clsDoctor> DoctorList
        {
            get
            {   
                //return the private data
                return mDoctorList;
            }
            set
            {   
                //set the private data
                mDoctorList = value;
            }
        }

        //public doctor property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mDoctorList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsDoctor ThisDoctor { get; set; }

        public clsDoctorCollection()
        {
            //variable for the index           
            Int32 Index = 0; 
            
            //variable to store the record count
            Int32 RecordCount = 0;

            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblDoctorManagement_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsDoctor ADoctor = new clsDoctor();
                ADoctor.DoctorId = Convert.ToInt32(DB.DataTable.Rows[Index]["DoctorId"]);
                ADoctor.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                ADoctor.Password = Convert.ToString(DB.DataTable.Rows[Index]["Password"]);
                ADoctor.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ADoctor.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                ADoctor.ContractDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractDate"]);
                ADoctor.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);

                //add the record to the private data member
                mDoctorList.Add(ADoctor);

                //point at the next record
                Index++;
            }
            
        }
    }
}