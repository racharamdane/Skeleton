using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstAppointmentSchedulingCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            // clsAppointmentSchedulingCollection AAppointmentScheduling = new clsAppointmentSchedulingCollection();
        }

        [TestMethod]
        public void AppointmentListOK()
        {
            //create an instance of the class we want to create
            // clsAppointmentScheduling AllAppointments = new clsAppointmentSchedulingCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClassLibrary.ClsAppointmentScheduling> TestList = new List<ClassLibrary.ClsAppointmentScheduling>();

            //add an item to the list
            //create the item of test data
            ClassLibrary.ClsAppointmentScheduling TestItem = new ClassLibrary.ClsAppointmentScheduling();

            //set its properties
            TestItem.AppointmentId = 1234;
            TestItem.DoctorId = 1;
            TestItem.PatientId = 111;
            TestItem.AppointmentNotes = "N/A";
            TestItem.AppointmentDate = DateTime.Now.Date;
            TestItem.AppointmentTime = DateTime.Now;
            TestItem.Availability = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            // AllAppointments.AppointmentList = TestList;

            //test to see that the two values are the same
            // Assert.AreEqual(AllAppointments.AppointmentList, TestList);
        }

        [TestMethod]
        public void ThisAppointmentOK()
        {
            //create an instance of the class we want to create
            // clsAppointmentSchedulingCollection AllAppointments = new clsAppointmentSchedulingCollection();

            //create some test data to assign to the property
            ClassLibrary.ClsAppointmentScheduling TestItem = new ClassLibrary.ClsAppointmentScheduling();

            //set its properties
            TestItem.AppointmentId = 1234;
            TestItem.DoctorId = 1;
            TestItem.PatientId = 111;
            TestItem.AppointmentNotes = "N/A";
            TestItem.AppointmentDate = DateTime.Now.Date;
            TestItem.AppointmentTime = DateTime.Now;
            TestItem.Availability = true;

            //assign the data to the property
            // AllAppointments.ThisAppointment = TestItem;

            //test to see that the two values are the same
            // Assert.AreEqual(AllAppointments.ThisAppointment, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            ClassLibrary.ClsAppointmentScheduling AAppointmentScheduling = new ClassLibrary.ClsAppointmentScheduling();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<ClassLibrary.ClsAppointmentScheduling> TestList = new List<ClassLibrary.ClsAppointmentScheduling>();

            //add an item to the list
            //create the item of test data
            ClassLibrary.ClsAppointmentScheduling TestItem = new ClassLibrary.ClsAppointmentScheduling();

            //set its properties
            TestItem.AppointmentId = 1234;
            TestItem.DoctorId = 1;
            TestItem.PatientId = 111;
            TestItem.AppointmentNotes = "N/A";
            TestItem.AppointmentDate = DateTime.Now.Date;
            TestItem.AppointmentTime = DateTime.Now;
            TestItem.Availability = true;

            //add the item to the test list
            TestList.Add(TestItem);

            //assign the data to the property
            // AllAppointments.AppointmentList = TestList;

            //test to see that the two values are the same
            // Assert.AreEqual(AllAppointments.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentSchedulingCollection AllAppointments = new clsAppointmentSchedulingCollection();
            //create the item of test data
            ClassLibrary.ClsAppointmentScheduling TestItem = new ClassLibrary.ClsAppointmentScheduling();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.PatientId = 111;
            TestItem.DoctorId = 1;
            TestItem.AppointmentId = 1234;
            TestItem.AppointmentNotes = "N/A";
            TestItem.AppointmentDate = DateTime.Now;
            TestItem.AppointmentTime = DateTime.Now;

            //set ThisAppointmentScheduling to the test data
            AllAppointments.ThisAppointmentScheduling = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data 
            TestItem.AppointmentId = PrimaryKey;
            //find the record
            AllAppointments.ThisAppointmentScheduling.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointmentScheduling, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentSchedulingCollection AllAppointments = new clsAppointmentSchedulingCollection();
            //create the item of test data
            ClassLibrary.ClsAppointmentScheduling TestItem = new ClassLibrary.ClsAppointmentScheduling();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.PatientId = 111;
            TestItem.DoctorId = 1;
            TestItem.AppointmentId = 1234;
            TestItem.AppointmentNotes = "N/A";
            TestItem.AppointmentDate = DateTime.Now;
            TestItem.AppointmentTime = DateTime.Now;

            //set ThisAppointmentScheduling to the test data
            AllAppointments.ThisAppointmentScheduling = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data 
            TestItem.AppointmentId = PrimaryKey;
            //modify the test data
            TestItem.Availability = false;
            TestItem.PatientId = 222;
            TestItem.DoctorId = 2;
            TestItem.AppointmentNotes = "Updated Notes";
            TestItem.AppointmentDate = DateTime.Now.AddDays(1);
            TestItem.AppointmentTime = DateTime.Now.AddHours(1);

            //update the record
            AllAppointments.ThisAppointmentScheduling = TestItem;
            AllAppointments.Update();

            //find the record
            AllAppointments.ThisAppointmentScheduling.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.ThisAppointmentScheduling, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentSchedulingCollection AllAppointments = new clsAppointmentSchedulingCollection();
            //create the item of test data
            ClassLibrary.ClsAppointmentScheduling TestItem = new ClassLibrary.ClsAppointmentScheduling();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Availability = true;
            TestItem.PatientId = 111;
            TestItem.DoctorId = 1;
            TestItem.AppointmentId = 1234;
            TestItem.AppointmentNotes = "N/A";
            TestItem.AppointmentDate = DateTime.Now;
            TestItem.AppointmentTime = DateTime.Now;
            //set ThisAppointmentScheduling to the test data
            AllAppointments.ThisAppointmentScheduling = TestItem;
            //add the record
            PrimaryKey = AllAppointments.Add();
            //set the primary key of the test data 
            TestItem.AppointmentId = PrimaryKey;
            //delete the record
            AllAppointments.ThisAppointmentScheduling.Find(PrimaryKey);
            AllAppointments.Delete();
            //now find the record
            Boolean Found = AllAppointments.ThisAppointmentScheduling.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByDoctorMethodOK()
        {
            //create an instance of the class we want to create
            clsAppointmentSchedulingCollection AllAppointments = new clsAppointmentSchedulingCollection();
            //create an instance of the filtered data
            clsAppointmentSchedulingCollection FilteredAppointments = new clsAppointmentSchedulingCollection();
            //apply a blank string (should return all records)
            FilteredAppointments.reportbyDoctor("");
            //test to see that the two values are the same
            Assert.AreEqual(AllAppointments.Count, FilteredAppointments.Count);


        }
    }
}
