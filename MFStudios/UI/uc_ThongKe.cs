using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;

namespace MFStudios.UI
{
    public partial class uc_ThongKe : UserControl
    {
        public uc_ThongKe()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-OKIVOU5\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True");
        public bool KetNoi(string server, string database)
        {
            try
            {
                string s = "Data source=" + server + ";database=" + database + ";Integrated Security = true";
                myClass.mycon = new SqlConnection(s);
                myClass.mycon.Open();
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
                da = new SqlDataAdapter(s, con);
                da.Fill(ds, "KQ");
                con.Close();
                return ds.Tables["KQ"];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return new DataTable();
            }
        }
        private void bbtnTKTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KetNoi("DESKTOP-OKIVOU5\\SQLEXPRESS", "DBMFSTUDIOS") == false)          //link DATABASE NGUYEN XUAN TOAN
            //if (KetNoi("MSI\\SQLEXPRESS", "DBMFSTUDIOS") == false)            //link DATABASE TRAN THIEN PHUC
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Application.Exit();
            }

            else 
            {
                DateTime ngay = DateTime.Parse(dtpNgay.Value.ToShortDateString());
                double tongtien = 0;
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", con);
                //khởi tạo một instance của class DataTable
                DataTable dt = new DataTable();
                //sử dụng phương thức fill để điền dữ liệu vào bảng
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    if (ngay == DateTime.Parse(row["NGAYHENTRA"].ToString()))
                    {
                        tongtien += double.Parse(row["TONGTIEN"].ToString());
                    }
                }
                MessageBox.Show("Doanh thu là : " + tongtien, "Thống kê doanh thu");
            }
            string query = "Select MAHD,NGAYTHUE,NGAYHENTRA,THONGTINDONHANG,MAKH,MANV,TONGTIEN from HOADON";
            dgvThongKe.DataSource = TruyVan(query);
        }

        private void bbtnTKTT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KetNoi("DESKTOP-OKIVOU5\\SQLEXPRESS", "DBMFSTUDIOS") == false)          //link DATABASE NGUYEN XUAN TOAN
            //if (KetNoi("MSI\\SQLEXPRESS", "DBMFSTUDIOS") == false)            //link DATABASE TRAN THIEN PHUC
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Application.Exit();
            }
            else 
            {

                DateTime a = DateTime.Parse(dtpNgay.Value.ToString());
                double tongtien = 0;
                SqlDataAdapter da = new SqlDataAdapter("select * from HOADON", con);
                //khởi tạo một instance của class DataTable
                DataTable dt = new DataTable();
                //sử dụng phương thức fill để điền dữ liệu vào bảng
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    DateTime datesql = DateTime.Parse(row["NGAYHENTRA"].ToString());

                    if (a.Month == datesql.Month && a.Year == datesql.Year)
                    {
                        tongtien += double.Parse(row["TONGTIEN"].ToString());
                    }
                }
                MessageBox.Show("Doanh thu của tháng " + a.Month + " là : " + tongtien, "Thống kê doanh thu");
            }
            string query = "Select MAHD,NGAYTHUE,NGAYHENTRA,THONGTINDONHANG,MAKH,MANV,TONGTIEN from HOADON";
            dgvThongKe.DataSource = TruyVan(query);
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if(KetNoi("DESKTOP-OKIVOU5\\SQLEXPRESS", "DBMFSTUDIOS"))
            {
                string maHD = txtTim.Text.Trim();
                if (maHD == "")
                {
                    uc_ThongKe_Load(sender, e);
                }
                else 
                {
                    string query = "Select * from HOADON where MAHD like '%" + maHD + "%'";
                    dgvThongKe.DataSource = TruyVan(query);
                }
            }
        }
        private void uc_ThongKe_Load(object sender, EventArgs e)
        {
            if (KetNoi("DESKTOP-OKIVOU5\\SQLEXPRESS", "DBMFSTUDIOS") == false)
            {
                MessageBox.Show("Bấm OK để thoát", "Kết nối không thành công", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                try
                {
                    string query = "Select MAHD,NGAYTHUE,NGAYHENTRA,THONGTINDONHANG,MAKH,MANV,TONGTIEN from HOADON";
                    dgvThongKe.DataSource = TruyVan(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtpNgay_ValueChanged(object sender, EventArgs e)
        {
            if (KetNoi("DESKTOP-OKIVOU5\\SQLEXPRESS", "DBMFSTUDIOS"))
            {
                DateTime ngay = DateTime.Parse(dtpNgay.Value.ToShortDateString());
                string query = "Select * from HOADON where NGAYHENTRA='" + ngay + "'";
                dgvThongKe.DataSource = TruyVan(query);
            }
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }
    }
}

