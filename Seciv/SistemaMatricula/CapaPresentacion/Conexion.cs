using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using CapaPresentacion.Models;

namespace CapaPresentacion
{
    public class Conexion
    {
        public Conexion()
        {
        }
        public IMongoDatabase getDataBase()
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            var client = new MongoClient("mongodb+srv://sys:sys@inge01.actyoaw.mongodb.net/SECIV?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("SECIV");
            return database;
        }

        public IMongoCollection<Compra> getCompras()
        {
            var categoriasDB = getDataBase().GetCollection<Compra>("Compras");
            return categoriasDB;
        }

    }
}
