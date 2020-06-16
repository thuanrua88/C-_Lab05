using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snipper9
{
    class Student
    {
        public virtual void PrintDetails()
        {
            string studentName = "nothing";
            string address = "nothing";
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Address: " + address);
        }
    }
    class Grade : Student
    {
        string cls = "Fo";
        float percent = 71.34f;

        public override void PrintDetails()
        {
            Console.WriteLine("Class: " + cls);
            Console.WriteLine("Percentage: " + percent);
        }
        static void Main(string[] args)
        {
            Student objStudent = new Student();
            Grade objGrade = new Grade();
            objStudent.PrintDetails();
            objGrade.PrintDetails();
            Console.Read();
        }
    }
}
