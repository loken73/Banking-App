﻿using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            string homeScreenResponse;
            User currentUser = new User();

            do
            {
                Account currentAccount = new Account();

                string [] CurrentMenu = Menues.StartMenu();
                Menues.MenuMaker(CurrentMenu);
                homeScreenResponse = Console.ReadLine();
                Console.WriteLine();

                if (homeScreenResponse == "1")
                {
                    currentAccount.accountNumber =  0;
                    currentAccount.accountAmount = 0;

                    Menues.MenuMaker(Menues.CreateAccountMenu());

                    Console.WriteLine("What is your first name?");
                    currentUser.firstname = Console.ReadLine();

                    Console.WriteLine("What is your last name?");
                    currentUser.lastname = Console.ReadLine();

                    Console.WriteLine("What type of account would you like to open right now.");
                    currentAccount.accountType = Console.ReadLine();

                    Random number = new Random();

                    currentAccount.accountNumber = number.Next(100000000, 999999999);

                    currentUser.UserAccounts.Add(currentAccount);

                    Console.WriteLine("Hello, {0} {1}. Your new {2} account number is {3}.\n", currentUser.firstname, currentUser.lastname, currentAccount.accountType, currentAccount.accountNumber);
                }
                else if (homeScreenResponse == "2")
                {
                    int exactAccountNumeric;

                    Console.WriteLine("Would you like to manage your checking accounts or savings accounts?");
                    string manageAccountChoice = Console.ReadLine();
                    Console.WriteLine();

                    currentUser.ManageAccountList(manageAccountChoice);
                    Console.WriteLine("Please choose the {0} account by entering the corresponding account number listed.", manageAccountChoice);
                    string exactAccount = Console.ReadLine();
                    Int32.TryParse(exactAccount, out exactAccountNumeric);
                    Console.WriteLine();

                    Console.WriteLine("Would you like to deposit or withdraw?");
                    string depositOrWithdraw = Console.ReadLine();
                    Console.WriteLine();

                    if (depositOrWithdraw == "deposit")
                    {
                        Console.WriteLine("Please enter the amount you would like to deposit.");
                        float depositAmount = float.Parse(Console.ReadLine());

                        currentAccount.accountAmount = currentAccount.accountDeposit(depositAmount);

                        Console.WriteLine("Great job on the deposit to your {0} account. Your account balance is ${1}.", manageAccountChoice, currentAccount.accountAmount);
                    }
                    else if (depositOrWithdraw == "withdraw")
                    {
                        Console.WriteLine("Please enter the amount you would like to withdraw. \n");
                        float withdrawAmount = float.Parse(Console.ReadLine());

                        currentAccount.accountAmount = currentAccount.accountWithdrawal(withdrawAmount);

                        Console.WriteLine("You just withdrew ${0} from your {1} account.\n", currentAccount.accountAmount, manageAccountChoice);
                    }



                }
            } while (homeScreenResponse != "3");
        }

    }

}
