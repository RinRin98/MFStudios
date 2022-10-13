namespace frmQLTB
{
    partial class frmLoaiTB
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbTTLThietBi = new System.Windows.Forms.GroupBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.lblMaLoai = new System.Windows.Forms.Label();
            this.lblQLThietBi = new System.Windows.Forms.Label();
            this.dgvLTB = new System.Windows.Forms.DataGridView();
            this.grbChucNang.SuspendLayout();
            this.grbTTLThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(386, 36);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 44);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(230, 242);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(293, 30);
            this.txtTim.TabIndex = 12;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tìm kiếm theo tên loại :";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.Location = new System.Drawing.Point(552, 72);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(522, 200);
            this.grbChucNang.TabIndex = 10;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức Năng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(212, 90);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 44);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(24, 90);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 44);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(212, 32);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(103, 44);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 44);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbTTLThietBi
            // 
            this.grbTTLThietBi.Controls.Add(this.txtTenLoai);
            this.grbTTLThietBi.Controls.Add(this.lblTenLoai);
            this.grbTTLThietBi.Controls.Add(this.txtMaLoai);
            this.grbTTLThietBi.Controls.Add(this.lblMaLoai);
            this.grbTTLThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTLThietBi.Location = new System.Drawing.Point(17, 72);
            this.grbTTLThietBi.Name = "grbTTLThietBi";
            this.grbTTLThietBi.Size = new System.Drawing.Size(506, 155);
            this.grbTTLThietBi.TabIndex = 9;
            this.grbTTLThietBi.TabStop = false;
            this.grbTTLThietBi.Text = "Thông Tin  Loại Thiết Bị";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(151, 84);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(284, 30);
            this.txtTenLoai.TabIndex = 1;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Location = new System.Drawing.Point(26, 90);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(89, 25);
            this.lblTenLoai.TabIndex = 0;
            this.lblTenLoai.Text = "Tên Loại";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(151, 36);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(284, 30);
            this.txtMaLoai.TabIndex = 1;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.AutoSize = true;
            this.lblMaLoai.Location = new System.Drawing.Point(26, 42);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(82, 25);
            this.lblMaLoai.TabIndex = 0;
            this.lblMaLoai.Text = "Mã Loại";
            // 
            // lblQLThietBi
            // 
            this.lblQLThietBi.AutoSize = true;
            this.lblQLThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLThietBi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblQLThietBi.Location = new System.Drawing.Point(349, 9);
            this.lblQLThietBi.Name = "lblQLThietBi";
            this.lblQLThietBi.Size = new System.Drawing.Size(421, 48);
            this.lblQLThietBi.TabIndex = 8;
            this.lblQLThietBi.Text = "Quản Lý Loại Thiết Bị";
            // 
            // dgvLTB
            // 
            this.dgvLTB.AllowUserToAddRows = false;
            this.dgvLTB.AllowUserToDeleteRows = false;
            this.dgvLTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLTB.Location = new System.Drawing.Point(27, 278);
            this.dgvLTB.Name = "dgvLTB";
            this.dgvLTB.ReadOnly = true;
            this.dgvLTB.RowHeadersWidth = 51;
            this.dgvLTB.RowTemplate.Height = 24;
            this.dgvLTB.Size = new System.Drawing.Size(1047, 220);
            this.dgvLTB.TabIndex = 13;
            this.dgvLTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLTB_CellClick);
            // 
            // frmLoaiTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 510);
            this.Controls.Add(this.dgvLTB);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbTTLThietBi);
            this.Controls.Add(this.lblQLThietBi);
            this.Name = "frmLoaiTB";
            this.Text = "Quản Lý Loại Thiết Bị";
            this.grbChucNang.ResumeLayout(false);
            this.grbTTLThietBi.ResumeLayout(false);
            this.grbTTLThietBi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbTTLThietBi;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label lblMaLoai;
        private System.Windows.Forms.Label lblQLThietBi;
        private System.Windows.Forms.DataGridView dgvLTB;
    }
}

