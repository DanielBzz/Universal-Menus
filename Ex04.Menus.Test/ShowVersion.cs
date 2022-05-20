using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : MenuItem, IExecutable
    {
        private const string k_MenuItemName = "Show Version";

        public ShowVersion() : base(k_MenuItemName)
        {
        }

        public void Execute()
        {
            Methods.ShowVersion();
        }
    }
}
