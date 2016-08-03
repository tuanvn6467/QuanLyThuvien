namespace QuanLyThuVien
{
    partial class FrLstLoaiSachEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiSach = new System.Windows.Forms.TextBox();
            this.txtTenMaLoaiSach = new System.Windows.Forms.TextBox();
            this.btnChapNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên mã loại sách";
            // 
            // txtMaLoaiSach
            // 
            this.txtMaLoaiSach.Location = new System.Drawing.Point(126, 54);
            this.txtMaLoaiSach.Name = "txtMaLoaiSach";
            this.txtMaLoaiSach.Size = new System.Drawing.Size(217, 22);
            this.txtMaLoaiSach.TabIndex = 2;
            // 
            // txtTenMaLoaiSach
            // 
            this.txtTenMaLoaiSach.Location = new System.Drawing.Point(153, 99);
            this.txtTenMaLoaiSach.Name = "txtTenMaLoaiSach";
            this.txtTenMaLoaiSach.Size = new System.Drawing.Size(217, 22);
            this.txtTenMaLoaiSach.TabIndex = 3;
            // 
            // btnChapNhan
            // 
            this.btnChapNhan.Location = new System.Drawing.Point(74, 148);
            this.btnChapNhan.Name = "btnChapNhan";
            this.btnChapNhan.Size = new System.Drawing.Size(108, 32);
            this.btnChapNhan.TabIndex = 4;
            this.btnChapNhan.Text = "Chấp Nhận";
            this.btnChapNhan.UseVisualStyleBackColor = true;
            this.btnChapNhan.Click += new System.EventHandler(this.btnChapNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(235, 148);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 32);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // FrLstLoaiSachEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 190);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChapNhan);
            this.Controls.Add(this.txtTenMaLoaiSach);
            this.Controls.Add(this.txtMaLoaiSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrLstLoaiSachEdit";
            this.Text = "FrLstLoaiSachEdit";
            //this.Load += new System.EventHandler(this.FrLstLoaiSachEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtMaLoaiSach;
        public System.Windows.Forms.TextBox txtTenMaLoaiSach;
        private System.Windows.Forms.Button btnChapNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}