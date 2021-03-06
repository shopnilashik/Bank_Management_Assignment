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
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter your choice between (1-7):");
                Console.WriteLine("1.Open an Account :type 'open'");
                Console.WriteLine("2.Perform transaction on account:type 'account'");
                Console.WriteLine("3.Exit the application: type 'quit'");
                
                string input = Convert.ToString(Console.ReadLine());

                Bank bn = new Bank();
               
                
                switch (input)
                {
                    case "open":
                        bn.create_account();
                        bn.show();
                        
                            break;
                    case "account":
                        Environment.Exit(0);
                        break;
                    case "quit":
                        Environment.Exit(0);
                        break;


                }
         

            }


        }

    }
    
}

