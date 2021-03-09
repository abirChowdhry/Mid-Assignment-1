using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Bank
    {
        private SavingsAccount[] myBank1;
        private CheckingAccount[] myBank2;

        AccountNumberGenerate a1 = new AccountNumberGenerate();

        public Bank(int accountType, int size)
        {
            if (accountType == 1)
                myBank1 = new SavingsAccount[size];

            else if (accountType == 2)
                myBank2 = new CheckingAccount[size];
        }

        public void AddAccount1(SavingsAccount account)
        {
            int flag = 0;
            for (int i = 0; i < myBank1.Length; i++)
            {
                if (myBank1[i] == null)
                {
                    myBank1[i] = account;
                    myBank1[i].AccountNumber = a1.AccNumGenerate();
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
        public void AddAccount2(CheckingAccount account)
        {
            int flag = 0;
            for (int i = 0; i < myBank2.Length; i++)
            {
                if (myBank2[i] == null)
                {
                    myBank2[i] = account;
                    myBank2[i].AccountNumber = a1.AccNumGenerate();
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


        public void Transaction(int transactionType, double amm, int accountNumber, int receiverAccNum, string accountType)
        {
            if (accountType == "savings")
            {
                if (transactionType == 1)
                {
                    int flag = 0;
                    for (int i = 0; i < myBank1.Length; i++)
                    {

                        if (myBank1[i] == null)
                        {
                            continue;
                        }
                        else if (myBank1[i].AccountNumber == accountNumber)
                        {
                            myBank1[i].Withdraw(amm);
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        Console.WriteLine("Account not found");
                }

                else if (transactionType == 2)
                {
                    int flag = 0;
                    for (int i = 0; i < myBank1.Length; i++)
                    {
                        if (myBank1[i] == null)
                        {
                            continue;
                        }
                        else if (myBank1[i].AccountNumber == accountNumber)
                        {
                            myBank1[i].Deposite(amm);
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        Console.WriteLine("Account not found");
                }

                else if (transactionType == 3)
                {
                    int flag = 0;
                    int flag2 = 0;

                    for (int i = 0; i < myBank1.Length; i++)
                    {
                        if (myBank1[i] == null)
                        {
                            continue;
                        }
                        else if (myBank1[i].AccountNumber == accountNumber)
                        {
                            flag = 1;

                            for (int j = 0; j < myBank1.Length && j < myBank2.Length; j++)
                            {
                                if (myBank1[j] == null || myBank2 == null)
                                {
                                    continue;
                                }

                                else if (myBank1[j].AccountNumber == receiverAccNum)
                                {
                                    myBank1[i].Transfer(myBank1[j], amm);
                                    flag2 = 1;
                                    break;
                                }

                                else if (myBank2[j].AccountNumber == receiverAccNum)
                                {
                                    myBank1[i].Transfer(myBank2[j], amm);
                                    flag2 = 1;
                                    break;
                                }
                            }
                        }

                        if (flag2 == 0)
                            Console.WriteLine("Reciever Account Not Found!");
                    }

                    if (flag == 0)
                    {
                        Console.WriteLine("Sender Account Not Found!");
                    }
                }
            }

            else if (accountType == "checking")
            {
                if (transactionType == 1)
                {
                    int flag = 0;
                    for (int i = 0; i < myBank2.Length; i++)
                    {

                        if (myBank2[i] == null)
                        {
                            continue;
                        }
                        else if (myBank2[i].AccountNumber == accountNumber)
                        {
                            myBank2[i].Withdraw(amm);
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        Console.WriteLine("Account not found");
                }

                else if (transactionType == 2)
                {
                    int flag = 0;
                    for (int i = 0; i < myBank2.Length; i++)
                    {
                        if (myBank2[i] == null)
                        {
                            continue;
                        }
                        else if (myBank2[i].AccountNumber == accountNumber)
                        {
                            myBank2[i].Deposite(amm);
                            flag = 1;
                            break;
                        }
                    }

                    if (flag == 0)
                        Console.WriteLine("Account not found");
                }

                else if (transactionType == 3)
                {
                    int flag = 0;
                    int flag2 = 0;

                    for (int i = 0; i < myBank2.Length; i++)
                    {
                        if (myBank2[i] == null)
                        {
                            continue;
                        }

                        else if (myBank2[i].AccountNumber == accountNumber)
                        {
                            flag = 1;

                            for (int j = 0; j < myBank2.Length && j <myBank1.Length; j++)
                            {
                                if (myBank1[j] == null || myBank2[j] == null)
                                {
                                    continue;
                                }

                                else if (myBank1[j].AccountNumber == receiverAccNum)
                                {
                                    myBank2[j].Transfer(myBank1[j], amm);
                                    flag2 = 1;
                                    break;
                                }

                                else if (myBank2[j].AccountNumber == receiverAccNum) 
                                {
                                    myBank2[j].Transfer(myBank2[j], amm);
                                    flag2 = 1;
                                    break;
                                }
                            }

                            if (flag2 == 0)
                                Console.WriteLine("Reciever Account Not Found!");
                        }


                        if (flag == 0)
                            Console.WriteLine("Sender Account Not Found!");

                    }
                }
            }
        }
            public void PrintAccountDetails(string acctype)
            {
                if (acctype == "savings")
                {
                    int flag = 0;

                    for (int i = 0; i < myBank1.Length; i++)
                    {
                        if (myBank1[i] == null)
                        {
                            continue;
                        }

                        else
                        {
                            myBank1[i].ShowAccountInformation();
                            flag = 1;
                        }
                    }

                    if (flag == 0)
                        Console.WriteLine("No Account To Show!");
                }
                else if (acctype == "checking")
                {
                    int flag = 0;

                    for (int i = 0; i < myBank2.Length; i++)
                    {
                        if (myBank2[i] == null)
                        {
                            continue;
                        }

                        else
                        {
                            myBank2[i].ShowAccountInformation();
                            flag = 1;
                        }
                    }

                    if (flag == 0)
                        Console.WriteLine("No Account To Show!");
                }
            }
        }
    } 


