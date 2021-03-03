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
            int choice;
            string r;
            Bank B1 = new Bank("AB", 999999);

            do
            {
                Console.WriteLine("Welcome To AB Bank");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Delete Account");
                Console.WriteLine("3. Transection");
                Console.WriteLine("4. Show Account");

                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("How Many Accoount Do you Want to create:");
                    int numOfAcc = Convert.ToInt32(Console.ReadLine());

                    B1 = new Bank("Brac", numOfAcc);
                    for (int i = 0; i < numOfAcc; i++)
                    {
                        Console.WriteLine("Enter Account Name: ");
                        string aname = Console.ReadLine();
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

                        Account A1 = new Account(aname, balance, new Address(roadno, houseno, city, country));

                        B1.AddAccount(A1);
                    }
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Enter Account Number: ");
                    int accnum = Convert.ToInt32(Console.ReadLine());
                    B1.DeleteAccount(accnum);
                }

                else if (choice == 3)
                {
                    Console.WriteLine("1.Withdraw ");
                    Console.WriteLine("2.Deposite ");
                    Console.WriteLine("3.Transfer ");

                    Console.WriteLine("Enter Your Choice: ");
                    int choice1 = Convert.ToInt32(Console.ReadLine());

                    if (choice1 == 1)
                    {
                        Console.WriteLine("Enter The Ammount to Withdraw: ");
                        double ammount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Ammount Number: ");
                        int accnum = Convert.ToInt32(Console.ReadLine());

                        B1.Transaction(1, ammount, accnum, 1);
                    }

                    else if (choice1 == 2)
                    {
                        Console.WriteLine("Enter The Ammount to Deposite: ");
                        double ammount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Ammount Number: ");
                        int accnum = Convert.ToInt32(Console.ReadLine());

                        B1.Transaction(2, ammount, accnum, 1);
                    }

                    else if (choice1 == 3)
                    {
                        Console.WriteLine("Enter The Ammount to Transfer: ");
                        double ammount = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Sender Account Number: ");
                        int accnum = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Receiver Account Number: ");
                        int receiver = Convert.ToInt32(Console.ReadLine());

                        B1.Transaction(3, ammount, accnum, receiver);
                    }

                }

                else if (choice == 4)
                {
                    B1.PrintAccountDetails();
                }

                Console.WriteLine("Do you want to go back to main menu(Y/N): ");
                r = Console.ReadLine();
            } while (r == "y" || r == "Y");
        }
    }
}
