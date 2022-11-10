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

        #region CONSTRUCTORES

        public Venta()
        {

        }

        public Venta(string id, string vent_codigo, Double vent_monto, string vent_fecha, string estado_Venta)
        {
            this.id = id;
            this.vent_codigo = vent_codigo;
            this.vent_monto = vent_monto;
            this.vent_fecha = vent_fecha;
            this.vent_estado = estado_Venta;
        }

        public Venta(string vent_codigo, Double vent_monto, string vent_fecha, string estado_Venta)
        {
            this.vent_codigo = vent_codigo;
            this.vent_monto = vent_monto;
            this.vent_fecha = vent_fecha;
            this.vent_estado = estado_Venta;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("vent_codigo")]
        public string vent_codigo { get; set; }

        [BsonElement("vent_monto")]
        public Double vent_monto { get; set; }

        [BsonElement("vent_fecha")]
        public string vent_fecha { get; set; }

        [BsonElement("vent_estado")]
        public string vent_estado { get; set; }

        #endregion
    }
}
