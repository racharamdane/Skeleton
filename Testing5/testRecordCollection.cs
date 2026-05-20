using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstRecordCollection
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

            TestList.Add(TestItem);

            AllRecords.RecordList = TestList;
            Assert.AreEqual(AllRecords.RecordList, TestList);
        }
        [TestMethod]
        public void CountRecordOk()
        {
            clsRecordCollection AllRecords = new clsRecordCollection();

            Int32 SomeCount = 0;

            AllRecords.Count = SomeCount;
            Assert.AreEqual(AllRecords.Count, SomeCount);
        }
        [TestMethod]
        public void ThisRecordPropertyOk()
        {
            clsRecordCollection AllRecords = new clsRecordCollection();
            clsMedicalRecord TestItem = new clsMedicalRecord();

            TestItem.Sex = true;
            TestItem.Dob = DateTime.Now;
            TestItem.Medications = "Some medication";
            TestItem.Diagnoses = "some diagnosis";
            TestItem.ClinicalNotes = "some clinical notes";

            AllRecords.ThisAddress = TestItem;
            Assert.AreEqual(AllRecords.RecordList, TestItem);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsRecordCollection AllRecords = new clsRecordCollection();
            List<clsMedicalRecord> TestList = new List<clsMedicalRecord>();
            clsMedicalRecord TestItem = new clsMedicalRecord();

            TestItem.Sex = true;
            TestItem.Dob = DateTime.Now;
            TestItem.Medications = "Some medication";
            TestItem.Diagnoses = "some diagnosis";
            TestItem.ClinicalNotes = "some clinical notes";
            TestList.Add(TestItem);

            AllRecords.RecordList = TestList;

            Assert.AreEqual(AllRecords.Count, TestList.Count);
        }

    }
}
