﻿using System;
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

        #region CONSTRUCTORES
        public Compra()
        {

        }

        public Compra(string id, string com_codigo, double com_monto, string com_fecha, string com_estado)
        {
            this.id = id;
            this.com_codigo = com_codigo;
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
            this.com_estado = com_estado;
        }

        public Compra(string com_codigo, double com_monto, string com_fecha, string com_estado)
        {
            this.com_codigo = com_codigo;
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
            this.com_estado = com_estado;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("com_codigo")]
        public string com_codigo { get; set; }

        [BsonElement("com_monto")]
        public Double com_monto { get; set; }

        [BsonElement("com_fecha")]
        public string com_fecha { get; set; }

        [BsonElement("com_estado")]
        public string com_estado { get; set; }

        #endregion

    }
}
