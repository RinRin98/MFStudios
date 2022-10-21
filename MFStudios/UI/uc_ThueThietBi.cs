using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using MFStudios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MFStudios.UI
{

    public partial class uc_ThueThietBi : UserControl
    {
        string MaNV = LoginForm.getUserlogin;
        public static SqlConnection con = new SqlConnection(@"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True");
        public uc_ThueThietBi()
        {
            InitializeComponent();
        }
        private void uc_ThueThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                DBMFStudios context = new DBMFStudios();
                loadKH();
                BindGirdTB(context.THIETBIs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadKH()
        {
            DBMFStudios context = new DBMFStudios();
            var listKH = context.KHACHHANGs.ToList();
            cbbTenKH.DataSource = listKH;
            cbbTenKH.DisplayMember = "TENKH";
            cbbTenKH.ValueMember = "MAKH";
        }
        private void txtGiaThue_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaThue.Text == "" || txtGiaThue.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtGiaThue.Text, System.Globalization.NumberStyles.Currency);
            txtGiaThue.Text = number.ToString("#,#");
            txtGiaThue.SelectionStart = txtGiaThue.Text.Length;
        }


        private void cbbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            string con = "Data Source=RIN\\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";
            string ad = "select * from KHACHHANG where TENKH = @TENKH";
            using (SqlConnection conDataBase = new SqlConnection(con))
            using (SqlCommand cmdDataBase = new SqlCommand(ad, conDataBase))
                try
                {
                    conDataBase.Open();
                    cmdDataBase.Parameters.Add("@TENKH", SqlDbType.NVarChar).Value = cbbTenKH.Text;
                    using (SqlDataReader myReader = cmdDataBase.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            string MaKH = myReader["MAKH"] as String;
                            txtMaKH.Text = MaKH;
                            string SDT = myReader["SDT"] as String;
                            txtSDT.Text = SDT;
                            string DiaChi = myReader["DIACHI"] as String;

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
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
        public string TangMa()
        {
            if (KetNoi("RIN\\SQLEXPRESS", "DBMFSTUDIOS") == false)          //link DATABASE NGUYEN XUAN TOAN
            //if (KetNoi("MSI\\SQLEXPRESS", "DBMFSTUDIOS") == false)            //link DATABASE TRAN THIEN PHUC
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Application.Exit();
            }
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM THIETBI", myClass.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "HD";
            Random rand = new Random();
            string random = (rand.Next(999)).ToString();

            return ma + random;
        }
        public void clear()
        {

            txtMaTB.Text = "";
            txtTenTB.Text = "";

        }
        private int GetSelectedRow(string maHD)
        {
            for (int i = 0; i < dgvPhieuThueTB.Rows.Count; i++)
            {
                if (dgvPhieuThueTB.Rows[i].Cells[0].Value.ToString() == maHD)
                {
                    return i;
                }
            }
            return -1;
        }
        private void InsertUpdate(int selectedRow)
        {
            dgvPhieuThueTB.Rows[selectedRow].Cells[0].Value = txtMaTB.Text;
            dgvPhieuThueTB.Rows[selectedRow].Cells[1].Value = txtTenTB.Text;
            dgvPhieuThueTB.Rows[selectedRow].Cells[2].Value = dtpThue.Value;
            dgvPhieuThueTB.Rows[selectedRow].Cells[3].Value = dtpTra.Value;
            dgvPhieuThueTB.Rows[selectedRow].Cells[4].Value = float.Parse(txtGiaThue.Text).ToString();
        }
        private void InsertUpdateTHIETBI(int selectedRow)
        {
            dgvThietBi.Rows[selectedRow].Cells[0].Value = txtMaTB.Text;
            dgvThietBi.Rows[selectedRow].Cells[1].Value = txtTenTB.Text;
            dgvThietBi.Rows[selectedRow].Cells[2].Value = txtGiaThue.Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtpThue.Value.Date > dtpTra.Value.Date)
                {
                    MessageBox.Show("Lỗi nhập ngày mời nhập lại!", "Thông báo");
                }
                else if (dgvPhieuThueTB.RowCount == null)
                {
                    btnXoa.Enabled = false;
                }
                else
                {
                    cbbTenKH.Enabled = false;
                    btnXoa.Enabled = true;
                    if (txtMaHD.Text == "" || txtTenTB.Text == "" || dtpThue.Text == "" || dtpTra.Text == "" || txtGiaThue.Text == "")
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    int selectedRow = GetSelectedRow(txtMaHD.Text);
                    int currrow = dgvThietBi.CurrentRow.Index;
                    if (selectedRow == -1)
                    {
                        selectedRow = dgvPhieuThueTB.Rows.Add();
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo!!!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        InsertUpdate(selectedRow);
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo!!!", MessageBoxButtons.OK);
                    }
                    dgvThietBi.Rows.RemoveAt(currrow);
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThietBi.Rows[e.RowIndex];
                txtMaTB.Text = dgvThietBi.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenTB.Text = dgvThietBi.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtGiaThue.Text = dgvThietBi.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtMaTB.Enabled = false;
            }
        }
        private void BindGirdTB(List<THIETBI> listTB)
        {
            dgvThietBi.Rows.Clear();
            foreach (THIETBI s in listTB)
            {
                int row = dgvThietBi.Rows.Add();
                dgvThietBi.Rows[row].Cells[0].Value = s.MATB;
                dgvThietBi.Rows[row].Cells[1].Value = s.TENTB;
                dgvThietBi.Rows[row].Cells[2].Value = s.GIATHUE;

            }
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            cbbTenKH.Refresh();
            bbtnThem.Enabled = true;
            bbtnLuu.Enabled = true;
            btnThem.Enabled = true;
            cbbTenKH.Enabled = true;
            txtMaHD.Text = TangMa();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = GetSelectedRow(txtMaTB.Text);
                int currrow = dgvPhieuThueTB.CurrentRow.Index;
                if (selectedRow == -1)
                {
                    throw new Exception("Không tìm thấy Thiết Bị thuê cần xóa!");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa?", "YES/NO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        dgvPhieuThueTB.Rows.RemoveAt(selectedRow);
                        currrow = dgvThietBi.Rows.Add();
                        InsertUpdateTHIETBI(currrow);
                        MessageBox.Show("Xóa Thiết Bị thuê thành công!", "Thông Báo!!!", MessageBoxButtons.OK);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPhieuThueTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvPhieuThueTB.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtMaTB.Text = row.Cells[0].Value.ToString();
                txtTenTB.Text = row.Cells[1].Value.ToString();
                dtpThue.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                dtpTra.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                txtGiaThue.Text = row.Cells[4].Value.ToString();
            }
        }

        private void bbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                
                if (dgvPhieuThueTB.RowCount == 0)
                {
                    MessageBox.Show("Danh sách trống không thể Lưu Hóa ĐƠNNNNN!");
                }
                else
                {
                    DBMFStudios context = new DBMFStudios();
                    HOADON tb = new HOADON();
                    int NumberOfDays = 0;
                    //double ngaythaydoi = 0;
                    //double ngaykhongthaydoi = 0;
                    string s = "";
                    int sc = dgvPhieuThueTB.Rows.Count;
                    double thanhtien = 0;
                    for (int i = 0; i < sc; i++)
                    {                        
                        s = s + dgvPhieuThueTB.Rows[i].Cells[1].Value.ToString() + ", ";
                        DateTime dt = DateTime.Parse(dgvPhieuThueTB.Rows[i].Cells[2].Value.ToString());
                        DateTime dtra = DateTime.Parse(dgvPhieuThueTB.Rows[i].Cells[3].Value.ToString());
                        if (dt.Day==dtra.Day)
                        {
                            thanhtien += (float.Parse(dgvPhieuThueTB.Rows[i].Cells[4].Value.ToString()));
                        }
                        NumberOfDays = dtra.Day - dt.Day;
                        thanhtien += (float.Parse(dgvPhieuThueTB.Rows[i].Cells[4].Value.ToString())*NumberOfDays);
                    }
                        tb.MAHD = txtMaHD.Text;
                        tb.NGAYTHUE = dtpThue.Value;
                        tb.NGAYHENTRA = dtpTra.Value;
                        tb.THONGTINDONHANG = s.ToString();
                        tb.MAKH = txtMaKH.Text;
                        tb.MANV = MaNV.ToString();
                        tb.TONGTIEN = thanhtien;
                        context.HOADONs.Add(tb);
                        context.SaveChanges();
                        MessageBox.Show("Thêm Hóa Đơn thành công!\n" + "Tổng Tiền phải Thanh Toán là : " + thanhtien, "Thông Báo!!!");
                        dgvPhieuThueTB.Rows.Clear();
                        txtMaHD.Text = TangMa();
                        clear();
                }                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bbtnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dgvPhieuThueTB.Rows.Clear();
            DBMFStudios context = new DBMFStudios();
            BindGirdTB(context.THIETBIs.ToList());

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.THIETBIs.Where(p => p.MATB.Contains(txtTimKiem.Text) || p.TENTB.Contains(txtTimKiem.Text)).ToList();
            BindGirdTB(listTimkiem);
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }
    }
}
