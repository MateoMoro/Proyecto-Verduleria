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
            cargarUsuariosEnComboBox();
        }

        private void textBoxCU_Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            Btn_BorrarUsuario.Visible = false;
            Btn_Volver.Visible = false;
            LCU_Nombre.Visible = true;
            textBoxCU_Nombre.Visible = true;
            LCU_Apellido.Visible = true;
            textBoxCU_Apellido.Visible = true;
            LCU_TipoUsuario.Visible = true;
            comboBoxCU_TipoUsuario.Visible = true;
            LCU_NombreUsuario.Visible = true;
            textBoxCU_NombreUsuario.Visible = true;
            LCU_Contraseña.Visible = true;
            textBoxCU_Contraseña.Visible = true;
            LCU_CContraseña.Visible = true;
            textBoxCU_CContraseña.Visible = true;
            BtnCU_Registrar.Visible = true;
            BtnCU_Cancelar.Visible = true;
            BtnCU_Volver.Visible = true;
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
                user.IdTipo = int.Parse(comboBoxCU_TipoUsuario.SelectedValue.ToString());
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
            Btn_Volver.Visible = true;
            LCU_Nombre.Visible = false;
            textBoxCU_Nombre.Visible = false;
            LCU_Apellido.Visible = false;
            textBoxCU_Apellido.Visible = false;
            LCU_TipoUsuario.Visible = false;
            comboBoxCU_TipoUsuario.Visible = false;
            LCU_NombreUsuario.Visible = false;
            textBoxCU_NombreUsuario.Visible = false;
            LCU_Contraseña.Visible = false;
            textBoxCU_Contraseña.Visible = false;
            LCU_CContraseña.Visible = false;
            textBoxCU_CContraseña.Visible = false;
            BtnCU_Registrar.Visible = false;
            BtnCU_Cancelar.Visible = false;
            BtnCU_Volver.Visible = false;
        }

        private void Btn_BorrarUsuario_Click(object sender, EventArgs e)
        {
            Btn_CrearUsuario.Visible = false;
            Btn_Volver.Visible = false;
            LBU_NombreUsuario.Visible = true;
            textBoxBU_NombreUsuario.Visible = true;
            LBU_Contraseña.Visible = true;
            textBoxBU_Contraseña.Visible = true;
            LBU_CContraseña.Visible = true;
            textBoxBU_CContraseña.Visible = true;
            BtnBU_Borrar.Visible = true;
            BtnBU_Cancelar.Visible = true;
            BtnBU_Volver.Visible = true;
        }

        private void BtnBU_Borrar_Click(object sender, EventArgs e)
        {

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
            Btn_Volver.Visible = true;
            LBU_NombreUsuario.Visible = false;
            textBoxBU_NombreUsuario.Visible = false;
            LBU_Contraseña.Visible = false;
            textBoxBU_Contraseña.Visible = false;
            LBU_CContraseña.Visible = false;
            textBoxBU_CContraseña.Visible = false;
            BtnBU_Borrar.Visible = false;
            BtnBU_Cancelar.Visible = false;
            BtnBU_Volver.Visible = false;
        }

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.Close();
            p.Show();
        }

        private void cargarUsuariosEnComboBox()
        {
            try
            {
                comboBoxCU_TipoUsuario.ValueMember = "idTipoUser";
                comboBoxCU_TipoUsuario.DisplayMember = "Nombre";
                modeloUsuarios m = new modeloUsuarios();
                comboBoxCU_TipoUsuario.DataSource = m.obtenerTipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
