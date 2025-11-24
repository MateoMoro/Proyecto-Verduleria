using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Ventas
{
    internal class ControlVentas
    {
        public string ctrlAgregarVenta(Venta vent)
        {
            ModeloVentas modelo = new ModeloVentas();
            string rta = "";

            if (vent == null)
                return "Venta inválida";
            else if (vent.NumeroFactura < 0)
                rta = "Debe ingresar el Numero de Factura";
            else
            {
                Venta tmp = new Venta { NumeroFactura = vent.NumeroFactura };
                if (modelo.existeVenta(tmp))
                {
                    rta = "¡La venta ya existe!";
                }
                else
                {
                    if (modelo.registrarVenta(vent))
                        rta = "¡Venta registrada con éxito!";
                    else
                        rta = "Error al registrar la Venta";
                }
            }

            return rta;
        }

        public string ctrlModificarVenta(Venta vent)
        {
            ModeloVentas modelo = new ModeloVentas();
            string rta = "";

            if (vent == null)
                return "Venta inválida";
            else if (vent.NumeroFactura < 0)
                rta = "Debe ingresar el Numero de Factura";
            else
            {
                Venta tmp = new Venta { NumeroFactura = vent.NumeroFactura };
                if (!modelo.existeVenta(vent))
                {
                    rta = "¡La venta no existe!";
                }
                else
                {
                    if (modelo.modificarVenta(vent))
                        rta = "¡Venta modificada con éxito!";
                    else
                        rta = "Error al modificar la Venta";
                }
            }

            return rta;
        }

        public string ctrlBorrarVenta(Venta vent)
        {
            ModeloVentas modelo = new ModeloVentas();
            string rta = "";

            if (vent == null)
                return "Venta inválida";
            else
            {
                Venta tmp = new Venta { NumeroFactura = vent.NumeroFactura };
                if (!modelo.existeVenta(tmp))
                {
                    rta = "¡La Venta no existe!";
                }
                else
                {
                    if (modelo.borrarVenta(vent))
                        rta = "¡Venta borrada con éxito!";
                    else
                        rta = "Error al borrar la Venta";
                }
            }

            return rta;
        }
    }
}
