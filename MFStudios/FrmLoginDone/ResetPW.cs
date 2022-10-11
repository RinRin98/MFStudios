using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace MFStudios
{
    public partial class ResetPW : DevExpress.XtraEditors.XtraForm
    {
        string MaNV = LoginForm.touser;
        public ResetPW()
        {
            InitializeComponent();
        }

        private void pctResetpw_Click(object sender, EventArgs e)
        {
            if (txtNewPW.Text == txtconfirmPW.Text)
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-0APB0UV0\\SQLEXPRESS;Initial Catalog=TestLogin;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[NhanVien]\r\n   SET  [pass] = '"+ txtNewPW.Text + "' WHERE MaNV = '" + MaNV + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Reset PW successfully");
                LoginForm frm = new LoginForm();
                this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Password Không Khớp");
            }
        }
    }
}