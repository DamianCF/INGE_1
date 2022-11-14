using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel;

namespace CapaLogica.LogicaNegocio
{
    public class Compra
    {

        #region CONSTRUCTORES
        public Compra()
        {

        }

        public Compra(string id, string com_codigo, double com_monto, string com_fecha, string idFact, string com_estado)
        {
            this.id = id;
            this.com_codigo = com_codigo;
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
            this.com_estado = com_estado;
            this.com_idFactCompra = idFact;
        }

        public Compra(string com_codigo, double com_monto, string com_fecha, string idFact, string com_estado)
        {
            this.com_codigo = com_codigo;
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
            this.com_estado = com_estado;
            this.com_idFactCompra = idFact;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("com_codigo")]
        [DisplayName("Código")]
        public string com_codigo { get; set; }

        [BsonElement("com_monto")]
        [DisplayName("Monto")]
        public Double com_monto { get; set; }

        [BsonElement("com_fecha")]
        [DisplayName("Fecha")]
        public string com_fecha { get; set; }

        [BsonElement("com_idFactCompra")]
        [DisplayName("idFactCompra")]
        public string com_idFactCompra { get; set; }

        [BsonElement("com_estado")]
        [DisplayName("Estado")]
        public string com_estado { get; set; }

        #endregion

    }
}
