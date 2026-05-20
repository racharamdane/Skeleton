using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class testRecordCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsRecordCollection AllRecords = new clsRecordCollection();
            Assert.IsNotNull(AllRecords);
        }
        [TestMethod]
        public void RecordListOk()
        {
            clsRecordCollection AllRecords = new clsRecordCollection();

            List<clsMedicalRecord> TestList = new List<clsMedicalRecord>();
            clsMedicalRecord TestItem = new clsMedicalRecord();

            TestItem.Sex = true;
            TestItem.Dob = DateTime.Now;
            TestItem.Medications = "Some medication";
            TestItem.Diagnoses = "some diagnosis";
            TestItem.ClinicalNotes = "some clinical notes";

        }

    }
}
