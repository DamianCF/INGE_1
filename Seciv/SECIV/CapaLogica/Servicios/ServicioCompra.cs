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
            var filter = Builders<Compra>.Filter.And(
                Builders<Compra>.Filter.Gte(c => c.com_fecha, fechaIni),
                Builders<Compra>.Filter.Lte(c => c.com_fecha, fechaFin));
            return collection.Find(filter).ToList<Compra>();

            // retornar una lista de compras entre dos fechas en formato string (dd/mm/yyyy) 
            //return collection.AsQueryable().Where(c => c.com_fecha >= fechaIni && c.com_fecha <= fechaFin).ToList<Compra>();

            //DateTime fechaInicio = DateTime.ParseExact(fechaIni, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //DateTime fechaFinal = DateTime.ParseExact(fechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //return collection.AsQueryable()
            //    .Where(c => DateTime.ParseExact(c.com_fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture) >= fechaInicio &&
            //                DateTime.ParseExact(c.com_fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture) <= fechaFinal)
            //    .ToList();

            //return collection.AsQueryable()
            //    .Where(c => DateTime.ParseExact(c.com_fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture) >= DateTime.ParseExact(fechaIni, "dd/MM/yyyy", CultureInfo.InvariantCulture) &&
            //                               DateTime.ParseExact(c.com_fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture) <= DateTime.ParseExact(fechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture))
            //    .ToList();

            //return collection.AsQueryable()
            //.Where(c =>
            //{
            //    DateTime fechaInicio;
            //    DateTime fechaFinal;
            //    if (DateTime.TryParseExact(fechaIni, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaInicio) &&
            //        DateTime.TryParseExact(fechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaFinal))
            //    {
            //        DateTime comFecha;
            //        if (DateTime.TryParseExact(c.com_fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out comFecha))
            //        {
            //            return comFecha >= fechaInicio && comFecha <= fechaFinal;
            //        }
            //    }
            //    return false;
            //})
            //.ToList();

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
