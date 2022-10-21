using DevExpress.XtraBars;
using MFStudios.Models;
using MFStudios.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace MFStudios
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
     
        string MaNV = LoginForm.getUserlogin;
        public frmMain()
        {
            
            InitializeComponent();   
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlDataReader dt = null;
            PhanQuyen();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=RIN\\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select HOTEN,  MACV from NHANVIEN where MaNV ='" + MaNV + "' ", con);
                con.Open();
                dt = cmd.ExecuteReader();
                while (dt.Read())
                {
                    string UserName = (string)dt["HOTEN"];
                    bsiUserName.Caption = UserName;
                }
            }
            catch
            {
                if ( dt != null)
                {
                    dt.Close();
                }
            }

            
        }

        public void PhanQuyen()
        {
            SqlConnection con = new SqlConnection("Data Source=RIN\\SQLEXPRESS;Initial Catalog=DBMFSTUDIOS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select HOTEN,  MACV from NHANVIEN where MaNV ='" + MaNV + "' ", con);
            con.Open();
            SqlDataReader dc = null;
            dc = cmd.ExecuteReader();
            while (dc.Read())
            {
                string CV = (string)dc["MACV"];
                if (CV == "QL")
                {
                    aceNhanVien.Visible = true;
                    aceThietBi.Visible = true;
                    aceLoaiThietBi.Visible = true;
                }
                else if (CV == "NV")
                {
                    aceNhanVien.Visible = false;
                    aceThietBi.Visible = false;
                    aceLoaiThietBi.Visible = false;
                }
            }
        }

        uc_NhanVien ucNhanVien;
        uc_ThietBi ucThietBi;
        uc_LoaiThietBi ucLoaiThietBi;
        uc_KhachHang ucKhachHang;
        uc_ThueThietBi ucThueThietBi;
        uc_HoaDon ucHoaDon;
        uc_ThongKe ucThongKe;
        private void aceNhanVien_Click(object sender, EventArgs e)
        {
            if (ucNhanVien == null)
            {
                ucNhanVien = new uc_NhanVien();
                ucNhanVien.Dock= DockStyle.Fill;
                mainContainer.Controls.Add(ucNhanVien);
                ucNhanVien.BringToFront();
            }
            else
            {
                ucNhanVien.BringToFront();
            }
            lblTieuDe.Caption = aceNhanVien.Text;
        }

        private void aceThietBi_Click(object sender, EventArgs e)
        {
            if (ucThietBi == null)
            {
                ucThietBi = new uc_ThietBi();
                ucThietBi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucThietBi);
                ucThietBi.BringToFront();
            }
            else
            {
                ucThietBi.BringToFront();
            }
            lblTieuDe.Caption = aceThietBi.Text;
        }

        private void aceLoaiThietBi_Click(object sender, EventArgs e)
        {
            if (ucLoaiThietBi == null)
            {
                ucLoaiThietBi = new uc_LoaiThietBi();
                ucLoaiThietBi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucLoaiThietBi);
                ucLoaiThietBi.BringToFront();
            }
            else
            {
                ucLoaiThietBi.BringToFront();
            }
            lblTieuDe.Caption = aceLoaiThietBi.Text;
        }

        private void aceKhachHang_Click(object sender, EventArgs e)
        {
            if (ucKhachHang == null)
            {
                ucKhachHang = new uc_KhachHang();
                ucKhachHang.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucKhachHang);
                ucKhachHang.BringToFront();
            }
            else
            {
                ucKhachHang.BringToFront();
            }
            lblTieuDe.Caption = aceKhachHang.Text;
        }

        private void aceThueThietBi_Click(object sender, EventArgs e)
        {
            if (ucThueThietBi == null)
            {
                ucThueThietBi = new uc_ThueThietBi();
                ucThueThietBi.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucThueThietBi);
                ucThueThietBi.BringToFront();
            }
            else
            {
                ucThueThietBi.BringToFront();
            }
            lblTieuDe.Caption = aceThueThietBi.Text;
        }

        private void aceHoaDon_Click(object sender, EventArgs e)
        {
            if (ucHoaDon == null)
            {
                ucHoaDon = new uc_HoaDon();
                ucHoaDon.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucHoaDon);
                ucHoaDon.BringToFront();
            }
            else
            {
                ucHoaDon.BringToFront();
            }
            lblTieuDe.Caption = aceHoaDon.Text;
        }

        private void bbtnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            ResetPW rp = new ResetPW();
            rp.Show();
            
        }

        private void bbtnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoginForm lg = new LoginForm();
            this.Close();
            lg.Show();
        }

        private void aceThongKe_Click(object sender, EventArgs e)
        {
            if (ucThongKe == null)
            {
                ucThongKe = new uc_ThongKe();
                ucThongKe.Dock = DockStyle.Fill;
                mainContainer.Controls.Add(ucThongKe);
                ucThongKe.BringToFront();
            }
            else
            {
                ucThongKe.BringToFront();
            }
            lblTieuDe.Caption = aceThongKe.Text;
        }

        private void aceThongTin_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            String tt = "";
            tt += "Phần mềm : Quản lý Thuê Thiết Bị MFStudios  \n";
            tt += "\n\n";
            tt += " Học phần : Công Nghệ Phần Mềm ";
            tt += "\t";
            tt += "\n\n";
            tt += "____Đồ án Môn học____";
            tt += "\n";
            tt += "\nSinh viên thực hiện : - Trần Thiên Phúc, Nguyễn Xuân Toản, Nguyễn Quốc Tường, Trần Duy Anh";
            tt += "\nVersion : 1.1 năm " + currentYear + "  \n\n";
            tt += "Liên hệ để được hỗ trợ : 0896416809";
            tt += "\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
        }
    }
}
