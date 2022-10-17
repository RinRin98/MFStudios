namespace MFStudios.UI
{
    partial class uc_LoaiThietBi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_LoaiThietBi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbtLuu = new DevExpress.XtraBars.BarButtonItem();
            this.bbtThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.dgvLoaiTB = new System.Windows.Forms.DataGridView();
            this.MALOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTB)).BeginInit();
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
            this.bbtThem,
            this.barButtonItem2,
            this.bbtLuu,
            this.bbtThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtThem
            // 
            this.bbtThem.Caption = "Thêm";
            this.bbtThem.Id = 0;
            this.bbtThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtThem.ImageOptions.Image")));
            this.bbtThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtThem.ImageOptions.LargeImage")));
            this.bbtThem.Name = "bbtThem";
            this.bbtThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtThem_ItemClick);
            // 
            // bbtLuu
            // 
            this.bbtLuu.Caption = "Lưu/Update";
            this.bbtLuu.Id = 2;
            this.bbtLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtLuu.ImageOptions.Image")));
            this.bbtLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtLuu.ImageOptions.LargeImage")));
            this.bbtLuu.Name = "bbtLuu";
            this.bbtLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtLuu_ItemClick);
            // 
            // bbtThoat
            // 
            this.bbtThoat.Caption = "Thoát";
            this.bbtThoat.Id = 3;
            this.bbtThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bbtThoat.ImageOptions.Image")));
            this.bbtThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bbtThoat.ImageOptions.LargeImage")));
            this.bbtThoat.Name = "bbtThoat";
            this.bbtThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(977, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 569);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(977, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 545);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(977, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 545);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Sửa";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
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
            this.splitContainer1.Panel1.Controls.Add(this.txtTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.lblTimKiem);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenLoai);
            this.splitContainer1.Panel1.Controls.Add(this.lblTenLoai);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaLoai);
            this.splitContainer1.Panel1.Controls.Add(this.lblMaLoai);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvLoaiTB);
            this.splitContainer1.Size = new System.Drawing.Size(977, 545);
            this.splitContainer1.SplitterDistance = 165;
            this.splitContainer1.TabIndex = 4;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(121, 139);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(192, 21);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(55, 139);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(60, 15);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Enabled = false;
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(216, 81);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(192, 21);
            this.txtTenLoai.TabIndex = 0;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoai.Location = new System.Drawing.Point(137, 81);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(55, 15);
            this.lblTenLoai.TabIndex = 0;
            this.lblTenLoai.Text = "Tên Loại";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.Location = new System.Drawing.Point(216, 32);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(100, 21);
            this.txtMaLoai.TabIndex = 1;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoai.Location = new System.Drawing.Point(140, 35);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(52, 15);
            this.lblMaLoai.TabIndex = 0;
            this.lblMaLoai.Text = "Mã Loại";
            // 
            // dgvLoaiTB
            // 
            this.dgvLoaiTB.AllowUserToAddRows = false;
            this.dgvLoaiTB.AllowUserToDeleteRows = false;
            this.dgvLoaiTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALOAI,
            this.TENLOAI});
            this.dgvLoaiTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiTB.Location = new System.Drawing.Point(0, 0);
            this.dgvLoaiTB.Name = "dgvLoaiTB";
            this.dgvLoaiTB.ReadOnly = true;
            this.dgvLoaiTB.Size = new System.Drawing.Size(977, 376);
            this.dgvLoaiTB.TabIndex = 0;
            this.dgvLoaiTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiTB_CellClick);
            // 
            // MALOAI
            // 
            this.MALOAI.HeaderText = "Mã Loại";
            this.MALOAI.Name = "MALOAI";
            this.MALOAI.ReadOnly = true;
            // 
            // TENLOAI
            // 
            this.TENLOAI.HeaderText = "Tên Loại";
            this.TENLOAI.Name = "TENLOAI";
            this.TENLOAI.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // uc_LoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "uc_LoaiThietBi";
            this.Size = new System.Drawing.Size(977, 569);
            this.Load += new System.EventHandler(this.uc_LoaiThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraBars.BarButtonItem bbtThem;
        private DevExpress.XtraBars.BarButtonItem bbtLuu;
        private DevExpress.XtraBars.BarButtonItem bbtThoat;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.DataGridView dgvLoaiTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAI;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
