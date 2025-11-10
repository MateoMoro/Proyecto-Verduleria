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

namespace Proyecto_Final.Proyecto.Menu.Tipos_Productos
{
    public partial class FormTiposProductos : Form
    {
        public FormTiposProductos()
        {
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloTiposProductos m = new ModeloTiposProductos();
            dataGridView1.DataSource = m.obtenerTipoProducto();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProducto tipo = new TipoProducto();
                tipo.IdTipoProducto = int.Parse(textBox_ID.Text);
                tipo.Descripcion = textBox_Descripcion.Text;
                ControlTiposProductos control = new ControlTiposProductos();
                MessageBox.Show(control.ctrlAgregarTipoProducto(tipo), "Control de tipos de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_Descripcion.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el tipo de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProducto tipo = new TipoProducto();
                tipo.IdTipoProducto = int.Parse(textBox_ID.Text);
                tipo.Descripcion = textBox_Descripcion.Text;
                ControlTiposProductos control = new ControlTiposProductos();
                MessageBox.Show(control.ctrlModificarTipoProducto(tipo), "Control de tipos de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_Descripcion.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el tipo de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProducto tipo = new TipoProducto();
                tipo.IdTipoProducto = int.Parse(textBox_ID.Text);
                ControlTiposProductos control = new ControlTiposProductos();
                MessageBox.Show(control.ctrlBorrarTipoProducto(tipo), "Control de tipos de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_Descripcion.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el tipo de producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
