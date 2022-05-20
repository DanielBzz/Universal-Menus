using System;

namespace Ex04.Menus.Delegates
{
    public delegate void ActivateItemDelegate();

    public class MethodItem : MenuItem
    {
        public event ActivateItemDelegate Active;

        public MethodItem(string i_Name) : base(i_Name)
        {
        }

        public void ActivateMethodItem()
        {
            OnActive();
        }

        protected virtual void OnActive()
        {
            if (Active != null)
            {
                Active.Invoke();
            }
            else
            {
                throw new ArgumentNullException("No Method to invoke");
            }
        }
    }
}
