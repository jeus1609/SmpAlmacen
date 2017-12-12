using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios.Almacen
{
    public partial class Entrada : Form
    {
        DataSets.dsALMACEN dsAlmacen;
        DataSets.dsALMACENTableAdapters.vListaEntradaTableAdapter adapListaEntrada;

        string sCodigoItem;

        public string SCodigoItem
        {
            get { return sCodigoItem; }
            set { sCodigoItem = value; }
        }
        string sDescItem;

        public string SDescItem
        {
            get { return sDescItem; }
            set { sDescItem = value; }
        }
        string sPrecioUnitario;

        public string SPrecioUnitario
        {
            get { return sPrecioUnitario; }
            set { sPrecioUnitario = value; }
        }
        string sCantidad;

        public string SCantidad
        {
            get { return sCantidad; }
            set { sCantidad = value; }
        }
        string sPorEntregar;

        public string SPorEntregar
        {
            get { return sPorEntregar; }
            set { sPorEntregar = value; }
        }

        string sIdEntradaDetalle;

        public string SIdEntradaDetalle
        {
            get { return sIdEntradaDetalle; }
            set { sIdEntradaDetalle = value; }
        }

        public Entrada()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SIdEntradaDetalle = dataGridView1["id_EntradaDetalle", dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SCodigoItem = dataGridView1["id_CatalogoBien", dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SDescItem = dataGridView1["DescBien", dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SPrecioUnitario = dataGridView1["PrecioUnitario", dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SCantidad = dataGridView1["Cantidad", dataGridView1.CurrentCell.RowIndex].Value.ToString();
                SPorEntregar = dataGridView1["PorEntregar", dataGridView1.CurrentCell.RowIndex].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros para seleccionar, Error: " + ex.Message);
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            ListarFiltro();
        }

        private void ListarFiltro()
        {
            dataGridView1.Rows.Clear();
            dsAlmacen = new DataSets.dsALMACEN();
            adapListaEntrada = new DataSets.dsALMACENTableAdapters.vListaEntradaTableAdapter();

            adapListaEntrada.FillFiltros(dsAlmacen.vListaEntrada, "%" + txtCodigo.Text + "%", "%" + txtDescItem.Text + "%", "%" + txtNroPecosa.Text + "%", "%" + txtNroPedido.Text + "%", false);

            string sIdEntradaDetalle;
            string sNroPecosa;
            string sNroPedido;
            string sJustificacion;
            string sFechaEntrada;
            string sFechaPedido;
            string sCodItem;
            string sDescBien;
            string sPrecioUnitario;
            string sCantidad;
            string sSubTotal;
            string sPorEntregar;

            foreach (DataRow row in dsAlmacen.vListaEntrada.Rows)
            {
                sCodItem = row["id_CatalogoBien"].ToString();
                sDescBien = row["DescBien"].ToString();
                sPrecioUnitario = row["PrecioUnitario"].ToString();
                sCantidad = row["Cantidad"].ToString();
                sSubTotal = row["SubTotal"].ToString();
                sPorEntregar = row["PorEntregar"].ToString();
                sNroPecosa = row["NroPecosa"].ToString();
                sNroPedido = row["NroPedido"].ToString();
                sJustificacion = row["Justificacion"].ToString();
                sFechaPedido = row["FechaPedido"].ToString();
                sFechaEntrada = row["FechaEntrada"].ToString();
                sIdEntradaDetalle = row["id_EntradaDetalle"].ToString();

                dataGridView1.Rows.Add(sIdEntradaDetalle, sCodItem, sDescBien, sPrecioUnitario, sCantidad, sSubTotal, sPorEntregar, sNroPecosa, sNroPedido, sJustificacion, sFechaEntrada);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarFiltro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ListarFiltro();
        }

        private void txtDescItem_TextChanged(object sender, EventArgs e)
        {
            ListarFiltro();
        }

        private void txtNroPecosa_TextChanged(object sender, EventArgs e)
        {
            ListarFiltro();
        }

        private void txtNroPedido_TextChanged(object sender, EventArgs e)
        {
            ListarFiltro();
        }
    }
}
