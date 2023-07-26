using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void InsertarVenta(string vent_fecha, string vent_nombreComprador, List<Producto> vent_productos, string vent_detalle, string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_subTotal, Double vent_total, string vent_estado)
        {
            Venta nuevaVenta = new Venta(vent_fecha, vent_nombreComprador, vent_productos, vent_detalle, vent_metodoPago, vent_descuento, vent_impuesto, vent_subTotal, vent_total, vent_estado);
            using (ServicioVenta Venta = new ServicioVenta())
                //Venta.InsertarVenta(nuevaVenta);
                if (Venta.InsertarVenta(nuevaVenta))  //si se inserto la venta actualizar stock
                {
                    List<Producto> listaProductos = new List<Producto>();
                    using (ServicioProducto Producto = new ServicioProducto())//obtener productos de BD
                        listaProductos = Producto.ListarProductos();

                    foreach (Producto prod in vent_productos) //recorrer vent_productos y realizar la resta de cantStok en el producto de la bd 
                    {
                        Producto productoBD = listaProductos.FirstOrDefault(p => p.id == prod.id);//obtener producto en BD que coincide con prod
                        productoBD.prd_cantStock = productoBD.prd_cantStock - prod.prd_cantStock;//restar cantStock de producto en BD

                        using (ServicioProducto Producto = new ServicioProducto())
                            Producto.ActualizarProducto(productoBD); //actualizar producto en bd = Actualizar el stock de los productos
                    }
                }
        }

        public List<Venta> ListarVentas()
        {
            using (ServicioVenta Venta = new ServicioVenta())
            {
                return Venta.ListarVentas();
            }
        }


        public (List<Venta>, double) ListarVentasEntreFechas(string fechaIni, string fechaFin)
        {
            //var query = comprasCollection
            //.Where(x => DateTime.ParseExact(x.com_fecha, "d/M/yyyy", null) >= startDate &&
            //     DateTime.ParseExact(x.com_fecha, "d/M/yyyy", null) <= endDate).ToList();

            ServicioVenta Venta = new ServicioVenta();
            //return Compra.ListarComprasEntreFechas(fechaIni, fechaFin);

            var startDate = DateTime.ParseExact(fechaIni, "d/M/yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(fechaFin, "d/M/yyyy", CultureInfo.InvariantCulture);

            var ventasCollection = Venta.getCollectionVentas().AsQueryable();
            // Convertir buy.com_fecha a DateTime fuera de la consulta LINQ
            var comprasFiltradas = ventasCollection
                .ToList() // Obtener la lista de compras como objetos en memoria
                .Where(buy => DateTime.ParseExact(buy.vent_fecha, "d/M/yyyy", CultureInfo.InvariantCulture) >= startDate &&
                              DateTime.ParseExact(buy.vent_fecha, "d/M/yyyy", CultureInfo.InvariantCulture) <= endDate);

            var query = from buy in comprasFiltradas
                        select new
                        {
                            id = buy.id,
                            vent_codigo = buy.vent_codigo,
                            vent_fecha = buy.vent_fecha.ToString(),
                            vent_nombreComprador = buy.vent_nombreComprador,
                            vent_detalle = buy.vent_detalle.ToString(),
                            vent_metodoPago = buy.vent_metodoPago,
                            vent_descuento = buy.vent_descuento,
                            vent_impuesto = buy.vent_impuesto,
                            vent_subTotal = buy.vent_subTotal,
                            vent_total = buy.vent_total,
                            vent_estado = buy.vent_estado
                        };

            List < Venta> listaVentas = new List<Venta>();
            double totalVentas = 0;
            foreach (var com in query)  // da error aqui
            {
                totalVentas += com.vent_total;
                Venta venta = new Venta(com.id, com.vent_codigo, com.vent_fecha, com.vent_nombreComprador, com.vent_detalle, com.vent_metodoPago, com.vent_descuento, com.vent_impuesto,
             com.vent_subTotal, com.vent_total, com.vent_estado);
                listaVentas.Add(venta);
            }
            // Imprimimos los resultados de la consulta
            //foreach (var product in productsWithCategories)
            //{
            //    Console.WriteLine($"ID #{product.productId} - Nombre: ${product.name} - Categoria: {product.categoryName}");
            //}

            return (listaVentas, totalVentas);
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
