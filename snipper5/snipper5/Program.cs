using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper5
{
    class Employees
    {
        int empID = 1;
        string empName = "Duc Nhu";
        int age = 25;

        public void Display()
        {
            Console.WriteLine("Employe ID: " + empID);
            Console.WriteLine("Employee Name: " + empName);
        }
        class Department : Employees {
            int deptId = 501;
            string deptName = "Sales";
            new void Display()
            {
                base.Display();
                Console.WriteLine("Department ID: " + deptId);
                Console.WriteLine("Department Name: " + deptName);
            }
        }
        static void Main(string[] args)
        {
            Department obj = new Department();
            obj.Display();
            Console.Read();
        }
    }
}
