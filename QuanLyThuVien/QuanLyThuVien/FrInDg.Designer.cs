namespace QuanLyThuVien
{
    partial class FrInDg
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QLTVDataSetDg = new QuanLyThuVien.QLTVDataSetDg();
            this.LstDocGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LstDocGiaTableAdapter = new QuanLyThuVien.QLTVDataSetDgTableAdapters.LstDocGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSetDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstDocGiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LstDocGiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.RpInDg.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(694, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // QLTVDataSetDg
            // 
            this.QLTVDataSetDg.DataSetName = "QLTVDataSetDg";
            this.QLTVDataSetDg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LstDocGiaBindingSource
            // 
            this.LstDocGiaBindingSource.DataMember = "LstDocGia";
            this.LstDocGiaBindingSource.DataSource = this.QLTVDataSetDg;
            // 
            // LstDocGiaTableAdapter
            // 
            this.LstDocGiaTableAdapter.ClearBeforeFill = true;
            // 
            // FrInDg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrInDg";
            this.Text = "FrInDg";
            this.Load += new System.EventHandler(this.FrInDg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSetDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LstDocGiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LstDocGiaBindingSource;
        private QLTVDataSetDg QLTVDataSetDg;
        private QLTVDataSetDgTableAdapters.LstDocGiaTableAdapter LstDocGiaTableAdapter;

    }
}