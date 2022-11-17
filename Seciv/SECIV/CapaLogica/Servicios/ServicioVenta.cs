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
    public class ServicioVenta : IDisposable
    {
        public void Dispose()
        {

        }

        static IMongoCollection<Venta> collection = conexion.getDataBase().GetCollection<Venta>("SECIV_ventas");

        public void InsertarVenta(Venta c)
        {
            collection.InsertOne(c);
        }
        public List<Venta> ListarVentas()
        {
            return collection.AsQueryable().ToList<Venta>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarVenta(Venta c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarVenta(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
}
