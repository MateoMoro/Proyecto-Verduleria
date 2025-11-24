using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Proveedores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Productos
{
    internal class ControlProductos
    {
        public string ctrlAgregarProducto(Producto prod)
        {
            ModeloProductos modelo = new ModeloProductos();
            string rta = "";

            if (prod == null)
                return "Producto inválido";
            else if (string.IsNullOrWhiteSpace(prod.Codigo))
                rta = "Debe ingresar el Codigo";
            else
            {
                Producto tmp = new Producto { Codigo = prod.Codigo };
                if (modelo.existeProducto(tmp))
                {
                    rta = "¡El Codigo ya existe!";
                }
                else
                {
                    if (modelo.registrarProducto(prod))
                        rta = "¡Producto registrado con éxito!";
                    else
                        rta = "Error al registrar el Producto";
                }
            }

            return rta;
        }

        public string ctrlModificarProducto(Producto prod)
        {
            ModeloProductos modelo = new ModeloProductos();
            string rta = "";

            if (prod == null)
                return "Producto inválido";
            else if (string.IsNullOrWhiteSpace(prod.Codigo))
                rta = "Debe ingresar el Codigo";
            else
            {
                Producto tmp = new Producto { Codigo = prod.Codigo };
                if (!modelo.existeProducto(tmp))
                {
                    rta = "¡El Codigo no existe!";
                }
                else
                {
                    if (modelo.modificarProducto(prod))
                        rta = "¡Producto modificado con éxito!";
                    else
                        rta = "Error al modificar el Producto";
                }
            }

            return rta;
        }

        public string ctrlBorrarProducto(Producto prod)
        {
            ModeloProductos modelo = new ModeloProductos();
            string rta = "";

            if (prod == null)
                return "Producto inválido";
            else
            {
                Producto tmp = new Producto { Codigo = prod.Codigo };
                if (!modelo.existeProducto(tmp))
                {
                    rta = "¡El Codigo no existe!";
                }
                else
                {
                    if (modelo.borrarProducto(prod))
                        rta = "¡Producto borrado con éxito!";
                    else
                        rta = "Error al borrar el Producto";
                }
            }

            return rta;
        }
    }
}
