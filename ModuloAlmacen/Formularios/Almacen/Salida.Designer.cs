namespace ModuloAlmacen.Formularios.Almacen
{
    partial class Salida
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSeleccionarItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaEntregar = new System.Windows.Forms.DataGridView();
            this.id_EntradaDetalleColumna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadAgregar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtStockPecosa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStockAlmacen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPorEntregar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodItem = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCantTotal = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEntregar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionarItem
            // 
            this.btnSeleccionarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarItem.Location = new System.Drawing.Point(356, 37);
            this.btnSeleccionarItem.Name = "btnSeleccionarItem";
            this.btnSeleccionarItem.Size = new System.Drawing.Size(28, 23);
            this.btnSeleccionarItem.TabIndex = 0;
            this.btnSeleccionarItem.Text = "...";
            this.btnSeleccionarItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccionarItem.UseVisualStyleBackColor = true;
            this.btnSeleccionarItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lista Items por entregar";
            // 
            // dgvListaEntregar
            // 
            this.dgvListaEntregar.AllowUserToAddRows = false;
            this.dgvListaEntregar.AllowUserToResizeRows = false;
            this.dgvListaEntregar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaEntregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEntregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_EntradaDetalleColumna,
            this.CodItem,
            this.DescItem,
            this.StockActual,
            this.Cantidad,
            this.PrecioSalida,
            this.SubTotal});
            this.dgvListaEntregar.Location = new System.Drawing.Point(2, 214);
            this.dgvListaEntregar.Name = "dgvListaEntregar";
            this.dgvListaEntregar.RowHeadersVisible = false;
            this.dgvListaEntregar.Size = new System.Drawing.Size(841, 150);
            this.dgvListaEntregar.TabIndex = 19;
            // 
            // id_EntradaDetalleColumna
            // 
            this.id_EntradaDetalleColumna.HeaderText = "id_EntradaDetalleColumna";
            this.id_EntradaDetalleColumna.Name = "id_EntradaDetalleColumna";
            this.id_EntradaDetalleColumna.Visible = false;
            // 
            // CodItem
            // 
            this.CodItem.FillWeight = 59.67963F;
            this.CodItem.HeaderText = "Codigo";
            this.CodItem.Name = "CodItem";
            // 
            // DescItem
            // 
            this.DescItem.FillWeight = 243.6548F;
            this.DescItem.HeaderText = "Item";
            this.DescItem.Name = "DescItem";
            // 
            // StockActual
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.StockActual.DefaultCellStyle = dataGridViewCellStyle9;
            this.StockActual.FillWeight = 74.1664F;
            this.StockActual.HeaderText = "StockActual";
            this.StockActual.Name = "StockActual";
            // 
            // Cantidad
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle10;
            this.Cantidad.FillWeight = 74.1664F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioSalida
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PrecioSalida.DefaultCellStyle = dataGridViewCellStyle11;
            this.PrecioSalida.FillWeight = 74.1664F;
            this.PrecioSalida.HeaderText = "Precio Salida";
            this.PrecioSalida.Name = "PrecioSalida";
            // 
            // SubTotal
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle12;
            this.SubTotal.FillWeight = 74.1664F;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // txtCantidadAgregar
            // 
            this.txtCantidadAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadAgregar.Location = new System.Drawing.Point(568, 84);
            this.txtCantidadAgregar.Name = "txtCantidadAgregar";
            this.txtCantidadAgregar.Size = new System.Drawing.Size(98, 21);
            this.txtCantidadAgregar.TabIndex = 18;
            this.txtCantidadAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadAgregar.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidadAgregar_Validating);
            this.txtCantidadAgregar.Validated += new System.EventHandler(this.txtCantidadAgregar_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad a Entregar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(706, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "Agregar a lista Salida";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtStockPecosa
            // 
            this.txtStockPecosa.Enabled = false;
            this.txtStockPecosa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockPecosa.Location = new System.Drawing.Point(18, 84);
            this.txtStockPecosa.Name = "txtStockPecosa";
            this.txtStockPecosa.Size = new System.Drawing.Size(65, 21);
            this.txtStockPecosa.TabIndex = 15;
            this.txtStockPecosa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cant PECOSA";
            // 
            // txtDescItem
            // 
            this.txtDescItem.Enabled = false;
            this.txtDescItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescItem.Location = new System.Drawing.Point(18, 39);
            this.txtDescItem.Name = "txtDescItem";
            this.txtDescItem.Size = new System.Drawing.Size(332, 21);
            this.txtDescItem.TabIndex = 13;
            this.txtDescItem.Text = "                                         Seleccione Item ===>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descripcion Bien";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(16, 165);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(288, 20);
            this.txtEncargado.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entregado a cargo de :";
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Enabled = false;
            this.txtFechaSalida.Location = new System.Drawing.Point(371, 165);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.Size = new System.Drawing.Size(123, 20);
            this.txtFechaSalida.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha Salida";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtStockAlmacen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPorEntregar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCodItem);
            this.groupBox1.Controls.Add(this.txtDescItem);
            this.groupBox1.Controls.Add(this.btnSeleccionarItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStockPecosa);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCantidadAgregar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 111);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Item de PECOSA";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Stock Almacen";
            // 
            // txtStockAlmacen
            // 
            this.txtStockAlmacen.Enabled = false;
            this.txtStockAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockAlmacen.Location = new System.Drawing.Point(117, 84);
            this.txtStockAlmacen.Name = "txtStockAlmacen";
            this.txtStockAlmacen.Size = new System.Drawing.Size(65, 21);
            this.txtStockAlmacen.TabIndex = 24;
            this.txtStockAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Disponible";
            // 
            // txtPorEntregar
            // 
            this.txtPorEntregar.Enabled = false;
            this.txtPorEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorEntregar.Location = new System.Drawing.Point(226, 84);
            this.txtPorEntregar.Name = "txtPorEntregar";
            this.txtPorEntregar.Size = new System.Drawing.Size(65, 21);
            this.txtPorEntregar.TabIndex = 22;
            this.txtPorEntregar.Text = "0";
            this.txtPorEntregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Codigo Item";
            // 
            // txtCodItem
            // 
            this.txtCodItem.Enabled = false;
            this.txtCodItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodItem.Location = new System.Drawing.Point(409, 39);
            this.txtCodItem.Name = "txtCodItem";
            this.txtCodItem.Size = new System.Drawing.Size(85, 21);
            this.txtCodItem.TabIndex = 20;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(656, 370);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar Salida Almacen";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(758, 370);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button5_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblCantTotal
            // 
            this.lblCantTotal.AutoSize = true;
            this.lblCantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTotal.Location = new System.Drawing.Point(13, 375);
            this.lblCantTotal.Name = "lblCantTotal";
            this.lblCantTotal.Size = new System.Drawing.Size(102, 16);
            this.lblCantTotal.TabIndex = 29;
            this.lblCantTotal.Text = "Cantidad Total: ";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(223, 375);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(77, 16);
            this.lblValorTotal.TabIndex = 30;
            this.lblValorTotal.Text = "Valor Total:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(844, 400);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblCantTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFechaSalida);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvListaEntregar);
            this.MaximizeBox = false;
            this.Name = "Salida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida";
            this.Load += new System.EventHandler(this.Salida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEntregar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListaEntregar;
        private System.Windows.Forms.TextBox txtCantidadAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtStockPecosa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFechaSalida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblCantTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStockAlmacen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPorEntregar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_EntradaDetalleColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}