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
                 Console.WriteLine("{0} {1} {2} {3} {4} {5}",  ,b.Price);
            }
            Console.ReadKey();
        }

        public static void SortingByName()
        {
            ItemStorage storage= new ItemStorage();

            foreach (Item b in storage.SortByName())
            {
                Console.WriteLine(b.Name);

            }
            Console.ReadKey();
        }
    }
}
