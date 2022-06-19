using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism.method_overloading
{
    class Animal { }
    class Monkey : Animal { }
    class Test
    {
        public void methodOne(Animal a)
        {
            Console.WriteLine("Animal version");
        }
        public void methodOne(Monkey m)
        {
            Console.WriteLine("Monkey version");
        }
        public static void testAnimal()
        {
            Test t = new Test();
            Animal a = new Animal();
            t.methodOne(a);//Animal version Monkey 
            a = new Monkey();
            t.methodOne(a);//Monkey version Animal 
            a = new Monkey();
            t.methodOne(a);//Animal version
        }
    }

    internal class MethodOverloading
    {
        public void methodOne(int i)
        {
            Console.WriteLine("Inside int method "+i);
        }
        public void methodOne(float f) //overloaded methods
        {
            Console.WriteLine("Inside float method "+f);
        }

        public void methodTwo(string str)
        {
            Console.WriteLine("Inside String method "+str);
        }
        public void methodTwo(Object obj)
        {
            Console.WriteLine("Inside Object Method "+obj.ToString());
        }

        public void methodThree(string str)
        {
            Console.WriteLine("Inside String method "+str);
        }
        public void methodThree(StringBuilder strBfr)
        {
            Console.WriteLine("Inside String Builder method "+strBfr);
        }



        public static void test()
        {
            new MethodOverloading().methodOne(20);
            new MethodOverloading().methodOne(2.2f);
            Console.WriteLine("String and object with methodTwo..");
            new MethodOverloading().methodTwo("aman");
            new MethodOverloading().methodTwo(new Object());
            new MethodOverloading().methodTwo(null);    
            MethodOverloading obj=new MethodOverloading();
            Console.WriteLine("String and String Builder");
            obj.methodThree("aman");
            obj.methodThree(new StringBuilder());
            Test.testAnimal();
        }
    }
}
