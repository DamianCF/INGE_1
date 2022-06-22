using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio.Matricula;



namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioMatricula : servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioMatricula()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarMatricula(Matricula elMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Matricula");// funciona como una bandera

            miComando.CommandText = "InsertarMatricula"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            // no se debe de colocar el id
            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = elMatricula.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elMatricula.Grupo_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = elMatricula.Curso_id;

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = elMatricula.Profesor_id;

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = elMatricula.Horario_id;

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = elMatricula.Aula_id;

            miComando.Parameters.Add("MatriculaComprobante", SqlDbType.VarChar);
            miComando.Parameters["MatriculaComprobante"].Value = elMatricula.Matricula_comprobante;

            miComando.Parameters.Add("Matricula_estado", SqlDbType.VarChar);
            miComando.Parameters["Matricula_estado"].Value = elMatricula.Matricula_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Matricula";

            Console.WriteLine("Fin Servicio Insertar Matricula");

            return respuesta;
        }

        public string modificarMatricula(Matricula elMatricula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Matricula");

            miComando.CommandText = "ModificarMatricula"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Matricula_id", SqlDbType.Int);
            miComando.Parameters["Matricula_id"].Value = elMatricula.Matricula_id;

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = elMatricula.Estudiante_id;

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elMatricula.Grupo_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = elMatricula.Curso_id;

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = elMatricula.Profesor_id;

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = elMatricula.Horario_id;

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = elMatricula.Aula_id;

            miComando.Parameters.Add("MatriculaComprobante", SqlDbType.VarChar);
            miComando.Parameters["MatriculaComprobante"].Value = elMatricula.Matricula_comprobante;

            miComando.Parameters.Add("Matricula_estado", SqlDbType.VarChar);
            miComando.Parameters["Matricula_estado"].Value = elMatricula.Matricula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Matricula";

            Console.WriteLine("Fin Gestor Insertar Matricula");

            return respuesta;
        }

        public DataSet ConsultarMatricula(int Matricula_id)
        {
            miComando.CommandText = "ConsultarMatricula";
            miComando.Parameters.AddWithValue("@Matricula_id", SqlDbType.Int);
            miComando.Parameters["@Matricula_id"].Value = Matricula_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarMatricula()  // retora todos los registros deMatriculaes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matricula");

            miComando.CommandText = "ListarMatricula";//ListarMatricula

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculaDescripcion()  // retora todos los registros deMatriculaes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matricula");

            miComando.CommandText = "ListarMatriculaDescripcion";

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasInactivas()  //
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Inactivas");

            miComando.CommandText = "ListarMatriculasInactivas";

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasInactivasDescripcion()  //
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Inactivas");

            miComando.CommandText = "ListarMatriculasInactivasDescripcion";

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasEstudianteCurso(int Estudiante_id, int Curso_id)  
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasEstudianteCurso";//ListarMatricula

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = Estudiante_id;

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = Curso_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }


        public DataTable ListarMatriculasEstudiante(int Estudiante_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasEstudiante";//ListarMatricula

            miComando.Parameters.Add("Estudiante_id", SqlDbType.Int);
            miComando.Parameters["Estudiante_id"].Value = Estudiante_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasGrupo(int Grupo_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasGrupo";//ListarMatricula

            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = Grupo_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasCurso(int Curso_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasCurso";//ListarMatricula

            miComando.Parameters.Add("Curso_id", SqlDbType.Int);
            miComando.Parameters["Curso_id"].Value = Curso_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasAula(int Aula_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasAula";//ListarMatricula

            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = Aula_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasProfesor(int Profesor_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasProfesor";//ListarMatricula

            miComando.Parameters.Add("Profesor_id", SqlDbType.Int);
            miComando.Parameters["Profesor_id"].Value = Profesor_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        public DataTable ListarMatriculasHorario(int Horario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Matriculas Estudiante Curso");

            miComando.CommandText = "ListarMatriculasHorario";//ListarMatricula

            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = Horario_id;

            DataSet eLMatricula = new DataSet();
            this.abrirConexion();

            eLMatricula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLMatricula.Tables[0];

            return miTabla;
        }

        // faltan el inactivar y eliminar, se hacen parecido
        public string InactivarMatricula(int Matricula_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Matricula");

            miComando.CommandText = "InactivarMatricula"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Matricula_id", SqlDbType.Int);
            miComando.Parameters["Matricula_id"].Value = Matricula_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Matricula";

            Console.WriteLine("Fin Gestor Inactivar Matricula");

            return respuesta;
        }
    }
}
