using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Proveedores
{
    internal class ControlProveedores
    {
        public string ctrlAgregarProveedor(Proveedor prov)
        {
            ModeloProveedores modelo = new ModeloProveedores();
            string rta = "";

            if (prov == null)
                return "Proveedor inválido";

            if (prov.IdProveedor <= 0)
                rta = "Debe ingresar un ID válido";
            else if (string.IsNullOrWhiteSpace(prov.Documento))
                rta = "Debe ingresar el documento";
            else if (string.IsNullOrWhiteSpace(prov.RazonSocial))
                rta = "Debe ingresar la razón social";
            else
            {
                Proveedor tmp = new Proveedor { IdProveedor = prov.IdProveedor };
                if (modelo.existeProveedor(tmp))
                {
                    rta = "¡El ID ya existe!";
                }
                else
                {
                    if (modelo.registrarProveedor(prov))
                        rta = "¡Proveedor registrado con éxito!";
                    else
                        rta = "Error al registrar proveedor";
                }
            }

            return rta;
        }

        public string ctrlModificarProveedor(Proveedor prov)
        {
            ModeloProveedores modelo = new ModeloProveedores();
            string rta = "";

            if (prov == null)
                return "Proveedor inválido";

            if (prov.IdProveedor <= 0)
                rta = "Debe ingresar un ID válido";
            else if (string.IsNullOrWhiteSpace(prov.Documento))
                rta = "Debe ingresar el documento";
            else if (string.IsNullOrWhiteSpace(prov.RazonSocial))
                rta = "Debe ingresar la razón social";
            else
            {
                Proveedor tmp = new Proveedor { IdProveedor = prov.IdProveedor };
                if (!modelo.existeProveedor(tmp))
                {
                    rta = "¡El ID no existe!";
                }
                else
                {
                    if (modelo.modificarProveedor(prov))
                        rta = "¡Proveedor modificado con éxito!";
                    else
                        rta = "Error al modificar proveedor";
                }
            }

            return rta;
        }

        public string ctrlBorrarProveedor(Proveedor prov)
        {
            ModeloProveedores modelo = new ModeloProveedores();
            string rta = "";

            if (prov == null)
                return "Proveedor inválido";

            if (prov.IdProveedor <= 0)
                rta = "Debe ingresar un ID válido";
            else
            {
                Proveedor tmp = new Proveedor { IdProveedor = prov.IdProveedor };
                if (!modelo.existeProveedor(tmp))
                {
                    rta = "¡El ID no existe!";
                }
                else
                {
                    if (modelo.borrarProveedor(prov))
                        rta = "¡Proveedor borrado con éxito!";
                    else
                        rta = "Error al borrar proveedor";
                }
            }

            return rta;
        }
    }
}
