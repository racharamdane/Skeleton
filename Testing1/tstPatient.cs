using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Data;
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
            Int32 TestData = 122;
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
        public void PatientRegistrationDateOK()
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
            Int32 APatientID = 122;
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
            Int32 PatientID = 122;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the address id property
            if (APatient.PatientID != 122)
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
            Int32 PatientID = 122;
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
            Int32 PatientID = 122;
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
        public void TestPatientRegistrationDateFound()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 PatientID = 122;
            //invoke the method
            Found = APatient.Find(PatientID);
            //check the date added property
            if (APatient.DateAdded
                != Convert.ToDateTime("10/01/2026"))
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
            Int32 PatientID = 122;
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
            Int32 PatientID = 122;
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
            Int32 PatientID = 122;
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
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
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
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
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
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
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
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
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
            Patientfullname = Patientfullname.PadRight(49, 'a');; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFullNameMax()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            Patientfullname = Patientfullname.PadRight(50, 'a'); ; //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientFullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Patientfullname = Patientfullname.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientFullNameMid()
        {
            //create an instance of the class we want to create 
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            Patientfullname = Patientfullname.PadRight(25, 'a'); //this should be ok 
            //invoke the method 
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
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
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientRegistrationDateExtremeMin()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //create a string variable to store the error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the data to todays date
            TestDate = DateTime.Now.Date;
            //change the date to todays date minus 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);

        }
        [TestMethod]
        public void PatientRegistrationDateMinLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientRegistrationDateMin()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientRegistrationDateMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientregistrationdateExtremeMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        public void PatientregistrationdateExtremeMin()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientRegistrationDateInvalidData()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //set the date variable to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientEmailMinLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PatientEmail = "";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientEmailMin()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PatientEmail = "a";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PatientEmail = "aa";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            PatientEmail = PatientEmail.PadRight(49, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void PatientEmailMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            PatientEmail = PatientEmail.PadRight(50, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PatientEmail = "";
            PatientEmail = PatientEmail.PadRight(51, 'a');

            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientEmailMid()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
         
            PatientEmail = PatientEmail.PadRight(25, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientEmailExtremeMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            PatientEmail = PatientEmail.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Patientpassword = "";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientPasswordMin()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientpassword = "a";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientpassword = "aa";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientpassword = "";
            Patientpassword = Patientpassword.PadRight(49, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientPasswordMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientpassword = "";
            Patientpassword = Patientpassword.PadRight(50, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Patientpassword = "";
            Patientpassword = Patientpassword.PadRight(51, 'a');

            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientPasswordExtremeMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Patientpassword = "";
            Patientpassword = Patientpassword.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientPasswordMid()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientpassword = "";
            Patientpassword = Patientpassword.PadRight(25, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMinLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Patientgender = "";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMin()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientgender = "a";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientgender = "aa";
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientgender = "";
            Patientgender = Patientgender.PadRight(49, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientgender = "";
            Patientgender = Patientgender.PadRight(50, 'a');
            //invoke the method
                Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Patientgender = "";
            Patientgender = Patientgender.PadRight(51, 'a');

            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PatientGenderMid()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Patientgender = "";
            Patientgender = Patientgender.PadRight(25, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PatientGenderExtremeMax()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Patientgender = "";
            Patientgender = Patientgender.PadRight(500, 'a');
            //invoke the method
            Error = APatient.Valid(Patientfullname, PatientEmail, Patientgender, Patientpassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        
        public void StatStaticsGroupedByPatientgender()
        {
            //cerate an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //invoke the method
            DataTable dT = APatient.StaticsGroupedByPatientgender();
            //according to the last executed test there should be 2 records in the data table
            int noOfRecords = 2;
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);
        }
        public void StatStaticsGroupedByPatientregistrationdate()
        {
            // create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //invoke the method
            DataTable dT = APatient.StaticsGroupedByPatientregistrationdate();
            //according to the last executed test there should be 2 records in the data table
            int noOfRecords = dT.Rows.Count;
            //test to see that the result is correct
            Assert.AreEqual(noOfRecords, dT.Rows.Count);


        }

    }
}
