using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ModuloAlmacen.Reportes
{
    public partial class rptKardex : Form
    {
        public rptKardex()
        {
            InitializeComponent();
        }

        private void rptKardex_Load(object sender, EventArgs e)
        {
            this.vListaKardexInventarioTableAdapter.Fill(this.dBALMACENDataSet.vListaKardexInventario);

            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
