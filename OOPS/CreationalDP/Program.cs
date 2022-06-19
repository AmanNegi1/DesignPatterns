namespace CreationalDP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //factory method design pattern..
            Console.WriteLine("Factory Method");
            Factory_Method_DP.test();
            //Abstract factory design pattern..
            Console.WriteLine("Abstract Factory method");
            Abstract_Factory_DP.test();
           // Builder Design Pattern..
            Console.WriteLine("Builder Design Pattern");
            BuilderDP.test();
            Console.WriteLine("Prototype Design Pattern");
            PrototypeDP.test();
            Console.WriteLine("Singleton Design Pattern");
            SingletonDP.test();
        }
    }
}