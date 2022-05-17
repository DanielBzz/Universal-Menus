using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowDate : MenuItem, IExecutable
    {
        public ShowDate(string i_MenuItemName) : base(i_MenuItemName) { }

        public void Execute()
        {

        }
    }
}
