using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_FInal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = textBox_Usuario.Text;
                String pass = textBox_Contraseña.Text;
                Usuario u = new Usuario(usuario, pass);
                ControlLogin control = new ControlLogin();
                bool validacion = control.usuarioValido(u);
                if (validacion)
                {
                    MessageBox.Show("Bienvenido", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Principal p = new Principal();
                    this.Visible = false; //Oculta el formulario de inicio de sesión.
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Usuario / Password inválido. Revise los datos solicitados", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBox_Usuario.Text == "")
                        textBox_Usuario.Focus();
                    else
                        textBox_Contraseña.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            textBox_Usuario.Text = "";
            textBox_Contraseña.Text = "";
            textBox_Usuario.Focus();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Salir del sistema", "Disfrutable", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.Visible = false; 
            p.Show();
        }
    }
}
