using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorEnvios : IDisposable
    {

        public void Dispose()
        {

        }

        public void Insertarenvio(string env_codigo, double env_numeroGuia, string env_nomCliente, string env_pApellCliente, string env_codPostal,
            string env_provincia, string env_canton, string env_distrito, string env_direccion, string env_telefonoContacto, string env_correoContacto)
        {
            Envio nuevoEnvio = new Envio(env_codigo, env_numeroGuia, env_nomCliente, env_pApellCliente, env_codPostal, env_provincia, env_canton, env_distrito, env_direccion, env_telefonoContacto, env_correoContacto);

            using (ServicioEnvio Envio = new ServicioEnvio())
                Envio.InsertarEnvios(nuevoEnvio);
        }

        public List<Envio> ListarEnvios()
        {
            using (ServicioEnvio Envio = new ServicioEnvio())
            {
                return Envio.ListarEnvios();
            }
        }

        public void ActualizarEnvios(string id, string env_codigo, double env_numeroGuia, string env_nomCliente, string env_pApellCliente, string env_codPostal,
            string env_provincia, string env_canton, string env_distrito, string env_direccion, string env_telefonoContacto, string env_correoContacto)
        {
            Envio ActEnvio = new Envio(id, env_codigo, env_numeroGuia, env_nomCliente, env_pApellCliente, env_codPostal, env_provincia, env_canton, env_distrito, env_direccion, env_telefonoContacto, env_correoContacto);
            using (ServicioEnvio Envio = new ServicioEnvio())
                Envio.ActualizarEnvio(ActEnvio);
        }
        public void EliminarEnvio(string id)
        {
            using (ServicioEnvio Envio = new ServicioEnvio())
                Envio.EliminarEnvio(id);
        }
    }
}
