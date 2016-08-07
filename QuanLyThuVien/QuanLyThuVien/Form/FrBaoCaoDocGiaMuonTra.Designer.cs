namespace QuanLyThuVien
{
    partial class FrBaoCaoDocGiaMuonTra
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
            this.GrDocGiaMuonSach = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.So_Phieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Sach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Muon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_TraDuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrDocGiaMuonSach)).BeginInit();
            this.SuspendLayout();
            // 
            // GrDocGiaMuonSach
            // 
            this.GrDocGiaMuonSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrDocGiaMuonSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.So_Phieu,
            this.Ma_DocGia,
            this.Ten_DocGia,
            this.Ma_Sach,
            this.So_Luong,
            this.Ten_Sach,
            this.Ngay_Muon,
            this.Ngay_TraDuKien});
            this.GrDocGiaMuonSach.Location = new System.Drawing.Point(7, 29);
            this.GrDocGiaMuonSach.Name = "GrDocGiaMuonSach";
            this.GrDocGiaMuonSach.ReadOnly = true;
            this.GrDocGiaMuonSach.Size = new System.Drawing.Size(947, 357);
            this.GrDocGiaMuonSach.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(700, 392);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông tin độc giả mượn trả sách";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(813, 392);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(87, 34);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // So_Phieu
            // 
            this.So_Phieu.DataPropertyName = "So_Phieu";
            this.So_Phieu.HeaderText = "Số phiếu";
            this.So_Phieu.Name = "So_Phieu";
            this.So_Phieu.ReadOnly = true;
            // 
            // Ma_DocGia
            // 
            this.Ma_DocGia.DataPropertyName = "Ma_DocGia";
            this.Ma_DocGia.HeaderText = "Mã Độc Giả";
            this.Ma_DocGia.Name = "Ma_DocGia";
            this.Ma_DocGia.ReadOnly = true;
            // 
            // Ten_DocGia
            // 
            this.Ten_DocGia.DataPropertyName = "Ten_DocGia";
            this.Ten_DocGia.HeaderText = "Tên Độc Giả";
            this.Ten_DocGia.Name = "Ten_DocGia";
            this.Ten_DocGia.ReadOnly = true;
            this.Ten_DocGia.Width = 150;
            // 
            // Ma_Sach
            // 
            this.Ma_Sach.DataPropertyName = "Ma_Sach";
            this.Ma_Sach.HeaderText = "Mã Sách";
            this.Ma_Sach.Name = "Ma_Sach";
            this.Ma_Sach.ReadOnly = true;
            // 
            // So_Luong
            // 
            this.So_Luong.DataPropertyName = "So_Luong";
            this.So_Luong.HeaderText = "Số Lượng";
            this.So_Luong.Name = "So_Luong";
            this.So_Luong.ReadOnly = true;
            // 
            // Ten_Sach
            // 
            this.Ten_Sach.DataPropertyName = "Ten_Sach";
            this.Ten_Sach.HeaderText = "Tên Sách";
            this.Ten_Sach.Name = "Ten_Sach";
            this.Ten_Sach.ReadOnly = true;
            // 
            // Ngay_Muon
            // 
            this.Ngay_Muon.DataPropertyName = "Ngay_Muon";
            this.Ngay_Muon.HeaderText = "Ngày Mượn";
            this.Ngay_Muon.Name = "Ngay_Muon";
            this.Ngay_Muon.ReadOnly = true;
            this.Ngay_Muon.Width = 125;
            // 
            // Ngay_TraDuKien
            // 
            this.Ngay_TraDuKien.DataPropertyName = "Ngay_TraDuKien";
            this.Ngay_TraDuKien.HeaderText = "Ngày Trả Dự Kiến";
            this.Ngay_TraDuKien.Name = "Ngay_TraDuKien";
            this.Ngay_TraDuKien.ReadOnly = true;
            this.Ngay_TraDuKien.Width = 125;
            // 
            // FrBaoCaoDocGiaMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 438);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.GrDocGiaMuonSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "FrBaoCaoDocGiaMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Mượn Trả";
            this.Load += new System.EventHandler(this.FrLstDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrDocGiaMuonSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        public System.Windows.Forms.DataGridView GrDocGiaMuonSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Phieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Sach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Muon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_TraDuKien;
    }
}