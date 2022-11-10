using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class CierreCaja
    {
        public CierreCaja(Double cc_cierreCompras, Double cc_cierreVentas, Double cc_saldoFinal, string cc_estado, string cc_fehca)
        {
            this.id = id;
            CierreCompras = cc_cierreCompras;
            CierreVentas = cc_cierreVentas;
            SaldoFinal = cc_saldoFinal;
            Estado = cc_estado;
            Fecha = cc_fehca;

        }

        public CierreCaja(string id, Double cc_cierreCompras, Double cc_cierreVentas, Double cc_saldoFinal, string cc_estado, string cc_fehca)
        {
            CierreCompras = cc_cierreCompras;
            CierreVentas = cc_cierreVentas;
            SaldoFinal = cc_saldoFinal;
            Estado = cc_estado;
            Fecha = cc_fehca;

        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("CierreCompras")]
        public Double CierreCompras { get; set; }

        [BsonElement("CierreVentas")]
        public Double CierreVentas { get; set; }

        [BsonElement("SaldoFinal")]
        public Double SaldoFinal { get; set; }

        [BsonElement("Estado")]
        public string Estado { get; set; }

        [BsonElement("Fecha")]
        public string Fecha { get; set; }
    }
}
