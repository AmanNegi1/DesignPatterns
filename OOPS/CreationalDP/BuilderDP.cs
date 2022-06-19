using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP
{
    class Vehicle
    {
       public string Body { get; set; }  
       public string Engine { get; set; }
       public string Model { get; set; }
        public Vehicle()
        {

        }
        public void showInfo()
        {
            Console.WriteLine(this.Body + " " + this.Engine + " " + this.Model+" "+this);
        }
    }
    interface IVehicleBuilder
    {
        void setModel();
        void setEngine();
        void setBody();
        Vehicle getVehicle();
    }
    class HeroBuilder : IVehicleBuilder
    {
        static Vehicle vehicle=new Vehicle();
        public void setModel()
        {
            vehicle.Model="Setting model";
        }
        public void setEngine()
        {
            vehicle.Engine="Setting engine";
        }
        public void setBody()
        {
            vehicle.Body="setting body";
        }
        public  Vehicle getVehicle()
        {
            return vehicle;
        }
    }
    class HondaBuilder : IVehicleBuilder
    {
        static Vehicle vehicle = new Vehicle();
        public void setModel()
        {
            vehicle.Model = "Setting model";
        }
        public void setEngine()
        {
            vehicle.Engine = "Setting engine";
        }
        public void setBody()
        {
            vehicle.Body = "setting body";
        }
        public Vehicle getVehicle()
        {
            return vehicle;
        }
    }

     class VehicleCreator
    {
        private readonly IVehicleBuilder vehicleBuilder;
        public VehicleCreator(IVehicleBuilder builder)
        {
            vehicleBuilder = builder;
        }
        public void createVehicle()
        {
            vehicleBuilder.setBody();
            vehicleBuilder.setEngine();
            vehicleBuilder.setModel();
        }
        public Vehicle getVehicle()
        {
            return vehicleBuilder.getVehicle();
        }

    }
    internal class BuilderDP
    {
         public static void test()
        {
            var vehicleCreator =new VehicleCreator(new HeroBuilder());
            vehicleCreator.createVehicle();
            var vehicle= vehicleCreator.getVehicle();
            vehicle.showInfo();
        }
    }
}
