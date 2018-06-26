using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_23_06_18
{
    
    class Program
    {
        public static int Division()
        {
            int a, b;
            int res;


            Console.WriteLine("Enter first number");
            a= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                throw new ArgumentException("Do not divide by 0");
            }
            res = a / b;
            return res;
          //throw new DivideByZeroException("Do not divide by 0");
            
        }


        static void Main(string[] args)
        {
            int result=0;

            try
            {
                result = Division();
                Console.WriteLine(result);
            }
            catch (ArgumentException)
            {
                                
             Console.WriteLine("Do not divide on 0");
             
            }
        }
    }
}

