using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
	/*
     
     Voileting ISP
     
     */

	// interface segregation principle - bad example
		interface IWorker
		{
			public void work();
			public void eat();
		}

		class Worker : IWorker
		{
			public void work()
			{
			// ....working
			Console.WriteLine("Working..");
		}
			public void eat()
			{
			// ...... eating in launch break
				Console.WriteLine("eating..");

			}
	}

	class SuperWorker : IWorker
	{
		public void work()
		{
			//.... working much more
			Console.WriteLine("Working..");
		}

		public void eat()
		{
			//.... eating in launch break
			Console.WriteLine("eating..");
		}
	}

	class Manager
	{
		IWorker worker1;

		public void setWorker(IWorker w)
		{
			this.worker1 = w;
		}

		public void manage()
		{
			worker1.work();
		}
	}


	/*

	Follows ISP: Clients should not be forced to depend upon interfaces that they don't use.


	 */



	interface IWorkable
	{
		public void work();
	}

	interface IFeedable
	{
		public void eat();
	}

	interface IWorker_ : IFeedable, IWorkable {

	}

	
	class Worker_ : IWorkable, IFeedable{
		public void work()
		{
			// ....working
			Console.WriteLine("Working..");
		}

		public void eat()
		{
			//.... eating in launch break
			Console.WriteLine("eating in launch break..");
		}
	}

	class Robot : IWorkable
	{
		public void work()
		{
			// ....working
			Console.WriteLine("Robot working..");
		}
	}

	class SuperWorker_ : IWorkable, IFeedable{
		public void work()
		{
			//.... working much more
			Console.WriteLine("working..");
		}

		public void eat()
		{
			//.... eating in launch break
			Console.WriteLine("eating in launch break..");
		}
	}

	class Manager_
	{
		IWorkable worker;

		public void setWorker(IWorkable w)
		{
			worker = w;
		}

		public void manage()
		{
			worker.work();
		}
	}
	internal class ISP
    {
		public static void test()
        {
			/*Does not follow*/
			Manager mgr = new Manager();
			mgr.setWorker(new Worker());
			/*Follows ISP*/
			Manager_ manager = new Manager_();
			manager.setWorker(new Worker_());
			manager.manage();
			manager.setWorker(new Robot());
			manager.manage();
        }
    }
}
