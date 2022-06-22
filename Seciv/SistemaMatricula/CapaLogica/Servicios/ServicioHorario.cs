using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio.Horario;



namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioHorario : servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioHorario()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Horario");// funciona como una bandera

            miComando.CommandText = "InsertarHorario"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            // no se debe de colocar el id
            miComando.Parameters.Add("Horario_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("Horario_dia", SqlDbType.VarChar);
            miComando.Parameters["Horario_dia"].Value = elHorario.Horario_dia;

            miComando.Parameters.Add("Horario_horaInicio", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaInicio"].Value = elHorario.Horario_horaInicio;

            miComando.Parameters.Add("Horario_horaFinal", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaFinal"].Value = elHorario.Horario_horaFinal;

            miComando.Parameters.Add("Horario_estado", SqlDbType.VarChar);
            miComando.Parameters["Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Horario";

            Console.WriteLine("Fin Servicio Insertar Horario");

            return respuesta;
        }

        public string modificarHorario(Horario elHorario)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Horario");

            miComando.CommandText = "ModificarHorario"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = elHorario.Horario_id;

            miComando.Parameters.Add("Horario_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Horario_descripcion"].Value = elHorario.Horario_descripcion;

            miComando.Parameters.Add("Horario_dia", SqlDbType.VarChar);
            miComando.Parameters["Horario_dia"].Value = elHorario.Horario_dia;

            miComando.Parameters.Add("Horario_horaInicio", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaInicio"].Value = elHorario.Horario_horaInicio;

            miComando.Parameters.Add("Horario_horaFinal", SqlDbType.VarChar);
            miComando.Parameters["Horario_horaFinal"].Value = elHorario.Horario_horaFinal;

            miComando.Parameters.Add("Horario_estado", SqlDbType.VarChar);
            miComando.Parameters["Horario_estado"].Value = elHorario.Horario_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Horario";

            Console.WriteLine("Fin Gestor Insertar Horario");

            return respuesta;
        }

        public DataSet ConsultarHorario(int Horario_id)
        {
            miComando.CommandText = "ConsultarHorario";
            miComando.Parameters.AddWithValue("@Horario_id", SqlDbType.Int);
            miComando.Parameters["@Horario_id"].Value = Horario_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarHorario()  // retora todos los registros deHorarioes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Horario");

            miComando.CommandText = "ListarHorarios";//ListarHorario

            DataSet eLHorario = new DataSet();
            this.abrirConexion();

            eLHorario = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLHorario.Tables[0];

            return miTabla;
        }

        public DataTable ListarHorariosInactivos()  // retora todos los registros deHorarioes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Horarios Inactivos");

            miComando.CommandText = "ListarHorariosInactivos";//ListarHorario

            DataSet eLHorario = new DataSet();
            this.abrirConexion();

            eLHorario = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLHorario.Tables[0];

            return miTabla;
        }

        // faltan el inactivar y eliminar, se hacen parecido
        public string InactivarHorario(int Horario_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Horario");

            miComando.CommandText = "InactivarHorario"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Horario_id", SqlDbType.Int);
            miComando.Parameters["Horario_id"].Value = Horario_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Horario";

            Console.WriteLine("Fin Gestor Inactivar Horario");

            return respuesta;
        }
    }
}
