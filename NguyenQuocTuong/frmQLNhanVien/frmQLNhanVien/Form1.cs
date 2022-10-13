using frmQLNhanVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frmQLNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                NhanVienDBcontext context = new NhanVienDBcontext();
                var listNhanVien = context.NHANVIEN.ToList();                              
                NVdgv(listNhanVien);                
                var listChucVu = context.CHUCVU.ToList();
                FillChucVu(listChucVu);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        private void NVdgv(List<NHANVIEN> listNhanViens)
        {
            dgvNhanVien.Rows.Clear();
            foreach (NHANVIEN s in listNhanViens)
            {
                int row = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[row].Cells[0].Value = s.MANV;
                dgvNhanVien.Rows[row].Cells[1].Value = s.PASS;
                dgvNhanVien.Rows[row].Cells[2].Value = s.HOTEN;
                if (s.GIOITINH == true)
                    dgvNhanVien.Rows[row].Cells[3].Value = "Nam";
                else
                    dgvNhanVien.Rows[row].Cells[3].Value = "Nữ";
                dgvNhanVien.Rows[row].Cells[4].Value = s.CHUCVU;
                dgvNhanVien.Rows[row].Cells[5].Value = s.SDT;
                dgvNhanVien.Rows[row].Cells[6].Value = s.EMAIL_NV;
            }
        }
        //
        private void FillChucVu(List<CHUCVU> listChucVus)
        {
            this.cbbChucVu.DataSource = listChucVus;
            this.cbbChucVu.DisplayMember = "TENCV";
            this.cbbChucVu.ValueMember = "MACV";
        }
        //
        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVienDBcontext context = new NhanVienDBcontext();
            NHANVIEN find = context.NHANVIEN.FirstOrDefault(p => p.MANV == txtMaSo.Text);
            if (find != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    context.NHANVIEN.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không Tìm thấy nhân viên cần xóa!");
            }
            NVdgv(context.NHANVIEN.ToList());
        }    
        //
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaSo.Text = dgvNhanVien.Rows[numrow].Cells[0].Value.ToString();
            txtPass.Text = dgvNhanVien.Rows[numrow].Cells[1].Value.ToString();
            txtHoTen.Text = dgvNhanVien.Rows[numrow].Cells[2].Value.ToString();
            if (dgvNhanVien.Rows[numrow].Cells[3].Value.ToString() == "Nam")
                rbtnNam.Checked = true;
            else
                rbtnNu.Checked = true;
            cbbChucVu.Text = dgvNhanVien.Rows[numrow].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[numrow].Cells[5].Value.ToString();
            txtMail.Text = dgvNhanVien.Rows[numrow].Cells[6].Value.ToString();
        }
        //
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtrasodienthoai(txtSDT.Text) == false)
                {
                    MessageBox.Show("Sai định dạng số Email!", "Thông báo");
                    return;
                }
                if (kiemtraMail(txtMail.Text) == false)
                {
                    MessageBox.Show("Sai định dạng số Email!", "Thông báo");
                    return;
                }


                CHUCVU temp = cbbChucVu.SelectedItem as CHUCVU;
                    NhanVienDBcontext context = new NhanVienDBcontext();
                    NHANVIEN find = context.NHANVIEN.FirstOrDefault(p => p.MANV == txtMaSo.Text);
                    if (find == null)
                    {
                        NHANVIEN nv = new NHANVIEN();
                        nv.MANV = txtMaSo.Text;
                        nv.PASS = txtPass.Text;
                        nv.HOTEN = txtHoTen.Text;
                        if (rbtnNam.Checked == true)
                            nv.GIOITINH = true;
                        else
                            nv.GIOITINH = false;
                        nv.SDT = txtSDT.Text;
                        nv.EMAIL_NV = txtMail.Text;
                        context.NHANVIEN.Add(nv);
                        context.SaveChanges();
                        MessageBox.Show("Thêm Nhân viên thành công!");
                    }
                    else
                    {
                        find.PASS = txtPass.Text;
                        find.HOTEN = txtHoTen.Text;
                        find.CHUCVU = temp.TENCV;
                        if (rbtnNam.Checked == true)
                            find.GIOITINH = true;
                        else
                            find.GIOITINH = false;
                        find.SDT = txtSDT.Text;
                        find.EMAIL_NV = txtMail.Text;
                        context.NHANVIEN.AddOrUpdate(find);
                        context.SaveChanges();
                        MessageBox.Show("Update Nhân Viên thành công!");
                    }
                    NVdgv(context.NHANVIEN.ToList());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //
        NhanVienDBcontext context = new NhanVienDBcontext();
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var listTimkiem = context.NHANVIEN.Where(p => p.HOTEN.Contains(txtTimKiem.Text)).ToList();
            NVdgv(listTimkiem);

        }
        string phonenumber = @"^([+84|84|0]{1})+([3|5|7|8|9]{1})+([0-9]{8})$";
        public bool kiemtrasodienthoai(string number)
        {
            if (number != null) return Regex.IsMatch(number, phonenumber);
            else return false;
        }
        //
        public bool kiemtraMail(string email)
        {
            Regex regex = new Regex(@"^[\w-.]+@([\w-]+.)+[\w-]{2,4}$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;            
        }
        //
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
        //
        public string TangMa()
        {
            if (KetNoi("LAPTOP-0APB0UV0\\SQLEXPRESS", "DBMFSTUDIOS") == false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
            SqlDataAdapter ad = new SqlDataAdapter("select * from NHANVIEN", ChuoiKetNoi.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "NV001";
            }
            else
            {
                int k;
                ma = "NV";
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
        // 
        public void clear()
        {
            dgvNhanVien.Columns[0].Width = 110;
            dgvNhanVien.Columns[1].Width = 150;
            dgvNhanVien.Columns[2].Width = 110;
            dgvNhanVien.Columns[3].Width = 110;
            dgvNhanVien.Columns[4].Width = 110;
            dgvNhanVien.Columns[5].Width = 110;
            dgvNhanVien.Columns[6].Width = 110;                       
            txtMaSo.Text = "";
            txtPass.Focus();
            txtHoTen.Text = "";
            txtSDT.Text = "";            
            txtMail.Text = "";                        
            int sc = dgvNhanVien.Rows.Count;
            double tongTB = 0;
            for (int i = 0; i < sc - 1; i++)
            {
                tongTB++;
            }
            lblKQ.Text = tongTB.ToString() + " TB";
        }
        //
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }
    }
}
