using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        Dictionary<string, string> menuItem = new Dictionary<string, string>();
        private string name;
        private string price;
        private string description;
        private string category;
        private string isNew;

        public MenuItem(string name, string price, string description, string category, string isNew)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.category = category;
            this.isNew = isNew;
        }

        public string IsNew
        {
            get { return isNew; }
            set { isNew = value; }
        }

        public Dictionary<string, string> AddMenuItem()
        {
            menuItem.Add("Name", this.name);
            menuItem.Add("Price", this.price);
            menuItem.Add("Description", this.description);
            menuItem.Add("Category", this.category);
            menuItem.Add("Is New", this.isNew);

            return menuItem;
        }

    }
}
