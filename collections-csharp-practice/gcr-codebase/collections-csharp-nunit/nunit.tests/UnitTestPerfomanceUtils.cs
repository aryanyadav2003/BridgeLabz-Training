using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit.tests
{
    internal class UnitTestPerfomanceUtils
    {
        private PerfomanceUtils utils;

        [SetUp]
        public void Setup()
        {
            utils = new PerfomanceUtils();
        }

        [Test]
        [Timeout(2000)]
        public void LongRunningTask_ShouldFinishWithin2Seconds()
        {
            string result = utils.LongRunningTask();
            Assert.AreEqual("Completed", result);
        }
    }
}
