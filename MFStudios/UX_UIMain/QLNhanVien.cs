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

namespace MFStudios.UX_UIMain
{
    public partial class QLNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void grvThongTin_Load(object sender, EventArgs e)
        {
          //  grvThongTin.DataSource = myClass.GetData("SELECT * from NhanVien");
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {

        }
    }
}