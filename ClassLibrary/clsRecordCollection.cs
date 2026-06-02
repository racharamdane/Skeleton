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
    }
}