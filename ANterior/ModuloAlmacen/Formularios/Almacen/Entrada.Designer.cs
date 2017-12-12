namespace ModuloAlmacen.Formularios.Almacen
{
    partial class Entrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroPecosa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroPedido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.id_EntradaDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_CatalogoBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescBien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorEntregar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPecosa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Justificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_EntradaDetalle,
            this.id_CatalogoBien,
            this.DescBien,
            this.PrecioUnitario,
            this.Cantidad,
            this.SubTotal,
            this.PorEntregar,
            this.NroPecosa,
            this.NroPedido,
            this.Justificacion,
            this.FechaEntrada});
            this.dataGridView1.Location = new System.Drawing.Point(3, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 309);
            this.dataGridView1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Lista de items de PECOSA\'s en almacen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo Item";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(132, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNroPecosa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNroPedido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtDescItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Criterios de Filtro";
            // 
            // txtNroPecosa
            // 
            this.txtNroPecosa.Location = new System.Drawing.Point(409, 32);
            this.txtNroPecosa.Name = "txtNroPecosa";
            this.txtNroPecosa.Size = new System.Drawing.Size(100, 20);
            this.txtNroPecosa.TabIndex = 2;
            this.txtNroPecosa.TextChanged += new System.EventHandler(this.txtNroPecosa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nro PECOSA";
            // 
            // txtNroPedido
            // 
            this.txtNroPedido.Location = new System.Drawing.Point(537, 32);
            this.txtNroPedido.Name = "txtNroPedido";
            this.txtNroPedido.Size = new System.Drawing.Size(100, 20);
            this.txtNroPedido.TabIndex = 3;
            this.txtNroPedido.TextChanged += new System.EventHandler(this.txtNroPedido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nro Pedido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescItem
            // 
            this.txtDescItem.Location = new System.Drawing.Point(258, 32);
            this.txtDescItem.Name = "txtDescItem";
            this.txtDescItem.Size = new System.Drawing.Size(125, 20);
            this.txtDescItem.TabIndex = 1;
            this.txtDescItem.TextChanged += new System.EventHandler(this.txtDescItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre Item";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(792, 404);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(115, 26);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar Item";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(925, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 26);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // id_EntradaDetalle
            // 
            this.id_EntradaDetalle.HeaderText = "id_EntradaDetalle";
            this.id_EntradaDetalle.Name = "id_EntradaDetalle";
            this.id_EntradaDetalle.Visible = false;
            // 
            // id_CatalogoBien
            // 
            this.id_CatalogoBien.FillWeight = 84.07197F;
            this.id_CatalogoBien.HeaderText = "id_CatalogoBien";
            this.id_CatalogoBien.Name = "id_CatalogoBien";
            // 
            // DescBien
            // 
            this.DescBien.FillWeight = 417.0498F;
            this.DescBien.HeaderText = "Item";
            this.DescBien.Name = "DescBien";
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle1;
            this.PrecioUnitario.FillWeight = 60.85511F;
            this.PrecioUnitario.HeaderText = "Precio";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.FillWeight = 57.0272F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubTotal.FillWeight = 55.58097F;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // PorEntregar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PorEntregar.DefaultCellStyle = dataGridViewCellStyle4;
            this.PorEntregar.FillWeight = 54.05738F;
            this.PorEntregar.HeaderText = "PorEntregar";
            this.PorEntregar.Name = "PorEntregar";
            // 
            // NroPecosa
            // 
            this.NroPecosa.FillWeight = 52.45232F;
            this.NroPecosa.HeaderText = "Pecosa";
            this.NroPecosa.Name = "NroPecosa";
            // 
            // NroPedido
            // 
            this.NroPedido.FillWeight = 50.76143F;
            this.NroPedido.HeaderText = "Pedido";
            this.NroPedido.Name = "NroPedido";
            // 
            // Justificacion
            // 
            this.Justificacion.FillWeight = 84.07197F;
            this.Justificacion.HeaderText = "Justificacion";
            this.Justificacion.Name = "Justificacion";
            // 
            // FechaEntrada
            // 
            this.FechaEntrada.FillWeight = 84.07197F;
            this.FechaEntrada.HeaderText = "FechaEntrada";
            this.FechaEntrada.Name = "FechaEntrada";
            // 
            // Entrada
            // 
            this.AcceptButton = this.btnSeleccionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1052, 436);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Entrada";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada PECOSAS";
            this.Load += new System.EventHandler(this.Entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNroPecosa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_EntradaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_CatalogoBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescBien;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorEntregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPecosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Justificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrada;
    }
}