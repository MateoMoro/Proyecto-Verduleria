using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Compras;
using System;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Final.Proyecto.Menu.Detalles_Compras
{
    public partial class FormDetallesCompras : Form
    {
        Compra idCompra;
        Producto idProducto;

        public FormDetallesCompras()
        {
            InitializeComponent();
            cargarIDCompraEnComboBox();
            cargarIDProductoEnComboBox();
            cargarDataGrid();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void cargarIDCompraEnComboBox()
        {
            try
            {
                comboBox_IDCompra.ValueMember = "id_compras";
                comboBox_IDCompra.DisplayMember = "numero_factura";
                ModeloDetallesCompras m = new ModeloDetallesCompras();
                comboBox_IDCompra.DataSource = m.obtenerIDCompra();
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
                comboBox_IDProducto.DisplayMember = "id";
                ModeloDetallesCompras m = new ModeloDetallesCompras();
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
            ModeloDetallesCompras m = new ModeloDetallesCompras();
            dataGridView1.DataSource = m.obtenerDetalleCompra();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        // Al seleccionar fila vuelca los valores a los controles
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;
                var row = dataGridView1.Rows[e.RowIndex];

                // Aliases en obtenerDetalleCompra: 'ID', 'ID de la Compra', 'ID del Producto', 'Precio de Compra', 'Cantidad', 'Fecha de la Compra'
                textBox_IdDetalleCompra.Text = row.Cells["ID"].Value?.ToString() ?? "";
                textBox_PrecioCompra.Text = row.Cells["Precio de Compra"].Value?.ToString() ?? "";
                textBox_Cantidad.Text = row.Cells["Cantidad"].Value?.ToString() ?? "";

                var fechaObj = row.Cells["Fecha de la Compra"].Value;
                DateTime fecha;
                if (fechaObj != null && DateTime.TryParse(fechaObj.ToString(), out fecha))
                    dateTimePicker1.Value = fecha;

                var idCompraVal = row.Cells["ID de la Compra"].Value;
                if (idCompraVal != null && idCompraVal != DBNull.Value)
                {
                    int parsed;
                    if (int.TryParse(idCompraVal.ToString(), out parsed))
                        comboBox_IDCompra.SelectedValue = parsed;
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

        private void Btn_Agregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DetalleCompra detalleCompra = new DetalleCompra();
                detalleCompra.IdDetalleCompra = int.Parse(textBox_IdDetalleCompra.Text);
                detalleCompra.IdCompra = idCompra;
                detalleCompra.IdProducto = idProducto;
                detalleCompra.PrecioCompra = decimal.Parse(textBox_PrecioCompra.Text);
                detalleCompra.Cantidad = int.Parse(textBox_Cantidad.Text);
                detalleCompra.FechaCreacion = dateTimePicker1.Value;
                ControlDetallesCompras control = new ControlDetallesCompras();
                MessageBox.Show(control.ctrlAgregarDetalleCompra(detalleCompra), "Control de Detalles de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_IdDetalleCompra.Clear();
                textBox_PrecioCompra.Clear();
                textBox_Cantidad.Clear();
                textBox_IdDetalleCompra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Agregar el Detalle de Compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_IDCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCompra = new Compra();
            idCompra.IdCompra = int.Parse(comboBox_IDCompra.SelectedValue.ToString());
            idCompra.NumeroFactura = int.Parse(comboBox_IDCompra.Text.ToString());
        }

        private void comboBox_IDProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProducto = new Producto();
            idProducto.IdProducto = int.Parse(comboBox_IDProducto.SelectedValue.ToString());
        }

        private void Btn_Modificar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DetalleCompra detalleCompra = new DetalleCompra();
                detalleCompra.IdDetalleCompra = int.Parse(textBox_IdDetalleCompra.Text);
                detalleCompra.IdCompra = idCompra;
                detalleCompra.IdProducto = idProducto;
                detalleCompra.PrecioCompra = decimal.Parse(textBox_PrecioCompra.Text);
                detalleCompra.Cantidad = int.Parse(textBox_Cantidad.Text);
                detalleCompra.FechaCreacion = dateTimePicker1.Value;
                ControlDetallesCompras control = new ControlDetallesCompras();
                MessageBox.Show(control.ctrlModificarDetalleCompra(detalleCompra), "Control de Detalles de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_IdDetalleCompra.Clear();
                textBox_PrecioCompra.Clear();
                textBox_Cantidad.Clear();
                textBox_IdDetalleCompra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Modificar el Detalle de Compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Borrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DetalleCompra detalleCompra = new DetalleCompra();
                detalleCompra.IdDetalleCompra = int.Parse(textBox_IdDetalleCompra.Text);
                ControlDetallesCompras control = new ControlDetallesCompras();
                MessageBox.Show(control.ctrlBorrarDetalleCompra(detalleCompra), "Control de Detalles de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cargarDataGrid();
                textBox_IdDetalleCompra.Clear();
                textBox_IdDetalleCompra.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Borrar el Detalle de Compra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
