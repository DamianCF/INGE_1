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
    public class ServicioFacturaCompra : IDisposable
    {
        public ServicioFacturaCompra()
        {

        }

        public void Dispose() { }

        static IMongoCollection<FacturaCompra> collection = conexion.getDataBase().GetCollection<FacturaCompra>("SECIV_facturasCompras");

        public void InsertarFacturaCompra(FacturaCompra c)
        {
            collection.InsertOne(c);
        }
        public List<FacturaCompra> ListarFacturaCompras()
        {
            return collection.AsQueryable().ToList<FacturaCompra>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarFacturaCompra(FacturaCompra c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarFacturaCompra(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }

    }
}