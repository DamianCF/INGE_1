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

namespace CapaPresentacion.Modulo_Ventas
{
    /// <summary>
    /// Lógica de interacción para mainVentasView.xaml
    /// </summary>
    public partial class mainVentasView : Page
    {
        public bool actualizar = false;
        List<Producto> productos = new List<Producto>();

        public mainVentasView()
        {
            InitializeComponent();
            ListarVentas();
            ListarProductos();
            txtFecha.SelectedDate = DateTime.Now;
            btnEdita.IsEnabled = false;
            btnEliminar.IsEnabled = false;

            txtTotal.IsReadOnly = true;
            txtImpuesto.IsReadOnly = true;
            txtSubtotal.IsReadOnly = true;
        }
        

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
        public void insertarVenta()
        {

            using (GestorVentas Venta = new GestorVentas())
            {
                Venta.InsertarVenta(txtFecha.Text, txtCliente.Text,txtDescripcion.Text,txtDetalle.Text,
                    CbxPago.Text, Double.Parse(txtDescuento.Text), Double.Parse(txtImpuesto.Text), Double.Parse(txtSubtotal.Text), Double.Parse(txtTotal.Text), "A");
            }
        }

        // -------------------------------------Elementos que pertenecen al view principal--------------------------------------- //

        private void btnEliminar_Click_1(object sender, RoutedEventArgs e)
        {
            using (GestorVentas Venta = new GestorVentas())
            {
                if (txtId.Text != "")
                {
                    Venta.EliminarVenta(txtId.Text);
                }
            }
            actualizar = true;
            ListarVentas();
        }
        private void btnEdita_Click(object sender, RoutedEventArgs e)
        {
            btnAplicar.IsEnabled = true;
            BtnEliminar.IsEnabled = true;

            editScreen.Visibility = Visibility.Visible;
            nuevaScreeen.Visibility = Visibility.Collapsed;
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorVentas Venta = new GestorVentas())
            {
                Venta.ActualizarVentas(txtId.Text, int.Parse(txtCodigo.Text), txtFecha.Text, txtCliente.Text, txtDescripcion.Text, txtDetalle.Text,
                    CbxPago.Text, Double.Parse(txtDescuento.Text), Double.Parse(txtImpuesto.Text), Double.Parse(txtSubtotal.Text), Double.Parse(txtTotal.Text), "A");
            }
            actualizar = true;
            ListarVentas();
        }

        private void btnNuevaVenta_Click(object sender, RoutedEventArgs e)
        {
            editScreen.Visibility = Visibility.Collapsed;
            nuevaScreeen.Visibility = Visibility.Visible;
        }
        // ------------------------------------------------------------------------------------------------------------------------ //


        
        
        // -------------------------------------Elementos que pertenecen al view del drawer---------------------------------------- //
        
