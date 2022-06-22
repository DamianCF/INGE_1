using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio.Horario
{
    public class Horario
    {

        #region ATRIBUTOS

        protected int horario_id;
        protected string horario_descripcion;
        protected string horario_dia;
        protected string horario_horaInicio;
        protected string horario_horaFinal;
        protected string horario_estado;

        #endregion


        #region CONSTRUCTORES

        public Horario()
        {

        }

        public Horario(string Hhorario_descripcion, string Hhorario_dia, string Hhorario_horaInicio, string Hhorario_horaFinal, string Hhorario_estado)
        {
            Horario_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Horario_descripcion = Hhorario_descripcion;
            Horario_dia = Hhorario_dia;
            Horario_horaInicio = Hhorario_horaInicio;
            Horario_horaFinal = Hhorario_horaFinal;
            Horario_estado = Hhorario_estado;
        }


        public Horario(int Hhorario_id, string Hhorario_descripcion, string Hhorario_dia, string Hhorario_horaInicio, string Hhorario_horaFinal, string Hhorario_estado)
        {
            Horario_id = Hhorario_id;
            Horario_descripcion = Hhorario_descripcion;
            Horario_dia = Hhorario_dia;
            Horario_horaInicio = Hhorario_horaInicio;
            Horario_horaFinal = Hhorario_horaFinal;
            Horario_estado = Hhorario_estado;
        }

        #endregion CONSTRUCTORES

        #region SETS Y GETS

        public int Horario_id { get => horario_id; set => horario_id = value; }
        public string Horario_descripcion { get => horario_descripcion; set => horario_descripcion = value; }
        public string Horario_dia { get => horario_dia; set => horario_dia = value; }
        public string Horario_horaInicio { get => horario_horaInicio; set => horario_horaInicio = value; }
        public string Horario_horaFinal { get => horario_horaFinal; set => horario_horaFinal = value; }
        public string Horario_estado { get => horario_estado; set => horario_estado = value; }

        #endregion Sets y gets


    }
}
