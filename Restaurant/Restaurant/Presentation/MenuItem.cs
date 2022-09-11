using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Restaurant.Presentation.DelegateModel;

namespace Restaurant.Presentation
{
    public  class MenuItem
        {
            public MenuCallback mc;
            public string text;

            public MenuItem(string Text, MenuCallback Mc)
            {
                mc = Mc;
                text = Text;
            }
        }
    
}
