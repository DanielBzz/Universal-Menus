using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : MenuItem, IExecutable
    {
        public ShowTime() : base("Show Time")
        {
        }

        public void Execute()
        {
            System.Console.Clear();
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine("press any key to go back ... ");
            Console.ReadLine();
        }
    }
}
