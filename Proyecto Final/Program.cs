using System;
using System.Windows.Forms;
using Proyecto_Final.Proyecto.Inicio_Sesion;

namespace Proyecto_Final
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormInicioSesion());
        }
    }
}