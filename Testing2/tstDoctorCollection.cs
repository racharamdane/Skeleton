using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Testing2
{
    [TestClass]
    public class tstDoctorCollection
        {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsDoctorCollection AllDoctors = new clsDoctorCollection();
            }

            [TestMethod]
            public void DoctorListOK()
            {
                //create an instance of the class we want to create
                clsDoctorCollection AllDoctors = new clsDoctorCollection();
                //create some test data to assign to the property
                //in this case the data needs to be a list of objects
                List<clsDoctor> TestList = new List<clsDoctor>();
                //add an item to the list
                //create the item of test data
                clsDoctor TestItem = new clsDoctor();
                //set its properties
                TestItem.Available = true;
                TestItem.DoctorId = 1;
                TestItem.FullName = "Praisy";
                TestItem.Password = "P1";
                TestItem.Email = "p@gmail.com";
                TestItem.Department = "Gynaecology";
                TestItem.ContractDate = DateTime.Now;
                //add the item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllDoctors.DoctorList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllDoctors.DoctorList, TestList);
            }


            [TestMethod]
            public void ThisDoctorOK()
            {
                //create an instance of the class we want to create
                clsDoctorCollection AllDoctors = new clsDoctorCollection();
                //create some test data to assign to the property            
                clsDoctor TestDoctor = new clsDoctor();
                //set its properties
                TestDoctor.Available = true;
                TestDoctor.DoctorId = 1;
                TestDoctor.FullName = "Praisy";
                TestDoctor.Password = "P1";
                TestDoctor.Email = "p@gmail.com";
                TestDoctor.Department = "Gynaecology";
                TestDoctor.ContractDate = DateTime.Now;
                //assign the data to the property
                AllDoctors.ThisDoctor = TestDoctor;
                //test to see that the two values are the same
                Assert.AreEqual(AllDoctors.ThisDoctor, TestDoctor);
            }

            [TestMethod]
            public void ListAndCountOK()
            {
                //create an instance of the class we want to create
                clsDoctorCollection AllDoctors = new clsDoctorCollection();
                //create some test data to assign to the property
                //in this case the data needs to be a list of objects
                List<clsDoctor> TestList = new List<clsDoctor>();
                //add an item to the list
                //create the item of test data
                clsDoctor TestItem = new clsDoctor();
                //set its properties
                TestItem.Available = true;
                TestItem.DoctorId = 1;
                TestItem.FullName = "Praisy";
                TestItem.Password = "P1";
                TestItem.Email = "p@gmail.com";
                TestItem.Department = "Gynaecology";
                TestItem.ContractDate = DateTime.Now;
                //add the item to the test list
                TestList.Add(TestItem);
                //assign the data to the property
                AllDoctors.DoctorList = TestList;
                //test to see that the two values are the same
                Assert.AreEqual(AllDoctors.Count, TestList.Count);
            }

            [TestMethod]
            public void AddMethodOK()
            {
                //create an instance of the class we want to create
                clsDoctorCollection AllDoctors = new clsDoctorCollection();
                //create the item of the test data
                clsDoctor TestItem = new clsDoctor();
                //variable to store the primary key
                Int32 PrimaryKey = 0;
                //set its properties
                TestItem.Available = true;
                TestItem.DoctorId = 1;
                TestItem.FullName = "Praisy";
                TestItem.Password = "P1";
                TestItem.Email = "p@gmail.com";
                TestItem.Department = "Gynaecology";
                TestItem.ContractDate = DateTime.Now;
                //set ThisDoctor to the test data
                AllDoctors.ThisDoctor = TestItem;
                //add the record
                PrimaryKey = AllDoctors.Add();
                //set the primary key of the test data
                TestItem.DoctorId = PrimaryKey;
                //find the record
                AllDoctors.ThisDoctor.Find(PrimaryKey);
                //test to see that the two values are the same
                Assert.AreEqual(AllDoctors.ThisDoctor, TestItem);
            }

        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsDoctorCollection AllDoctors = new clsDoctorCollection();
            //create the item of the test data
            clsDoctor TestItem = new clsDoctor();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.DoctorId = 1;
            TestItem.FullName = "Praisy";
            TestItem.Password = "P1";
            TestItem.Email = "p@gmail.com";
            TestItem.Department = "Gynaecology";
            TestItem.ContractDate = DateTime.Now;
            //set ThisDoctor to the test data
            AllDoctors.ThisDoctor = TestItem;
            //add the record
            PrimaryKey = AllDoctors.Add();
            //set the primary key of the test data
            TestItem.DoctorId = PrimaryKey;
            //modify the test data
            TestItem.Available = false;
            TestItem.FullName = "Praisy S";
            TestItem.Password = "P12";
            TestItem.Email = "ps@gmail.com";
            TestItem.Department = "Oncology";
            TestItem.ContractDate = DateTime.Now;
            //set the record based on the new test data
            AllDoctors.ThisDoctor = TestItem;
            //update the record
            AllDoctors.Update();
            //find the record
            AllDoctors.ThisDoctor.Find(PrimaryKey);
            //test to see if ThisDoctor matches the test data
            Assert.AreEqual(AllDoctors.ThisDoctor, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsDoctorCollection AllDoctors = new clsDoctorCollection();
            //create the item of the test data
            clsDoctor TestItem = new clsDoctor();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Available = true;
            TestItem.DoctorId = 1;
            TestItem.FullName = "Praisy";
            TestItem.Password = "P1";
            TestItem.Email = "p@gmail.com";
            TestItem.Department = "Gynaecology";
            TestItem.ContractDate = DateTime.Now;
            //set ThisDoctor to the test data
            AllDoctors.ThisDoctor = TestItem;
            //add the record
            PrimaryKey = AllDoctors.Add();
            //set the primary key of the test data
            TestItem.DoctorId = PrimaryKey;
            //find the record
            AllDoctors.ThisDoctor.Find(PrimaryKey);
            //delete the record
            AllDoctors.Delete();
            //now find the record
            Boolean Found = AllDoctors.ThisDoctor.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class we want to create
            clsDoctorCollection AllDoctors = new clsDoctorCollection();
            //create the instance of the filtered data
            clsDoctorCollection FilteredDoctors = new clsDoctorCollection();
            //apply a blank string (should return all records)
            FilteredDoctors.ReportByFullName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllDoctors.Count, FilteredDoctors.Count);
        }

        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //create the instance of the filtered data
            clsDoctorCollection FilteredDoctors = new clsDoctorCollection();
            //apply a name that doesn't exist
            FilteredDoctors.ReportByFullName("Sandra Oh");
            //test to see that the two values are the same
            Assert.AreEqual(0, FilteredDoctors.Count);
        }

        [TestMethod]
        public void ReportByFullNameTestDataFound()
        {
            //create an instance of the class we want to create
            clsDoctorCollection FilteredDoctors = new clsDoctorCollection();
            //variable to store outcome
            Boolean OK = true;
            //apply a name that doesn't exist
            FilteredDoctors.ReportByFullName("Precious P");
            //check that the correct number of records are found
            if (FilteredDoctors.Count == 2)
            {
                //check that the first record is ID 42
                if (FilteredDoctors.DoctorList[0].DoctorId != 42)
                {
                    OK = false;
                }

                //check that the first record is ID 44
                if (FilteredDoctors.DoctorList[1].DoctorId != 44)
                {
                    OK = false;
                }
            }

            else
            {
                OK = false;
            }
            
            //test to see that the there are no records
            Assert.IsTrue(OK);
        }

    }
}
