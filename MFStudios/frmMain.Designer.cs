namespace MFStudios
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.mainContainer = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceDanhMuc = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThueThietBi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThietBi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLoaiThietBi = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceKhachHang = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHoaDon = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceHeThong = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceExcel = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.bsiUserName = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.lblTieuDe = new DevExpress.XtraBars.BarStaticItem();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(243, 31);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(713, 504);
            this.mainContainer.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.accordionControl1.Appearance.AccordionControl.ForeColor = System.Drawing.Color.Black;
            this.accordionControl1.Appearance.AccordionControl.Options.UseBackColor = true;
            this.accordionControl1.Appearance.AccordionControl.Options.UseForeColor = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDanhMuc,
            this.aceHeThong});
            this.accordionControl1.Location = new System.Drawing.Point(0, 31);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(243, 504);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceDanhMuc
            // 
            this.aceDanhMuc.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceThueThietBi,
            this.aceThietBi,
            this.aceLoaiThietBi,
            this.aceNhanVien,
            this.aceKhachHang,
            this.aceHoaDon});
            this.aceDanhMuc.Expanded = true;
            this.aceDanhMuc.Name = "aceDanhMuc";
            this.aceDanhMuc.Text = "DANH MỤC";
            // 
            // aceThueThietBi
            // 
            this.aceThueThietBi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceThueThietBi.ImageOptions.Image")));
            this.aceThueThietBi.Name = "aceThueThietBi";
            this.aceThueThietBi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThueThietBi.Text = "Cho Thuê Thiết Bị";
            // 
            // aceThietBi
            // 
            this.aceThietBi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceThietBi.ImageOptions.Image")));
            this.aceThietBi.Name = "aceThietBi";
            this.aceThietBi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThietBi.Text = "Danh Mục Thiết Bị";
            this.aceThietBi.Click += new System.EventHandler(this.aceThietBi_Click);
            // 
            // aceLoaiThietBi
            // 
            this.aceLoaiThietBi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceLoaiThietBi.ImageOptions.Image")));
            this.aceLoaiThietBi.Name = "aceLoaiThietBi";
            this.aceLoaiThietBi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLoaiThietBi.Text = "Danh Mục Loại Thiết Bị";
            this.aceLoaiThietBi.Click += new System.EventHandler(this.aceLoaiThietBi_Click);
            // 
            // aceNhanVien
            // 
            this.aceNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceNhanVien.ImageOptions.Image")));
            this.aceNhanVien.Name = "aceNhanVien";
            this.aceNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceNhanVien.Text = "Danh Mục Nhân Viên";
            this.aceNhanVien.Click += new System.EventHandler(this.aceNhanVien_Click);
            // 
            // aceKhachHang
            // 
            this.aceKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceKhachHang.ImageOptions.Image")));
            this.aceKhachHang.Name = "aceKhachHang";
            this.aceKhachHang.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceKhachHang.Text = "Danh Mục Khách Hàng";
            // 
            // aceHoaDon
            // 
            this.aceHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceHoaDon.ImageOptions.Image")));
            this.aceHoaDon.Name = "aceHoaDon";
            this.aceHoaDon.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHoaDon.Text = "Hóa Đơn";
            // 
            // aceHeThong
            // 
            this.aceHeThong.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceThongKe,
            this.aceExcel});
            this.aceHeThong.Expanded = true;
            this.aceHeThong.Name = "aceHeThong";
            this.aceHeThong.Text = "HỆ THỐNG";
            // 
            // aceThongKe
            // 
            this.aceThongKe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceThongKe.ImageOptions.Image")));
            this.aceThongKe.Name = "aceThongKe";
            this.aceThongKe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThongKe.Text = "Thống Kê";
            // 
            // aceExcel
            // 
            this.aceExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceExcel.ImageOptions.Image")));
            this.aceExcel.Name = "aceExcel";
            this.aceExcel.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceExcel.Text = "Xuất Excel";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barSubItem1,
            this.barStaticItem2,
            this.barSubItem2,
            this.barEditItem1,
            this.barListItem1,
            this.bsiUserName,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.lblTieuDe});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(956, 31);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.bsiUserName);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.lblTieuDe);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Id = 1;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "barStaticItem2";
            this.barStaticItem2.Id = 2;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem2.Caption = "UserName";
            this.barSubItem2.Id = 3;
            this.barSubItem2.Name = "barSubItem2";
            this.barSubItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem1.Text = "Thông Tin Tài Khoản";
            toolTipItem1.Text = "Đăng Xuất";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.barSubItem2.SuperTip = superToolTip1;
            // 
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.Caption = "UserName";
            this.barEditItem1.Edit = this.repositoryItemComboBox1;
            this.barEditItem1.Id = 4;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barListItem1
            // 
            this.barListItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barListItem1.Caption = "UserName";
            this.barListItem1.Id = 5;
            this.barListItem1.Name = "barListItem1";
            // 
            // bsiUserName
            // 
            this.bsiUserName.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiUserName.Id = 6;
            this.bsiUserName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bsiUserName.ImageOptions.Image")));
            this.bsiUserName.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bsiUserName.ImageOptions.LargeImage")));
            this.bsiUserName.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3)});
            this.bsiUserName.Name = "bsiUserName";
            this.bsiUserName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Thông Tin Tài Khoản";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Đổi Mật Khẩu";
            this.barButtonItem2.Id = 8;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Đăng Xuất";
            this.barButtonItem3.Id = 9;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Caption = "MFStudios - Quản lý cho thuê thiết bị";
            this.lblTieuDe.Id = 10;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
            this.fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barStaticItem1,
            this.barSubItem1,
            this.barStaticItem2,
            this.barSubItem2,
            this.barEditItem1,
            this.barListItem1,
            this.bsiUserName,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.lblTieuDe});
            this.fluentFormDefaultManager1.MaxItemId = 11;
            this.fluentFormDefaultManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 535);
            this.ControlContainer = this.mainContainer;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "frmMain";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MfStudios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer mainContainer;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarSubItem bsiUserName;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDanhMuc;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThueThietBi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThietBi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLoaiThietBi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHoaDon;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHeThong;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceExcel;
        private DevExpress.XtraBars.BarStaticItem lblTieuDe;
    }
}

