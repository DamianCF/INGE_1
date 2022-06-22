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
    public class ServicioAula : servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioAula()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarAula(Aula elAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Aula");// funciona como una bandera

            miComando.CommandText = "InsertarAula"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            miComando.Parameters.Add("Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Aula_descripcion"].Value = elAula.Aula_descripcion;

            miComando.Parameters.Add("Aula_capacidad", SqlDbType.VarChar);
            miComando.Parameters["Aula_capacidad"].Value = elAula.Aula_capacidad;

            miComando.Parameters.Add("Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["Aula_estado"].Value = elAula.Aula_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Aula";

            Console.WriteLine("Fin Servicio Insertar Aula");

            return respuesta;
        }

        public string modificarAula(Aula elAula)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Aula");

            miComando.CommandText = "ModificarAula"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = elAula.Aula_id;

            miComando.Parameters.Add("Aula_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Aula_descripcion"].Value = elAula.Aula_descripcion;

            miComando.Parameters.Add("Aula_capacidad", SqlDbType.VarChar);
            miComando.Parameters["Aula_capacidad"].Value = elAula.Aula_capacidad;

            miComando.Parameters.Add("Aula_estado", SqlDbType.VarChar);
            miComando.Parameters["Aula_estado"].Value = elAula.Aula_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Aula";

            Console.WriteLine("Fin Gestor Insertar Aula");

            return respuesta;
        }

        public DataSet ConsultarAula(int Aula_id)
        {
            miComando.CommandText = "ConsultarAula";
            miComando.Parameters.AddWithValue("@Aula_id", SqlDbType.Int);
            miComando.Parameters["@Aula_id"].Value = Aula_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarAula()  // retora todos los registros deAulaes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Aula");

            miComando.CommandText = "ListarAulas";
            DataSet eLAula = new DataSet();
            this.abrirConexion();

            eLAula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLAula.Tables[0];

            return miTabla;
        }

        public DataTable ListarAulasInactivas()  // retora todos los registros deAulaes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Aulas Inactivas");

            miComando.CommandText = "ListarAulasInactivas";

            DataSet eLAula = new DataSet();
            this.abrirConexion();

            eLAula = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLAula.Tables[0];

            return miTabla;
        }


        // faltan   eliminar, se hacen parecido
        public string InactivarAula(int Aula_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Aula");

            miComando.CommandText = "InactivarAula"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            miComando.Parameters.Add("Aula_id", SqlDbType.Int);
            miComando.Parameters["Aula_id"].Value = Aula_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Aula";

            Console.WriteLine("Fin Gestor Inactivar Aula");

            return respuesta;
        }
    }
}
