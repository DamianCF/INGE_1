using CapaIntegracion;
using CapaLogica.LogicaNegocio;
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
            ListarCompras();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorCompras laCompra = new GestorCompras())
            {
                laCompra.InsertarCompra(txtCodigo.Text, Double.Parse(txtMonto.Text), txtFecha.Text);
            }
            ListarCompras();
        }

        public void ListarCompras()
        {
            using (GestorCompras laCompra = new GestorCompras())
            {
                dgridCompras.ItemsSource = laCompra.ListarCompras();
            }
            cargarTxts();
        }

        private void cargarTxts()
        {
            if (dgridCompras.Items.Count > 0)
            {
                Compra compra = (Compra)dgridCompras.SelectedItem;
                if (compra == null)
                {
                    compra = (Compra)dgridCompras.Items.GetItemAt(0);
                }
                txtId.Text = compra.id;
                txtCodigo.Text = compra.Cod_Compra;
                txtMonto.Text = compra.Monto_Compra.ToString();
                txtFecha.Text = compra.Fecha_Compra;
            }
        }
        
        private void dgridCompras_MouseUp(object sender, MouseButtonEventArgs e)
        {
                cargarTxts();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
