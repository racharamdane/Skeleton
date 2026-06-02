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
            // variable for the index
            Int32 Index = 0;

            // variable to store the record count
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMedicalRecord_SelectAll");

            // get the count of records
            RecordCount = DB.Count;

            // while there are records to process
            while (Index < RecordCount)
            {
                // create a blank record
                clsMedicalRecord ARecord = new clsMedicalRecord();

                ARecord.PatientId = Convert.ToInt32(DB.DataTable.Rows[Index]["PatientId"]);
                ARecord.Dob = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dob"]);
                ARecord.Sex = Convert.ToBoolean(DB.DataTable.Rows[Index]["Sex"]);
                ARecord.Medications = Convert.ToString(DB.DataTable.Rows[Index]["Medications"]);
                ARecord.Diagnoses = Convert.ToString(DB.DataTable.Rows[Index]["Diagnoses"]);
                ARecord.ClinicalNotes = Convert.ToString(DB.DataTable.Rows[Index]["ClinicalNotes"]);

                // add the record to the private data member
                mRecordList.Add(ARecord);

                // point at the next record
                Index++;
            }
        }
    }
}