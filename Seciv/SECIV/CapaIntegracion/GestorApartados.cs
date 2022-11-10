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

        public void InsertarApartados(string codigo, string nomCliente, string productos, string fecha, string fechaLimite, string abonos, string saldos, string estado)
        {
            Apartado nuevoApartado = new Apartado(codigo, nomCliente, productos, fecha, fechaLimite, abonos, saldos, estado);

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

        public void ActualizarApartados(string id, string codigo, string nomCliente, string productos, string fecha, string fechaLimite, string abonos, string saldos, string estado)
        {
            Apartado nuevoApartado = new Apartado(id, codigo, nomCliente, productos, fecha, fechaLimite, abonos, saldos, estado);
            using (ServicioApartado Apartado = new ServicioApartado())
                Apartado.ActualizarApartados(nuevoApartado);
        }
        public void EliminarApartados(string id)
        {
            using (ServicioApartado Apartado = new ServicioApartado())
                Apartado.EliminarApartados(id);
        }

    }
}
