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
        public uc_ThietBi()
        {
            InitializeComponent();
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
            if (KetNoi("MSI\\SQLEXPRESS", "DBMFSTUDIOS") == false)
            {
                MessageBox.Show("Nhấn OK để thoát chương trình", "Không kết nối được CSDL!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Application.Exit();
            }
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM THIETBI", myClass.mycon);
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
                    ma = ma + "0";
                }
                else if (k < 100)
                {
                    ma = ma + "00";
                }
                ma = ma + k.ToString();
            }
            return ma;
        }
        public void clear()
        {

            txtMaTB.Text = "";
            txtTenThietBi.Focus();
            txtSoLuong.Text = "";
            cbbMoTa.SelectedValue = "Mới";
            cbbTinhTrang.SelectedValue = "Chưa cho thuê";
            txtGiaTri.Text = "";
            txtGiaThue.Text = "";
            loaitb();
            #region Tong TB
            //int sc = dgvThietBi.Rows.Count;
            //double tongTB = 0;
            //for (int i = 0; i < sc - 1; i++)
            //{
            //    tongTB++;
            //}
            //lblKQ.Text = tongTB.ToString() + " TB";
            #endregion
        }
        private void loaitb()
        {
            string load_loaitb = "Select maloai, tenloai from loaithietbi";
            myClass.xulycbx(load_loaitb, cbbLoaiTB);
            cbbLoaiTB.DisplayMember = "tenloai";
            cbbLoaiTB.ValueMember = "maloai";
        }

        private void bbtnThemTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            bbtnThemTB.Enabled = true;
            bbtnLuuTB.Enabled = true;
            txtMaTB.Text = TangMa();
            txtTenThietBi.Focus();
        }
        private void BindGird(List<THIETBI> listTB)
        {
            dgvThietBi.Rows.Clear();
            foreach (THIETBI s in listTB)
            {
                int row = dgvThietBi.Rows.Add();
                dgvThietBi.Rows[row].Cells[0].Value = s.MATB;
                dgvThietBi.Rows[row].Cells[1].Value = s.TENTB;
                dgvThietBi.Rows[row].Cells[2].Value = s.SOLUONG;
                dgvThietBi.Rows[row].Cells[3].Value = s.MOTA;
                dgvThietBi.Rows[row].Cells[4].Value = s.TINHTRANG;
                dgvThietBi.Rows[row].Cells[5].Value = s.GIATRITB;
                dgvThietBi.Rows[row].Cells[6].Value = s.GIATHUE;
                dgvThietBi.Rows[row].Cells[7].Value = s.LOAITHIETBI.TENLOAI;
            }
        }
        private void bbtnLuuTB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                
                if (txtTenThietBi.Text == "" ||
                txtSoLuong.Text == "" ||
                cbbMoTa.Text == "" ||
                cbbTinhTrang.Text == "" ||
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
                    tb.SOLUONG = int.Parse(txtSoLuong.Text);
                    tb.MOTA = cbbMoTa.ToString();
                    tb.TINHTRANG = cbbTinhTrang.ToString();
                    tb.GIATRITB=int.Parse(txtGiaTri.Text);
                    tb.GIATHUE = int.Parse(txtGiaThue.Text);
                    tb.MALOAI = temp.TENLOAI;
                    context.THIETBIs.Add(tb);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Thiết Bị thành công!");
                }
                else
                {
                    find.TENTB = txtTenThietBi.Text;
                    find.SOLUONG = int.Parse(txtSoLuong.Text);
                    find.MOTA = cbbMoTa.ToString();                  
                    find.TINHTRANG = cbbTinhTrang.ToString();
                    find.GIATRITB = int.Parse(txtGiaTri.Text);
                    find.GIATHUE = int.Parse(txtGiaThue.Text);
                    find.MALOAI = temp.TENLOAI;
                    context.THIETBIs.AddOrUpdate(find);
                    context.SaveChanges();
                    MessageBox.Show("Update Thiết Bị thành công!");
                }
                BindGird(context.THIETBIs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Không Tìm thấy thiết bị cần xóa!");
            }
            BindGird(context.THIETBIs.ToList());
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }


        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dgvThietBi.CurrentRow.Index;
            txtMaTB.Text = dgvThietBi.Rows[curow].Cells[0].Value.ToString();
            txtTenThietBi.Text = dgvThietBi.Rows[curow].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvThietBi.Rows[curow].Cells[2].Value.ToString();           
            cbbMoTa.Text = dgvThietBi.Rows[curow].Cells[3].Value.ToString();
            cbbTinhTrang.Text = dgvThietBi.Rows[curow].Cells[4].Value.ToString();
            txtGiaTri.Text = dgvThietBi.Rows[curow].Cells[5].Value.ToString();
            txtGiaThue.Text= dgvThietBi.Rows[curow].Cells[6].Value.ToString();
            cbbLoaiTB.Text= dgvThietBi.Rows[curow].Cells[7].Value.ToString();
            txtMaTB.Enabled = false;
            bbtnThemTB.Enabled = true;
            bbtnLuuTB.Enabled = true;
            bbtnXoaTB.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.THIETBIs.Where(p => p.TENTB.Contains(txtTimKiem.Text) || p.MATB.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }
    }
}
