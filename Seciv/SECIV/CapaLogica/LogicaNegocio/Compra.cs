using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CapaLogica.LogicaNegocio
{
    public class Compra
    {
        public Compra(string id, string cod_Compra, float monto_Compra, string fecha_Compra)
        {
            this.id = id;
            Cod_Compra = cod_Compra;
            Monto_Compra = monto_Compra;
            Fecha_Compra = fecha_Compra;
        }

        public Compra(string cod_Compra, float monto_Compra, string fecha_Compra)
        {
            Cod_Compra = cod_Compra;
            Monto_Compra = monto_Compra;
            Fecha_Compra = fecha_Compra;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("Cod_Compra")]
        public string Cod_Compra { get; set; }

        [BsonElement("Monto_Compra")]
        public float Monto_Compra { get; set; }

        [BsonElement("Fecha_Compra")]
        public string Fecha_Compra { get; set; }
    }
}
