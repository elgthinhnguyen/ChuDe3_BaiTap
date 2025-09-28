namespace ChuDe3_BaiTap_2312756_NguyenHungThinh
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.chkChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaTheoSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSoCMND = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(20, 20);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(51, 16);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV :";
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Location = new System.Drawing.Point(20, 60);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(87, 16);
            this.lblHoLot.TabIndex = 2;
            this.lblHoLot.Text = "Họ và tên lót :";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Location = new System.Drawing.Point(120, 60);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(150, 22);
            this.txtHoLot.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(300, 60);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(37, 16);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "Tên :";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(370, 60);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 22);
            this.txtTen.TabIndex = 5;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(20, 100);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(73, 16);
            this.lblNgaySinh.TabIndex = 6;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "d/m/y";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(120, 100);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(150, 22);
            this.dtpNgaySinh.TabIndex = 7;
            this.dtpNgaySinh.Value = new System.DateTime(2025, 9, 26, 21, 44, 45, 0);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(300, 100);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(36, 16);
            this.lblLop.TabIndex = 8;
            this.lblLop.Text = "Lớp :";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(20, 140);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(73, 16);
            this.lblCMND.TabIndex = 10;
            this.lblCMND.Text = "Số CMND :";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(300, 140);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(51, 16);
            this.lblSDT.TabIndex = 12;
            this.lblSDT.Text = "Số ĐT :";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(20, 180);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(98, 16);
            this.lblDiaChi.TabIndex = 14;
            this.lblDiaChi.Text = "Địa chỉ liên lạc :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 180);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(500, 22);
            this.txtDiaChi.TabIndex = 15;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(300, 20);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinh.TabIndex = 16;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // rbNu
            // 
            this.rbNu.Location = new System.Drawing.Point(450, 20);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(70, 24);
            this.rbNu.TabIndex = 18;
            this.rbNu.Text = "Nữ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(285, 362);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(384, 362);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 21;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(479, 362);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(578, 362);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeight = 29;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkChon});
            this.dgvSinhVien.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSinhVien.Location = new System.Drawing.Point(20, 400);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.Size = new System.Drawing.Size(680, 150);
            this.dgvSinhVien.TabIndex = 24;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            this.dgvSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellDoubleClick);
            // 
            // chkChon
            // 
            this.chkChon.HeaderText = "Chọn";
            this.chkChon.MinimumWidth = 6;
            this.chkChon.Name = "chkChon";
            this.chkChon.Width = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaTheoSelectToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 28);
            // 
            // xóaTheoSelectToolStripMenuItem
            // 
            this.xóaTheoSelectToolStripMenuItem.Name = "xóaTheoSelectToolStripMenuItem";
            this.xóaTheoSelectToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.xóaTheoSelectToolStripMenuItem.Text = "Xóa theo select";
            this.xóaTheoSelectToolStripMenuItem.Click += new System.EventHandler(this.xóaTheoSelectToolStripMenuItem_Click);
            // 
            // rbNam
            // 
            this.rbNam.Checked = true;
            this.rbNam.Location = new System.Drawing.Point(370, 20);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(74, 24);
            this.rbNam.TabIndex = 17;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Location = new System.Drawing.Point(120, 17);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(166, 22);
            this.mtxtMSSV.TabIndex = 25;
            // 
            // mtxtSoCMND
            // 
            this.mtxtSoCMND.Location = new System.Drawing.Point(120, 137);
            this.mtxtSoCMND.Mask = "000000000";
            this.mtxtSoCMND.Name = "mtxtSoCMND";
            this.mtxtSoCMND.Size = new System.Drawing.Size(166, 22);
            this.mtxtSoCMND.TabIndex = 25;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(370, 137);
            this.mtxtSoDT.Mask = "0000.000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(166, 22);
            this.mtxtSoDT.TabIndex = 25;
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Items.AddRange(new object[] {
            "CNTT1",
            "CNTT2",
            "CNTT3"});
            this.cbLop.Location = new System.Drawing.Point(370, 97);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(166, 24);
            this.cbLop.TabIndex = 26;
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "PhuongPhapNCKH",
            "LapTrinhMang",
            "LapTrinhCSDL",
            "HeDieuHanh",
            "LapTrinhTrenThietBiDiDong",
            "AnToanVaBaoMatHeThong",
            "DoAnCoSo",
            "MangMayTinh"});
            this.clbMonHoc.Location = new System.Drawing.Point(22, 215);
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(663, 140);
            this.clbMonHoc.TabIndex = 28;
//            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(712, 600);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.mtxtSoCMND);
            this.Controls.Add(this.mtxtMSSV);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.rbNam);
            this.Controls.Add(this.rbNu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "Form1";
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSSV, lblHoLot, lblTen, lblNgaySinh, lblLop, lblCMND, lblSDT, lblDiaChi, lblGioiTinh;
        private System.Windows.Forms.TextBox txtHoLot, txtTen, txtDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.Button btnTimKiem, btnThemMoi, btnCapNhat, btnThoat;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.MaskedTextBox mtxtSoCMND;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaTheoSelectToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkChon;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
    }
}


