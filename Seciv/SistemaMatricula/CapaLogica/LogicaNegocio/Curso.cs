using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio.Curso
{
    public class Curso
    {

#region ATRIBUTOS

        protected int curso_id;
        protected string curso_nombre;
        protected string curso_creditos;
        protected string curso_cupo;
        protected string curso_estado;

#endregion


#region CONSTRUCTORES

        public Curso()
        {

        }

        public Curso(string Ccurso_nombre, string Ccurso_creditos, string Ccurso_cupo, string Ccurso_estado)
        {
            Curso_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Curso_nombre = Ccurso_nombre;
            Curso_creditos = Ccurso_creditos;
            Curso_cupo = Ccurso_cupo;
            Curso_estado = Ccurso_estado;
        }

        public Curso(int Ccurso_id, string Ccurso_nombre, string Ccurso_creditos, string Ccurso_cupo, string Ccurso_estado)
        {
            Curso_id = Ccurso_id;
            Curso_nombre = Ccurso_nombre;
            Curso_creditos = Ccurso_creditos;
            Curso_cupo = Ccurso_cupo;
            Curso_estado = Ccurso_estado;
        }

#endregion CONTRUCTORES

#region SETS Y GETS

    public int Curso_id { get => curso_id; set => curso_id = value; }
        public string Curso_nombre { get => curso_nombre; set => curso_nombre = value; }
        public string Curso_creditos { get => curso_creditos; set => curso_creditos = value; }
        public string Curso_cupo { get => curso_cupo; set => curso_cupo = value; }
        public string Curso_estado { get => curso_estado; set => curso_estado = value; }
 #endregion Sets y gets

    }
}
