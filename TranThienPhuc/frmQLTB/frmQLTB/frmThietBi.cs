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
    public partial class frmThietBi : Form
    {
        public string chuoi = "select thietbi.matb, thietbi.tentb, thietbi.soluong, thietbi.mota, thietbi.tinhtrang, thietbi.giatritb, thietbi.giathue, loaithietbi.tenloai from thietbi INNER JOIN loaithietbi ON thietbi.maloai = loaithietbi.maloai";
        public frmThietBi()
        {
            InitializeComponent();
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvTTTB);
            clear();
        }
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
        public string TangMa()
        {
            if (KetNoi("MSI\\SQLEXPRESS", "DBMFSTUDIOS") == false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
            SqlDataAdapter ad = new SqlDataAdapter("select * from ThietBi", ChuoiKetNoi.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "TB001";
            }
            else
            {
                int k;
                ma = "TB";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
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
        public void clear()
        {
            dgvTTTB.Columns[0].HeaderText = "Mã TB"; dgvTTTB.Columns[0].Width = 110;
            dgvTTTB.Columns[1].HeaderText = "Tên TB"; dgvTTTB.Columns[1].Width = 150;
            dgvTTTB.Columns[2].HeaderText = "Số Lượng"; dgvTTTB.Columns[2].Width = 110;
            dgvTTTB.Columns[3].HeaderText = "Mô Tả"; dgvTTTB.Columns[3].Width = 110;
            dgvTTTB.Columns[4].HeaderText = "Tình Trạng"; dgvTTTB.Columns[4].Width = 110;
            dgvTTTB.Columns[5].HeaderText = "Gía Trị TB"; dgvTTTB.Columns[5].Width = 110;
            dgvTTTB.Columns[6].HeaderText = "Gía Thuê TB"; dgvTTTB.Columns[6].Width = 110;
            dgvTTTB.Columns[7].HeaderText = "Tên Loại"; dgvTTTB.Columns[7].Width = 110;
            loaitb();
            txtMaTB.Text = "";
            txtTenTB.Focus();
            txtTenTB.Text = "";
            txtSoLuong.Text = "";
            txtMaTB.Text = "";
            txtTinhTrang.Text = "";
            txtGiaTri.Text = "";
            txtGiaThue.Text = "";
            int sc = dgvTTTB.Rows.Count;
            double tongTB = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongTB++;
            }
            lblKQ.Text = tongTB.ToString() + " TB";
        }
        private void loaitb()
        {
            string load_loaitb = "Select maloai, tenloai from loaithietbi";
            ChuoiKetNoi.xulycbx(load_loaitb, cmbLoaiTB);
            cmbLoaiTB.DisplayMember = "tenloai";
            cmbLoaiTB.ValueMember = "maloai";
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {           
                string load1 = "Select * from thietbi where tentb like N'%" + txtTim.Text + "%' ";
                ChuoiKetNoi.timkiem(load1, dgvTTTB);
                clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "Update thietbi set tentb = N'" + txtTenTB.Text + "',soluong = N'" + txtSoLuong.Text + "',mota = '" + txtMoTa.Text + "',tinhtrang = '" + txtTinhTrang.Text + "',giatritb = '" + txtGiaTri.Text + "',giathue = '" + txtGiaThue.Text + "',maloai = N'" + cmbLoaiTB.SelectedValue + "' where matb='" + txtMaTB.Text + "'";
            ChuoiKetNoi.Execute_Sua(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvTTTB);
            clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from thietbi where matb= '" + txtMaTB.Text + "'";
            ChuoiKetNoi.Execute_Xoa(sql);
            ChuoiKetNoi.Chuoiketnoi(chuoi, dgvTTTB);
            clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void txtGiaTri_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtGiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clear();
            btnThem.Enabled = true;
            btnLuu.Enabled = true;
            txtMaTB.Text = TangMa();
            txtTenTB.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenTB.Text == "" ||
            txtSoLuong.Text == "" ||
            txtMoTa.Text == "" ||
            txtTinhTrang.Text == "" ||
            txtGiaTri.Text == "" ||
            txtGiaThue.Text == "" ||
            cmbLoaiTB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
            }
            else
            {
                string sql1 = "Insert into thietbi values(N'" +txtMaTB.Text+ "',N'"+ txtTenTB.Text + "','" + txtSoLuong.Text + "',N'" + txtMoTa.Text + "',N'" + txtTinhTrang.Text + "','" + txtGiaTri.Text + "','" + txtGiaThue.Text + "',N'" + cmbLoaiTB.SelectedValue + "')";
                ChuoiKetNoi.them_dl(sql1, dgvTTTB);
                ChuoiKetNoi.Chuoiketnoi(chuoi, dgvTTTB);
                clear();
            }
        }

        private void dgvTTTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dgvTTTB.CurrentRow.Index;
            txtMaTB.Text = dgvTTTB.Rows[curow].Cells[0].Value.ToString();
            txtTenTB.Text = dgvTTTB.Rows[curow].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvTTTB.Rows[curow].Cells[2].Value.ToString();
            txtMoTa.Text = dgvTTTB.Rows[curow].Cells[3].Value.ToString();
            txtTinhTrang.Text = dgvTTTB.Rows[curow].Cells[4].Value.ToString();
            txtGiaTri.Text = dgvTTTB.Rows[curow].Cells[5].Value.ToString();
            txtGiaThue.Text = dgvTTTB.Rows[curow].Cells[6].Value.ToString();
            cmbLoaiTB.Text = dgvTTTB.Rows[curow].Cells[7].Value.ToString();
            txtMaTB.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
    }
}
