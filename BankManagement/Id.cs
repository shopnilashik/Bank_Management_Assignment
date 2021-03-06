using System;
namespace BankManagement
{
    class Id
    {

        public string idgenerator(int inc)
        {
            string start = "0000";
            string id = "21" + (start + inc);
            return id;
        }

        public string generate()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
//return Guid.NewGuid().ToString("N");   