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
        public Envio(string id, string env_Codigo, Double env_NumeroGuia, string env_nomCliente, string env_pApellCliente, string env_CodPostal, string env_Provincia, string env_Canton,
            string env_Distrito, string env_Direccion, string env_TelefonoContacto, string env_CorreoContacto)
        {
            this.id = id;
            Env_Codigo = env_Codigo;
            Env_NumeroGuia = env_NumeroGuia;
            Env_nomCliente = env_nomCliente;
            Env_pApellCliente = env_pApellCliente;
            Env_CodPostal = env_CodPostal;
            Env_Provincia = env_Provincia;
            Env_Canton = env_Canton;
            Env_Distrito = env_Distrito;
            Env_Direccion = env_Direccion;
            Env_TelefonoContacto = env_TelefonoContacto;
            Env_CorreoContacto = env_CorreoContacto;
        }

        public Envio(string env_Codigo, Double env_NumeroGuia, string env_nomCliente, string env_pApellCliente, string env_CodPostal, string env_Provincia, string env_Canton,
            string env_Distrito, string env_Direccion, string env_TelefonoContacto, string env_CorreoContacto)
        {
            Env_Codigo = env_Codigo;
            Env_NumeroGuia = env_NumeroGuia;
            Env_nomCliente = env_nomCliente;
            Env_pApellCliente = env_pApellCliente;
            Env_CodPostal = env_CodPostal;
            Env_Provincia = env_Provincia;
            Env_Canton = env_Canton;
            Env_Distrito = env_Distrito;
            Env_Direccion = env_Direccion;
            Env_TelefonoContacto = env_TelefonoContacto;
            Env_CorreoContacto = env_CorreoContacto;
        }



        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }

        [BsonElement("Env_Codigo")]
        public string Env_Codigo { get; set; }

        [BsonElement("Env_NumeroGuia")]
        public Double Env_NumeroGuia { get; set; }

        [BsonElement("Env_NomCliente")]
        public string Env_nomCliente { get; set; }

        [BsonElement("Env_pApellCliente")]
        public string Env_pApellCliente { get; set; }

        [BsonElement("Env_CodPostal")]
        public string Env_CodPostal { get; set; }

        [BsonElement("Env_Provincia")]
        public string Env_Provincia { get; set; }

        [BsonElement("Env_Canton")]
        public string Env_Canton { get; set; }

        [BsonElement("Env_Distrito")]
        public string Env_Distrito { get; set; }

        [BsonElement("Env_Direccion")]
        public string Env_Direccion { get; set; }

        [BsonElement("Env_TelefonoContacto")]
        public string Env_TelefonoContacto { get; set; }

        [BsonElement("Env_CorreoContacto")]
        public string Env_CorreoContacto { get; set; }

    }
}
