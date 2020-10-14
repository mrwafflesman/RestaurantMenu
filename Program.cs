using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input;

            MenuItem hamburger = new MenuItem("Hamburger", "5", "A Hamburger", "Entree", "No");
            MenuItem chicken = new MenuItem("Chicken Tenders", "6", "Chicken Tenders", "Entree", "No");
            MenuItem fries = new MenuItem("French Fries", "2", "French Fries", "Side", "No");

            Menu menu = new Menu();
            menu.Add(hamburger.AddMenuItem());
            menu.Add(chicken.AddMenuItem());
            menu.Add(fries.AddMenuItem());



            foreach(Dictionary<string, string> item in menu.MenuList)
            {
                Console.WriteLine(item["Name"]);
            }
            /*
            while(true) 
            {
                Console.WriteLine("What would you like to do?\n0 - Add menu item\n1 - remove menu item\n2 - print menu item\n3 - print menu");
                input = int.Parse(Console.ReadLine());

                if(input == 0) 
                {
                    MenuItem.AddMenuItem();
                }
                else if(input == 1)
                {
                    MenuItem.RemoveMenuItem();
                }
                else if(input == 2) 
                {
                    MenuItem.PrintMenuItem();
                }
                else if(input == 3) 
                {
                    Menu.PrintMenu();
                }
                else 
                {
                    Console.WriteLine("Invalid input.")
                }
            }
            */
        }
    }
}
