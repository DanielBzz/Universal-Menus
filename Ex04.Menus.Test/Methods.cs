using System;

namespace Ex04.Menus.Test
{
    public static class Methods
    {
        public static void ShowDate()
        {
            System.Console.Clear();
            Console.WriteLine(DateTime.Now.ToShortDateString());
            handleEndOfMethod();
        }

        public static void ShowTime()
        {
            System.Console.Clear();
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            handleEndOfMethod();
        }

        public static void CountSpaces()
        {
            Console.Clear();
            Console.WriteLine("Please enter a string");
            string sentence = Console.ReadLine();
            int counter = 0;

            foreach (char character in sentence)
            {
                if (char.IsWhiteSpace(character))
                {
                    ++counter;
                }
            }

            Console.WriteLine("You entered {0} spaces", counter);
            handleEndOfMethod();
        }

        public static void ShowVersion()
        {
            System.Console.Clear();
            Console.WriteLine("Version: 22.2.4.8950");
            handleEndOfMethod();
        }

        private static void handleEndOfMethod()
        {
            Console.WriteLine("Press enter to go back ...");
            Console.ReadLine();
        }
    }
}
