using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstRoomManagementCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsRoomManagementCollection AllRooms = new clsRoomManagementCollection();
            //test to see that it exists
            Assert.IsNotNull(AllRooms);
        }

        [TestMethod]
        public void RoomListOK()
        {
            //create an instance of the class we want to create
            clsRoomManagementCollection AllRooms = new clsRoomManagementCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsRoomManagement> TestList = new List<clsRoomManagement>();
            //add an item to the list
            //create the item of test data
            clsRoomManagement TestItem = new clsRoomManagement();
            //set its properties
            TestItem.RoomID = 1;
            TestItem.RoomName = "Test Room";
            TestItem.RoomEntryDate = DateTime.Now.Date;
            TestItem.TreatmentOver = false;
            TestItem.PatientID = 1;
            TestItem.ClinicalNotes = "wrbxteyanlpofjibgbgzjczsuriqmgwdxlndgarfhihexxghhfcxnlcmskcueolxgkutzvcpytydqykykfntydirnqckfqtiwezop";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllRooms.RoomList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllRooms.RoomList, TestList);
        }

        [TestMethod]
        public void ThisRoomPropertyOK()
        {
            //create an instance of the class we want to create
            clsRoomManagementCollection AllRooms = new clsRoomManagementCollection();
            //create some test data to assign to the property
            clsRoomManagement TestRoom = new clsRoomManagement();
            //set the properties of the test object
            TestRoom.RoomID = 1;
            TestRoom.RoomName = "Test Room";
            TestRoom.RoomEntryDate = DateTime.Now.Date;
            TestRoom.TreatmentOver = false;
            TestRoom.PatientID = 1;
            TestRoom.ClinicalNotes = "wrbxteyanlpofjibgbgzjczsuriqmgwdxlndgarfhihexxghhfcxnlcmskcueolxgkutzvcpytydqykykfntydirnqckfqtiwezop";
            //assign the data to the property
            AllRooms.ThisRoom = TestRoom;
            //test to see that the two values are the same
            Assert.AreEqual(AllRooms.ThisRoom, TestRoom);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsRoomManagementCollection AllRooms = new clsRoomManagementCollection();
            //create some test data to assign to the property
            List<clsRoomManagement> TestList = new List<clsRoomManagement>();
            //add an item to the list
            //create the item of test data
            clsRoomManagement TestItem = new clsRoomManagement();
            //set its properties
            TestItem.RoomID = 1;
            TestItem.RoomName = "Test Room";
            TestItem.RoomEntryDate = DateTime.Now.Date;
            TestItem.TreatmentOver = false;
            TestItem.PatientID = 1;
            TestItem.ClinicalNotes = "wrbxteyanlpofjibgbgzjczsuriqmgwdxlndgarfhihexxghhfcxnlcmskcueolxgkutzvcpytydqykykfntydirnqckfqtiwezop";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllRooms.RoomList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllRooms.Count, TestList.Count);
        }


    }
}
