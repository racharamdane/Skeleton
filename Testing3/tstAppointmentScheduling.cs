using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstAppointmentScheduling
    {
        public object DoctorId;
        public object PatientId;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //test to see that it exists
            Assert.IsNotNull(AAppointmentScheduling);
        }

        [TestMethod]
        public void AvailabilityOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AAppointmentScheduling.Availability = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAppointmentScheduling.Availability, TestData);
        }

        [TestMethod]
        public void AppointmentDateOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AAppointmentScheduling.AppointmentDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAppointmentScheduling.AppointmentDate, TestData);
        }

        [TestMethod]
        public void DoctorIdOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            AAppointmentScheduling.DoctorId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAppointmentScheduling.DoctorId, TestData);
        }

        [TestMethod]
        public void PatientIdOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create some test data to assign to the property
            Int32 TestData = 111;
            //assign the data to the property
            AAppointmentScheduling.PatientId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAppointmentScheduling.PatientId, TestData);
        }

        [TestMethod]
        public void AppointmentNotesOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create some test data to assign to the property
            string TestData = "N/A";
            //assign the data to the property
            AAppointmentScheduling.AppointmentNotes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAppointmentScheduling.AppointmentNotes, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            int AppointmentId = 1234;
            //test to see that the two values are the same
            Found = AAppointmentScheduling.Find(AppointmentId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDoctorIdFound(int DoctorId)
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(DoctorId);
            //check the doctor Id
            if (AAppointmentScheduling.DoctorId != 1)
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPatientIdFound(int PatientId)
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(PatientId);
            //check the doctor Id
            if (AAppointmentScheduling.PatientId != 111)
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAppointmentIdFound()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(AppointmentId);
            //check the doctor Id
            if (AAppointmentScheduling.AppointmentId != 1234)
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentNotesFound()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(AppointmentId);
            //check the Full Name property
            if (AAppointmentScheduling.AppointmentNotes != "N/A")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAppointmentDateFound()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(AppointmentId);
            //check the doctor Id
            if (AAppointmentScheduling.AppointmentDate != Convert.ToDateTime("29/04/2026"))
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestAppointmentTimeFound()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(AppointmentId);
            //check the doctor Id
            if (AAppointmentScheduling.AppointmentTime != Convert.ToDateTime("16:00:00"))
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int AppointmentId = 1234;
            //invoke the method
            Found = AAppointmentScheduling.Find(AppointmentId);
            //check the Full Name property
            if (AAppointmentScheduling.Availability != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        /************Valid Method************/
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AppointmentNotesMinLessOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesMin()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "AA";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            AppointmentNotes = AppointmentNotes.PadRight(499, 'A');
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesMax()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            AppointmentNotes = AppointmentNotes.PadRight(500, 'A');
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            AppointmentNotes = AppointmentNotes.PadRight(501, 'A');
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesMid()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            AppointmentNotes = AppointmentNotes.PadRight(250, 'A');
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }
        [TestMethod]
        public void AppointmentNotesExtremeMax()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = MakeValidAppointment();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            AppointmentNotes = AppointmentNotes.PadRight(1000, 'A');
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesExtremeMin()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = MakeValidAppointment();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentNotesInvalidData()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = MakeValidAppointment();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "This is not a valid note!@£$%^&*()";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AppointmentDateExtremeMin()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.MinValue.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMinLessOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMax()
            {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(365);
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(366);
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMid()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(182);
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(364);
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AppointmentDateMin()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string AppointmentDate = TestDate.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateExtremeMax()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.MaxValue.ToString();
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentDateInvalidData()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = "This is not a date!";
            string AppointmentTime = DateTime.Now.TimeOfDay.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeInvalidData()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = "This is not a time!";
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeExtremeMin()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.MinValue.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeExtremeMax()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            string AppointmentTime = DateTime.MaxValue.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMinLessOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            TestTime = TestTime.AddSeconds(-1);
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMaxLessOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            TestTime = TestTime.AddSeconds(1);
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMin()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMax()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            TestTime = TestTime.AddSeconds(1);
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMinPlusOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            TestTime = TestTime.AddSeconds(1);
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMaxPlusOne()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            TestTime = TestTime.AddSeconds(1);
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void AppointmentTimeMid()
        {
            //create an instance of the class we want to create
            ClsAppointmentScheduling AAppointmentScheduling = new ClsAppointmentScheduling();
            //string variable to store any error message
            String Error = "";
            //create some test data to assign to the property
            string AppointmentNotes = "N/A";
            string AppointmentDate = DateTime.Now.Date.ToString();
            DateTime TestTime = DateTime.Now;
            TestTime = TestTime.AddSeconds(1);
            string AppointmentTime = TestTime.ToString();
            //invoke the method
            Error = AAppointmentScheduling.Valid(AppointmentNotes, AppointmentDate, AppointmentTime);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        private ClsAppointmentScheduling MakeValidAppointment()
        {
            var a = new ClsAppointmentScheduling();
            // provide valid ids so Valid(...) won't report doctor/patient blank errors
            a.DoctorId = 1;
            a.PatientId = 111;
            return a;
        }
    }
}

 





