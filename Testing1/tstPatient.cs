using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstPatient
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsPatient1 APatient = new clsPatient1();
            //test to see that it exists
            Assert.IsNotNull(APatient);
        }
    }
}
