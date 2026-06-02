using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing5
{
    [TestClass]
    public class tstMedicalRecord
    {
        public bool OK { get; private set; }
        //test data
        String Dob = DateTime.Now.AddYears(-40).ToShortDateString();
        string Medications = "Medication 200mg";
        string Diagnoses = "Diabetus";
        string ClinicalNotes = "Foot Pain";

        [TestMethod]
        public void PatientIdOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();

            Int32 TestData = 1;

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
        [TestMethod]
        public void FindMethodOk()
        {
            //create instance of the class
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            //create boolean to store the results of the validation
            Boolean Found = false;
            //create test data
            Int32 PatientId = 1234571;
            //invoke method 
            Found = AMedicalRecord.Find(PatientId);
 
            Assert.IsTrue(Found);
        }
        [TestMethod]
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
            Assert.IsTrue(OK);
        }
        [TestMethod]
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
            Assert.IsTrue(OK);
        }
        [TestMethod]
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
            Assert.IsTrue(OK);
        }
        [TestMethod]
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
            Assert.IsTrue(OK);
        }
        [TestMethod]
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
            Assert.IsTrue(OK);
        }
        [TestMethod]
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
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void DobExtremeMin()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            String Dob = DateTime.Now.AddYears(100).ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DobMinLess1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            String Dob = DateTime.Now.AddDays(1).ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DobMin()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
<<<<<<< HEAD
            DateTime testDob = DateTime.Now;
            Error = AMedicalRecord.Valid(testDob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual("", Error);
=======
            String Dob = DateTime.Now.ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
>>>>>>> 6cc58e06d512c2231777df37be07b946577a4f0d
        }
        [TestMethod]
        public void DobMinPlus1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            String Dob = DateTime.Now.AddDays(-1).ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DobMaxLess1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            String Dob = DateTime.Now.AddYears(-149).ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DobMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            String Dob = DateTime.Now.AddYears(-150).ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DobMaxPlus1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            String Dob = DateTime.Now.AddYears(-151).ToShortDateString();
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void MedicationsMaxLess1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Medications = new string('a', 99);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MedicationsMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Medications = new string('a', 100);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MedicationsMaxPlus1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Medications = new string('a', 101);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MedicationsExtremeMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Medications = new string('a', 500);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MedicationsMid()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Medications = new string('a', 50);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MedicationsBlank()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Medications = "";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiagnosesMaxLess1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Diagnoses = new string('a', 99);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiagnosesMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Diagnoses = new string('a', 100);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiagnosesMaxPlus1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Diagnoses = new string('a', 101);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiagnosesExtremeMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Diagnoses = new string('a', 500);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiagnosesMid()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Diagnoses = new string('a', 50);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiagnosesBlank()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string Diagnoses = "";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClinicalNotesBlank()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = "";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ClinicalMin()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = "aa";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClinicalMinPlus1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = "aaa";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClinicalMid()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = "patient seen for stomach pain";
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
<<<<<<< HEAD
        }
        [TestMethod]
        public void ClinicalMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = new string('a', 100);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClinicalMaxPlus1()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = new string('a', 101);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreNotEqual(Error, "");
=======
>>>>>>> 6cc58e06d512c2231777df37be07b946577a4f0d
        }
        [TestMethod]
        public void ClinicalExtremeMax()
        {
            clsMedicalRecord AMedicalRecord = new clsMedicalRecord();
            string Error = "";
            string ClinicalNotes = new string('a', 1000);
            Error = AMedicalRecord.Valid(Dob, Medications, Diagnoses, ClinicalNotes);
            Assert.AreEqual(Error, "");
        }


    }

}
