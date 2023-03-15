using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class BuyCalc
    {
        public void Calc()
        {

            Console.WriteLine("Enter the amount to buy stock");
            double amount = double.Parse(Console.ReadLine());
            CommonData CD = new CommonData();
            CustomerData CUD = new CustomerData();
            Console.WriteLine("BUY PRICE = " + CD.Buy_Price);
            Console.WriteLine("No oF stock");
            double NoOfStock = amount/CD.Buy_Price;
            
            double Total = CD.Trading_Fees * NoOfStock;
            Console.WriteLine("Trading fees = "+Total);
            if(CUD.Balance==(Total))
            {
                Console.WriteLine("Stock buy");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
            
        }
    }
}
