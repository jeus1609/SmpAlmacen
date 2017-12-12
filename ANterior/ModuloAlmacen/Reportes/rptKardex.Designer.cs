namespace ModuloAlmacen.Reportes
{
    partial class rptKardex
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
            this.vListaKardexInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBALMACENDataSet = new ModuloAlmacen.DataSets.DBALMACENDataSet();
            this.vListaKardexInventarioTableAdapter = new ModuloAlmacen.DataSets.DBALMACENDataSetTableAdapters.vListaKardexInventarioTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vListaKardexInventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBALMACENDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vListaKardexInventarioBindingSource
            // 
            this.vListaKardexInventarioBindingSource.DataMember = "vListaKardexInventario";
            this.vListaKardexInventarioBindingSource.DataSource = this.dBALMACENDataSet;
            // 
            // dBALMACENDataSet
            // 
            this.dBALMACENDataSet.DataSetName = "DBALMACENDataSet";
            this.dBALMACENDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vListaKardexInventarioTableAdapter
            // 
            this.vListaKardexInventarioTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(505, 170);
            this.reportViewer1.TabIndex = 0;
            // 
            // rptKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 170);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptKardex";
            this.Text = "rptKardex";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vListaKardexInventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBALMACENDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DBALMACENDataSet dBALMACENDataSet;
        private System.Windows.Forms.BindingSource vListaKardexInventarioBindingSource;
        private DataSets.DBALMACENDataSetTableAdapters.vListaKardexInventarioTableAdapter vListaKardexInventarioTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}