using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas
using SistemaMatricula.CapaConexion;
using SistemaMatricula.CapaLogica.LogicaNegocio.Grupo;


namespace SistemaMatricula.CapaLogica.Servicios
{
    public class ServicioGrupo : servicio, IDisposable
    {                           // indica usar la conexion a base de datos
                                // el IDisponsable libera memoria
        private SqlCommand miComando;
        private string respuesta;

        public void Dispose() // se requiere este metodo para usar el IDisposable
        {

        }

        public ServicioGrupo()
        {
            respuesta = "";
            miComando = new SqlCommand();
        }

        public string InsertarGrupo(Grupo elGrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Insertar Grupo");// funciona como una bandera

            miComando.CommandText = "InsertarGrupo"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd


            miComando.Parameters.Add("Grupo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Grupo_descripcion"].Value = elGrupo.Grupo_descripcion;

            miComando.Parameters.Add("Grupo_estado", SqlDbType.VarChar);
            miComando.Parameters["Grupo_estado"].Value = elGrupo.Grupo_estado;

            respuesta = this.ejecutaSentencia(miComando); // ordena la ejecucion del procedimiento almacenado

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Insertar Grupo";

            Console.WriteLine("Fin Servicio Insertar Grupo");

            return respuesta;
        }

        public string modificarGrupo(Grupo elGrupo)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Modificar Grupo");

            miComando.CommandText = "ModificarGrupo"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = elGrupo.Grupo_id;

            miComando.Parameters.Add("Grupo_descripcion", SqlDbType.VarChar);
            miComando.Parameters["Grupo_descripcion"].Value = elGrupo.Grupo_descripcion;

            miComando.Parameters.Add("Grupo_estado", SqlDbType.VarChar);
            miComando.Parameters["Grupo_estado"].Value = elGrupo.Grupo_estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Modificar Grupo";

            Console.WriteLine("Fin Gestor Insertar Grupo");

            return respuesta;
        }

        public DataSet ConsultarGrupo(int Grupo_id)
        {
            miComando.CommandText = "ConsultarGrupo";
            miComando.Parameters.AddWithValue("@Grupo_id", SqlDbType.Int);
            miComando.Parameters["@Grupo_id"].Value = Grupo_id;

            DataSet miDataSet = new DataSet(); // el DataSet va a debolver un registro de un profesor de acuerdo al id buscado
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataTable ListarGrupo()  // retora todos los registros deGrupoes y los inserta en una tabla
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Grupo");

            miComando.CommandText = "ListarGrupos";//ListarGrupo

            DataSet eLGrupo = new DataSet();
            this.abrirConexion();

            eLGrupo = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLGrupo.Tables[0];

            return miTabla;
        }

        public DataTable ListarGruposInactivos()  // a
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Listar Grupos Inactivos");

            miComando.CommandText = "ListarGruposInactivos";//ListarGrupo

            DataSet eLGrupo = new DataSet();
            this.abrirConexion();

            eLGrupo = this.seleccionarInformacion(miComando);
            DataTable miTabla = eLGrupo.Tables[0];

            return miTabla;
        }

        // faltan el inactivar y eliminar, se hacen parecido
        public string InactivarGrupo(int Grupo_id)
        {
            miComando = new SqlCommand();
            Console.WriteLine("Gestor Inactivar Grupo");

            miComando.CommandText = "InactivarGrupo"; /// debe de coincidir con el nombre de un procedimiento almacenado encontrado en la bd
            // las cosas deben de coincidir con la bd
            miComando.Parameters.Add("Grupo_id", SqlDbType.Int);
            miComando.Parameters["Grupo_id"].Value = Grupo_id;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion Eliminar Grupo";

            Console.WriteLine("Fin Gestor Inactivar Grupo");

            return respuesta;
        }
    }
}
