using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing5
{
    [TestClass]
    public class tstMedicalRecord
    {
        //test data
        string Dob = DateTime.Now.ToShortDateString();
        string Medications = "Medication 200mg";
        string Diagnoses = "Diabetus";
        string ClinicalNotes = "Foot Pain";

        [TestMethod]
        public void PatientIdOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            Int32 TestData = '1';

            AMedicalRecord.PatientId = TestData;

            Assert.AreEqual(AMedicalRecord.PatientId, TestData);
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

            AMedicalRecord.Dob = TestData;

            Assert.AreEqual(AMedicalRecord.Dob, TestData);
        }
        [TestMethod]
        public void SexOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            Boolean TestData = true;

            AMedicalRecord.Sex = TestData;

            Assert.AreEqual(AMedicalRecord.Sex, TestData);
        }
        [TestMethod]
        public void MedicationsOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            String TestData = "Meds";

            AMedicalRecord.Medications = TestData;

            Assert.AreEqual(AMedicalRecord.Medications, TestData);
        }
        [TestMethod]
        public void DiagnosesOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            String TestData = "Ailments";

            AMedicalRecord.Diagnoses = TestData;

            Assert.AreEqual(AMedicalRecord.Diagnoses, TestData);
        }
        [TestMethod]
        public void ClinicalNotesOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            String TestData = "Notes";

            AMedicalRecord.ClinicalNotes = TestData;

            Assert.AreEqual(AMedicalRecord.ClinicalNotes, TestData);
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
            if(AMedicalRecord.PatientId != 1234571)
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
            if (AMedicalRecord.Dob != Convert.ToDateTime("12/12/2012"))
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
            if (AMedicalRecord.Sex != true)
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
            if (AMedicalRecord.Medications != "Test Meds")
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
            if (AMedicalRecord.Diagnoses != "Test Diags")
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
            if (AMedicalRecord.ClinicalNotes != "Test Notes")
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            Error = AMedicalRecord.Valid(Dob, Sex, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
    }

}
