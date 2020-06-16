using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper12
{
    class Area
    {
        static int Cal(int len, int wide)
        {
            return len * wide;
        }
        static double Cal(double valOne, double valTwo)
        {
            return valOne * valTwo;
        }
        static void Main(string[] args)
        {
            int length = 10;
            int breadth = 22;
            double tbase = 2.5;
            double theight = 1.5;
            Console.WriteLine("Area of Rectangle: " + Cal(length, breadth));
            Console.WriteLine("Area of Rectangle: " + Cal(tbase, theight));
            Console.Read();
        }
    }
}
