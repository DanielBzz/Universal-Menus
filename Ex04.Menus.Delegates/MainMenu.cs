using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        private const string k_QuitMenuItemName = "Quit";
        private const string k_BackMenuItemName = "Back";
        private const int k_BackOrQuitOption = 0;
        private readonly Dictionary<int, MenuItem> r_MenuItems = new Dictionary<int, MenuItem>();
        private int m_Level = 1;

        public MainMenu(string i_Name) : base(i_Name)
        {
            Add(new MenuItem(k_QuitMenuItemName));
        }

        public int Level
        {
            get
            {
                return m_Level;
            }

            set
            {
                m_Level = value;
            }
        }

        public void Add(MenuItem i_MenuItem)
        {
            MainMenu newMenuToAdd = i_MenuItem as MainMenu;

            if (newMenuToAdd != null)
            {
                newMenuToAdd.Level = m_Level + 1;
                newMenuToAdd.r_MenuItems[0].Name = k_BackMenuItemName;
            }

            r_MenuItems.Add(r_MenuItems.Count, i_MenuItem);
        }

        public void Show()
        {
            bool isActiveMenu = true;

            while (isActiveMenu)
            {
                System.Console.Clear();
                printTitle();
                printMenu();
                handleUserChoice(ref isActiveMenu);
            }
        }

        private void handleUserChoice(ref bool io_IsActiveMenu)
        {
            int userChoise;
            getUserSelection(out userChoise, k_BackOrQuitOption, r_MenuItems.Count - 1);

            if (userChoise == k_BackOrQuitOption)
            {
                io_IsActiveMenu = false;
            }
            else if (r_MenuItems[userChoise] is MainMenu)
            {
                (r_MenuItems[userChoise] as MainMenu).Show();
            }
            else if (r_MenuItems[userChoise] is MethodItem)
            {
                try
                {
                    (r_MenuItems[userChoise] as MethodItem).ActivateMethodItem();
                }
                catch (ArgumentNullException ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("press any key to go back to the last menu..");
                    Console.ReadLine();
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        private void printTitle()
        {
            string title = string.Format(@"({0}) {1}", m_Level, Name);

            Console.WriteLine(title);
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write("_");
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        private void printMenu()
        {
            string choiceMsg = string.Format(@"Choose a number from 0 to {0}", r_MenuItems.Count - 1);

            Console.WriteLine(choiceMsg);
            foreach (KeyValuePair<int, MenuItem> menuItem in r_MenuItems)
            {
                Console.WriteLine(string.Format(@"{0}. {1}", menuItem.Key, menuItem.Value.Name));
            }
        }

        private void getUserSelection(out int o_UserInput, int i_MinValue, int i_MaxValue)
        {
            StringBuilder input = new StringBuilder(Console.ReadLine());

            while (int.TryParse(input.ToString(), out o_UserInput) == false || o_UserInput < i_MinValue || o_UserInput > i_MaxValue)
            {
                Console.WriteLine("Wrong Input");
                input.Clear();
                input.Append(Console.ReadLine());
            }
        }
    }
}
