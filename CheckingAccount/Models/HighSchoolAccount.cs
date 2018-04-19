using System;
namespace CheckingAccount
{
    public class HighSchoolAccount : CheckingAccount
    {
        public HighSchoolAccount()
        {
            setBalance(0);
            setOverDraftFee(0);
            
        }

        public HighSchoolAccount(double newBalance)
        {
            setBalance(newBalance);
            setOverDraftFee(0);

        }

        public override void AddInterest()
        {
            double balance = getBalance();
            double interestRate;

            if (balance < 1000)
            {
                return;
            }
            else if (balance >= 10000)
            {
                setInterestRate(1.0);
            }
            else
            {
                setInterestRate(.5);

            }

            interestRate = getInterestRate();


            setBalance(balance + (balance * ((interestRate) / 100) * .0833));

        }
    }
}
