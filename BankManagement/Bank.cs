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
        public string name;
        internal int deposit;
        protected char type;
        private void create_account()
        {
            Console.WriteLine("\n Enter you name; ");
            name = Console.ReadLine();
            Console.WriteLine("name{0}",name);




            

        }

        public void createAccount()
        {   
            create_account();
            Bank bn = new Bank();
            Console.WriteLine("name{0}   :", bn.name);
        }

        //public void show()
        //{
        //    Console.WriteLine("name{0}   :", name);

        //}
    }
}

        
