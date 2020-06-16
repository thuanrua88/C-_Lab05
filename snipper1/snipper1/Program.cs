using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper1
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
    }

    class Cat : Animal
    {
        public void Color()
        {
            Console.WriteLine("Black");
        }
    }

    class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Shushi");
        }
    }

    class DogBlack : Dog
    {
        public void Old()
        {
            int a = 0;
            a++;
            Console.WriteLine("Old: " + a);
        }
    }
}
