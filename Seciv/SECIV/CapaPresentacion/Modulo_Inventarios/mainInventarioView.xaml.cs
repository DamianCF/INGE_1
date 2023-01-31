using CapaIntegracion;
using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CapaPresentacion.Modulo_Inventarios
{
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

        //Metodo que controla los tipos de datos que se ingresan en los textbox
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        #region Productos
        public void InsertarProducto()
        {
            using (GestorProductos Producto = new GestorProductos())
            {

                    Producto.InsertarProducto(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, Double.Parse(txtPrecioCost.Text), Double.Parse(txtUtilidad.Text), Double.Parse(txtPrecioVenta.Text), Double.Parse(txtIVA.Text),
                        Int32.Parse(txtCantidad.Text),cmbCategoria.Text, txtDecoracion.Text);
                //alrtCampos.Visibility = Visibility.Collapsed;
                //alrtConfirmacion.Visibility = Visibility.Visible;
                //nmAlerta.Text = "Compra registrada con exito";
            }
            
        }
        
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            InsertarProducto();
            actualizar  = true;
            ListarProductos();
        }
        public void ListarProductos()
        {
            if (actualizar)
            {
                using (GestorProductos Producto = new GestorProductos())
                {
                    Singleton.Instance.productos = Producto.ListarProductos();
                    dgridInventarios.ItemsSource = Singleton.Instance.productos;

                }
                actualizar = false;
            }
            else
            {
                dgridInventarios.ItemsSource = Singleton.Instance.productos;
            }
            //cargarTxts();
        }
        private void cargarTxts()
        {

            //if (dgridInventarios.Items.Count > 0)
            //{
            //    Producto producto = (Producto)dgridInventarios.SelectedItem;
            //    if (producto == null)
            //    {
            //        producto = (Producto)dgridInventarios.Items.GetItemAt(0);
            //    }
            //    //txtId.Text = producto.id;
            //    txtCodigo.Text = producto.prd_codigo;
            //    txtNombre.Text = producto.prd_nombre;
            //    txtDescripcion.Text = producto.prd_descripcion;
            //    txtPrecioCost.Text = producto.prd_precioCosto.ToString();
            //    txtUtilidad.Text = producto.prd_utilidad.ToString();
            //    txtPrecioVenta.Text = producto.prd_precioVenta.ToString();
            //    //txtIVA.Text = producto.prd_impuesto.ToString();
            //    //txtCantidad.Text = producto.prd_cantidad.ToString();
            //    cmbCategoria.Text = producto.prd_idCategoria;
            //    txtDecoracion.Text = producto.prd_idDecoracion;
            //}
        }

        #endregion

        #region Categorias

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
            //cargarTxts();
        }
        private void btnCategorias_Click(object sender, RoutedEventArgs e)
        {
            GridProducto.Visibility= Visibility.Collapsed;
            GridCategorias.Visibility= Visibility.Visible;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridCategorias.Visibility= Visibility.Collapsed;
            GridProducto.Visibility= Visibility.Visible;
            //btnAplicar.IsEnabled = false;
            //BtnEliminar.IsEnabled = false;
            //btnAplicar.IsEnabled = false;
            //LimpiarTxts();
        }

        private void dgridInventarios_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "prd_idCategoria" ? Visibility.Hidden : Visibility.Visible;
            e.Column.Visibility = e.PropertyName == "prd_idDecoracion" ? Visibility.Hidden : Visibility.Visible;

        }

        private void dgridInventarios_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //cargarTxts();

            btnEditar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
        }

        private void btnActualizarr_Click(object sender, RoutedEventArgs e)
        {
            actualizar |= true;
            ListarProductos();
        }

        private void dgridCategorias_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "cat_estado" ? Visibility.Hidden : Visibility.Visible;
        }

        private void dgridCategorias_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //cargarTxts();

            btnEditarCategoria.IsEnabled = true;
            BtnEliminarCategoria.IsEnabled = true;
        }

        #endregion

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            btnAplicar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnAplicar.IsEnabled = true;
        }
    }
}
