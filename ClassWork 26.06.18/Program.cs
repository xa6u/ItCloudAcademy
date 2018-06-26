using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_26._06._18
{
    class Vehicle
    {
        private int _numberOfWheels;
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set
            {
                if (value < 1)
                {
                    throw new Exception("Number of wheels should be more than 0");
                }
                _numberOfWheels = value;
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{ GetType().Name},Number of wheels : {NumberOfWheels}");
        }


    }
    class Bike:Vehicle
    {
        public int TopSpeed = 200;
        public override void PrintInfo()
        {
            Console.WriteLine($" {GetType().Name},Max Speed is: {TopSpeed}");
            base.PrintInfo();
        }

        public Bike()
        {
            NumberOfWheels = 2;
        }

    }

    class Car : Vehicle
    {
        public int NumberOfDoors = 5;
        public override void PrintInfo()
        {
            Console.WriteLine($" {GetType().Name},Number of doors is: {NumberOfDoors}");
            base.PrintInfo();
        }

        public Car()
        {
            NumberOfWheels = 4;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> list = new List<Vehicle>();
            Vehicle v = new Car();
            
            try
            {
                v.NumberOfWheels = 0;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                v.NumberOfWheels = 1;
            }
            Console.WriteLine(v.NumberOfWheels);

            //list.Add(new Bike());
            //list.Add(new Car());

            //foreach (Vehicle item in list)
            //{
            //    item.PrintInfo();
            //}

        }
    }
}
