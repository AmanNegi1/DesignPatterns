using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Encapsulation
{
    internal class Loan
    {
        public virtual double cal(double a)
        {
            return a;
        }
    }
    internal class HomeLoan: Loan
    {
        public override double cal(double a)
        {
            return a+10;
        }
    }
    internal class VehicleLoan : Loan
    {
        public override double cal(double a)
        {
            return a+20;
        }
    }
    internal class TestLoan
    {
        public static void test()
        {
            Loan loan;
            HomeLoan homeLoan=new HomeLoan();
            VehicleLoan vehicleLoan=new VehicleLoan();
            loan=homeLoan;
            double ans=loan.cal(1);
            Console.WriteLine("Calculated ans "+ans);
        }
    }
}
