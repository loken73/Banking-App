using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> CurrentMenu = new List<string> ();
            string [] start = Menues.StartMenu();
            CurrentMenu.InsertRange(0, start);
            Menues.MenuMaker(CurrentMenu);
            var homeScreenResponse = Console.ReadLine();

            if (homeScreenResponse == "1")
            {

            }
            else if (homeScreenResponse == "2")
            {

            }
            else 
            {
                Console.WriteLine("Thank you for choosing Big Bank Inc.");
            }
        }

    }

}
