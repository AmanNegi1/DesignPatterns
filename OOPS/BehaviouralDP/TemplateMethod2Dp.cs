using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviouralDP
{
    abstract class CoffeeTemplate
    {
        // PrepareCoffee method is the template method
        public void PrepareCoffee()
        {
            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();
            Console.WriteLine(this.GetType().Name + " is Ready");
        }
        protected abstract void BoilWater();
        protected abstract void AddMilk();
        protected abstract void AddSugar();
        protected abstract void AddCoffeePowder();
    }
    class BruCoffee : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }
        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Bru Coffee Powder Added");
        }
    }

    class NescafeCoffee : CoffeeTemplate
    {
        protected override void BoilWater()
        {
            Console.WriteLine("Water Boild");
        }
        protected override void AddMilk()
        {
            Console.WriteLine("Milk Added");
        }
        protected override void AddSugar()
        {
            Console.WriteLine("Sugar Added");
        }
        protected override void AddCoffeePowder()
        {
            Console.WriteLine("Nescafe Coffee Powder Added");
        }
    }


    internal class TemplateMethod2Dp
    {
        public static void test()
        {
            Console.WriteLine("Nescafe Coffee Preparation\n");
            CoffeeTemplate coffee = new NescafeCoffee();
            coffee.PrepareCoffee();
            Console.WriteLine();
            Console.WriteLine("Bru coffee preparation\n");
            coffee = new BruCoffee();
            coffee.PrepareCoffee();
            Console.Read();
        }
    }
}
