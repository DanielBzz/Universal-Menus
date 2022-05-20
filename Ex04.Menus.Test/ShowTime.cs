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
            Methods methods = new Methods();
            methods.ShowTime();
        }
    }
}
