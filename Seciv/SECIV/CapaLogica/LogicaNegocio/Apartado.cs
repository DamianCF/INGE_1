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

        public Apartado(string id, string apa_codigo, string apa_nomCliente, string apa_productos, string apa_fecha, string apa_fechaLimite, string apa_abonos, string apa_saldos, string apa_estado)
        {
            this.id = id;
            apa_Codigo = apa_codigo;
            apa_NomCliente = apa_nomCliente;
            apa_Productos = apa_productos;
            apa_Fecha = apa_fecha;
            apa_FechaLimite = apa_fechaLimite;
            apa_Abonos = apa_abonos;
            apa_Saldos = apa_saldos;
            apa_Estado = apa_estado;

        }

        public Apartado(string apa_codigo, string apa_nomCliente, string apa_productos, string apa_fecha, string apa_fechaLimite, string apa_abonos, string apa_saldos, string apa_estado)
        {
            apa_Codigo = apa_codigo;
            apa_NomCliente = apa_nomCliente;
            apa_Productos = apa_productos;
            apa_Fecha = apa_fecha;
            apa_FechaLimite = apa_fechaLimite;
            apa_Abonos = apa_abonos;
            apa_Saldos = apa_saldos;
            apa_Estado = apa_estado;

        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("apa_Codigo")]
        public string apa_Codigo { get; set; }

        [BsonElement("apa_NomCliente")]
        public string apa_NomCliente { get; set; }

        [BsonElement("apa_Productos")]
        public string apa_Productos { get; set; }

        [BsonElement("apa_Fecha")]
        public string apa_Fecha { get; set; }

        [BsonElement("apa_FechaLimite")]
        public string apa_FechaLimite { get; set; }

        [BsonElement("apa_Abonos")]
        public string apa_Abonos { get; set; }

        [BsonElement("apa_Saldos")]
        public string apa_Saldos { get; set; }

        [BsonElement("apa_Estado")]
        public string apa_Estado { get; set; }
    }
}
