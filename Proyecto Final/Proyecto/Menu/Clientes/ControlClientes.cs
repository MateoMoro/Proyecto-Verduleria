using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Clientes
{
    internal class ControlClientes
    {
        public string ctrlAgregarCliente(Cliente cli)
        {
            ModeloClientes modelo = new ModeloClientes();
            string rta = "";

            if (cli == null)
                return "Cliente inválido";

            if (cli.IdCliente <= 0)
                rta = "Debe ingresar un ID válido";
            else if (string.IsNullOrWhiteSpace(cli.Documento))
                rta = "Debe ingresar el Documento";
            else if (string.IsNullOrWhiteSpace(cli.Nombre))
                rta = "Debe ingresar el Nombre";
            else
            {
                Cliente tmp = new Cliente { IdCliente = cli.IdCliente };
                if (modelo.existeCliente(tmp))
                {
                    rta = "¡El ID ya existe!";
                }
                else
                {
                    if (modelo.registrarCliente(cli))
                        rta = "¡Cliente registrado con éxito!";
                    else
                        rta = "Error al registrar el Cliente";
                }
            }

            return rta;
        }

        public string ctrlModificarCliente(Cliente cli)
        {
            ModeloClientes modelo = new ModeloClientes();
            string rta = "";

            if (cli == null)
                return "Cliente inválido";

            if (cli.IdCliente <= 0)
                rta = "Debe ingresar un ID válido";
            else if (string.IsNullOrWhiteSpace(cli.Documento))
                rta = "Debe ingresar el Documento";
            else if (string.IsNullOrWhiteSpace(cli.Nombre))
                rta = "Debe ingresar el Nombre";
            else
            {
                Cliente tmp = new Cliente { IdCliente = cli.IdCliente };
                if (!modelo.existeCliente(tmp))
                {
                    rta = "¡El ID no existe!";
                }
                else
                {
                    if (modelo.modificarCliente(cli))
                        rta = "¡Cliente modificado con éxito!";
                    else
                        rta = "Error al modificar el Cliente";
                }
            }

            return rta;
        }

        public string ctrlBorrarCliente(Cliente cli)
        {
            ModeloClientes modelo = new ModeloClientes();
            string rta = "";

            if (cli == null)
                return "Cliente inválido";

            if (cli.IdCliente <= 0)
                rta = "Debe ingresar un ID válido";
            else
            {
                Cliente tmp = new Cliente { IdCliente = cli.IdCliente };
                if (!modelo.existeCliente(tmp))
                {
                    rta = "¡El ID no existe!";
                }
                else
                {
                    if (modelo.borrarCliente(cli))
                        rta = "¡Cliente borrado con éxito!";
                    else
                        rta = "Error al borrar Cliente";
                }
            }

            return rta;
        }
    }
}
