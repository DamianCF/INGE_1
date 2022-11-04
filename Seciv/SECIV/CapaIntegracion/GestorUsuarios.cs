using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorUsuarios : IDisposable
    {

        public GestorUsuarios()
        {

        }
        public void Dispose()
        {

        }
        
        public void InsertarUsuario( string usu_cedula, string usu_nombre, string usu_primerApellido, string usu_segundoApellido, string usu_correo, string usu_contrasena, string usu_estado)
        {
            Usuario nuevoUsuario = new Usuario(usu_cedula,usu_nombre,usu_primerApellido,usu_segundoApellido,usu_correo,usu_contrasena,usu_estado);

            using (ServicioUsuario Usuario = new ServicioUsuario())
                Usuario.InsertarUsuario(nuevoUsuario);
        }

        public List<Usuario> ListarUsuarios()
        {
            using (ServicioUsuario Usuario = new ServicioUsuario())
            {
                return Usuario.ListarUsuarios();
            }
        }

        public void ActualizarUsuario(string id, string usu_cedula, string usu_nombre, string usu_primerApellido, string usu_segundoApellido, string usu_correo, string usu_contrasena, string usu_estado)
        {
            Usuario ActUsuario = new Usuario(id, usu_cedula, usu_nombre, usu_primerApellido, usu_segundoApellido, usu_correo, usu_contrasena, usu_estado);
            using (ServicioUsuario Usuario = new ServicioUsuario())
                Usuario.ActualizarUsuario(ActUsuario);
        }
        public void EliminarUsuario(string id)
        {
            using (ServicioUsuario Usuario = new ServicioUsuario())
                Usuario.EliminarUsuario(id);
        }

    }
}
