using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SECIV
{
    internal class Compra
    {
        [BsonId]
        public ObjectId Id { get; set; }
        
        [BsonElement("Cod_Compra")]
        public String com_codigo { get; set; }        
        
        [BsonElement("Monto_Compra")]
        public Double com_monto { get; set; }

        [BsonElement("Fecha_Compra")]
        public String com_fecha { get; set; }

        public Compra(string com_codigo, double com_monto, String com_fecha)
        {
            this.com_codigo = com_codigo;
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
        }
    }
}
