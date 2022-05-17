using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowVersion : MenuItem, IExecutable
    {
        public ShowVersion(string i_MenuItemName) : base(i_MenuItemName) { }

        public void Execute()
        {

        }
    }
}
