using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CapaPresentacion.Models
{
    public class Compra
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("Cod_Compra")]
        public string Cod_Compra { get; set; }

        [BsonElement("Monto_Compra")]
        public float Monto_Compra { get; set; }

        [BsonElement("Fecha_Compra")]
        public string Fecha_Compra { get; set; }

        // factura
    }
}
