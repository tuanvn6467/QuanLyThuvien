namespace QuanLyThuVien
{
    partial class FrInLstSach
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ViewSelectLstSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLTVDataSetLstSach = new QuanLyThuVien.QLTVDataSetLstSach();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ViewSelectLstSachTableAdapter = new QuanLyThuVien.QLTVDataSetLstSachTableAdapters.ViewSelectLstSachTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSelectLstSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSetLstSach)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewSelectLstSachBindingSource
            // 
            this.ViewSelectLstSachBindingSource.DataMember = "ViewSelectLstSach";
            this.ViewSelectLstSachBindingSource.DataSource = this.QLTVDataSetLstSach;
            // 
            // QLTVDataSetLstSach
            // 
            this.QLTVDataSetLstSach.DataSetName = "QLTVDataSetLstSach";
            this.QLTVDataSetLstSach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetLstSach";
            reportDataSource2.Value = this.ViewSelectLstSachBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.Report.RpInLstSach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(894, 397);
            this.reportViewer1.TabIndex = 0;
            // 
            // ViewSelectLstSachTableAdapter
            // 
            this.ViewSelectLstSachTableAdapter.ClearBeforeFill = true;
            // 
            // FrInLstSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 397);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrInLstSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrInLstSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrInLstSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewSelectLstSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLTVDataSetLstSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ViewSelectLstSachBindingSource;
        private QLTVDataSetLstSach QLTVDataSetLstSach;
        private QLTVDataSetLstSachTableAdapters.ViewSelectLstSachTableAdapter ViewSelectLstSachTableAdapter;
    }
}