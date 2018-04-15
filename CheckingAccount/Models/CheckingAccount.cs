using System;
namespace CheckingAccount
{
    public abstract class CheckingAccount
    {
        private double balance;
        private double interestRate;
        private double overDraftFee;




        public CheckingAccount()
        {
            
        }


        public void Withdrawal(double amountWithdrawn)
        {
            //If balance is < 0.00 decline else
            //Subracts amount from balance
            //If balance < 0.00 subtract fee

            if(balance < 0)
            {
                Console.WriteLine($"Your account has ${amountWithdrawn} and cannot be withdrawn from"); 
            }
            else
            {
                balance = balance - amountWithdrawn;
                if(balance < 0)
                {
                    balance = balance - overDraftFee;
                }
            }

        }

        public void Deposit(double amountDeposited)
        {
            balance = balance + amountDeposited;
        }

        public abstract void AddInterest();

        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double newBalance)
        {
            this.balance = newBalance;
        }

        public double getInterestRate()
        {
            return interestRate;
        }

        public void setInterestRate(double newInterestRate)
        {
            this.interestRate = newInterestRate;
        }

        public double getOverDraftFee()
        {
            return overDraftFee;
        }

        public void setOverDraftFee(double newOverDraftFee)
        {
            this.overDraftFee = newOverDraftFee;
        }





    }
}
