using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio.Curso;

/* se anuncia o presenta todos los metodos de procedimientos almacenados de la bd
 */

namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioCurso : servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioCurso()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Curso");// funciona como una bandera

            miComando.CommandText = "InsertarCurso"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            miComando.Parameters.Add("Curso_nombre", SqlDbType.VarChar);
            miComando.Parameters["Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("Curso_creditos", SqlDbType.VarChar);
            miComando.Parameters["Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("Curso_cupo", SqlDbType.VarChar);
            miComando.Parameters["Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("Curso_estado", SqlDbType.VarChar);
            miComando.Parameters["Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Curso";

            Console.WriteLine("Fin Servicio Insertar Curso");

            return respuesta;
        }

        public string modificarCurso(Curso elCurso)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Curso");

            miComando.CommandText = "ModificarCurso"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = elCurso.Curso_id;

            miComando.Parameters.Add("Curso_nombre", SqlDbType.VarChar);
            miComando.Parameters["Curso_nombre"].Value = elCurso.Curso_nombre;

            miComando.Parameters.Add("Curso_creditos", SqlDbType.VarChar);
            miComando.Parameters["Curso_creditos"].Value = elCurso.Curso_creditos;

            miComando.Parameters.Add("Curso_cupo", SqlDbType.VarChar);
            miComando.Parameters["Curso_cupo"].Value = elCurso.Curso_cupo;

            miComando.Parameters.Add("Curso_estado", SqlDbType.VarChar);
            miComando.Parameters["Curso_estado"].Value = elCurso.Curso_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Curso";

            Console.WriteLine("Fin Gestor Insertar Curso");

            return respuesta;
        }

        public DataSet ConsultarCurso(int Curso_id)
        {
            miComando.CommandText = "ConsultarCurso";
            miComando.Parameters.AddWithValue("@Curso_id", SqlDbType.Int);
            miComando.Parameters["@Curso_id"].Value = Curso_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarCurso()  // retora todos los registros deCursoes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Curso");

            miComando.CommandText = "ListarCurso";//ListarCurso

            DataSet eLCurso = new DataSet();
            this.abrirConexion();

            eLCurso = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLCurso.Tables[0];

            return miTabla;
        }

        public DataTable ListarCursosInactivos()  // 
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Cursos Inactivos");

            miComando.CommandText = "ListarCursosInactivos";

            DataSet eLCurso = new DataSet();
            this.abrirConexion();

            eLCurso = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLCurso.Tables[0];

            return miTabla;
        }

        // falta eliminar, se hacen parecido
        public string InactivarCurso(int Curso_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Curso");

            miComando.CommandText = "InactivarCurso"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = Curso_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Curso";

            Console.WriteLine("Fin Gestor Inactivar Curso");

            return respuesta;
        }
    }
}
