namespace ModuloAlmacen.Formularios.Mantenimiento
{
    partial class UbicacionAlmacen
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
            System.Windows.Forms.Label id_AlmacenLabel;
            System.Windows.Forms.Label anioAlmacenLabel;
            System.Windows.Forms.Label nombreProyectoLabel;
            System.Windows.Forms.Label direccionCompletaLabel;
            System.Windows.Forms.Label id_piLabel;
            System.Windows.Forms.Label id_UsuarioLabel;
            System.Windows.Forms.Label codigoUnicoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UbicacionAlmacen));
            this.label2 = new System.Windows.Forms.Label();
            this.aLMACENBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aLMACENBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_AlmacenTextBox = new System.Windows.Forms.TextBox();
            this.anioAlmacenTextBox = new System.Windows.Forms.TextBox();
            this.nombreProyectoTextBox = new System.Windows.Forms.TextBox();
            this.direccionCompletaTextBox = new System.Windows.Forms.TextBox();
            this.id_piTextBox = new System.Windows.Forms.TextBox();
            this.id_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.codigoUnicoTextBox = new System.Windows.Forms.TextBox();
            this.aLMACENDataGridView = new System.Windows.Forms.DataGridView();
            this.btnPredeterminado = new System.Windows.Forms.Button();
            this.aLMACENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsALMACEN = new ModuloAlmacen.DataSets.dsALMACEN();
            this.aLMACENTableAdapter = new ModuloAlmacen.DataSets.dsALMACENTableAdapters.ALMACENTableAdapter();
            this.tableAdapterManager = new ModuloAlmacen.DataSets.dsALMACENTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            id_AlmacenLabel = new System.Windows.Forms.Label();
            anioAlmacenLabel = new System.Windows.Forms.Label();
            nombreProyectoLabel = new System.Windows.Forms.Label();
            direccionCompletaLabel = new System.Windows.Forms.Label();
            id_piLabel = new System.Windows.Forms.Label();
            id_UsuarioLabel = new System.Windows.Forms.Label();
            codigoUnicoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENBindingNavigator)).BeginInit();
            this.aLMACENBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsALMACEN)).BeginInit();
            this.SuspendLayout();
            // 
            // id_AlmacenLabel
            // 
            id_AlmacenLabel.AutoSize = true;
            id_AlmacenLabel.Location = new System.Drawing.Point(416, 51);
            id_AlmacenLabel.Name = "id_AlmacenLabel";
            id_AlmacenLabel.Size = new System.Drawing.Size(62, 13);
            id_AlmacenLabel.TabIndex = 4;
            id_AlmacenLabel.Text = "id Almacen:";
            // 
            // anioAlmacenLabel
            // 
            anioAlmacenLabel.AutoSize = true;
            anioAlmacenLabel.Location = new System.Drawing.Point(29, 51);
            anioAlmacenLabel.Name = "anioAlmacenLabel";
            anioAlmacenLabel.Size = new System.Drawing.Size(73, 13);
            anioAlmacenLabel.TabIndex = 6;
            anioAlmacenLabel.Text = "Año Almacen:";
            // 
            // nombreProyectoLabel
            // 
            nombreProyectoLabel.AutoSize = true;
            nombreProyectoLabel.Location = new System.Drawing.Point(29, 77);
            nombreProyectoLabel.Name = "nombreProyectoLabel";
            nombreProyectoLabel.Size = new System.Drawing.Size(92, 13);
            nombreProyectoLabel.TabIndex = 8;
            nombreProyectoLabel.Text = "Nombre Proyecto:";
            // 
            // direccionCompletaLabel
            // 
            direccionCompletaLabel.AutoSize = true;
            direccionCompletaLabel.Location = new System.Drawing.Point(29, 103);
            direccionCompletaLabel.Name = "direccionCompletaLabel";
            direccionCompletaLabel.Size = new System.Drawing.Size(102, 13);
            direccionCompletaLabel.TabIndex = 10;
            direccionCompletaLabel.Text = "Direccion Completa:";
            // 
            // id_piLabel
            // 
            id_piLabel.AutoSize = true;
            id_piLabel.Location = new System.Drawing.Point(416, 77);
            id_piLabel.Name = "id_piLabel";
            id_piLabel.Size = new System.Drawing.Size(29, 13);
            id_piLabel.TabIndex = 12;
            id_piLabel.Text = "id pi:";
            // 
            // id_UsuarioLabel
            // 
            id_UsuarioLabel.AutoSize = true;
            id_UsuarioLabel.Location = new System.Drawing.Point(416, 103);
            id_UsuarioLabel.Name = "id_UsuarioLabel";
            id_UsuarioLabel.Size = new System.Drawing.Size(57, 13);
            id_UsuarioLabel.TabIndex = 14;
            id_UsuarioLabel.Text = "id Usuario:";
            // 
            // codigoUnicoLabel
            // 
            codigoUnicoLabel.AutoSize = true;
            codigoUnicoLabel.Location = new System.Drawing.Point(29, 129);
            codigoUnicoLabel.Name = "codigoUnicoLabel";
            codigoUnicoLabel.Size = new System.Drawing.Size(74, 13);
            codigoUnicoLabel.TabIndex = 16;
            codigoUnicoLabel.Text = "Codigo Unico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lista de Almacenes";
            // 
            // aLMACENBindingNavigator
            // 
            this.aLMACENBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aLMACENBindingNavigator.BindingSource = this.aLMACENBindingSource;
            this.aLMACENBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aLMACENBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aLMACENBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.aLMACENBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.aLMACENBindingNavigatorSaveItem});
            this.aLMACENBindingNavigator.Location = new System.Drawing.Point(9, 162);
            this.aLMACENBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aLMACENBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aLMACENBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aLMACENBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aLMACENBindingNavigator.Name = "aLMACENBindingNavigator";
            this.aLMACENBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aLMACENBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.aLMACENBindingNavigator.TabIndex = 3;
            this.aLMACENBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // aLMACENBindingNavigatorSaveItem
            // 
            this.aLMACENBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aLMACENBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aLMACENBindingNavigatorSaveItem.Image")));
            this.aLMACENBindingNavigatorSaveItem.Name = "aLMACENBindingNavigatorSaveItem";
            this.aLMACENBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aLMACENBindingNavigatorSaveItem.Text = "Guardar Cambios";
            this.aLMACENBindingNavigatorSaveItem.Click += new System.EventHandler(this.aLMACENBindingNavigatorSaveItem_Click);
            // 
            // id_AlmacenTextBox
            // 
            this.id_AlmacenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "id_Almacen", true));
            this.id_AlmacenTextBox.Enabled = false;
            this.id_AlmacenTextBox.Location = new System.Drawing.Point(493, 48);
            this.id_AlmacenTextBox.Name = "id_AlmacenTextBox";
            this.id_AlmacenTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_AlmacenTextBox.TabIndex = 5;
            // 
            // anioAlmacenTextBox
            // 
            this.anioAlmacenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "AnioAlmacen", true));
            this.anioAlmacenTextBox.Location = new System.Drawing.Point(137, 48);
            this.anioAlmacenTextBox.Name = "anioAlmacenTextBox";
            this.anioAlmacenTextBox.Size = new System.Drawing.Size(100, 20);
            this.anioAlmacenTextBox.TabIndex = 7;
            // 
            // nombreProyectoTextBox
            // 
            this.nombreProyectoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "NombreProyecto", true));
            this.nombreProyectoTextBox.Location = new System.Drawing.Point(137, 74);
            this.nombreProyectoTextBox.Name = "nombreProyectoTextBox";
            this.nombreProyectoTextBox.Size = new System.Drawing.Size(231, 20);
            this.nombreProyectoTextBox.TabIndex = 9;
            // 
            // direccionCompletaTextBox
            // 
            this.direccionCompletaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "DireccionCompleta", true));
            this.direccionCompletaTextBox.Location = new System.Drawing.Point(137, 100);
            this.direccionCompletaTextBox.Name = "direccionCompletaTextBox";
            this.direccionCompletaTextBox.Size = new System.Drawing.Size(231, 20);
            this.direccionCompletaTextBox.TabIndex = 11;
            // 
            // id_piTextBox
            // 
            this.id_piTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "id_pi", true));
            this.id_piTextBox.Enabled = false;
            this.id_piTextBox.Location = new System.Drawing.Point(493, 74);
            this.id_piTextBox.Name = "id_piTextBox";
            this.id_piTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_piTextBox.TabIndex = 13;
            // 
            // id_UsuarioTextBox
            // 
            this.id_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "id_Usuario", true));
            this.id_UsuarioTextBox.Enabled = false;
            this.id_UsuarioTextBox.Location = new System.Drawing.Point(493, 100);
            this.id_UsuarioTextBox.Name = "id_UsuarioTextBox";
            this.id_UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_UsuarioTextBox.TabIndex = 15;
            // 
            // codigoUnicoTextBox
            // 
            this.codigoUnicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aLMACENBindingSource, "CodigoUnico", true));
            this.codigoUnicoTextBox.Enabled = false;
            this.codigoUnicoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoUnicoTextBox.Location = new System.Drawing.Point(137, 126);
            this.codigoUnicoTextBox.Name = "codigoUnicoTextBox";
            this.codigoUnicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoUnicoTextBox.TabIndex = 17;
            // 
            // aLMACENDataGridView
            // 
            this.aLMACENDataGridView.AllowUserToAddRows = false;
            this.aLMACENDataGridView.AllowUserToResizeRows = false;
            this.aLMACENDataGridView.AutoGenerateColumns = false;
            this.aLMACENDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aLMACENDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aLMACENDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.aLMACENDataGridView.DataSource = this.aLMACENBindingSource;
            this.aLMACENDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aLMACENDataGridView.Location = new System.Drawing.Point(0, 192);
            this.aLMACENDataGridView.Name = "aLMACENDataGridView";
            this.aLMACENDataGridView.ReadOnly = true;
            this.aLMACENDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aLMACENDataGridView.Size = new System.Drawing.Size(632, 199);
            this.aLMACENDataGridView.TabIndex = 18;
            // 
            // btnPredeterminado
            // 
            this.btnPredeterminado.Location = new System.Drawing.Point(514, 142);
            this.btnPredeterminado.Name = "btnPredeterminado";
            this.btnPredeterminado.Size = new System.Drawing.Size(113, 44);
            this.btnPredeterminado.TabIndex = 19;
            this.btnPredeterminado.Text = "Establecer como prederminado";
            this.btnPredeterminado.UseVisualStyleBackColor = true;
            this.btnPredeterminado.Click += new System.EventHandler(this.btnPredeterminado_Click);
            // 
            // aLMACENBindingSource
            // 
            this.aLMACENBindingSource.DataMember = "ALMACEN";
            this.aLMACENBindingSource.DataSource = this.dsALMACEN;
            // 
            // dsALMACEN
            // 
            this.dsALMACEN.DataSetName = "dsALMACEN";
            this.dsALMACEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLMACENTableAdapter
            // 
            this.aLMACENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ALMACENTableAdapter = this.aLMACENTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATALOGO_BIENTableAdapter = null;
            this.tableAdapterManager.ENTRADA_DETALLETableAdapter = null;
            this.tableAdapterManager.ENTRADATableAdapter = null;
            this.tableAdapterManager.MOVIMIENTO_BIENTableAdapter = null;
            this.tableAdapterManager.SALIDA_DETALLETableAdapter = null;
            this.tableAdapterManager.SALIDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ModuloAlmacen.DataSets.dsALMACENTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_Almacen";
            this.dataGridViewTextBoxColumn1.FillWeight = 25.38071F;
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnioAlmacen";
            this.dataGridViewTextBoxColumn2.FillWeight = 118.6548F;
            this.dataGridViewTextBoxColumn2.HeaderText = "AnioAlmacen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NombreProyecto";
            this.dataGridViewTextBoxColumn3.FillWeight = 118.6548F;
            this.dataGridViewTextBoxColumn3.HeaderText = "NombreProyecto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DireccionCompleta";
            this.dataGridViewTextBoxColumn4.FillWeight = 118.6548F;
            this.dataGridViewTextBoxColumn4.HeaderText = "DireccionCompleta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_pi";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_pi";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_Usuario";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_Usuario";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CodigoUnico";
            this.dataGridViewTextBoxColumn7.FillWeight = 118.6548F;
            this.dataGridViewTextBoxColumn7.HeaderText = "CodigoUnico";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(243, 124);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 22);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // UbicacionAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 391);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnPredeterminado);
            this.Controls.Add(this.aLMACENDataGridView);
            this.Controls.Add(id_AlmacenLabel);
            this.Controls.Add(this.id_AlmacenTextBox);
            this.Controls.Add(anioAlmacenLabel);
            this.Controls.Add(this.anioAlmacenTextBox);
            this.Controls.Add(nombreProyectoLabel);
            this.Controls.Add(this.nombreProyectoTextBox);
            this.Controls.Add(direccionCompletaLabel);
            this.Controls.Add(this.direccionCompletaTextBox);
            this.Controls.Add(id_piLabel);
            this.Controls.Add(this.id_piTextBox);
            this.Controls.Add(id_UsuarioLabel);
            this.Controls.Add(this.id_UsuarioTextBox);
            this.Controls.Add(codigoUnicoLabel);
            this.Controls.Add(this.codigoUnicoTextBox);
            this.Controls.Add(this.aLMACENBindingNavigator);
            this.Controls.Add(this.label2);
            this.Name = "UbicacionAlmacen";
            this.Text = "Ubicacion Almacen";
            this.Load += new System.EventHandler(this.UbicacionAlmacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENBindingNavigator)).EndInit();
            this.aLMACENBindingNavigator.ResumeLayout(false);
            this.aLMACENBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsALMACEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private DataSets.dsALMACEN dsALMACEN;
        private System.Windows.Forms.BindingSource aLMACENBindingSource;
        private DataSets.dsALMACENTableAdapters.ALMACENTableAdapter aLMACENTableAdapter;
        private DataSets.dsALMACENTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aLMACENBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton aLMACENBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_AlmacenTextBox;
        private System.Windows.Forms.TextBox anioAlmacenTextBox;
        private System.Windows.Forms.TextBox nombreProyectoTextBox;
        private System.Windows.Forms.TextBox direccionCompletaTextBox;
        private System.Windows.Forms.TextBox id_piTextBox;
        private System.Windows.Forms.TextBox id_UsuarioTextBox;
        private System.Windows.Forms.TextBox codigoUnicoTextBox;
        private System.Windows.Forms.DataGridView aLMACENDataGridView;
        private System.Windows.Forms.Button btnPredeterminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnEditar;
    }
}