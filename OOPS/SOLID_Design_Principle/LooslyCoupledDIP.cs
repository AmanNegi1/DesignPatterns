using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    internal interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    internal class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }

    internal class DataAccessFactory_
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }

    public class CustomerBusinessLogic_
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic_()
        {
            _custDataAccess = DataAccessFactory_.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
    internal class LooslyCoupledDIP
    {
        public static void test()
        {
            CustomerBusinessLogic_ customerBusinessLogic_ = new CustomerBusinessLogic_();
            customerBusinessLogic_.GetCustomerName(1);
        }
    }
}
