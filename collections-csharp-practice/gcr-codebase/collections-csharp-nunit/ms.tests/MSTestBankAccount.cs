using class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace ms.tests
{
    internal class MSTestBankAccount
    {
        private BankAccount account;
        [TestInitialize]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        [TestMethod]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            account.Deposit(500);
            Assert.AreEqual(1500, account.GetBalance());
        }

        [TestMethod]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            account.Withdraw(300);
            Assert.AreEqual(700, account.GetBalance());
        }

        //[TestMethod]
        //[ExpectedException(typeof(InvalidOperationException))]
        //public void Withdraw_InsufficientFunds_ThrowsException()
        //{
        //    account.Withdraw(2000);
        //}
    }
}
