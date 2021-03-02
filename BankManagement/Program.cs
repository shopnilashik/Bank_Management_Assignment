using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Program
    {
        static int AccountNumberGen(int inc)
        {
            int start = 2021;
            int an = start + inc;
            return an;
        }

        static void Main(string[] args)
        {
            bool flag = true;


            Console.WriteLine("How can i help u sir");

            int a;
            Account acc = new Account();
            //Console.WriteLine("How many accounts do you want to create? ");
            //a = Convert.ToInt32(Console.ReadLine());
            Bank weBank = new Bank();

            while (flag)
            {
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Print Details");
                Console.WriteLine("3.Deposite Money");
                Console.WriteLine("4.Withdrow Money");
                Console.WriteLine("5.Remove Account");
                Console.WriteLine("6.Transfer Money");
                Console.WriteLine("7.Exit"); 
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {

                    case 1:

                        //Account acc = new Account();
                        
                        Console.WriteLine("How Many Accounts Do You Want To Create? ");
                        a = Convert.ToInt32(Console.ReadLine());
                       
                        //Bank weBank = new Bank("Tradestone Bank", a);
                        for (int i = 0; i < a; i++)
                        {
                            Console.WriteLine("\nAccount " + (i + 1));
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ammount: ");
                            double ammount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("House no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Road no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("City: ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Country: ");
                            string country = Console.ReadLine();

                            weBank.AddAccount(new Account(name, ammount, AccountNumberGen(i), new Address(houseNo, roadNo, city, country)));

                        }
                        break;
                    case 2:
                        weBank.PrintAllAccounts();
                        break;
                        
                    case 3:
                        Console.WriteLine("\nDeposit ammount: ");
                        double dep = Convert.ToInt32(Console.ReadLine());
                        acc.Deposit(dep);
                        break;
                        
                    case 4:
                        Console.WriteLine("\nWithdraw ammount: ");
                        double withd = Convert.ToInt32(Console.ReadLine());
                        acc.Withdraw(withd);
                        break;

                    case 5:

                        Console.WriteLine("Account No: ");
                        int delAC = Convert.ToInt32(Console.ReadLine());
                        weBank.RemoveAccount(delAC);
                        break;
                    case 6:
                        Console.WriteLine("\nTransfer ammount: ");
                        double tran = Convert.ToInt32(Console.ReadLine());
                        //Console.WriteLine("\nTransfer Account: ");
                        //int a = Convert.ToInt32(Console.ReadLine());
                        acc.Transfer(tran);
                        break;

                    case 7:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Enter valid Number\n");
                        continue;



                }


            }

        }

    }
}

