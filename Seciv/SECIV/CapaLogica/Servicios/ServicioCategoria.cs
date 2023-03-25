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
    public class ServicioCategoria : IDisposable
    {
        public void Dispose()
        {
        }
        public ServicioCategoria() { }

        static IMongoCollection<Categoria> collection = conexion.getDataBase().GetCollection<Categoria>("SECIV_categorias");

        public IMongoCollection<Categoria>  getCollectionCategoria(){
            return collection;
        }

        public void InsertarCategoria(Categoria c)
        {
            collection.InsertOne(c);
        }
        public List<Categoria> ListarCategorias()
        {
            return collection.AsQueryable().ToList<Categoria>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarCategoria(Categoria c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarCategoria(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
}
