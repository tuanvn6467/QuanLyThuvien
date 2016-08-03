namespace QuanLyThuVien
{
    partial class FrLstSach
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaLoai = new System.Windows.Forms.ComboBox();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.cbMaTacGia = new System.Windows.Forms.ComboBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtSoTrang = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtTenTacGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grLstSach = new System.Windows.Forms.DataGridView();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grLstSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cbMaLoai);
            this.panel2.Controls.Add(this.cbMaNXB);
            this.panel2.Controls.Add(this.cbMaTacGia);
            this.panel2.Controls.Add(this.txtTenLoai);
            this.panel2.Controls.Add(this.txtSoTrang);
            this.panel2.Controls.Add(this.txtTenSach);
            this.panel2.Controls.Add(this.txtTenNXB);
            this.panel2.Controls.Add(this.txtMaSach);
            this.panel2.Controls.Add(this.txtTenTacGia);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 126);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lammoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnIn);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(555, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Location = new System.Drawing.Point(182, 67);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 23);
            this.btn_lammoi.TabIndex = 1;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(182, 21);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 23);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(106, 67);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(64, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(21, 67);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(102, 21);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 23);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbMaLoai
            // 
            this.cbMaLoai.FormattingEnabled = true;
            this.cbMaLoai.Location = new System.Drawing.Point(346, 86);
            this.cbMaLoai.Name = "cbMaLoai";
            this.cbMaLoai.Size = new System.Drawing.Size(97, 24);
            this.cbMaLoai.TabIndex = 11;
            this.cbMaLoai.SelectedIndexChanged += new System.EventHandler(this.cbMaLoai_SelectedIndexChanged);
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.Location = new System.Drawing.Point(331, 49);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(96, 24);
            this.cbMaNXB.TabIndex = 10;
            this.cbMaNXB.SelectedIndexChanged += new System.EventHandler(this.cbMaNXB_SelectedIndexChanged);
            // 
            // cbMaTacGia
            // 
            this.cbMaTacGia.FormattingEnabled = true;
            this.cbMaTacGia.Location = new System.Drawing.Point(75, 88);
            this.cbMaTacGia.Name = "cbMaTacGia";
            this.cbMaTacGia.Size = new System.Drawing.Size(100, 24);
            this.cbMaTacGia.TabIndex = 9;
            this.cbMaTacGia.SelectedIndexChanged += new System.EventHandler(this.cbMaTacGia_SelectedIndexChanged);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(449, 86);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.ReadOnly = true;
            this.txtTenLoai.Size = new System.Drawing.Size(100, 22);
            this.txtTenLoai.TabIndex = 9;
            // 
            // txtSoTrang
            // 
            this.txtSoTrang.Location = new System.Drawing.Point(73, 49);
            this.txtSoTrang.Name = "txtSoTrang";
            this.txtSoTrang.Size = new System.Drawing.Size(100, 22);
            this.txtSoTrang.TabIndex = 8;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(286, 16);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(181, 22);
            this.txtTenSach.TabIndex = 7;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(433, 49);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.ReadOnly = true;
            this.txtTenNXB.Size = new System.Drawing.Size(100, 22);
            this.txtTenNXB.TabIndex = 8;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(75, 13);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(100, 22);
            this.txtMaSach.TabIndex = 6;
            // 
            // txtTenTacGia
            // 
            this.txtTenTacGia.Location = new System.Drawing.Point(181, 88);
            this.txtTenTacGia.Name = "txtTenTacGia";
            this.txtTenTacGia.ReadOnly = true;
            this.txtTenTacGia.Size = new System.Drawing.Size(100, 22);
            this.txtTenTacGia.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã Nhà xuất bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số trang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // grLstSach
            // 
            this.grLstSach.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grLstSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grLstSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_Sach,
            this.Ten_Sach,
            this.So_Trang,
            this.Ma_NhaXuatBan,
            this.Ma_TacGia,
            this.Ma_LoaiSach});
            this.grLstSach.Location = new System.Drawing.Point(5, 185);
            this.grLstSach.Name = "grLstSach";
            this.grLstSach.Size = new System.Drawing.Size(821, 211);
            this.grLstSach.TabIndex = 2;
            this.grLstSach.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grLstSach_CellDoubleClick);
            this.grLstSach.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grLstSach_RowHeaderMouseClick);
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.DataPropertyName = "Ma_Sach";
            this.Ma_Sach.HeaderText = "Mã Sách";
            this.Ma_Sach.Name = "Ma_Sach";
            this.Ma_Sach.ReadOnly = true;
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Tên Sách";
            this.Ten_Sach.Name = "Ten_Sach";
            this.Ten_Sach.ReadOnly = true;
            this.Ten_Sach.Width = 120;
            // 
            // So_Trang
            // 
            this.So_Trang.DataPropertyName = "So_Trang";
            this.So_Trang.HeaderText = "Số Trang";
            this.So_Trang.Name = "So_Trang";
            this.So_Trang.ReadOnly = true;
            // 
            // Ma_NhaXuatBan
            // 
            this.Ma_NhaXuatBan.DataPropertyName = "Ten_NhaXuatBan";
            this.Ma_NhaXuatBan.HeaderText = "Tên Nhà Xuất Bản";
            this.Ma_NhaXuatBan.Name = "Ma_NhaXuatBan";
            this.Ma_NhaXuatBan.ReadOnly = true;
            this.Ma_NhaXuatBan.Width = 150;
            // 
            // Ma_TacGia
            // 
            this.Ma_TacGia.DataPropertyName = "Ten_TacGia";
            this.Ma_TacGia.HeaderText = "Tên Tác Giả";
            this.Ma_TacGia.Name = "Ma_TacGia";
            this.Ma_TacGia.ReadOnly = true;
            this.Ma_TacGia.Width = 150;
            // 
            // Ma_LoaiSach
            // 
            this.Ma_LoaiSach.DataPropertyName = "Ten_LoaiSach";
            this.Ma_LoaiSach.HeaderText = "Tên Loại Sách";
            this.Ma_LoaiSach.Name = "Ma_LoaiSach";
            this.Ma_LoaiSach.ReadOnly = true;
            this.Ma_LoaiSach.Width = 158;
            // 
            // FrLstSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 406);
            this.Controls.Add(this.grLstSach);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrLstSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrLstSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grLstSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMaLoai;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private System.Windows.Forms.ComboBox cbMaTacGia;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtSoTrang;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtTenTacGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView grLstSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Trang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_TacGia;
        //private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_LoaiSach;
        private System.Windows.Forms.Button btn_lammoi;
    }
}