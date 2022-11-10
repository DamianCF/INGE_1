using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Envio
    {

        #region CONSTRUCTORES
        public Envio()
        {

        }

        public Envio(string id, string env_codigo, double env_numeroGuia, string env_nomCliente, string env_pApellCliente, string env_codPostal,
            string env_provincia, string env_canton, string env_distrito, string env_direccion, string env_telefonoContacto, string env_correoContacto)
        {
            this.id = id;
            this.env_codigo = env_codigo;
            this.env_numeroGuia = env_numeroGuia;
            this.env_nomCliente = env_nomCliente;
            this.env_pApellCliente = env_pApellCliente;
            this.env_codPostal = env_codPostal;
            this.env_provincia = env_provincia;
            this.env_canton = env_canton;
            this.env_distrito = env_distrito;
            this.env_direccion = env_direccion;
            this.env_telefonoContacto = env_telefonoContacto;
            this.env_correoContacto = env_correoContacto;
        }

        public Envio(string env_codigo, double env_numeroGuia, string env_nomCliente, string env_pApellCliente, string env_codPostal,
            string env_provincia, string env_canton, string env_distrito, string env_direccion, string env_telefonoContacto, string env_correoContacto)
        {
            this.env_codigo = env_codigo;
            this.env_numeroGuia = env_numeroGuia;
            this.env_nomCliente = env_nomCliente;
            this.env_pApellCliente = env_pApellCliente;
            this.env_codPostal = env_codPostal;
            this.env_provincia = env_provincia;
            this.env_canton = env_canton;
            this.env_distrito = env_distrito;
            this.env_direccion = env_direccion;
            this.env_telefonoContacto = env_telefonoContacto;
            this.env_correoContacto = env_correoContacto;
        }

        #endregion

        #region ATRIBUTOS

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("env_codigo")]
        public string env_codigo { get; set; }

        [BsonElement("env_numeroGuia")]
        public Double env_numeroGuia { get; set; }

        [BsonElement("env_nomCliente")]
        public string env_nomCliente { get; set; }

        [BsonElement("env_pApellCliente")]
        public string env_pApellCliente { get; set; }

        [BsonElement("env_codPostal")]
        public string env_codPostal { get; set; }

        [BsonElement("env_provincia")]
        public string env_provincia { get; set; }

        [BsonElement("env_canton")]
        public string env_canton { get; set; }

        [BsonElement("env_distrito")]
        public string env_distrito { get; set; }

        [BsonElement("env_direccion")]
        public string env_direccion { get; set; }

        [BsonElement("env_telefonoContacto")]
        public string env_telefonoContacto { get; set; }

        [BsonElement("env_correoContacto")]
        public string env_correoContacto { get; set; }

        #endregion

    }
}
