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

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Formularios.login login = Formularios.login.Instancia();
            login.Close();
        }

        private void configurarSIGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Formularios.Configs.ConexionSIGA().Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Desea cerrar la aplicacion", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Acerca_de.AcercaDe().Show();
        }

        private void seleccionarAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
