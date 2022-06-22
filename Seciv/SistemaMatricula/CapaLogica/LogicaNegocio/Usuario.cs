using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatricula.CapaLogica.LogicaNegocio
{
    public class Usuario
    {

        #region ATRIBUTOS

        protected int usuario_id;
        protected string usuario_cedula;
        protected string usuario_nombre;
        protected string usuario_primerApellido;
        protected string usuario_segundoApellido;
        protected string usuario_tipo;
        protected string usuario_telefono;
        protected string usuario_correoElectronico;
        protected string usuario_direccion;
        protected string usuario_contrasenia;
        protected string usuario_estado;

        #endregion

        #region CONSTRUCTORES

        public Usuario()
        {

        }


        public Usuario(string Pusuario_cedula, string Pusuario_nombre, string Pusuario_primerApellido, string Pusuario_segundoApellido,
            string Pusuario_tipo,string Pusuario_telefono, string Pusuario_correoElectronico, string Pusuario_direccion, string Pusuario_contrasenia,string Pusuario_estado)
        {
            Usuario_id = 0;//   es un constructor para un procedimieto almacenado de insertar , el id se genera el la db
            Usuario_cedula = Pusuario_cedula;
            Usuario_nombre = Pusuario_nombre;
            Usuario_primerApellido = Pusuario_primerApellido;
            Usuario_segundoApellido = Pusuario_segundoApellido;
            Usuario_tipo = Pusuario_tipo;
            Usuario_telefono = Pusuario_telefono;
            Usuario_correoElectronico = Pusuario_correoElectronico;
            Usuario_direccion = Pusuario_direccion;
            Usuario_contrasenia = Pusuario_contrasenia;
            Usuario_estado = Pusuario_estado;
        }


        public Usuario(int Pusuario_id, string Pusuario_cedula, string Pusuario_nombre, string Pusuario_primerApellido, string Pusuario_segundoApellido,
            string Pusuario_tipo, string Pusuario_telefono, string Pusuario_correoElectronico, string Pusuario_direccion, string Pusuario_contrasenia, string Pusuario_estado)
        {
            Usuario_id = Pusuario_id;
            Usuario_cedula = Pusuario_cedula;
            Usuario_nombre = Pusuario_nombre;
            Usuario_primerApellido = Pusuario_primerApellido;
            Usuario_segundoApellido = Pusuario_segundoApellido;
            Usuario_tipo = Pusuario_tipo;
            Usuario_telefono = Pusuario_telefono;
            Usuario_correoElectronico = Pusuario_correoElectronico;
            Usuario_direccion = Pusuario_direccion;
            Usuario_contrasenia = Pusuario_contrasenia;
            Usuario_estado = Pusuario_estado;
        }

        #endregion CONTRUCTORES

        #region SETS Y GETS
        public int Usuario_id { get => usuario_id; set => usuario_id = value; }
        public string Usuario_cedula { get => usuario_cedula; set => usuario_cedula = value; }
        public string Usuario_nombre { get => usuario_nombre; set => usuario_nombre = value; }
        public string Usuario_primerApellido { get => usuario_primerApellido; set => usuario_primerApellido = value; }
        public string Usuario_segundoApellido { get => usuario_segundoApellido; set => usuario_segundoApellido = value; }
        public string Usuario_tipo { get => usuario_tipo; set => usuario_tipo = value; }
        public string Usuario_telefono { get => usuario_telefono; set => usuario_telefono = value; }
        public string Usuario_correoElectronico { get => usuario_correoElectronico; set => usuario_correoElectronico = value; }
        public string Usuario_direccion { get => usuario_direccion; set => usuario_direccion = value; }
        public string Usuario_contrasenia { get => usuario_contrasenia; set => usuario_contrasenia = value; }
        public string Usuario_estado { get => usuario_estado; set => usuario_estado = value; }

        #endregion Sets y gets
    }
}
