﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper2
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eats something");
        }
        public void Dosomethig()
        {
            Console.WriteLine("Every animal does something");
        }
    }
    class Cat : Animal
    {
        static void main(string[] args)
        {
            Cat obj = new Cat();
            obj.Eat();
            Console.Read();
        }
    }
}
