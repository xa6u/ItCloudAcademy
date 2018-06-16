using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork16_06_18
{
    class Program
    {




        //static int ReadIndent()
        //{
        //    string str;
        //    int result;
        //    bool parseResult;
        //    do
        //    {
        //        str = Console.ReadLine();
        //        parseResult = int.TryParse(str, out result);
        //        if (!parseResult)
        //        {
        //            Console.WriteLine("give me int value");
        //        }

        //    } while (!parseResult);
        //    return result;

        //}
        //static void AddIndent(int n)
        //{
        //    string formatPattern = $"{{0,{n}}}";
        //    Console.WriteLine(formatPattern, "*");
        //}



        public class Product
        {
            public int Data;
            public string Name;

            public Product(int data, string name)
            {
                Data = data;
                Name = name;
            }
        }


        public static void ChangeReference(Product item)
        {
            //item.Name = "Product new name";
            item = new Product( 2, "New Name");
        }

        //11.1
        public struct Rectangle
        {
            public int X1;
            public int X2;
            public int Y1;
            public int Y2;

            public void Draw()
            {
                Console.SetCursorPosition(X1, Y1);
                for (int i = 0; i < X2-X1 ; i++)
                {
                    //Console.Write($"{{0,{X1}}}", "*");
                    Console.Write("*");
                }
                
                for (int i = 0; i < Y2 - Y1; i++)
                {
                    Console.SetCursorPosition(X1, Y1+i);
                    //Console.Write($"{{0,{X1}}}", "*");
                    Console.Write("*");
                    Console.SetCursorPosition(X2, Y1 + i);
                    Console.Write("*");
                }

                Console.SetCursorPosition(X1, Y2);
                for (int i = 0; i < X2-X1; i++)
                {
                    Console.Write("*");
                }

            }

            public Rectangle(int x1,int y1, int x2, int y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
            }
        }

        //11.2
        static void Fill(int x1,int y1, int x2, int y2)
        {
            if((x1>=x2)||(y1>=y2))
            {
                return;
            }
            Rectangle rect = new Rectangle(x1, y1, x2, y2);
            rect.Draw();
            Fill(x1 + 1, y1 + 1, x2 - 1, y2 - 1);
        }

        static void Main(string[] args)
        {
            //int indent = ReadIndent();
            //AddIndent(indent);
            //Product product = new Product(1, "ProductName");
            //Console.WriteLine(product.Name);
            //ChangeReference(product);
            //Console.WriteLine(product.Name);
            //Console.WriteLine("Input x1:");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input y1:");
            //int y1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input x2:");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Input y2:");
            //int y2 = int.Parse(Console.ReadLine());

            //Rectangle rect = new Rectangle(x1, y1,x2,y2);
            //rect.Draw();

            Fill(0, 0, Console.BufferWidth-1, Console.BufferHeight - 1);
            Console.SetCursorPosition(Console.BufferWidth - 1, Console.BufferHeight - 1);

        }

    }
}
