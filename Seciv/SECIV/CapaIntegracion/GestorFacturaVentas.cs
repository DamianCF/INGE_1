using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorFacturaVentas : IDisposable
    {
        public GestorFacturaVentas()
        {

        }

        public void Dispose()
        {

        }

        public void InsertarFacturaVentas(string fv_codigo, string fv_nomComprador, string fv_fecVenta, string fv_Productos, string fv_detalle, string fv_metodoPago)
        {
            FacturaVenta nuevaFacturaVenta = new FacturaVenta(fv_codigo, fv_nomComprador, fv_fecVenta, fv_Productos, fv_detalle, fv_metodoPago);

            using (ServicioFacturaVenta FacturaVenta = new ServicioFacturaVenta())
                FacturaVenta.InsertarFacturaVenta(nuevaFacturaVenta);
        }

        public List<FacturaVenta> ListarFacturaVenta()
        {
            using (ServicioFacturaVenta FacturaVenta = new ServicioFacturaVenta())
            {
                return FacturaVenta.ListarFacturaVenta();
            }
        }

        public void ActualizarFacturaVenta(string id, string fv_codigo, string fv_nomComprador, string fv_fecVenta, string fv_Productos, string fv_detalle, string fv_metodoPago)
        {
            FacturaVenta ActFacturaVenta = new FacturaVenta(id, fv_codigo, fv_nomComprador, fv_fecVenta, fv_Productos, fv_detalle, fv_metodoPago);
            using (ServicioFacturaVenta FacturaVenta = new ServicioFacturaVenta())
                FacturaVenta.ActualizarFacturaVenta(ActFacturaVenta);
        }

        public void EliminarFacturaVenta(string id)
        {
            using (ServicioFacturaVenta FacturaVenta = new ServicioFacturaVenta())
                FacturaVenta.EliminarFacturaVenta(id);
        }
    }
}