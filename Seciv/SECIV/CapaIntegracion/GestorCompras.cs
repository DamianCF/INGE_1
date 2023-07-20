using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Servicios;
using MongoDB.Driver;
using System.Globalization;

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
            string com_metodoPago, Double com_impuesto, Double com_total, Double com_subTotal)
        {
            Compra nuevaCompra = new Compra(com_monto, com_fecha, com_estado, com_nombreProveedor, com_productos, com_detalle,
                com_metodoPago, com_impuesto, com_total, com_subTotal);

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

        public (List<Compra>, double) ListarComprasEntreFechas(string fechaIni, string fechaFin)
        {
            //var query = comprasCollection
            //.Where(x => DateTime.ParseExact(x.com_fecha, "d/M/yyyy", null) >= startDate &&
            //     DateTime.ParseExact(x.com_fecha, "d/M/yyyy", null) <= endDate).ToList();

            ServicioCompra Compra = new ServicioCompra();
            //return Compra.ListarComprasEntreFechas(fechaIni, fechaFin);

            var startDate = DateTime.ParseExact(fechaIni, "d/M/yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(fechaFin, "d/M/yyyy", CultureInfo.InvariantCulture);
            
            var comprasCollection = Compra.getCollectionCompras().AsQueryable();
            // Convertir buy.com_fecha a DateTime fuera de la consulta LINQ
            var comprasFiltradas = comprasCollection
                .ToList() // Obtener la lista de compras como objetos en memoria
                .Where(buy => DateTime.ParseExact(buy.com_fecha, "d/M/yyyy", CultureInfo.InvariantCulture) >= startDate &&
                              DateTime.ParseExact(buy.com_fecha, "d/M/yyyy", CultureInfo.InvariantCulture) <= endDate);

            var query = from buy in comprasFiltradas
                        select new
                        {
                            id = buy.id,
                            com_codigo = buy.com_codigo,
                            com_monto = buy.com_monto,
                            com_fecha = buy.com_fecha.ToString(),
                            com_estado = buy.com_estado,
                            com_nombreProveedor = buy.com_nombreProveedor,
                            com_productos = buy.com_productos,
                            com_detalle = buy.com_detalle,
                            com_metodoPago = buy.com_metodoPago,
                            com_impuesto = buy.com_impuesto,
                            com_subTotal = buy.com_subTotal,
                            com_total = buy.com_total
                        };

            List<Compra> listaCompras = new List<Compra>();
            double totalCompras = 0;
            foreach (var com in query)  // da error aqui
            {
                totalCompras += com.com_monto;
                Compra compra = new Compra(com.id, com.com_codigo, com.com_monto, com.com_fecha, com.com_estado, com.com_nombreProveedor, com.com_productos, com.com_detalle,
             com.com_metodoPago, com.com_impuesto, com.com_subTotal, com.com_total);
                listaCompras.Add(compra);
            }
            // Imprimimos los resultados de la consulta
            //foreach (var product in productsWithCategories)
            //{
            //    Console.WriteLine($"ID #{product.productId} - Nombre: ${product.name} - Categoria: {product.categoryName}");
            //}

            return (listaCompras, totalCompras);
        }

        public void ActualizarCompra(string id, int com_codigo, double com_monto, string com_fecha, string com_estado, string com_nombreProveedor, string com_productos, string com_detalle,
            string com_metodoPago, Double com_impuesto, Double com_total, Double com_subTotal)
        {
            Compra ActCompra = new Compra(id, com_codigo, com_monto, com_fecha, com_estado, com_nombreProveedor, com_productos, com_detalle,
                com_metodoPago, com_impuesto, com_total, com_subTotal);
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
