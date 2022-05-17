using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : MenuItem, IExecutable
    {
        public CountSpaces(string i_MenuItemName) : base(i_MenuItemName) { }

        public void Execute()
        {

        }
    }
}
