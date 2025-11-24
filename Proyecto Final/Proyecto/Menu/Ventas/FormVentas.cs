using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Final.Proyecto.Menu.Ventas
{
    public partial class FormVentas : Form
    {
        Usuario idUsuario;
        Cliente idCliente;

        public FormVentas()
        {
            InitializeComponent();
            cargarDataGrid();
            cargarIDUsuarioEnComboBox();
            cargarIDClienteEnComboBox();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void cargarIDUsuarioEnComboBox()
        {
            try
            {
                comboBox_IDUsuario.ValueMember = "id_user";
                comboBox_IDUsuario.DisplayMember = "user";
                ModeloVentas m = new ModeloVentas();
                comboBox_IDUsuario.DataSource = m.obtenerIDUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarIDClienteEnComboBox()
        {
            try
            {
                comboBox_IDCliente.ValueMember = "id_cliente";
                comboBox_IDCliente.DisplayMember = "nombre_completo";
                ModeloVentas m = new ModeloVentas();
                comboBox_IDCliente.DataSource = m.obtenerIDCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloVentas m = new ModeloVentas();
            dataGridView1.DataSource = m.obtenerVenta();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void comboBox_IDUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            idUsuario = new Usuario();
            idUsuario.Id = int.Parse(comboBox_IDUsuario.SelectedValue.ToString());
            idUsuario.UsuarioNombre = comboBox_IDUsuario.ValueMember;
        }

        private void comboBox_IDCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCliente = new Cliente();
            idCliente.IdCliente = int.Parse(comboBox_IDCliente.SelectedValue.ToString());
            idCliente.Nombre = comboBox_IDCliente.ValueMember;
        }

        // Rellena controles al seleccionar una fila
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dataGridView1.Rows[e.RowIndex];

                // Aliases en obtenerVenta: 'ID', 'Numero de Factura', 'ID del Usuario', 'ID del Cliente', 'Pago', 'Cambio', 'Total', 'Fecha'
                textBox_NumeroFactura.Text = row.Cells["Numero de Factura"].Value?.ToString() ?? "";
                textBox_MontoPago.Text = row.Cells["Pago"].Value?.ToString() ?? "";
                textBox_MontoCambio.Text = row.Cells["Cambio"].Value?.ToString() ?? "";
                textBox_MontoTotal.Text = row.Cells["Total"].Value?.ToString() ?? "";

                var fechaObj = row.Cells["Fecha"].Value;
                DateTime fecha;
                if (fechaObj != null && DateTime.TryParse(fechaObj.ToString(), out fecha))
                    dateTimePicker1.Value = fecha;

                var idUsuarioVal = row.Cells["ID del Usuario"].Value;
                if (idUsuarioVal != null && idUsuarioVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idUsuarioVal.ToString(), out parsed))
                        comboBox_IDUsuario.SelectedValue = parsed;
                }

                var idClienteVal = row.Cells["ID del Cliente"].Value;
                if (idClienteVal != null && idClienteVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idClienteVal.ToString(), out parsed))
                        comboBox_IDCliente.SelectedValue = parsed;
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
                Venta vent = new Venta();
                vent.NumeroFactura = int.Parse(textBox_NumeroFactura.Text);
                vent.IdUsuario = idUsuario;
                vent.IdCliente = idCliente;
                vent.MontoPago = decimal.Parse(textBox_MontoPago.Text);
                vent.MontoCambio = decimal.Parse(textBox_MontoCambio.Text);
                vent.MontoTotal = decimal.Parse(textBox_MontoTotal.Text);
                vent.FechaVenta = dateTimePicker1.Value;
                ControlVentas control = new ControlVentas();
                MessageBox.Show(control.ctrlAgregarVenta(vent), "Control de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_NumeroFactura.Clear();
                textBox_MontoPago.Clear();
                textBox_MontoCambio.Clear();
                textBox_MontoTotal.Clear();
                textBox_NumeroFactura.Focus();
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
                Venta vent = new Venta();
                vent.NumeroFactura = int.Parse(textBox_NumeroFactura.Text);
                vent.IdUsuario = idUsuario;
                vent.IdCliente = idCliente;
                vent.MontoPago = decimal.Parse(textBox_MontoPago.Text);
                vent.MontoCambio = decimal.Parse(textBox_MontoCambio.Text);
                vent.MontoTotal = decimal.Parse(textBox_MontoTotal.Text);
                vent.FechaVenta = dateTimePicker1.Value;
                ControlVentas control = new ControlVentas();
                MessageBox.Show(control.ctrlModificarVenta(vent), "Control de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_NumeroFactura.Clear();
                textBox_MontoPago.Clear();
                textBox_MontoCambio.Clear();
                textBox_MontoTotal.Clear();
                textBox_NumeroFactura.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Venta vent = new Venta();
                vent.NumeroFactura = int.Parse(textBox_NumeroFactura.Text);
                ControlVentas control = new ControlVentas();
                MessageBox.Show(control.ctrlBorrarVenta(vent), "Control de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_NumeroFactura.Clear();
                textBox_NumeroFactura.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
