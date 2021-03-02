using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermLabAssignment1
{
    class Bank
    {

        private string bankName;
        public static Account[] yesBank;
        public static int size;

        public Bank(string bankName, int size)
        {
            Bank.size = size;
            this.bankName = bankName;
            yesBank = new Account[size];
        }

        public Bank() { }
           

       

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }


        public Account[] Accounts
        {
            set { Bank.yesBank = value; }
            get { return Bank.yesBank; }
        }

        public Account[] yesbank
        {
            get {

                return yesBank;
            }
            set {
                yesBank = value;

            }
        }

        public void PrintAllAccounts()
        {
            Console.WriteLine( BankName );
            for (int i = 0; i < yesBank.Length; i++)
            {
                if (yesBank[i] == null)
                {
                    continue;
                }
                yesBank[i].PrintAccount();
            }
            
        }

        public void AddAccount(Account account)
        {
            
                for (int i = 0; i < yesBank.Length; i++)
                {
                    if (yesBank[i] == null)
                    {

                        continue;
                    }
                

            
                yesBank[i].PrintAccount();
            }
        }

        public void trans(int transT, int a)
        {


        }

        public void RemoveAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < yesBank.Length; i++)
            {
                if (yesBank[i].AccountNumber == accountNumber)
                {
                    

                    yesBank[i] = null;
                    Console.WriteLine("Account Deleted");
                    flag = 1;
                    break;
                }
                else if (yesBank[i] == null)
                {
                    for (int k = 0; k < (yesBank.Length - i); k++)
                    {
                        yesBank[i] = yesBank[i + 1];
                    }
                    continue;
                }
                else
                {
                    flag = 0;

                }

            }
            if (flag == 0)
                Console.WriteLine("Account Not Found");
        }

        

    }
}