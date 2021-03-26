namespace Social_Network_Rental.Presentacion.Reportes
{
    partial class frmReporteInmuebleCategoria
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
            this.DataSet1 = new Social_Network_Rental.Presentacion.Reportes.DataSet1();
            this.USP_Inmueble_SBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_Inmueble_STableAdapter = new Social_Network_Rental.Presentacion.Reportes.DataSet1TableAdapters.USP_Inmueble_STableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Inmueble_SBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_Inmueble_SBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Social_Network_Rental.Presentacion.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_Inmueble_SBindingSource
            // 
            this.USP_Inmueble_SBindingSource.DataMember = "USP_Inmueble_S";
            this.USP_Inmueble_SBindingSource.DataSource = this.DataSet1;
            // 
            // USP_Inmueble_STableAdapter
            // 
            this.USP_Inmueble_STableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteInmuebleCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteInmuebleCategoria";
            this.Text = "frmReporteInmuebleCategoria";
            this.Load += new System.EventHandler(this.frmReporteInmuebleCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_Inmueble_SBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_Inmueble_SBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.USP_Inmueble_STableAdapter USP_Inmueble_STableAdapter;
    }
}