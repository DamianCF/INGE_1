using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Producto
    {
        #region CONSTRUCTORES

        public Producto()
        {

        }
        public Producto(string id, string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, decimal prd_utilidad, double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
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

        public Producto(string prd_codigo, string prd_nombre, string prd_descripcion, double prd_precioCosto, decimal prd_utilidad, double prd_precioVenta, double prd_porcIVA, int prd_cantStock, string prd_idCategoria, string prd_idDecoracion)
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
        public string prd_codigo { get; set; }

        [BsonElement("prd_nombre")]
        public string prd_nombre { get; set; }

        [BsonElement("prd_descripcion")]
        public string prd_descripcion { get; set; }

        [BsonElement("prd_precioCosto")]
        public double prd_precioCosto { get; set; }

        [BsonElement("prd_utilidad")]
        public decimal prd_utilidad { get; set; }

        [BsonElement("prd_precioVenta")]
        public double prd_precioVenta { get; set; }

        [BsonElement("prd_porcIVA")]
        public double prd_porcIVA { get; set; }

        [BsonElement("prd_cantStock")]
        public int prd_cantStock { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string prd_idCategoria { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string prd_idDecoracion { get; set; }

        #endregion
    }
}
