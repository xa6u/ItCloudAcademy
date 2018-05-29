using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork29_05_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.2 exerise
            //int number = int.Parse(Console.ReadLine());
            //int varLenght = sizeof(int) * 8;
            //for (int i = 0; i < varLenght; i++)
            //{
            //    int pattern = 1 << i;
            //    int result = number & pattern;
            //    string stringResultresult=result > 0 ? "1" : "0";

            //    Console.SetCursorPosition(varLenght - i, Console.CursorTop);
            //    Console.Write(stringResultresult);
            //}
            //Console.WriteLine();


            //6.3 exersise
            //int left = 10, top = 10;
            //ConsoleKeyInfo key;

            //do
            //{
            //    key = Console.ReadKey(true);
            //    switch (key.Key)
            //    {
            //        case ConsoleKey.RightArrow:
            //           left++;
            //            break;

            //        case ConsoleKey.LeftArrow:
            //            left--;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            top--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            top++;
            //            break;
            //        case ConsoleKey.O:
            //            Console.ForegroundColor = ConsoleColor.DarkRed;
            //            break;
            //        case ConsoleKey.D:
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            break;
            //        case ConsoleKey.S:
            //            Console.BackgroundColor = ConsoleColor.White;
            //            break;
            //        default:
            //            break;
            //    }
            //    Console.SetCursorPosition(left, top);
            //    Console.Write("*");

            //} while (key.Key != ConsoleKey.Backspace);

            //6.4 exersize
            //Console.CursorVisible = false;
            //Console.BackgroundColor = ConsoleColor.White;
            //for (double x = 0; x < 2*Math.PI; x+=0.1)
            //{
            //    double y = 10* Math.Sin(x);
            //    //Console.SetCursorPosition((int)x,(int)y);
            //    Console.SetCursorPosition((int)Math.Round(x*10),10 + (int)Math.Round(y));
            //    Console.Write("*");
            //}

            //6.1 exersise
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    
                    Console.WriteLine($"{i}*{j}={i*j}");

                }
                Console.WriteLine(" ");

                Console.MoveBufferArea();
                //нарисовать кружочек, и двигать влево-вправо
            }

        }
    }
}
