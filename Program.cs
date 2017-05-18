using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            string homeScreenResponse;

            do
            {
                string [] CurrentMenu = Menues.StartMenu();
                Menues.MenuMaker(CurrentMenu);
                homeScreenResponse = Console.ReadLine();

                if (homeScreenResponse == "1")
                {
                    User currentUser = new User();
                    Menues.MenuMaker(Menues.CreateAccountMenu());

                    Console.WriteLine("What is your first name?");
                    currentUser.firstname = Console.ReadLine();

                    Console.WriteLine("What is your last name?");
                    currentUser.lastname = Console.ReadLine();

                    Random number = new Random();

                    currentUser.UserAccount.accountNumber = number.Next(100000000, 999999999);

                    Console.WriteLine("Your new account number is {0}", currentUser.UserAccount.accountNumber);
                }
                else if (homeScreenResponse == "2")
                {

                }
            } while (homeScreenResponse != "3");
        }

    }

}
