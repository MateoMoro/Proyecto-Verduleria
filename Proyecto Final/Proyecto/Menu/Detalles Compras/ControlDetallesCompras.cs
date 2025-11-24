using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Compras;

namespace Proyecto_Final.Proyecto.Menu.Detalles_Compras
{
    internal class ControlDetallesCompras
    {
        public string ctrlAgregarDetalleCompra(DetalleCompra detalleCompra)
        {
            ModeloDetallesCompras modelo = new ModeloDetallesCompras();
            string rta = "";

            if (detalleCompra == null)
                return "Detalle de Compra inválido";
            else if (detalleCompra.IdDetalleCompra < 0)
                rta = "Debe ingresar el Numero del Detalle de Compra";
            else
            {
                DetalleCompra tmp = new DetalleCompra { IdDetalleCompra = detalleCompra.IdDetalleCompra };
                if (modelo.existeDetalleCompra(tmp))
                {
                    rta = "¡El Detalle de Compra ya existe!";
                }
                else
                {
                    if (modelo.registrarDetalleCompra(detalleCompra))
                        rta = "¡Detalle de Compra registrado con éxito!";
                    else
                        rta = "Error al registrar el Detalle de Compra";
                }
            }

            return rta;
        }

        public string ctrlModificarDetalleCompra(DetalleCompra detalleCompra)
        {
            ModeloDetallesCompras modelo = new ModeloDetallesCompras();
            string rta = "";

            if (detalleCompra == null)
                return "Detalle de Compra inválido";
            else if (detalleCompra.IdDetalleCompra < 0)
                rta = "Debe ingresar el ID del Detalle de Compra";
            else
            {
                DetalleCompra tmp = new DetalleCompra { IdDetalleCompra = detalleCompra.IdDetalleCompra };
                if (!modelo.existeDetalleCompra(tmp))
                {
                    rta = "¡El Detalle de Compra no existe!";
                }
                else
                {
                    if (modelo.modificarDetalleCompra(detalleCompra))
                        rta = "¡Detalle de Compra modificado con éxito!";
                    else
                        rta = "Error al modificar el Detalle de Compra";
                }
            }

            return rta;
        }

        public string ctrlBorrarDetalleCompra(DetalleCompra detalleCompra)
        {
            ModeloDetallesCompras modelo = new ModeloDetallesCompras();
            string rta = "";

            if (detalleCompra == null)
                return "Detalle de Compra inválido";
            else if (detalleCompra.IdDetalleCompra < 0)
                rta = "Debe ingresar el ID del Detalle de Compra";
            else
            {
                DetalleCompra tmp = new DetalleCompra { IdDetalleCompra = detalleCompra.IdDetalleCompra };
                if (!modelo.existeDetalleCompra(tmp))
                {
                    rta = "¡El Detalle de Compra no existe!";
                }
                else
                {
                    if (modelo.borrarDetalleCompra(detalleCompra))
                        rta = "¡Detalle de Compra borrado con éxito!";
                    else
                        rta = "Error al borrar el Detalle de Compra";
                }
            }

            return rta;
        }
    }
}
