using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio.Estudiante
{
    public class Estudiante
    {

        #region ATRIBUTOS

        protected int estudiante_id;
        protected int grupo_id;
        protected string estudiante_cedula;
        protected string estudiante_nombre;
        protected string estudiante_primerApellido;
        protected string estudiante_segundoApellido;
        protected string estudiante_telefono;
        protected string estudiante_correoElectronico;
        protected string estudiante_direccion;
        protected string estudiante_estado;


        #endregion


        #region CONSTRUCTORES

        public Estudiante()
        {

        }


        public Estudiante(string Eestudiante_cedula, string Eestudiante_nombre, string Eestudiante_primerApellido, string Eestudiante_segundoApellido,
            string Eestudiante_telefono, string Eestudiante_correoElectronico, string Eestudiante_direccion, string Eestudiante_estado)
        {
            Estudiante_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Grupo_id = 0;
            Estudiante_cedula = Eestudiante_cedula;
            Estudiante_nombre = Eestudiante_nombre;
            Estudiante_primerApellido = Eestudiante_primerApellido;
            Estudiante_segundoApellido = Eestudiante_segundoApellido;
            Estudiante_telefono = Eestudiante_telefono;
            Estudiante_correoElectronico = Eestudiante_correoElectronico;
            Estudiante_direccion = Eestudiante_direccion;
            Estudiante_estado = Eestudiante_estado;
        }

        public Estudiante(int Ggrupo_id,string Eestudiante_cedula, string Eestudiante_nombre, string Eestudiante_primerApellido, string Eestudiante_segundoApellido,
            string Eestudiante_telefono, string Eestudiante_correoElectronico, string Eestudiante_direccion, string Eestudiante_estado)
        {
            Estudiante_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Grupo_id = Ggrupo_id;
            Estudiante_cedula = Eestudiante_cedula;
            Estudiante_nombre = Eestudiante_nombre;
            Estudiante_primerApellido = Eestudiante_primerApellido;
            Estudiante_segundoApellido = Eestudiante_segundoApellido;
            Estudiante_telefono = Eestudiante_telefono;
            Estudiante_correoElectronico = Eestudiante_correoElectronico;
            Estudiante_direccion = Eestudiante_direccion;
            Estudiante_estado = Eestudiante_estado;
        }

        public Estudiante(int Eestudiante_id, int Ggrupo_id, string Eestudiante_cedula, string Eestudiante_nombre, string Eestudiante_primerApellido, string Eestudiante_segundoApellido,
            string Eestudiante_telefono, string Eestudiante_correoElectronico, string Eestudiante_direccion, string Eestudiante_estado)
        {
            Estudiante_id = Eestudiante_id;
            Grupo_id = Ggrupo_id;
            Estudiante_cedula = Eestudiante_cedula;
            Estudiante_nombre = Eestudiante_nombre;
            Estudiante_primerApellido = Eestudiante_primerApellido;
            Estudiante_segundoApellido = Eestudiante_segundoApellido;
            Estudiante_telefono = Eestudiante_telefono;
            Estudiante_correoElectronico = Eestudiante_correoElectronico;
            Estudiante_direccion = Eestudiante_direccion;
            Estudiante_estado = Eestudiante_estado;
        }

        #endregion CONTRUCTORES


        #region SETS Y GETS

        public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public string Estudiante_cedula { get => estudiante_cedula; set => estudiante_cedula = value; }
        public string Estudiante_nombre { get => estudiante_nombre; set => estudiante_nombre = value; }
        public string Estudiante_primerApellido { get => estudiante_primerApellido; set => estudiante_primerApellido = value; }
        public string Estudiante_segundoApellido { get => estudiante_segundoApellido; set => estudiante_segundoApellido = value; }
        public string Estudiante_telefono { get => estudiante_telefono; set => estudiante_telefono = value; }
        public string Estudiante_correoElectronico { get => estudiante_correoElectronico; set => estudiante_correoElectronico = value; }
        public string Estudiante_direccion { get => estudiante_direccion; set => estudiante_direccion = value; }
        public string Estudiante_estado { get => estudiante_estado; set => estudiante_estado = value; }

        #endregion Sets y gets

    }
}
