using Proyecto_Final.Clases;
using Proyecto_Final.Proyecto.Menu.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Proyecto.Menu.Compras
{
    internal class ControlCompras
    {
        public string ctrlAgregarCompra(Compra comp)
        {
            ModeloCompras modelo = new ModeloCompras();
            string rta = "";

            if (comp == null)
                return "Compra inválida";
            else if (comp.NumeroFactura < 0)
                rta = "Debe ingresar el Numero de Factura";
            else
            {
                Compra tmp = new Compra { NumeroFactura = comp.NumeroFactura };
                if (modelo.existeCompra(tmp))
                {
                    rta = "¡La Compra ya existe!";
                }
                else
                {
                    if (modelo.registrarCompra(comp))
                        rta = "¡Compra registrada con éxito!";
                    else
                        rta = "Error al registrar la Compra";
                }
            }

            return rta;
        }

        public string ctrlModificarCompra(Compra comp)
        {
            ModeloCompras modelo = new ModeloCompras();
            string rta = "";

            if (comp == null)
                return "Compra inválida";
            else if (comp.NumeroFactura < 0)
                rta = "Debe ingresar el Numero de Factura";
            else
            {
                Compra tmp = new Compra { NumeroFactura = comp.NumeroFactura };
                if (!modelo.existeCompra(tmp))
                {
                    rta = "¡La Compra no existe!";
                }
                else
                {
                    if (modelo.modificarCompra(comp))
                        rta = "¡Compra modificada con éxito!";
                    else
                        rta = "Error al modificar la Compra";
                }
            }

            return rta;
        }

        public string ctrlBorrarCompra(Compra comp)
        {
            ModeloCompras modelo = new ModeloCompras();
            string rta = "";

            if (comp == null)
                return "Compra inválida";
            else if (comp.NumeroFactura < 0)
                rta = "Debe ingresar el Numero de Factura";
            else
            {
                Compra tmp = new Compra { NumeroFactura = comp.NumeroFactura };
                if (!modelo.existeCompra(tmp))
                {
                    rta = "¡La Compra no existe!";
                }
                else
                {
                    if (modelo.borrarCompra(comp))
                        rta = "¡Compra borrada con éxito!";
                    else
                        rta = "Error al borrar la Compra";
                }
            }

            return rta;
        }
    }
}
