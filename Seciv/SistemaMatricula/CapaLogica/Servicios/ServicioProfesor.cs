using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio.Profesor;

/* se anuncia o presenta todos los metodos de procedimientos almacenados de la bd
 */

namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioProfesor:servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioProfesor()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Profesor");// funciona como una bandera

            miComando.CommandText = "InsertarProfesor"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            // no se debe de colocar el id
            miComando.Parameters.Add("Profesor_cedula", SqlDbType.VarChar);
            miComando.Parameters["Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("Profesor_nombre", SqlDbType.VarChar);
            miComando.Parameters["Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("Profesor_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("Profesor_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("Profesor_telefono", SqlDbType.VarChar);
            miComando.Parameters["Profesor_telefono"].Value = elProfesor.Profesor_telefono;

            miComando.Parameters.Add("Profesor_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("Profesor_direccion", SqlDbType.VarChar);
            miComando.Parameters["Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("Profesor_estado", SqlDbType.VarChar);
            miComando.Parameters["Profesor_estado"].Value = elProfesor.Profesor_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Profesor";

            Console.WriteLine("Fin Servicio Insertar Profesor");

            return respuesta;
        }

        public string modificarProfesor(Profesor elProfesor)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Profesor");

            miComando.CommandText = "ModificarProfesor"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = elProfesor.Profesor_id;

            miComando.Parameters.Add("Profesor_cedula", SqlDbType.VarChar);
            miComando.Parameters["Profesor_cedula"].Value = elProfesor.Profesor_cedula;

            miComando.Parameters.Add("Profesor_nombre", SqlDbType.VarChar);
            miComando.Parameters["Profesor_nombre"].Value = elProfesor.Profesor_nombre;

            miComando.Parameters.Add("Profesor_primerApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_primerApellido"].Value = elProfesor.Profesor_primerApellido;

            miComando.Parameters.Add("Profesor_segundoApellido", SqlDbType.VarChar);
            miComando.Parameters["Profesor_segundoApellido"].Value = elProfesor.Profesor_segundoApellido;

            miComando.Parameters.Add("Profesor_telefono", SqlDbType.VarChar);
            miComando.Parameters["Profesor_telefono"].Value = elProfesor.Profesor_telefono;

            miComando.Parameters.Add("Profesor_correoElectronico", SqlDbType.VarChar);
            miComando.Parameters["Profesor_correoElectronico"].Value = elProfesor.Profesor_correoElectronico;

            miComando.Parameters.Add("Profesor_direccion", SqlDbType.VarChar);
            miComando.Parameters["Profesor_direccion"].Value = elProfesor.Profesor_direccion;

            miComando.Parameters.Add("Profesor_estado", SqlDbType.VarChar);
            miComando.Parameters["Profesor_estado"].Value = elProfesor.Profesor_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Profesor";

            Console.WriteLine("Fin Gestor Insertar Profesor");

            return respuesta;
        }

        public DataSet ConsultarProfesor( int Profesor_id)
        {
            miComando.CommandText = "ConsultarProfesor";
            miComando.Parameters.AddWithValue("@Profesor_id", SqlDbType.Int);
            miComando.Parameters["@Profesor_id"].Value = Profesor_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarProfesor()  // retora todos los registros deProfesores y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Profesor");

            miComando.CommandText = "ListarProfesores";//ListarProfesor

            DataSet eLProfesor = new DataSet();
            this.abrirConexion();

            eLProfesor = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLProfesor.Tables[0];

            return miTabla;
        }

        public DataTable ListarProfesoresInactivos()  
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Profesor");

            miComando.CommandText = "ListarProfesoresInactivos";

            DataSet eLProfesor = new DataSet();
            this.abrirConexion();

            eLProfesor = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLProfesor.Tables[0];

            return miTabla;
        }

        // faltan el inactivar y eliminar, se hacen parecido

        public string InactivarProfesor(int Profesor_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Profesor");

            miComando.CommandText = "InactivarProfesor"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = Profesor_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Profesor";

            Console.WriteLine("Fin Gestor Inactivar Profesor");

            return respuesta;
        }


    }
}
