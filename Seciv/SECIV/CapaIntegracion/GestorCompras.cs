using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaLogica.Servicios;

namespace CapaIntegracion
{
    public class GestorCompras : IDisposable
    {
        public GestorCompras()
        {

        }
        public void Dispose()
        {

        }
        public void InsertarCompra(string codigo, float monto, string fecha)
        {
            Compra nuevaCompra = new Compra(codigo,monto,fecha);

            using (ServicioCompra laCompra = new ServicioCompra())
            laCompra.InsertarCompra(nuevaCompra);
        }
    }
}
