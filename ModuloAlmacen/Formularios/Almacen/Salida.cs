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
    public partial class Salida : Form
    {
        DBALMACENDataSet dsAlmacen = new DBALMACENDataSet();
        DataSets.dsALMACENTableAdapters.spConsultarSiExiste adapAlmacen = new DataSets.dsALMACENTableAdapters.spConsultarSiExiste();

        string sIdEntradaDetalle;

        public string SIdEntradaDetalle
        {
            get { return sIdEntradaDetalle; }
            set { sIdEntradaDetalle = value; }
        }
        string sPrecioSalida;

        public string SPrecioSalida
        {
            get { return sPrecioSalida; }
            set { sPrecioSalida = value; }
        }
        string sSubTotal;

        public string SSubTotal
        {
            get { return sSubTotal; }
            set { sSubTotal = value; }
        }

        public Salida()
        {
            InitializeComponent();
        }

        decimal cantItemPorEntregarPecosa;

        public decimal CantItemPorEntregarPecosa
        {
            get { return cantItemPorEntregarPecosa; }
            set { cantItemPorEntregarPecosa = value; }
        }


        decimal cantTotalTabla;
        decimal montoTotalTabla;

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada frmEntrada = new Entrada();
            if (DialogResult.OK == frmEntrada.ShowDialog())
            {
                // cargando stock de MovimientoBien      MessageBox.Show(frmEntrada.SCodigoItem);
                txtStockAlmacen.Text = adapAlmacen.StockActualItem(frmEntrada.SCodigoItem).ToString();

                txtCodItem.Text = frmEntrada.SCodigoItem;
                txtDescItem.Text = frmEntrada.SDescItem;
                txtStockPecosa.Text = frmEntrada.SCantidad;//************************************* VERIFICAR STOCK ACTUAL

                CantItemPorEntregarPecosa = decimal.Parse(frmEntrada.SPorEntregar);
                txtPorEntregar.Text = (decimal.Parse(frmEntrada.SPorEntregar) - cantEnTabla(frmEntrada.SCodigoItem)).ToString();

                this.SIdEntradaDetalle = frmEntrada.SIdEntradaDetalle;
                this.SPrecioSalida = frmEntrada.SPrecioUnitario;
                this.errorProvider1.SetError(btnSeleccionarItem, "");

                txtCantidadAgregar.Text = "0";
                txtCantidadAgregar.SelectAll();
                txtCantidadAgregar.Focus();
            }
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            txtFechaSalida.Text = DateTime.Now.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodItem.Text))
            {
                if (decimal.Parse(txtCantidadAgregar.Text) != 0)
                {
                    int rowId = verificarSiExisteItem(txtCodItem.Text);
                    string cantidadAgregar = txtCantidadAgregar.Text;

                    if (rowId == -1)// -1 no existe
                    {
                        rowId = dgvListaEntregar.Rows.Add();
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtCantidadAgregar.Text))
                        {
                            MessageBox.Show("no valido");
                        }
                        cantidadAgregar = (decimal.Parse(dgvListaEntregar["Cantidad", rowId].Value.ToString()) + decimal.Parse(cantidadAgregar)).ToString();
                    }

                    DataGridViewRow row = dgvListaEntregar.Rows[rowId];

                    row.Cells["CodItem"].Value = txtCodItem.Text;
                    row.Cells["DescItem"].Value = txtDescItem.Text;
                    row.Cells["StockActual"].Value = txtStockPecosa.Text;
                    row.Cells["Cantidad"].Value = cantidadAgregar;
                    row.Cells["PrecioSalida"].Value = this.SPrecioSalida;
                    row.Cells["SubTotal"].Value = this.SSubTotal;
                    row.Cells["id_EntradaDetalleColumna"].Value = this.SIdEntradaDetalle;

                    txtCantidadAgregar.Text = "0";

                    decimal localPorEntregar = CantItemPorEntregarPecosa - cantEnTabla(txtCodItem.Text);
                    txtPorEntregar.Text = localPorEntregar.ToString();
                    updateTotal();
                    //txtCodItem.Text = "";
                }
                else
                    this.errorProvider1.SetError(txtCantidadAgregar, "Ingrese cantidad distinta a cero");
            }
            else
                this.errorProvider1.SetError(btnSeleccionarItem, "Seleccione item");
        }

        private int verificarSiExisteItem(string Item)
        {
            int retorno = -1;
            foreach (DataGridViewRow rowDataGrid1 in dgvListaEntregar.Rows)
            {
                if (rowDataGrid1.Cells["CodItem"].Value.ToString() == Item)//Importando Solo Seleccionados
                {
                    retorno = rowDataGrid1.Index;
                    continue;
                }
            }
            return retorno;
        }

        private void txtCantidadAgregar_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!validandoCantidad(txtCantidadAgregar, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtCantidadAgregar.Select(0, txtCantidadAgregar.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(txtCantidadAgregar, errorMsg);
            }
        }

        private bool validandoCantidad(TextBox cajaTexto, out string errorMensaje)
        {
            decimal parsedValue;
           

            if (!decimal.TryParse(txtStockPecosa.Text, out parsedValue))// validando si existe stock
            {
                errorMensaje = "";
                return true;
            }            

            if (!decimal.TryParse(cajaTexto.Text, out parsedValue))
            {
                errorMensaje = "Ingrese Solo numeros";
                return false;
            }

            if (decimal.Parse(cajaTexto.Text) < 0)
            {
                errorMensaje = "Ingrese cantidad positiva y mayor a cero";
                return false;
            }
            
            decimal localPorEntregar = CantItemPorEntregarPecosa - cantEnTabla(txtCodItem.Text);
            txtPorEntregar.Text = localPorEntregar.ToString();
            if (localPorEntregar < decimal.Parse(cajaTexto.Text))
            {
                if (localPorEntregar == 0)
                {
                    errorMensaje = "Ingrese cantidad 0 ya que no hay mas disponible";
                }
                else
                    errorMensaje = "Ingrese cantidad menor o igual a la existente en la PECOSA";
                return false;
            }

            //si todos los filtros anteriores entonces todo bien y continua el evento
            if (decimal.TryParse(cajaTexto.Text, out parsedValue))
            {
                errorMensaje = "";
                return true;
            }

            errorMensaje = "la cantidad no es valida";
            return false;
        }
                
        private void txtCantidadAgregar_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCantidadAgregar, "");
        }

        private decimal cantEnTabla(string CodigoItem)
        {
            decimal cantiTabla = 0;
            foreach (DataGridViewRow rowDataGrid1 in dgvListaEntregar.Rows)
            {
                if (rowDataGrid1.Cells["CodItem"].Value.ToString() == CodigoItem)
                {
                    cantiTabla += decimal.Parse(rowDataGrid1.Cells["Cantidad"].Value.ToString());
                }
            }
            return cantiTabla;
        }

        private void updateTotal()
        {
            cantTotalTabla = 0;
            montoTotalTabla = 0;
            decimal localTotal;
            decimal localCantidad;

            foreach (DataGridViewRow rowDataGrid1 in dgvListaEntregar.Rows)
            {                
                //decimal salida;
                //decimal cant = (decimal.TryParse(rowDataGrid1.Cells["CodItem"].Value.ToString(), out salida) ? salida : 0)
                localCantidad = decimal.Parse(rowDataGrid1.Cells["Cantidad"].Value.ToString());
                localTotal = localCantidad * decimal.Parse(rowDataGrid1.Cells["PrecioSalida"].Value.ToString());
                rowDataGrid1.Cells["SubTotal"].Value = localTotal.ToString();

                //if (rowDataGrid1.Cells["CodItem"].Value.ToString() == Item)//Importando Solo Seleccionados
                //{
                //    retorno = rowDataGrid1.Index;
                //    continue;
                //}
                montoTotalTabla += localTotal;
                cantTotalTabla += localCantidad;
            }
            lblValorTotal.Text = "Valor Total:      S/ " + montoTotalTabla.ToString();
            lblCantTotal.Text = "Cantidad Total:    " + cantTotalTabla.ToString(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEncargado.Text))
            {
                if (dgvListaEntregar.RowCount != 0)
                {
                    DataSets.dsALMACENTableAdapters.SALIDATableAdapter adapSalida = new DataSets.dsALMACENTableAdapters.SALIDATableAdapter();
                    DataSets.dsALMACENTableAdapters.SALIDA_DETALLETableAdapter adapSalidaDetalle = new DataSets.dsALMACENTableAdapters.SALIDA_DETALLETableAdapter();
                    DataSets.dsALMACENTableAdapters.ENTRADA_DETALLETableAdapter adapEntradaDetalle = new DataSets.dsALMACENTableAdapters.ENTRADA_DETALLETableAdapter();

                    try
                    {
                        adapSalida.Transaction = adapSalidaDetalle.Transaction;

                        int idSalida = int.Parse(adapSalida.InsertIdentity(txtEncargado.Text).ToString());
                        //MessageBox.Show(idSalida.ToString());
                        int localid_EntradaDetalleColumna;
                        decimal localCantidad;
                        decimal localPrecioSalida;

                        foreach (DataGridViewRow rowDataGrid1 in dgvListaEntregar.Rows)
                        {
                            localid_EntradaDetalleColumna = int.Parse(rowDataGrid1.Cells["id_EntradaDetalleColumna"].Value.ToString());
                            localCantidad = decimal.Parse(rowDataGrid1.Cells["Cantidad"].Value.ToString());
                            localPrecioSalida = decimal.Parse(rowDataGrid1.Cells["PrecioSalida"].Value.ToString());

                            adapEntradaDetalle.UpPorEntregar(-1 * localCantidad, localid_EntradaDetalleColumna);//quitando cantidad por entregar en entrada_detalle

                            adapSalidaDetalle.Insert(idSalida, localid_EntradaDetalleColumna, localCantidad, localPrecioSalida);
                        }

                        MessageBox.Show("Registros Guardados Correctamente");
                        btnGuardar.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //throw;
                    }
                    finally
                    {
                        adapSalida.Connection.Close();
                        btnSalir.Text = "Salir";
                    }
                }
            }
            else
            {
                this.errorProvider1.SetError(txtEncargado, "Ingrese Responsable");
            }
        }
    }
}
