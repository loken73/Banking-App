using System;
using System.Collections.Generic;

namespace Bank 
{
    public class User
    {
        public string firstname {get; set;}

        public string lastname {get; set;}

        public List<Account> UserAccounts = new List<Account>();

        public void ManageAccountList (string type)
        {
            foreach (Account act in UserAccounts)
            {
                if (act.accountType == type)
                {
                    Console.WriteLine(act.accountNumber + "\n");
                }
            }
        }
    }
}