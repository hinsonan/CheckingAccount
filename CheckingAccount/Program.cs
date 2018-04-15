using System;

namespace CheckingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new RegularAccount(1000);

           





            x.AddInterest();
            Console.WriteLine(x.getBalance());

        }
    }
}
