using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor without parameters");
        }
    
        public Animal(string name)
        {
            Console.WriteLine("Animal constructor without parameters");
        }
    }
    class Canine : Animal
    {
        public Canine() : base("Lion")
        {
            Console.WriteLine("Derived Canine");
        }
    }
    class Details
    {
        static void Main(string[] args)
        {
            Canine obj = new Canine();
            Console.Read();
        }
    }
}
