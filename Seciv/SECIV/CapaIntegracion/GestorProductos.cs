using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorProductos : IDisposable
    {
        public GestorProductos()
        {

        }

        public void Dispose()
        {

        }

        public void InsertarProducto(string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, double prd_utilidad, double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
        {
            Producto nuevoProducto = new Producto(prd_codigo, prd_nombre, prd_descripcion, prd_precioCosto, prd_utilidad, prd_precioVenta, prd_porcIVA, prd_cantStock, prd_idCategoria, prd_idDecoracion);

            using (ServicioProducto Producto = new ServicioProducto())
                Producto.InsertarProducto(nuevoProducto);
        }

        public List<Producto> ListarProductos()
        {
            using (ServicioProducto Producto = new ServicioProducto())
            {
                return Producto.ListarProductos();
            }
        }

        public void ActualizarProducto(string id, string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, double prd_utilidad, double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
        {
            Producto ActProducto = new Producto(id, prd_codigo, prd_nombre, prd_descripcion, prd_precioCosto, prd_utilidad, prd_precioVenta, prd_porcIVA, prd_cantStock, prd_idCategoria, prd_idDecoracion);
            using (ServicioProducto Producto = new ServicioProducto())
                Producto.ActualizarProducto(ActProducto);
        }

        public void EliminarProducto(string id)
        {
            using (ServicioProducto Producto = new ServicioProducto())
                Producto.EliminarProducto(id);
        }
        
            // Ejemplo de filtro
            //var query = productsCollection.AsQueryable().Where(p => p.prd_nombre == "Almohada").ToList();
            //query.ForEach(p => Console.WriteLine(p.ToJson()));

        public List<Producto> LookupProductoCategoria()
        {
            ServicioProducto Producto = new ServicioProducto();
            var productsCollection = Producto.getCollectionProducto().AsQueryable() ;
            ServicioCategoria Categoria = new ServicioCategoria();
            var categoriesCollection = Categoria.getCollectionCategoria().AsQueryable();

            // Realizamos el $lookup utilizando LINQ
            var productsWithCategories = from product in productsCollection
                                      join category in categoriesCollection
                                      on product.prd_idCategoria equals category.id into categoryJoin
                                      from category in categoryJoin.DefaultIfEmpty()
                                      select new
                                      {
                                          id = product.id,
                                          prd_codigo = product.prd_codigo,
                                          prd_nombre = product.prd_nombre,
                                          prd_descripcion = product.prd_descripcion,
                                          prd_precioCosto = product.prd_precioCosto,
                                          prd_utilidad = product.prd_utilidad,
                                          prd_precioVenta = product.prd_precioVenta,
                                          prd_porcIVA = product.prd_porcIVA,
                                          prd_cantStock = product.prd_cantStock,
                                          prd_idCategoria = product.prd_idCategoria,
                                          prd_idDecoracion = product.prd_idDecoracion,
                                          prd_nomCategoria = category != null ? category.cat_nombre : "Desconocido"
                                      };

            List<Producto> productsList = new List<Producto>();
            foreach (var product in productsWithCategories)
            {
                Producto producto = new Producto(product.id, product.prd_codigo, product.prd_nombre, product.prd_descripcion, product.prd_precioCosto, product.prd_utilidad, product.prd_precioVenta, product.prd_porcIVA, product.prd_cantStock, product.prd_idCategoria, product.prd_idDecoracion);
                producto.prd_nomCategoria = product.prd_nomCategoria;
                productsList.Add(producto);
            }
            // Imprimimos los resultados de la consulta
            //foreach (var product in productsWithCategories)
            //{
            //    Console.WriteLine($"ID #{product.productId} - Nombre: ${product.name} - Categoria: {product.categoryName}");
            //}
            return productsList;
        }

    }
}
