using CapaIntegracion;
using CapaLogica.LogicaNegocio;
using MongoDB.Bson;
using MongoDB.Driver;
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


namespace CapaPresentacion
{

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            conectarBD();
        }

        private void conectarBD()
        {
            //Console.WriteLine(Singleton.Instance.estadoUsuario);
            //Singleton.Instance.estadoUsuario = "A";

            using (GestorVentas Ventas = new GestorVentas())// precargar ventas
            {
                Singleton.Instance.ventas = Ventas.ListarVentas();
            }
            using (GestorCompras Compra = new GestorCompras())
            {
                Singleton.Instance.compras = Compra.ListarCompras();
            }
            using (GestorProductos Producto = new GestorProductos())
            {
                Singleton.Instance.productos = Producto.LookupProductoCategoria();//Producto.ListarProductos();
            }
            using (GestorUsuarios Usuario = new GestorUsuarios())
            {
                Singleton.Instance.usuarios = Usuario.ListarUsuarios();
                using (GestorCategorias Categoria = new GestorCategorias())
                {
                    Singleton.Instance.categorias = Categoria.ListarCategorias();
                }
                pgrsBar.IsIndeterminate = false;

                pgrsBar.Visibility = Visibility.Hidden;
            }
        }

        private void btnCompras_Click(object sender, RoutedEventArgs e)
        {
            btnCompras.Foreground = Brushes.MidnightBlue;
            btnVentas.Foreground = Brushes.White;
            btnInventario.Foreground = Brushes.White;
            btnReportes.Foreground = Brushes.White;
            btnApartados.Foreground = Brushes.White;
            Grid.Content = new Modulo_Compras.mainComprasView();

        }

        private void btnInventario_Click(object sender, RoutedEventArgs e)
        {
            btnCompras.Foreground = Brushes.White;
            btnVentas.Foreground = Brushes.White;
            btnInventario.Foreground = Brushes.MidnightBlue;
            btnReportes.Foreground = Brushes.White;
            btnApartados.Foreground = Brushes.White;
            Grid.Content = new Modulo_Inventarios.mainInventarioView();
        }

        private void btnVentas_Click(object sender, RoutedEventArgs e)
        {
            btnCompras.Foreground = Brushes.White;
            btnVentas.Foreground = Brushes.MidnightBlue;
            btnInventario.Foreground = Brushes.White;
            btnReportes.Foreground = Brushes.White;
            btnApartados.Foreground = Brushes.White;
            Grid.Content = new Modulo_Ventas.mainVentasView();
        }

        private void btnContabilidad_Click(object sender, RoutedEventArgs e)
        {
            btnCompras.Foreground = Brushes.White;
            btnVentas.Foreground = Brushes.White;
            btnInventario.Foreground = Brushes.White;
            btnReportes.Foreground = Brushes.MidnightBlue;
            btnApartados.Foreground = Brushes.White;
            Grid.Content = new Modulo_Contabilidad.mainContabilidadView();
        }

        private void btnApartados_Click(object sender, RoutedEventArgs e)
        {
            btnCompras.Foreground = Brushes.White;
            btnVentas.Foreground = Brushes.White;
            btnInventario.Foreground = Brushes.White;
            btnReportes.Foreground = Brushes.White;
            btnApartados.Foreground = Brushes.MidnightBlue;

        }

        public string randomCode()
        {
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var Charsarr = new char[8];
            var random = new Random();

            for (int i = 0; i < Charsarr.Length; i++)
            {
                Charsarr[i] = characters[random.Next(characters.Length)];
            }

            var resultString = new String(Charsarr);
            return resultString;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

