using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ms.tests
{
    internal class MSTestDatabase
    {
        private DataBaseConnection db;

        // Runs BEFORE each test
        [TestInitialize]
        public void Setup()
        {
            db = new DataBaseConnection();
            db.Connect();
        }

        // Runs AFTER each test
        [TestCleanup]
        public void Cleanup()
        {
            db.Disconnect();
        }

        [TestMethod]
        public void Connection_IsEstablished_InSetup()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [TestMethod]
        public void Connection_IsClosed_InCleanup()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected);
        }
    }
}
