using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper8
{
    class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        protected void DoSomething()
        {
            Console.WriteLine("Every animal does something");
        }
    }
    class Cat : Animal
    {
        static void Main(string[] args)
        {
            Cat obj = new Cat();
            obj.Eat();
            Console.Read();
        }
    }
}
