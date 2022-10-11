using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFStudios
{
    public class myClass
    {
        static SqlConnection con = new SqlConnection();
        public static void TaoKetNoi()
        {
            con.ConnectionString = "Data Source=LAPTOP-0APB0UV0\\SQLEXPRESS;Initial Catalog=TestLogin;Integrated Security=True";
            try
            {
                con.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DongKetNoi()
        {
            con.Close();
        }

        public static DataTable GetData(string query)
        {
            TaoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            DongKetNoi();
            return tb;
        }
    }
}
