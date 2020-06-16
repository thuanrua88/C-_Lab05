using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper11
{
    class IDSystem
    {
        public virtual void printf()
        {
            Console.WriteLine("The system should be handled carefull");
        }
    }
    class CompanySystem : IDSystem
    {
        public sealed override void printf()
        {
            Console.Write("The system information is confidentia");
            Console.WriteLine("This information should not be overridden");
        }
    }
    class SealedSystem : CompanySystem
    {
        public override void printf()
        {
            Console.WriteLine("This statement won't get extd");
        }
        static void Main(string[] args)
        {
            SealedSystem obj = new SealedSystem();
            obj.printf();
            
        }
    }
}
