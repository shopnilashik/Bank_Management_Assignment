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
            int start = 999;
            int an = start + inc;
            return an;
        }
        static void Main(string[] args)
        {
           
            {
               
                    Console.WriteLine("How many accounts do you want to create? ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Bank ourBank = new Bank("Developer's bank", num);
                
                        for (int i = 0; i < num; i++)
                        {

                            Console.WriteLine("\nAccount Number " + (i + 1));
                            Console.WriteLine("Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Ammount: ");
                            int ammount = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("House no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Road no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("City: ");
                            string city = Console.ReadLine();
                            Console.WriteLine("Country: ");
                            string country = Console.ReadLine();

                            ourBank.AddAccount(new Account(name, ammount, AccountNumberGen(i), new Address(houseNo, roadNo, city, country)));
                            Console.WriteLine("Your Account Number : {0}",an);
                        }




                Console.WriteLine("Do You want to Transaction..?? ");
                    Console.WriteLine("1.Withdrow");
                    Console.WriteLine("2.Deposite");
                    int la = int.Parse(Console.ReadLine());
                switch (la)
                {

                    case 1:
                        Account dep = new Account();
                        Console.WriteLine("Enter Your Account Number");
                        int acce = int.Parse(Console.ReadLine());

                        dep.Deposit(acce);
                        break;
                    case 2:
                        Account wit = new Account();
                        Console.WriteLine("Enter Your Account Number");
                        int acca = int.Parse(Console.ReadLine());
                        wit.Withdraw(acca);
                        break;
                }
                 



                    //ourBank.PrintAllAccounts();

            }


        }
                   

    
   


           

    }



        


}

