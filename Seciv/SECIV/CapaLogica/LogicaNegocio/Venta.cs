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

        public Venta(string id, int vent_codigo, string vent_fecha, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_subTotal, Double vent_total, string vent_estado)
        {
            this.id = id;
            this.vent_codigo = vent_codigo;
            this.vent_fecha = vent_fecha;
            this.vent_nombreComprador = vent_nombreComprador;
            this.vent_productos = vent_productos;
            this.vent_detalle = vent_detalle;
            this.vent_metodoPago = vent_metodoPago;
            this.vent_descuento = vent_descuento;
            this.vent_impuesto = vent_impuesto;
            this.vent_subTotal = vent_subTotal;
            this.vent_total = vent_total;
            this.vent_estado = vent_estado;
        }

        public Venta(string vent_fecha, string vent_nombreComprador, string vent_productos, string vent_detalle,
            string vent_metodoPago, Double vent_descuento, Double vent_impuesto, Double vent_subTotal, Double vent_total, string vent_estado)
        { 
            this.vent_fecha = vent_fecha;
            this.vent_nombreComprador = vent_nombreComprador;
            this.vent_productos = vent_productos;
            this.vent_detalle = vent_detalle;
            this.vent_metodoPago = vent_metodoPago;
            this.vent_descuento = vent_descuento;
            this.vent_impuesto = vent_impuesto;
            this.vent_subTotal = vent_subTotal;
            this.vent_total = vent_total;
            this.vent_estado = vent_estado;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("vent_codigo")]
        [DisplayName("Código")]
        public int vent_codigo { get; set; }


        [BsonElement("vent_fecha")]
        [DisplayName("Fecha")]
        public string vent_fecha { get; set; }

        [BsonElement("vent_nombreComprador")]
        [DisplayName("Cliente")]
        public string vent_nombreComprador { get; set; }

        [BsonElement("vent_productos")]
        [DisplayName("Productos")]
        public string vent_productos { get; set; }

        [BsonElement("vent_detalle")]
        [DisplayName("Detalle")]
        public string vent_detalle { get; set; }

        [BsonElement("vent_metodoPago")]
        [DisplayName("Método de pago")]
        public string vent_metodoPago { get; set; }

        [BsonElement("vent_descuento")]
        [DisplayName("Descuento")]
        public Double vent_descuento { get; set; }

        [BsonElement("vent_impuesto")]
        [DisplayName("Impuesto")]
        public Double vent_impuesto { get; set; }

        [BsonElement("vent_subTotal")]
        [DisplayName("Subtotal")]
        public Double vent_subTotal { get; set; }

        [BsonElement("vent_total")]
        [DisplayName("Total")]
        public Double vent_total { get; set; }

        [BsonElement("vent_estado")]
        [DisplayName("Estado")]
        public string vent_estado { get; set; }

        #endregion
    }
}
