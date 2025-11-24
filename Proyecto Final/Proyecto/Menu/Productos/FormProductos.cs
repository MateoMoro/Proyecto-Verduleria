using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Tipos_Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu.Productos
{
    public partial class FormProductos : Form
    {
        TipoProducto tipoProducto;

        public FormProductos()
        {
            InitializeComponent();
            cargarDataGrid();
            cargarUsuariosEnComboBox();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void cargarUsuariosEnComboBox()
        {
            try
            {
                comboBox1.ValueMember = "id_tipoproducto";
                comboBox1.DisplayMember = "descripcion";
                ModeloProductos m = new ModeloProductos();
                comboBox1.DataSource = m.obtenerTipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloProductos m = new ModeloProductos();
            dataGridView1.DataSource = m.obtenerProducto();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.Codigo = textBox_Codigo.Text;
                prod.Nombre = textBox_Nombre.Text;
                prod.Descripcion = textBox_Descripcion.Text;
                prod.IdTipoProducto = tipoProducto;
                prod.Stock = int.Parse(textBox_Stock.Text);
                prod.PrecioCompra = decimal.Parse(textBox_PrecioCompra.Text);
                prod.PrecioVenta = decimal.Parse(textBox_PrecioVenta.Text);
                ControlProductos control = new ControlProductos();
                MessageBox.Show(control.ctrlAgregarProducto(prod), "Control de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_Codigo.Clear();
                textBox_Nombre.Clear();
                textBox_Descripcion.Clear();
                //
                textBox_Stock.Clear();
                textBox_PrecioCompra.Clear();
                textBox_PrecioVenta.Clear();
                textBox_Codigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.Codigo = textBox_Codigo.Text;
                prod.Nombre = textBox_Nombre.Text;
                prod.Descripcion = textBox_Descripcion.Text;
                prod.IdTipoProducto = tipoProducto;
                prod.Stock = int.Parse(textBox_Stock.Text);
                prod.PrecioCompra = decimal.Parse(textBox_PrecioCompra.Text);
                prod.PrecioVenta = decimal.Parse(textBox_PrecioVenta.Text);
                ControlProductos control = new ControlProductos();
                MessageBox.Show(control.ctrlModificarProducto(prod), "Control de Productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_Codigo.Clear();
                textBox_Nombre.Clear();
                textBox_Descripcion.Clear();
                //
                textBox_Stock.Clear();
                textBox_PrecioCompra.Clear();
                textBox_PrecioVenta.Clear();
                textBox_Codigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.Codigo = textBox_Codigo.Text;
                ControlProductos control = new ControlProductos();
                MessageBox.Show(control.ctrlBorrarProducto(prod), "Control de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_Codigo.Clear();
                textBox_Codigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipoProducto = new TipoProducto();
            tipoProducto.IdTipoProducto = int.Parse(comboBox1.SelectedValue.ToString());
            tipoProducto.Descripcion = comboBox1.ValueMember;
        }

        // Rellenar controles al seleccionar fila del DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dataGridView1.Rows[e.RowIndex];

                textBox_Codigo.Text = GetCellValue(row, new[] { "Codigo", "codigo", "Código" }, 0);
                textBox_Nombre.Text = GetCellValue(row, new[] { "Nombre", "nombre" }, 1);
                textBox_Descripcion.Text = GetCellValue(row, new[] { "Descripcion", "Descripcion Producto", "descripcion" }, 2);
                textBox_Stock.Text = GetCellValue(row, new[] { "Stock", "stock" }, 3);
                textBox_PrecioCompra.Text = GetCellValue(row, new[] { "Precio Compra", "precio_compra", "PrecioCompra" }, 4);
                textBox_PrecioVenta.Text = GetCellValue(row, new[] { "Precio Venta", "precio_venta", "PrecioVenta" }, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper para leer varias alternativas de nombre de columna o fallback por índice
        private string GetCellValue(DataGridViewRow row, string[] columnNames, int fallbackIndex)
        {
            foreach (var col in columnNames)
            {
                if (dataGridView1.Columns.Contains(col))
                    return row.Cells[col].Value?.ToString() ?? "";
            }
            if (row.Cells.Count > fallbackIndex)
                return row.Cells[fallbackIndex].Value?.ToString() ?? "";
            return "";
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
