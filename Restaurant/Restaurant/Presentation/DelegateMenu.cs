using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static Restaurant.Presentation.DelegateModel;

namespace Restaurant.Presentation
{
    public class DelegateModel
    {
        public delegate void MenuCallback();
    }

    class DelegateMenu
    {
        private readonly List <MenuItem> m_Items = new List <MenuItem>();


        public void Add(string text, MenuCallback mc)
    	{
    		m_Items.Add(new MenuItem(text, mc));
    	} 
        public void Remove()
        {
            m_Items.Clear();
        }

        public void Show()
        {           
            for (int i = 0; i < m_Items.Count; i++)
            {
                Console.WriteLine(" [{0}] {1}", i + 1, m_Items[i].text);
            }
        }

        public void GetChoice()
        {            
            Console.Write(">");

            string input = Console.ReadLine();

            bool choice = Regex.IsMatch(input, @"^\d+$");

            if (choice)
            {
                int.TryParse(input, out int user_choice);

                if (user_choice > m_Items.Count || user_choice < 1)
                {
                    Console.WriteLine("Invalid option. Restart program");
                }
                else
                {
                    m_Items[user_choice - 1].mc.Invoke();
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Restart program");
            }            
        }

        public void RunStartMenu(MenuCallback mcb)
        {
            mcb.Invoke();
        }
    }
}
