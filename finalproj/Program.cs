using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproj
{
    interface IDefender
    {
        void Defender();
        void Hide();        
    }
    interface IAirDefender : IDefender
    {

    }
    interface IGroundDefender : IDefender
    {

    }

    public class MilitaryUnit
    {
        string Name{get;set;}

        public void Attack()
        {
            Console.WriteLine("I shoot in all that i can see, sir!!!");
        }
    }
    class TechnicalUnit : MilitaryUnit
    {
        string Mark { get; set; }
        public void VehicleAttack()
        {
            Console.WriteLine("Lock the target!Fire!");
        }
    }
    class Airplain : TechnicalUnit, IAirDefender
    {
        public void Defender()
        {
            Console.WriteLine("I will fly like a baterfly, and bite like a bee my base to the last fuel drop!");
        }

        public void Hide()
        {
            Console.WriteLine("Next time, bastards. I will go to the air");
        }
    }
    class Cannon: TechnicalUnit
    {

    }
    class Tank : TechnicalUnit
    {

    }
    class Soldier : MilitaryUnit, IAirDefender, IGroundDefender
    {
        public void Defender()
        {
            Console.WriteLine("Defend my base to the last blood drop!");
        }

        public void Hide()
        {
            Console.WriteLine("Next time, bastards");
        }
    }


    class MilitaryBase
    {
        public void AirAttack()
        {

        }

        public void GroundAttack()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier = new Soldier();
            soldier.Attack();

        }
    }
}
