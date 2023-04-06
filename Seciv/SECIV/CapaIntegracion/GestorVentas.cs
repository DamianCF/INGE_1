using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorVentas : IDisposable
    {
        public GestorVentas()
        {

        }

        public void Dispose()
        {

        }

        public void InsertarVenta(string vent_fecha, string vent_nombreComprador, List<Producto> vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_subTotal, Double vent_total, string vent_estado)
        {
            Venta nuevaVenta = new Venta(vent_fecha, vent_nombreComprador, vent_productos, vent_detalle, vent_metodoPago, vent_descuento, vent_impuesto, vent_subTotal, vent_total, vent_estado);
            using (ServicioVenta Venta = new ServicioVenta())
                Venta.InsertarVenta(nuevaVenta);
            //{
            //    if (Venta.InsertarVenta(nuevaVenta)) //Actualizar el stock de los productos
            //    {
            //        foreach (Producto prod in vent_productos) //recorrer vent_productos
            //        {
            //            //obtener productos de bd y encontrar el que coincide con prod

            //            //realizar la comparacion y resta de cantStok en el producto de la bd 

            //            //actualizar producto en bd
            //        }
            //    }
            //}
        }

        public List<Venta> ListarVentas()
        {
            using (ServicioVenta Venta = new ServicioVenta())
            {
                return Venta.ListarVentas();
            }
        }

        public void ActualizarVentas(string id, int vent_codigo, string vent_fecha, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_subTotal, Double vent_total, string vent_estado)
        {
            //Venta ActVenta = new Venta(id, vent_codigo, vent_fecha, vent_nombreComprador, vent_productos, vent_detalle,
            // vent_metodoPago, vent_descuento, vent_impuesto, vent_subTotal, vent_total, vent_estado);
            //using (ServicioVenta Venta = new ServicioVenta())
            //    Venta.ActualizarVenta(ActVenta);
        }
        public void EliminarVenta(string id)
        {
            using (ServicioVenta Venta = new ServicioVenta())
                Venta.EliminarVenta(id);
        }

    }
}
