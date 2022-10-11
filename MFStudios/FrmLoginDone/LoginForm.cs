using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MFStudios.Models;
using static DevExpress.XtraEditors.Mask.MaskSettings;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Net.Mail;
using System.Net;
using MFStudios.Models;

namespace MFStudios
{
    
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        string radomCode;
        public static string touser;
        public static string toemail;
        public static string getUserlogin;

        public LoginForm()
        {
            Thread frmStart = new Thread(new ThreadStart(StartForm));
            frmStart.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            frmStart.Abort();
            txtPass.UseSystemPasswordChar = false;
            grbSendCode.Visible = false;

        }
        public void StartForm()
        {
            Application.Run(new frmStaring());
        }

        #region Login
        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPass.Checked)
            {
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

  

        private void pctLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=LAPTOP-0APB0UV0\\SQLEXPRESS;Initial Catalog=TestLogin;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from NhanVien where MaNV = @MaNV and pass = @pass", con);
                    cmd.Parameters.AddWithValue("@MaNV", txtUserName.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("login successfull");
                        getUserlogin = txtUserName.Text; 
                        frmMain frm = new frmMain();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("UserName or PassWord is invaid");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void lblForgetPass_Click_1(object sender, EventArgs e)
        {
            grbSendCode.Visible = true;
           
            
        }

        private void pctSendCode_Click(object sender, EventArgs e)
        {
            try
            {
                DBNhanVien context = new DBNhanVien();
                NhanVien find = context.NhanVien.FirstOrDefault(p => p.MaNV == txtsendUser.Text);
                if (find != null)
                {
                    string messageBody;
                    Random rand = new Random();
                    radomCode = (rand.Next(999999)).ToString();
                    SmtpClient smtp = new SmtpClient();
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("security@mfstudios.vn", "MF@@130622mf");
                    smtp.Host = "pro51.emailserver.vn";
                    toemail = find.gmail;
                    MailMessage message = new MailMessage();
                    message.From = new System.Net.Mail.MailAddress("security@mfstudios.vn");
                    message.To.Add(new MailAddress("security@mfstudios.vn"));
                    message.IsBodyHtml = true;
                    messageBody = "Your verify code is " + radomCode;
                    message.Subject = "NoReply - Password Reseting Code";
                    message.Body = messageBody;
                    message.To.Add(toemail);
                    smtp.Send(message);
                    MessageBox.Show("code send successfully");
                }
                else
                {
                    MessageBox.Show("Wrong UserName!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pctVerifyCode_Click(object sender, EventArgs e)
        {
            if (radomCode == (txtCode.Text).ToString())
            {
                touser = txtsendUser.Text;
                ResetPW rp = new ResetPW();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Verify Code");
            }
        }
    }

    #endregion
    
}