using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class InterfaceMenu
    {
        private readonly MainMenu r_MainMenu = new MainMenu("Interface MainMenu");

        public void Show()
        {
            MainMenu versionsAndSpacesMenu = new MainMenu("Versions And Spaces");
            MainMenu showDateTimeMenu = new MainMenu("Show Date or Time");
            ShowDate showDate = new ShowDate();
            ShowTime showTime = new ShowTime();
            ShowVersion showVersion = new ShowVersion();
            CountSpaces countSpaces = new CountSpaces();

            r_MainMenu.Add(showDateTimeMenu);
            r_MainMenu.Add(versionsAndSpacesMenu);
            showDateTimeMenu.Add(showDate);
            showDateTimeMenu.Add(showTime);
            versionsAndSpacesMenu.Add(showVersion);
            versionsAndSpacesMenu.Add(countSpaces);

            try
            {
                r_MainMenu.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
