using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsRecordCollection
    {
        // private data member for the list
        List<clsMedicalRecord> mRecordList = new List<clsMedicalRecord>();

        // public property for the record list
        public List<clsMedicalRecord> RecordList
        {
            get
            {
                // return the private data
                return mRecordList;
            }
            set
            {
                mRecordList = value;
            }
        }

        // public property for count
        public int Count
        {
            get
            {
                // return the count of the list
                return mRecordList.Count;
            }
            set
            {
                //do later
            }
        }

        public clsMedicalRecord ThisRecord { get; set; }

        public clsRecordCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblMedicalRecord_SelectAll");
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create an instance of the record class
                clsMedicalRecord ARecord = new clsMedicalRecord();
                //get the details of the record from the database
                ARecord.Dob = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dob"]);
                ARecord.Sex = Convert.ToBoolean(DB.DataTable.Rows[Index]["Sex"]);
                ARecord.Medications = Convert.ToString(DB.DataTable.Rows[Index]["Medications"]);
                ARecord.Diagnoses = Convert.ToString(DB.DataTable.Rows[Index]["Diagnoses"]);
                ARecord.ClinicalNotes = Convert.ToString(DB.DataTable.Rows[Index]["ClinicalNotes"]);
                //add the record to the private list
                mRecordList.Add(ARecord);

                //point at the next record
                Index++;



            }

        }
    }
}