using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.Fly();
            eagle.Speed();

            Console.ReadLine();
        }
    }

    abstract class Animal
    {
        public abstract void Eat(); 
    }
    abstract class Fish : Animal
    {
        public abstract void Swim();
    }
    abstract class Bird : Animal
    {
        public abstract void Fly();
        public virtual void Speed() {
            Console.WriteLine("My speed 150km/hours");
        }
    }
    class Eagle : Bird
    {
        public override void Eat() {
            Console.WriteLine("They are ea");
        }
        public override void Fly()
        {
            Console.WriteLine("Eagles very speedly");
        }
        public override void Speed()
        {
            Console.WriteLine("Eagles fly 220km/hours");
        }
    }
    class Shark : Fish
    {
        public override void Swim()
        {
            Console.WriteLine("Sharkes good seingers");
        }
        public override void Eat()
        {
            Console.WriteLine("Sharks eating fishes");
        }
    }

}
