using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Models;
using SistemaMatricula.CapaIntegracion;
using SistemaMatricula.CapaPresentacion.Validar_TextBox;
using MongoDB.Driver;

namespace CapaPresentacion
{
    public partial class formProductos : Form
    {
        string idProducto = "";
        Conexion conexion = new Conexion();
        List<Producto> lst;

        public formProductos()
        {
            InitializeComponent();
        }

        private void formProducto_Load(object sender, EventArgs e)
        {
            dgvProductos.Columns.Add("id", "ID");
            dgvProductos.Columns["id"].Visible = false;
            dgvProductos.Columns.Add("prd_codigo", "Codigo Producto");
            this.dgvProductos.Columns["prd_codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_nombre", "Nombre");
            this.dgvProductos.Columns["prd_nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_descripcion", "Descripcion");
            this.dgvProductos.Columns["prd_descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_precioCosto", "Precio Costo");
            this.dgvProductos.Columns["prd_precioCosto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_utilidad", "Utilidad");
            this.dgvProductos.Columns["prd_utilidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_precioVenta", "Precio Venta");
            this.dgvProductos.Columns["prd_precioVenta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_porcIVA", "Porcentaje IVA");
            this.dgvProductos.Columns["prd_porcIVA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_cantStock", "Cantidad");
            this.dgvProductos.Columns["prd_cantStock"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_idCategoria", "Categoria");
            this.dgvProductos.Columns["prd_idCategoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvProductos.Columns.Add("prd_idDecoracion", "Decoracion");
            this.dgvProductos.Columns["prd_idDecoracion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CargarGridProducto();
        }




        private void LimpiarTxts()
        {
            idProducto = "";
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtUtilidad.Clear();
            txtCantidadStock.Clear();
        }

        private void CargarGridProducto()
        {
            dgvProductos.Rows.Clear();
            var comprasDB = conexion.getProductos();
            lst = comprasDB.Find(d => true).ToList();
            foreach (Producto compra in lst)
            {
                dgvProductos.Rows.Add(compra.id.ToString(), compra.Codigo_Producto.ToString(), compra.Nombre_Producto.ToString(), compra.Descripcion_Producto.ToString(),
                    compra.Precio_Costo.ToString(), compra.Utilidad.ToString(), compra.Precio_Venta.ToString(), compra.Porcentaje_IVA.ToString(), compra.Cantidad_Stock.ToString(), compra.id_Categoria.ToString(), compra.id_Decoracion.ToString());
            }
        }


        private void dgvProductoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numFila = dgvProductos.CurrentCell.RowIndex;

            if (dgvProductos.CurrentCell.Value != null)
            {

                idProducto = this.dgvProductos[0, numFila].Value.ToString();

                string codProducto = this.dgvProductos[1, numFila].Value.ToString();
                txtCodigo.Text = codProducto;

                string Nombre = this.dgvProductos[2, numFila].Value.ToString();
                txtNombre.Text = Nombre;

                string Descripcion = this.dgvProductos[3, numFila].Value.ToString();
                txtDescripcion.Text = Descripcion;

                string PrecioCosto = this.dgvProductos[4, numFila].Value.ToString();
                txtPrecioCosto.Text = PrecioCosto;

                string Utilidad = this.dgvProductos[5, numFila].Value.ToString();
                txtUtilidad.Text = Utilidad;

                string PrecioVenta = this.dgvProductos[6, numFila].Value.ToString();
                txtPrecioVenta.Text = PrecioVenta;

                string CantidadStock = this.dgvProductos[7, numFila].Value.ToString();
                txtCantidadStock.Text = CantidadStock;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var categoriasDB = conexion.getProductos();
            var compra = new Producto()
            {
                id = idProducto,
                Codigo_Producto = txtCodigo.Text.ToString(),
                Nombre_Producto = txtNombre.Text,
                Descripcion_Producto = txtDescripcion.Text.ToString(),
                Precio_Costo = int.Parse(txtPrecioCosto.Text.ToString()),
                Porcentaje_IVA = 13,
                Utilidad = int.Parse(txtUtilidad.Text.ToString()),
                Precio_Venta = int.Parse(txtPrecioVenta.Text.ToString()),
                Cantidad_Stock = int.Parse(txtCantidadStock.Text.ToString()),
                id_Categoria = "63519807e54e48b2009f24f7",
                id_Decoracion = "6351982ee54e48b2009f24f8"
            };
            categoriasDB.ReplaceOne(d => d.id == idProducto, compra);
            CargarGridProducto();
            LimpiarTxts();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxts();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var categoriasDB = conexion.getProductos();
            categoriasDB.DeleteOne(d => d.id == idProducto);
            CargarGridProducto();
            LimpiarTxts();
        }
        private void txtProducto_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCantidadStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            var categoriasDB = conexion.getProductos();
            var compra = new Producto()
            {
                Codigo_Producto = txtCodigo.Text.ToString(),
                Nombre_Producto = txtNombre.Text,
                Descripcion_Producto = txtDescripcion.Text.ToString(),
                Precio_Costo = int.Parse(txtPrecioCosto.Text.ToString()),
                Utilidad = int.Parse(txtUtilidad.Text.ToString()),
                Precio_Venta = int.Parse(txtPrecioVenta.Text.ToString()),
                Porcentaje_IVA = 13,
                Cantidad_Stock = int.Parse(txtCantidadStock.Text.ToString()),
                id_Categoria = "63519807e54e48b2009f24f7",
                id_Decoracion = "6351982ee54e48b2009f24f8"
            };
            categoriasDB.InsertOne(compra);
            CargarGridProducto();
            LimpiarTxts();

        }
    }
}