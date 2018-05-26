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

            //int[] arrayOfInt = { 1, 2, 10, 23 };

            //foreach(int i in arrayOfInt)
            //{
            //    Console.WriteLine(i);
            //}

            //somthing about IF statement
            //int a = 1;
            //if (a > 0)
            //{
            //    Console.WriteLine("a>0");
            //}
            //else
            //{
            //    Console.WriteLine("a<=0");
            //}

            ////or

            //string s = a > 0 ? "a>0":"a<=0";
            //Console.WriteLine(s);

            //something about bits

            //for(int i=0; i<8;i++)
            //{
            //    int result = 1 << i;
            //    Console.WriteLine(result);
            //}

            //5.1 exersise
            //for(int i=0;i<100;i++)
            //{
            //    Console.Write("a");
            //}
            //for(int i=0;i<100;i++)
            //{
            //    Console.WriteLine("a");
            //}

            //5.2 exersise
            //for(int i=0;i<=255;i++)
            //{
            //    Console.Write("{0} ", i);
            //}
            //Console.WriteLine();
            //for(int i=255;i>=0;i--)
            //{
            //    Console.Write("{0} ", i);
            //}

            //5.3 exersise
            int a, b;
            int result;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                result = a - b;
            }
            else
            {
                result = b - a;
            }

            //Or
            int maxValue, minValue;
            maxValue = a > b ? a : b;
            minValue = a < b ? a : b;

            for(int i=result;i>0;i--)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
