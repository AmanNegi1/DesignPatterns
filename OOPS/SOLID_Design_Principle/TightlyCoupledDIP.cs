using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    internal class CustomerBusinessLogic
    {
        public CustomerBusinessLogic()
        {
        }

        public string GetCustomerName(int id)
        {
            DataAccess _dataAccess = DataAccessFactory.GetDataAccessObj();

            return _dataAccess.GetCustomerName(id);
        }
    }
    internal class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }
    internal class DataAccess
    {
        public DataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name"; // get it from DB in real app
        }
    }
    /*
        the CustomerBusinessLogic class uses the concrete DataAccess class. Therefore, 
        it is still tightly coupled, even though we have inverted the dependent object creation to the factory class.
     */
    internal class TightlyCoupledDIP
    {
        public static void test()
        {
            CustomerBusinessLogic customerBusinessLogic = new CustomerBusinessLogic();
            customerBusinessLogic.GetCustomerName(1);
        }
    }
}
