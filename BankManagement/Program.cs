using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement;

namespace MidTermLabAssignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine("_______Welcome_____");
                Console.WriteLine("Enter your choice between 1-7:");
                Console.WriteLine("\n1.Create Account");
                Console.WriteLine("2.Transfer Money");
                Console.WriteLine("3.Withdrow Money");
                Console.WriteLine("4.Deposit Money");
                Console.WriteLine("5.Change User Name");
                Console.WriteLine("6. Account Details");
                Console.WriteLine("7.Exit");
                int input = Convert.ToInt32(Console.ReadLine());

                Bank bn = new Bank();
                Account ac = new Account();
                switch (input)
                {
                    case 1:
                        bn.createAccount();
                        ac.show();
                            break;
                    case 2:
                        Environment.Exit(0);
                        break;

                    case 6:
                        ac.show();
                        break;

                   defaul:
                        Console.WriteLine();



                }
                
                
                

            }
            
            
            



        }





    }


      
}

