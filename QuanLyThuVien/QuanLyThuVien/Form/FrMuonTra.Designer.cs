﻿namespace QuanLyThuVien
{
    partial class FrMuonTra
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grSachMuon = new System.Windows.Forms.DataGridView();
            this.Ma_Sach1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.So_Luong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ton_Kho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.txtTenDG = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grMuonTra = new System.Windows.Forms.DataGridView();
            this.So_Phieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Tra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPTPM = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSachMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Mượn Trả Sách";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(945, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbPTPM);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNgayTra);
            this.panel2.Controls.Add(this.txtNgayMuon);
            this.panel2.Controls.Add(this.txtNgayLap);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.cbMaNV);
            this.panel2.Controls.Add(this.cbMaDG);
            this.panel2.Controls.Add(this.txtTenDG);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.txtSoPhieu);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(13, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 402);
            this.panel2.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(787, 95);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(225, 22);
            this.txtTimKiem.TabIndex = 32;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            this.txtTimKiem.MouseEnter += new System.EventHandler(this.txtTimKiem_MouseEnter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(94, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "*";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(689, 94);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(109, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(73, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "*";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.txtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayTra.Location = new System.Drawing.Point(319, 167);
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Size = new System.Drawing.Size(153, 22);
            this.txtNgayTra.TabIndex = 28;
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.txtNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayMuon.Location = new System.Drawing.Point(113, 167);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(126, 22);
            this.txtNgayMuon.TabIndex = 27;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayLap.Location = new System.Drawing.Point(113, 138);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(126, 22);
            this.txtNgayLap.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grSachMuon);
            this.groupBox2.Location = new System.Drawing.Point(490, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 261);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách mượn";
            // 
            // grSachMuon
            // 
            this.grSachMuon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grSachMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grSachMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Sach1,
            this.So_Luong1,
            this.Ton_Kho});
            this.grSachMuon.Location = new System.Drawing.Point(12, 21);
            this.grSachMuon.Name = "grSachMuon";
            this.grSachMuon.Size = new System.Drawing.Size(516, 276);
            this.grSachMuon.TabIndex = 0;
            this.grSachMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grSachMuon_CellContentClick);
            this.grSachMuon.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grSachMuon_RowLeave);
            // 
            // Ma_Sach1
            // 
            this.Ma_Sach1.DataPropertyName = "Ma_Sach";
            this.Ma_Sach1.HeaderText = "Mã Sách";
            this.Ma_Sach1.Name = "Ma_Sach1";
            this.Ma_Sach1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ma_Sach1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Ma_Sach1.Width = 110;
            // 
            // So_Luong1
            // 
            this.So_Luong1.DataPropertyName = "So_Luong";
            this.So_Luong1.HeaderText = "Số Lượng";
            this.So_Luong1.Name = "So_Luong1";
            // 
            // Ton_Kho
            // 
            this.Ton_Kho.DataPropertyName = "Ton_Kho";
            this.Ton_Kho.HeaderText = "Tồn Kho";
            this.Ton_Kho.Name = "Ton_Kho";
            this.Ton_Kho.ReadOnly = true;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(128, 45);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(107, 24);
            this.cbMaNV.TabIndex = 24;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(113, 97);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(122, 24);
            this.cbMaDG.TabIndex = 23;
            this.cbMaDG.SelectedIndexChanged += new System.EventHandler(this.cbMaDG_SelectedIndexChanged);
            // 
            // txtTenDG
            // 
            this.txtTenDG.Enabled = false;
            this.txtTenDG.Location = new System.Drawing.Point(247, 98);
            this.txtTenDG.Name = "txtTenDG";
            this.txtTenDG.Size = new System.Drawing.Size(225, 22);
            this.txtTenDG.TabIndex = 21;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(248, 45);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(224, 22);
            this.txtTenNV.TabIndex = 20;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(113, 204);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(359, 195);
            this.txtGhiChu.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNhapLai);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Location = new System.Drawing.Point(490, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Các thao tác";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(88, 22);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btnNhapLai.TabIndex = 32;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(250, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(169, 22);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(247, 11);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(225, 22);
            this.txtSoPhieu.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ghi Chú";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngày Mượn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày Trả ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Độc Giả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Phiếu";
            // 
            // grMuonTra
            // 
            this.grMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grMuonTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.So_Phieu,
            this.Ten_DocGia,
            this.Ten_NV,
            this.Ma_NV,
            this.Ma_DocGia,
            this.Ngay_Muon,
            this.Ngay_Tra,
            this.Ngay_Lap,
            this.Ghi_Chu});
            this.grMuonTra.Location = new System.Drawing.Point(13, 463);
            this.grMuonTra.Name = "grMuonTra";
            this.grMuonTra.ReadOnly = true;
            this.grMuonTra.Size = new System.Drawing.Size(1027, 192);
            this.grMuonTra.TabIndex = 2;
            this.grMuonTra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grMuonTra_CellDoubleClick_1);
            // 
            // So_Phieu
            // 
            this.So_Phieu.DataPropertyName = "So_Phieu";
            this.So_Phieu.HeaderText = "Số Phiếu";
            this.So_Phieu.Name = "So_Phieu";
            this.So_Phieu.ReadOnly = true;
            this.So_Phieu.Width = 80;
            // 
            // Ten_DocGia
            // 
            this.Ten_DocGia.DataPropertyName = "Ten_DocGia";
            this.Ten_DocGia.HeaderText = "Tên Độc Giả";
            this.Ten_DocGia.Name = "Ten_DocGia";
            this.Ten_DocGia.ReadOnly = true;
            this.Ten_DocGia.Width = 120;
            // 
            // Ten_NV
            // 
            this.Ten_NV.DataPropertyName = "Ten_NV";
            this.Ten_NV.HeaderText = "Tên Nhân Viên";
            this.Ten_NV.Name = "Ten_NV";
            this.Ten_NV.ReadOnly = true;
            this.Ten_NV.Width = 120;
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã Nhân Viên";
            this.Ma_NV.Name = "Ma_NV";
            this.Ma_NV.ReadOnly = true;
            // 
            // Ma_DocGia
            // 
            this.Ma_DocGia.DataPropertyName = "Ma_DocGia";
            this.Ma_DocGia.HeaderText = "Mã Độc Giả";
            this.Ma_DocGia.Name = "Ma_DocGia";
            this.Ma_DocGia.ReadOnly = true;
            // 
            // Ngay_Muon
            // 
            this.Ngay_Muon.DataPropertyName = "Ngay_Muon";
            this.Ngay_Muon.HeaderText = "Ngày Mượn";
            this.Ngay_Muon.Name = "Ngay_Muon";
            this.Ngay_Muon.ReadOnly = true;
            // 
            // Ngay_Tra
            // 
            this.Ngay_Tra.DataPropertyName = "Ngay_TraDuKien";
            this.Ngay_Tra.HeaderText = "Ngày Trả";
            this.Ngay_Tra.Name = "Ngay_Tra";
            this.Ngay_Tra.ReadOnly = true;
            // 
            // Ngay_Lap
            // 
            this.Ngay_Lap.DataPropertyName = "Ngay_Lap";
            this.Ngay_Lap.HeaderText = "Ngày Lập";
            this.Ngay_Lap.Name = "Ngay_Lap";
            this.Ngay_Lap.ReadOnly = true;
            // 
            // Ghi_Chu
            // 
            this.Ghi_Chu.DataPropertyName = "Ghi_Chu";
            this.Ghi_Chu.HeaderText = "Ghi Chú";
            this.Ghi_Chu.Name = "Ghi_Chu";
            this.Ghi_Chu.ReadOnly = true;
            this.Ghi_Chu.Width = 80;
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.Name = "Ten_Sach";
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.Name = "Ma_Sach";
            // 
            // So_Luong
            // 
            this.So_Luong.Name = "So_Luong";
            // 
            // cbPTPM
            // 
            this.cbPTPM.DisplayMember = "PM";
            this.cbPTPM.FormattingEnabled = true;
            this.cbPTPM.Items.AddRange(new object[] {
            "PT",
            "PM"});
            this.cbPTPM.Location = new System.Drawing.Point(128, 11);
            this.cbPTPM.Name = "cbPTPM";
            this.cbPTPM.Size = new System.Drawing.Size(107, 24);
            this.cbPTPM.TabIndex = 33;
            this.cbPTPM.Text = "PM";
            // 
            // FrMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 667);
            this.Controls.Add(this.grMuonTra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrMuonTra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grSachMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grMuonTra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDG;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.DataGridView grMuonTra;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Phieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Tra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Lap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grSachMuon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.DateTimePicker txtNgayTra;
        private System.Windows.Forms.DateTimePicker txtNgayMuon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.DataGridViewComboBoxColumn Ma_Sach1;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ton_Kho;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cbPTPM;
    }
}