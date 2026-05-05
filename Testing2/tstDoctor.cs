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
        public void AvailableDocotrOK()
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

    }
}
