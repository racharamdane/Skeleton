using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstRoomManagement
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //test to see that it exists
            Assert.IsNotNull(AnRoomManagement);
        }

        [TestMethod]
        public void TreatmentOverOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnRoomManagement.TreatmentOver = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagement.TreatmentOver, TestData);
        }

        [TestMethod]
        public void RoomEntryDateOK()
        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnRoomManagment.RoomEntryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.RoomEntryDate, TestData);
        }

        [TestMethod]
        public void RoomIDOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnRoomManagment.RoomID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.RoomID, TestData);
        }

        [TestMethod]
        public void PatientIDOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnRoomManagment.PatientID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.PatientID, TestData);
        }

        [TestMethod]
        public void RoomNameOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AnRoomManagment.RoomName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.RoomName, TestData);
        }

        [TestMethod]
        public void ClinicalNotesOK()
        {
            //create an instnace of the class we want to create
            clsRoomManagement AnRoomManagment = new clsRoomManagement();
            //create some test data to assign to the property
            String TestData = "Test";
            //assign the data to the property
            AnRoomManagment.ClinicalNotes = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnRoomManagment.ClinicalNotes, TestData);
        }

    }
}
