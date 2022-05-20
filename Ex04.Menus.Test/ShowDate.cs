using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : MenuItem, IExecutable
    {
        private const string k_MenuItemName = "Show Date";

        public ShowDate() : base(k_MenuItemName)
        {
        }

        public void Execute()
        {
            Methods methods = new Methods();
            methods.ShowDate();
        }
    }
}
