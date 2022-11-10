using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class FacturaVenta
    {
        public FacturaVenta(string id, string fv_codigo, string fv_nomComprador, string fv_fecVenta, string fv_productos, string fv_detalle, string fv_metodoPago)
        {
            this.id = id;
            this.fv_codigo = fv_codigo;
            this.fv_nomComprador = fv_nomComprador;
            this.fv_fecVenta = fv_fecVenta;
            this.fv_productos = fv_productos;
            this.fv_detalle = fv_detalle;
            this.fv_metodoPago = fv_metodoPago;
        }

        public FacturaVenta(string fv_codigo, string fv_nomComprador, string fv_fecVenta, string fv_productos, string fv_detalle, string fv_metodoPago)
        {
            this.fv_codigo = fv_codigo;
            this.fv_nomComprador = fv_nomComprador;
            this.fv_fecVenta = fv_fecVenta;
            this.fv_productos = fv_productos;
            this.fv_detalle = fv_detalle;
            this.fv_metodoPago = fv_metodoPago;
        }


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("fv_codigo")]
        public string fv_codigo { get; set; }

        [BsonElement("fv_nomComprador")]
        public string fv_nomComprador { get; set; }

        [BsonElement("fv_fecVenta")]
        public string fv_fecVenta { get; set; }

        [BsonElement("fv_productos")]
        public string fv_productos { get; set; }

        [BsonElement("fv_detalle")]
        public string fv_detalle { get; set; }

        [BsonElement("fv_metodoPago")]
        public string fv_metodoPago { get; set; }


    }
}