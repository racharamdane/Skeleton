using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class tstDoctor
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //test to see that it exists
            Assert.IsNotNull(ADoctor);
        }

        [TestMethod]
        public void AvailableDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ADoctor.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.Available, TestData);
        }

        [TestMethod]
        public void ContractDateDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ADoctor.ContractDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.ContractDate, TestData);
        }

        [TestMethod]
        public void DoctorIdDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            ADoctor.DoctorId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.DoctorId, TestData);
        }

        [TestMethod]
        public void FullNameDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            string TestData = "Racha S";
            //assign the data to the property
            ADoctor.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.FullName, TestData);
        }
        [TestMethod]
        public void PasswordDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            string TestData = "O5";
            //assign the data to the property
            ADoctor.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.Password, TestData);
        }
        [TestMethod]
        public void EmailDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            string TestData = "p@gmail.com";
            //assign the data to the property
            ADoctor.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.Email, TestData);
        }

        [TestMethod]
        public void DepartmentDoctorOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            string TestData = "Gynaecology";
            //assign the data to the property
            ADoctor.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADoctor.Department, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            int DoctorId = 1;
            //test to see that the two values are the same
            Found = ADoctor.Find(DoctorId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDoctorIdFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the doctor Id
            if (ADoctor.DoctorId !=1)
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorFullNameFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the Full Name property
            if (ADoctor.FullName.Trim() != "Praisy")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorPasswordFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the Full Name property
            if (ADoctor.Password.Trim() != "P1")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorEmailFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the Full Name property
            if (ADoctor.Email != "p@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorDepartmentFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the Full Name property
            if (ADoctor.Department != "Gynaecology")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContractDateFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            // create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the doctor Id
            if (ADoctor.ContractDate != Convert.ToDateTime("29/04/2026"))
            {
                OK = false;
            }
            //check to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDoctorAvailabilityFound()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int DoctorId = 1;
            //invoke the method
            Found = ADoctor.Find(DoctorId);
            //check the Full Name property
            if (ADoctor.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}
