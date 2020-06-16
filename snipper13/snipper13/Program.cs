using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper13
{
    class Circle
    {
        protected const double PI = 3.14;
        protected double Radius = 14.9;
        public virtual double Area()
        {
            return PI * Radius * Radius;
        }
    }
    class Cone : Circle
    {
        protected double side = 10.2;
        public override double Area()
        {
            return PI * Radius * side;
        }


        static void Main(string[] args)
        {
            Circle obj = new Circle();
            Console.WriteLine("Areais: " + obj.Area());
            Circle obj2 = new Cone();
            Console.WriteLine("Areais: " + obj2.Area());
            Console.Read();
        }
    }
}
