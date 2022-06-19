using OOPS.Abstraction;
using OOPS.Inheritance;
using OOPS.Encapsulation;
using OOPS.Polymorphism.method_overloading;
using OOPS.Polymorphism;
using OOPS.Association;
namespace OOPS
{
    public class Program
    {
         static void Main(string[] args)
        {

            //Abstraction
            Branch mumbaiBranch = new MumbaiBranch();
            mumbaiBranch.openAccount("panCard", 500);
            Branch delhiBranch=new DelhiBranch();
            delhiBranch.openAccount("electicBill", 400);

            //Inheritance client
            TestEmployee.test();
            //Multi level Inheritance
            TestAnimal.test();
            //multiple inheritance
            TestCalculator.test();
            //Method Overriding
            TestLoan.test();
            //Method overloading
            MethodOverloading.test();
            //TypeCasting
            TypeCasting.test();
            Aggregation2.test();
            Composition.test();

            Method_Overriding.test();




        }
    }

}