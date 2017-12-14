using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuloAlmacen.Formularios
{
    public partial class Interfaz : Form
    {
        //Configs.Conexion conexion = Configs.Conexion.Instancia();
        string newCnnStr = Configs.Conexion.Instancia().DevolverCadena();
        //string newCnnStr = "Data Source=192.168.1.100;Initial Catalog=" + "SIGA" + ";Persist Security Info=True;User ID=sa;Password=Semo123";
        string sNroPecosa;
        string sNroPedido;
        bool bImportado = false;

        DBALMACENDataSet dsAlmacen = new DBALMACENDataSet();
        DataSets.dsSIGA dsSiga = new DataSets.dsSIGA();

        //SIGA
        DataSets.dsSIGATableAdapters.vListaPedidoDetalleTableAdapter adapListaPedidosDetalle = new DataSets.dsSIGATableAdapters.vListaPedidoDetalleTableAdapter();
        DataSets.dsSIGATableAdapters.vListaPedidosTableAdapter adapListaPedidos = new DataSets.dsSIGATableAdapters.vListaPedidosTableAdapter();
        
        //ALMACEN
        DataSets.dsALMACENTableAdapters.spConsultarSiExiste adapConsultarSiExiste = new DataSets.dsALMACENTableAdapters.spConsultarSiExiste();
        DataSets.dsALMACENTableAdapters.ENTRADATableAdapter adapEntrada = new DataSets.dsALMACENTableAdapters.ENTRADATableAdapter();
        DataSets.dsALMACENTableAdapters.ENTRADA_DETALLETableAdapter adapEntradaDetalle = new DataSets.dsALMACENTableAdapters.ENTRADA_DETALLETableAdapter();
        DataSets.dsALMACENTableAdapters.CATALOGO_BIENTableAdapter adapCatalogoBien = new DataSets.dsALMACENTableAdapters.CATALOGO_BIENTableAdapter();
        DataSets.dsALMACENTableAdapters.MOVIMIENTO_BIENTableAdapter adapMovimientoBien = new DataSets.dsALMACENTableAdapters.MOVIMIENTO_BIENTableAdapter();

        bool bListaCargada = false;

        public Interfaz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (DialogResult.Yes == MessageBox.Show("Esta Operacion puede demorar si no tiene buena conexion a Internet\n Desea Continuar", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                dataGridView1.Rows.Clear();
                try
                {
                    adapListaPedidos.Connection.ConnectionString = newCnnStr;

                    adapListaPedidos.FillByActProy(dsSiga.vListaPedidos, "2187136", int.Parse(txtAnio.Text));

                    foreach (DataRow row in dsSiga.vListaPedidos.Rows)
                    {
                        sNroPecosa = row["NRO_PECOSA"].ToString();
                        sNroPedido = row["NRO_PEDIDO"].ToString();

                        bImportado = (adapConsultarSiExiste.ConsultarSiExiste(int.Parse(txtAnio.Text), sNroPecosa, sNroPedido) == 0) ? false : true;

                        if (chkSoloNuevos.Checked)
                        {
                            if (!bImportado)
                            {
                                dataGridView1.Rows.Add(
                                    row["ANO_EJE"].ToString(),
                                    row["SEC_EJEC"].ToString(),
                                    row["TIPO_BIEN"].ToString(),
                                    row["TIPO_PEDIDO"].ToString(),
                                    sNroPedido,
                                    sNroPecosa,
                                    row["FECHA_PEDIDO"].ToString(),
                                    row["MOTIVO_PEDIDO"].ToString(),
                                    row["nombre_completo"].ToString(),
                                    bImportado,
                                    false
                                    );
                            }
                        }
                        else
                        {
                            dataGridView1.Rows.Add(
                                row["ANO_EJE"].ToString(),
                                row["SEC_EJEC"].ToString(),
                                row["TIPO_BIEN"].ToString(),
                                row["TIPO_PEDIDO"].ToString(),
                                sNroPedido,
                                sNroPecosa,
                                row["FECHA_PEDIDO"].ToString(),
                                row["MOTIVO_PEDIDO"].ToString(),
                                row["nombre_completo"].ToString(),
                                bImportado,
                                false
                                );
                        }
                    }

                    bListaCargada = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ListarDetallePedido()
        {
            dataGridView2.Rows.Clear();            
            adapListaPedidosDetalle.Connection.ConnectionString = newCnnStr;

            decimal ano_eje = decimal.Parse(dataGridView1["Anio", dataGridView1.CurrentCell.RowIndex].Value.ToString());
            decimal sec_ejec = decimal.Parse(dataGridView1["SecEjec", dataGridView1.CurrentCell.RowIndex].Value.ToString());
            string tipo_bien = dataGridView1["TipoBien", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string tipo_pedido = dataGridView1["TipoPedido", dataGridView1.CurrentCell.RowIndex].Value.ToString();
            string nro_pedido = dataGridView1["NroPedido", dataGridView1.CurrentCell.RowIndex].Value.ToString();

            adapListaPedidosDetalle.FillByDetallePedido(dsSiga.vListaPedidoDetalle, ano_eje, sec_ejec, tipo_bien, tipo_pedido, nro_pedido);

            foreach (DataRow row in dsSiga.vListaPedidoDetalle.Rows)
            {
                dataGridView2.Rows.Add(
                    row["CODIGO_ITEM"].ToString(),
                    row["NOMBRE_ITEM"].ToString(),
                    row["UNIDAD"].ToString(),
                    row["PRECIO_UNIT"].ToString(),
                    row["CANT_APROBADA"].ToString(),
                    row["VALOR_TOTAL"].ToString()
                    );
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            //ListarDetallePedido();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                //chk.Value = !(chk.Value == null ? false : (bool)chk.Value); //because chk.Value is initialy null
                chk.Value = !(chk.Value == null ? true : (bool)chk.Value); //because chk.Value is initialy null
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarDetallePedido();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            int ContadorImportacion = 0;

            decimal importarAnoEjec;
            decimal importarSecEjec;
            string importarTipoBien;
            string importarTipoPedido;

            int importarNroAlmacen = 1;
            string importarNroPecosa;
            string importarNroPedido;
            string importarNroOrden;
            string importarJustificacion;
            DateTime importarFechapedido = DateTime.Now;
            //DateTime importarFechaEntrada = DateTime.Now;
            bool importarEntregado = false;
            string importarSolicitante;

            int itentityEntrada;

            string impDetIdCatalogoBien;
            string impDetIdNombreItem;
            decimal impDetPrecioUnit;
            decimal impDetCant;
            decimal impDetPorEntregar;
            bool impDetEntregado;

            

            foreach (DataGridViewRow rowContarPedidos in dataGridView1.Rows)
            {
                DataGridViewCheckBoxCell chkPedidosSeleccionado = (DataGridViewCheckBoxCell)rowContarPedidos.Cells["Seleccionar"];
                if ((bool)chkPedidosSeleccionado.Value)
                    ContadorImportacion += 1;
            }

            if (DialogResult.Yes == MessageBox.Show("Se Importaran " + ContadorImportacion + " PECOSA's\nEsta Operacion puede demorar si no tiene buena conexion a Internet\n Desea Continuar", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                ContadorImportacion = 0;

                //try
                {
                    foreach (DataGridViewRow rowDataGrid1 in dataGridView1.Rows)
                    {
                        DataGridViewCheckBoxCell chkSeleccionar = (DataGridViewCheckBoxCell)rowDataGrid1.Cells["Seleccionar"];
                        if ((bool)chkSeleccionar.Value)//Importando Solo Seleccionados
                        {
                            importarAnoEjec = decimal.Parse(rowDataGrid1.Cells["Anio"].Value.ToString());
                            importarSecEjec = decimal.Parse(rowDataGrid1.Cells["SecEjec"].Value.ToString());
                            importarTipoBien = rowDataGrid1.Cells["TipoBien"].Value.ToString();
                            importarTipoPedido = rowDataGrid1.Cells["TipoPedido"].Value.ToString();

                            importarNroPecosa = rowDataGrid1.Cells["NroPecosa"].Value.ToString();
                            importarNroPedido = rowDataGrid1.Cells["NroPedido"].Value.ToString();
                            importarNroOrden = "No Se Encuentra";
                            importarJustificacion = rowDataGrid1.Cells["MotivoPedido"].Value.ToString();
                            importarFechapedido = DateTime.Parse(rowDataGrid1.Cells["FechaPedido"].Value.ToString());
                            //importarEntregado = 
                            importarSolicitante = rowDataGrid1.Cells["Solicitante"].Value.ToString();

                            itentityEntrada = int.Parse(adapEntrada.InsertItentity(importarNroAlmacen, importarNroPecosa, importarNroPedido, importarNroOrden, importarJustificacion, importarFechapedido, importarEntregado, importarSolicitante).ToString());
                            //MessageBox.Show(itentityEntrada.ToString());

                            //Consultando DetallePecosas
                            
                            
                            adapListaPedidosDetalle.Connection.ConnectionString = newCnnStr;

                            adapListaPedidosDetalle.FillByDetallePedido(dsSiga.vListaPedidoDetalle, importarAnoEjec, importarSecEjec, importarTipoBien, importarTipoPedido, importarNroPedido);

                            //Insertando detallePecosas
                            foreach (DataRow rowListaDetalle in dsSiga.vListaPedidoDetalle.Rows)
                            {
                                impDetIdCatalogoBien = rowListaDetalle["CODIGO_ITEM"].ToString(); ;
                                impDetIdNombreItem = string.Empty;//insertando valores nulos ya que no existe detalle u observacion
                                impDetPrecioUnit = decimal.Parse(rowListaDetalle["PRECIO_UNIT"].ToString());
                                impDetCant = decimal.Parse(rowListaDetalle["CANT_APROBADA"].ToString());
                                impDetPorEntregar = decimal.Parse(rowListaDetalle["CANT_APROBADA"].ToString());
                                impDetEntregado = false;

                                //Insertando a Catalogo
                                if (0 == adapCatalogoBien.SiExiste(impDetIdCatalogoBien))
                                    adapCatalogoBien.Insert(impDetIdCatalogoBien, impDetIdNombreItem);

                                //insertando Detalle
                                int id_Entrada_Detalle = int.Parse(adapEntradaDetalle.InsertIdentity(itentityEntrada, impDetIdCatalogoBien, impDetIdNombreItem, impDetPrecioUnit, impDetCant, impDetPorEntregar, impDetEntregado).ToString());

                                ContadorImportacion += 1;
                            }

                            //cambiando el check de importado
                            DataGridViewCheckBoxCell chkImportado = (DataGridViewCheckBoxCell)rowDataGrid1.Cells["Importado"];
                            chkSeleccionar.Value = false;
                            chkImportado.Value = true;

                            
                        }
                    }
                    MessageBox.Show("Se importaron " + ContadorImportacion.ToString() + " registros correctamente");
                }
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (bListaCargada)
            {
                //DataGridViewRow row = dataGridView1.CurrentRow;
                //DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)row.Cells["Importado"];
                //DataGridViewCheckBoxCell chk2 = (DataGridViewCheckBoxCell)row.Cells["Seleccionar"];
                //MessageBox.Show(chk1.Value.ToString() + " " + chk2.Value.ToString());

                foreach (DataGridViewRow rowDataGrid1 in dataGridView1.Rows)
                {
                    DataGridViewCheckBoxCell chk1 = (DataGridViewCheckBoxCell)rowDataGrid1.Cells["Importado"];
                    DataGridViewCheckBoxCell chk2 = (DataGridViewCheckBoxCell)rowDataGrid1.Cells["Seleccionar"];

                    if ((bool)chk1.Value)
                    {
                        if ((bool)chk2.Value)
                        {
                            MessageBox.Show("No Puede seleccionar este pedido ya que se encuentra importado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            chk2.Value = false;
                        }
                    }
                }
                //verificar cambiar estado check y previamente importado
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
