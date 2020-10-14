using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        public List<Dictionary<string, string>> menuList = new List<Dictionary<string, string>>();
        DateTime date = new DateTime();

        public Menu()
        {

        }

        public void Add(Dictionary<string, string> menuItem)
        {
            bool isDupe = false;

            foreach(Dictionary<string, string> item in menuList)
            {
                if(item["Name"] == menuItem["Name"])
                {
                    Console.WriteLine("Cannot add duplicate items.");
                    isDupe = true;
                }
            }

            if (!isDupe)
            {
                menuList.Add(menuItem);
                this.date = DateTime.Now;
            }
        }

        public List<Dictionary<string, string>> MenuList 
        {
            get {return menuList;}
        }
        
        public void PrintMenu()
        {
            foreach(Dictionary<string, string> item in menuList)
            {
                Console.WriteLine("*****");
                Console.WriteLine(item["Name"]);
                Console.WriteLine(item["Description"]);
                Console.WriteLine(item["Category"]);
                Console.WriteLine("$" + item["Price"]);
                Console.WriteLine(item["Is New"] == "Yes" ? "NEW!" : "");
                Console.WriteLine("*****");
            }
            Console.WriteLine("Updated " + date);
        }

        public void PrintMenuItem(string name)
        {
            foreach(Dictionary<string, string> item in menuList)
            {
                if (item["Name"] == name)
                {
                    Console.WriteLine("*****");
                    Console.WriteLine(item["Name"]);
                    Console.WriteLine(item["Description"]);
                    Console.WriteLine(item["Category"]);
                    Console.WriteLine("$" + item["Price"]);
                    Console.WriteLine(item["Is New"] == "Yes" ? "NEW!" : "");
                    Console.WriteLine("*****");
                    break;
                }
            }
            
        }

        public void RemoveItem(string name) 
        { 
            foreach(Dictionary<string, string> item in menuList)
            {
                if(item["Name"] == name)
                {
                    menuList.Remove(item);
                    break;
                }
            }
        }

    }
}
