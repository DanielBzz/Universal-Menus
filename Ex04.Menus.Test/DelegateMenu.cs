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
            ShowDate date = new ShowDate();
            date.Execute();
        }

        private void showTime_Chosen()
        {
            ShowTime time = new ShowTime();
            time.Execute();
        }

        private void showVersion_Chosen()
        {
            ShowVersion version = new ShowVersion();
            version.Execute();
        }

        private void countSpaces_Chosen()
        {
            CountSpaces counter = new CountSpaces();
            counter.Execute();
        }
    }
}
