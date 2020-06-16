using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper3
{
    class Program
    {
       class Animal
        {
            protected string Food;
            protected string Activity;
        }
        class Lion : Animal
        {
            static void Main(string[] args)
            {
                Lion obj = new Lion();
                Console.Read();
            }
        }
    }
}
