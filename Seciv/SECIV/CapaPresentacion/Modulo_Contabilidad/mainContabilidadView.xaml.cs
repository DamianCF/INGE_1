using CapaIntegracion;
using MaterialDesignColors;
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

namespace CapaPresentacion.Modulo_Contabilidad
{
    /// <summary>
    /// Cargar el cmbox en Diario y seleccionar la fecha al dia de hoy y inicializar los campos de  balance, ventas y compras en 0
    /// Cargar los valores desde la bd con el query respectivo de fechas
    /// Hacer el calculo de balance, ventas y compras
    /// Cargar los balance, ventas y compras en sus respectivos valores en colones 
    /// realizar las validaciones respectivas de campos y datagrid ...
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


            calcularRangoFechas();
            using (GestorCompras Compra = new GestorCompras())
            {
                //Console.WriteLine("ListarCompras");
                dgridCompras.ItemsSource = Compra.ListarComprasEntreFechas(fechaIni, fechaFin);
            }
            //using (GestorVentas Venta = new GestorVentas())
            //{
            //    //Console.WriteLine("ListarVentas");
            //    dgridCompras.ItemsSource = Venta.ListarVentasRangoFechas(fechaIni, fechaFin);
            //}
            continuar = true;
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

        void calcularRangoFechas()
        {
            string rangoSeleccionado = (cmbxRangoFechas.SelectedItem as ComboBoxItem)?.Content.ToString();
            //Console.WriteLine(textoSeleccionado);
            switch (rangoSeleccionado)
            {
                case "Diario":
                    fechaIni = txtFecha.Text;
                    fechaFin = txtFecha.Text;
                    break;

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
                    break;

                case "Mensual":
                    DateTime fechaM = (DateTime)txtFecha.SelectedDate;

                    DateTime inicioMes = new DateTime(fechaM.Year, fechaM.Month, 1);
                    DateTime finMes = inicioMes.AddMonths(1).AddDays(-1);

                    //Console.WriteLine("Fecha de inicio del mes: " + inicioMes.ToString("dd/MM/yyyy"));
                    //Console.WriteLine("Fecha de fin del mes: " + finMes.ToString("dd/MM/yyyy"));
                    fechaIni = inicioMes.ToString("dd/MM/yyyy");
                    fechaFin = finMes.ToString("dd/MM/yyyy");
                    break;
                case "Anual":
                    DateTime fechaA = (DateTime)txtFecha.SelectedDate;

                    DateTime inicioAño = new DateTime(fechaA.Year, 1, 1);
                    DateTime finAño = inicioAño.AddYears(1).AddDays(-1);

                    //Console.WriteLine("Fecha de inicio del año: " + inicioAño.ToString("dd/MM/yyyy"));
                    //Console.WriteLine("Fecha de fin del año: " + finAño.ToString("dd/MM/yyyy"));
                    fechaIni = inicioAño.ToString("dd/MM/yyyy");
                    fechaFin = finAño.ToString("dd/MM/yyyy");
                    break;
                default:
                    // Acciones por defecto si el valor de rangoSeleccionado no coincide con ningún caso
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }

        private void dgridVentas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
