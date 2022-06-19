using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDP
{
    public sealed class SingletonDP
    {
        private static int counter = 0;
        private static SingletonDP instance=null;
        public static SingletonDP getInstance
        {
            get{
                if(instance==null)
                    instance = new SingletonDP();
                return instance;
            }
        }
        private SingletonDP()
        {
            counter++;
            Console.WriteLine(counter.ToString());
        }
        public void printDetails(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void test()
        {
            SingletonDP fromTeacher = SingletonDP.getInstance;
            fromTeacher.printDetails("from teacher");
            SingletonDP fromStuedent=SingletonDP.getInstance;
            fromStuedent.printDetails("from student");
        }
    }
}
