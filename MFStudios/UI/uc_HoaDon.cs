using DevExpress.XtraReports.UI;
using MFStudios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFStudios.UI
{
    public partial class uc_HoaDon : UserControl
    {
        
        public uc_HoaDon()
        {
            InitializeComponent();
            
        }
        public static string con = @"Data Source=RIN\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True";
        private void uc_HoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                DBMFStudios context = new DBMFStudios();
                var listHD = context.HOADONs.ToList();
                BindGird(context.HOADONs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtTenKH.Text = dgvHoaDon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtTTThue.Text = dgvHoaDon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                dtpThue.Value = Convert.ToDateTime(row.Cells[3].Value.ToString());
                dtpTra.Value = Convert.ToDateTime(row.Cells[4].Value.ToString());
                txtTongTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            }
        }
        private void BindGird(List<HOADON> listHD)
        {
            dgvHoaDon.Rows.Clear();
            foreach (HOADON s in listHD)
            {
                int row = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[row].Cells[0].Value = s.MAHD;
                dgvHoaDon.Rows[row].Cells[1].Value = s.KHACHHANG.TENKH;
                dgvHoaDon.Rows[row].Cells[2].Value = s.THONGTINDONHANG;
                dgvHoaDon.Rows[row].Cells[3].Value = s.NGAYTHUE;
                dgvHoaDon.Rows[row].Cells[4].Value = s.NGAYHENTRA;
                dgvHoaDon.Rows[row].Cells[5].Value = s.TONGTIEN;
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTien.Text == "" || txtTongTien.Text == "0") return;
            decimal number;
            number = decimal.Parse(txtTongTien.Text, System.Globalization.NumberStyles.Currency);
            txtTongTien.Text = number.ToString("#,#");
            txtTongTien.SelectionStart = txtTongTien.Text.Length;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DBMFStudios context = new DBMFStudios();

            var listTimkiem = context.HOADONs.Where(p => p.MAHD.Contains(txtTimKiem.Text) || p.KHACHHANG.TENKH.Contains(txtTimKiem.Text)).ToList();
            BindGird(listTimkiem);
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        

        

        private void btnXuatHoaDon_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DBMFStudios context = new DBMFStudios();
            var HoaDon = context.HOADONs.Where(p => p.MAHD == txtMaHD.Text).ToList();
            InHoaDon ihd = new InHoaDon(HoaDon);
            ihd.ShowPreview();
        }

        private void btnXuatExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (dgvHoaDon.RowCount == 0)
                {
                    MessageBox.Show("Danh sách trống không thể Lưu Hóa Đơn vào Excel!");
                }
                else
                {
                    string duongdan = "";
                    DateTime ngay = DateTime.Now;
                    string tim = ngay.ToString();
                    string randomNameFile = tim.Replace(" ", "_").Replace("/", "-").Replace(":", "-");
                    XuatExcel.exportecxelhoadon(dgvHoaDon, duongdan, randomNameFile);
                    MessageBox.Show("Xuất file thành công ", "Thông báo ", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể xuất file! Lỗi: " + ex.Message, "Thông báo");
            }
        }
    }
}
