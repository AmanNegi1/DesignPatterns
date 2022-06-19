using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    public class Product
    {
        protected double discount=1;
        public double getDiscount()
        {
            return discount;
        }
    }
    
    public class InHouseProduct : Product
    {
        public void applyExtraDiscount()
        {
            discount = discount * 1.5;
        }
    }
   
    public class PricingUtils
    {
        public static void main()
        {
            Product product = new Product();
            Product p2 = new Product();
            Product p3=new InHouseProduct();
            List<Product> products = new List<Product>();
            products.Add(product);
            products.Add(p2);
            products.Add(p3);
            foreach(Product p in products)
            {
                if(p.GetType() == typeof(InHouseProduct))
                {
                    //here we have to bother about checking //object downcasted
                    ((InHouseProduct)p).applyExtraDiscount();
                }
                Console.WriteLine(p.getDiscount());
            }


            ///Applied LSP
            Product2 product2 = new Product2();
            Product2 p22 = new Product2();
            Product2 p32 = new InHouseProduct2();
            List<Product2> products2 = new List<Product2>();
            products2.Add(product2);
            products2.Add(p22);
            products2.Add(p32);

            foreach (Product2 p in products2)
            {
                
                Console.WriteLine(p.getDiscount());
            }


        }
    }
    internal class LspAgain
    {
        public static void test()
        {
            PricingUtils.main();
        }
    }
    public class Product2
    {
        protected double discount = 1;
        public virtual double getDiscount()
        {
            return discount;
        }
    }
    public class InHouseProduct2 : Product2
    {

        public override double getDiscount()
        {
            applyExtraDiscount();
            return discount;
        }
        public void applyExtraDiscount()
        {
            discount = discount * 1.5;
        }
    }
}
