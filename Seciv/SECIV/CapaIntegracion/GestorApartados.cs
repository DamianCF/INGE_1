using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorApartados : IDisposable
    {
        public GestorApartados()
        {

        }

        public void Dispose()
        {

        }

        public void InsertarApartados(string apa_codigo, string apa_nomCliente, string apa_productos, string apa_fecha, string apa_fechaLimite,
            string apa_abonos, string apa_saldos, string apa_estado)
        {
            Apartado nuevoApartado = new Apartado(apa_codigo, apa_nomCliente, apa_productos, apa_fecha, apa_fechaLimite, apa_abonos, apa_saldos, apa_estado);

            using (ServicioApartado Apartado = new ServicioApartado())
                Apartado.InsertarApartados(nuevoApartado);
        }

        public List<Apartado> ListarApartados()
        {
            using (ServicioApartado Apartado = new ServicioApartado())
            {
                return Apartado.ListarApartados();
            }
        }

        public void ActualizarApartados(string id,string apa_codigo, string apa_nomCliente, string apa_productos, string apa_fecha, string apa_fechaLimite,
            string apa_abonos, string apa_saldos, string apa_estado)
        {
            Apartado ActApartado = new Apartado(id, apa_codigo, apa_nomCliente, apa_productos, apa_fecha, apa_fechaLimite, apa_abonos, apa_saldos, apa_estado);
            using (ServicioApartado Apartado = new ServicioApartado())
                Apartado.ActualizarApartados(ActApartado);
        }
        public void EliminarApartados(string id)
        {
            using (ServicioApartado Apartado = new ServicioApartado())
                Apartado.EliminarApartados(id);
        }

    }
}
