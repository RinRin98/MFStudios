using frmQLThietBi;
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

namespace frmQLTB
{
    public partial class frmLoaiTB : Form
    {
        public string chuoi = "Select * from loaithietbi";
        public bool KetNoi(string server, string database)
        {
            try
            {
                string s = "Data source=" + server + ";database=" + database + ";Integrated Security = true";
                ChuoiKetNoi.mycon = new SqlConnection(s);
                ChuoiKetNoi.mycon.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public frmLoaiTB()
        {
            InitializeComponent();
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvLTB);
            clear();
        }
        public void clear()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
        }
        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string load1 = "Select * from loaithietbi where tenloai like N'%" + txtTim.Text + "%' ";
            ChuoiKetNoi.timkiem(load1, dgvLTB);
            clear();
        }
        public string TangMa()
        {
            if(KetNoi("MSI\\SQLEXPRESS", "DBMFSTUDIOS") == false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }    
            SqlDataAdapter ad = new SqlDataAdapter("select * from LoaiThietBi",ChuoiKetNoi.mycon );
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "LTB001";
            }
            else
            {
                int k;
                ma = "LTB";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(3, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            txtMaLoai.Text = TangMa();
            txtTenLoai.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update loaithietbi set tenloai = N'" + txtTenLoai.Text + "' Where maloai = '" + txtMaLoai.Text + "'";
            ChuoiKetNoi.Execute_Sua(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvLTB);
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from loaithietbi where maloai= '" + txtMaLoai.Text + "'";
            ChuoiKetNoi.Execute_Xoa(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvLTB);
            clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text == ""||txtMaLoai.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into LoaiThietBi values(N'" + txtMaLoai.Text + "',N'" + txtTenLoai.Text + "' )";
                ChuoiKetNoi.them_dl(sql1, dgvLTB);
                ChuoiKetNoi.Chuoiketnoi(chuoi, dgvLTB);
                clear();
            }
        }
        private void dgvLTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dgvLTB.CurrentRow.Index;
            txtMaLoai.Text = dgvLTB.Rows[curow].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLTB.Rows[curow].Cells[1].Value.ToString();
            txtMaLoai.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
    }
}
