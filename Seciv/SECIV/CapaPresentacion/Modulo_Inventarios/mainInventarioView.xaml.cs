using CapaIntegracion;
using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CapaPresentacion.Modulo_Inventarios
{
    /// <summary>
    /// Operaciones Crud por completar Categorias:
    /// listar OK
    /// agregar OK
    /// editar OK
    /// limpiar OK
    /// eliminar OK
    /// Buscar NO
    /// Alertas NO
    /// Operaciones Crud por completar Productos:
    /// listar OK
    /// agregar OK 
    /// editar OK
    /// limpiar OK
    /// eliminar OK
    /// Buscar NO
    /// Alertas (Eliminar SI)   (Agregado NO)
    /// Ocultar idCategorias en listado NO
    /// </summary>

    public partial class mainInventarioView : Page
    {
        public bool actualizar = false;
        public mainInventarioView()
        {
            InitializeComponent();
            ListarProductos();
            ListarCategorias();
            btnEditar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnEditarCategoria.IsEnabled = false;
            BtnEliminarCategoria.IsEnabled = false;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)  //Metodo que controla los tipos de datos que se ingresan en los textbox
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        #region PRODUCTOS ----------------------------------------------------------------------------------------

        private void dgridInventarios_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "prd_idCategoria" ? Visibility.Hidden : Visibility.Visible;
            e.Column.Visibility = e.PropertyName == "prd_idDecoracion" ? Visibility.Hidden : Visibility.Visible;
        }

        private void dgridInventarios_MouseUp(object sender, MouseButtonEventArgs e)
        {
            cargarTxtsProducto();
            btnEditar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
        }

        //Listar los productos
        public void ListarProductos()
        {
            if (actualizar)
            {
                using (GestorProductos Producto = new GestorProductos())
                {
                    Singleton.Instance.productos = Producto.LookupProductoCategoria();//Producto.ListarProductos();
                    dgridInventarios.ItemsSource = Singleton.Instance.productos;
                }
                actualizar = false;
            }
            else
            {
                dgridInventarios.ItemsSource = Singleton.Instance.productos;
            }
            cargarTxtsProducto();
        }

        //Insertar un producto
        public void InsertarProducto()
        {
            ItemComboxCategoria item = cmbCategoria.SelectedItem as ItemComboxCategoria;//Console.WriteLine(item.cat_nombre + "   " + item.id);

            using (GestorProductos Producto = new GestorProductos())
            {
                Producto.InsertarProducto(Int32.Parse(txtCantidad.Text), txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, Double.Parse(txtPrecioCost.Text), Double.Parse(txtUtilidad.Text), Double.Parse(txtPrecioVenta.Text), Double.Parse(txtIVA.Text),
                     item.id, txtDecoracion.Text);
                alrtCampos.Visibility = Visibility.Collapsed;
                alrtConfirmacion.Visibility = Visibility.Visible;
                nmAlerta.Text = "Producto registrado con exito";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridCategorias.Visibility = Visibility.Collapsed;
            GridProducto.Visibility = Visibility.Visible;
            btnAplicar.IsEnabled = false;
            BtnEliminar.IsEnabled = false;
            btnAplicar.IsEnabled = false;
            LimpiarTxtsProducto();
        }
        private void btnAgregar_Click_1(object sender, RoutedEventArgs e)
        {
            InsertarProducto();
            actualizar = true;
            ListarProductos();
            LimpiarTxtsProducto();
        }

        //Limpiar Texto Procucto
        private void LimpiarTxtsProducto()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecioCost.Text = "";
            txtUtilidad.Text = "";
            txtPrecioVenta.Text = "";
            txtCantidad.Text = "";
            txtDecoracion.Text = "";
            cargarCategoriasCmBox();
            cmbCategoria.SelectedIndex = 0;
            txtDescripcion.Text = "";
            txtIVA.Text = "";
        }
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarTxtsProducto();
        }

        //Actualizar la lista de productos
        private void btnActualizarr_Click(object sender, RoutedEventArgs e)
        {
            actualizar = true;
            ListarProductos();
        }

        //Cargar los datos del producto seleccionado
        private void cargarTxtsProducto()
        {
            if (dgridInventarios.Items.Count > 0)
            {
                Producto produto = (Producto)dgridInventarios.SelectedItem;
                if (produto == null)
                {
                    produto = (Producto)dgridInventarios.Items.GetItemAt(0);
                }
                txtId.Text = produto.id;
                txtCodigo.Text = produto.prd_codigo.ToString();
                txtNombre.Text = produto.prd_nombre.ToString();
                txtPrecioCost.Text = produto.prd_precioCosto.ToString();
                txtUtilidad.Text = produto.prd_utilidad.ToString();
                txtPrecioVenta.Text = produto.prd_precioVenta.ToString();
                txtIVA.Text = produto.prd_porcIVA.ToString();
                txtCantidad.Text = produto.prd_cantStock.ToString();
                txtDecoracion.Text = produto.prd_idDecoracion.ToString();
                txtDescripcion.Text = produto.prd_descripcion.ToString();
                txtIdCategoria.Text = produto.prd_idCategoria.ToString();



            }
        }

        //Editar un producto Seleccionado
        private void btnEditar_Click(object sender, RoutedEventArgs e) // desplegar Panel Derecho para editar
        {
            GridCategorias.Visibility = Visibility.Collapsed;
            GridProducto.Visibility = Visibility.Visible;
            btnAplicar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnAplicar.IsEnabled = true;
            cargarTxtsProducto();

            actualizar = true;
            cargarCategoriasCmBox();

            // seleccionar el la categoria que posee el producto en el combobox en caso de existir
            foreach (ItemComboxCategoria categoria in cmbCategoria.ItemsSource)
            {
                if (categoria.id == txtIdCategoria.Text)
                {
                    cmbCategoria.SelectedItem = categoria;
                }
            }
        }
        private void btnAplicar_Click(object sender, RoutedEventArgs e)
        {
            ItemComboxCategoria item = cmbCategoria.SelectedItem as ItemComboxCategoria;
            using (GestorProductos Compra = new GestorProductos())
            {
                Compra.ActualizarProducto(txtId.Text, txtCodigo.Text, txtNombre.Text, txtDescripcion.Text,
                    Double.Parse(txtPrecioCost.Text), Double.Parse(txtUtilidad.Text), Double.Parse(txtPrecioVenta.Text),
                    Double.Parse(txtIVA.Text), int.Parse(txtCantidad.Text), item.id, txtDecoracion.Text);
                alrtCampos.Visibility = Visibility.Collapsed;
                alrtConfirmacion.Visibility = Visibility.Visible;
                nmAlerta.Text = "Cambios aplicados correctamente";
            }
            actualizar = true;
            ListarProductos();
        }

        //Eliminar un producto
        public void eliminarProducto()
        {
            using (GestorProductos Producto = new GestorProductos())
            {
                if (txtId.Text != "")
                {
                    Producto.EliminarProducto(txtId.Text);
                }
            }
            LimpiarTxtsProducto();
            actualizar = true;
            ListarProductos();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            eliminarProducto();
        }

        #endregion

        #region CATEGORIAS -------------------------------------------------------------------------------

        private void btnCategorias_Click(object sender, RoutedEventArgs e)
        {
            GridProducto.Visibility = Visibility.Collapsed;
            GridCategorias.Visibility = Visibility.Visible;
        }

        private void dgridCategorias_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
        }

        private void dgridCategorias_MouseUp(object sender, MouseButtonEventArgs e)
        {
            cargarTxtsCategoria();
            btnEditarCategoria.IsEnabled = true;
            BtnEliminarCategoria.IsEnabled = true;
        }

        //Cargar Campos categoria
        private void cargarTxtsCategoria()
        {
            if (dgridCategorias.Items.Count > 0)
            {
                Categoria categoria = (Categoria)dgridCategorias.SelectedItem;
                if (categoria == null)
                {
                    categoria = (Categoria)dgridCategorias.Items.GetItemAt(0);
                }
                txtIdCategoria.Text = categoria.id;
                txtdescCategoria.Text = categoria.cat_descripcion.ToString();
                txtNomCategoria.Text = categoria.cat_nombre.ToString();
            }
        }

        //Limpiar Campos
        private void LimpiarTxtsCategoria()
        {
            txtIdCategoria.Text = "";
            txtNomCategoria.Text = "";
            txtdescCategoria.Text = "";
        }
        private void btnLimpiarCategoria_Click(object sender, RoutedEventArgs e)
        {
            LimpiarTxtsCategoria();
        }

        //Listar Categorias
        public void ListarCategorias()
        {
            if (actualizar)
            {
                using (GestorCategorias Categoria = new GestorCategorias())
                {
                    Singleton.Instance.categorias = Categoria.ListarCategorias();
                    dgridCategorias.ItemsSource = Singleton.Instance.categorias;

                }
                actualizar = false;
            }
            else
            {
                dgridCategorias.ItemsSource = Singleton.Instance.categorias;
            }
            cargarTxtsCategoria();
        }

        //Listar Categorias en el ComboBox 
        public void cargarCategoriasCmBox()
        {
            //cmbCategoria.Items.Clear();
            List<Categoria> categoriasAUX = new List<Categoria>();
            List<ItemComboxCategoria> itemsCategorias = new List<ItemComboxCategoria>();

            if (actualizar)
            {
                using (GestorCategorias Categoria = new GestorCategorias())
                {
                    Singleton.Instance.categorias = Categoria.ListarCategorias();
                    categoriasAUX = Singleton.Instance.categorias;

                }
                actualizar = false;
            }
            else
            {
                categoriasAUX = Singleton.Instance.categorias;
            }

            foreach (Categoria categoria in categoriasAUX)
            {
                itemsCategorias.Add(new ItemComboxCategoria(categoria.id, categoria.cat_nombre, categoria.cat_descripcion));
            }
            cmbCategoria.ItemsSource = itemsCategorias;
        }

        //Agregar Categoria
        private void InsertarCategoria()
        {
            using (GestorCategorias Categoria = new GestorCategorias())
            {
                Categoria.InsertarCategoria(txtNomCategoria.Text, txtdescCategoria.Text);
                alrtCampos.Visibility = Visibility.Collapsed;
                alrtConfirmacion.Visibility = Visibility.Visible;
                nmAlerta.Text = "Categoria registrada con exito";
            }
        }
        private void btnAgregarCategoria_Click(object sender, RoutedEventArgs e)
        {
            InsertarCategoria();
            actualizar = true;
            ListarCategorias();
            LimpiarTxtsCategoria();
        }

        //Editar Categoria
        private void btnEditarCategoria_Click(object sender, RoutedEventArgs e)
        {
            using (GestorCategorias Categoria = new GestorCategorias())
            {
                Categoria.ActualizarCategoria(txtIdCategoria.Text, txtNomCategoria.Text, txtdescCategoria.Text);
                alrtCampos.Visibility = Visibility.Collapsed;
                alrtConfirmacion.Visibility = Visibility.Visible;
                nmAlerta.Text = "Cambios aplicados correctamente";
            }
            actualizar = true;
            ListarCategorias();
        }

        //Eliminar Categoria
        private void BtnEliminarCategoria_Click(object sender, RoutedEventArgs e)
        {
            using (GestorCategorias Categoria = new GestorCategorias())
            {
                if (txtId.Text != "")
                {
                    Categoria.EliminarCategoria(txtIdCategoria.Text);
                }
            }
            LimpiarTxtsCategoria();
            actualizar = true;
            ListarCategorias();
        }

        private void cmbCategoria_DropDownClosed(object sender, EventArgs e) //
        {


            ////// seleccionar el la categoria que posee el producto en el combobox

            ////cmbCategoria.Items.ToString();
            //ItemComboxCategoria item = cmbCategoria.SelectedItem as ItemComboxCategoria;
            //Console.WriteLine(item.cat_nombre + "   " + item.id);

        }
    }

    public class ItemComboxCategoria // clase axiliar para el combobox
    {
        public string id { get; set; }
        public string cat_nombre { get; set; }
        public string cat_descripcion { get; set; }

        public ItemComboxCategoria(string id, string cat_nombre, string cat_descripcion)
        {
            this.id = id;
            this.cat_nombre = cat_nombre;
            this.cat_descripcion = cat_descripcion;
        }
        public ItemComboxCategoria(string cat_nombre)
        {
            this.cat_nombre = cat_nombre;
        }
    }

    #endregion
}