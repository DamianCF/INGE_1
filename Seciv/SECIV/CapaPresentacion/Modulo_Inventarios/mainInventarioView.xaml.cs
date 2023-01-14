using CapaIntegracion;
using System;
using System.Collections.Generic;
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
        public bool actualizar = false;
        public mainInventarioView()
        {
            InitializeComponent();
            ListarProductos();
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

        private void btnCategorias_Click(object sender, RoutedEventArgs e)
        {
            GridProducto.Visibility= Visibility.Collapsed;
            GridCategorias.Visibility= Visibility.Visible;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridCategorias.Visibility= Visibility.Collapsed;
            GridProducto.Visibility= Visibility.Visible;
        }
    }
}
