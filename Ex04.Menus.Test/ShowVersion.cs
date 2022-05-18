using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : MenuItem, IExecutable
    {
        public ShowVersion() : base("Show Version")
        {
        }

        public void Execute()
        {
            System.Console.Clear();
            Console.WriteLine("Version: 22.2.4.8950");
            Console.WriteLine("press any key to go back ... ");
            Console.ReadLine();
        }
    }
}
