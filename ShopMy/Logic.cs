using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMy
{
    class Logic
    {
        public static void SortingByPrice()
        {
            ItemStorage itemstorage = new ItemStorage();

            foreach (Item b in itemstorage.SortByPrice())
            {
                //Console.WriteLine(b.Price);
                 Console.WriteLine("{0} {1} {2} {3} {4}", b.ArticleNumber, b.Name , b.Price, b.Category, b.Quantity);
            }
            Console.ReadKey();
        }

        public static void SortingByName()
        {
            ItemStorage storage= new ItemStorage();

            foreach (Item b in storage.SortByName())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", b.ArticleNumber, b.Name, b.Price, b.Category, b.Quantity);
            }
            Console.ReadKey();
        }

        public static void SortingByPriceAndName()
        {
            ItemStorage storage = new ItemStorage();

            foreach (Item b in storage.SortByPriceAndName())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", b.Price, b.Name, b.ArticleNumber,  b.Category, b.Quantity);
            }
            Console.ReadKey();
        }

        public static void SortingByPriceAndGroupedByCategory()
        {
            ItemStorage storage = new ItemStorage();

            foreach (Item b in storage.SortByPriceAndGroupedByCategory())
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", b.Price, b.Category, b.Name, b.ArticleNumber, b.Quantity);
            }
            Console.ReadKey();
        }
    }
}
