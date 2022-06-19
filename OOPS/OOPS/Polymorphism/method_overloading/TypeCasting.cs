using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism.method_overloading
{
     class Parent
    {
        public  void m1()
        {
            Console.WriteLine("me1");
        }
    }
    class child : Parent
    {
        public  void m1()
        {
            Console.WriteLine("child m1");
        }
        public void m2()
        {
            Console.WriteLine("Child m2");
        }
    }

    internal class TypeCasting
    {
        public static void test()
        {
            child  c=new child();
            c.m1(); 
            c.m2();
            ((Parent)c).m1();
        }
    }
}
