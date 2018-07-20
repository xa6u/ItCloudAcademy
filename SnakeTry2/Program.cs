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
        static readonly int x = 80;
        static readonly int y = 26;

        public enum Direction
        {
            Up,
            Down,
            Right,
            Left,
        }

        public void DrawPlayground()
        {
            //Console.SetWindowSize(x + 1, y + 1);
            //Console.SetBufferSize(x + 1, y + 1);
            //Console.CursorVisible = false;

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

        //struct Coords
        //{
        //    public int x { get; set; }
        //    public int y { get; set; }
        //}
        //class PlaygroundWalls
        //{
        //    private char ch;
        //    private List<Coords> wall = new List<Coords>(); 
        //}
        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            List<int> length = new List<int>(); 
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
                        do
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            x++;
                        } while (key.Key == ConsoleKey.P);
                        break;

                    case ConsoleKey.LeftArrow:
                        do
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            x--;
                        } while (key.Key == ConsoleKey.P);
                        break;
                    case ConsoleKey.UpArrow:
                        do
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            y--;
                        } while (key.Key == ConsoleKey.P);
                        break;
                    case ConsoleKey.DownArrow:
                        do
                        {
                            Print(x, y);
                            Thread.Sleep(100);
                            y++;
                        } while (key.Key == ConsoleKey.P);
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
