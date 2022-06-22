using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Aula
    {
        #region ATRIBUTOS

        protected int aula_id;
        protected string aula_descripcion;
        protected string aula_capacidad;
        protected string aula_estado;

        #endregion

        #region CONSTRUCTORES

        public Aula()
        {

        }

        public Aula(string Aaula_descripcion, string Aaula_capacidad, string Aaula_estado)
        {
            Aula_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Aula_descripcion = Aaula_descripcion;
            Aula_capacidad = Aaula_capacidad;
            Aula_estado = Aaula_estado;
        }

        public Aula(int Aaula_id, string Aaula_descripcion, string Aaula_capacidad, string Aaula_estado)
        {
            Aula_id = Aaula_id;
            Aula_descripcion = Aaula_descripcion;
            Aula_capacidad = Aaula_capacidad;
            Aula_estado = Aaula_estado;
        }

        #endregion CONTRUCTORES


        #region SETS Y GETS
        public int Aula_id { get => aula_id; set => aula_id = value; }
        public string Aula_descripcion { get => aula_descripcion; set => aula_descripcion = value; }
        public string Aula_capacidad { get => aula_capacidad; set => aula_capacidad = value; }
        public string Aula_estado { get => aula_estado; set => aula_estado = value; }

        #endregion Sets y gets

    }
}
