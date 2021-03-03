using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        AccountNumberGenerate a1 = new AccountNumberGenerate();

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            myBank = new Account[size];
        }

        public void AddAccount(Account account)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    myBank[i].AccountNumber = a1.AccNumGenerate();
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("Account Created");
            }
            else if (flag == 0) 
            {
                Console.WriteLine("Account Can't be Created");
            }
        }

        public void DeleteAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                     myBank[i] = null;
                     flag = 1;
                    break;
                }

            }
            if (flag == 0)
                Console.WriteLine("Account not found");

            else if (flag == 1)
                Console.WriteLine("Account Deleted");
        }

        public void Transaction(int transactionType, double amm, int accountNumber, int receiverAccNum)
        {
            if (transactionType == 1)
            {
                int flag = 0;
                for (int i = 0; i < myBank.Length; i++)
                {

                    if (myBank[i] == null)
                    {
                        continue;
                    }
                    else if (myBank[i].AccountNumber == accountNumber)
                    {
                        myBank[i].Withdraw(amm);
                        flag = 1;
                        break;
                    }
                }

                if(flag == 0)
                    Console.WriteLine("Account not found");
            }

            else if (transactionType == 2)
            {
                int flag = 0;
                for (int i = 0; i < myBank.Length; i++)
                {
                    if (myBank[i] == null)
                    {
                        continue;
                    }
                    else if (myBank[i].AccountNumber == accountNumber)
                    {
                        myBank[i].Deposite(amm);
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.WriteLine("Account not found");
            }

            else if (transactionType == 3)
            {
                int flag=0;
                for (int i = 0; i < myBank.Length; i++)
                {
                    if (myBank[i] == null)
                    {
                        continue;
                    }
                    else if (myBank[i].AccountNumber == accountNumber)
                    {
                        flag = 1;
                        int flag2=0;
                        for (int j = 0; j < myBank.Length; j++)
                        {
                            if (myBank[j] == null)
                            {
                                continue;
                            }
                            else if (myBank[j].AccountNumber == receiverAccNum)
                            {
                                myBank[i].Transfer(myBank[j], amm);
                                flag2 = 1;
                                break;
                            }
                            if(flag2==0)
                                Console.WriteLine("Reciever Account Not Found!");
                        }
                    }
                    if(flag==0)
                        Console.WriteLine("Sender Account Not Found!");
                }
            }
        }

        public void PrintAccountDetails()
        {
            int flag = 0;

            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }

                else
                {
                    myBank[i].ShowAccountInformation();
                    flag = 1;
                }
            }

            if(flag == 0)
                Console.WriteLine("No Account To Show!");
        }
    }
}
