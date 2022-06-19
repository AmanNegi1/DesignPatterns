using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    class Product
    {
        public void getProductDetails()
        {
            Console.WriteLine("Getting Product Details..");
        }
    }
    class Payment
    {
        public void makePayment()
        {
            Console.WriteLine("Making Payment..");
        }
    }
    class Invoice
    {
        public void sendInvoice()
        {
            Console.WriteLine("Sending Invoice..");
        }
    }
    /*
        Creating Facade
     */
    class Order
    {
        public void placeOrder()
        {
            Product product = new Product();
            product.getProductDetails();
            Payment payment = new Payment();
            payment.makePayment();
            Invoice invoice = new Invoice();
            invoice.sendInvoice();
        }
    }
    internal class FacadeDP
    {
        public static void test()
        {
            //client..
            Order order= new Order();  
            order.placeOrder();

        }
    }
}
