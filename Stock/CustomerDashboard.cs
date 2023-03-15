using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    class CustomerDashboard
    {
        public void Dashboard()
        {
            CommonFunc CF = new CommonFunc();
            BuyStock BS = new BuyStock();
            Console.WriteLine("Choose the function to be executed");
            Console.WriteLine("Enter 1 to View Stock");
            Console.WriteLine("Enter 2 to Buy Stock");
            Console.WriteLine("Enter 3 to sell Report");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CF.ViewStock();
                    break;
                case 2:
                    BS.Buy();
                    break;
                case 3:
                    break;

            }
        }
    }
}
