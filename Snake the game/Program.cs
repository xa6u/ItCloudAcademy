using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_the_game
{
    class Snake
    {
        public void SnakeHeadMove()
        {

        }
        public void SnakeSegmentMove()
        {

        }
        public void SnakeGrove()
        {

        }
    }

    class Player
    {
        public static int PlayerScore(int score)
        {
            
           return score;
        }
    }

    class Rabbit
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var topBorder = 0;
            var lowBorder = 0;
            //var leftBorder = 0;
            var rightBorder = 0;
            int consoleWidth = 100;
            int consoleHeights = 80;

            Console.SetWindowSize(consoleWidth, consoleHeights);
            Console.WriteLine("The size is 200x200");
            for (int i = 0; i < consoleWidth; i++)
            {
                Console.SetCursorPosition(topBorder, 0);
                Console.Write("*");
                topBorder++;                
            }

            for (int i = 0; i < consoleWidth; i++)
            {
                Console.SetCursorPosition(lowBorder, 80);
                Console.Write("*");
                lowBorder++;
            }


            for (int i = 0; i < consoleHeights; i++)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("*");
                lowBorder++;
            }

            for (int i = 0; i < consoleHeights; i++)
            {
                Console.SetCursorPosition(consoleWidth, rightBorder);
                Console.WriteLine("*");
                rightBorder++;
            }

            Console.ReadLine();
        }
    }
}
