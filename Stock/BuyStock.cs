using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class BuyStock
    {
        public void Buy()
        {
            BuyCalc BC = new BuyCalc();
            Console.WriteLine("Enter the stock you want to buy");
            string StockName = Console.ReadLine();
            SqlConnection con = new SqlConnection("server=DEL1-LHP-N72555;database=Stock;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("Select * from StocKP",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "StocKP");
            int count = ds.Tables[0].Rows.Count;
            int flag = 1;
            for (int i = 0; i < count; i++)
            {
                if(StockName==(ds.Tables[0].Rows[i][0].ToString()))
                {
                    BC.Calc();
                    flag = 0;
                }

            }
            if(flag==0)
            {
                Console.WriteLine("NOT AVAILABLE STOCK");
            }


        }
    }
}
