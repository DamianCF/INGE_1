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
    public class ServicioEnvio : IDisposable
    {

        public ServicioEnvio()
        {

        }

        public void Dispose()
        {

        }

        static IMongoCollection<Envio> collection = conexion.getDataBase().GetCollection<Envio>("SECIV_envios");

        public void InsertarEnvio(Envio c)
        {
            collection.InsertOne(c);
        }
        public List<Envio> ListarEnvios()
        {
            return collection.AsQueryable().ToList<Envio>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarEnvio(Envio c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarEnvio(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
}
