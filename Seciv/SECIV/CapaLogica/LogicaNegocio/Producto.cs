using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CapaLogica.LogicaNegocio
{
    public class Producto
    {
        #region CONSTRUCTORES

        public Producto()
        {

        }
        public Producto(string id, string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, double prd_utilidad,
            double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
        {
            this.id = id;
            this.prd_codigo = prd_codigo;
            this.prd_nombre = prd_nombre;
            this.prd_descripcion = prd_descripcion;
            this.prd_precioCosto = prd_precioCosto;
            this.prd_utilidad = prd_utilidad;
            this.prd_precioVenta = prd_precioVenta;
            this.prd_porcIVA = prd_porcIVA;
            this.prd_cantStock = prd_cantStock;
            this.prd_idCategoria = prd_idCategoria;
            this.prd_idDecoracion = prd_idDecoracion;
        }

        public Producto(string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, double prd_utilidad,
            double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
        {
            this.prd_codigo = prd_codigo;
            this.prd_nombre = prd_nombre;
            this.prd_descripcion = prd_descripcion;
            this.prd_precioCosto = prd_precioCosto;
            this.prd_utilidad = prd_utilidad;
            this.prd_precioVenta = prd_precioVenta;
            this.prd_porcIVA = prd_porcIVA;
            this.prd_cantStock = prd_cantStock;
            this.prd_idCategoria = prd_idCategoria;
            this.prd_idDecoracion = prd_idDecoracion;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("prd_codigo")]
        [DisplayName("Código")]
        public string prd_codigo { get; set; }

        [BsonElement("prd_nombre")]
        [DisplayName("Nombre")]
        public string prd_nombre { get; set; }

        [BsonElement("prd_descripcion")]
        [DisplayName("Descripcion")]
        public string prd_descripcion { get; set; }

        [BsonElement("prd_precioCosto")]
        [DisplayName("PrecioCosto")]
        public double prd_precioCosto { get; set; }

        [BsonElement("prd_utilidad")]
        [DisplayName("Utilidad")]
        public double prd_utilidad { get; set; }

        [BsonElement("prd_precioVenta")]
        [DisplayName("PrecioVenta")]
        public double prd_precioVenta { get; set; }

        [BsonElement("prd_porcIVA")]
        [DisplayName("PorcIVA")]
        public double prd_porcIVA { get; set; }

        [BsonElement("prd_cantStock")]
        [DisplayName("Cantidad")]
        public int prd_cantStock { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("prd_idCategoria")]
        [DisplayName("Categoria")]
        public string prd_idCategoria { get; set; }

        //[BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("prd_idDecoracion")]
        public string prd_idDecoracion { get; set; }

        #endregion
    }
}
