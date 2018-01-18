using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios.Mantenimiento
{
    public partial class UbicacionAlmacen : Form
    {
        public UbicacionAlmacen()
        {
            InitializeComponent();
        }

        private void aLMACENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLMACENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsALMACEN);
            codigoUnicoTextBox.Enabled = false;
        }

        private void UbicacionAlmacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsALMACEN.ALMACEN' Puede moverla o quitarla según sea necesario.
            this.aLMACENTableAdapter.Fill(this.dsALMACEN.ALMACEN);
        }

        private void btnPredeterminado_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AnioAlmacen = anioAlmacenTextBox.Text;
            Properties.Settings.Default.NombrePi = nombreProyectoTextBox.Text;
            Properties.Settings.Default.DireccionPi = direccionCompletaTextBox.Text;
            Properties.Settings.Default.CodigoUnicoPi = codigoUnicoTextBox.Text;
            Properties.Settings.Default.IdAlmacen = id_AlmacenTextBox.Text;            
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            MessageBox.Show("Proyecto con codigo " + Properties.Settings.Default.CodigoUnicoPi + " y almacen " + Properties.Settings.Default.IdAlmacen + " se establecio como predeterminado");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Tenga en cuenta que si hace un cambio de Codigo unico es posible que se mesclen Pecosas de Proyectos distintos, por tanto se recomienda crear un nuevo almacen y asignar un nuevo Codigo Unico.\nEsta seguro de continuar","LEER",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            codigoUnicoTextBox.Enabled = true;
        }
    }
}
