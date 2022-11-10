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
    public class ServicioDecoracion : IDisposable
    {
        public ServicioDecoracion()
        {

        }

        public void Dispose() { }

        static IMongoCollection<Decoracion> collection = conexion.getDataBase().GetCollection<Decoracion>("SECIV_decoraciones");

        public void InsertarDecoracion(Decoracion c)
        {
            collection.InsertOne(c);
        }
        public List<Decoracion> ListarDecoraciones()
        {
            return collection.AsQueryable().ToList<Decoracion>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarDecoracion(Decoracion c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarDecoracion(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
}
