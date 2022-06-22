using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio.Grupo
{
    public class Grupo
    {

        #region ATRIBUTOS

        protected int grupo_id;
        protected string grupo_descripcion;
        protected string grupo_estado;

        #endregion

        #region CONSTRUCTORES

        public Grupo()
        {

        }

        public Grupo(string Ggrupo_descripcion, string Ggrupo_estado)
        {
            Grupo_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Grupo_descripcion = Ggrupo_descripcion;
            Grupo_estado = Ggrupo_estado;
        }

        public Grupo(int Ggrupo_id, string Ggrupo_descripcion, string Ggrupo_estado)
        {
            Grupo_id = Ggrupo_id;
            Grupo_descripcion = Ggrupo_descripcion;
            Grupo_estado = Ggrupo_estado;
        }

        #endregion CONTRUCTORES

        #region SETS Y GETS
        public int Grupo_id { get => grupo_id; set => grupo_id = value; }
        public string Grupo_descripcion { get => grupo_descripcion; set => grupo_descripcion = value; }
        public string Grupo_estado { get => grupo_estado; set => grupo_estado = value; }

        #endregion Sets y gets

    }
}
