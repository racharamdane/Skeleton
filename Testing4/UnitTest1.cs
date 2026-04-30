using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()

        {
            //create an instance of the class we want to create
            clsRoomManagement AnRoomManagement = new clsRoomManagement();
            //test to see that it exists
            Assert.IsNotNull(AnRoomManagement);
        }
    }
}
