using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu.Compras
{
    public partial class FormCompras : Form
    {
        Usuario idUsuario;
        Proveedor idProveedor;

        public FormCompras()
        {
            InitializeComponent();
            cargarIDProveedorEnComboBox();
            cargarIDUsuarioEnComboBox();
            cargarDataGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void cargarIDUsuarioEnComboBox()
        {
            try
            {
                comboBox_IDUsuario.ValueMember = "id_user";
                comboBox_IDUsuario.DisplayMember = "user";
                ModeloCompras m = new ModeloCompras();
                comboBox_IDUsuario.DataSource = m.obtenerIDUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarIDProveedorEnComboBox()
        {
            try
            {
                comboBox_IDProveedor.ValueMember = "id_proveedor";
                comboBox_IDProveedor.DisplayMember = "razon_social";
                ModeloCompras m = new ModeloCompras();
                comboBox_IDProveedor.DataSource = m.obtenerIDProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_IDUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            idUsuario = new Usuario();
            idUsuario.Id = int.Parse(comboBox_IDUsuario.SelectedValue.ToString());
            idUsuario.UsuarioNombre = comboBox_IDUsuario.Text;
        }

        private void comboBox_IDProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProveedor = new Proveedor();
            idProveedor.IdProveedor = int.Parse(comboBox_IDProveedor.SelectedValue.ToString());
            idProveedor.RazonSocial = comboBox_IDProveedor.Text;
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloCompras m = new ModeloCompras();
            dataGridView1.DataSource = m.obtenerCompra();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Al hacer click en una fila vuelca los datos a los controles para editar/borrar
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dataGridView1.Rows[e.RowIndex];

                // Los alias en obtenerCompra: 'ID', 'Numero de Factura', 'ID del Usuario', 'ID del Proveedor', 'Total de Compra', 'Fecha'
                textBox_NumeroFactura.Text = row.Cells["Numero de Factura"].Value?.ToString() ?? "";
                textBox_MontoTotal.Text = row.Cells["Total de Compra"].Value?.ToString() ?? "";

                var fechaObj = row.Cells["Fecha"].Value;
                DateTime fecha;
                if (fechaObj != null && DateTime.TryParse(fechaObj.ToString(), out fecha))
                    dateTimePicker1.Value = fecha;

                // establecer SelectedValue en los combobox (si existen valores)
                var idUsuarioVal = row.Cells["ID del Usuario"].Value;
                if (idUsuarioVal != null && idUsuarioVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idUsuarioVal.ToString(), out parsed))
                        comboBox_IDUsuario.SelectedValue = parsed;
                }

                var idProveedorVal = row.Cells["ID del Proveedor"].Value;
                if (idProveedorVal != null && idProveedorVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idProveedorVal.ToString(), out parsed))
                        comboBox_IDProveedor.SelectedValue = parsed;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Compra comp = new Compra();
                comp.NumeroFactura = int.Parse(textBox_NumeroFactura.Text);
                comp.IdUsuario = idUsuario;
                comp.IdProveedor = idProveedor;
                comp.MontoTotal = decimal.Parse(textBox_MontoTotal.Text);
                comp.FechaCompra = dateTimePicker1.Value;
                ControlCompras control = new ControlCompras();
                MessageBox.Show(control.ctrlAgregarCompra(comp), "Control de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_NumeroFactura.Clear();
                textBox_MontoTotal.Clear();
                textBox_NumeroFactura.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al Agregar la Compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Compra comp = new Compra();
                comp.NumeroFactura = int.Parse(textBox_NumeroFactura.Text);
                comp.IdUsuario = idUsuario;
                comp.IdProveedor = idProveedor;
                comp.MontoTotal = decimal.Parse(textBox_MontoTotal.Text);
                comp.FechaCompra = dateTimePicker1.Value;
                ControlCompras control = new ControlCompras();
                MessageBox.Show(control.ctrlModificarCompra(comp), "Control de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_NumeroFactura.Clear();
                textBox_MontoTotal.Clear();
                textBox_NumeroFactura.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar la Compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Compra comp = new Compra();
                comp.NumeroFactura = int.Parse(textBox_NumeroFactura.Text);
                ControlCompras control = new ControlCompras();
                MessageBox.Show(control.ctrlBorrarCompra(comp), "Control de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_NumeroFactura.Clear();
                textBox_MontoTotal.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Borrar la Compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
