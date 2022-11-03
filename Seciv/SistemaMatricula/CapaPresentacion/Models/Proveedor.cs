using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CapaPresentacion.Models
{
    public class Proveedor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("Nombre_Proveedor")]
        public string Nombre_Proveedor { get; set; }

        [BsonElement("Cedula_Proveedor")]
        public int Cedula_Proveedor { get; set; }

        [BsonElement("Correo_Proveedor")]
        public string Correo_Proveedor { get; set; }

        [BsonElement("Telefono_Proveedor")]
        public string Telefono_Proveedor { get; set; }

        [BsonElement("Direccion_Proveedor")]
        public string Direccion_Proveedor { get; set; }

    }
}
