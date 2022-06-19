using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
	interface IWorker_2
	{
		public void work();
	}

	class Worker_2 : IWorker_2
	{
		public void work()
		{
			// ....working
			Console.WriteLine("Worker_2 working ..");
		}
	}

	class SuperWorker_2  : IWorker_2
	{
		public void work()
		{
			//.... working much more
			Console.WriteLine("Superworker_2 working hard..");
		}
	}

class Manager_2
{
	IWorker_2 worker;

	public void setWorker(IWorker_2 w)
	{
		worker = w;
	}

	public void manage()
	{
		worker.work();
	}
}
internal class DIP
    {
		public static void test()
        {
			Manager_2 manager = new Manager_2();
			manager.setWorker(new Worker_2());
			manager.manage();
        }
    }
}
