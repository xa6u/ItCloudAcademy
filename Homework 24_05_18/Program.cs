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
            //Exersise 4.5
            //double lowerPrice = 14.56;
            //double higherPrice = 20;
            //double newPrice;
            //Console.WriteLine("What the new price for the good?");
            //newPrice = double.Parse(Console.ReadLine());

            //"Serial if" realisation
            //if (newPrice > higherPrice )
            //{
            //    Console.WriteLine($"New price is bigger that can be allowed. Our biggest price is {higherPrice}");
            //}
            //if (newPrice<lowerPrice)
            //{
            //    Console.WriteLine($"New price is smaller that we can affort. Our lower price is {lowerPrice}");
            //}

            //"Nested if" rewalisation
            //if (newPrice < higherPrice)
            //{
            //    if (newPrice < lowerPrice)
            //    {
            //        Console.WriteLine($"New price is smaller that we can affort. Our lower price is {lowerPrice}");
            //    }
                
            //}
            //else
            //{
            //    Console.WriteLine($"New price is bigger that can be allowed. Our biggest price is {higherPrice}");
            //}


            //Exerdide 4.6
            double numOne, numTwo;
            char ch;
            Console.WriteLine($"Enter number 1" );
            numOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            numTwo = double.TryParse(Console.ReadLine());
            Console.WriteLine("Chose the arithmetic operation for this numbers (+,-,*,/,%)");
            ch = Convert.ToChar(Console.ReadLine()[0]);


            //"IF" realisation
            //if (ch == '+')
            //{
            //    Console.WriteLine($"The summ of your numbers is {numOne + numTwo}");
            //}
            //if (ch == '-')
            //{
            //    Console.WriteLine($"The difference of your numbers is {numOne - numTwo}");
            //}
            //if (ch == '*')
            //{
            //    Console.WriteLine($"The product of your numbers is {numOne * numTwo}");
            //}
            //if (ch == '/')
            //{
            //    Console.WriteLine($"The quotient of your numbers is {numOne / numTwo}");
            //}
            //if (ch == '%')
            //{
            //    Console.WriteLine($"The remainder of your numbers is {numOne % numTwo}");
            //}
            //if(ch!='+' && ch!='-' && ch!='*' && ch!='/' && ch!='%')
            //{
            //    Console.WriteLine("This is not a arithmetic operation!");
            //}

            //"switch" realisation
            switch(ch)
            {
                case '+': Console.WriteLine($"The summ of your numbers is {numOne + numTwo}");break;
                case '-': Console.WriteLine($"The difference of your numbers is {numOne - numTwo}");break;
                case '*': Console.WriteLine($"The product of your numbers is {numOne * numTwo}");break;
                case '/': Console.WriteLine($"The quotient of your numbers is {numOne / numTwo}");break;
                case '%': Console.WriteLine($"The remainder of your numbers is {numOne % numTwo}");break;
                default : Console.WriteLine("This is not a arithmetic operation!");break;
            }






        }
    }
}
