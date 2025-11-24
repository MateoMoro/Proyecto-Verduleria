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
            dataGridView1.CellClick += dataGridView1_CellClick;
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
            textBox_ID.Focus();
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
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
                // Razon social puede tener diferentes alias
                var razon = GetCellValue(row, "Razon Social", 2);
                if (string.IsNullOrEmpty(razon))
                    razon = GetCellValue(row, "RazonSocial", 2);
                if (string.IsNullOrEmpty(razon))
                    razon = GetCellValue(row, "razon_social", 2);
                textBox_RazonSocial.Text = razon;

                textBox_Correo.Text = GetCellValue(row, "Correo", 3);
                textBox_Telefono.Text = GetCellValue(row, "Telefono", 4);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetCellValue(DataGridViewRow row, string columnName, int fallbackIndex)
        {
            if (dataGridView1.Columns.Contains(columnName))
                return row.Cells[columnName].Value?.ToString() ?? "";
            if (row.Cells.Count > fallbackIndex)
                return row.Cells[fallbackIndex].Value?.ToString() ?? "";
            return "";
        }
    }
}
