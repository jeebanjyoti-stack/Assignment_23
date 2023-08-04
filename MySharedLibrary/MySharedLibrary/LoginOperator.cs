using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class LoginOperator
    {
        static List<Login> list = new List<Login>()
        {
            new Login {ID = 8249801,Password = "j4356"},
            new Login {ID = 8249802,Password = "j8552"},
            new Login {ID = 8249803,Password = "j8520"},
            new Login {ID = 8249804,Password = "j9632"},
            new Login {ID = 8249805,Password = "j7410"},
        };
        public static void login()
        {
            Login loginDetails = new Login();
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Login l = list.SingleOrDefault(e => e.ID == id && e.Password == password);
            if (l != null)
            {
                Console.WriteLine("Login Successfull!!");
            }
            else
            {
                Console.WriteLine("Invalid Details!!");
            }

        }
    }
}
