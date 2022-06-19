using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP
{
    interface Animal
    {
        public string speak();
    }
    //Land Animal
    class Dog : Animal
    {
        public  string speak()
        {
            return "bark";
        }
    }
    class Lion : Animal
    {
        public string speak()
        {
            return "Roar";
        }
    }
    //Sea Animal..
    class Octopus : Animal
    {
        public string speak()
        {
            return "Squaqck";
        }
    }
    class Shark : Animal
    {
        public string speak()
        {
            return "No voice";
        }
    }
    abstract class AnimalFactory
    {
        public abstract Animal getAnimal(string animalType);
        public static AnimalFactory createAnimalFactory(string factoryType)
        {
            if (factoryType.Equals("sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }

    }
    class LandAnimalFactory : AnimalFactory
    {
        public override Animal getAnimal(string animalType)
        {
            if (animalType.Equals("dog"))
            {
                return new Dog();
            }
            else 
            {
                return new Lion();
            }
            
        }
    }
    class SeaAnimalFactory : AnimalFactory
    {
        public override Animal getAnimal(string animalType)
        {
            if (animalType.Equals("octopus"))
            {
                return new Octopus();
            }
            else if (animalType.Equals("shark"))
            {
                return new Shark();
            }
            else
            {
                throw new Exception();
            }
        }
    }
    internal class Abstract_Factory_DP
    {
        public static void test()
        {
            AnimalFactory factory = new LandAnimalFactory();
            Animal animal=factory.getAnimal("Dog");
            animal.speak();
        }
    }
}
