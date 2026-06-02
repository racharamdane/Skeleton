using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsRecordCollection
    {

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
                Index++;
            }
        }
    }
}
