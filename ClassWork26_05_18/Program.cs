using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork26_05_18
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Endless loop
            //int i = 0;
            //while(i<10)
            //{
            //    Console.Write("a");
            //}

            ////Endless loop
            //int j = 0;
            //while (j < 10)
            //    Console.Write("a");
            //j = j + 1;

            //triangle
            //int n = int.Parse(Console.ReadLine());
            //for(int row=1;row<=n;row++)
            //{
            //    for (int column = 1; column<=row;column++) 
            //    {
            //        Console.Write("{0}", column);
            //    }
            //    Console.WriteLine();
            //}

            //Hello newer writes
            //for (int i = 0;i<10 ;i++ )
            //{
            //    if(i==3)
            //    goto BreakOut;
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Hello");
            //BreakOut: Console.WriteLine("BreakeOut");

            int[] arrayOfInt = { 1, 2, 10, 23 };

            foreach(int i in arrayOfInt)
            {
                Console.WriteLine(i);
            }


        }
    }
}
