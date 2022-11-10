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
    public class ServicioFacturaVenta : IDisposable
    {
        public ServicioFacturaVenta()
        {

        }

        public void Dispose()
        {

        }

        static IMongoCollection<FacturaVenta> collection = conexion.getDataBase().GetCollection<FacturaVenta>("SECIV_facturasVentas");

        public void InsertarFacturaVenta(FacturaVenta c)
        {
            collection.InsertOne(c);
        }
        public List<FacturaVenta> ListarFacturaVenta()
        {
            return collection.AsQueryable().ToList<FacturaVenta>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarFacturaVenta(FacturaVenta c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarFacturaVenta(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }

    }
}