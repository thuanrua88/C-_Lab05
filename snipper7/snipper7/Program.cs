using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper7
{
    class Metals
    {
        string metaltype;
        public Metals(string type)
        {
            metaltype = type;
            Console.WriteLine("Metal: \t\t" + metaltype);
        }
    }
    class SteelCompany : Metals
    {
        string grd;
        public SteelCompany(string grade) : base("Steel")
        {
            grd = grade;
            Console.WriteLine("Grade: \t\t" + grd);
        }
    }
    class Automobiles : SteelCompany
    {
        string part;
        public Automobiles(string part) : base("Cast iron")
        {
            part = part;
            Console.WriteLine("Part: \t\t" + part);
        }
        static void Main(string[] args)
        {
            Automobiles obj = new Automobiles("DN");
            Console.Read();
        }
    }
}
