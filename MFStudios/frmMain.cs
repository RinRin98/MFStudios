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
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-0APB0UV0\\SQLEXPRESS;Initial Catalog=TestLogin;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Select HOTEN from NhanVien where MaNV = '" + MaNV + "' ", con);
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
        uc_NhanVien ucNhanVien;
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
    }
}
