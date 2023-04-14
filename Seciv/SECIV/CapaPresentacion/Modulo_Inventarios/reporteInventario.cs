using MongoDB.Bson;
using MongoDB.Driver;
using System.Data;

namespace CapaPresentacion.Modulo_Inventarios
{
    public class reporteInventario : DataSet
    {

        public reporteInventario()
        {

            MongoClient cliente = new MongoClient("mongodb+srv://sys:sys@inge01.actyoaw.mongodb.net/SECIV?retryWrites=true&w=majority");
            IMongoDatabase baseDeDatos = cliente.GetDatabase("SECIV");
            IMongoCollection<BsonDocument> coleccion = baseDeDatos.GetCollection<BsonDocument>("SECIV_productos");

            DataTable dataTable = new DataTable("Usuarios");

            dataTable.Columns.Add("_id", typeof(ObjectId));
            dataTable.Columns.Add("prd_codigo", typeof(string));
            dataTable.Columns.Add("prd_nombre", typeof(string));
            dataTable.Columns.Add("prd_descripcion", typeof(string));
            dataTable.Columns.Add("prd_precioCosto", typeof(double));
            dataTable.Columns.Add("prd_utilidad", typeof(double));
            dataTable.Columns.Add("prd_precioVenta", typeof(double));
            dataTable.Columns.Add("prd_porcIVA", typeof(double));
            dataTable.Columns.Add("prd_cantStock", typeof(int));
            dataTable.Columns.Add("prd_idCategoria", typeof(ObjectId));
            dataTable.Columns.Add("prd_idDecoracion", typeof(string));

            var resultados = coleccion.Find(new BsonDocument()).ToList();
            foreach (var documento in resultados)
            {
                dataTable.Rows.Add(
                    documento.GetValue("_id").AsObjectId,
                    documento.GetValue("prd_codigo").AsString,
                    documento.GetValue("prd_nombre").AsString,
                    documento.GetValue("prd_descripcion").AsString,
                    documento.GetValue("prd_precioCosto").AsDouble,
                    documento.GetValue("prd_utilidad").AsDouble,
                    documento.GetValue("prd_precioVenta").AsDouble,
                    documento.GetValue("prd_porcIVA").AsDouble,
                    documento.GetValue("prd_cantStock").AsInt32,
                    documento.GetValue("prd_idCategoria").AsObjectId,
                    documento.GetValue("prd_idDecoracion").AsString
                );
            }

            Tables.Add(dataTable);
        }
    }
}