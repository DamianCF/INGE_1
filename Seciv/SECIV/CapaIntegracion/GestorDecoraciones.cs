using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorDecoraciones : IDisposable
    {

        public GestorDecoraciones()
        {

        }
        public void Dispose()
        {

        }
        public void InsertarDecoracion( string dec_descripcion, double dec_monto, string dec_estado)
        {
            Decoracion nuevaDecoracion = new Decoracion(dec_descripcion, dec_monto, dec_estado);

            using (ServicioDecoracion Decoracion = new ServicioDecoracion())
                Decoracion.InsertarDecoracion(nuevaDecoracion);
        }

        public List<Decoracion> ListarDecoraciones()
        {
            using (ServicioDecoracion Decoracion = new ServicioDecoracion())
            {
                return Decoracion.ListarDecoraciones();
            }
        }

        public void ActualizarDecoracion(string id, string dec_descripcion, double dec_monto, string dec_estado)
        {
            Decoracion ActDecoracion = new Decoracion(id, dec_descripcion, dec_monto, dec_estado);
            using (ServicioDecoracion Decoracion = new ServicioDecoracion())
                Decoracion.ActualizarDecoracion(ActDecoracion);
        }
        public void EliminarDecoracion(string id)
        {
            using (ServicioDecoracion Decoracion = new ServicioDecoracion())
                Decoracion.EliminarDecoracion(id);
        }
    }


}
