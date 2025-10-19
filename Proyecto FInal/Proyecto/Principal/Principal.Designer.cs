namespace Proyecto_FInal
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
            this.menuStripControles = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCBUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTipoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.Titulo = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menuStripControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripControles
            // 
            this.menuStripControles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCBUsuario,
            this.toolStripMenuItemVentas,
            this.toolStripMenuItemCompras,
            this.toolStripMenuItemProveedores,
            this.toolStripMenuItemReportes,
            this.toolStripMenuItemInventario,
            this.toolStripMenuItemClientes});
            this.menuStripControles.Location = new System.Drawing.Point(0, 24);
            this.menuStripControles.Name = "menuStripControles";
            this.menuStripControles.Size = new System.Drawing.Size(800, 24);
            this.menuStripControles.TabIndex = 4;
            this.menuStripControles.Text = "menuStrip1";
            // 
            // toolStripMenuItemCBUsuario
            // 
            this.toolStripMenuItemCBUsuario.Name = "toolStripMenuItemCBUsuario";
            this.toolStripMenuItemCBUsuario.Size = new System.Drawing.Size(135, 20);
            this.toolStripMenuItemCBUsuario.Text = "Crear o Borrar Usuario";
            this.toolStripMenuItemCBUsuario.Click += new System.EventHandler(this.toolStripMenuItemCBUsuario_Click);
            // 
            // toolStripMenuItemVentas
            // 
            this.toolStripMenuItemVentas.Name = "toolStripMenuItemVentas";
            this.toolStripMenuItemVentas.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItemVentas.Text = "Ventas";
            this.toolStripMenuItemVentas.Click += new System.EventHandler(this.toolStripMenuItemVentas_Click);
            // 
            // toolStripMenuItemCompras
            // 
            this.toolStripMenuItemCompras.Name = "toolStripMenuItemCompras";
            this.toolStripMenuItemCompras.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItemCompras.Text = "Compras";
            this.toolStripMenuItemCompras.Click += new System.EventHandler(this.toolStripMenuItemCompras_Click);
            // 
            // toolStripMenuItemProveedores
            // 
            this.toolStripMenuItemProveedores.Name = "toolStripMenuItemProveedores";
            this.toolStripMenuItemProveedores.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItemProveedores.Text = "Proveedores";
            this.toolStripMenuItemProveedores.Click += new System.EventHandler(this.toolStripMenuItemProveedores_Click);
            // 
            // toolStripMenuItemReportes
            // 
            this.toolStripMenuItemReportes.Name = "toolStripMenuItemReportes";
            this.toolStripMenuItemReportes.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItemReportes.Text = "Reportes";
            this.toolStripMenuItemReportes.Click += new System.EventHandler(this.toolStripMenuItemReportes_Click);
            // 
            // toolStripMenuItemInventario
            // 
            this.toolStripMenuItemInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTipoProducto,
            this.toolStripMenuItemProductos});
            this.toolStripMenuItemInventario.Name = "toolStripMenuItemInventario";
            this.toolStripMenuItemInventario.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItemInventario.Text = "Inventario";
            // 
            // toolStripMenuItemTipoProducto
            // 
            this.toolStripMenuItemTipoProducto.Name = "toolStripMenuItemTipoProducto";
            this.toolStripMenuItemTipoProducto.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemTipoProducto.Text = "Tipos de Productos";
            this.toolStripMenuItemTipoProducto.Click += new System.EventHandler(this.toolStripMenuItemTipoProducto_Click);
            // 
            // toolStripMenuItemProductos
            // 
            this.toolStripMenuItemProductos.Name = "toolStripMenuItemProductos";
            this.toolStripMenuItemProductos.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemProductos.Text = "Productos";
            this.toolStripMenuItemProductos.Click += new System.EventHandler(this.toolStripMenuItemProductos_Click);
            // 
            // toolStripMenuItemClientes
            // 
            this.toolStripMenuItemClientes.Name = "toolStripMenuItemClientes";
            this.toolStripMenuItemClientes.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItemClientes.Text = "Clientes";
            this.toolStripMenuItemClientes.Click += new System.EventHandler(this.toolStripMenuItemClientes_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(800, 24);
            this.menuTitulo.TabIndex = 5;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(12, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(35, 13);
            this.Titulo.TabIndex = 6;
            this.Titulo.Text = "label1";
            // 
            // Contenedor
            // 
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 48);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(800, 402);
            this.Contenedor.TabIndex = 7;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuStripControles);
            this.Controls.Add(this.menuTitulo);
            this.MainMenuStrip = this.menuStripControles;
            this.Name = "Principal";
            this.Text = "Pagina Principal";
            this.menuStripControles.ResumeLayout(false);
            this.menuStripControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripControles;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCBUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVentas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCompras;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProveedores;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReportes;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInventario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTipoProducto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClientes;
    }
}