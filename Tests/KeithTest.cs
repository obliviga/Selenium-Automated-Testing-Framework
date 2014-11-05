using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Automation;

namespace Tests
{
    [TestClass]
    public class KeithTest
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Alert_Works()
        {
            TestPage.GoTo();
            
        }
    }
}
