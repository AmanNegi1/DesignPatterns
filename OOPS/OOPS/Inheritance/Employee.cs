using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

    }
    internal class Programmer : Employee
    {
        public float Bonus { get; set; }

    }
    class TestEmployee
    {
        public static void test() { 
            Programmer pgmr=new Programmer();
            pgmr.Bonus = 1000;
            pgmr.Name = "Aman Negi";
            pgmr.Salary = 50000;
            Console.WriteLine(pgmr.Id+" "+pgmr.Name+" "+pgmr.Bonus+" "+pgmr.Salary);
        }
    }
}
