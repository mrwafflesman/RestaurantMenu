using System;
using System.Collections.Generic;

namespace RestaurantMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            MenuItem hamburger = new MenuItem("Hamburger", "5", "A Hamburger", "Entree", "No");
            MenuItem chicken = new MenuItem("Chicken Tenders", "6", "Chicken Tenders", "Entree", "No");
            MenuItem fries = new MenuItem("French Fries", "2", "French Fries", "Side", "No");

            Menu menu = new Menu();
            menu.Add(hamburger.AddMenuItem());
            menu.Add(chicken.AddMenuItem());
            menu.Add(fries.AddMenuItem());
            
            while(true) 
            {
                Console.WriteLine("What would you like to do?\n0 - Add menu item\n1 - remove menu item\n2 - print menu item\n3 - print menu");
                input = int.Parse(Console.ReadLine());

                if(input == 0)
                {
                    string name;
                    string price;
                    string desc;
                    string category;

                    Console.WriteLine("Name of dish.");
                    name = Console.ReadLine();

                    Console.WriteLine("Dish price.");
                    price = Console.ReadLine();

                    Console.WriteLine("Description of dish.");
                    desc = Console.ReadLine();

                    Console.WriteLine("Dish category.");
                    category = Console.ReadLine();

                    MenuItem newItem = new MenuItem(name, price, desc, category, "Yes");

                    menu.Add(newItem.AddMenuItem());
                }
                else if(input == 1)
                {
                    string name;

                    Console.WriteLine("Enter the name of the item to be removed.");
                    name = Console.ReadLine();

                    menu.RemoveItem(name);
                }
                else if(input == 2)
                {
                    string name;

                    Console.WriteLine("Enter the name of the item:");
                    name = Console.ReadLine();

                    menu.PrintMenuItem(name);
                }
                else if(input == 3) 
                {
                    menu.PrintMenu();
                }
                else 
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            
        }
    }
}
