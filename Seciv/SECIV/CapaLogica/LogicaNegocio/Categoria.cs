using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Categoria
    {
        #region CONSTRUCTORES
        public Categoria()
        {

        }

        public Categoria(string id, string cat_nombre, string cat_descripcion, string cat_estado)
        {
            this.id = id;
            this.cat_nombre = cat_nombre;
            this.cat_descripcion = cat_descripcion;
            this.cat_estado = cat_estado;
        }

        public Categoria(string cat_nombre, string cat_descripcion, string cat_estado)
        {
            this.cat_nombre = cat_nombre;
            this.cat_descripcion = cat_descripcion;
            this.cat_estado = cat_estado;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("cat_nombre")]
        [DisplayName("Nombre")]
        public string cat_nombre { get; set; }

        [BsonElement("cat_descripcion")]
        [DisplayName("Descripcion")]
        public string cat_descripcion { get; set; }

        [BsonElement("cat_estado")]
        [DisplayName("Estado")]
        public string cat_estado { get; set; }

        #endregion

    }
}
