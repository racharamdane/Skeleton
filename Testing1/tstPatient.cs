using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstPatient
    {
        //good test data
        //create some test data to pass to the method
        string Patientfullname = "Racha R";
        string PatientEmail = "racha@gmail.com";
        string Patientgender = "female";
        string Patientpassword = "racha123456789";
        string DateAdded = DateTime.Now.ToShortDateString();


        /******************INSTANCE OF THE CLASS TEST******************/

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //test to see that it exists
            Assert.IsNotNull(APatient);
        }

        /******************PROPERTY OK TESTS******************/

        [TestMethod]
        public void PatientIdOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create some test data to assign to the patient
            Int32 TestData = 111;
            //assign the data to the patient
            APatient.PatientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APatient.PatientID, TestData);
        }
        [TestMethod]
        public void PatientFullNameOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create some test data to assign to the patient
            string TestData = "Racha R";
            //assign the data to the patient
            APatient.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APatient.FullName, TestData);
        }

        [TestMethod]
        public void PatientTreatmentOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create some test data to assign to the patient
            Boolean TestData = true;
            //assign the data to the patient
            APatient.Treatment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APatient.Treatment, TestData);
        }
        [TestMethod]
        public void PatientDateOfBirthOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create some test data to assign to the patient
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the patient
            APatient.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(APatient.DateAdded, TestData);
        }
        [TestMethod]
        public void PatientGenderOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnAddress = new ClsPatient();
            //create some test data to assign to the patient
            string TestData = "female";
            //assign the data to the patient
            AnAddress.PatientGender = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PatientGender, TestData);
        }
        [TestMethod]
        public void PatientEmailOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnAddress = new ClsPatient();
            //create some test data to assign to the property
            string TestData = "racha@gmail.com";
            //assign the data to the property
            AnAddress.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.Email, TestData);
        }

        [TestMethod]
        public void PatientPasswordOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnAddress = new ClsPatient();
            //create some test data to assign to the patient
            string TestData = "racha123456789";
            //assign the data to the patient
            AnAddress.PatientPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PatientPassword, TestData);
        }

        /******************FIND METHOD TEST******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 APatientID = 111;
            //invoke the method
            Found = APatient.Find(APatientID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        /******************PROPERTY DATA TESTS******************/

        [TestMethod]
        public void TestPatientIdFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the address id property
            if (APatient.PatientID != 111)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientFullNameFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the house no property
            if (APatient.FullName != "Racha R")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTreatmentFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the street property
            if (APatient.Treatment != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the date added property
            if (APatient.DateAdded != Convert.ToDateTime("10/01/2000"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientGenderFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the county code property
            if (APatient.PatientGender != "female")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientEmailFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the county code property
            if (APatient.Email != "racha@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientPasswordFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 111;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the county code property
            if (APatient.PatientPassword != "racha123456789")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /******************VALID METHOD TEST******************/


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void PatientFullNameMinLessOne()
        {
            // create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Patientfullname = "";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientFullNameMin()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Patientfullname = "a"; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientFullNameMinPlusOne()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Patientfullname = "aa"; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientFullNameMaxLessOne()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Patientfullname = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFullNameNoMax()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Patientfullname = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientFullNameNoMid()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Patientfullname = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFullNameExtremeMax()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Patientfullname = "";
            Patientfullname = Patientfullname.PadRight(500, 'a'); //this should fail 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
    }

}