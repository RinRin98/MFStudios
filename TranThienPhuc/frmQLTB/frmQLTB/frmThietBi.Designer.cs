namespace frmQLTB
{
    partial class frmThietBi
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbLoaiTB = new System.Windows.Forms.ComboBox();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.lblLoaiTB = new System.Windows.Forms.Label();
            this.lblGiaThue = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblKQ = new System.Windows.Forms.Label();
            this.lblTongTB = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtTenTB = new System.Windows.Forms.TextBox();
            this.lblTenTB = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.lblMaTB = new System.Windows.Forms.Label();
            this.dgvTTTB = new System.Windows.Forms.DataGridView();
            this.grbTTThietBi = new System.Windows.Forms.GroupBox();
            this.lblQLThietBi = new System.Windows.Forms.Label();
            this.tHIETBIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTB)).BeginInit();
            this.grbTTThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(512, 490);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(177, 25);
            this.lblTimKiem.TabIndex = 15;
            this.lblTimKiem.Text = "Tìm Kiếm Tên TB :";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1026, 560);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 56);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbLoaiTB
            // 
            this.cmbLoaiTB.FormattingEnabled = true;
            this.cmbLoaiTB.Location = new System.Drawing.Point(151, 381);
            this.cmbLoaiTB.Name = "cmbLoaiTB";
            this.cmbLoaiTB.Size = new System.Drawing.Size(284, 33);
            this.cmbLoaiTB.TabIndex = 6;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Location = new System.Drawing.Point(220, 424);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(75, 23);
            this.xtraScrollableControl1.TabIndex = 3;
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Location = new System.Drawing.Point(151, 331);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(284, 30);
            this.txtGiaThue.TabIndex = 5;
            this.txtGiaThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaThue_KeyPress);
            // 
            // lblLoaiTB
            // 
            this.lblLoaiTB.AutoSize = true;
            this.lblLoaiTB.Location = new System.Drawing.Point(26, 384);
            this.lblLoaiTB.Name = "lblLoaiTB";
            this.lblLoaiTB.Size = new System.Drawing.Size(80, 25);
            this.lblLoaiTB.TabIndex = 0;
            this.lblLoaiTB.Text = "Loại TB";
            // 
            // lblGiaThue
            // 
            this.lblGiaThue.AutoSize = true;
            this.lblGiaThue.Location = new System.Drawing.Point(26, 331);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(93, 25);
            this.lblGiaThue.TabIndex = 0;
            this.lblGiaThue.Text = "Gía Thuê";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(151, 274);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(284, 30);
            this.txtGiaTri.TabIndex = 4;
            this.txtGiaTri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTri_KeyPress);
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Location = new System.Drawing.Point(26, 280);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(101, 25);
            this.lblGiaTri.TabIndex = 0;
            this.lblGiaTri.Text = "Gía Trị TB";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(151, 224);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(284, 30);
            this.txtTinhTrang.TabIndex = 3;
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(648, 533);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(47, 25);
            this.lblKQ.TabIndex = 16;
            this.lblKQ.Text = ".......";
            // 
            // lblTongTB
            // 
            this.lblTongTB.AutoSize = true;
            this.lblTongTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTB.Location = new System.Drawing.Point(512, 533);
            this.lblTongTB.Name = "lblTongTB";
            this.lblTongTB.Size = new System.Drawing.Size(130, 25);
            this.lblTongTB.TabIndex = 17;
            this.lblTongTB.Text = "Tổng Số TB :";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(696, 490);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(289, 30);
            this.txtTim.TabIndex = 20;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Location = new System.Drawing.Point(26, 230);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(108, 25);
            this.lblTinhTrang.TabIndex = 0;
            this.lblTinhTrang.Text = "Tình Trạng";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(151, 180);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(284, 30);
            this.txtMoTa.TabIndex = 2;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(26, 186);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(69, 25);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(26, 140);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(97, 25);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(151, 134);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(284, 30);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(7, 519);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(487, 172);
            this.grbChucNang.TabIndex = 19;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(70, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 46);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(70, 105);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 46);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(279, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(106, 46);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtTenTB
            // 
            this.txtTenTB.Location = new System.Drawing.Point(151, 84);
            this.txtTenTB.Name = "txtTenTB";
            this.txtTenTB.Size = new System.Drawing.Size(284, 30);
            this.txtTenTB.TabIndex = 0;
            // 
            // lblTenTB
            // 
            this.lblTenTB.AutoSize = true;
            this.lblTenTB.Location = new System.Drawing.Point(26, 90);
            this.lblTenTB.Name = "lblTenTB";
            this.lblTenTB.Size = new System.Drawing.Size(78, 25);
            this.lblTenTB.TabIndex = 0;
            this.lblTenTB.Text = "Tên TB";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Enabled = false;
            this.txtMaTB.Location = new System.Drawing.Point(151, 36);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.ReadOnly = true;
            this.txtMaTB.Size = new System.Drawing.Size(284, 30);
            this.txtMaTB.TabIndex = 1;
            // 
            // lblMaTB
            // 
            this.lblMaTB.AutoSize = true;
            this.lblMaTB.Location = new System.Drawing.Point(26, 42);
            this.lblMaTB.Name = "lblMaTB";
            this.lblMaTB.Size = new System.Drawing.Size(71, 25);
            this.lblMaTB.TabIndex = 0;
            this.lblMaTB.Text = "Mã TB";
            // 
            // dgvTTTB
            // 
            this.dgvTTTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTTB.Location = new System.Drawing.Point(500, 121);
            this.dgvTTTB.Name = "dgvTTTB";
            this.dgvTTTB.RowHeadersWidth = 51;
            this.dgvTTTB.RowTemplate.Height = 24;
            this.dgvTTTB.Size = new System.Drawing.Size(680, 363);
            this.dgvTTTB.TabIndex = 18;
            this.dgvTTTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTTB_CellClick);
            // 
            // grbTTThietBi
            // 
            this.grbTTThietBi.Controls.Add(this.cmbLoaiTB);
            this.grbTTThietBi.Controls.Add(this.xtraScrollableControl1);
            this.grbTTThietBi.Controls.Add(this.txtGiaThue);
            this.grbTTThietBi.Controls.Add(this.lblLoaiTB);
            this.grbTTThietBi.Controls.Add(this.lblGiaThue);
            this.grbTTThietBi.Controls.Add(this.txtGiaTri);
            this.grbTTThietBi.Controls.Add(this.lblGiaTri);
            this.grbTTThietBi.Controls.Add(this.txtTinhTrang);
            this.grbTTThietBi.Controls.Add(this.lblTinhTrang);
            this.grbTTThietBi.Controls.Add(this.txtMoTa);
            this.grbTTThietBi.Controls.Add(this.lblMoTa);
            this.grbTTThietBi.Controls.Add(this.txtSoLuong);
            this.grbTTThietBi.Controls.Add(this.lblSoLuong);
            this.grbTTThietBi.Controls.Add(this.txtTenTB);
            this.grbTTThietBi.Controls.Add(this.lblTenTB);
            this.grbTTThietBi.Controls.Add(this.txtMaTB);
            this.grbTTThietBi.Controls.Add(this.lblMaTB);
            this.grbTTThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTThietBi.Location = new System.Drawing.Point(12, 39);
            this.grbTTThietBi.Name = "grbTTThietBi";
            this.grbTTThietBi.Size = new System.Drawing.Size(482, 448);
            this.grbTTThietBi.TabIndex = 14;
            this.grbTTThietBi.TabStop = false;
            this.grbTTThietBi.Text = "Thông Tin Thiết Bị";
            // 
            // lblQLThietBi
            // 
            this.lblQLThietBi.AutoSize = true;
            this.lblQLThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLThietBi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQLThietBi.Location = new System.Drawing.Point(509, 57);
            this.lblQLThietBi.Name = "lblQLThietBi";
            this.lblQLThietBi.Size = new System.Drawing.Size(331, 48);
            this.lblQLThietBi.TabIndex = 13;
            this.lblQLThietBi.Text = "Quản Lý Thiết Bị";
            // 
            // tHIETBIBindingSource
            // 
            this.tHIETBIBindingSource.DataMember = "THIETBI";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(279, 46);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(106, 46);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 756);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.lblTongTB);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.dgvTTTB);
            this.Controls.Add(this.grbTTThietBi);
            this.Controls.Add(this.lblQLThietBi);
            this.Name = "frmThietBi";
            this.Text = "Quản Lý Thiết Bị";
            this.grbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTTB)).EndInit();
            this.grbTTThietBi.ResumeLayout(false);
            this.grbTTThietBi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tHIETBIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbLoaiTB;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label lblLoaiTB;
        private System.Windows.Forms.Label lblGiaThue;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label lblTongTB;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.BindingSource tHIETBIBindingSource;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtTenTB;
        private System.Windows.Forms.Label lblTenTB;
        private System.Windows.Forms.TextBox txtMaTB;
        private System.Windows.Forms.Label lblMaTB;
        private System.Windows.Forms.DataGridView dgvTTTB;
        private System.Windows.Forms.GroupBox grbTTThietBi;
        private System.Windows.Forms.Label lblQLThietBi;
        private System.Windows.Forms.Button btnLuu;
    }
}