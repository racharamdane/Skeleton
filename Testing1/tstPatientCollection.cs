using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Testing1
{
    [TestClass]
    public class tstPatientCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //test to see that it exists
            Assert.IsNotNull(AllPatients);
        }

        [TestMethod]
        public void PatientListOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //create some test data to assign to the property
            List<ClsPatient> TestList = new List<ClsPatient>();
            //add an item to the list
            // create the item of test data
            ClsPatient TestItem = new ClsPatient();
            // set its properties
            TestItem.Treatment = true;
            TestItem.PatientID = 111;
            TestItem.FullName = "Racha R";
            TestItem.DateAdded = DateTime.Now;
            TestItem.PatientGender = "female";
            TestItem.PatientPassword = "racha123456789";
            TestItem.Email = "racha@gmail.com";

            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllPatients.PatientList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllPatients.PatientList, TestList);

        }

        [TestMethod]
        public void ThisPatientOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //create some test data to assign to the property
            List<ClsPatient> TestList = new List<ClsPatient>();
            //add an item to the list
            // create the item of test data
            ClsPatient TestItem = new ClsPatient();
            // set its properties
            TestItem.Treatment = true;
            TestItem.PatientID = 111;
            TestItem.FullName = "Racha R";
            TestItem.DateAdded = DateTime.Now;
            TestItem.PatientGender = "female";
            TestItem.PatientPassword = "racha123456789";
            TestItem.Email = "racha@gmail.com";
            //assign the item to the property
            AllPatients.ThisPatient = TestItem;
            // test to see that the two values are the same
            Assert.AreEqual(AllPatients.ThisPatient, TestItem);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<ClsPatient> TestList = new List<ClsPatient>();
            //add an item to the list
            // create the item of test data
            ClsPatient TestItem = new ClsPatient();
            // set its properties
            TestItem.Treatment = true;
            TestItem.PatientID = 111;
            TestItem.FullName = "Racha R";
            TestItem.DateAdded = DateTime.Now;
            TestItem.PatientGender = "female";
            TestItem.PatientPassword = "racha123456789";
            TestItem.Email = "racha@gmail.com";
            // add the item to the test list
            TestList.Add(TestItem);
            // assign the data to the property
            AllPatients.PatientList = TestList;
            // test to see that the two values are the same
            Assert.AreEqual(AllPatients.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //create the item of test data
            ClsPatient TestItem = new ClsPatient();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Treatment = true;
            TestItem.PatientID = 111;
            TestItem.FullName = "Racha R";
            TestItem.DateAdded = DateTime.Now;
            TestItem.PatientGender = "female";
            TestItem.PatientPassword = "racha123456789";
            TestItem.Email = "racha@gmail.com";
            //set ThisPatient to the test data
            AllPatients.ThisPatient TestItem;
            //add the record
            PrimaryKey = AllPatients.Add();
            //set the primary ke of the test data 
            TestItem.PatientID = PrimaryKey;
            //find the record
            AllPatients.ThisPatient.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPatients.ThisPatient, TestItem);



        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //create the item of test data
            ClsPatient TestItem = new ClsPatient();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test item
            TestItem.Treatment = true;
            TestItem.FullName = "Racha R";
            TestItem.DateAdded = DateTime.Now;
            TestItem.PatientGender = "female";
            TestItem.PatientPassword = "racha123456789";
            TestItem.Email = "racha@gmail.com";
            //set ThisPatient to the test data
            AllPatients.ThisPatient = TestItem;
            //add the record
            PrimaryKey = AllPatients.Add();
            //set the primary key of the test data
            TestItem.PatientID = PrimaryKey;
            //modify the test data
            TestItem.Treatment = false;
            TestItem.FullName = "Ra";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.PatientGender = "male";
            TestItem.PatientPassword = "ra123456789";
            TestItem.Email = "ra@gmai.com";
            //set the record based on the new test data
            AllPatients.ThisPatient = TestItem;
            //update the record
            AllPatients.Update();
            //find the record
            AllPatients.ThisPatient.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllPatients.ThisPatient, TestItem);


        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            ClsPatientCollection AllPatients = new ClsPatientCollection();
            //create the item of test data
            ClsPatient TestItem = new ClsPatient();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test item
            TestItem.Treatment = true;
            TestItem.FullName = "Racha R";
            TestItem.DateAdded = DateTime.Now;
            TestItem.PatientGender = "female";
            TestItem.PatientPassword = "racha123456789";
            TestItem.Email = "racha@gmail.com";
            TestItem.PatientID = 111;
            //set ThisPatient to the test data
            AllPatients.ThisPatient = TestItem;
            //add the record
            PrimaryKey = AllPatients.Add();
            //set the primary key of the test data
            TestItem.PatientID = PrimaryKey;
            //find the record
            AllPatients.ThisPatient.Find(PrimaryKey);
            //delete the record
            AllPatients.Delete();
            //now find the record
            Boolean Found = AllPatients.ThisPatient.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByFullNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            ClsPatientCoolection AllPatients = new ClsPatientCollection();
            //create an instance of the filtered data
            ClsPatientCollection FilteredPatients = new ClsPatientCollection();
            //apply a blank string (should return all records)
            FilteredPatients.ReportByFullName("xxxxxx");
            //test to see that the two values are the same
            Assert.AreEqual(AllPatients.Count, FilteredPatients.Count);


        }
        [TestMethod]
        public void ReportByFullNameNoneFound()
        {
            //create an instance of the filtered data
            ClsPatientCollection FilteredPatients = new ClsPatientCollection();
            //apply a name that doesn't exist
            FilteredPatients.ReportByFullName("xxxxxx");
            //check that the correct number of records are found
            if (FilteredPatients.Count != 5)
            {
                //check to see that the first record is 5
                if (FilteredPatients.PatientList[0].PatientID != 5)
                {
                    OK = false;
                }
                // check to see that the second record is 6
                if (FilteredPatients.PatientList[1].PatientID != 6)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;

            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }


    }
}




    
