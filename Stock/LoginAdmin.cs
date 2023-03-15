using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class LoginAdmin
    {
        public void LoginA()
        {
            SqlConnection con = new SqlConnection("server=DEL1-LHP-N72555;database=Stock;integrated security=true");
            AdminData AD = new AdminData();
            AdminDashboard ADD = new AdminDashboard();
            Console.WriteLine("Enter Admin Name ");
            AD.Admin_Name = Console.ReadLine();
            Console.WriteLine("Enter Admin Password");
            AD.Admin_Password = Console.ReadLine();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from StockAL", con);
            DataSet ds = new DataSet();
            da.Fill(ds,"StockAL");
            int count = ds.Tables[0].Rows.Count;
            int flag = 1;
            for (int i = 0; i < count; i++)
            {
                if (AD.Admin_Name == (ds.Tables[0].Rows[i][0].ToString()) && AD.Admin_Password == (ds.Tables[0].Rows[i][1].ToString()))
                {
                    Console.WriteLine("You are successfully login as " + AD.Admin_Name);
                    flag = 0;
                    ADD.Dashboard();
                    break;
                }
                
            }
            if(flag!=0)
            {
                Console.WriteLine("WRONG CREDENTIALS");
            }


        }

    }
}
