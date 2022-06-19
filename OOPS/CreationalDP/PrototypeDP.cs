using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP
{
    public class Employee
    {
        public string name { get; set; }
        public string department { get; set; }
        public Employee getClone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
    internal class PrototypeDP
    {
        public static void test()
        {
            Employee emp = new Employee();
            emp.name = "Aman";
            emp.department = "cse";
            Employee emp2 = emp.getClone();
            emp2.name = "akhil";
            Console.WriteLine(emp.name + " " + emp2.name);
        }
    }
}
