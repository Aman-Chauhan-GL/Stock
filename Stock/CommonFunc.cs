using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock
{
    public class CommonFunc
    {
        public void ViewStock()
        {
            SqlConnection con = new SqlConnection("server=DEL1-LHP-N72555;database=Stock;integrated security=true");
            SqlDataAdapter da = new SqlDataAdapter("select * from StocKP", con);
            DataTable  ds = new DataTable();
            da.Fill(ds);
            Console.Clear();
            foreach (DataRow rows in ds.Rows)
            {
                foreach(var o in rows.ItemArray)
                {
                    Console.Write(o + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
