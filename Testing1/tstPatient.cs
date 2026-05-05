using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;

namespace Testing1
{
    [TestClass]
    public class tstPatient
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsPatient APatient = new ClsPatient();
            //test to see that it exists
            Assert.IsNotNull(APatient);
        }
        [TestMethod]
        public void PatientIdOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnAddress = new ClsPatient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnAddress.PatientId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PatientId, TestData);
        }
        [TestMethod]
        public void PatientFullNameOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnAddress = new ClsPatient();
            //create some test data to assign to the patient
            string TestData = "Racha Ramdane";
            //assign the data to the patient
            AnAddress.FullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.FullName, TestData);
        }

        [TestMethod]
        public void PatientTreatmentOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnPatient = new ClsPatient();
            //create some test data to assign to the patient
            Boolean TestData = true;
            //assign the data to the patient
            AnPatient.Treatment = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnPatient.Treatment, TestData);
        }
        [TestMethod]
        public void PatientDateOfBirthOK()
        {
            //create an instance of the class we want to create
            ClsPatient AnAddress = new ClsPatient();
            //create some test data to assign to the patient
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the patient
            AnAddress.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.DateAdded, TestData);
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
            string TestData = "Some Street";
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
            string TestData = "LE14AB";
            //assign the data to the patient
            AnAddress.PatientPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnAddress.PatientPassword, TestData);
        }
        
       

    }
}
