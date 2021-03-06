using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement;

namespace MidTermLabAssignment1
{
    class Bank
    {
        public string name,username,d,m,y,address;
        public int balance = 0;
        internal int depo;
        public int wit;
        public string actyp;
        Id idg = new Id();


        protected char type;
        public void create_account()
        {
            
            Console.WriteLine("1. Open a Savings Account : type 'savings'");
            Console.WriteLine("2. Open an Checking Account :type 'checking'");
            actyp = Convert.ToString(Console.ReadLine());
            switch (actyp)
            {
                case "savings":

                    savDisplay();
                    break;
                case "checking":
                    cheDisplay();
                    break;

            }

            Console.WriteLine("\n Enter you name; ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your Username:");
            username = Console.ReadLine();

            Console.WriteLine("\n Enter you Birth date:  ");
            d = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Month");
            m = Console.ReadLine();

            Console.WriteLine("\n Enter you Birth Year; ");
            y = Console.ReadLine();

            Console.WriteLine("Enter your Address:");
            address = Console.ReadLine();

            

            Console.WriteLine("Your first opening ammount :");
            balance = Convert.ToInt32(Console.ReadLine());


            switch (actyp)
            {
                case "savings":

                    savDisplay();
                    break;
                case "checking":
                    cheDisplay();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;

            }



        }
        public void show() 
        {
            Console.WriteLine("\n\n\n\n\n\n_________Details_______");
            Console.WriteLine("Your Account Number : {0}",idg.generate());
            Console.WriteLine("Your Name  :{0}",name);
            Console.WriteLine("Username   :{0}", username);
            Console.WriteLine("Your Birthdate   :{0}-{1}-{2}",d,m,y);
           
            Console.WriteLine("Yout address  :{0}", address);

            Console.WriteLine("Your account type: {0}", actyp);
         
            Console.WriteLine("Your Balance: {0}", balance);


        }
        public void savDisplay()
        {
            Console.WriteLine("Saving Account");
        }
        public void cheDisplay()
        {
            Console.WriteLine("Checking Account");
        }
        public void account()
        {
            string com;
            Console.WriteLine("\n\n\nMake a deposit");
            Console.WriteLine("Make a withdrow");
            Console.WriteLine("Make a transaction");
            Console.WriteLine("Show the number of transaction and balance");
            Console.WriteLine("Exit the application");
            com = Console.ReadLine();
            switch (com)
            {

                case "deposit":
                    Deposit();
                    break;
                case "withdrow":
                    Withdrow();
                    break;
                case "transfer":
                    break;
                case "show":
                    show();
                    break;
                case "quit":
                    Environment.Exit(0);
                    break;
            }

        }


        public int Deposit()
        {
            Console.WriteLine("Your Current Balance :{0}",balance);
            Console.WriteLine("Enter the amount want to Deposit ");
            depo = Convert.ToInt32(Console.ReadLine());
            balance = depo + balance;
            Console.WriteLine("New Balance :{0}",balance);
            return Convert.ToInt32(balance);
        }
        public int withdrod()
        {
            balance = balance - wit;
            return balance;
        }
        public void Withdrow()
        {
            Console.WriteLine("1.Saving Account");
            Console.WriteLine("2.Checking Account");
            int typ = Convert.ToInt32(Console.ReadLine());

            switch (typ)
            {
                case 1:
                    
                    
                    Console.WriteLine("in Saving Account Balance can't be zero ");
                    Console.WriteLine("Enter a mount");
                    wit = Convert.ToInt32(Console.ReadLine());
                    if (balance == 0)
                    {
                        Console.WriteLine("Your balance cnt't be zero");
                    }
                    else
                    {
                        balance = balance - wit;
                    }
                    
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter amount");
                        wit = Convert.ToInt32(Console.ReadLine());
                        balance = balance - wit;
                       

                    }
                    break;
            }

            
        }
        public void transfer()
        {
            Console.WriteLine("Enter account number to transfer");
            string accNUm = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter a amount ");
            int balance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Balance is transfered");
        }
    }

}

        
