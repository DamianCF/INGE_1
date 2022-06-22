using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio.Matricula
{
    public class Matricula
    {

        #region ATRIBUTOS

        protected int matricula_id;
        protected int estudiante_id;
        protected int grupo_id;
        protected int curso_id;
        protected int profesor_id;
        protected int horario_id;
        protected int aula_id;
        protected string matricula_comprobante;
        protected string matricula_estado;

        #endregion


        #region CONSTRUCTORES

        public Matricula()
        {

        }



        public Matricula(int Eestudiante_id, int Ggrupo_id, int Ccurso_id, int Pprofesor_id, int Hhorario_id,
            int Aaula_id, string Mmatricula_comprobante, string Mmatricula_estado)
        {
            Matricula_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Estudiante_id = Eestudiante_id;
            Grupo_id = Ggrupo_id;
            Curso_id = Ccurso_id;
            Profesor_id = Pprofesor_id;
            Horario_id = Hhorario_id;
            Aula_id = Aaula_id;
            Matricula_comprobante = Mmatricula_comprobante;
            Matricula_estado = Mmatricula_estado;
        }


        public Matricula(int Mmatricula_id, int Eestudiante_id, int Ggrupo_id, int Ccurso_id, int Pprofesor_id, int Hhorario_id,
            int Aaula_id, string Mmatricula_comprobante, string Mmatricula_estado)
        {
            Matricula_id = Mmatricula_id;
            Estudiante_id = Eestudiante_id;
            Grupo_id = Ggrupo_id;
            Curso_id = Ccurso_id;
            Profesor_id = Pprofesor_id;
            Horario_id = Hhorario_id;
            Aula_id = Aaula_id;
            Matricula_comprobante = Mmatricula_comprobante;
            Matricula_estado = Mmatricula_estado;
        }

        #endregion CONTRUCTORES

        #region SETS Y GETS

        public int Matricula_id { get => matricula_id; set => matricula_id = value; }
        public int Estudiante_id { get => estudiante_id; set => estudiante_id = value; }
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public int Curso_id { get => curso_id; set => curso_id = value; }
        public int Profesor_id { get => profesor_id; set => profesor_id = value; }
        public int Horario_id { get => horario_id; set => horario_id = value; }
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Matricula_comprobante { get => matricula_comprobante; set => matricula_comprobante = value; }
        public string Matricula_estado { get => matricula_estado; set => matricula_estado = value; }

        #endregion Sets y gets

    }
}
