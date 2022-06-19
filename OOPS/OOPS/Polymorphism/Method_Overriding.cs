using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Polymorphism
{
    /*
     Example 1: 
     */
    class Parent
    {
        public virtual Object methodOne()
        {
            return null;
        }
    }
    class Child : Parent
    {
        public override string methodOne()
        {
            return "child";
        }
    }
     /* 
      * Example 2
      */
     abstract class Parent2
    {
        public abstract void methodOne();
    }
    class Child2 : Parent2
    {
        public override void methodOne()
        {
            Console.WriteLine("Inside Child Class");
        }
    }

    /*
      Example 3 Exception Handling 
     */

    class Parent3
    {
        public virtual void methodOne()
        {
            try
            {

            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
    class Child3 : Parent3
    {
        public override void methodOne()
        {
            throw new Exception();
        }
    }
    /*
        Overriding with respect to static | Method Hiding
     */
    class p1
    {
        public  static void methodOne()
        {
            Console.WriteLine("Inside Parent Class");
        }
    }
    class p2 : p1
    {
        /*public void methodOne()
        {
            Console.WriteLine("Inside child method hiding");
            
            //Its Valid here but in PDF it is compile time err.
        }*/
        public static void methodOne()
        {
                //Method Hiding
                //valid
        }
    }
   class P3
    {
    public int x = 888;
    }
    class C3 :P3
    {
    public int x=999;
    }

internal class Method_Overriding
    {
        public static void test()
        {
            Parent p = new Child();
            Console.WriteLine(p.methodOne());
            Parent3 p3= new Child3(); 
            try
            {
                p3.methodOne();
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            P3 p4= new C3();//will print Based on Reference variable
            Console.WriteLine(p4.x+" ");
        }
    }

}
