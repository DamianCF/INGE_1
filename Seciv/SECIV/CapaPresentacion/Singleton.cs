using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class Singleton
    {

        // clase usada para pasar informacion entre pantallas
            private static Singleton instance = null;
            public string estadoUsuario = "";
            public List<Venta> ventas = null;
            public List<Compra> compras = null;

        protected Singleton()
            {
                estadoUsuario = "A";
                ventas = null;
                compras = null;
        }

        public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }
    }
}
