using System;
namespace BankManagement
{
    class Id
    {
        


        public string generate()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
//return Guid.NewGuid().ToString("N");   