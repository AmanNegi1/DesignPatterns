using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Control_Flow
{
    internal class StaticFlow
    {
        static int i = 10;
        static StaticFlow(){
            Console.WriteLine("Hello");
        }
        public static void methodOne(StaticFlow obj)
        {
           // obj.methodTwo();

            Console.WriteLine("Inside method one "+obj+j);
            return;
        }
        public void methodTwo()
        {
               StaticFlow.methodOne(this);
            return;
        }
        static int j = 20;
    }
}
