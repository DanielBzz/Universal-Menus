namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_Name;

        public MenuItem(string i_Name)
        {
            m_Name = i_Name;
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }
    }
}