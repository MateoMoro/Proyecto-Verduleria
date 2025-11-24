using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Detalles_Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Detalles_Ventas
{
    internal class ControlDetallesVentas
    {
        public string ctrlAgregarDetalleVenta(DetalleVenta detalle)
        {
            ModeloDetallesVentas modelo = new ModeloDetallesVentas();
            string rta = "";

            if (detalle == null)
                return "Detalle de Venta inválido";
            else if (detalle.IdDetalleVenta < 0)
                rta = "Debe ingresar el Numero del Detalle de Venta";
            else
            {
                DetalleVenta tmp = new DetalleVenta { IdDetalleVenta = detalle.IdDetalleVenta };
                if (modelo.existeDetalleVenta(tmp))
                {
                    rta = "¡El Detalle de Venta ya existe!";
                }
                else
                {
                    if (modelo.registrarDetalleVenta(detalle))
                        rta = "¡Detalle de Venta registrado con éxito!";
                    else
                        rta = "Error al registrar el Detalle de Venta";
                }
            }

            return rta;
        }

        public string ctrlModificarDetalleVenta(DetalleVenta detalle)
        {
            ModeloDetallesVentas modelo = new ModeloDetallesVentas();
            string rta = "";

            if (detalle == null)
                return "Detalle de Venta inválido";
            else if (detalle.IdDetalleVenta < 0)
                rta = "Debe ingresar el ID del Detalle de Venta";
            else
            {
                DetalleVenta tmp = new DetalleVenta { IdDetalleVenta = detalle.IdDetalleVenta };
                if (!modelo.existeDetalleVenta(tmp))
                {
                    rta = "¡El Detalle de Venta no existe!";
                }
                else
                {
                    if (modelo.modificarDetalleVenta(detalle))
                        rta = "¡Detalle de Venta modificado con éxito!";
                    else
                        rta = "Error al modificar el Detalle de Venta";
                }
            }

            return rta;
        }

        public string ctrlBorrarDetalleVenta(DetalleVenta detalle)
        {
            ModeloDetallesVentas modelo = new ModeloDetallesVentas();
            string rta = "";

            if (detalle == null)
                return "Detalle de Venta inválido";
            else if (detalle.IdDetalleVenta < 0)
                rta = "Debe ingresar el ID del Detalle de Venta";
            else
            {
                DetalleVenta tmp = new DetalleVenta { IdDetalleVenta = detalle.IdDetalleVenta };
                if (!modelo.existeDetalleVenta(tmp))
                {
                    rta = "¡El Detalle de Venta no existe!";
                }
                else
                {
                    if (modelo.borrarDetalleVenta(detalle))
                        rta = "¡Detalle de Venta borrado con éxito!";
                    else
                        rta = "Error al borrar el Detalle de Venta";
                }
            }

            return rta;
        }
    }
}
