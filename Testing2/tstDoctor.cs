using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace Testing2
{
    [TestClass]
    public class tstDoctor
    {

        //good test data
        //create some test data to pass the method
        string FullName = "Praisy";
        string Password = "P1";
        string Email = "p@gmail.com";
        string Department = "Gynaecology";
        string ContractDate = DateTime.Now.ToShortDateString();


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
            if (ADoctor.DoctorId != 1)
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

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            string Error = "";
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = ""; //this should trigger an error
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "a"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMid()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FullNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FullNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FullName = "";
            FullName = FullName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = ""; //this should trigger an error
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "a"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "aa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(49, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(50, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMid()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(25, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PasswordExtremeMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Password = "";
            Password = Password.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = ""; //this should trigger an error
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "a"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "aa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(49, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(50, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(25, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Email = "";
            Password = Password.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = ""; //this should trigger an error
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentlMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "a"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "aa"; //this should be ok
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(49, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(50, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMid()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(25, 'a'); //this should pass
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DepartmentMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DepartmentExtremeMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Department = "";
            Department = Department.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ContractDate = TestDate.ToString();
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractDateMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ContractDate = TestDate.ToString();
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContractDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ContractDate = TestDate.ToString();
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string ContractDate = TestDate.ToString();
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContractDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string ContractDate = TestDate.ToString();
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContractDateInvalidData()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //string variable to store any error message
            String Error = "";
            //set the ContractDate to a non date value
            string ContractDate = "this is not a date!";
            //invoke the method
            Error = ADoctor.Valid(FullName, Password, Email, Department, ContractDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }
    }
}
