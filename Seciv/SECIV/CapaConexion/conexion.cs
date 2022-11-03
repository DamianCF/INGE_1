
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CapaConexion
{
    public class conexion
    {
        public conexion()
        {
        }
        public static IMongoDatabase getDataBase()
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            var client = new MongoClient("mongodb+srv://sys:sys@inge01.actyoaw.mongodb.net/SECIV?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("SECIV");
            return database;
        }

    }
}
