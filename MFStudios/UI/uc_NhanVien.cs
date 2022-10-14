using DevExpress.WebUtils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using MFStudios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace MFStudios.UI
{
    public partial class uc_NhanVien : UserControl
    {

        public static string con = @"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";
        public uc_NhanVien()
        {
            InitializeComponent();
            
        }
        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                DBMFStudios context = new DBMFStudios();
                var listNhanVien = context.NHANVIENs.ToList();
                
                var listChucVu = context.CHUCVUs.ToList();
                cbbChucVu.DataSource = listChucVu;
                cbbChucVu.DisplayMember = "TENCV";
                cbbChucVu.ValueMember = "MACV";
                BindGird(context.NHANVIENs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGird(List<NHANVIEN> listCV)
        {
            dgvNhanVien.Rows.Clear();
            foreach (NHANVIEN s in listCV)
            {
                int row = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[row].Cells[0].Value = s.MANV;
                dgvNhanVien.Rows[row].Cells[1].Value = s.PASS;
                dgvNhanVien.Rows[row].Cells[2].Value = s.HOTEN;
                if (s.GIOITINH == true)
                    dgvNhanVien.Rows[row].Cells[3].Value = "Nam";
                else
                    dgvNhanVien.Rows[row].Cells[3].Value = "Nữ";
                dgvNhanVien.Rows[row].Cells[4].Value = s.SDT;
                dgvNhanVien.Rows[row].Cells[5].Value = s.EMAIL;
                dgvNhanVien.Rows[row].Cells[6].Value = s.CHUCVU.TENCV;
            }
        }
      
        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBMFStudios context = new DBMFStudios();
            NHANVIEN find = context.NHANVIENs.FirstOrDefault(p => p.MANV == txtMaNV.Text);
            if (find != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    context.NHANVIENs.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không Tìm thấy nhân viên cần xóa!");
            }
            BindGird(context.NHANVIENs.ToList());

        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int curow = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgvNhanVien.Rows[curow].Cells[0].Value.ToString();
            txtPass.Text = dgvNhanVien.Rows[curow].Cells[1].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[curow].Cells[2].Value.ToString();
            if (dgvNhanVien.Rows[curow].Cells[3].Value.ToString() == "Nam")
                rbtNam.Checked = true;
            else
                rbtNu.Checked = true;
            txtSDT.Text = dgvNhanVien.Rows[curow].Cells[4].Value.ToString();
            txtEmail.Text = dgvNhanVien.Rows[curow].Cells[5].Value.ToString();
            cbbChucVu.Text = dgvNhanVien.Rows[curow].Cells[6].Value.ToString();
            txtMaNV.Enabled = false;
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
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM NHANVIEN", myClass.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "NV";
            Random rand = new Random();
            string random = (rand.Next(99999)).ToString();

            return ma + random;
        }

        
        public void clear()
        {

            txtMaNV.Text = "";
            txtPass.Focus();
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cbbChucVu.SelectedValue = "Nhân Viên";
            #region Tong NV
            //int sc = dgvNhanVien.Rows.Count;
            //double tongNV = 0;
            //for (int i = 0; i < sc - 1; i++)
            //{
            //    tongNV++;
            //}
            //lblKQ.Text = tongNV.ToString() + " NV";
            #endregion
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
        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            bbtnThem.Enabled = true;
            bbtnLuu.Enabled = true;
            txtMaNV.Text = TangMa();
            txtPass.Focus();
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            Application.Exit();

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
                if (txtPass.Text == "" ||
                txtHoTen.Text == "" ||
                txtSDT.Text == "" ||
                txtEmail.Text == "" ||
                cbbChucVu.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                }
                DBMFStudios context = new DBMFStudios();
                CHUCVU temp = cbbChucVu.SelectedItem as CHUCVU;
                NHANVIEN find = context.NHANVIENs.FirstOrDefault(p => p.MANV == txtMaNV.Text);
                if (find == null)
                {
                    NHANVIEN nv = new NHANVIEN();
                    nv.MANV = TangMa();
                    nv.PASS = txtPass.Text;
                    nv.HOTEN = txtHoTen.Text;
                    if (rbtNam.Checked == true)
                        nv.GIOITINH = true;
                    else
                        nv.GIOITINH = false;
                    nv.SDT = txtSDT.Text;
                    nv.EMAIL = txtEmail.Text;
                    nv.MACV = temp.MACV;
                    context.NHANVIENs.Add(nv);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Nhân viên thành công!");
                }
                else
                {
                    find.PASS = txtPass.Text;
                    find.HOTEN = txtHoTen.Text;
                    find.MACV = temp.MACV;
                    if (rbtNam.Checked == true)
                        find.GIOITINH = true;
                    else
                        find.GIOITINH = false;
                    find.SDT = txtSDT.Text;
                    find.EMAIL = txtEmail.Text;
                    context.NHANVIENs.AddOrUpdate(find);
                    context.SaveChanges();
                    MessageBox.Show("Update Nhân Viên thành công!");
                }
                BindGird(context.NHANVIENs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

   
        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.NHANVIENs.Where(p => p.HOTEN.Contains(txtTimKiem.Text) || p.MANV.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }
    }
}
