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
    }
}
