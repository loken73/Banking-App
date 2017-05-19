using System;
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

                string [] HomeMenu = Menues.StartMenu();
                Menues.MenuMaker(HomeMenu);
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

                    Console.WriteLine("Would you like to deposit, withdraw or delete?");
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
                    else if (depositOrWithdraw == "delete")
                    {
                        Console.WriteLine("Are you sure you want to delete this account?");
                        string deleteAnswer = Console.ReadLine();
                        Console.WriteLine();

                        if (deleteAnswer == "yes")
                        {
                            foreach (Account act in currentUser.UserAccounts)
                            {
                                if (act.accountNumber == exactAccountNumeric)
                                {
                                    currentUser.UserAccounts.Remove(act);

                                    Console.WriteLine("This account {0}, has been removed.\n", exactAccountNumeric);
                                    Console.WriteLine("You now have {0} accounts with us.\n", currentUser.UserAccounts.Count);

                                }
                            }
                        }
                    }
                }
                else if (homeScreenResponse == "3")
                {
                    string [] infoMenu = Menues.AccountInformationMenu();
                    Menues.MenuMaker(infoMenu);
                    string info = Console.ReadLine();

                    if (info == "individual")
                    {
                        Console.WriteLine("Please enter the account number you would like to view");
                        int accountToView = Int32.Parse(Console.ReadLine());

                        foreach (Account act in currentUser.UserAccounts)
                        {
                            if (act.accountNumber == accountToView)
                            {
                                Console.WriteLine("Account Number: {0}, Account Type: {1}, Account Balance: {2}", act.accountNumber, act.accountType, act.accountAmount);
                            }
                        }
                    }
                    else if (info == "all")
                    {
                        float actListTotal = 0;

                        foreach (Account act in currentUser.UserAccounts)
                        {
                            Console.WriteLine("Account Number: {0}, Account Type: {1}, Account Balance: {2}", act.accountNumber, act.accountType, act.accountAmount);
                            Console.WriteLine();

                            actListTotal =+ act.accountAmount;
                        }

                        Console.WriteLine("The total of all your accounts is {0}", actListTotal);
                    }


                }
            } while (homeScreenResponse != "4");
        }

    }

}
