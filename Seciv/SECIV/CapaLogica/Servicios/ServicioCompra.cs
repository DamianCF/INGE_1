using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaConexion;
using CapaLogica.LogicaNegocio;
using MongoDB.Driver;

namespace CapaLogica.Servicios
{
    public class ServicioCompra : IDisposable
    {
        public ServicioCompra() 
        {

        }

        public void Dispose() {}
         
        static IMongoCollection<Compra> collection = conexion.getDataBase().GetCollection<Compra>("Compras");

        public void InsertarCompra(Compra c)
        {
            collection.InsertOne(c);
        }
        public List<Compra> ListarCompras()
        {
            return collection.AsQueryable().ToList<Compra>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarCompra(Compra c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarCompra(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
            
        
    
}
