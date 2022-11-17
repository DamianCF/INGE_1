using CapaIntegracion;
using CapaLogica.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
    /// <summary>
    /// Lógica de interacción para mainInventarioView.xaml
    /// </summary>
    public partial class mainInventarioView : Page
    {
        public mainInventarioView()
        {
            InitializeComponent();
            ListarProductos();
            btnElimina.IsEnabled = false;
            btnEdita.IsEnabled = false;
        }

        public void ListarProducto()
        {
            using (GestorProductos Producto = new GestorProductos())
            {
                dgridInventarios.ItemsSource = Producto.ListarProductos();

            }
            cargarTxts();
        }
        
        public void InsertarProducto()
        {
            using (GestorProductos Producto = new GestorProductos())
            {
                string a = cmbCategoria.Text;
                {
                    Console.WriteLine(a);
                    Producto.InsertarProducto(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, Double.Parse(txtPrecioCost.Text), Double.Parse(txtUtilidad.Text), Double.Parse(txtPrecioVenta.Text), Double.Parse(txtIVA.Text),
                        Int32.Parse(txtCantidad.Text),cmbCategoria.Text, txtDecoracion.Text);
                }
            }
            
        }

        public void ListarProductos()
        {
            using (GestorProductos Productos = new GestorProductos())
            {
                dgridInventarios.ItemsSource = Productos.ListarProductos();

            }
            cargarTxts();
        }


        private void cargarTxts()
        {
            if (dgridInventarios.Items.Count > 0)
            {
                Producto producto = (Producto)dgridInventarios.SelectedItem;
                if (producto == null)
                {
                    producto = (Producto)dgridInventarios.Items.GetItemAt(0);
                }
                txtCodigo.Text = producto.prd_codigo;
                txtNombre.Text = producto.prd_nombre;
                txtDescripcion.Text = producto.prd_descripcion;
                txtPrecioCost.Text = producto.prd_precioCosto.ToString();
                txtUtilidad.Text = producto.prd_utilidad.ToString();
                txtPrecioVenta.Text = producto.prd_precioVenta.ToString();
                txtIVA.Text = producto.prd_porcIVA.ToString();
                txtCantidad.Text = producto.prd_cantStock.ToString();
                cmbCategoria.Text = producto.prd_idCategoria;
                txtDecoracion.Text = producto.prd_idDecoracion;
            
            }
        }
        
        private void dgridInventarios_MouseUp(object sender, MouseButtonEventArgs e)
        {
            cargarTxts();

            btnEdita.IsEnabled = true;
            btnElimina.IsEnabled = true;

        }
        
        private void LimpiarTxts()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCost.Text = "";
            txtUtilidad.Text = "";
            txtPrecioVenta.Text = "";
            txtIVA.Text = "";
            txtCantidad.Text = "";
            cmbCategoria.Text = "";
            txtDecoracion.Text = "";
        }
    
        private void dgridInventarios_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
        }
        



        
        //-----------------------------Botones en main de Inventario------------------------------------
        private void btnAgrega_Click(object sender, RoutedEventArgs e)
        {

            btnAplicar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnAplicar.IsEnabled =false;
            LimpiarTxts();
        }

        private void btnElimina_Click(object sender, RoutedEventArgs e)
        {
            using (GestorProductos Producto = new GestorProductos())
            {
                if(txtId.Text !="")
                {
                    Producto.EliminarProducto(txtId.Text);
                }
            }
            ListarProducto();
        }


        //-----------------------Botones en el drawer de Inventarios--------------------------------------------
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDescripcion.Text != "" && txtPrecioCost.Text != "" && txtUtilidad.Text != "" && txtPrecioVenta.Text != "" && txtIVA.Text != "" && txtCantidad.Text != "" && cmbCategoria.Text != "" && txtDecoracion.Text != "")
            {
                InsertarProducto();
                ListarProductos();
                LimpiarTxts();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
            }

        }

        private void btnAplicar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorProductos Producto = new GestorProductos())
            {
                Producto.ActualizarProducto(txtId.Text, txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, Double.Parse(txtPrecioCost.Text), Double.Parse(txtUtilidad.Text), Double.Parse(txtPrecioVenta.Text), Double.Parse(txtIVA.Text),
                    Int32.Parse(txtCantidad.Text), cmbCategoria.Text, txtDecoracion.Text);
            }
            ListarProductos();
        }

        private void DrawerHost_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DrawerHost.RightDrawerCloseOnClickAway = false;
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarTxts();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorProductos Producto = new GestorProductos())
            {
                if (txtId.Text != "")
                {
                    Producto.EliminarProducto(txtId.Text);
                }
            }
            ListarProducto();
        }

        private void btnEdita_Click(object sender, RoutedEventArgs e)
        {
            btnAplicar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnAplicar.IsEnabled = true;

        }


    }
}
