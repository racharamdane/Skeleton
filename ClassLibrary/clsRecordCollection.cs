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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblMedicalRecord_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsMedicalRecord ARecord = new clsMedicalRecord();
                ARecord.Dob = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dob"]);
                ARecord.Sex = Convert.ToBoolean(DB.DataTable.Rows[Index]["Sex"]);
                ARecord.Medications = Convert.ToString(DB.DataTable.Rows[Index]["Medications"]);
                ARecord.Diagnoses = Convert.ToString(DB.DataTable.Rows[Index]["Diagnoses"]);
                ARecord.ClinicalNotes = Convert.ToString(DB.DataTable.Rows[Index]["ClinicalNotes"]);
                mRecordList.Add(ARecord);
                Index++;
            }
        }
    }
}