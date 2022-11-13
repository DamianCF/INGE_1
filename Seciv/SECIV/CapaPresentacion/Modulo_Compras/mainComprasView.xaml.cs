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

namespace CapaPresentacion.Modulo_Compras
{
    /// <summary>
    /// Interaction logic for mainComprasView.xaml
    /// </summary>
    public partial class mainComprasView : Page
    {
        public mainComprasView()
        {
            InitializeComponent();
            ListarCompras();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorCompras Compra = new GestorCompras())
            {
                Compra.InsertarCompra(txtCodigo.Text, Double.Parse(txtMonto.Text), txtFecha.Text, txtEstado.Text);
            }
            ListarCompras();
        }

        public void ListarCompras()
        {
            using (GestorCompras Compra = new GestorCompras())
            {
                dgridCompras.ItemsSource = Compra.ListarCompras();

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
                txtCodigo.Text = compra.com_codigo;
                txtMonto.Text = compra.com_monto.ToString();
                txtFecha.Text = compra.com_fecha;
                txtEstado.Text = compra.com_estado;
           }
        }

        private void dgridCompras_MouseUp(object sender, MouseButtonEventArgs e)
        {
            cargarTxts();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorCompras Compra = new GestorCompras())
            {
                Compra.ActualizarCompra(txtId.Text, txtCodigo.Text, Double.Parse(txtMonto.Text), txtFecha.Text, txtEstado.Text);
            }
            ListarCompras();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorCompras Compra = new GestorCompras())
            {
                if (txtId.Text != "")
                {
                    Compra.EliminarCompra(txtId.Text);
                }
            }
            ListarCompras();
        }

        private void LimpiarTxts()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtMonto.Text = "";
            txtFecha.Text = "";
            txtEstado.Text = "";
        }
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarTxts();
        }

        private void dgridCompras_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "com_estado" ? Visibility.Hidden : Visibility.Visible;
            e.Cancel = e.PropertyName == "com_codigo";
        }
    }
}
