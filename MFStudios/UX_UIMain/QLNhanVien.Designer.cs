namespace MFStudios.UX_UIMain
{
    partial class QLNhanVien
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
            this.grvThongTin = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvThongTin
            // 
            this.grvThongTin.Location = new System.Drawing.Point(-1, 43);
            this.grvThongTin.MainView = this.gridView1;
            this.grvThongTin.Name = "grvThongTin";
            this.grvThongTin.Size = new System.Drawing.Size(842, 380);
            this.grvThongTin.TabIndex = 1;
            this.grvThongTin.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grvThongTin.Load += new System.EventHandler(this.grvThongTin_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaNV,
            this.Pass,
            this.HoTen,
            this.SDT,
            this.Email});
            this.gridView1.GridControl = this.grvThongTin;
            this.gridView1.Name = "gridView1";
            // 
            // MaNV
            // 
            this.MaNV.Caption = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 0;
            this.MaNV.Width = 163;
            // 
            // Pass
            // 
            this.Pass.Caption = "PassWord";
            this.Pass.Name = "Pass";
            this.Pass.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.Pass.Visible = true;
            this.Pass.VisibleIndex = 1;
            this.Pass.Width = 163;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 162;
            // 
            // SDT
            // 
            this.SDT.Caption = "Số Điện Thoại";
            this.SDT.Name = "SDT";
            this.SDT.Visible = true;
            this.SDT.VisibleIndex = 3;
            this.SDT.Width = 163;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.Name = "Email";
            this.Email.Visible = true;
            this.Email.VisibleIndex = 4;
            this.Email.Width = 166;
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 550);
            this.Controls.Add(this.grvThongTin);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.grvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grvThongTin;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn Pass;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
    }
}