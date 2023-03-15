using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public partial class AdminFunc
    {
        public void Publish()
        {
            CommonData CD = new CommonData();
            Console.WriteLine("Enter the new Stock ");
            Console.WriteLine("Enter Stock Name");
            CD.Stock_Name = Console.ReadLine();
            Console.WriteLine("Enter Company Name");
            CD.Company_Name = Console.ReadLine();
            Console.WriteLine("Enter Buy_Price");
            CD.Buy_Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Sell_Price");
            CD.Sell_Price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            CD.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trading_Fees");
            CD.Trading_Fees = Double.Parse(Console.ReadLine());
            SqlConnection con = new SqlConnection("server=DEL1-LHP-N72555;database=Stock;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into StocKP values('"+CD.Stock_Name+"','"+CD.Company_Name+"',"+CD.Buy_Price+ "," + CD.Sell_Price + "," + CD.Quantity + "," + CD.Trading_Fees + ")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Stock Updated");
        }
    }
}
