using DevExpress.XtraReports.UI;
using MFStudios.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace MFStudios.UI
{
    public partial class InHoaDon : DevExpress.XtraReports.UI.XtraReport
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        public InHoaDon(List<HOADON> listHD)
        {
            InitializeComponent();
            DataSource = listHD;
        }
    }
}
