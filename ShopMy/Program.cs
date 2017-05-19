using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShopMy
{
    class Program
    {
        static void Main(string[] args)
        {
            //ItemStorage itemstorage = new ItemStorage();

           // Console.ReadKey();

            bool boolExit = false;

            do
            {
                Console.WriteLine("Please navigate through the menue by inputting the number \n(1, 2, 3, 0) of your choice"
                + "\n1. View the shops stock in sorted Lists"
                + "\n2. Search for produkts in shop"
                + "\n3. Remove Contact"
                + "\n0. Exit the application\n");

                string input = Console.ReadLine();//Console read from keybrd input
                char nav = input[0]; //Take first char in string and put it in  nav

                switch (nav)
                {
                    case '1':
                        
                        ListStock();
                        break;

                    case '2':
                        SearchStock();
                        break;

                    case '3':

                        break;

                    case '0':
                        return;

                    default:
                        Console.WriteLine("Please enter some valid input (1, 2, 3, 4, 0)");
                        break;
                }
            }
            while (!boolExit);

            Console.Clear();


        }



        #region Stock list
        public static void ListStock()
        {
            bool boolExit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Please navigate through the menue by inputting the number \n(1, 2, 3, 0) of your choice"
                + "\n1. Sort stock by name"
                + "\n2. Sort stock by price"
                + "\n3. Sort stoch by price and name"
                + "\n4. Sort stock by price grouped on category"
                + "\n0. Exit the application\n");

                string input = Console.ReadLine();//Console read from keybrd input
                char nav = input[0]; //Take first charin string and put it in  nav
                //string value = input.Substring(1); //removes the first char in the string and then give it to value

                switch (nav)
                {
                    case '1':
                        
                        Logic.SortingByName();

                        break;

                    case '2':

                        Logic.SortingByPrice();

                        break;

                    case '3':
                        Logic.SortingByPriceAndName();
                        break;

                    case '4':
                        Logic.SortingByPriceAndGroupedByCategory();
                        break;

                    case '0':
                        return;

                    default:
                        Console.WriteLine("Please enter some valid input (1, 2, 3, 4, 0)");
                        break;
                }
            }
            while (!boolExit);

            Console.Clear();
        }
        #endregion

        #region Stock Search
        public static void SearchStock()
        {
            bool boolExit = false;

            do
            {
                Console.WriteLine("Please navigate through the menue by inputting the number \n(1, 2, 3, 0) of your choice"
                + "\n1. View the shops stock in sorted Lists"
                + "\n2. Search for produkts in shop"
                + "\n3. Remove Contact"
                + "\n0. Exit the application\n");

                string input = Console.ReadLine();//Console read from keybrd input
                char nav = input[0]; //Take first charin string and put it in  nav
                string value = input.Substring(1); //removes the first char in the string and then give it to value

                switch (nav)
                {
                    case '1':
                        
                        break;

                    case '2':
                        
                        break;

                    case '3':

                        break;

                    case '0':
                        return;

                    default:
                        Console.WriteLine("Please enter some valid input (1, 2, 3, 4, 0)");
                        break;
                }
            }
            while (!boolExit);

            Console.Clear();
        }
        #endregion
    }
}