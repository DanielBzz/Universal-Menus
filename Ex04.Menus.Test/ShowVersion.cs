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
            Methods methods = new Methods();
            methods.ShowVersion();
        }
    }
}
