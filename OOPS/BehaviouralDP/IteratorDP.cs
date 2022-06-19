using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
        interface AbstractIterator
        {
            Employee First();
            Employee Next();
            bool IsCompleted { get; }
        }
        class Iterator : AbstractIterator
        {
            private ConcreteCollection collection;
            private int current = 0;
            private int step = 1;
            // Constructor
            public Iterator(ConcreteCollection collection)
            {
                this.collection = collection;
            }
            // Gets first item
            public Employee First()
            {
                current = 0;
                return collection.GetEmployee(current);
            }
            // Gets next item
            public Employee Next()
            {
                current += step;
                if (!IsCompleted)
                {
                    return collection.GetEmployee(current);
                }
                else
                {
                    return null;
                }
            }
            // Check whether iteration is complete
            public bool IsCompleted
            {
                get { return current >= collection.Count; }
            }
        }
        interface AbstractCollection
        {
            Iterator CreateIterator();
        }
        class ConcreteCollection : AbstractCollection
        {
            private List<Employee> listEmployees = new List<Employee>();
            //Create Iterator
            public Iterator CreateIterator()
            {
                return new Iterator(this);
            }
            // Gets item count
            public int Count
            {
                get { return listEmployees.Count; }
            }
            //Add items to the collection
            public void AddEmployee(Employee employee)
            {
                listEmployees.Add(employee);
            }
            //Get item from collection
            public Employee GetEmployee(int IndexPosition)
            {
                return listEmployees[IndexPosition];
            }
        }

    internal class IteratorDP
    {
            public static void test()
            {
                ConcreteCollection collection = new ConcreteCollection();
                collection.AddEmployee(new Employee("Anurag", 100));
                collection.AddEmployee(new Employee("Pranaya", 101));
                collection.AddEmployee(new Employee("Santosh", 102));
                collection.AddEmployee(new Employee("Priyanka", 103));
                collection.AddEmployee(new Employee("Abinash", 104));
                collection.AddEmployee(new Employee("Preety", 105));

                // Create iterator
                Iterator iterator = collection.CreateIterator();
                //looping iterator      
                Console.WriteLine("Iterating over collection:");

                for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
                {
                    Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
                }
                Console.Read();
            }

    }
}
