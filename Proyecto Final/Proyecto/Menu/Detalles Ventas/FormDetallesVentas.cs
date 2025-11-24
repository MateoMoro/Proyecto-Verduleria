using Proyecto_Final.Clases;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu.Detalles_Ventas
{
    public partial class FormDetallesVentas : Form
    {
        Venta idVenta;
        Producto idProducto;

        public FormDetallesVentas()
        {
            InitializeComponent();
            cargarIDVentaEnComboBox();
            cargarIDProductoEnComboBox();
            cargarDataGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
            Btn_Modificar.Click += Btn_Modificar_Click;
            Btn_Borrar.Click += Btn_Borrar_Click;
        }

        private void cargarIDVentaEnComboBox()
        {
            try
            {
                comboBox_IDVenta.ValueMember = "id_ventas";
                comboBox_IDVenta.DisplayMember = "numero_factura";
                ModeloDetallesVentas m = new ModeloDetallesVentas();
                comboBox_IDVenta.DataSource = m.obtenerIDVenta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarIDProductoEnComboBox()
        {
            try
            {
                comboBox_IDProducto.ValueMember = "id";
                comboBox_IDProducto.DisplayMember = "codigo";
                ModeloDetallesVentas m = new ModeloDetallesVentas();
                comboBox_IDProducto.DataSource = m.obtenerIDProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            ModeloDetallesVentas m = new ModeloDetallesVentas();
            dataGridView1.DataSource = m.obtenerDetalleVenta();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Rellenar controles al seleccionar fila
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dataGridView1.Rows[e.RowIndex];

                // Aliases en obtenerDetalleVenta: 'ID', 'ID de la Venta', 'ID del Producto', 'Precio de Venta', 'Cantidad', 'Subtotal', 'Fecha'
                textBox_IdDetalleVenta.Text = row.Cells["ID"].Value?.ToString() ?? "";
                textBox_PrecioVenta.Text = row.Cells["Precio de Venta"].Value?.ToString() ?? "";
                textBox_Cantidad.Text = row.Cells["Cantidad"].Value?.ToString() ?? "";
                textBox_SubTotal.Text = row.Cells["SubTotal"].Value?.ToString() ?? "";

                var fechaObj = row.Cells["Fecha"].Value;
                DateTime fecha;
                if (fechaObj != null && DateTime.TryParse(fechaObj.ToString(), out fecha))
                    dateTimePicker1.Value = fecha;

                var idVentaVal = row.Cells["ID de la Venta"].Value;
                if (idVentaVal != null && idVentaVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idVentaVal.ToString(), out parsed))
                        comboBox_IDVenta.SelectedValue = parsed;
                }

                var idProductoVal = row.Cells["ID del Producto"].Value;
                if (idProductoVal != null && idProductoVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idProductoVal.ToString(), out parsed))
                        comboBox_IDProducto.SelectedValue = parsed;
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
                DetalleVenta det = new DetalleVenta();
                det.IdDetalleVenta = int.Parse(textBox_IdDetalleVenta.Text);
                det.IdVenta = idVenta;
                det.IdProducto = idProducto;
                det.PrecioVenta = decimal.Parse(textBox_PrecioVenta.Text);
                det.Cantidad = int.Parse(textBox_Cantidad.Text);
                det.Subtotal = decimal.Parse(textBox_SubTotal.Text);
                det.FechaCreacion = dateTimePicker1.Value;
                ControlDetallesVentas control = new ControlDetallesVentas();
                MessageBox.Show(control.ctrlAgregarDetalleVenta(det), "Control de Detalles de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_IdDetalleVenta.Clear();
                textBox_PrecioVenta.Clear();
                textBox_Cantidad.Clear();
                textBox_SubTotal.Clear();
                textBox_IdDetalleVenta.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar el Detalle de Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_IDProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProducto = new Producto();
            idProducto.IdProducto = int.Parse(comboBox_IDProducto.SelectedValue.ToString());
            idProducto.Codigo = comboBox_IDProducto.Text.ToString();
        }

        private void comboBox_IDVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            idVenta = new Venta();
            idVenta.IdVenta = int.Parse(comboBox_IDVenta.SelectedValue.ToString());
            idVenta.NumeroFactura = int.Parse(comboBox_IDVenta.Text.ToString());
        }


        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleVenta det = new DetalleVenta();
                det.IdDetalleVenta = int.Parse(textBox_IdDetalleVenta.Text);
                det.IdVenta = idVenta;
                det.IdProducto = idProducto;
                det.PrecioVenta = decimal.Parse(textBox_PrecioVenta.Text);
                det.Cantidad = int.Parse(textBox_Cantidad.Text);
                det.Subtotal = decimal.Parse(textBox_SubTotal.Text);
                det.FechaCreacion = dateTimePicker1.Value;
                ControlDetallesVentas control = new ControlDetallesVentas();
                MessageBox.Show(control.ctrlModificarDetalleVenta(det), "Control de Detalles de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_IdDetalleVenta.Clear();
                textBox_PrecioVenta.Clear();
                textBox_Cantidad.Clear();
                textBox_SubTotal.Clear();
                textBox_IdDetalleVenta.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar el Detalle de Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleVenta det = new DetalleVenta();
                det.IdDetalleVenta = int.Parse(textBox_IdDetalleVenta.Text);
                ControlDetallesVentas control = new ControlDetallesVentas();
                MessageBox.Show(control.ctrlBorrarDetalleVenta(det), "Control de Detalles de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_IdDetalleVenta.Clear();
                textBox_IdDetalleVenta.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Borrar el Detalle de Venta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
