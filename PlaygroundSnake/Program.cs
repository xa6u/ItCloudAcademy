using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundSnake
{
    class Program
    {
        static readonly int x = 80;
        static readonly int y = 26;

        struct Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public char ch { get; set; }
        }
        
        class PlayField
        {
            private void VerticalEdge()
            {

            }
            private void HorEdge()
            {

            }
        }

        static void Main(string[] args)
        {
            List<int> length = new List<int>();
            Console.SetWindowSize(x + 1, y + 1);
            Console.SetBufferSize(x + 1, y + 1);
            Console.CursorVisible = false;
        }
    }
}
