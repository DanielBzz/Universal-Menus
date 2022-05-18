using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void ItemChosenDelegate();

    public class FinalItem : MenuItem
    {

        public event ItemChosenDelegate Chosen;

        public FinalItem(string i_Name) : base(i_Name)
        {
        }

        public void ActivateFinalItem()
        {
            OnChosen();
        }

        protected virtual void OnChosen()
        {
            if (Chosen != null)
            {
                Chosen.Invoke();
            }
            else
            {
                throw new ArgumentNullException("No Method to invoke");
            }
        }

    }
}
