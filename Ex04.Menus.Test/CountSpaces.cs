using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : MenuItem, IExecutable
    {
        public CountSpaces() : base("Count Spaces")
        {
        }

        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            int counter = 0;

            foreach (char character in sentence)
            {
                if (char.IsWhiteSpace(character))
                {
                    ++counter;
                }
            }

            Console.WriteLine("In the sentence you enter there is {0} spaces", counter);
            Console.WriteLine("press any key to go back ... ");
            Console.ReadLine();
        }
    }
}
