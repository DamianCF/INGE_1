using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorFacturaCompras : IDisposable
    {
        public GestorFacturaCompras()
        {

        }
        public void Dispose()
        {

        }
        public string InsertarFacturaCompra(string fc_codigo, string fc_nomProveedor, string fc_fecCompra, string fc_detalle, string fc_metodoPago)
        {
            FacturaCompra nuevaFacturaCompra = new FacturaCompra(fc_codigo, fc_nomProveedor, fc_fecCompra, fc_detalle, fc_metodoPago);

            using (ServicioFacturaCompra FacturaCompra = new ServicioFacturaCompra())
              return  FacturaCompra.InsertarFacturaCompra(nuevaFacturaCompra);
        }

        public List<FacturaCompra> ListarFacturaCompras()
        {
            using (ServicioFacturaCompra FacturaCompra = new ServicioFacturaCompra())
            {
                return FacturaCompra.ListarFacturaCompras();
            }
        }

        public void ActualizarFacturaCompra(string id, string fc_codigo, string fc_nomProveedor, string fc_fecCompra, string fc_detalle, string fc_metodoPago)
        {
            FacturaCompra ActFacturaCompra = new FacturaCompra(id, fc_codigo, fc_nomProveedor, fc_fecCompra, fc_detalle, fc_metodoPago);
            using (ServicioFacturaCompra FacturaCompra = new ServicioFacturaCompra())
                FacturaCompra.ActualizarFacturaCompra(ActFacturaCompra);
        }
        public void EliminarFacturaCompra(string id)
        {
            using (ServicioFacturaCompra FacturaCompra = new ServicioFacturaCompra())
                FacturaCompra.EliminarFacturaCompra(id);
        }
    }
}