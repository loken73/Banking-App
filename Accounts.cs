using System;
using System.Collections.Generic;

namespace Bank
{
    public class Account
    {
        public int accountNumber { get; set; }

        public string accountType { get; set; }

        public float accountAmount { get; set; }

        public float initialInvestment(float init)
        {
            this.accountAmount= 0;
            this.accountAmount = init;

            return accountAmount;
        }

        public float accountDeposit(float amt)
        {
            return this.accountAmount + amt;
        }

        public float accountWithdrawal (float amt)
        {
            if (this.accountAmount < amt)
            {
                Console.WriteLine("I am sorry, but you cannot withdraw more funds than what you currently have available.");
                return this.accountAmount;
            }
            else
            {
                return this.accountAmount - amt;
            }
        }
    }
}