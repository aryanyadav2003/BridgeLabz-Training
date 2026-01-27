using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nunit.tests
{
    internal class UnitTestDatabase
    {
        private DataBaseConnection db;
        // Runs BEFORE each test
        [SetUp]
        public void Setup()
        {
            db = new DataBaseConnection();
            db.Connect();
        }

        // Runs AFTER each test
        [TearDown]
        public void Teardown()
        {
            db.Disconnect();
        }

        [Test]
        public void Connection_IsEstablished_InSetup()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [Test]
        public void Connection_IsClosed_InTeardown()
        {
            // Simulate post-test cleanup
            db.Disconnect();
            Assert.IsFalse(db.IsConnected);
        }
    }
}
