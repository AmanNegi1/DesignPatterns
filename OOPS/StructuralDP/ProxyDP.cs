using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDP
{
    interface ExpensiveObject
    {
        void process();
    }
    class ExpensiveObjectImpl : ExpensiveObject
    {

        public ExpensiveObjectImpl()
        {
            heavyInitialConfiguration();
        }

   
        public  void process()
        {
        
                Console.WriteLine("processing complete.");
        }

        private void heavyInitialConfiguration()
        {
        
                Console.WriteLine("Loading initial configuration...");
        }

    }
    class ExpensiveObjectProxy : ExpensiveObject
    {
        private static ExpensiveObject obj;

    
        public void process()
        {
            if (obj == null)
            {
                obj = new ExpensiveObjectImpl();
            }
            obj.process();
        }
    }
internal class ProxyDP
    {
        public static void test()
        {
            ExpensiveObject obj = new ExpensiveObjectProxy();
            obj.process();
            obj.process();
        }
    }
}
