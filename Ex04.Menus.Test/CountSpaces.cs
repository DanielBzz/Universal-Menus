using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : MenuItem, IExecutable
    {
        private const string k_MenuItemName = "Count Spaces";

        public CountSpaces() : base(k_MenuItemName)
        {
        }

        public void Execute()
        {
            Methods methods = new Methods();
            methods.CountSpaces();
        }
    }
}
