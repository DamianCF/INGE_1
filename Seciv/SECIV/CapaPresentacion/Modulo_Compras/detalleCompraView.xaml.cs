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

namespace CapaPresentacion.Modulo_Compras
{
    /// <summary>
    /// Lógica de interacción para detalleCompraView.xaml
    /// </summary>
    public partial class detalleCompraView : Page
    {
        public detalleCompraView()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Modulo_Compras.mainComprasView());
        }
    }
}
