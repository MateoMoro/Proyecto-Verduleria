using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu.Proveedores
{
    public partial class FormProveedores : Form
    {
        public FormProveedores()
        {
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloProveedores m = new ModeloProveedores();
            dataGridView1.DataSource = m.obtenerProveedor();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor();
                proveedor.IdProveedor = int.Parse(textBox_ID.Text);
                proveedor.Documento = textBox_Documento.Text;
                proveedor.RazonSocial = textBox_RazonSocial.Text;
                proveedor.Correo = textBox_Correo.Text;
                proveedor.Telefono = textBox_Telefono.Text;
                ControlProveedores control = new ControlProveedores();
                MessageBox.Show(control.ctrlAgregarProveedor(proveedor), "Control de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_Documento.Clear();
                textBox_RazonSocial.Clear();
                textBox_Correo.Clear();
                textBox_Telefono.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el proveedor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = int.Parse(textBox_ID.Text);
            proveedor.Documento = textBox_Documento.Text;
            proveedor.RazonSocial = textBox_RazonSocial.Text;
            proveedor.Correo = textBox_Correo.Text;
            proveedor.Telefono = textBox_Telefono.Text;
            ControlProveedores control = new ControlProveedores();
            MessageBox.Show(control.ctrlModificarProveedor(proveedor), "Control de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cargarDataGrid();
            textBox_ID.Clear();
            textBox_Documento.Clear();
            textBox_RazonSocial.Clear();
            textBox_Correo.Clear();
            textBox_Telefono.Clear();
            textBox_ID.Focus();
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            proveedor.IdProveedor = int.Parse(textBox_ID.Text);
            ControlProveedores control = new ControlProveedores();
            MessageBox.Show(control.ctrlBorrarProveedor(proveedor), "Control de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            cargarDataGrid();
            textBox_ID.Clear();
            textBox_Documento.Clear();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
