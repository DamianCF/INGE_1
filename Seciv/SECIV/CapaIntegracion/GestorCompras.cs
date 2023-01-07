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
        public void InsertarCompra(double com_monto, string com_fecha, string com_estado, string com_nombreProveedor, string com_productos, string com_detalle,
            string com_metodoPago, Double com_descuento, Double com_impuesto, Double com_total, Double com_subTotal)
        {
            Compra nuevaCompra = new Compra(com_monto, com_fecha, com_estado, com_nombreProveedor, com_productos, com_detalle, 
                com_metodoPago, com_descuento, com_impuesto, com_total, com_subTotal);

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
        
        public void ActualizarCompra(string id, int com_codigo, double com_monto, string com_fecha, string com_estado, string com_nombreProveedor, string com_productos, string com_detalle,
            string com_metodoPago, Double com_descuento, Double com_impuesto, Double com_total, Double com_subTotal)
        {
            Compra ActCompra = new Compra(id , com_codigo, com_monto, com_fecha, com_estado, com_nombreProveedor, com_productos, com_detalle,
                com_metodoPago, com_descuento, com_impuesto, com_total, com_subTotal);
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
