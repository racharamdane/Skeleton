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
            Assert.IsNull(AnRoomManagement);
        }
    }
}
