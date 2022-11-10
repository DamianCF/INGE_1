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

        #region COSNTRUCTORES

        public CierreCaja()
        {

        }

        public CierreCaja(Double cc_compras, Double cc_ventas, Double cc_saldoFinal, string cc_estado, string cc_fehca)
        {
            this.id = id;
            this.cc_compras = cc_compras;
            this.cc_ventas = cc_ventas;
            this.cc_saldoFinal = cc_saldoFinal;
            this.cc_fecha = cc_fehca;
            this.cc_estado = cc_estado;
        }

        public CierreCaja(string id, Double cc_compras, Double cc_ventas, Double cc_saldoFinal, string cc_estado, string cc_fehca)
        {
            this.cc_compras = cc_compras;
            this.cc_ventas = cc_ventas;
            this.cc_saldoFinal = cc_saldoFinal;
            this.cc_fecha = cc_fehca;
            this.cc_estado = cc_estado;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("cc_compras")]
        public Double cc_compras { get; set; }

        [BsonElement("cc_ventas")]
        public Double cc_ventas { get; set; }

        [BsonElement("cc_saldoFinal")]
        public Double cc_saldoFinal { get; set; }

        [BsonElement("cc_fecha")]
        public string cc_fecha { get; set; }
        
        [BsonElement("cc_estado")]
        public string cc_estado { get; set; }

        #endregion

    }
}
