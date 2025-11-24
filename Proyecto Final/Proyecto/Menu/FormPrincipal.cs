using MySqlX.XDevAPI;
using Proyecto_Final.Proyecto.Menu.Crear_y_Borrar_Usuario;
using Proyecto_Final.Proyecto.Menu.Productos;
using Proyecto_Final.Proyecto.Menu.Proveedores;
using Proyecto_Final.Proyecto.Menu.Tipos_Productos;
using Proyecto_Final.Proyecto.Menu.Ventas;
using Proyecto_Final.Proyecto.Menu.Detalles_Ventas;
using Proyecto_Final.Proyecto.Menu.Compras;
using Proyecto_Final.Proyecto.Menu.Detalles_Compras;
using Proyecto_Final.Proyecto.Menu.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu
{
    public partial class FormPrincipal : Form
    {
        private static Form formularioActivo = null;

        public FormPrincipal()
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
            AbrirFormulario(new FormCrearYBorrarUsuario());
        }

        private void toolStripMenuItem_Salir_Click_1(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Salir del sistema", "Disfrutable", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripMenuItemTipoProducto_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormTiposProductos());
        }

        private void toolStripMenuItemProductos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProductos());
        }

        private void toolStripMenuItemVentas_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormVentas());
        }

        private void toolStripMenuItemCompras_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormCompras());
        }

        private void toolStripMenuItemProveedores_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormProveedores());
        }

        private void toolStripMenuItemClientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new FormClientes());
        }

        private void toolStripMenuItemReportes_Click_1(object sender, EventArgs e)
        {
         
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormDetallesVentas());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormDetallesCompras());
        }
    }
}
