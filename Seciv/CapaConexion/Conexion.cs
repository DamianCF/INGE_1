using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaConexion
{
    public class Conexion
    {
        /// <summary>
        ///  Encargado de la conexion a la base de datos
        /// </summary>

        public IMongoDatabase GetDataBase()
        {
            //var client = new MongoClient("mongodb://localhost:27017");
            var client = new MongoClient("mongodb+srv://sys:sys@inge01.actyoaw.mongodb.net/SECIV?retryWrites=true&w=majority");
            IMongoDatabase database = client.GetDatabase("SECIV");
            return database;
        }

    }

}
