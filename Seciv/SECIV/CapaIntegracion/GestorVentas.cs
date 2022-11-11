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

        public void Insertarventa(string vent_codigo, Double vent_monto, string vent_fecha, string estado_Venta)
        {
            Venta nuevaVenta = new Venta(vent_codigo, vent_monto, vent_fecha, estado_Venta);

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

        public void ActualizarVentas(string id, string vent_codigo, Double vent_monto, string vent_fecha, string estado_Venta)
        {
            Venta ActVenta = new Venta(id, vent_codigo, vent_monto, vent_fecha, estado_Venta);
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
