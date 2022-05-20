using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : MenuItem, IExecutable
    {
        public ShowDate() : base("Show Date") { }

        public void Execute()
        {
            Methods methods = new Methods();
            methods.ShowDate();
        }
    }
}
