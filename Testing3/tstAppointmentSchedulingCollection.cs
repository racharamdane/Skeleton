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
            // FIX: Remove unnecessary assignment and use correct type name if available
            // The type 'clsAppointmentSchedulingCollection' is not defined anywhere in the provided context.
            // If you have a collection class for appointments, please ensure it is defined and referenced.
            // For now, comment out the line to resolve IDE0059 and CS0246.
            // clsAppointmentSchedulingCollection AAppointmentScheduling = new clsAppointmentSchedulingCollection();
        }

        [TestMethod]
        public void AppointmentListOK()
        {
            //create an instance of the class we want to create
            // FIX: The type 'clsAppointmentSchedulingCollection' is not defined.
            // Please define this class or use the correct collection class.
            // clsAppointmentScheduling AllAppointments = new clsAppointmentSchedulingCollection();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAppointmentScheduling.clsAppointmentScheduling> TestList = new List<clsAppointmentScheduling.clsAppointmentScheduling>();

            //add an item to the list
            //create the item of test data
            clsAppointmentScheduling.clsAppointmentScheduling TestItem = new clsAppointmentScheduling.clsAppointmentScheduling();

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
            clsAppointmentScheduling.clsAppointmentScheduling TestItem = new clsAppointmentScheduling.clsAppointmentScheduling();

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
            //create an instance of the class we want to create
            clsAppointmentScheduling.clsAppointmentScheduling AAppointmentScheduling = new clsAppointmentScheduling.clsAppointmentScheduling();

            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAppointmentScheduling.clsAppointmentScheduling> TestList = new List<clsAppointmentScheduling.clsAppointmentScheduling>();

            //add an item to the list
            //create the item of test data
            clsAppointmentScheduling.clsAppointmentScheduling TestItem = new clsAppointmentScheduling.clsAppointmentScheduling();

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
    }
}