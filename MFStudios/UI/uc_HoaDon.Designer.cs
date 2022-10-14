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
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbHoaDon = new DevExpress.XtraEditors.GroupControl();
            this.dtpTra = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.dtpThue = new System.Windows.Forms.DateTimePicker();
            this.lblTongTien = new System.Windows.Forms.Label();
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
            this.MAKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTTThue = new System.Windows.Forms.TextBox();
            this.lblTTThue = new System.Windows.Forms.Label();
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
            this.barButtonItem1,
            this.barButtonItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xuất Excel";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
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
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 4;
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.txtTTThue);
            this.grbHoaDon.Controls.Add(this.dtpTra);
            this.grbHoaDon.Controls.Add(this.txtTongTien);
            this.grbHoaDon.Controls.Add(this.txtTenKH);
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
            this.grbHoaDon.Size = new System.Drawing.Size(995, 162);
            this.grbHoaDon.TabIndex = 0;
            this.grbHoaDon.Text = "Thông Tin Đơn Hàng";
            // 
            // dtpTra
            // 
            this.dtpTra.Enabled = false;
            this.dtpTra.Location = new System.Drawing.Point(487, 80);
            this.dtpTra.Name = "dtpTra";
            this.dtpTra.Size = new System.Drawing.Size(200, 21);
            this.dtpTra.TabIndex = 3;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(150, 123);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(185, 21);
            this.txtTongTien.TabIndex = 1;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(150, 82);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(134, 21);
            this.txtTenKH.TabIndex = 1;
            // 
            // dtpThue
            // 
            this.dtpThue.Enabled = false;
            this.dtpThue.Location = new System.Drawing.Point(487, 42);
            this.dtpThue.Name = "dtpThue";
            this.dtpThue.Size = new System.Drawing.Size(200, 21);
            this.dtpThue.TabIndex = 2;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(58, 128);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(54, 13);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(382, 82);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(51, 13);
            this.lblTra.TabIndex = 0;
            this.lblTra.Text = "Ngày Trả";
            // 
            // lblThue
            // 
            this.lblThue.AutoSize = true;
            this.lblThue.Location = new System.Drawing.Point(382, 44);
            this.lblThue.Name = "lblThue";
            this.lblThue.Size = new System.Drawing.Size(59, 13);
            this.lblThue.TabIndex = 0;
            this.lblThue.Text = "Ngày Thuê";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(150, 42);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(100, 21);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(55, 85);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(85, 13);
            this.lblTenKH.TabIndex = 0;
            this.lblTenKH.Text = "Tên Khách Hàng";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(55, 47);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(66, 13);
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
            this.TONGTIEN,
            this.MAKH});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.Size = new System.Drawing.Size(995, 402);
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
            // MAKH
            // 
            this.MAKH.HeaderText = "Mã Khách Hàng";
            this.MAKH.Name = "MAKH";
            this.MAKH.ReadOnly = true;
            this.MAKH.Visible = false;
            // 
            // txtTTThue
            // 
            this.txtTTThue.Location = new System.Drawing.Point(487, 125);
            this.txtTTThue.Multiline = true;
            this.txtTTThue.Name = "txtTTThue";
            this.txtTTThue.Size = new System.Drawing.Size(236, 102);
            this.txtTTThue.TabIndex = 4;
            // 
            // lblTTThue
            // 
            this.lblTTThue.AutoSize = true;
            this.lblTTThue.Location = new System.Drawing.Point(382, 147);
            this.lblTTThue.Name = "lblTTThue";
            this.lblTTThue.Size = new System.Drawing.Size(81, 13);
            this.lblTTThue.TabIndex = 0;
            this.lblTTThue.Text = "Thông Tin Thuê";
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAKH;
        private System.Windows.Forms.TextBox txtTTThue;
        private System.Windows.Forms.Label lblTTThue;
    }
}
