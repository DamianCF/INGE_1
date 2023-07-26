using CapaIntegracion;
using MaterialDesignColors;
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

namespace CapaPresentacion.Modulo_Contabilidad
{
    /// <summary>
    /// al seleccionar todo cargar el balance de todas las transaciones
    /// en compras problema con monto y total dejar solo el ultimo
    /// Generar reporte con la informacion especificada en la pantalla de reportes 
    /// De ser posible intentar colocar imagenes ilustrativas a balance, ventas y compras
    /// Hacer la prueba de un texto en el header
    /// intentar hacer cosas que se acomoden automaticamente
    /// </summary>
    public partial class mainContabilidadView : Page
    {
        bool continuar = false;
        string fechaIni = "";
        string fechaFin = "";

        public mainContabilidadView()
        {
            InitializeComponent();

            cmbxRangoFechas.SelectedIndex = 0;
            txtFecha.SelectedDate = DateTime.Today;
            txtBalance.Text = "0";
            txtVentas.Text = "0";
            txtCompras.Text = "0";
            ListarComprasVentas();

        }

        void ListarComprasVentas()
        {
            // clear items of dgridCompras


            if (calcularRangoFechas())
            {
                using (GestorCompras Compra = new GestorCompras())
                {
                    //Console.WriteLine("ListarCompras");
                    var result = Compra.ListarComprasEntreFechas(fechaIni, fechaFin);
                    dgridCompras.ItemsSource = result.Item1;
                    txtCompras.Text = result.Item2.ToString();
                }
                using (GestorVentas Venta = new GestorVentas())
                {
                    //Console.WriteLine("ListarCompras");
                    var result = Venta.ListarVentasEntreFechas(fechaIni, fechaFin);
                    dgridVentas.ItemsSource = result.Item1;
                    txtVentas.Text = result.Item2.ToString();
                }
                continuar = true;
            }


            txtBalance.Text = (double.Parse(txtVentas.Text) - double.Parse(txtCompras.Text)).ToString();
        }

        private void cmbxRangoFechas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (continuar)
            {
                if (txtFecha.SelectedDate == null)
                {
                    MessageBox.Show("Debe seleccionar una fecha");
                    return;
                }
                else
                {
                    ListarComprasVentas();
                }
            }
        }

        bool calcularRangoFechas()
        {
            string rangoSeleccionado = (cmbxRangoFechas.SelectedItem as ComboBoxItem)?.Content.ToString();
            //Console.WriteLine(textoSeleccionado);
            switch (rangoSeleccionado)
            {
                case "Diario":
                    fechaIni = txtFecha.Text;
                    fechaFin = txtFecha.Text;
                    return true;

                case "Semanal":
                    DateTime fecha = (DateTime)txtFecha.SelectedDate;
                    DayOfWeek diaSemana = fecha.DayOfWeek;
                    int restaDias = (7 + (diaSemana - DayOfWeek.Monday)) % 7;

                    DateTime inicioSemana = fecha.AddDays(-restaDias);
                    DateTime finSemana = inicioSemana.AddDays(6);

                    //Console.WriteLine("Fecha de inicio de semana: " + inicioSemana.ToString("dd/MM/yyyy"));
                    //Console.WriteLine("Fecha de fin de semana: " + finSemana.ToString("dd/MM/yyyy"));
                    fechaIni = inicioSemana.ToString("dd/MM/yyyy");
                    fechaFin = finSemana.ToString("dd/MM/yyyy");
                    return true;

                case "Mensual":
                    DateTime fechaM = (DateTime)txtFecha.SelectedDate;

                    DateTime inicioMes = new DateTime(fechaM.Year, fechaM.Month, 1);
                    DateTime finMes = inicioMes.AddMonths(1).AddDays(-1);

                    //Console.WriteLine("Fecha de inicio del mes: " + inicioMes.ToString("dd/MM/yyyy"));
                    //Console.WriteLine("Fecha de fin del mes: " + finMes.ToString("dd/MM/yyyy"));
                    fechaIni = inicioMes.ToString("dd/MM/yyyy");
                    fechaFin = finMes.ToString("dd/MM/yyyy");
                    return true;

                case "Anual":
                    DateTime fechaA = (DateTime)txtFecha.SelectedDate;

                    DateTime inicioAño = new DateTime(fechaA.Year, 1, 1);
                    DateTime finAño = inicioAño.AddYears(1).AddDays(-1);

                    //Console.WriteLine("Fecha de inicio del año: " + inicioAño.ToString("dd/MM/yyyy"));
                    //Console.WriteLine("Fecha de fin del año: " + finAño.ToString("dd/MM/yyyy"));
                    fechaIni = inicioAño.ToString("dd/MM/yyyy");
                    fechaFin = finAño.ToString("dd/MM/yyyy");
                    return true;

                case "Todo":
                    //using (GestorCompras Compra = new GestorCompras())
                    //{
                    //    dgridCompras.ItemsSource = Compra.ListarCompras();
                    //    txtCompras.Text = "0"; // faltaria hacer la suma de todo
                    //}
                    //using (GestorVentas Venta = new GestorVentas())
                    //{
                    //    //Console.WriteLine("ListarVentas");
                    //    dgridVentas.ItemsSource = Venta.ListarVentas();
                    //    txtVentas.Text = "0";
                    //}
                    //return false;
                    fechaIni = "1/1/2000";
                    fechaFin = txtFecha.Text;
                    return true;

                default:
                    // Acciones por defecto si el valor de rangoSeleccionado no coincide con ningún caso
                    Console.WriteLine("Opción no válida");
                    return false;
            }
        }

        private void dgridVentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void txtFecha_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (continuar)
            {
                if (txtFecha.SelectedDate == null)
                {
                    MessageBox.Show("Debe seleccionar una fecha");
                    return;
                }
                else
                {
                    ListarComprasVentas();
                }
            }
        }

        private void dgridCompras_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "com_estado" ? Visibility.Hidden : Visibility.Visible;
        }

        private void dgridVentas_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "vent_estado" ? Visibility.Hidden : Visibility.Visible;
            e.Column.Visibility = e.PropertyName == "vent_productos" ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
