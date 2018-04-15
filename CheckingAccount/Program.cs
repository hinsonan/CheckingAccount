using System;

namespace CheckingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new RegularAccount(1000);

            x.Withdrawal(1001);

            Console.WriteLine(x.getBalance());

            x.Deposit(20);
            Console.WriteLine(x.getBalance());

            x.AddInterest();
            Console.WriteLine(x.getBalance());

        }
    }
}
