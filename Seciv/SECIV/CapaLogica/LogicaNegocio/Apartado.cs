using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Apartado
    {

        #region CONSTRUCTORES

        public Apartado()
        {

        }

        public Apartado(string id, string apa_codigo, string apa_nomCliente, string apa_productos, string apa_fecha, string apa_fechaLimite,
            string apa_abonos, string apa_saldos, string apa_estado)
        {
            this.id = id;
            this.apa_codigo = apa_codigo;
            this.apa_nomCliente = apa_nomCliente;
            this.apa_productos = apa_productos;
            this.apa_fecha = apa_fecha;
            this.apa_fechaLimite = apa_fechaLimite;
            this.apa_abonos = apa_abonos;
            this.apa_saldos = apa_saldos;
            this.apa_estado = apa_estado;

        }

        public Apartado(string apa_codigo, string apa_nomCliente, string apa_productos, string apa_fecha, string apa_fechaLimite,
           string apa_abonos, string apa_saldos, string apa_estado)
        {
            this.apa_codigo = apa_codigo;
            this.apa_nomCliente = apa_nomCliente;
            this.apa_productos = apa_productos;
            this.apa_fecha = apa_fecha;
            this.apa_fechaLimite = apa_fechaLimite;
            this.apa_abonos = apa_abonos;
            this.apa_saldos = apa_saldos;
            this.apa_estado = apa_estado;

        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("apa_codigo")]
        public string apa_codigo { get; set; }

        [BsonElement("apa_nomCliente")]
        public string apa_nomCliente { get; set; }

        [BsonElement("apa_productos")]
        public string apa_productos { get; set; }

        [BsonElement("apa_fecha")]
        public string apa_fecha { get; set; }

        [BsonElement("apa_fechaLimite")]
        public string apa_fechaLimite { get; set; }

        [BsonElement("apa_abonos")]
        public string apa_abonos { get; set; }

        [BsonElement("apa_saldos")]
        public string apa_saldos { get; set; }

        [BsonElement("apa_estado")]
        public string apa_estado { get; set; }

        #endregion

    }
}
