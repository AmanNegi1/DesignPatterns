using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    interface add_calc
    {
        int add(int a, int b);
    }
    interface sub_calc
    {
        int sub(int x, int y);
    }
    interface mul_calc
    {
        int mul(int r, int s);
    }
    interface div_calc
    {
        int div(int c, int d);
    }
    internal class Multiple_Inheritance: add_calc,sub_calc,mul_calc,div_calc
    {
        public int result1;
        public int add(int a, int b)
        {
            return result1 = a + b;
        }
        public int result2;
        public int sub(int x, int y)
        {
            return result2 = x - y;
        }
        public int result3;
        public int mul(int r, int s)
        {
            return result3 = r * s;
        }
        public int result4;
        public int div(int c, int d)
        {
            return result4 = c / d;
        }
    }
    class TestCalculator
    {
        public static void test()
        {
            Multiple_Inheritance c = new Multiple_Inheritance();
            c.add(8, 2);
            c.sub(20, 10);
            c.mul(5, 2);
            c.div(20, 10);
            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
            Console.WriteLine("Addition: " + c.result1);
            Console.WriteLine("Substraction: " + c.result2);
            Console.WriteLine("Multiplication :" + c.result3);
            Console.WriteLine("Division: " + c.result4);
           // Console.ReadKey();
        }
    }
}
