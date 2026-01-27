using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.tests
{
    internal class MSTestPerfomanceUtils
    {
        private PerfomanceUtils utils;

        [TestInitialize]
        public void Setup()
        {
            utils = new PerfomanceUtils();
        }
        [TestMethod]
        [Timeout(2000)]
        public void LongRunningTask_ShouldFinishWithin2Seconds()
        {
            string result = utils.LongRunningTask();
            Assert.AreEqual("Completed", result);
        }
    }
}
