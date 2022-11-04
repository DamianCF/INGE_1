using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Usuario
    {
        #region CONSTRUCTORES

        public Usuario()
        {

        }

        public Usuario(string id, string usu_cedula, string usu_nombre, string usu_primerApellido, string usu_segundoApellido, string usu_correo, string usu_contrasena, string usu_estado)
        {
            this.id = id;
            this.usu_cedula = usu_cedula;
            this.usu_nombre = usu_nombre;
            this.usu_primerApellido = usu_primerApellido;
            this.usu_segundoApellido = usu_segundoApellido;
            this.usu_correo = usu_correo;
            this.usu_contrasena = usu_contrasena;
            this.usu_estado = usu_estado;
        }

        public Usuario( string usu_cedula, string usu_nombre, string usu_primerApellido, string usu_segundoApellido, string usu_correo, string usu_contrasena, string usu_estado)
        {
            this.usu_cedula = usu_cedula;
            this.usu_nombre = usu_nombre;
            this.usu_primerApellido = usu_primerApellido;
            this.usu_segundoApellido = usu_segundoApellido;
            this.usu_correo = usu_correo;
            this.usu_contrasena = usu_contrasena;
            this.usu_estado = usu_estado;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("usu_cedula")]
        public string usu_cedula { get; set; }

        [BsonElement("usu_nombre")]
        public string usu_nombre { get; set; }

        [BsonElement("usu_primerApellido")]
        public string usu_primerApellido { get; set; }

        [BsonElement("usu_segundoApellido")]
        public string usu_segundoApellido { get; set; }

        [BsonElement("usu_correo")]
        public string usu_correo { get; set; }

        [BsonElement("usu_contrasena")]
        public string usu_contrasena { get; set; }

        [BsonElement("usu_estado")]
        public string usu_estado { get; set; }

        #endregion
    }
}
