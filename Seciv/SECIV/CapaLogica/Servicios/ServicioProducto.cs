using CapaConexion;
using CapaLogica.LogicaNegocio;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicios
{
    public class ServicioProducto : IDisposable
    {
        public ServicioProducto()
        {

        }

        public void Dispose()
        {

        }

        static IMongoCollection<Producto> collection = conexion.getDataBase().GetCollection<Producto>("Productos");

        public void InsertarProducto(Producto p)
        {
            collection.InsertOne(p);
        }
        public List<Producto> ListarProductos()
        {
            return collection.AsQueryable().ToList<Producto>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarProducto(Producto p)
        {
            collection.ReplaceOne(x => x.id == p.id, p);
        }
        public void EliminarProducto(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }

    }
}
