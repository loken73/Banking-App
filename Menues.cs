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
                "How can we be of service?",
                "1 - Create an Account",
                "2 - Manage your Account",
                "3 - Quit"
            };

            return Start;
        }

        public static void MenuMaker (List<string> menu)
        {
            foreach (string item in menu)
            {
                Console.WriteLine("{0}\n", item);
            }
        } 
    }
}