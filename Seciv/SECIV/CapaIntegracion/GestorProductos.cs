using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
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

        public void InsertarProducto(string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, decimal prd_utilidad, double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
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

        public void ActualizarProducto(string id, string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, decimal prd_utilidad, double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
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

    }
}
