namespace ModuloAlmacen.Formularios
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarPECOSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexDeInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarSIGAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleccionarAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenToolStripMenuItem,
            this.interfazToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(639, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(639, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Estado";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salidaAlmacenToolStripMenuItem});
            this.almacenToolStripMenuItem.Image = global::ModuloAlmacen.Properties.Resources.caja;
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.almacenToolStripMenuItem.Text = "Almacen";
            // 
            // salidaAlmacenToolStripMenuItem
            // 
            this.salidaAlmacenToolStripMenuItem.Name = "salidaAlmacenToolStripMenuItem";
            this.salidaAlmacenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.salidaAlmacenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.salidaAlmacenToolStripMenuItem.Text = "Salida Almacen";
            this.salidaAlmacenToolStripMenuItem.Click += new System.EventHandler(this.salidaAlmacenToolStripMenuItem_Click);
            // 
            // interfazToolStripMenuItem
            // 
            this.interfazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarPECOSAToolStripMenuItem});
            this.interfazToolStripMenuItem.Image = global::ModuloAlmacen.Properties.Resources.sync;
            this.interfazToolStripMenuItem.Name = "interfazToolStripMenuItem";
            this.interfazToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.interfazToolStripMenuItem.Text = "Interfaz";
            // 
            // importarPECOSAToolStripMenuItem
            // 
            this.importarPECOSAToolStripMenuItem.Name = "importarPECOSAToolStripMenuItem";
            this.importarPECOSAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.importarPECOSAToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.importarPECOSAToolStripMenuItem.Text = "Importar PECOSA";
            this.importarPECOSAToolStripMenuItem.Click += new System.EventHandler(this.importarPECOSAToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kardexDeInventarioToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = global::ModuloAlmacen.Properties.Resources.reportes;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // kardexDeInventarioToolStripMenuItem
            // 
            this.kardexDeInventarioToolStripMenuItem.Name = "kardexDeInventarioToolStripMenuItem";
            this.kardexDeInventarioToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kardexDeInventarioToolStripMenuItem.Text = "Kardex de Inventario";
            this.kardexDeInventarioToolStripMenuItem.Click += new System.EventHandler(this.kardexDeInventarioToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarSIGAToolStripMenuItem,
            this.seleccionarAlmacenToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.herramientasToolStripMenuItem.Image = global::ModuloAlmacen.Properties.Resources.mantenimiento;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.herramientasToolStripMenuItem.Text = "Mantenimiento";
            // 
            // configurarSIGAToolStripMenuItem
            // 
            this.configurarSIGAToolStripMenuItem.Name = "configurarSIGAToolStripMenuItem";
            this.configurarSIGAToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.configurarSIGAToolStripMenuItem.Text = "Configurar SIGA";
            this.configurarSIGAToolStripMenuItem.Click += new System.EventHandler(this.configurarSIGAToolStripMenuItem_Click);
            // 
            // seleccionarAlmacenToolStripMenuItem
            // 
            this.seleccionarAlmacenToolStripMenuItem.Name = "seleccionarAlmacenToolStripMenuItem";
            this.seleccionarAlmacenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.seleccionarAlmacenToolStripMenuItem.Text = "Almacen";
            this.seleccionarAlmacenToolStripMenuItem.Click += new System.EventHandler(this.seleccionarAlmacenToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 345);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarPECOSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexDeInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarSIGAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}