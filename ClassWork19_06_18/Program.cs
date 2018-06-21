using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItCloud.Education.MathLibs;



namespace ClassWork19_06_18
{
    public struct Product
    {
        int ID;
        string NAME;
        decimal PRICE;

        public Product(int id,string name, decimal price)
        {
            ID = id;
            NAME = name;
            PRICE = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Book id: {ID}, Name = {NAME}, Price = {PRICE}");
        }

    }

    class Program
    {

        public static void Prodmaker(int numberOfProducts)
        {
           // int i = 0;
            int id;
            string name;
            decimal price;
            Console.WriteLine($"Enter {numberOfProducts} product id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {numberOfProducts} product name");
            name = Console.ReadLine();
            Console.WriteLine($"Enter {numberOfProducts} product price");
            price = int.Parse(Console.ReadLine());
        }

        public static void Sortbyprice(params object[] arrayOfProducts)
        {
            for (int i = 0; i < arrayOfProducts.Length; i++)
            {
                if (arrayOfProducts.[i] > arrayOfProducts[i+1])

                

            }
        }
        
        static void Main(string[] args)
        {

            //int val = 0;
            //int result = Incrementor.Inc(ref val);

            //int val1;
            //string str;
            //Incrementor.Intout(out val1,out str);
            //Console.WriteLine(val1);
            //Console.WriteLine(str);

            Product[] arrayOfProducts;
            Console.WriteLine("Enter number of products");
            int numberOfProducts = int.Parse(Console.ReadLine());
            arrayOfProducts = new Product[numberOfProducts];

            for (int i = 1; i <= numberOfProducts; i++)
            {
                Prodmaker(i);

            }
            
        }
    }
}
