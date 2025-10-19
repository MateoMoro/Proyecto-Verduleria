using Proyecto_FInal.Proyecto.Principal.Clientes;
using Proyecto_FInal.Proyecto.Principal.Inventario;
using Proyecto_FInal.Proyecto.Principal.Inventario.TipoProductos;
using Proyecto_FInal.Proyecto.Principal.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FInal
{
    public partial class Principal : Form
    {
        private static Form formularioActivo = null;   

        public Principal()
        {
            InitializeComponent();
        }

        public void AbrirFormulario(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            Contenedor.Controls.Add(formularioHijo);
            Contenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void toolStripMenuItemCBUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new LoginRegistrarBorrarUsuario());
        }

        private void toolStripMenuItemVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Venta());
        }

        private void toolStripMenuItemCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Compra());
        }

        private void toolStripMenuItemProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Proveedor());
        }

        private void toolStripMenuItemReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Reportes());
        }

        private void toolStripMenuItemTipoProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new TiposProductos());
        }

        private void toolStripMenuItemProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Productos());
        }

        private void toolStripMenuItemClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Clientes());
        }
    }
}
