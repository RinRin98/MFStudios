namespace MFStudios.UI
{
    partial class uc_HoaDon
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_HoaDon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnXuatExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnXuatHoaDon = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbHoaDon = new DevExpress.XtraEditors.GroupControl();
            this.txtTTThue = new System.Windows.Forms.TextBox();
            this.dtpTra = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dtpThue = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTTThue = new System.Windows.Forms.Label();
            this.lblTra = new System.Windows.Forms.Label();
            this.lblThue = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbHoaDon)).BeginInit();
            this.grbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXuatExcel,
            this.bbtnThoat,
            this.btnXuatHoaDon});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuatExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXuatHoaDon, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Caption = "Xuất Excel";
            this.btnXuatExcel.Id = 0;
            this.btnXuatExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.Image")));
            this.btnXuatExcel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.ImageOptions.LargeImage")));
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatExcel_ItemClick);
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.Caption = "Xuất hóa đơn";
            this.btnXuatHoaDon.Id = 2;
            this.btnXuatHoaDon.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXuatHoaDon.ImageOptions.SvgImage")));
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXuatHoaDon_ItemClick_1);
            // 
            // bbtnThoat
            // 
            this.bbtnThoat.Caption = "Thoát";
            this.bbtnThoat.Id = 1;
            this.bbtnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtnThoat.ImageOptions.Image")));
            this.bbtnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtnThoat.ImageOptions.LargeImage")));
            this.bbtnThoat.Name = "bbtnThoat";
            this.bbtnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(995, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 592);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(995, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(995, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbHoaDon);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHoaDon);
            this.splitContainer1.Size = new System.Drawing.Size(995, 568);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 4;
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.txtTTThue);
            this.grbHoaDon.Controls.Add(this.dtpTra);
            this.grbHoaDon.Controls.Add(this.txtTimKiem);
            this.grbHoaDon.Controls.Add(this.txtTongTien);
            this.grbHoaDon.Controls.Add(this.txtTenKH);
            this.grbHoaDon.Controls.Add(this.lblTimKiem);
            this.grbHoaDon.Controls.Add(this.dtpThue);
            this.grbHoaDon.Controls.Add(this.lblTongTien);
            this.grbHoaDon.Controls.Add(this.lblTTThue);
            this.grbHoaDon.Controls.Add(this.lblTra);
            this.grbHoaDon.Controls.Add(this.lblThue);
            this.grbHoaDon.Controls.Add(this.txtMaHD);
            this.grbHoaDon.Controls.Add(this.lblTenKH);
            this.grbHoaDon.Controls.Add(this.lblMaHD);
            this.grbHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbHoaDon.Location = new System.Drawing.Point(0, 0);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Size = new System.Drawing.Size(995, 250);
            this.grbHoaDon.TabIndex = 0;
            this.grbHoaDon.Text = "Thông Tin Đơn Hàng";
            // 
            // txtTTThue
            // 
            this.txtTTThue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTTThue.Location = new System.Drawing.Point(487, 125);
            this.txtTTThue.Multiline = true;
            this.txtTTThue.Name = "txtTTThue";
            this.txtTTThue.Size = new System.Drawing.Size(236, 102);
            this.txtTTThue.TabIndex = 4;
            // 
            // dtpTra
            // 
            this.dtpTra.Enabled = false;
            this.dtpTra.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpTra.Location = new System.Drawing.Point(487, 80);
            this.dtpTra.Name = "dtpTra";
            this.dtpTra.Size = new System.Drawing.Size(236, 22);
            this.dtpTra.TabIndex = 3;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTimKiem.Location = new System.Drawing.Point(171, 173);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(185, 22);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTongTien.Location = new System.Drawing.Point(171, 125);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(185, 22);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTenKH.Location = new System.Drawing.Point(171, 82);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(134, 22);
            this.txtTenKH.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTimKiem.Location = new System.Drawing.Point(55, 176);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(57, 14);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // dtpThue
            // 
            this.dtpThue.Enabled = false;
            this.dtpThue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dtpThue.Location = new System.Drawing.Point(487, 42);
            this.dtpThue.Name = "dtpThue";
            this.dtpThue.Size = new System.Drawing.Size(236, 22);
            this.dtpThue.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTongTien.Location = new System.Drawing.Point(55, 128);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(64, 14);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblTTThue
            // 
            this.lblTTThue.AutoSize = true;
            this.lblTTThue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTTThue.Location = new System.Drawing.Point(382, 128);
            this.lblTTThue.Name = "lblTTThue";
            this.lblTTThue.Size = new System.Drawing.Size(97, 14);
            this.lblTTThue.TabIndex = 0;
            this.lblTTThue.Text = "Thông Tin Thuê";
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTra.Location = new System.Drawing.Point(382, 82);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(56, 14);
            this.lblTra.TabIndex = 0;
            this.lblTra.Text = "Ngày Trả";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblThue.Location = new System.Drawing.Point(382, 44);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(67, 14);
            this.lblThue.TabIndex = 0;
            this.lblThue.Text = "Ngày Thuê";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMaHD.Location = new System.Drawing.Point(171, 42);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 22);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTenKH.Location = new System.Drawing.Point(55, 85);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(98, 14);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblMaHD.Location = new System.Drawing.Point(55, 47);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(73, 14);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.TenKH,
            this.TTThue,
            this.NGAYTHUE,
            this.NGAYTRA,
            this.TONGTIEN});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(995, 314);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // MAHD
            // 
            this.MAHD.HeaderText = "Mã Hóa Đơn";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // TTThue
            // 
            this.TTThue.HeaderText = "Thông Tin Thuê";
            this.TTThue.Name = "TTThue";
            this.TTThue.ReadOnly = true;
            // 
            // NGAYTHUE
            // 
            this.NGAYTHUE.HeaderText = "Ngày Thuê";
            this.NGAYTHUE.Name = "NGAYTHUE";
            this.NGAYTHUE.ReadOnly = true;
            // 
            // NGAYTRA
            // 
            this.NGAYTRA.HeaderText = "Ngày Trả";
            this.NGAYTRA.Name = "NGAYTRA";
            this.NGAYTRA.ReadOnly = true;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.HeaderText = "Tổng Tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.ReadOnly = true;
            // 
            // uc_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_HoaDon";
            this.Size = new System.Drawing.Size(995, 592);
            this.Load += new System.EventHandler(this.uc_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbHoaDon)).EndInit();
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnXuatExcel;
        private DevExpress.XtraBars.BarButtonItem bbtnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.GroupControl grbHoaDon;
        private System.Windows.Forms.DateTimePicker dtpTra;
        private System.Windows.Forms.DateTimePicker dtpThue;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.Label lblThue;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTTThue;
        private System.Windows.Forms.Label lblTTThue;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private DevExpress.XtraBars.BarButtonItem btnXuatHoaDon;
    }
}
