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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFStudios.UI
{
    public partial class uc_ThietBi : UserControl
    {
        public static string con = @"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";
        public uc_ThietBi()
        {
            InitializeComponent();
        }

        private void uc_ThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                DBMFStudios context = new DBMFStudios();
                var listTB = context.THIETBIs.ToList();
                var listLTB = context.LOAITHIETBIs.ToList();
                cbbLoaiTB.DataSource = listLTB;
                cbbLoaiTB.DisplayMember = "TENLOAI";
                cbbLoaiTB.ValueMember = "MALOAI";
                BindGird(context.THIETBIs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGird(List<THIETBI> listTB)
        {
            dgvThietBi.Rows.Clear();
            foreach (THIETBI s in listTB)
            {
                
                int row = dgvThietBi.Rows.Add();
              
                dgvThietBi.Rows[row].Cells[0].Value = s.MATB;
                dgvThietBi.Rows[row].Cells[1].Value = s.TENTB;
                dgvThietBi.Rows[row].Cells[2].Value = s.GIATRITB;
                dgvThietBi.Rows[row].Cells[3].Value = s.GIATHUE;
                dgvThietBi.Rows[row].Cells[4].Value = s.LOAITHIETBI.TENLOAI;

            }
        }

        private void bbtnXoaTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBMFStudios context = new DBMFStudios();
            THIETBI find = context.THIETBIs.FirstOrDefault(p => p.MATB == txtMaTB.Text);
            if (find != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    context.THIETBIs.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không Tìm thấy nhân viên cần xóa!");
            }
            BindGird(context.THIETBIs.ToList());
        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThietBi.Rows[e.RowIndex];

                txtMaTB.Text = dgvThietBi.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenThietBi.Text = dgvThietBi.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            
                txtGiaTri.Text = dgvThietBi.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtGiaThue.Text = dgvThietBi.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cbbLoaiTB.Text = dgvThietBi.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

                txtMaTB.Enabled = false;
                bbtnThemTB.Enabled = true;
                bbtnSua.Enabled = true;
                bbtnXoaTB.Enabled = true;
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
            string ma = "TB";
            Random rand = new Random();
            string random = (rand.Next(9999)).ToString();

            return ma + random;
        }
        public void clear()
        {

            txtMaTB.Text = "";
            txtTenThietBi.Focus();
         
            txtGiaTri.Text = "";
            txtGiaThue.Text = "";
            cbbLoaiTB.SelectedValue = "";
        }

        private void bbtnThemTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            bbtnThemTB.Enabled = true;
            bbtnLuuTB.Enabled = true;
            txtMaTB.Text = TangMa();
            txtMaTB.Focus();
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void bbtnLuuTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (txtTenThietBi.Text == "" ||
                
                txtGiaTri.Text == "" ||
                txtGiaThue.Text == "" ||
                cbbLoaiTB.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                }
                DBMFStudios context = new DBMFStudios();
                LOAITHIETBI temp = cbbLoaiTB.SelectedItem as LOAITHIETBI;
                THIETBI find = context.THIETBIs.FirstOrDefault(p => p.MATB == txtMaTB.Text);
                if (find == null)
                {
                    THIETBI tb = new THIETBI();
                    tb.MATB = TangMa();
                    tb.TENTB = txtTenThietBi.Text;
                  
                    tb.GIATRITB = int.Parse(txtGiaTri.Text);
                    tb.GIATHUE = int.Parse(txtGiaThue.Text);
                    tb.MALOAI = temp.MALOAI;
                    context.THIETBIs.Add(tb);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Thiết Bị thành công!");
                }
                else
                {
                    find.TENTB = txtTenThietBi.Text;
                 
                    find.GIATRITB = int.Parse(txtGiaTri.Text);
                    find.GIATHUE = int.Parse(txtGiaThue.Text);
                    find.MALOAI = temp.MALOAI;
                    context.THIETBIs.AddOrUpdate(find);
                    context.SaveChanges();
                    MessageBox.Show("Update Thiết Bị thành công!");
                }
                BindGird(context.THIETBIs.ToList());
                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.THIETBIs.Where(p => p.MATB.Contains(txtTimKiem.Text) || p.TENTB.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }
    }
}
