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
            var regularAccount = new RegularAccount(600);
            regularAccount.Withdrawal(599);
            Assert.Equal(1, regularAccount.getBalance());

            regularAccount.setBalance(600);
            regularAccount.Withdrawal(600);
            Assert.Equal(0, regularAccount.getBalance());

            regularAccount.setBalance(600);
            regularAccount.Withdrawal(601);
            Assert.Equal(-36, regularAccount.getBalance());

            regularAccount.setBalance(-1);
            regularAccount.Withdrawal(1);
            Assert.Equal(-1, regularAccount.getBalance());

        }

        [Fact]
        public void DepositTest()
        {
            var regularAccount = new RegularAccount(600);
            regularAccount.Deposit(50);
            Assert.Equal(650, regularAccount.getBalance());

            regularAccount.setBalance(600);
            regularAccount.Deposit(0);
            Assert.Equal(600, regularAccount.getBalance());

        }

        [Fact]
        public void AddInterestTest()
        {
            var regularAccount = new RegularAccount(1000);
            regularAccount.AddInterest();
            Assert.Equal(1000.416, regularAccount.getBalance(), 3);

            regularAccount.setBalance(150);
            regularAccount.AddInterest();
            Assert.Equal(150, regularAccount.getBalance());

            regularAccount.setBalance(10000);
            regularAccount.AddInterest();
            Assert.Equal(10008.333, regularAccount.getBalance(), 2);

        }
    }
}
