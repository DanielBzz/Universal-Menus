using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ActivateItemDelegate();

    public class FinalItem : MenuItem
    {
        public event ActivateItemDelegate Active;

        public FinalItem(string i_Name) : base(i_Name)
        {
        }

        public void ActivateFinalItem()
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
