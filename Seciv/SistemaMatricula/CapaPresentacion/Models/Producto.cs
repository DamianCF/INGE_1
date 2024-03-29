﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace CapaPresentacion.Models
{
    public class Producto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("Codigo_Producto")]
        public string Codigo_Producto { get; set; }

        [BsonElement("Nombre_Producto")]
        public string Nombre_Producto { get; set; }

        [BsonElement("Descripcion_Producto")]
        public string Descripcion_Producto { get; set; }

        [BsonElement("Precio_Costo")]
        public double Precio_Costo { get; set; }

        [BsonElement("Utilidad")]
        public double Utilidad { get; set; }

        [BsonElement("Precio_Venta")]
        public double Precio_Venta { get; set; }

        [BsonElement("Porcentaje_IVA")]
        public double Porcentaje_IVA { get; set; }

        [BsonElement("Cantidad_Stock")]
        public int Cantidad_Stock { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string id_Categoria { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string id_Decoracion { get; set; }

        // categoria

    }
}