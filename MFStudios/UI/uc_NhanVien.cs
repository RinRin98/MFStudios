using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFStudios.UI
{
    public partial class uc_NhanVien : UserControl
    {
        public uc_NhanVien()
        {
            InitializeComponent();
        }

        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            gcDanhSach.DataSource = myClass.GetData("SELECT * from NhanVien");

        }
    }
}
