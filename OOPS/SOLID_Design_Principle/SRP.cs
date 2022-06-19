using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principle
{
    /*
           Example that Voilets the SRP..
 
     */
    class User
    {
        public string Name { get; set; }
    }
    class SqlDB
    {
        public void openConnection()
        {

        }
        public void close()
        {
            Console.WriteLine("Connection closed..");
        }
    }
    class SqlCommand
    {
        public SqlCommand(string user)
        {
            Console.WriteLine("User Registered");
        }
    }
    class RegisterService
    {
        public void registerUser(string name)
        {
            SqlDB con = new SqlDB();
            con.openConnection();
            SqlCommand command = new SqlCommand("insert user into table");
            con.close();
        }
    }
    /*
    
    
    Example Follows SRP


     */
    class RegisterService_Follows_SRP
    {
        UserRepository _userRepository=new UserRepository();
        public void RegisterUser(User user)
        {
            _userRepository.insert(user);
        }

    }
    class UserRepository
    {
        public void insert(User user)
        {
            
            SqlDB con = new SqlDB();
            con.openConnection();
            Console.WriteLine("Connection Opened..");
            SqlCommand command = new SqlCommand("insert user into table");
            con.close();
        }
    }
    internal class SRP
    {
        public static void test()
        {
            User user = new User();
            user.Name = "Aman";
            RegisterService_Follows_SRP registerService_Follows_SRP = new RegisterService_Follows_SRP();
            registerService_Follows_SRP.RegisterUser(user);
        }
    }
}
