using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstMedicalRecord
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsMedicalRecord ARecord = new clsMedicalRecord();
            Assert.IsNotNull(ARecord);
        }
    }
}
