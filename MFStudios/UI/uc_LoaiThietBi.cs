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
using MFStudios.Models;

namespace MFStudios.UI
{
    public partial class uc_LoaiThietBi : UserControl
    {
        public static string con = @"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";
        public uc_LoaiThietBi()
        {
            InitializeComponent();
        }

        private void uc_LoaiThietBi_Load(object sender, EventArgs e)
        {
            try
            {
                DBMFStudios context = new DBMFStudios();
                var listTB = context.LOAITHIETBIs.ToList();
                BindGird(context.LOAITHIETBIs.ToList());
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGird(List<LOAITHIETBI> listTB)
        {
            dgvLoaiTB.Rows.Clear();
            foreach (LOAITHIETBI s in listTB)
            {

                int row = dgvLoaiTB.Rows.Add();

                dgvLoaiTB.Rows[row].Cells[0].Value = s.MALOAI;
                dgvLoaiTB.Rows[row].Cells[1].Value = s.TENLOAI;
            }
        }

        private void dgvLoaiTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLoaiTB.Rows[e.RowIndex];

                txtMaLoai.Text = dgvLoaiTB.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenLoai.Text = dgvLoaiTB.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtMaLoai.Enabled = false;
                bbtThem.Enabled = true;
                bbtLuu.Enabled = true;
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
            SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM LOAITHIETBI", myClass.mycon);
            //khởi tạo một instance của class DataTable
            DataTable dt = new DataTable();
            //sử dụng phương thức fill để điền dữ liệu vào bảng
            ad.Fill(dt);
            string ma = "LTB";
            Random rand = new Random();
            string random = (rand.Next(9999)).ToString();

            return ma + random;
        }
        public void clear()
        {

            txtMaLoai.Text = "";
            txtTenLoai.Focus();
        }

        private void bbtThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear();
            bbtThem.Enabled = true;
            bbtLuu.Enabled = true;
            txtMaLoai.Text = TangMa();
            txtTenLoai.Enabled = true;
            txtTenLoai.Focus();
        }

        private void bbtThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void bbtLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                if (txtMaLoai.Text == "" ||
                txtTenLoai.Text == "" 
                )
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                }
                DBMFStudios context = new DBMFStudios();

                LOAITHIETBI find = context.LOAITHIETBIs.FirstOrDefault(p => p.MALOAI == txtMaLoai.Text);
                if (find == null)
                {
                    LOAITHIETBI tb = new LOAITHIETBI();
                    tb.MALOAI = TangMa();
                    tb.TENLOAI = txtTenLoai.Text;
                    context.LOAITHIETBIs.Add(tb);
                    context.SaveChanges();
                    MessageBox.Show("Thêm Loại Thiết Bị thành công!");
                }
                else
                {
                    find.MALOAI = txtMaLoai.Text;
                    find.TENLOAI = txtTenLoai.Text;
                    context.LOAITHIETBIs.AddOrUpdate(find);
                    context.SaveChanges();
                    MessageBox.Show("Update Loại Thiết Bị thành công!");
                }
                BindGird(context.LOAITHIETBIs.ToList());
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

            var listTimkiem = context.LOAITHIETBIs.Where(p => p.MALOAI.Contains(txtTimKiem.Text) || p.TENLOAI.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }
    }
}
