using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string r;
            Bank B1 = new Bank(1 , 999999);
            Bank B2 = new Bank(2 , 999999);
            
            Console.WriteLine("   ****Welcome To Developers Bank****   ");

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Main Menu");
                Console.WriteLine("------------");
                Console.WriteLine("1. Open Account(open)");
                Console.WriteLine("2. Transaction(account)");
                Console.WriteLine("3. Exit The Application(quit)");
                Console.WriteLine();
                Console.WriteLine("Enter Your Choice");
                choice = Console.ReadLine();

                if (choice == "open")
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Open a savings account(savings)");
                    Console.WriteLine("2. Open a checking account(checking)");
                    Console.WriteLine("3. Exit The Application(quit)");
                    Console.WriteLine();
                    Console.WriteLine("Enter Your Choice");
                    choice = Console.ReadLine();

                    if (choice == "savings")
                    {
                        Console.WriteLine("How Many Accoount Do you Want to create:");
                        int numOfAcc = Convert.ToInt32(Console.ReadLine());
                        
                        for (int i = 0; i < numOfAcc; i++)
                        {
                            Console.WriteLine("Enter Name: ");
                            string aname = Console.ReadLine();
                            Console.WriteLine("Enter Date Of Birth: ");
                            string birthday = Console.ReadLine();
                            Console.WriteLine("Enter Balance: ");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Road no of you address:");
                            string roadno = Console.ReadLine();
                            Console.WriteLine("Enter House no of you address:");
                            string houseno = Console.ReadLine();
                            Console.WriteLine("Enter your City:");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter your Country:");
                            string country = Console.ReadLine();

                            SavingsAccount A1 = new SavingsAccount(aname, birthday, balance, new Address(roadno, houseno, city, country));

                            B1.AddAccount1(A1);
                        }
                    }

                    else if (choice == "checking")
                    {
                        Console.WriteLine("How Many Accoount Do you Want to create:");
                        int numOfAcc = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < numOfAcc; i++)
                        {
                            Console.WriteLine("Enter Name: ");
                            string aname = Console.ReadLine();
                            Console.WriteLine("Enter Date Of Birth: ");
                            string birthday = Console.ReadLine();
                            Console.WriteLine("Enter Balance: ");
                            double balance = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter Road no of you address:");
                            string roadno = Console.ReadLine();
                            Console.WriteLine("Enter House no of you address:");
                            string houseno = Console.ReadLine();
                            Console.WriteLine("Enter your City:");
                            string city = Console.ReadLine();
                            Console.WriteLine("Enter your Country:");
                            string country = Console.ReadLine();

                            CheckingAccount A1 = new CheckingAccount(aname, birthday, balance, new Address(roadno, houseno, city, country));

                            B2.AddAccount2(A1);
                        }
                    }

                    else if (choice == "quit")
                    {
                        r = "y";
                        break;
                    }
                }
              
                else if (choice == "account")
                    {
                        Console.WriteLine();
                        Console.WriteLine("1.Make a Withdrawal(withdraw) ");
                        Console.WriteLine("2.Make a Deposite(deposite) ");
                        Console.WriteLine("3.Make a Transfer(transfer) ");
                        Console.WriteLine("4.Show the number of transaction and balance(show) ");
                        Console.WriteLine("5.Exit The Application(quit) ");
                        Console.WriteLine();
                        Console.WriteLine("Enter Your Choice: ");
                        string choice1 = Console.ReadLine();

                        if (choice1 == "withdraw")
                        {
                            Console.WriteLine("Enter The Ammount to Withdraw: ");
                            double ammount = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Account Number: ");
                            int accnum = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Account Type: ");
                            string accType = Console.ReadLine();

                            if (accType == "savings")
                                B1.Transaction(1, ammount, accnum, 1, accType);

                            else if (accType == "checking")
                                B2.Transaction(1, ammount, accnum, 1, accType);
                        }

                        else if (choice1 == "deposite")
                        {
                            Console.WriteLine("Enter The Ammount to Deposite: ");
                            double ammount = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Account Number: ");
                            int accnum = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Account Type: ");
                            string accType = Console.ReadLine();

                            if (accType == "savings")
                                B1.Transaction(2, ammount, accnum, 1, accType);

                            else if (accType == "checking")
                                B2.Transaction(2, ammount, accnum, 1, accType);
                        }

                        else if (choice1 == "transfer")
                        {
                            Console.WriteLine("Enter The Ammount to Transfer: ");
                            double ammount = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Enter Sender Account Number: ");
                            int accnum = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter Sender's Account Type: ");
                            string accType1 = Console.ReadLine();

                            Console.WriteLine("Enter Receiver Account Number: ");
                            int receiver = Convert.ToInt32(Console.ReadLine());

                            if (accType1 == "savings")
                                B1.Transaction(3, ammount, accnum, receiver, accType1);

                            else if (accType1 == "checking")
                                B2.Transaction(3, ammount, accnum, receiver, accType1);
                        }

                        else if (choice1 == "show")
                        {
                            Console.WriteLine("Enter Account Type: ");
                            string accType1 = Console.ReadLine();

                            if (accType1 == "savings")
                                B1.PrintAccountDetails(accType1);

                            else if (accType1 == "checking")
                                B2.PrintAccountDetails(accType1);
                        }

                        else if (choice1 == "quit")
                        {
                            r = "y";
                            break;
                        }

                    }
               

                else if (choice == "quit") 
                {
                    r = "y";
                    break;
                }
                
                    Console.WriteLine();
                    Console.WriteLine("Do you want to go back to main menu(Y/N): ");
                    r = Console.ReadLine();
                
            } while (r == "y" || r == "Y");
        }
    }
}
