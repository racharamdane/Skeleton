using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsRecordCollection
    {
        public List<clsMedicalRecord> RecordList { get; set; }
        public int Count { get; set; }
        public clsMedicalRecord ThisAddress { get; set; }
    }
}