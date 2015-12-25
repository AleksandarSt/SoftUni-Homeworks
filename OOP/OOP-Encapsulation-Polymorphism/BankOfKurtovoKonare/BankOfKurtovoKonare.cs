using BankOfKurtovoKonare.Classes;
using System;

namespace BankOfKurtovoKonare
{
    class BankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            Customer indiv1 = new IndividualCustomer("Ivan Todorov");
            Customer indiv2 = new IndividualCustomer("Georgi Georgiev");
            Customer comp = new CompanyCustomer("Toplivo AD");

            Account[] someAccounts = new Account[4]
            {
                new DepositAccount(indiv1,1020,0.4m),
                new LoanAccount(indiv2,300,3),
                new MortgageAccount(indiv2,20000,2),
                new DepositAccount(comp,4000,4)
            };

            foreach (var item in someAccounts)
            {
                Console.WriteLine(item.CalculateInterest(5));
            }
        }
    }
}
