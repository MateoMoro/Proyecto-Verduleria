namespace Proyecto_Final.Proyecto.Menu
{
    partial class FormPrincipal
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
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menuStripControles = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemCBUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTipoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Salir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.Titulo = new System.Windows.Forms.Label();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.menuStripControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.AutoSize = true;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 70);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(894, 416);
            this.Contenedor.TabIndex = 11;
            // 
            // menuStripControles
            // 
            this.menuStripControles.AutoSize = false;
            this.menuStripControles.BackColor = System.Drawing.Color.Sienna;
            this.menuStripControles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCBUsuario,
            this.toolStripMenuItemInventario,
            this.toolStripMenuItemVentas,
            this.toolStripMenuItemCompras,
            this.toolStripMenuItemProveedores,
            this.toolStripMenuItemClientes,
            this.toolStripMenuItem_Salir,
            this.toolStripMenuItemReportes});
            this.menuStripControles.Location = new System.Drawing.Point(0, 35);
            this.menuStripControles.Name = "menuStripControles";
            this.menuStripControles.Size = new System.Drawing.Size(894, 35);
            this.menuStripControles.TabIndex = 8;
            this.menuStripControles.Text = "menuStrip1";
            // 
            // toolStripMenuItemCBUsuario
            // 
            this.toolStripMenuItemCBUsuario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCBUsuario.Name = "toolStripMenuItemCBUsuario";
            this.toolStripMenuItemCBUsuario.Size = new System.Drawing.Size(184, 31);
            this.toolStripMenuItemCBUsuario.Text = "Crear/Borrar Usuario";
            this.toolStripMenuItemCBUsuario.Click += new System.EventHandler(this.toolStripMenuItemCBUsuario_Click);
            // 
            // toolStripMenuItemInventario
            // 
            this.toolStripMenuItemInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemProductos,
            this.toolStripMenuItemTipoProducto});
            this.toolStripMenuItemInventario.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemInventario.Name = "toolStripMenuItemInventario";
            this.toolStripMenuItemInventario.Size = new System.Drawing.Size(101, 31);
            this.toolStripMenuItemInventario.Text = "Inventario";
            // 
            // toolStripMenuItemProductos
            // 
            this.toolStripMenuItemProductos.Name = "toolStripMenuItemProductos";
            this.toolStripMenuItemProductos.Size = new System.Drawing.Size(225, 24);
            this.toolStripMenuItemProductos.Text = "Productos";
            this.toolStripMenuItemProductos.Click += new System.EventHandler(this.toolStripMenuItemProductos_Click_1);
            // 
            // toolStripMenuItemTipoProducto
            // 
            this.toolStripMenuItemTipoProducto.Name = "toolStripMenuItemTipoProducto";
            this.toolStripMenuItemTipoProducto.Size = new System.Drawing.Size(225, 24);
            this.toolStripMenuItemTipoProducto.Text = "Tipos de Productos";
            this.toolStripMenuItemTipoProducto.Click += new System.EventHandler(this.toolStripMenuItemTipoProducto_Click_1);
            // 
            // toolStripMenuItemVentas
            // 
            this.toolStripMenuItemVentas.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemVentas.Name = "toolStripMenuItemVentas";
            this.toolStripMenuItemVentas.Size = new System.Drawing.Size(72, 31);
            this.toolStripMenuItemVentas.Text = "Ventas";
            this.toolStripMenuItemVentas.Click += new System.EventHandler(this.toolStripMenuItemVentas_Click_1);
            // 
            // toolStripMenuItemCompras
            // 
            this.toolStripMenuItemCompras.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCompras.Name = "toolStripMenuItemCompras";
            this.toolStripMenuItemCompras.Size = new System.Drawing.Size(90, 31);
            this.toolStripMenuItemCompras.Text = "Compras";
            this.toolStripMenuItemCompras.Click += new System.EventHandler(this.toolStripMenuItemCompras_Click_1);
            // 
            // toolStripMenuItemProveedores
            // 
            this.toolStripMenuItemProveedores.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemProveedores.Name = "toolStripMenuItemProveedores";
            this.toolStripMenuItemProveedores.Size = new System.Drawing.Size(117, 31);
            this.toolStripMenuItemProveedores.Text = "Proveedores";
            this.toolStripMenuItemProveedores.Click += new System.EventHandler(this.toolStripMenuItemProveedores_Click_1);
            // 
            // toolStripMenuItemClientes
            // 
            this.toolStripMenuItemClientes.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemClientes.Name = "toolStripMenuItemClientes";
            this.toolStripMenuItemClientes.Size = new System.Drawing.Size(83, 31);
            this.toolStripMenuItemClientes.Text = "Clientes";
            this.toolStripMenuItemClientes.Click += new System.EventHandler(this.toolStripMenuItemClientes_Click_1);
            // 
            // toolStripMenuItem_Salir
            // 
            this.toolStripMenuItem_Salir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem_Salir.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem_Salir.Name = "toolStripMenuItem_Salir";
            this.toolStripMenuItem_Salir.Size = new System.Drawing.Size(55, 31);
            this.toolStripMenuItem_Salir.Text = "Salir";
            this.toolStripMenuItem_Salir.Click += new System.EventHandler(this.toolStripMenuItem_Salir_Click_1);
            // 
            // toolStripMenuItemReportes
            // 
            this.toolStripMenuItemReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.toolStripMenuItemReportes.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemReportes.Name = "toolStripMenuItemReportes";
            this.toolStripMenuItemReportes.Size = new System.Drawing.Size(84, 31);
            this.toolStripMenuItemReportes.Text = "Detalles";
            this.toolStripMenuItemReportes.Click += new System.EventHandler(this.toolStripMenuItemReportes_Click_1);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem3.Text = "Ventas";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(147, 24);
            this.toolStripMenuItem4.Text = "Compras";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.OliveDrab;
            this.Titulo.Font = new System.Drawing.Font("Constantia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(12, 2);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(321, 33);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "SISTEMA DISFRUTABLE";
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.OliveDrab;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(894, 35);
            this.menuTitulo.TabIndex = 9;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(894, 486);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.menuStripControles);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.menuTitulo);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStripControles.ResumeLayout(false);
            this.menuStripControles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.MenuStrip menuStripControles;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCBUsuario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInventario;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTipoProducto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProductos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVentas;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCompras;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProveedores;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClientes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Salir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemReportes;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}