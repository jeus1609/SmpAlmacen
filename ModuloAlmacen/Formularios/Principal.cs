using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salidaAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Almacen.Salida newSalida = new Almacen.Salida();
            newSalida.MdiParent = this;
            newSalida.Show();
        }

        private void importarPECOSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interfaz frmInterfaz = new Interfaz();
            frmInterfaz.MdiParent = this;
            frmInterfaz.Show();
        }

        private void kardexDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Reportes.KardexInventario().Show();
        }
    }
}
