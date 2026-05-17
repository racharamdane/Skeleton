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
        string RoomName = "Test";
        string ClinicalNotes = "Test";
        int PatientID = 1;
        DateTime RoomEntryDate = DateTime.Now.Date;

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
            if (AnRoomManagement.ClinicalNotes != "stuff")
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 0; //this should trigger an error 
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 1; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 2; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 9999; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 10000; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 10001; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 5000; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            int PatientID = 9999999; //this should be ok
            //invoke the method
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
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
            Error = AnRoomManagement.Valid(RoomName, ClinicalNotes, PatientID, RoomEntryDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
