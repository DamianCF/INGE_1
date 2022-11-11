using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Servicios;

namespace CapaIntegracion
{
    public class GestorCompras : IDisposable
    {
        public GestorCompras()
        {

        }
        public void Dispose()
        {

        }
        public void InsertarCompra(string com_codigo, double com_monto, string com_fecha, string com_estado)
        {
            Compra nuevaCompra = new Compra(com_codigo, com_monto, com_fecha, com_estado);

            using (ServicioCompra Compra = new ServicioCompra())
                Compra.InsertarCompra(nuevaCompra);
        }

        public List<Compra> ListarCompras()
        {
            using (ServicioCompra Compra = new ServicioCompra())
            {
                return Compra.ListarCompras();
            }
        }

        public void ActualizarCompra(string id, string com_codigo, double com_monto, string com_fecha, string com_estado)
        {
            Compra ActCompra = new Compra(id, com_codigo, com_monto, com_fecha, com_estado);
            using (ServicioCompra Compra = new ServicioCompra())
                Compra.ActualizarCompra(ActCompra);
        }
        public void EliminarCompra(string id)
        {
            using (ServicioCompra Compra = new ServicioCompra())
                Compra.EliminarCompra(id);
        }
    }
}
