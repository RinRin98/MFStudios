using MFStudios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFStudios.UI
{
    public partial class uc_KhachHang : UserControl
    {
        public uc_KhachHang()
        {
            InitializeComponent();
        }
        public static string con = @"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";

        private void uc_KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                DBMFStudios context = new DBMFStudios();
                var listKH = context.KHACHHANGs.ToList();

                BindGird(context.KHACHHANGs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGird(List<KHACHHANG> listKH)
        {
            dgvKhachHang.Rows.Clear();
            foreach (KHACHHANG s in listKH)
            {
                int row = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[row].Cells[0].Value = s.MAKH;
                dgvKhachHang.Rows[row].Cells[1].Value = s.TENKH;
                dgvKhachHang.Rows[row].Cells[2].Value = s.DIACHI;
                dgvKhachHang.Rows[row].Cells[3].Value = s.SDT;
                dgvKhachHang.Rows[row].Cells[4].Value = s.EMAIL;
            }
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBMFStudios context = new DBMFStudios();
            KHACHHANG find = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
            if (find != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    context.KHACHHANGs.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không Tìm thấy nhân viên cần xóa!");
            }
            BindGird(context.KHACHHANGs.ToList());
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvKhachHang.Rows[e.RowIndex];

                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtEmail.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                txtMaKH.Enabled = false;
                bbtnThem.Enabled = true;
                bbtnSua.Enabled = true;
                bbtnXoa.Enabled = true;
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
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM KHACHHANG", myClass.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "KH";
            Random rand = new Random();
            string random = (rand.Next(99999)).ToString();

            return ma + random;
        }
        public void clear()
        {

            txtMaKH.Text = "";
            txtTenKH.Focus();
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";   
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            bbtnThem.Enabled = true;
            bbtnLuu.Enabled = true;
            txtMaKH.Text = TangMa();
            txtTenKH.Focus();
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }
        string phonenumber = @"^([+84|84|0]{1})+([3|5|7|8|9]{1})+([0-9]{8})$";
        public bool kiemtrasodienthoai(string number)
        {
            if (number != null) return Regex.IsMatch(number, phonenumber);
            else return false;
        }
        public bool kiemtraMail(string email)
        {
            Regex regex = new Regex(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
        private void bbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (kiemtrasodienthoai(txtSDT.Text) == false)
                {
                    MessageBox.Show("Sai định dạng số Email!", "Thông báo");
                    return;
                }
                if (kiemtraMail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Sai định dạng số Email!", "Thông báo");
                    return;
                }
                if (txtTenKH.Text == "" ||
                txtDiaChi.Text == "" ||
                txtSDT.Text == "" ||
                txtEmail.Text == "" )
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                }
                DBMFStudios context = new DBMFStudios();
                KHACHHANG find = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == txtMaKH.Text);
                if (find == null)
                {
                    KHACHHANG nv = new KHACHHANG();
                    nv.MAKH = TangMa();
                    nv.TENKH = txtTenKH.Text;
                    nv.DIACHI = txtDiaChi.Text;
                    nv.SDT = txtSDT.Text;
                    nv.EMAIL = txtEmail.Text;
                    context.KHACHHANGs.Add(nv);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Khách Hàng thành công!");
                }
                else
                {
                    find.TENKH = txtTenKH.Text;
                    find.DIACHI = txtDiaChi.Text;
                    find.SDT = txtSDT.Text;
                    find.EMAIL = txtEmail.Text;
                    context.KHACHHANGs.AddOrUpdate(find);
                    context.SaveChanges();
                    MessageBox.Show("Update Khách Hàng thành công!");
                }
                BindGird(context.KHACHHANGs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.KHACHHANGs.Where(p => p.MAKH.Contains(txtTimKiem.Text) || p.TENKH.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }
    }
}
