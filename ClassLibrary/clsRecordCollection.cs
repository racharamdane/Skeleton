using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsRecordCollection
    {
<<<<<<< HEAD
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

                ARecord.Dob = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dob"]);
                ARecord.Sex = Convert.ToBoolean(DB.DataTable.Rows[Index]["Sex"]);
                ARecord.Medications = Convert.ToString(DB.DataTable.Rows[Index]["Medications"]);
                ARecord.Diagnoses = Convert.ToString(DB.DataTable.Rows[Index]["Diagnoses"]);
                ARecord.ClinicalNotes = Convert.ToString(DB.DataTable.Rows[Index]["ClinicalNotes"]);

                // add the record to the private data member
                mRecordList.Add(ARecord);

                // point at the next record
=======

        List<clsMedicalRecord> mRecordList = new List<clsMedicalRecord>();
        clsMedicalRecord mThisRecord = new clsMedicalRecord();
        public List<clsMedicalRecord> RecordList 
        { 
            get 
            {
                return mRecordList; 
            }
            set 
            {
                mRecordList = value; 
            } 
        }
        public int Count 
        {
            get
            {
               return mRecordList.Count;
            }
            set 
            {
                ///
            }
        }
        public clsMedicalRecord ThisRecord
        {
            get
            {  return mThisRecord; }
            set
            {  mThisRecord = value;}
        }

        public clsRecordCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sroc_tblMedicalRecord_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
                AMedicalRecord.Sex = Convert.ToBoolean(DB.DataTable.Rows[Index]["True"]);
                AMedicalRecord.Dob = Convert.ToDateTime(DB.DataTable.Rows[Index]["01/01/1997"]);
                AMedicalRecord.Medications = Convert.ToString(DB.DataTable.Rows[Index]["Antibiotics"]);
                AMedicalRecord.Diagnoses = Convert.ToString(DB.DataTable.Rows[Index]["Stomach virus"]);
                AMedicalRecord.ClinicalNotes = Convert.ToString(DB.DataTable.Rows[Index]["Some Clinical Notes"]);
                mRecordList.Add(AMedicalRecord);
>>>>>>> 6cc58e06d512c2231777df37be07b946577a4f0d
                Index++;
            }
        }
    }
}
