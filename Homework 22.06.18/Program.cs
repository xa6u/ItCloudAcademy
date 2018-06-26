using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22._06._18
{    

    class Program
    {
        static void Main(string[] args)
        {
            int firstElement;
            int secondElement;
            int summ;
            string s1, s2;

            Random random = new Random();
            int[] intArray = new int[10];

            for (int i = 1; i < 10; i++)
            {
                int randomArrayValue = random.Next(1000);
                intArray[i] = randomArrayValue;
                Console.WriteLine(intArray[i]);
            }
            
            try
            {
                Console.WriteLine("Enter index of first element");
                s1 = Console.ReadLine();
                Console.WriteLine("Enter index of second element");
                s2 = Console.ReadLine();

                var a = int.TryParse(s1, out firstElement);
                var b = int.TryParse(s2, out secondElement);

                if (!a||!b)
                {
                    throw new FormatException("The element is not in the digit");
                }

                if (firstElement > intArray.Length || secondElement > intArray.Length || firstElement < intArray.Length || secondElement < intArray.Length)
                {
                    throw new IndexOutOfRangeException("The element is not in the array");
                }

                summ = intArray[firstElement] + intArray[secondElement];

                Console.WriteLine(summ);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
