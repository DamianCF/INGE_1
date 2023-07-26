﻿using CapaConexion;
using CapaLogica.LogicaNegocio;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicios
{
    public class ServicioVenta : IDisposable
    {
        public void Dispose()
        {

        }

        static IMongoCollection<Venta> collection = conexion.getDataBase().GetCollection<Venta>("SECIV_venta");


        public IMongoCollection<Venta> getCollectionVentas()
        {
            return collection;
        }

        public bool InsertarVenta(Venta c)
        {
            try
            {
                collection.InsertOne(c);
            }
            catch (MongoWriteConcernException e)
            {
                return false;
                Console.WriteLine(e.Message);
            }
            return true;
        }


        public List<Venta> ListarVentas()
        {
            return collection.AsQueryable().ToList<Venta>(); // collection.Find(x => true).ToList(); 
        }
        public List<Venta> ListarVentasRangoFechas(string fechaIni, string fechaFin)
        {
            var filter = Builders<Venta>.Filter.And(
                Builders<Venta>.Filter.Gte(c => c.vent_fecha, fechaIni),
                Builders<Venta>.Filter.Lte(c => c.vent_fecha, fechaFin));
            return collection.Find(filter).ToList<Venta>();
        }
        public void ActualizarVenta(Venta c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarVenta(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }
    }
}
