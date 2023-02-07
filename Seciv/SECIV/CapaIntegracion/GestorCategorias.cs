using CapaLogica.LogicaNegocio;
using CapaLogica.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaIntegracion
{
    public class GestorCategorias : IDisposable
    {
        public GestorCategorias() { }
        public void Dispose()
        {
        }
        public void InsertarCategoria(string cat_nombre, string cat_descripcion)
        {
            Categoria nuevaCategoria = new Categoria(cat_nombre, cat_descripcion);

            using (ServicioCategoria Categoria = new ServicioCategoria())
                Categoria.InsertarCategoria(nuevaCategoria);
        }

        public List<Categoria> ListarCategorias()
        {
            using (ServicioCategoria Categoria = new ServicioCategoria())
            {
                return Categoria.ListarCategorias();
            }
        }

        public void ActualizarCategoria(string id, string cat_nombre, string cat_descripcion)
        {
            Categoria ActCategoria = new Categoria(id,  cat_nombre,  cat_descripcion);
            using (ServicioCategoria Categoria = new ServicioCategoria())
                Categoria.ActualizarCategoria(ActCategoria);
        }
        public void EliminarCategoria(string id)
        {
            using (ServicioCategoria Categoria = new ServicioCategoria())
                Categoria.EliminarCategoria(id);
        }


    }
}
