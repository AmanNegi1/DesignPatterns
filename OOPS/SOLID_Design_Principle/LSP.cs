using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    //do not follow lsp
    class Apple1
    {
        public Apple1()
        {
            Console.WriteLine("Inside Apple1");
        }
        public virtual string getColor()
        {
            return "red";
        }
    }
    class Orange2:Apple1
    {
        public override string getColor()
        {
            return "Orange";
        }
    }


    //follows lsp..
    public abstract class Fruit
    {
        public abstract string getColor();
    }
    public class Apple : Fruit
    {
        public override string getColor()
        {
            return "red";
        }
    }
    public class Orange : Fruit
    {
        public override string getColor()
        {
            return "orange";
        }
    }
    internal class LSP
    {
        public static void test()
        {
            Apple1 app=new Orange2();
            Console.WriteLine(app.getColor());
            app = new Orange2();


            Fruit fruit = new Orange();
            Console.WriteLine(fruit.getColor());
            fruit = new Apple();
            Console.WriteLine(fruit.getColor());
        }
    }
}
