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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Btn_CBUsuario_Click(object sender, EventArgs e)
        {
            LoginRegistrarBorrarUsuario p = new LoginRegistrarBorrarUsuario();
            this.Close();
            p.Show();
        }

        private void Btn_Compras_Click(object sender, EventArgs e)
        {
            Finanzas f = new Finanzas();
            this.Close();
            f.Show();
        }

        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            Inventario i = new Inventario();
            this.Close();
            i.Show();
        }
    }
}
