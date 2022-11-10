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
    public class ServicioApartado : IDisposable
    {

        public ServicioApartado()
        {

        }

        public void Dispose() { }

        static IMongoCollection<Apartado> collection = conexion.getDataBase().GetCollection<Apartado>("SECIV_apartados");

        public void InsertarApartados(Apartado c)
        {
            collection.InsertOne(c);
        }
        public List<Apartado> ListarApartados()
        {
            return collection.AsQueryable().ToList<Apartado>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarApartados(Apartado c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarApartados(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
}
