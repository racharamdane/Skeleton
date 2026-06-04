using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstRoomManagement
    {
        //good test data
        //create some test data to pass to the method
        string RoomID = 1.ToString();
        string RoomName = "Test";
        string ClinicalNotes = new string('a', 100);
        string PatientID = 1.ToString();
        string RoomEntryDate = DateTime.Now.Date.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //test to see that it exists
            Assert.IsNotNull(AnRoomManagement);
        }

        [TestMethod]
        public void TreatmentOverOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnRoomManagement.TreatmentOver = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagement.TreatmentOver, TestData);
        }

        [TestMethod]
        public void RoomEntryDateOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnRoomManagment.RoomEntryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.RoomEntryDate, TestData);
        }

        [TestMethod]
        public void RoomIDOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnRoomManagment.RoomID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.RoomID, TestData);
        }

        [TestMethod]
        public void PatientIDOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnRoomManagment.PatientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.PatientID, TestData);
        }

        [TestMethod]
        public void RoomNameOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AnRoomManagment.RoomName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.RoomName, TestData);
        }

        [TestMethod]
        public void ClinicalNotesOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AnRoomManagment.ClinicalNotes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.ClinicalNotes, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //test to see if the result is ture
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestRoomIDFound()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //check the room id
            if (AnRoomManagement.RoomID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTreatmentOverFound()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //check the room id
            if (AnRoomManagement.TreatmentOver != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoomEntryDateFound()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //check the room id
            if (AnRoomManagement.RoomEntryDate != Convert.ToDateTime("12/05/2026"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPatientIDFound()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //check the room id
            if (AnRoomManagement.PatientID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestRoomNameFound()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //check the room id
            if (AnRoomManagement.RoomName != "room1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestClinicalNotesFound()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 RoomID = 1;
            //invoke the method
            Found = AnRoomManagement.Find(RoomID);
            //check the room id
            if (AnRoomManagement.ClinicalNotes != "wrbxteyanlpofjibgbgzjczsuriqmgwdxlndgarfhihexxghhfcxnlcmskcueolxgkutzvcpytydqykykfntydirnqckfqtiwezop")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void RoomNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = ""; //this should trigger an error 
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameMin()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = "a"; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = "aa"; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = new string('a', 99); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = new string('a', 100); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = new string('a', 101); //this should trigger an error
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameMid()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = new string('a', 50); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string RoomName = new string('a', 9999); //this should trigger an error
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMinLessOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 0.ToString(); //this should trigger an error 
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMin()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 1.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 2.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMMaxLessOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 9999.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 10000.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 10001.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDMMid()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 5000.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDExtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = 9999999.ToString(); //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PatientIDInvalidDataType()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string PatientID = "a"; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(-100);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(-5).AddDays(-1);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMin()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(-5);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(-5).AddDays(1);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddDays(-1);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate;
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddDays(1);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateMid()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(-2).AddDays(-182);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to be 100 years in the past
            TestDate = TestDate.AddYears(100);
            //convert the date to a string variable
            string RoomEntryDate = TestDate.ToString();
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void RoomEntryDateInvalidDataType()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create a varible to store the test data
            String RoomEntryDate = "String";

            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesExtremeMin()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = "a"; //this should trigger an error
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMinLessOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 99); //this should trigger an error
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMin()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 100); //this should pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMinPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 101); //this should pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMaxMinusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 4999); //this should pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMax()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 5000); //this should pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 5001); //this should not pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClinicalNotesMid()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 2500); //this should pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ClinicalNotesExtreemeMAx()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //string c=variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string ClinicalNotes = new string('a', 999999); //this should not pass
            //invoke the method
            Error = AnRoomManagement.Valid(RoomID, RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
