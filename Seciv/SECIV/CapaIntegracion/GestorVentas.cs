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

        public void Insertarventa(string vent_codigo, Double vent_monto, string vent_fecha, string vent_estado, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_total, Double vent_subTotal)
        {
            Venta nuevaVenta = new Venta(vent_codigo, vent_monto, vent_fecha, vent_estado, vent_nombreComprador, vent_productos, vent_detalle
                , vent_metodoPago, vent_descuento, vent_impuesto, vent_total, vent_subTotal);

            using (ServicioVenta Venta = new ServicioVenta())
                Venta.InsertarVenta(nuevaVenta);
        }

        public List<Venta> ListarVentas()
        {
            using (ServicioVenta Venta = new ServicioVenta())
            {
                return Venta.ListarVentas();
            }
        }

        public void ActualizarVentas(string id, string vent_codigo, Double vent_monto, string vent_fecha, string vent_estado, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_total, Double vent_subTotal)
        {
            Venta ActVenta = new Venta(id, vent_codigo, vent_monto, vent_fecha, vent_estado, vent_nombreComprador, vent_productos, vent_detalle
                , vent_metodoPago, vent_descuento, vent_impuesto, vent_total, vent_subTotal);
            using (ServicioVenta Venta = new ServicioVenta())
                Venta.ActualizarVenta(ActVenta);
        }
        public void EliminarVenta(string id)
        {
            using (ServicioVenta Venta = new ServicioVenta())
                Venta.EliminarVenta(id);
        }

    }
}
