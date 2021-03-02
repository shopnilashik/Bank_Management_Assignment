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



        public void PrintAllAccounts()
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


        public void AddAccount(Account account)
        {
            for (int i = 0; i < yesBank.Length; i++)
            {
                if (yesBank[i] == null)
                {
                    yesBank[i] = account;
                    break;
                }
            }
        }

        public void trans(int typeT, int a)
        {


        }

        public void RemoveAccount(int accountNumber)
        {
            int flag = 0;
            for (int i = 0; i < yesBank.Length; i++)
            {
                if (yesBank[i] == null)
                {
                    continue;
                }
                else if (yesBank[i].AccountNumber == accountNumber)
                {
                    yesBank[i].PrintAccount();
                    flag = 0;

                    int length = yesBank.Length;

                    for (int k = 0; i < (length - i); i++)
                    {
                        yesBank[i] = yesBank[i + 1];
                    }
                    break;
                }
                else
                {
                    flag = 1;

                }

            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");

        
        }
        


    }
}