using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMy
{
    class Item //:IEquatable<T>,IComparable<Item>
    {
        public string ArticleNumber { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
    }

    public enum Category
    {
        Hardware,
        Software,
        software,
        Peripheral,
        Others
    }

    class ShortSortByPriceAndName
    {
        public int Price { get; set; }
        public string Name { get; set; }
    }

    class ShortSortByPriceAndCategory
    {
        public int Price { get; set; }
        public Category Category { get; set; }
    }


}

