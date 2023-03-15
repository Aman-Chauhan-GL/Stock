using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class AdminDashboard
    {
        public void Dashboard()
        {
            AdminFunc AF = new AdminFunc();
            CommonFunc CF = new CommonFunc();
            Console.WriteLine("Choose the function to be executed");
            Console.WriteLine("Enter 1 to Publish Stock");
            Console.WriteLine("Enter 2 to view Stock");
            Console.WriteLine("Enter 3 to generate Report");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    AF.Publish();
                    break;
                case 2:
                    CF.ViewStock();
                    break;
                case 3:
                    break;

            }
        }

    }
}
