using Proyecto_Final.Proyecto.Menu.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Clases;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu.Clientes
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            cargarDataGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloClientes m = new ModeloClientes();
            dataGridView1.DataSource = m.obtenerCliente();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.IdCliente = int.Parse(textBox_ID.Text);
                cli.Documento = textBox_Documento.Text;
                cli.Nombre = textBox_NombreCompleto.Text;
                cli.Telefono = textBox_Telefono.Text;
                ControlClientes control = new ControlClientes();
                MessageBox.Show(control.ctrlAgregarCliente(cli), "Control de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_Documento.Clear();
                textBox_NombreCompleto.Clear();
                textBox_Telefono.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.IdCliente = int.Parse(textBox_ID.Text);
                cli.Documento = textBox_Documento.Text;
                cli.Nombre = textBox_NombreCompleto.Text;
                cli.Telefono = textBox_Telefono.Text;
                ControlClientes control = new ControlClientes();
                MessageBox.Show(control.ctrlModificarCliente(cli), "Control de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_Documento.Clear();
                textBox_NombreCompleto.Clear();
                textBox_Telefono.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.IdCliente = int.Parse(textBox_ID.Text);
                ControlClientes control = new ControlClientes();
                MessageBox.Show(control.ctrlBorrarCliente(cli), "Control de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_ID.Clear();
                textBox_ID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Rellenar controles al seleccionar fila
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dataGridView1.Rows[e.RowIndex];

                textBox_ID.Text = GetCellValue(row, "ID", 0);
                textBox_Documento.Text = GetCellValue(row, "Documento", 1);
                // Intentar columnas alternativas si existen
                var nombre = GetCellValue(row, "Nombre", 2);
                if (string.IsNullOrEmpty(nombre))
                    nombre = GetCellValue(row, "Nombre Completo", 2);
                if (string.IsNullOrEmpty(nombre))
                    nombre = GetCellValue(row, "nombre_completo", 2);
                textBox_NombreCompleto.Text = nombre;
                textBox_Telefono.Text = GetCellValue(row, "Telefono", 3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper seguro para obtener valores de celda por nombre o índice de fallback
        private string GetCellValue(DataGridViewRow row, string columnName, int fallbackIndex)
        {
            if (dataGridView1.Columns.Contains(columnName))
                return row.Cells[columnName].Value?.ToString() ?? "";
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
