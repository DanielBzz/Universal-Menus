using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : MenuItem, IExecutable
    {
        public ShowDate() : base("Show Date")
        {
        }

        public void Execute()
        {
            System.Console.Clear();
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine("press any key to go back ... ");
            Console.ReadLine();
        }
    }
}
