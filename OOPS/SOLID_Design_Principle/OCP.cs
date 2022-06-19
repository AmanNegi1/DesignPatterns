using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    internal abstract class Branch
    {
        abstract public Boolean validateAddressProof(string proof);
        public void openAccount(string proof, int amt)
        {
            if (amt >= 500 && validateAddressProof(proof))
            {
                Console.WriteLine("Account Opened");
            }
            else
            {
                Console.WriteLine("Account Can not be opened");
            }
        }
    }
    internal class MumbaiBranch : Branch
    {
        public override bool validateAddressProof(string proof)
        {
            if (proof.Equals("panCard"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    internal class DelhiBranch : Branch
    {
        public override bool validateAddressProof(string proof)
        {
            if (proof.Equals("electricBill"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    internal class OCP
    {
        public static void test()
        {
            Branch mumbaiBranch = new MumbaiBranch();
            mumbaiBranch.openAccount("panCard", 500);
            Branch delhiBranch = new DelhiBranch();
            delhiBranch.openAccount("electicBill", 400);
        }
    }
}
