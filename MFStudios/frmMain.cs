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
                }
                else if (CV == "NV")
                {
                    aceNhanVien.Visible = false;
                }
            }
        }

        uc_NhanVien ucNhanVien;
        uc_ThietBi ucThietBi;
        uc_LoaiThietBi ucLoaiThietBi;
        uc_KhachHang ucKhachHang;
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
    }
}
