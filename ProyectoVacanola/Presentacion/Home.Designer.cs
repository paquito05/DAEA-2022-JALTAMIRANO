
namespace Presentacion
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegiVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegiCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.registarAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registarActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVacunaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeConsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(139, 22);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(139, 22);
            this.mnuManProductos.Text = "Productos";
            this.mnuManProductos.Click += new System.EventHandler(this.mnuManProductos_Click);
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(139, 22);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(139, 22);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegiVenta,
            this.mnuProRegiCompra,
            this.registarAnimalToolStripMenuItem,
            this.registarActividadToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProRegiVenta
            // 
            this.mnuProRegiVenta.Name = "mnuProRegiVenta";
            this.mnuProRegiVenta.Size = new System.Drawing.Size(169, 22);
            this.mnuProRegiVenta.Text = "Registrar Venta";
            // 
            // mnuProRegiCompra
            // 
            this.mnuProRegiCompra.Name = "mnuProRegiCompra";
            this.mnuProRegiCompra.Size = new System.Drawing.Size(169, 22);
            this.mnuProRegiCompra.Text = "Registrar Compra";
            this.mnuProRegiCompra.Click += new System.EventHandler(this.mnuProRegiCompra_Click);
            // 
            // registarAnimalToolStripMenuItem
            // 
            this.registarAnimalToolStripMenuItem.Name = "registarAnimalToolStripMenuItem";
            this.registarAnimalToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registarAnimalToolStripMenuItem.Text = "Registar Animal";
            this.registarAnimalToolStripMenuItem.Click += new System.EventHandler(this.registarAnimalToolStripMenuItem_Click);
            // 
            // registarActividadToolStripMenuItem
            // 
            this.registarActividadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarConsumoToolStripMenuItem,
            this.registrarVacunaciónToolStripMenuItem});
            this.registarActividadToolStripMenuItem.Name = "registarActividadToolStripMenuItem";
            this.registarActividadToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.registarActividadToolStripMenuItem.Text = "Registar Actividad";
            // 
            // registrarConsumoToolStripMenuItem
            // 
            this.registrarConsumoToolStripMenuItem.Name = "registrarConsumoToolStripMenuItem";
            this.registrarConsumoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registrarConsumoToolStripMenuItem.Text = "Registrar Consumo";
            this.registrarConsumoToolStripMenuItem.Click += new System.EventHandler(this.registrarConsumoToolStripMenuItem_Click);
            // 
            // registrarVacunaciónToolStripMenuItem
            // 
            this.registrarVacunaciónToolStripMenuItem.Name = "registrarVacunaciónToolStripMenuItem";
            this.registrarVacunaciónToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.registrarVacunaciónToolStripMenuItem.Text = "Registrar Vacunación";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReporVenta,
            this.mnuReporCompra,
            this.reporteDeConsumoToolStripMenuItem,
            this.reporteDeActividadToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuReporVenta
            // 
            this.mnuReporVenta.Name = "mnuReporVenta";
            this.mnuReporVenta.Size = new System.Drawing.Size(184, 22);
            this.mnuReporVenta.Text = "Reporte de Ventas";
            // 
            // mnuReporCompra
            // 
            this.mnuReporCompra.Name = "mnuReporCompra";
            this.mnuReporCompra.Size = new System.Drawing.Size(184, 22);
            this.mnuReporCompra.Text = "Reporte de Compras";
            // 
            // reporteDeConsumoToolStripMenuItem
            // 
            this.reporteDeConsumoToolStripMenuItem.Name = "reporteDeConsumoToolStripMenuItem";
            this.reporteDeConsumoToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteDeConsumoToolStripMenuItem.Text = "Reporte de Animales";
            this.reporteDeConsumoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeConsumoToolStripMenuItem_Click);
            // 
            // reporteDeActividadToolStripMenuItem
            // 
            this.reporteDeActividadToolStripMenuItem.Name = "reporteDeActividadToolStripMenuItem";
            this.reporteDeActividadToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reporteDeActividadToolStripMenuItem.Text = "Reporte de Actividad";
            this.reporteDeActividadToolStripMenuItem.Click += new System.EventHandler(this.reporteDeActividadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1080, 620);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(1080, 620);
            this.MinimumSize = new System.Drawing.Size(1080, 620);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegiVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegiCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReporVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuReporCompra;
        private System.Windows.Forms.ToolStripMenuItem registarAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registarActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarConsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVacunaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}



