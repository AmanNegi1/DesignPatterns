using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    interface ITarget
    {
         void ProcessSalary(List<Employee> emps);
    }
    class ThirdPartyPrinter
    {
        public void processEmployees(List<string> emps)
        {
            foreach (string emp in emps)
            {
                Console.WriteLine(emp);
            }
        }
    }
     class EmployeeAdapter : ITarget
    {
        ThirdPartyPrinter thirdPartyObject=new ThirdPartyPrinter();
        public void ProcessSalary(List<Employee> emps)
        {
            List<string> strEmps= new List<string>();
            int i = 0;
            foreach(Employee emp in emps)
            {
                string str = emp.Id + " : " + emp.Name;
                strEmps.Add(str);
            }
            thirdPartyObject.processEmployees(strEmps);
        }
    }
    internal class AdapterDP
    {
        public static void test()
        {
            EmployeeAdapter dp = new EmployeeAdapter();
            Employee emp1 = new Employee(1, "ram");
            Employee emp2 = new Employee(2, "Syam");
            Employee emp3 = new Employee(3, "Radha");
            List<Employee> emps = new List<Employee>();
            emps.Add(emp1);
            emps.Add(emp2);
            emps.Add(emp3);
            dp.ProcessSalary(emps);
        }
    }
}
