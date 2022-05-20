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
            FinalItem showDate = new FinalItem("Show Time");
            FinalItem showTime = new FinalItem("Show Date");
            FinalItem showVersion = new FinalItem("Show Version");
            FinalItem countSpaces = new FinalItem("Count Spaces");

            r_MainMenu.Add(showDateTimeMenu);
            r_MainMenu.Add(versionsAndSpacesMenu);
            showDateTimeMenu.Add(showDate);
            showDateTimeMenu.Add(showTime);
            versionsAndSpacesMenu.Add(showVersion);
            versionsAndSpacesMenu.Add(countSpaces);
            showDate.Active += showDate_Chosen;
            showTime.Active += showTime_Chosen;
            showVersion.Active += showVersion_Chosen;
            countSpaces.Active += countSpaces_Chosen;

            try
            {
                r_MainMenu.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void showDate_Chosen()
        {
            Methods methods = new Methods();
            methods.ShowDate();
        }

        private void showTime_Chosen()
        {
            Methods methods = new Methods();
            methods.ShowTime();
        }

        private void showVersion_Chosen()
        {
            Methods methods = new Methods();
            methods.ShowVersion();
        }

        private void countSpaces_Chosen()
        {
            Methods methods = new Methods();
            methods.CountSpaces();
        }
    }
}
