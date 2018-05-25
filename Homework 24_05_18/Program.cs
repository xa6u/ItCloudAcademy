using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_24_05_18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 4.5
В программе определены два числа, определяющие нижний и верхний пороговые уровни на цену товара.
Ввести с клавиатуры новую цену товара.
Реализовать следующие условия: если цена поднялась выше верхнего значения, то сообщить об этом трейдеру, если цена опустилась ниже нежнего порога, то сообщить об этом трейдеру, в остальных случаях не осуществлять никаких действий.
Предложить два варианта(последовательный и вложенный if)*/
                double lowerPrice = 14.56;
            double higherPrice = 20;
            double newPrice;
            Console.WriteLine("What the new price for the good?");
            newPrice = double.Parse(Console.ReadLine());

            //"Serial if" realisation
            if (newPrice > higherPrice)
            {
                Console.WriteLine($"New price is bigger that can be allowed. Our biggest price is {higherPrice}");
            }
            if (newPrice < lowerPrice)
            {
                Console.WriteLine($"New price is smaller that we can affort. Our lower price is {lowerPrice}");
            }

            //"Nested if" rewalisation
            if (newPrice < higherPrice)
            {
                if (newPrice < lowerPrice)
                {
                    Console.WriteLine($"New price is smaller that we can affort. Our lower price is {lowerPrice}");
                }

            }
            else
            {
                Console.WriteLine($"New price is bigger that can be allowed. Our biggest price is {higherPrice}");
            }

            /*Задача 4.6

Написать программу – калькулятор.Пользователь вводит два числа и то действие, которое нужно совершить(+, -, *, /, %)
Вывести полученный результат на экран.
Реализовать два варианта(с оператором if и case)*/
            double numOne, numTwo;
            char ch;
            Console.WriteLine($"Enter number 1");
            numOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Chose the arithmetic operation for this numbers (+,-,*,/,%)");
            ch = Convert.ToChar(Console.ReadLine()[0]);


            //"IF" realisation
            if (ch == '+')
            {
                Console.WriteLine($"The summ of your numbers is {numOne + numTwo}");
            }
            if (ch == '-')
            {
                Console.WriteLine($"The difference of your numbers is {numOne - numTwo}");
            }
            if (ch == '*')
            {
                Console.WriteLine($"The product of your numbers is {numOne * numTwo}");
            }
            if (ch == '/')
            {
                Console.WriteLine($"The quotient of your numbers is {numOne / numTwo}");
            }
            if (ch == '%')
            {
                Console.WriteLine($"The remainder of your numbers is {numOne % numTwo}");
            }
            if (ch != '+' && ch != '-' && ch != '*' && ch != '/' && ch != '%')
            {
                Console.WriteLine("This is not a arithmetic operation!");
            }

            //"switch" realisation
            switch (ch)
            {
                case '+': Console.WriteLine($"The summ of your numbers is {numOne + numTwo}"); break;
                case '-': Console.WriteLine($"The difference of your numbers is {numOne - numTwo}"); break;
                case '*': Console.WriteLine($"The product of your numbers is {numOne * numTwo}"); break;
                case '/': Console.WriteLine($"The quotient of your numbers is {numOne / numTwo}"); break;
                case '%': Console.WriteLine($"The remainder of your numbers is {numOne % numTwo}"); break;
                default: Console.WriteLine("This is not a arithmetic operation!"); break;
            }

            /*Задача 4.7

Ввести с клавиатуры данные о трех машинах:
            (Название, максимальная скорость, количество литров на 100 км.)
Вывести на экран две таблицы сравнения:

по максимальной скорости
по количеству литров на 100 км.*/

            string car1, car2, car3;
            int velocity1, velocity2, velocity3;
            byte l1, l2, l3;
            Console.WriteLine("Enter first car name");
            car1 = Console.ReadLine();
            Console.WriteLine("Enter second car name");
            car2 = Console.ReadLine();
            Console.WriteLine("Enter third car name");
            car3 = Console.ReadLine();
            Console.WriteLine("Enter first car max speed");
            velocity1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second car max speed");
            velocity2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third car max speed");
            velocity3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first car L/100 km.");
            l1 =byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter second car L/100 km.");
            l2 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter third car L/100 km.");
            l3 = byte.Parse(Console.ReadLine());
            Console.WriteLine("From the fastest to the slowest");

            if (velocity1 > velocity2 && velocity2 > velocity3)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car1, car2, car3);
            }
            if (velocity1 > velocity3 && velocity3 > velocity2)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car1, car3, car2);
            }
            if (velocity2 > velocity1 && velocity1 > velocity3)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car2, car1, car3);
            }
            if (velocity2 > velocity3 && velocity3 > velocity1)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car2, car3, car1);
            }
            if (velocity3 > velocity1 && velocity1 > velocity2)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car3, car1, car2);
            }
            if (velocity3 > velocity2 && velocity2 > velocity1)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car3, car2, car1);
            }

            
            Console.WriteLine("From the maximum appetite to the maximum economy");


            if (l1 > l2 && l2 > l3)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car1, car2, car3);
            }
            if (l1 > l3 && l3 > l2)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car1, car3, car2);
            }
            if (l2 > l1 && l1 > l3)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car2, car1, car3);
            }
            if (l2 > l3 && l3 > l1)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car2, car3, car1);
            }
            if (l3 > l1 && l1 > l2)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car3, car1, car2);
            }
            if (l3 > l2 && l2 > l1)
            {
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", car3, car2, car1);
            }

        }
    }
}
