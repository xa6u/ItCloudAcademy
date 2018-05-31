using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_31_05_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hometask from 29
            //int radius = 10;
            //for (int i = -radius; i <= radius; i++)
            //{
            //    double yTop = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(i, 2));
            //    yTop /= 2;
            //    double yBottom = -yTop;
            //    Console.SetCursorPosition((int)i + radius, (int)Math.Round(yTop) + radius);
            //    Console.Write("*");
            //    Console.SetCursorPosition((int)i + radius, (int)Math.Round(yBottom) + radius);
            //    Console.Write("*");
            //}

            //Console.CursorVisible =false;

            //ConsoleKeyInfo keyInfo;
            //int left = 0, top = radius/2;
            //int previousLeft = left, previousTop = top;
            //do
            //{
            //    keyInfo = Console.ReadKey();
            //    switch (keyInfo.Key)
            //    {
            //        case ConsoleKey.W:
            //            top--;
            //            break;
            //        case ConsoleKey.S:
            //            top++;
            //            break;
            //        case ConsoleKey.D:
            //            left++;
            //            break;
            //        case ConsoleKey.A:
            //            left--;
            //            break;

            //        default:
            //            break;
            //    }
            //    Console.MoveBufferArea(previousLeft, previousTop, 2*radius+1, radius, left, top);
            //    previousTop = top;
            //    previousLeft = left;

            //} while (keyInfo.Key != ConsoleKey.Backspace);

            //Arrays
                     
            //reverse arrays
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] b = new int[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                b[a.Length - i-1] = a[i];
            }

            foreach (int item in b)
            {
                Console.Write($"{item},");
            }

            //triangle of Pascale

            int dimension = 15;
            int[][] array = new int[dimension][];
            for (int i = 0; i < dimension; i++)
            {
                array[i] = new int[i];
                for (int j = 0; j < array[i].Length; j++)
                {
                    int leftIndex= j - 1, rightIndex=j;
                    int prevCol = i - 1;
                    //доделать треугольник паскаля

                    array[i][j] = 1;
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
            


        }
    }
}
