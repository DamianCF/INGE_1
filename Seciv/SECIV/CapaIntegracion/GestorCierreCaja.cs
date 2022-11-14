using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorCierreCaja: IDisposable
    {

        public GestorCierreCaja()
        {

        }

        public void Dispose()
        {

        }

        public void InsertarCierreCaja(Double cierreCompras, Double cierreVentas, Double saldoFinal, string estado, string fecha)
        {
            CierreCaja nuevoCierre = new CierreCaja(cierreCompras, cierreVentas, saldoFinal, estado, fecha);

            using (ServicioCierreCaja elCierre = new ServicioCierreCaja())
                elCierre.InsertarCierreCaja(nuevoCierre);
        }

        public List<CierreCaja> ListarCierreCaja()
        {
            using (ServicioCierreCaja Cierre = new ServicioCierreCaja())
            {
                return Cierre.ListarCierreCaja();
            }
        }

        public void ActualizarCierreCaja(string id, Double cierreCompras, Double cierreVentas, Double saldoFinal, string estado, string fecha)
        {
            CierreCaja nuevoCierre = new CierreCaja(id, cierreCompras, cierreVentas, saldoFinal, estado, fecha);
            using (ServicioCierreCaja Cierre = new ServicioCierreCaja())
                Cierre.ActualizarCierreCaja(nuevoCierre);
        }

        public void EliminarCierreCaja(string id)
        {
            using (ServicioCierreCaja Cierre = new ServicioCierreCaja())
                Cierre.EliminarCierreCaja(id);
        }



    }
}
