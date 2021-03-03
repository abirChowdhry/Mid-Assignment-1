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
        private string accountName;
        private double balance;
        private Address address;

        public Account(string accountName, double balance, Address address)
        {
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }

       public int AccountNumber 
       {
            get { return accountNumber; }
            set { accountNumber = value; }
       }

      
        public void Withdraw(double ammount)
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
            if (balance >= ammount)
            {
                receiver.balance = balance + ammount;
                balance = balance - ammount;

                Console.WriteLine("Transferred " + ammount + "tk");
            }

            else
                Console.WriteLine("Can't Be Transferred! Transfer Ammount Exceed Balance");
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Account Name " + accountName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine(address.GetAddress());
        }

        //public int GetAccNum()
       // {
        //    int a = accountNumber + 1;
        //    return a;
        //}


    }
}
