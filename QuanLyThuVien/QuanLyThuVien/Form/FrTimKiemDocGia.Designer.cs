namespace QuanLyThuVien
{
    partial class FrTimKiemDocGia
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ma_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_DocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Lap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_HetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm theo ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 22);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_DocGia,
            this.Ten_DocGia,
            this.Dia_Chi,
            this.So_DienThoai,
            this.Ngay_Sinh,
            this.Ngay_Lap,
            this.Ngay_HetHan});
            this.dataGridView1.Location = new System.Drawing.Point(20, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 264);
            this.dataGridView1.TabIndex = 5;
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
            // Dia_Chi
            // 
            this.Dia_Chi.DataPropertyName = "Dia_Chi";
            this.Dia_Chi.HeaderText = "Địa chỉ";
            this.Dia_Chi.Name = "Dia_Chi";
            this.Dia_Chi.ReadOnly = true;
            this.Dia_Chi.Width = 150;
            // 
            // So_DienThoai
            // 
            this.So_DienThoai.DataPropertyName = "So_DienThoai";
            this.So_DienThoai.HeaderText = "Số Điện Thoại";
            this.So_DienThoai.Name = "So_DienThoai";
            this.So_DienThoai.ReadOnly = true;
            // 
            // Ngay_Sinh
            // 
            this.Ngay_Sinh.DataPropertyName = "Ngay_Sinh";
            this.Ngay_Sinh.HeaderText = "Ngày Sinh";
            this.Ngay_Sinh.Name = "Ngay_Sinh";
            this.Ngay_Sinh.ReadOnly = true;
            // 
            // Ngay_Lap
            // 
            this.Ngay_Lap.DataPropertyName = "Ngay_Lap";
            this.Ngay_Lap.HeaderText = "Ngày Lập";
            this.Ngay_Lap.Name = "Ngay_Lap";
            this.Ngay_Lap.ReadOnly = true;
            // 
            // Ngay_HetHan
            // 
            this.Ngay_HetHan.DataPropertyName = "Ngay_HetHan";
            this.Ngay_HetHan.HeaderText = "Ngày Hết Hạn";
            this.Ngay_HetHan.Name = "Ngay_HetHan";
            this.Ngay_HetHan.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TRA CỨU THÔNG TIN ĐỘC GIẢ";
            // 
            // FrTimKiemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrTimKiemDocGia";
            this.Text = "FrTimKiemDocGia";
            this.Load += new System.EventHandler(this.FrTimKiemDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_DocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_DienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Lap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_HetHan;
        private System.Windows.Forms.Label label3;
    }
}