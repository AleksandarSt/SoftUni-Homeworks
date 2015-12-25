using BankOfKurtovoKonare.Interfaces;
using System;

namespace BankOfKurtovoKonare.Classes
{
    public abstract class Account:IDeposit,IRate
    {
        private Customer customer;
        private decimal balance;
        private decimal monthlyInterestRate;

        protected Account(Customer customer, decimal balance, decimal monthlyInterestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = monthlyInterestRate;
        }


        public Customer Customer { get; set; }

        public decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal MonthlyInterestRate
        {
            get { return this.monthlyInterestRate; }
            set { this.monthlyInterestRate = value; }
        }

        public virtual void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (1 + (this.MonthlyInterestRate / 100) * months);

            return interest;
        }
    }
}
