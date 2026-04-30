using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstDoctor
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDoctor ADoctor = new clsDoctor();
            //test to see that it exists
            Assert.IsNotNull(ADoctor);
        }
    }
}
