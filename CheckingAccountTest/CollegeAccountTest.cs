using System;
using Xunit;
using CheckingAccount;

namespace CheckingAccountTest
{
    public class CollegeAccountTest
    {
        [Fact]
        public void WithdrawalTest()
        {
            var collegeAccount = new CollegeAccount(600);
            collegeAccount.Withdrawal(599);
            Assert.Equal(1, collegeAccount.getBalance());

            collegeAccount.setBalance(600);
            collegeAccount.Withdrawal(600);
            Assert.Equal(0, collegeAccount.getBalance());

            collegeAccount.setBalance(600);
            collegeAccount.Withdrawal(601);
            Assert.Equal(-16, collegeAccount.getBalance());

            collegeAccount.setBalance(-1);
            collegeAccount.Withdrawal(1);
            Assert.Equal(-1, collegeAccount.getBalance());

        }

        [Fact]
        public void DepositTest()
        {
            var collegeAccount = new CollegeAccount(600);
            collegeAccount.Deposit(50);
            Assert.Equal(650, collegeAccount.getBalance());

            collegeAccount.setBalance(600);
            collegeAccount.Deposit(0);
            Assert.Equal(600, collegeAccount.getBalance());

        }

        [Fact]
        public void AddInterestTest()
        {
            var collegeAccount = new CollegeAccount(1000);
            collegeAccount.AddInterest();
            Assert.Equal(1000.416, collegeAccount.getBalance(), 3);

            collegeAccount.setBalance(150);
            Assert.Equal(150, collegeAccount.getBalance());

        }
    }
}
