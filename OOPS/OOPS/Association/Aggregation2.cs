using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Association
{
    internal class Car
    {
        private Wheel wheel;
        private Engine engine;

        public Car(Wheel wheel, Engine engine)
        {
            this.wheel = wheel;
            this.engine = engine;
        }
    }
    internal class Wheel
    {
        public string manufacturer;
        public Wheel(string menufby)
        {
            this.manufacturer = menufby;
        }
    }

    internal class Engine
    {
        public string manufacturer;
        public Engine(string menuBy)
        {
            this.manufacturer=menuBy;
        }
    }
    internal class Aggregation2
    {
        public static void test()
        {
            Engine engine = new Engine("abc");
            Wheel wheel = new Wheel("xyx");
            Car car=new Car(wheel, engine);
            Console.WriteLine(car.GetType);
        }
    }
}
