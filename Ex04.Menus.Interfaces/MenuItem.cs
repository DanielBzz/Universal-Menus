namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        protected string m_Name;

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
