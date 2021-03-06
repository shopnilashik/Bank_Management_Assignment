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
                
                Console.WriteLine("_______Welcome_____");
                Console.WriteLine("\n\n\n");
                
                Console.WriteLine("Enter your choice between (1-3):");
                Console.WriteLine("1.Open an Account :    type 'open'");
                Console.WriteLine("2.Perform transaction on account:   type 'account'");
                Console.WriteLine("3.Exit the application:   type 'quit'");
                
                string input = Convert.ToString(Console.ReadLine());

                Bank bn = new Bank();
               
                
                switch (input)
                {
                    case "open":
                        bn.create_account();
                        bn.show();
                        
                            break;
                    case "account":
                        bn.account();
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;


                }
         

            }


        }

    }
    
}

