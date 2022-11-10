using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class FacturaCompra
    {

        #region CONSTRUCTORES
        public FacturaCompra()
        {

        }

        public FacturaCompra(string id, string fc_codigo, string fc_nomProveedor, string fc_fecCompra, string fc_detalle, string fc_metodoPago)
        {
            this.id = id;
            this.fc_codigo = fc_codigo;
            this.fc_nomProveedor = fc_nomProveedor;
            this.fc_fecCompra = fc_fecCompra;
            this.fc_detalle = fc_detalle;
            this.fc_metodoPago = fc_metodoPago;
        }

        public FacturaCompra(string fc_codigo, string fc_nomProveedor, string fc_fecCompra, string fc_detalle, string fc_metodoPago)
        {
            this.fc_codigo = fc_codigo;
            this.fc_nomProveedor = fc_nomProveedor;
            this.fc_fecCompra = fc_fecCompra;
            this.fc_detalle = fc_detalle;
            this.fc_metodoPago = fc_metodoPago;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("fc_codigo")]
        public string fc_codigo { get; set; }

        [BsonElement("fc_nomProveedor")]
        public string fc_nomProveedor { get; set; }

        [BsonElement("fc_fecCompra")]
        public string fc_fecCompra { get; set; }

        //[BsonElement("fc_Productos")]
        //public string fc_Productos { get; set; }

        [BsonElement("fc_detalle")]
        public string fc_detalle { get; set; }

        [BsonElement("fc_metodoPago")]
        public string fc_metodoPago { get; set; }

        #endregion
    }
}