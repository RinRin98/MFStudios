using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MFStudios
{
    public class myClass
    {
        public static string sqlcon = @"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";
        public static SqlConnection mycon;

        public static SqlConnection Mycon
        {
            get { return myClass.mycon; }
            set { myClass.mycon = value; }
        }
        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;

        public static SqlCommandBuilder bd;
        public static SqlDataReader showtext(string sql)
        {
            SqlDataReader read = null;
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql, mycon);
                read = com.ExecuteReader();

            }
            catch (Exception ex)
            { MessageBox.Show("Lỗi kết nối!\n" + ex.Message); }
            return read;
        }
        // ham ket noi
        public static void Chuoiketnoi(string chuoi, DataGridView db1)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối " + ex, "Thông báo ! ");
            }
        }


        // n bao câu lệnh chuoi select * cua minh sai

        public static void timkiem(string chuoi, DataGridView db2)
        {
            try
            {
                ad = new SqlDataAdapter(chuoi, sqlcon);
                dt = new DataTable();
                bd = new SqlCommandBuilder(ad);
                ad.Fill(dt);
                db2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        public static void xulycbx(string chuoi, ComboBox cbx)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();
            ad.Fill(dt);
            cbx.DataSource = dt;
        }


        public static void dodata(string chuoi, DataTable dt)
        {
            ad = new SqlDataAdapter(chuoi, sqlcon);
            dt = new DataTable();
            ad.Fill(dt);
        }
        //Them du lieu
        public static void them_dl(string sql1, DataGridView dt)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                dt.DataSource = tb;
                MessageBox.Show("Thêm thành công !", "Thông báo");
                mycon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "" + ex);
            }

        }
        public static void them_dlHoaDon(string sql1)
        {
            try
            {
                mycon = new SqlConnection(sqlcon);
                mycon.Open();
                com = new SqlCommand(sql1, mycon);
                ad = new SqlDataAdapter(com);
                DataTable tb = new DataTable();
                ad.Fill(tb);
                mycon.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("them loi r cau " + e);
            }

        }
        public static void Execute_Sua(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn sửa không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn sửa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        public static void Execute_Xoa(string sql)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mycon = new SqlConnection(sqlcon);
                    mycon.Open();
                    com = new SqlCommand(sql, mycon);
                    com.ExecuteNonQuery();
                    mycon.Close();
                    MessageBox.Show("Bạn đã xóa thành công ! ", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);

                }
            }
        }
        public bool KetNoi(string server, string database)
        {
            try
            {
                string s = "Data source=" + server + ";database=" + database + ";Integrated Security = true";
                mycon = new SqlConnection(s);
                mycon.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        DataTable TruyVan(string s)
        {
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(s, mycon);
                da.Fill(ds, "KQ");
                mycon.Close();
                return ds.Tables["KQ"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }

        bool ThemXoaSua(string s)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(s, mycon);
                cmd.ExecuteNonQuery();
                mycon.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
