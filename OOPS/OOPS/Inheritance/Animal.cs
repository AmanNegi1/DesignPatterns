using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    internal class Animal
    {
        public void eat() { Console.WriteLine("Eating..."); }
    }
    internal class Dog : Animal
    {
        public void bark() { Console.WriteLine("Barking..."); }
    }
    
    internal class BabyDog : Dog
    {
        public void weep() { Console.WriteLine("Weeping..."); }
    }
    internal class TestAnimal
    {
        public static void test()
        {
            BabyDog d1 = new BabyDog();
            Dog dog=(Dog)new Animal();
            
            dog.bark();
            dog.eat();
            Animal animal = new Dog();
            
            d1.eat();
            d1.bark();
            d1.weep();
        }
    }
}