        ///INICIO EVENTOS DE BOTONES/
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtFecha.Text != "" && txtCliente.Text != "" && txtDescripcion.Text != "" && txtDetalle.Text != "" && CbxPago.Text != "" && txtDescuento.Text != "" && txtImpuesto.Text != "" && txtSubtotal.Text != "" && txtTotal.Text != "")
            {
                insertarVenta();
                actualizar = true;
                ListarVentas();
                LimpiarTxts();
            }
            else
            {
                alrtCampos.Visibility = Visibility.Visible;
                alrtConfirmacion.Visibility = Visibility.Collapsed;
                nmAlerta.Text = "Debe llenar todos los campos";
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorVentas Venta = new GestorVentas())
            {
                if (txtId.Text != "")
                {
                    Venta.EliminarVenta(txtId.Text);
                }
            }
            actualizar = true;
            ListarVentas();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarTxts();
        }

        private void btnActualizarr_Click(object sender, RoutedEventArgs e)
        {
            actualizar = true;
            ListarVentas();
        }

        private void btnAplicar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorVentas Venta = new GestorVentas())
            {
                Venta.ActualizarVentas(txtId.Text, int.Parse(txtCodigo.Text), txtFecha.Text, txtCliente.Text, txtDescripcion.Text, txtDetalle.Text,
                    CbxPago.Text, Double.Parse(txtDescuento.Text), Double.Parse(txtImpuesto.Text), Double.Parse(txtSubtotal.Text), Double.Parse(txtTotal.Text), "A");
                alrtCampos.Visibility = Visibility.Collapsed;
                alrtConfirmacion.Visibility = Visibility.Visible;
                nmAlerta.Text = "Cambios aplicados correctamente";
            }
            actualizar = true;
            ListarVentas();
        }

        private void btnAgregaProductosClick(object sender, RoutedEventArgs e)
        {
            Window form = new Window();
            form.Icon = new BitmapImage(new Uri("pack://application:,,,/Recursos/iconoAzul.ico"));
            form.ShowDialog(); 
        }
        //FIN EVENTOS DE BOTONES


        
        //INICIO METODOS DE CARGA Y LIMPIEZA
        private void dgridVentas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            cargarTxts();
            btnEdita.IsEnabled = true;
            btnEliminar.IsEnabled = true;
        }
        
        public void ListarVentas()
        {
            
            if (actualizar)
            {
                using (GestorVentas Ventas = new GestorVentas())
                {
                    Singleton.Instance.ventas = Ventas.ListarVentas();// actualizo ventas en singleton 
                    dgridVentas.ItemsSource = Singleton.Instance.ventas;// cargo ventas en pantalla
                }
                actualizar = false;
            }
            else
            {
                dgridVentas.ItemsSource = Singleton.Instance.ventas;
            }  
        }

        private void dgridCarrito_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

        }

        //PRODUCTOS
        private void dgridProductos_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            
            // hide the column
            if (   e.PropertyName == "prd_descripcion" 
                || e.PropertyName == "prd_precioCosto"
                || e.PropertyName == "prd_utilidad" 
                || e.PropertyName == "prd_porcIVA"
                || e.PropertyName == "prd_idDecoracion")
            {
                e.Column.Visibility = Visibility.Collapsed;
            }        
        }
        
        public void ListarProductos()
        { // carga los productos en el datagrid          
                using (GestorProductos Productos = new GestorProductos())
                {
                    dgridProductos.ItemsSource = Productos.ListarProductos();
                }
        }
        
        private void dgridProductos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {                 
            productos.Add((Producto)dgridProductos.SelectedItem);
        }

        private void btnAgregarCategoria1_Click(object sender, RoutedEventArgs e)
        {
            dgridCarrito.ItemsSource = null;
            dgridCarrito.ItemsSource = productos;
        }

        private void Btn_Agregar_Carrito_Click(object sender, RoutedEventArgs e)
        {
            productos.Add((Producto)dgridProductos.SelectedItem);
            dgridCarrito.ItemsSource = null;
            dgridCarrito.ItemsSource = productos;
        }

        private void cargarTxts()
        {
            if (dgridVentas.Items.Count > 0)
            {
                Venta Ventas = (Venta)dgridVentas.SelectedItem;
                if (Ventas == null)
                {
                    Ventas = (Venta)dgridVentas.Items.GetItemAt(0);
                }
                txtId.Text = Ventas.id;
                txtCodigo.Text = Ventas.vent_codigo.ToString();
                txtFecha.Text = Ventas.vent_fecha;
                txtCliente.Text = Ventas.vent_nombreComprador;
                txtDescripcion.Text = Ventas.vent_productos;
                txtDetalle.Text = Ventas.vent_detalle;
                CbxPago.SelectedItem = Ventas.vent_fecha;
                txtDescuento.Text = Ventas.vent_descuento.ToString();
                txtImpuesto.Text = Ventas.vent_impuesto.ToString();
                txtSubtotal.Text = Ventas.vent_subTotal.ToString();
                txtTotal.Text = Ventas.vent_total.ToString();
                CbxPago.Text = Ventas.vent_metodoPago;
            }
        }

        private void LimpiarTxts()
        {
            txtId.Text = "";
            txtCodigo.Text = "";
            txtFecha.Text = "";
            txtCliente.Text = "";
            txtDescripcion.Text = "";
            txtDetalle.Text = "";
            CbxPago.SelectedItem = "";
            txtDescuento.Text = "";
            txtImpuesto.Text = "";
            txtSubtotal.Text = "";
            txtTotal.Text = "";
            txtEstado.Text = "";
            
        }
     
        private void dgridVentas_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "vent_estado" ? Visibility.Hidden : Visibility.Visible;
            
        }
        //FIN METODOS DE CARGA Y LIMPIEZA


        //INICIO DE METODOS DE VALIDACION Y CALCULOS
        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            Int32 selectionStart = textBox.SelectionStart;
            Int32 selectionLength = textBox.SelectionLength;

            String newText = String.Empty;
            foreach (Char c in textBox.Text.ToCharArray())
            {
                if (Char.IsDigit(c) || Char.IsControl(c)) newText += c;
            }

            textBox.Text = newText;

            textBox.SelectionStart = selectionStart <= textBox.Text.Length ?
                selectionStart : textBox.Text.Length;

            var textoMonto = txtMonto.Text;
            if (textoMonto != "")
            {
                txtImpuesto.Text = (Double.Parse(txtMonto.Text) * 0.13).ToString();
                txtTotal.Text = txtMonto.Text;
                txtSubtotal.Text = (Double.Parse(txtMonto.Text) - Double.Parse(txtImpuesto.Text)).ToString();
            }
        }

        private void txtDescuento_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txtDescuento.Text == "")
            {
                txtDescuento.Text = "0";
            }
            var textoDescuento = txtDescuento.Text;
            
           // var descuento = Double.Parse(txtDescuento.Text)/100;
           // descuento = descuento * Double.Parse(txtMonto.Text);
            
            //if (textoDescuento != "")
           // {
            //    txtTotal.Text = (Double.Parse(txtMonto.Text) - descuento).ToString();  
           // }
        }

        private void btnEditarCarrito_Click(object sender, RoutedEventArgs e)
        {
           
            dgridCarrito.UnselectAllCells();
            
        }














        ////FIN DE METODOS DE VALIDACION Y CALCULOS

        // ------------------------------------------------------------------------------------------------------------------------ //
    }
}