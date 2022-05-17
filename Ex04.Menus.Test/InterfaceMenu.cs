using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceMenu
    {
        private Menu m_MainMenu = new Menu("Interface Menu");

        public void Show()
        {
            Menu versionsAndSpacesMenu = new Menu("Versions And Spaces");
            Menu showDateTimeMenu = new Menu("Show Date or Time");
            ShowDate showDate = new ShowDate("Show Time");
            ShowTime showTime = new ShowTime("Show Date");
            ShowVersion showVersion = new ShowVersion("Show Version");
            CountSpaces countSpaces = new CountSpaces("Count Spaces");

            m_MainMenu.Add(showDateTimeMenu);
            m_MainMenu.Add(versionsAndSpacesMenu);
            showDateTimeMenu.Add(showDate);
            showDateTimeMenu.Add(showTime);
            versionsAndSpacesMenu.Add(showVersion);
            versionsAndSpacesMenu.Add(countSpaces);

            try
            {
                m_MainMenu.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
