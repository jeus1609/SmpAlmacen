using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloAlmacen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aLMACENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aLMACENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBALMACENDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBALMACENDataSet.ALMACEN' Puede moverla o quitarla según sea necesario.
            this.aLMACENTableAdapter.Fill(this.dBALMACENDataSet.ALMACEN);
            // TODO: esta línea de código carga datos en la tabla 'dBALMACENDataSet.ALMACEN' Puede moverla o quitarla según sea necesario.
            this.aLMACENTableAdapter.Fill(this.dBALMACENDataSet.ALMACEN);

        }

        private void aLMACENDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void aLMACENBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void aLMACENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aLMACENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBALMACENDataSet);

        }
    }
}
