using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMy
{
    class ItemStorage
    { 
        List<Item> storage;

        public IEnumerable<Item> GetAll()
        {
            return storage;
        }

        public ItemStorage()
        {
            #region Storage initialisation
            storage = new List<Item>
            {
                new Item {
                    ArticleNumber = "1.1",
                    Name = "Asus motherboard",
                    Price = 12345,
                    Category = Category.Hardware,
                    Quantity = 1 },

                new Item {
                    ArticleNumber = "1.2",
                    Name = "MSI Motherboard",
                    Price = 2345,
                    Category = Category.Hardware,
                    Quantity = 5},

                new Item {
                    ArticleNumber = "1.3",
                    Name = "HP Motherboad",
                    Price = 3456,
                    Category = Category.Hardware,
                    Quantity = 4 },

                new Item {
                    ArticleNumber = "2.1",
                    Name = "Intel CPU",
                    Price = 31234,
                    Category = Category.Hardware,
                    Quantity =  2},

                new Item {
                    ArticleNumber = "2.2",
                    Name = "AMD CPU",
                    Price = 2345,
                    Category = Category.Hardware,
                    Quantity = 5},

                new Item {
                    ArticleNumber = "2.3",
                    Name = "CPU",
                    Price = 2345,
                    Category = Category.Hardware,
                    Quantity = 8},

                new Item {
                    ArticleNumber = "10.1",
                    Name = "Logitech Keyboard",
                    Price = 123,
                    Category = Category.Peripheral,
                    Quantity = 10},

                new Item {
                    ArticleNumber = "10.2",
                    Name = "Apple Keyboard",
                    Price = 234,
                    Category = Category.Peripheral,
                    Quantity = 70},

                new Item {
                    ArticleNumber = "11.1",
                    Name = "Apple Mouse",
                    Price = 1234,
                    Category = Category.Peripheral,
                    Quantity = 10},

                new Item {
                    ArticleNumber = "11.2",
                    Name = "Logitech Keyboard",
                    Price = 3456,
                    Category = Category.Peripheral,
                    Quantity = 10},

                new Item {
                    ArticleNumber = "20.1",
                    Name = "Micrisoft Office",
                    Price = 12345,
                    Category = Category.Software,
                    Quantity = 12 },

                new Item {
                    ArticleNumber = "20.2",
                    Name = "Adobe Photoshop",
                    Price = 25689,
                    Category = Category.Software,
                    Quantity = 99},

                new Item {
                    ArticleNumber = "30.1",
                    Name = "Screw",
                    Price = 12,
                    Category = Category.Others,
                    Quantity = 28}
            };
            #endregion
        }

        public IEnumerable<Item> SortByPrice()
        {
            var query = from item in storage
                        orderby item.Price 
                        select item;

            return query;
        }

        public IEnumerable<Item> SortByName()
        {
            var query = from item in storage
                        orderby item.Name 
                        select item;

            return query;

        }

        public IEnumerable<Item> SortByPriceAndName()
        {
            var query = from Item in storage
                        orderby Item.Price, Item.Name ascending
                        select Item;
                        /*select new ShortSortByPriceAndName { Price = Item.Price, Name = Item.Name};*/

            return query;   
            
        }

        public IEnumerable<Item> SortByPriceAndGroupedByCategory()
        {
            //var query = (from Item in storage
            //            orderby Item.Price
            //            group storage by Item.Category
            //            into s
            //            select s).ToList();


            return storage.OrderBy(i => i.Price).GroupBy(i => i.Category).SelectMany(i => i);

            //return query;
        }


    }
}
