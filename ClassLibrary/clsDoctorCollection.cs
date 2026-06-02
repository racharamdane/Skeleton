using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDoctorCollection
    {
        //private data member for the list 
        List<clsDoctor> mDoctorList = new List<clsDoctor>();
        //private member data for ThisDoctor
        clsDoctor mThisDoctor = new clsDoctor();

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
        public clsDoctor ThisDoctor
        {
            get
            {
                //return the private data
                return mThisDoctor;
            }

            set
            {
                //set the private data
                mThisDoctor = value;
            }
        }


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
                ADoctor.Password = Convert.ToString(DB.DataTable.Rows[Index]["PPassword"]);
                ADoctor.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ADoctor.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
                ADoctor.ContractDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ContractDate"]);
                ADoctor.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["AAvailability"]);

                //add the record to the private data member
                mDoctorList.Add(ADoctor);

                //point at the next record
                Index++;
            }
            
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisDoctor
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@FullName", mThisDoctor.FullName);
            DB.AddParameter("@PPassword", mThisDoctor.Password);
            DB.AddParameter("@Email", mThisDoctor.Email);
            DB.AddParameter("@Department", mThisDoctor.Department);
            DB.AddParameter("@ContractDate", mThisDoctor.ContractDate);
            DB.AddParameter("@AAvailability", mThisDoctor.Available);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDoctorManagement_Insert");
        }

        public void Update()
        {
            {
                //updates an existing record based on the values of mThisDoctor
                //connect to the database
                clsDataConnection DB = new clsDataConnection();
                //set the parameters for the stored procedure
                DB.AddParameter("@DoctorId", mThisDoctor.DoctorId);
                DB.AddParameter("@FullName", mThisDoctor.FullName);
                DB.AddParameter("@PPassword", mThisDoctor.Password);
                DB.AddParameter("@Email", mThisDoctor.Email);
                DB.AddParameter("@Department", mThisDoctor.Department);
                DB.AddParameter("@ContractDate", mThisDoctor.ContractDate);
                DB.AddParameter("@AAvailability", mThisDoctor.Available);

                //execute the stored procedure
                DB.Execute("sproc_tblDoctorManagement_Update");
            }
        }

        public void Delete()
        {
            //deletes the record pointed to by thisDoctor
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DoctorId", mThisDoctor.DoctorId);
            //execute the stored procedure
            DB.Execute("sproc_DoctorManagement_Delete");
        }
    }
}