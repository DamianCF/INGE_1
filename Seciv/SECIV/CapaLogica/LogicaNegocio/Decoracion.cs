using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Decoracion
    {

        public Decoracion()
        {

        }

        public Decoracion(string id, string dec_descripcion, double dec_monto, string dec_estado)
        {
            this.id = id;
            this.dec_descripcion = dec_descripcion;
            this.dec_monto = dec_monto;
            this.dec_estado = dec_estado;
        }

        public Decoracion( string dec_descripcion, double dec_monto, string dec_estado)
        {
            this.dec_descripcion = dec_descripcion;
            this.dec_monto = dec_monto;
            this.dec_estado = dec_estado;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("dec_descripcion")]
        public string dec_descripcion { get; set; }

        [BsonElement("dec_monto")]
        public double dec_monto { get; set; }

        [BsonElement("dec_estado")]
        public string dec_estado { get; set; }

    }
}
