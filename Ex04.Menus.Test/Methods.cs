using System;

namespace Ex04.Menus.Test
{
    public class Methods
    {
        public void ShowDate()
        {
            System.Console.Clear();
            Console.WriteLine(DateTime.Now.ToShortDateString());
            handleEndOfMethod();
        }

        public void ShowTime()
        {
            System.Console.Clear();
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            handleEndOfMethod();
        }

        public void CountSpaces()
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

        public void ShowVersion()
        {
            System.Console.Clear();
            Console.WriteLine("Version: 22.2.4.8950");
            handleEndOfMethod();
        }

        private void handleEndOfMethod()
        {
            Console.WriteLine("Press any key to go back ...");
            Console.ReadLine();
        }
    }
}
