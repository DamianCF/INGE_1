using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorVentas:IDisposable
    {
        public GestorVentas()
        {

        }

        public void Dispose()
        {

        }

        public void Insertarventa(string codigo, Double monto, string fecha, string estado)
        {
            Venta nuevaVenta = new Venta(codigo, monto, fecha, estado);

            using (ServicioVenta laVenta = new ServicioVenta())
                laVenta.InsertarVenta(nuevaVenta);
        }

        public List<Venta> ListarVentas()
        {
            using (ServicioVenta laVenta = new ServicioVenta())
            {
                return laVenta.ListarVentas();
            }
        }

        public void ActualizarVentas(string id, string codigo, Double monto, string fecha, string estado)
        {
            Venta nuevaVenta = new Venta(id, codigo, monto, fecha, estado);
            using (ServicioVenta laVenta = new ServicioVenta())
                laVenta.ActualizarVentas(nuevaVenta);
        }
        public void EliminarVenta(string id)
        {
            using (ServicioVenta laVenta = new ServicioVenta())
                laVenta.EliminarVenta(id);
        }

    }
}
