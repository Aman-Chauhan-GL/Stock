using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class LoginCustomer
    {
        public void LoginC()
        {
            CustomerData CD = new CustomerData();
            CustomerDashboard CDashboard = new CustomerDashboard();
            SqlConnection con = new SqlConnection("server=DEL1-LHP-N72555;database=Stock;integrated security=true");
            Console.WriteLine("Enter Customer Name");
            CD.Cus_Name = Console.ReadLine();
            Console.WriteLine("Enter Customer Password");
            CD.Cus_Password = Console.ReadLine();
            SqlDataAdapter da = new SqlDataAdapter("select * from StockCL",con);
            DataSet ds = new DataSet();
            da.Fill(ds, "StockCL");
            int count = ds.Tables[0].Rows.Count;
            int flag = 1;
            for(int i=0;i<count;i++)
            {
                if(CD.Cus_Name == (ds.Tables[0].Rows[i][0].ToString()) && CD.Cus_Password == (ds.Tables[0].Rows[i][1].ToString()))
                {
                    Console.WriteLine("Sucessfully login as " + CD.Cus_Name);
                    Console.WriteLine();
                    CDashboard.Dashboard();
                    flag = 0;
                    break;
                }
                
            }
            if (flag != 0)
            {
                Console.WriteLine("Wrong credentials");
            }
        }
    }
}
