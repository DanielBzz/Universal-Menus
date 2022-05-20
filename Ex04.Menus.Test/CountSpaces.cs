using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : MenuItem, IExecutable
    {
        public CountSpaces() : base("Count Spaces") { }

        public void Execute()
        {
            Methods methods = new Methods();
            methods.CountSpaces();
        }
    }
}
