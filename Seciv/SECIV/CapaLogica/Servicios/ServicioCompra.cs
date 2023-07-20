using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void Dispose() { }

        static IMongoCollection<Compra> collection = conexion.getDataBase().GetCollection<Compra>("SECIV_compras");

        public IMongoCollection<Compra> getCollectionCompras()
        {
            return collection;
        }

        public void InsertarCompra(Compra c)
        {
            collection.InsertOne(c);
        }
        public List<Compra> ListarCompras()
        {
            return collection.AsQueryable().ToList<Compra>(); // collection.Find(x => true).ToList(); 
        }
        public List<Compra> ListarComprasEntreFechas(string fechaIni, string fechaFin)
        {
            // version funcional con MongoDB pero la base de datos no filtra bien por el formato al no ser IsoDate
            var filter = Builders<Compra>.Filter.And(
                Builders<Compra>.Filter.Gte(c => c.com_fecha, fechaIni),
                Builders<Compra>.Filter.Lte(c => c.com_fecha, fechaFin));
            return collection.Find(filter).ToList<Compra>();
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
