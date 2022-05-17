using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ShowTime : MenuItem, IExecutable
    {
        public ShowTime(string i_MenuItemName) : base(i_MenuItemName) { }

        public void Execute()
        {

        }
    }
}
