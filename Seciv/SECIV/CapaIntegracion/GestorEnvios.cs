using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorEnvios: IDisposable
    {

        public void Dispose()
        {

        }

        public void Insertarenvio(string id, string codigo, Double numeroGuia, string nomCliente, string pApellCliente, string codPostal, string provincia, string canton,
            string distrito, string direccion, string telefonoContacto, string correoContacto)
        {
            Envio nuevoEnvio = new Envio(codigo, numeroGuia, nomCliente, pApellCliente, codPostal, provincia, canton, distrito, direccion, telefonoContacto, correoContacto);

            using (ServicioEnvio laEnvios = new ServicioEnvio())
                laEnvios.InsertarEnvios(nuevoEnvio);
        }

        public List<Envio> ListarEnvios()
        {
            using (ServicioEnvio elEnvio = new ServicioEnvio())
            {
                return elEnvio.ListarEnvios();
            }
        }

        public void ActualizarEnvios(string id, string codigo, Double numeroGuia, string nomCliente, string pApellCliente, string codPostal, string provincia, string canton,
            string distrito, string direccion, string telefonoContacto, string correoContacto)
        {
            Envio nuevoEnvio = new Envio(codigo, numeroGuia, nomCliente, pApellCliente, codPostal, provincia, canton, distrito, direccion, telefonoContacto, correoContacto);
            using (ServicioEnvio elEnvio = new ServicioEnvio())
                elEnvio.ActualizarEnvios(nuevoEnvio);
        }
        public void EliminarEnvio(string id)
        {
            using (ServicioEnvio elEnvio = new ServicioEnvio())
                elEnvio.EliminarEnvios(id);
        }
    }
}
