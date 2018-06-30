using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkk_30._06._18
{

    class ArrayRandom
    {
        private int[] _array;

        public int MaxElementValue
        {
            get
            {
                int maxVal = _array.Max();
                return maxVal;

            }
        }

        public int MinElementValue
        {
            get
            {
                int minVal = _array.Min();
                return minVal;
            }
        }                 
        
        public ArrayRandom()
        {
            var randome = new Random();

            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = randome.Next(10, 100);
            }
            _array = array;
        }

        public void DisplayArray()
        {
            foreach (var item in _array)
            {
                Console.WriteLine(item);
            }
            
        }
    
    }

    class Calculator
    {
        private int _someInt;
    

        public Calculator(int value)
         {
            _someInt = value;
         }
        
        
        public int Add(int addInt)
        {
            int summ;
            summ = _someInt + addInt;
            return summ;
        }

        public int Inc(int incInt)
        {
            int inc;
            inc = ++incInt ;
            return inc;

        }
    }

    class HumenClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public HumenClass(string name)
        {
            Name = name;
        }
    }

    struct HumenStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public HumenStruct(string name)
        {
            Name = name;
            Age = -1;
        }
    }
    
    class IntegerContainer
    {
        private int[] _array = { 12, 143, 54, 76, 2, 4, 6, 8, 90, 67 };

        public decimal MIddleArythmetic
        {
            get
            {
                int totalSum = 0;
                foreach (int item in _array)
                {
                    totalSum += item;
                }
                return (decimal)totalSum / _array.Length;
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var a = new IntegerContainer();

            //Console.WriteLine($"A = {a.MIddleArythmetic}");

            //HumenClass humenClass = new HumenClass("Victor");
            //HumenStruct humenStruct = new HumenStruct();
            //Console.WriteLine(humenClass);
            //Console.WriteLine(humenStruct);
            //Console.WriteLine();

            //Calculator calc = new Calculator(25);
            //Console.WriteLine(calc.Add(10));
            //Console.WriteLine(calc.Inc(10));




        }
    }
}
