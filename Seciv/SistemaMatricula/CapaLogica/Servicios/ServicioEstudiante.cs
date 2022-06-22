using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio.Estudiante;

/* se anuncia o presenta todos los metodos de procedimientos almacenados de la bd
 */

namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioEstudiante : servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioEstudiante()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarEstudiante(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Estudiante");// funciona como una bandera

            miComando.CommandText = "InsertarEstudiante"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elEstudiante.Grupo_id;

            miComando.Parameters.Add("Estudiante_cedula", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("Estudiante_nombre", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("Estudiante_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("Estudiante_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("Estudiante_telefono", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_telefono"].Value = elEstudiante.Estudiante_telefono;

            miComando.Parameters.Add("Estudiante_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("Estudiante_direccion", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("Estudiante_estado", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Estudiante";

            Console.WriteLine("Fin Servicio Insertar Estudiante");

            return respuesta;
        }

        public string modificarEstudiante(Estudiante elEstudiante)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Estudiante");

            miComando.CommandText = "ModificarEstudiante"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = elEstudiante.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elEstudiante.Grupo_id;

            miComando.Parameters.Add("Estudiante_cedula", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_cedula"].Value = elEstudiante.Estudiante_cedula;

            miComando.Parameters.Add("Estudiante_nombre", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_nombre"].Value = elEstudiante.Estudiante_nombre;

            miComando.Parameters.Add("Estudiante_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_primerApellido"].Value = elEstudiante.Estudiante_primerApellido;

            miComando.Parameters.Add("Estudiante_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_segundoApellido"].Value = elEstudiante.Estudiante_segundoApellido;

            miComando.Parameters.Add("Estudiante_telefono", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_telefono"].Value = elEstudiante.Estudiante_telefono;

            miComando.Parameters.Add("Estudiante_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_correoElectronico"].Value = elEstudiante.Estudiante_correoElectronico;

            miComando.Parameters.Add("Estudiante_direccion", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_direccion"].Value = elEstudiante.Estudiante_direccion;

            miComando.Parameters.Add("Estudiante_estado", SqlDbType.VarChar);
            miComando.Parameters["Estudiante_estado"].Value = elEstudiante.Estudiante_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Estudiante";

            Console.WriteLine("Fin Gestor Insertar Estudiante");

            return respuesta;
        }

        public DataSet ConsultarEstudiante(int Estudiante_id)
        {
            miComando.CommandText = "ConsultarEstudiante";
            miComando.Parameters.AddWithValue("@Estudiante_id", SqlDbType.Int);
            miComando.Parameters["@Estudiante_id"].Value = Estudiante_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarEstudiante()  // retora todos los registros deEstudiantees y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Estudiante");

            miComando.CommandText = "ListarEstudiantes";//ListarEstudiante

            DataSet eLEstudiante = new DataSet();
            this.abrirConexion();

            eLEstudiante = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLEstudiante.Tables[0];

            return miTabla;
        }

        public DataTable ListarEstudiantesInactivos()  // retora todos los registros deEstudiantees y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Estudiantes Inactivos");

            miComando.CommandText = "ListarEstudiantesInactivos";//ListarEstudiante

            DataSet eLEstudiante = new DataSet();
            this.abrirConexion();

            eLEstudiante = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLEstudiante.Tables[0];

            return miTabla;
        }

        // falta eliminar, se hacen parecido
        public string InactivarEstudiante(int Estudiante_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Estudiante");

            miComando.CommandText = "InactivarEstudiante"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = Estudiante_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Estudiante";

            Console.WriteLine("Fin Gestor Inactivar Estudiante");

            return respuesta;
        }
    }
}
