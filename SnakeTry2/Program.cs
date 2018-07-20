using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeTry2
{
    class Snake
    {
        public enum Direction
        {
            Up,
            Down,
            Right,
            Left,
        }

        public void DrawPlayground()
        {

            Console.SetWindowSize(40, 30);
            for (int i = 0; i < 40; ++i)
            {
                Console.Write('*');
            }
            for (int i = 0; i < 40; ++i)
            {
                Console.SetCursorPosition(40, i);
                Console.Write('*');
            }
            for (int i = 40; i >= 0; --i)
            {
                Console.SetCursorPosition(i, 40);
                Console.Write('*');
            }
            for (int i = 40; i >= 0; --i)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('*');
            }
        }
        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("*");
            Thread.Sleep(100);            
        }
        public void Draw()
        {
            int x = 10, y = 10;
            ConsoleKeyInfo key =new ConsoleKeyInfo();
            do
            {
               // key = new ConsoleKeyInfo();
                Console.CursorVisible = false;
                if (Console.KeyAvailable)
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.RightArrow:
                        //for (int i = 0; i < 10; i++)
                        //{
                        //    Print(x, y);
                        //    Thread.Sleep(100);
                        //    x++;
                        //}
                        do
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            x++;
                        } while (key.Key == ConsoleKey.UpArrow);
                        break;

                    case ConsoleKey.LeftArrow:
                        for (int i = 0; i < 10; i++)
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            x--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        for (int i = 0; i < 10; i++)
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        for (int i = 0; i < 10; i++)
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            y++;
                        }
                        break;
                    default:
                        break;

                }
            } while (key.Key != ConsoleKey.Backspace);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Snake snake = new Snake();
            snake.DrawPlayground();
            snake.Draw();

        }

    }
}
