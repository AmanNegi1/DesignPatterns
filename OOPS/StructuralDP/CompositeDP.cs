using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    interface Department
    {
        void printDepartmentName();
    }
    class FinancialDepartment : Department
    {

        private int id;
        private string name;

        public void printDepartmentName()
        {
            
            Console.WriteLine(this.GetType());
        }

        public FinancialDepartment(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this .id = id;  
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    // standard constructor, getters, setters
    }
    class SalesDepartment : Department
    {

        private int id;
        private String name;

        public void printDepartmentName()
        {
                Console.WriteLine(this.GetType());
        }
        public SalesDepartment(int id,string name)
            {
            this.id = id;
            this.name=name;
            }
        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        // standard constructor, getters, setters
    }
    class HeadDepartment : Department
    {
    private int id;
    private string name;
    
    private List<Department> childDepartments;

    public HeadDepartment(int id, string name)
    {
        this.id = id;
        this.name = name;
        this.childDepartments = new List<Department>();
    }

    public void printDepartmentName()
    {
        foreach(Department department in childDepartments)
            {
                department.printDepartmentName();
            }
    }

    public void addDepartment(Department department)
    {
        childDepartments.Add(department);
    }

    public void removeDepartment(Department department)
    {
        childDepartments.Remove(department);
    }
}

internal class CompositeDP
    {
        public static void test()
        {
            Department salesDepartment = new SalesDepartment(1, "Sales department");
            Department financialDepartment = new FinancialDepartment(2, "Financial department");
            HeadDepartment headDepartment = new HeadDepartment(
          3, "Head department");

            headDepartment.addDepartment(salesDepartment);
            headDepartment.addDepartment(financialDepartment);

            headDepartment.printDepartmentName();
        }
    }
}
