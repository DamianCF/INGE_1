using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public Venta(string id, string vent_codigo, Double vent_monto, string vent_fecha, string vent_estado, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_total, Double vent_subTotal)
        {
            this.id = id;
            this.vent_codigo = vent_codigo;
            this.vent_monto = vent_monto;
            this.vent_fecha = vent_fecha;
            this.vent_estado = vent_estado;
            this.vent_nombreComprador = vent_nombreComprador;
            this.vent_productos = vent_productos;
            this.vent_detalle = vent_detalle;
            this.vent_metodoPago = vent_metodoPago;
            this.vent_descuento = vent_descuento;
            this.vent_impuesto = vent_impuesto;
            this.vent_total = vent_total;
            this.vent_subTotal = vent_subTotal;
        }

        public Venta(string vent_codigo, Double vent_monto, string vent_fecha, string vent_estado, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_total, Double vent_subTotal)
        {
            this.vent_codigo = vent_codigo;
            this.vent_monto = vent_monto;
            this.vent_fecha = vent_fecha;
            this.vent_estado = vent_estado;
            this.vent_nombreComprador = vent_nombreComprador;
            this.vent_productos = vent_productos;
            this.vent_detalle = vent_detalle;
            this.vent_metodoPago = vent_metodoPago;
            this.vent_descuento = vent_descuento;
            this.vent_impuesto = vent_impuesto;
            this.vent_total = vent_total;
            this.vent_subTotal = vent_subTotal;
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

        [BsonElement("vent_nombreComprador")]
        public string vent_nombreComprador { get; set; }

        [BsonElement("vent_productos")]
        public string vent_productos { get; set; }

        [BsonElement("vent_detalle")]
        public string vent_detalle { get; set; }

        [BsonElement("vent_metodoPago")]
        public string vent_metodoPago { get; set; }

        [BsonElement("vent_descuento")]
        public Double vent_descuento { get; set; }

        [BsonElement("vent_impuesto")]
        public Double vent_impuesto { get; set; }

        [BsonElement("vent_total")]
        public Double vent_total { get; set; }

        [BsonElement("vent_subTotal")]
        public Double vent_subTotal { get; set; }

        #endregion
    }
}
