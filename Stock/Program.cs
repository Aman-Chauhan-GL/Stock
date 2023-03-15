using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose to login in");
            Console.WriteLine("Enter 1 to login as Admin");
            Console.WriteLine("Enter 2 login as Customer");
            Console.WriteLine("Enter 3 to Register");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    LoginAdmin LA = new LoginAdmin();
                    LA.LoginA();
                    break;
                case 2:
                    LoginCustomer LC = new LoginCustomer();
                    LC.LoginC();
                    break;
                case 3:
                    Register R = new Register();
                    R.CustomerRegister();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
