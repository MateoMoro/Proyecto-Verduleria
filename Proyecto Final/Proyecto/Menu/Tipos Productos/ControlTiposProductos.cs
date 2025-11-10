using Proyecto_Final.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Tipos_Productos
{
    internal class ControlTiposProductos
    {
        public string ctrlAgregarTipoProducto(TipoProducto tipo)
        {
            ModeloTiposProductos modelo = new ModeloTiposProductos();
            string rta = "";

            if (tipo == null)
            {
                return "Tipo de producto inválido";
            }

            if (tipo.IdTipoProducto <= 0)
            {
                rta = "Debe ingresar un ID válido";
            }
            else if (string.IsNullOrWhiteSpace(tipo.Descripcion))
            {
                rta = "Debe ingresar una descripción";
            }
            else
            {
                TipoProducto tmp = new TipoProducto { IdTipoProducto = tipo.IdTipoProducto };
                if (modelo.existeTipoProducto(tmp))
                {
                    rta = "¡El ID ya existe!";
                }
                else
                {
                    if (modelo.registrarTipoProducto(tipo))
                        rta = "¡Tipo de producto registrado con éxito!";
                    else
                        rta = "Error al registrar tipo de producto";
                }
            }

            return rta;
        }

        public string ctrlModificarTipoProducto(TipoProducto tipo)
        {
            ModeloTiposProductos modelo = new ModeloTiposProductos();
            string rta = "";

            if (tipo == null)
            {
                return "Tipo de producto inválido";
            }

            if (tipo.IdTipoProducto <= 0)
            {
                rta = "Debe ingresar un ID válido";
            }
            else if (string.IsNullOrWhiteSpace(tipo.Descripcion))
            {
                rta = "Debe ingresar una descripción";
            }
            else
            {
                TipoProducto tmp = new TipoProducto { IdTipoProducto = tipo.IdTipoProducto };
                if (!modelo.existeTipoProducto(tmp))
                {
                    rta = "¡El ID no existe!";
                }
                else
                {
                    if (modelo.modificarTipoProducto(tipo))
                        rta = "¡Tipo de producto modificado con éxito!";
                    else
                        rta = "Error al modificar tipo de producto";
                }
            }

            return rta;
        }

        public string ctrlBorrarTipoProducto(TipoProducto tipo)
        {
            ModeloTiposProductos modelo = new ModeloTiposProductos();
            string rta = "";

            if (tipo == null)
            {
                return "Tipo de producto inválido";
            }

            if (tipo.IdTipoProducto <= 0)
            {
                rta = "Debe ingresar un ID válido";
            }
            else
            {
                TipoProducto tmp = new TipoProducto { IdTipoProducto = tipo.IdTipoProducto };
                if (!modelo.existeTipoProducto(tmp))
                {
                    rta = "¡El ID no existe!";
                }
                else
                {
                    if (modelo.borrarTipoProducto(tipo))
                        rta = "¡Tipo de producto borrado con éxito!";
                    else
                        rta = "Error al borrar tipo de producto";
                }
            }

            return rta;
        }
    }
}
