using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork14_06_18
{
    class Program
    {
        //Exersise 10.5
        /// <summary>
        /// Prints a max value of 2 numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void Maxvalue(float number1, float number2)
        {
            float maxvalue = number1;
            if (number2 > number1)
                maxvalue = number2;
            Console.WriteLine($"Max number is {maxvalue}");
        }
        /// <summary>
        /// Prints a min value of 2 numbers
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        static void Minvalue(float number1, float number2)
        {
            float maxvalue = number1;
            if (number2 < number1)
                maxvalue = number2;
            Console.WriteLine($"Min number is {maxvalue}");
        }

        //Exersise 10.6
        /// <summary>
        /// Prints max number of array
        /// </summary>
        static void ArrayMax()
        {
            float[] arrayOfNumbers = { 12, 3, 5, 123, -4, 5.6F };

            float max = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] > max)
                {
                    max = arrayOfNumbers[i];
                }

            }
            Console.WriteLine($"The max number from the array is {max}");
        }
        /// <summary>
        /// Prints min number of array
        /// </summary>
        static void ArrayMin()
        {
            float[] arrayOfNumbers = { 12, 3, 5, 123, -4, 5.6F };

            float min = arrayOfNumbers[0];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] < min)
                {
                    min = arrayOfNumbers[i];
                }

            }
            Console.WriteLine($"The min number from the array is {min}");
        }

        //exersise 10.7
        /// <summary>
        /// Display the summ of all numbers from 1 to N
        /// </summary>
        static void SummOfSeveralNumbers()
        {
            Console.WriteLine("Enter the number, and you wil see the summ of all it numbers from 1 ");
            int n = int.Parse(Console.ReadLine());
            int summ = 0;
            for (int i = 0; i <= n; i++)
            {
                summ = summ + i;
            }

            Console.WriteLine(summ);
        }

        /// <summary>
        /// Display the summ of all numbers from 1 to N (Recursion style)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int SummOfSeveralNumbersRecursion(int n)
        {
            //Console.WriteLine("Enter the number, and you wil see the summ of all it numbers from 1 ");
            if (n == 0) return n;
            return n + SummOfSeveralNumbersRecursion(n - 1);

           
        }


        static void Main(string[] args)
        {

            //for ex.10.5
            //float number1,number2;
            //Console.WriteLine("Enter first number");
            //number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //number2 = int.Parse(Console.ReadLine());


            //Maxvalue(number1, number2);
            //Minvalue(number1, number2);

            //for ex.10.6
            //ArrayMax();
            //ArrayMin();

            //for ex.10.7
            //SummOfSeveralNumbers();

            //for ex.10.8
            Console.WriteLine("Enter any positive number and find out summ of its numbers from 1 to N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The summ of all numbers from 1 to {n} = {SummOfSeveralNumbersRecursion(n)}");


        }
    }
}
