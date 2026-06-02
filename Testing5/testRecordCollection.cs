using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Testing5
{
    [TestClass]
    public class testRecordCollection
    {
        public bool OK { get; private set; }

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
        public void ThisRecordPropertyOk()
        {
            clsRecordCollection AllRecords = new clsRecordCollection();
            clsMedicalRecord TestItem = new clsMedicalRecord();

            TestItem.Sex = true;
            TestItem.Dob = DateTime.Now;
            TestItem.Medications = "Some medication";
            TestItem.Diagnoses = "some diagnosis";
            TestItem.ClinicalNotes = "some clinical notes";

            AllRecords.ThisRecord = TestItem;
            Assert.AreEqual(AllRecords.ThisRecord, TestItem);
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
            TestList.Add(TestItem);

            AllRecords.RecordList = TestList;

            Assert.AreEqual(TestList.Count, AllRecords.Count);
        }


    }
}
