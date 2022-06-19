using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP
{
    interface CreditCard
    {
        string getCardType();
        int getCreditLimit();
        int getAnnualCharge();
    }
    class PlatinumCard : CreditCard
    {
        public string getCardType()
        {
            return "Saving";
        }
        public int getCreditLimit()
        {
            return 20000;
        }
        public int getAnnualCharge()
        {
            return 300;
        }
    }
    class Titanium : CreditCard
    {
        public string getCardType()
        {
            return "Current";
        }
        public int getCreditLimit()
        {
            return 40000;
        }
        public int getAnnualCharge()
        {
            return 400;
        }
    }
    abstract class CreditCardFactory
    {
        protected abstract CreditCard makeProduct();
        public CreditCard createProduct()
        {
            return this.makeProduct();
        }

    }
    class TitaniumCardFactory : CreditCardFactory
    {
        protected override CreditCard makeProduct()
        {
            CreditCard product = new Titanium();
            return product;
        }
    }
    class PlatinumCardFactory : CreditCardFactory
    {
        protected override CreditCard makeProduct()
        {
            CreditCard product= new PlatinumCard();
            return product ;
        }
    }
    internal class Factory_Method_DP
    {
        public static void test()
        {
            CreditCard card=new PlatinumCardFactory().createProduct();
            Console.WriteLine(card.getCardType());
            Console.WriteLine(card.getCreditLimit());
            Console.WriteLine(card.getAnnualCharge());
        }
    }
}
