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
        public void FindMethodOk()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
 
            Assert.IsTrue(Found);
        }
        public void TestPatientIdFound()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
            if(AMedicalRecord.IdAdded != 1234571)
            { 
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        public void TestDobFound()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
            if (AMedicalRecord.DateAdded != Convert.ToDateTime("12/12/2012"))
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        public void TestSexFound()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
            if (AMedicalRecord.SexAdded != true)
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        public void TestMedicationsFound()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
            if (AMedicalRecord.MedsAdded != "Test Meds")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        public void TestDiagnosesFound()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
            if (AMedicalRecord.DiagsAdded != "Test Diags")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        public void TestNotesFound()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Boolean OK = true;
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
            if (AMedicalRecord.NotesAdded != "Test Notes")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
    }

}
