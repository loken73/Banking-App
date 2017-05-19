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
                "3 - Account Information",
                "4 - Quit"
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

        public static string[] AccountInformationMenu()
        {
            string [] info = new string []{
                "Would you like to view information of an individual account or of all your accounts.",
                "Please answer with the either individual or all to view the corresponding information"
            };

            return info;
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