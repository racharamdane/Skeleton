using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing3
{
    [TestClass]
    public class tstAppointmentScheduling
    {
        private object DoctorId;
        private object PatientId;

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
            AAppointmentScheduling.AppointmentNote = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AAppointmentScheduling.AppointmentNote, TestData);
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
        public void TestDoctorIdFound(object doctorId)
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
        public void TestPatientIdFound(object patientId, object patientId1)
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
    }

    public class ClsAppointmentScheduling
    {
        internal DateTime AppointmentTime;
        internal DateTime AppointmentDate;
        internal string AppointmentNotes;
        internal int PatientId;
        internal bool Availability;
        internal string AppointmentNote;
        internal int AppointmentId;
        internal int DoctorId;

        internal bool Find(object appointmentSchedulingId)
        {
            throw new NotImplementedException();
        }
    }
}




