using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsRoomManagementCollection
    {
        //constructor for the class
        public clsRoomManagementCollection()
        {
            //create the items of test data
            clsRoomManagement TestItem = new clsRoomManagement();
            //set its properties
            TestItem.RoomID = 1;
            TestItem.RoomName = "Test Room";
            TestItem.RoomEntryDate = DateTime.Now.Date;
            TestItem.TreatmentOver = false;
            TestItem.PatientID = 1;
            TestItem.ClinicalNotes = "wrbxteyanlpofjibgbgzjczsuriqmgwdxlndgarfhihexxghhfcxnlcmskcueolxgkutzvcpytydqykykfntydirnqckfqtiwezop";
            //add the item to the test list
            mRoomList.Add(TestItem);
            //re intialise 
        }
        //private data member for the list
        List<clsRoomManagement> mRoomList = new List<clsRoomManagement>();
        //public property for the room list
        public List<clsRoomManagement> RoomList
        {
            get
            {
                //return the private data
                return mRoomList;
            }
            set
            {
                //set the private data
                mRoomList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mRoomList.Count;
            }
            set
            {
                //we will worry about this later
            }
        }
        public clsRoomManagement ThisRoom { get; set; }
    }
}