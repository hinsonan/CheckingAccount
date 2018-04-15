using System;
using Xunit;
using CheckingAccount;

namespace CheckingAccountTest
{
    public class RegularAccountTest
    {
        [Fact]
        public void WithdrawalTest()
        {
            var RegularAccount = new RegularAccount(600);
            RegularAccount.Withdrawal(599);
            Assert.Equal(1, RegularAccount.getBalance());

            RegularAccount.setBalance(600);
            RegularAccount.Withdrawal(600);
            Assert.Equal(0, RegularAccount.getBalance());

            RegularAccount.setBalance(600);
            RegularAccount.Withdrawal(601);
            Assert.Equal(-36, RegularAccount.getBalance());

            RegularAccount.setBalance(-1);
            RegularAccount.Withdrawal(1);
            Assert.Equal(-1, RegularAccount.getBalance());

        }

        [Fact]
        public void DepositTest()
        {
            var RegularAccount = new RegularAccount(600);
            RegularAccount.Deposit(50);
            Assert.Equal(650, RegularAccount.getBalance());

            RegularAccount.setBalance(600);
            RegularAccount.Deposit(0);
            Assert.Equal(600, RegularAccount.getBalance());

        }
    }
}
