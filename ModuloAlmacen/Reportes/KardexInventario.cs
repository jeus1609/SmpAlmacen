using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAlmacen.Reportes
{
    public partial class KardexInventario : Form
    {
        public KardexInventario()
        {
            InitializeComponent();
        }

        private void KardexInventario_Load(object sender, EventArgs e)
        {
            try
            {
                DataSets.dsALMACENTableAdapters.vListaKardexInventarioTableAdapter adapKardexInventario = new DataSets.dsALMACENTableAdapters.vListaKardexInventarioTableAdapter();
                DataSets.dsALMACEN dsAlmacen = new DataSets.dsALMACEN();
                adapKardexInventario.Fill(dsAlmacen.vListaKardexInventario);
                rptKardexInv rptKardex = new rptKardexInv();
                rptKardex.SetDataSource(dsAlmacen);
                this.crystalReportViewer1.ReportSource = rptKardex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
