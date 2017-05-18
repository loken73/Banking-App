using System;
using System.Collections.Generic;


namespace Bank 
{
    public class Menues 
    {
        public static string[] StartMenu()
        {
            string [] Start = new string[]{
                "Welcome to Big Bank Inc.",
                "How can we be of service? Please enter the corresponding number.",
                "1 - Create an Account",
                "2 - Manage your Account",
                "3 - Quit"
            };

            return Start;
        }

        public static string[] CreateAccountMenu() 
        {
            string [] newAccount = new string[]{ 
                "Welcome to your new Account with Big Bank Inc.",
                "You are going to have to tell us a little bit about yourself before we continue"
            };

            return newAccount;
        }

        public static void MenuMaker (string[] menu)
        {
            foreach (string item in menu)
            {
                Console.WriteLine("{0}\n", item);
            }
        } 
    }
}