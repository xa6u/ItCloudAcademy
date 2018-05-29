using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork26_05_18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 2.12(*)
Для данных чисел проверить значение бита.

n binary representation bit #3
5            00000000 00000101      0
0            00000000 00000000      0
15           00000000 00001111      1
5343         00010100 11011111      1
62241        11110011 00100001      0*/

            int i = 1 << 3;
            int[] arrayForVerif = { 5, 0, 15, 5343, 62241 };

            foreach (int j in arrayForVerif)
            {
                int result = j & i;
                Console.WriteLine(result);
            }


            /*Задача 5.8

      В банк на двадцатипроцентный вклад положили М гривен.

      Начисления происходят раз в год и добавляются к сумме вклада.

      Какой станет сумма вклада через N лет.   */

            Console.WriteLine("How much money you want to put in the bank?");
            decimal vklad = decimal.Parse(Console.ReadLine());
            int stavka = 20;
            Console.WriteLine("Our base is {0}", stavka);
            Console.WriteLine("How long you want to keep your money in bank? (in years)");
            int srok = int.Parse(Console.ReadLine());


            for (int i = 0; i < srok; i++)
            {
                vklad = vklad + ((vklad * stavka) / 100);

            }
            Console.WriteLine("Your money in the end {0}", vklad);

            /*Задача 5.9       

      Даны натуральные числа от 1 до 50.Напечатать те из них, которые делятся на 3, но не делятся на 5.*/

            int a = 0;
            int b = 0;
            for (int i =1; i<=50; i++ )
            {
                a = i % 3; b = i % 5;
                if (a==0&&b>0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
