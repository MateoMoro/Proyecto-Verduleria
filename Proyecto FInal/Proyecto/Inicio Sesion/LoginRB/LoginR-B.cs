using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_FInal.ModeloUsuario;

namespace Proyecto_FInal
{
    public partial class LoginRegistrarBorrarUsuario : Form
    {
        public LoginRegistrarBorrarUsuario()
        {
            InitializeComponent();
            cargarDataGrid();
        }

        private void cargarDataGrid()
        {
            dataGridView1.DataSource = null;
            modeloUsuarios m = new modeloUsuarios();
            dataGridView1.DataSource = m.obtenerUsuarios();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void Btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            Btn_BorrarUsuario.Visible = false;
            LCU_Nombre.Visible = true;
            textBoxCU_Nombre.Visible = true;
            LCU_Apellido.Visible = true;
            textBoxCU_Apellido.Visible = true;
            LCU_NombreUsuario.Visible = true;
            textBoxCU_NombreUsuario.Visible = true;
            LCU_Contraseña.Visible = true;
            textBoxCU_Contraseña.Visible = true;
            LCU_CContraseña.Visible = true;
            textBoxCU_CContraseña.Visible = true;
            BtnCU_Registrar.Visible = true;
            BtnCU_Cancelar.Visible = true;
            BtnCU_Volver.Visible = true;
            Btn_Listado.Visible = true;
        }

        private void BtnCU_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.UsuarioNombre = textBoxCU_NombreUsuario.Text;
                user.Password = textBoxCU_Contraseña.Text;
                user.PasswordConfirma = textBoxCU_CContraseña.Text;
                user.Nombre = textBoxCU_Nombre.Text;
                user.Apellido = textBoxCU_Apellido.Text;
                ControlRegistroUsuario control = new ControlRegistroUsuario();
                MessageBox.Show(control.ctrlRegistroUsuarios(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCU_Cancelar_Click(object sender, EventArgs e)
        {
            textBoxCU_Nombre.Text = "";
            textBoxCU_Apellido.Text = "";
            textBoxCU_NombreUsuario.Text = "";
            textBoxCU_Contraseña.Text = "";
            textBoxCU_CContraseña.Text = "";
            textBoxCU_Nombre.Focus();
        }

        private void BtnCU_Volver_Click(object sender, EventArgs e)
        {
            Btn_BorrarUsuario.Visible = true;
            LCU_Nombre.Visible = false;
            textBoxCU_Nombre.Visible = false;
            LCU_Apellido.Visible = false;
            textBoxCU_Apellido.Visible = false;
            LCU_NombreUsuario.Visible = false;
            textBoxCU_NombreUsuario.Visible = false;
            LCU_Contraseña.Visible = false;
            textBoxCU_Contraseña.Visible = false;
            LCU_CContraseña.Visible = false;
            textBoxCU_CContraseña.Visible = false;
            BtnCU_Registrar.Visible = false;
            BtnCU_Cancelar.Visible = false;
            BtnCU_Volver.Visible = false;
            Btn_Listado.Visible = false;
            dataGridView1.Visible = false;
            Btn_Actualizar.Visible = false;
        }

        private void Btn_BorrarUsuario_Click(object sender, EventArgs e)
        {
            Btn_CrearUsuario.Visible = false;
            LBU_NombreUsuario.Visible = true;
            textBoxBU_NombreUsuario.Visible = true;
            LBU_Contraseña.Visible = true;
            textBoxBU_Contraseña.Visible = true;
            LBU_CContraseña.Visible = true;
            textBoxBU_CContraseña.Visible = true;
            BtnBU_Borrar.Visible = true;
            BtnBU_Cancelar.Visible = true;
            BtnBU_Volver.Visible = true;
            Btn_Listado.Visible = true;
        }

        private void BtnBU_Borrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.UsuarioNombre = textBoxBU_NombreUsuario.Text;
                user.Password = textBoxBU_Contraseña.Text;
                user.PasswordConfirma = textBoxBU_CContraseña.Text;

                // ControlBorradoUsuario está en el namespace Proyecto_FInal.LoginRB
                LoginRB.ControlBorradoUsuario control = new LoginRB.ControlBorradoUsuario();
                string resultado = control.ctrlBorrarUsuario(user);
                MessageBox.Show(resultado, "Control de borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si se borró, o tras el aviso, limpiar campos
                textBoxBU_NombreUsuario.Text = "";
                textBoxBU_Contraseña.Text = "";
                textBoxBU_CContraseña.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnBU_Cancelar_Click(object sender, EventArgs e)
        {
            textBoxBU_NombreUsuario.Text = "";
            textBoxBU_Contraseña.Text = "";
            textBoxBU_CContraseña.Text = "";
            textBoxBU_NombreUsuario.Focus();
        }

        private void BtnBU_Volver_Click(object sender, EventArgs e)
        {
            Btn_CrearUsuario.Visible = true;
            LBU_NombreUsuario.Visible = false;
            textBoxBU_NombreUsuario.Visible = false;
            LBU_Contraseña.Visible = false;
            textBoxBU_Contraseña.Visible = false;
            LBU_CContraseña.Visible = false;
            textBoxBU_CContraseña.Visible = false;
            BtnBU_Borrar.Visible = false;
            BtnBU_Cancelar.Visible = false;
            BtnBU_Volver.Visible = false;
            Btn_Listado.Visible = false;
            dataGridView1.Visible = false;
            Btn_Actualizar.Visible = false;
        } 

        private void Btn_Listado_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            Btn_Actualizar.Visible = true;
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            // Recarga los datos del DataGridView
            cargarDataGrid();
        }
    }
}
