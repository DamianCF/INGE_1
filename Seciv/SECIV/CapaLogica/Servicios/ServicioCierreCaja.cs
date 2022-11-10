using CapaConexion;
using CapaLogica.LogicaNegocio;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.Servicios
{
    public class ServicioCierreCaja: IDisposable
    {
        public ServicioCierreCaja()
        {

        }
        public void Dispose()
        {

        }

        static IMongoCollection<CierreCaja> collection = conexion.getDataBase().GetCollection<CierreCaja>("CierreCaja");

        public void InsertarCierreCaja(CierreCaja c)
        {
            collection.InsertOne(c);
        }
        public List<CierreCaja> ListarCierreCaja()
        {
            return collection.AsQueryable().ToList<CierreCaja>(); // collection.Find(x => true).ToList(); 
        }
        public void ActualizarCierreCaja(CierreCaja c)
        {
            collection.ReplaceOne(x => x.id == c.id, c);
        }
        public void EliminarCierreCaja(string id)
        {
            collection.DeleteOne(x => x.id == id);
        }


    }
}
