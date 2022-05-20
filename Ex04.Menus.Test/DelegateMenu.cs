using System;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class DelegateMenu
    {
        private readonly MainMenu r_MainMenu = new MainMenu("Delegate Main MainMenu");

        public void Show()
        {
            MainMenu versionsAndSpacesMenu = new MainMenu("Versions And Spaces");
            MainMenu showDateTimeMenu = new MainMenu("Show Date or Time");
            MethodItem showDate = new MethodItem("Show Date");
            MethodItem showTime = new MethodItem("Show Time");
            MethodItem showVersion = new MethodItem("Show Version");
            MethodItem countSpaces = new MethodItem("Count Spaces");

            r_MainMenu.Add(showDateTimeMenu);
            r_MainMenu.Add(versionsAndSpacesMenu);
            showDateTimeMenu.Add(showDate);
            showDateTimeMenu.Add(showTime);
            versionsAndSpacesMenu.Add(showVersion);
            versionsAndSpacesMenu.Add(countSpaces);
            showDate.Active += showDate_Active;
            showTime.Active += showTime_Active;
            showVersion.Active += showVersion_Active;
            countSpaces.Active += countSpaces_Active;

            try
            {
                r_MainMenu.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void showDate_Active()
        {
            Methods methods = new Methods();
            methods.ShowDate();
        }

        private void showTime_Active()
        {
            Methods methods = new Methods();
            methods.ShowTime();
        }

        private void showVersion_Active()
        {
            Methods methods = new Methods();
            methods.ShowVersion();
        }

        private void countSpaces_Active()
        {
            Methods methods = new Methods();
            methods.CountSpaces();
        }
    }
}
