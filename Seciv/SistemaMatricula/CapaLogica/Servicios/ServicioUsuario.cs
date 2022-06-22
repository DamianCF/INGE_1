using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio;

namespace SistemaMatricula.CapaLogica.Servicios
{
   public class ServicioUsuario : servicio, IDisposable
    {

        // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioUsuario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Usuario");// funciona como una bandera

            miComando.CommandText = "InsertarUsuario"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            // no se debe de colocar el id
            miComando.Parameters.Add("Usuario_cedula", SqlDbType.VarChar);
            miComando.Parameters["Usuario_cedula"].Value = elUsuario.Usuario_cedula;

            miComando.Parameters.Add("Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("Usuario_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Usuario_primerApellido"].Value = elUsuario.Usuario_primerApellido;

            miComando.Parameters.Add("Usuario_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Usuario_segundoApellido"].Value = elUsuario.Usuario_segundoApellido;

            miComando.Parameters.Add("Usuario_tipo", SqlDbType.VarChar);
            miComando.Parameters["Usuario_tipo"].Value = elUsuario.Usuario_tipo;

            miComando.Parameters.Add("Usuario_telefono", SqlDbType.VarChar);
            miComando.Parameters["Usuario_telefono"].Value = elUsuario.Usuario_telefono;

            miComando.Parameters.Add("Usuario_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Usuario_correoElectronico"].Value = elUsuario.Usuario_correoElectronico;

            miComando.Parameters.Add("Usuario_direccion", SqlDbType.VarChar);
            miComando.Parameters["Usuario_direccion"].Value = elUsuario.Usuario_direccion;
           
            miComando.Parameters.Add("Usuario_contrasenia", SqlDbType.VarChar);
            miComando.Parameters["Usuario_contrasenia"].Value = elUsuario.Usuario_contrasenia;

            miComando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["Usuario_estado"].Value = elUsuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Usuario";

            Console.WriteLine("Fin Servicio Insertar Usuario");

            return respuesta;
        }

        public string modificarUsuario(Usuario elUsuario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Usuario");

            miComando.CommandText = "ModificarUsuario"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Usuario_id", SqlDbType.Int);
            miComando.Parameters["Usuario_id"].Value = elUsuario.Usuario_id;

            miComando.Parameters.Add("Usuario_cedula", SqlDbType.VarChar);
            miComando.Parameters["Usuario_cedula"].Value = elUsuario.Usuario_cedula;

            miComando.Parameters.Add("Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["Usuario_nombre"].Value = elUsuario.Usuario_nombre;

            miComando.Parameters.Add("Usuario_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Usuario_primerApellido"].Value = elUsuario.Usuario_primerApellido;

            miComando.Parameters.Add("Usuario_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Usuario_segundoApellido"].Value = elUsuario.Usuario_segundoApellido;

            miComando.Parameters.Add("Usuario_tipo", SqlDbType.VarChar);
            miComando.Parameters["Usuario_tipo"].Value = elUsuario.Usuario_tipo;

            miComando.Parameters.Add("Usuario_telefono", SqlDbType.VarChar);
            miComando.Parameters["Usuario_telefono"].Value = elUsuario.Usuario_telefono;

            miComando.Parameters.Add("Usuario_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Usuario_correoElectronico"].Value = elUsuario.Usuario_correoElectronico;

            miComando.Parameters.Add("Usuario_direccion", SqlDbType.VarChar);
            miComando.Parameters["Usuario_direccion"].Value = elUsuario.Usuario_direccion;

            miComando.Parameters.Add("Usuario_contrasenia", SqlDbType.VarChar);
            miComando.Parameters["Usuario_contrasenia"].Value = elUsuario.Usuario_contrasenia;

            miComando.Parameters.Add("Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["Usuario_estado"].Value = elUsuario.Usuario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Usuario";

            Console.WriteLine("Fin Gestor Insertar Usuario");

            return respuesta;
        }

        public DataSet ConsultarUsuario(int Usuario_id)
        {
            miComando.CommandText = "ConsultarUsuario";

            miComando.Parameters.AddWithValue("@Usuario_id", SqlDbType.Int);
            miComando.Parameters["@Usuario_id"].Value = Usuario_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataSet ConsultarUsuarioLogin(string Usuario_cedula, string Usuario_contrasenia)
        {
            miComando.CommandText = "ConsultarUsuarioLogin";

            miComando.Parameters.AddWithValue("@Usuario_cedula", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_cedula"].Value = Usuario_cedula;

            miComando.Parameters.AddWithValue("@Usuario_contrasenia", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contrasenia"].Value = Usuario_contrasenia;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarUsuario()  // retora todos los registros deUsuarioes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Usuario");

            miComando.CommandText = "ListarUsuarios";//ListarUsuario

            DataSet eLUsuario = new DataSet();
            this.abrirConexion();

            eLUsuario = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLUsuario.Tables[0];

            return miTabla;
        }

        // faltan el inactivar y eliminar, se hacen parecido

        public string InactivarUsuario(int Usuario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Usuario");

            miComando.CommandText = "InactivarUsuario"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Usuario_id", SqlDbType.Int);
            miComando.Parameters["Usuario_id"].Value = Usuario_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Usuario";

            Console.WriteLine("Fin Gestor Inactivar Usuario");

            return respuesta;
        }

    }
}
