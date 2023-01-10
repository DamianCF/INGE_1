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
        
        public Compra(string id, int com_codigo, double com_monto, string com_fecha, string com_estado, string com_nombreProveedor, string com_productos, string com_detalle,
            string com_metodoPago, Double com_impuesto, Double com_total, Double com_subTotal)
        {
            this.id = id;
            this.com_codigo = com_codigo;
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
            this.com_estado = com_estado;
            this.com_nombreProveedor = com_nombreProveedor;
            this.com_productos = com_productos;
            this.com_detalle = com_detalle;
            this.com_metodoPago = com_metodoPago;
            this.com_impuesto = com_impuesto;
            this.com_total = com_total;
            this.com_subTotal = com_subTotal;
        }

        public Compra( double com_monto, string com_fecha, string com_estado, string com_nombreProveedor, string com_productos, string com_detalle,
            string com_metodoPago, Double com_impuesto, Double com_total, Double com_subTotal)
        {
            this.com_monto = com_monto;
            this.com_fecha = com_fecha;
            this.com_estado = com_estado;
            this.com_nombreProveedor = com_nombreProveedor;
            this.com_productos = com_productos;
            this.com_detalle = com_detalle;
            this.com_metodoPago = com_metodoPago;
            this.com_impuesto = com_impuesto;
            this.com_total = com_total;
            this.com_subTotal = com_subTotal;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("com_codigo")]
        [DisplayName("Código")]
        public int com_codigo { get; set; }

        [BsonElement("com_monto")]
        [DisplayName("Monto")]
        public Double com_monto { get; set; }

        [BsonElement("com_fecha")]
        [DisplayName("Fecha")]
        public string com_fecha { get; set; }

        [BsonElement("com_estado")]
        [DisplayName("Estado")]
        public string com_estado { get; set; }

        [BsonElement("com_nombreProveedor")]
        [DisplayName("Proveedor")]
        public string com_nombreProveedor { get; set; }

        [BsonElement("com_productos")]
        [DisplayName("Productos")]
        public string com_productos { get; set; }

        [BsonElement("com_detalle")]
        [DisplayName("Detalle")]
        public string com_detalle { get; set; }

        [BsonElement("com_metodoPago")]
        [DisplayName("MetodoPago")]
        public string com_metodoPago { get; set; }

        [BsonElement("com_impuesto")]
        [DisplayName("Impuesto")]
        public Double com_impuesto { get; set; }

        [BsonElement("com_total")]
        [DisplayName("Total")]
        public Double com_total { get; set; }

        [BsonElement("com_subTotal")]
        [DisplayName("SubTotal")]
        public Double com_subTotal { get; set; }




        #endregion

    }
}
