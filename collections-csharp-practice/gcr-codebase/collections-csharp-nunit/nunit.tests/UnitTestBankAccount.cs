using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_library;
namespace nunit.tests
{
    internal class UnitTestBankAccount
    {
        private BankAccount account;

        [SetUp]
        public void Setup()
        {
            account = new BankAccount(1000);
        }

        [Test]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            account.Deposit(500);
            Assert.AreEqual(1500, account.GetBalance());
        }

        [Test]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            account.Withdraw(300);
            Assert.AreEqual(700, account.GetBalance());
        }

        [Test]
        public void Withdraw_InsufficientFunds_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(
                () => account.Withdraw(2000)
            );
        }
    }
}
