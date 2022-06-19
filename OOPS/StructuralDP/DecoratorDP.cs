using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    interface Pizza
    {
        string MakePizza();
    }
    class PlainPizza : Pizza
    {
        public string MakePizza()
        {
            return "Plain Pizza";
        }
    }
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public virtual string MakePizza()
        {
            return pizza.MakePizza();
        }
    }
    class ChickenPizzaDecorator : PizzaDecorator
    {
        public ChickenPizzaDecorator(Pizza pizza) : base(pizza)
        {
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddChicken();
        }
        private string AddChicken()
        {
            return ", Chicken added";
        }
    }
    class VegPizzaDecorator : PizzaDecorator
    {
        public VegPizzaDecorator(Pizza pizza) : base(pizza)
        {
        }
        public override string MakePizza()
        {
            return pizza.MakePizza() + AddVegetables();
        }
        private string AddVegetables()
        {
            return ", Vegetables added";
        }
    }
    internal class DecoratorDP
    {
        public static void test()
        {
            PlainPizza plainPizzaObj = new PlainPizza();
            string plainPizza = plainPizzaObj.MakePizza();
            Console.WriteLine(plainPizza);
            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizzaObj);
            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");

        }
    }
}
