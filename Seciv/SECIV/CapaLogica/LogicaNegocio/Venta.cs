using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Venta
    {
        public Venta(string id, string vent_codigo, Double vent_monto, string vent_fecha, string estado_Venta)
        {
            this.id = id;
            Vent_Codigo = vent_codigo;
            Vent_Monto = vent_monto;
            Vent_Fecha = vent_fecha;
            Vent_Estado = estado_Venta;
        }

        public Venta(string vent_codigo, Double vent_monto, string vent_fecha, string estado_Venta)
        {
            Vent_Codigo = vent_codigo;
            Vent_Monto = vent_monto;
            Vent_Fecha = vent_fecha;
            Vent_Estado = estado_Venta;
        }


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("Vent_Codigo")]
        public string Vent_Codigo { get; set; }

        [BsonElement("Vent_Monto")]
        public Double Vent_Monto { get; set; }

        [BsonElement("Vent_Fecha")]
        public string Vent_Fecha { get; set; }

        [BsonElement("Vent_Estado")]
        public string Vent_Estado { get; set; }
    }
}
