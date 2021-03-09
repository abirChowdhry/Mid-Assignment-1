using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Account
    {
        private int accountNumber;
        protected string name;
        protected double balance;
        protected string dateOfBirth;
        protected Address address;

        public Account(string name, string dateOfBirth, double balance, Address address)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;
        }

       public int AccountNumber 
       {
            get { return accountNumber; }
            set { accountNumber = value; }
       }

      
        public virtual void Withdraw(double ammount)
        {
            if (balance >= ammount)
            {
                balance = balance - ammount;

                Console.WriteLine("Withdrawn " + ammount + "tk");
            }

            else
                Console.WriteLine("Can't Be Withdrawn! Withdraw Ammount Exceed Balance");
        }

        public void Deposite(double ammount)
        {
            balance = balance + ammount;

            Console.WriteLine("Deposited " + ammount + "tk");
        }

        public void Transfer(Account receiver, double ammount)
        {
            if (balance > ammount)
            {
                receiver.balance = receiver.balance + ammount;
                balance = balance - ammount;

                Console.WriteLine("Transferred " + ammount + "tk");
            }

            else
                Console.WriteLine("Can't Be Transferred!");
        }

        public virtual void ShowAccountInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Name " + name);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Date Of Bith: " + AccountNumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine(address.GetAddress());
        }

    }

    class SavingsAccount : Account
    {
        public SavingsAccount(string name, string dateOfBirth, double balance, Address address) : base(name, dateOfBirth, balance, address)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.balance = balance;
            this.address = address;
        }

        public override void Withdraw(double ammount)
        {
            if (balance == ammount)
            {
                Console.WriteLine("Balance Can't Be 0!");
            }
            else
            {
                base.Withdraw(ammount);
            }
        }

        public override void ShowAccountInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Savings Account");
            Console.WriteLine("----------------");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Date Of Bith: " + AccountNumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine(address.GetAddress());
        }
    }
        class CheckingAccount : Account 
        {
            public CheckingAccount(string name, string dateOfBirth, double balance, Address address) : base(name, dateOfBirth, balance, address) 
            {
                this.name = name;
                this.balance = balance;
                this.address = address;
            }

            public override void Withdraw(double ammount)
            {                   
                base.Withdraw(ammount);
            }

           public override void ShowAccountInformation()
           {
            Console.WriteLine();
            Console.WriteLine("Checking Account");
            Console.WriteLine("----------------");
            Console.WriteLine("Name " + name);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Date Of Bith: " + AccountNumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine(address.GetAddress());
           }
        }
}

