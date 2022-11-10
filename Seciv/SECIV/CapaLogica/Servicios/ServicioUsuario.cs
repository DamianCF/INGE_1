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
    public class ServicioUsuario : IDisposable
    {
        public ServicioUsuario()
        {

        }

        public void Dispose() { }

        static IMongoCollection<Usuario> collection = conexion.getDataBase().GetCollection<Usuario>("Usuarios");

        public void InsertarUsuario(Usuario u)
        {
            collection.InsertOne(u);
        }
        public List<Usuario> ListarUsuarios()
        {
            return collection.AsQueryable().ToList<Usuario>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarUsuario(Usuario u)
        {
            collection.ReplaceOne(x => x.id == u.id, u);
        }
        public void EliminarUsuario(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }

    }
}
