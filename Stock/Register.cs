using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Stock
{
    public class Register
    {
        public void CustomerRegister()
        {
            CustomerData CD = new CustomerData();
            Console.WriteLine("Fills the details to register\\n");
            Console.WriteLine("Enter name");
            CD.Cus_Name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            CD.Cus_Password = Console.ReadLine();
            Console.WriteLine("Enter Email");
            CD.Email = Console.ReadLine();
            Console.WriteLine("Phone Number");
            CD.Ph_No = Console.ReadLine();
            Console.WriteLine("Enter the amount to start trading");
            CD.Balance = double.Parse(Console.ReadLine());
            SqlConnection con = new SqlConnection("server=DEL1-LHP-N72555;database=Stock;integrated security=true");
            SqlCommand cmd = new SqlCommand("insert into StockCL values('"+CD.Cus_Name+ "','" + CD.Cus_Password + "','" + CD.Email + "','" + CD.Ph_No + "',"+CD.Balance+")", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Account register ");
            Console.WriteLine("Restart again to login"); 
        }
    }
}
