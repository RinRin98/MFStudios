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
    public partial class uc_LoaiThietBi : UserControl
    {
        public uc_LoaiThietBi()
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
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM LOAITHIETBI", myClass.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "LT001";
            }
            else
            {
                int k;
                ma = "LT";
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

            txtMaLoai.Text = "";
            txtTenThietBi.Focus();
            txtTenThietBi.Text = "";
        
            #region Tong LTB
            //int sc = dgvLoaiThietBi.Rows.Count;
            //double tongLTB = 0;
            //for (int i = 0; i < sc - 1; i++)
            //{
            //    tongLTB++;
            //}
            //lblKQ.Text = tongLTB.ToString() + " LTB";
            #endregion
        }

        private void bbtnThemLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            bbtnThemLoai.Enabled = true;
            bbtnLuuLoai.Enabled = true;
            txtMaLoai.Text = TangMa();
            txtTenLoai.Focus();
        }
        private void BindGird(List<LOAITHIETBI> listLTB)
        {
            dgvLoaiThietBi.Rows.Clear();
            foreach (LOAITHIETBI s in listLTB)
            {
                int row = dgvLoaiThietBi.Rows.Add();
                dgvLoaiThietBi.Rows[row].Cells[0].Value = s.MALOAI;
                dgvLoaiThietBi.Rows[row].Cells[1].Value = s.TENLOAI;
              
            }
        }
        private void bbtnLuuLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtTenLoai.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                }
                DBMFStudios context = new DBMFStudios();
               
                LOAITHIETBI find = context.LOAITHIETBIs.FirstOrDefault(p => p.MALOAI == txtMaLoai.Text);
                if (find == null)
                {
                    LOAITHIETBI ltb = new LOAITHIETBI();
                    ltb.MALOAI = TangMa();
                    ltb.TENLOAI = txtTenLoai.Text;
                    context.LOAITHIETBIs.Add(ltb);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Loại Thiết Bị thành công!");
                }
                else
                {
                    find.TENLOAI = txtTenLoai.Text;
                    context.LOAITHIETBIs.AddOrUpdate(find);
                    context.SaveChanges();
                    MessageBox.Show("Update Loại Thiết Bị thành công!");
                }
                BindGird(context.LOAITHIETBIs.ToList());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bbtnXoaLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBMFStudios context = new DBMFStudios();
            LOAITHIETBI find = context.LOAITHIETBIs.FirstOrDefault(p => p.MALOAI == txtMaLoai.Text);
            if (find != null)
            {
                DialogResult dr = MessageBox.Show("Bạn có muốn xóa ?", "YES/NO", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    context.LOAITHIETBIs.Remove(find);
                    context.SaveChanges();
                    MessageBox.Show("Xóa Loại Thiết Bị thành công!", "Thông Báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không Tìm thấy thiết bị cần xóa!");
            }
            BindGird(context.LOAITHIETBIs.ToList());
        }

        private void bbtnThoatLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void dgvLoaiThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curow = dgvLoaiThietBi.CurrentRow.Index;
            txtMaLoai.Text = dgvLoaiThietBi.Rows[curow].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiThietBi.Rows[curow].Cells[1].Value.ToString();          
            txtMaTB.Enabled = false;
            bbtnThemLoai.Enabled = true;
            bbtnLuuLoai.Enabled = true;
            bbtnXoaLoai.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.LOAITHIETBIs.Where(p => p.TENLOAI.Contains(txtTimKiem.Text) || p.TENLOAI.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }
    }
}
