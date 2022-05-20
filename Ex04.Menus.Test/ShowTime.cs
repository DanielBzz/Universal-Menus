using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : MenuItem, IExecutable
    {
        private const string k_MenuItemName = "Show Time";

        public ShowTime() : base(k_MenuItemName)
        {
        }

        public void Execute()
        {
            Methods.ShowTime();
        }
    }
}
