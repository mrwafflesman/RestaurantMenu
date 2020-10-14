using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<Dictionary<string, string>> menuList = new List<Dictionary<string, string>>();

        public Menu()
        {

        }

        public void Add(Dictionary<string, string> menuItem)
        {
            menuList.Add(menuItem);
        }

        public List<Dictionary<string, string>> MenuList 
        {
            get {return menuList;}
        }
        
    }
}
