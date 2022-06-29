using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace CapaPresentacion.Models
{
    public class Categoria
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("cod_Categoria")]
        public string cod_Categoria { get; set; }

        [BsonElement("nombre_Categoria")]
        public string nombre_Categoria { get; set; }

        [BsonElement("descripcion_Categoria")]
        public string descripcion_Categoria { get; set; }


    }
}
