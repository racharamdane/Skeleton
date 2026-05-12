using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing5
{
    [TestClass]
    public class tstMedicalRecord
    {
        [TestMethod]
        public void PatientIdOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            Int32 TestData = '1';

            AMedicalRecord.IdAdded = TestData;

            Assert.AreEqual(AMedicalRecord.IdAdded, TestData);
        }
        [TestMethod]
        public void InstanceOk()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            Assert.IsNotNull(AMedicalRecord);
        }

        [TestMethod]
        public void DobOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            DateTime TestData = DateTime.Now.Date;

            AMedicalRecord.DateAdded = TestData;

            Assert.AreEqual(AMedicalRecord.DateAdded, TestData);
        }
        [TestMethod]
        public void SexOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            Boolean TestData = true;

            AMedicalRecord.SexAdded = TestData;

            Assert.AreEqual(AMedicalRecord.SexAdded, TestData);
        }
        [TestMethod]
        public void MedicationsOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            String TestData = "Meds";

            AMedicalRecord.MedsAdded = TestData;

            Assert.AreEqual(AMedicalRecord.MedsAdded, TestData);
        }
        [TestMethod]
        public void DiagnosesOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            String TestData = "Ailments";

            AMedicalRecord.DiagsAdded = TestData;

            Assert.AreEqual(AMedicalRecord.DiagsAdded, TestData);
        }
        [TestMethod]
        public void ClinicalNotesOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            String TestData = "Notes";

            AMedicalRecord.NotesAdded = TestData;

            Assert.AreEqual(AMedicalRecord.NotesAdded, TestData);
        }
    }
}
