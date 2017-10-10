namespace TccBiblioteca
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            this.VisitasPorMotivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdbibliotecaDataSet = new TccBiblioteca.bdbibliotecaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VisitasPorMotivo = new TccBiblioteca.bdbibliotecaDataSetTableAdapters.VisitasPorMotivo();
            ((System.ComponentModel.ISupportInitialize)(this.VisitasPorMotivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdbibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // VisitasPorMotivoBindingSource
            // 
            this.VisitasPorMotivoBindingSource.DataMember = "VisitasPorMotivo";
            this.VisitasPorMotivoBindingSource.DataSource = this.bdbibliotecaDataSet;
            // 
            // bdbibliotecaDataSet
            // 
            this.bdbibliotecaDataSet.DataSetName = "bdbibliotecaDataSet";
            this.bdbibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVisitas";
            reportDataSource1.Value = this.VisitasPorMotivoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TccBiblioteca.RelatorioVisitas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(647, 381);
            this.reportViewer1.TabIndex = 0;
            // 
            // VisitasPorMotivo
            // 
            this.VisitasPorMotivo.ClearBeforeFill = true;
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 381);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Relatorio";
            this.Text = "Relatório";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio_FormClosing);
            this.Load += new System.EventHandler(this.Relatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisitasPorMotivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdbibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VisitasPorMotivoBindingSource;
        private bdbibliotecaDataSet bdbibliotecaDataSet;
        private bdbibliotecaDataSetTableAdapters.VisitasPorMotivo VisitasPorMotivo;
    }
}