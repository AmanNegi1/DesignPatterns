using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{

	// Dependency Inversion Principle - Bad example

	class Worker2
	{

		public void work()
		{

			// ....working

		}

	}



	class Manager2
	{

		Worker worker;



		public void setWorker(Worker w)
		{
			worker = w;
		}

		public void manage()
		{
			worker.work();
		}
	}

	class SuperWorker2
	{
		public void work()
		{
			//.... working much more
		}
	}

	internal class DIP_Voilets
    {
    }
}
