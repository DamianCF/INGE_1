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

namespace SECIV
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MongoClient client = new MongoClient("mongodb+srv://sys:sys@inge01.actyoaw.mongodb.net/SECIV?retryWrites=true&w=majority"); // new MongoClient();
        static IMongoDatabase db = client.GetDatabase("SECIV");
        static IMongoCollection<Compra> collection = db.GetCollection<Compra>("Compras");
        
        public void ReadAllCompras()
        {
            List<Compra> list = collection.AsQueryable().ToList<Compra>();
            dgridCompras.ItemsSource = list;
            Compra c = (Compra)dgridCompras.Items.GetItemAt(0);
            txtId.Text = c.Id.ToString();
            txtCodigo.Text = c.com_codigo.ToString();
            txtMonto.Text = c.com_monto.ToString();
            txtFecha.Text = c.com_fecha.ToString();

        }

        public MainWindow()
        {
            InitializeComponent();
            ReadAllCompras();
        }

        private void dgridCompras_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Compra c = (Compra)dgridCompras.SelectedItem;
            txtId.Text = c.Id.ToString();
            txtCodigo.Text = c.com_codigo.ToString();
            txtMonto.Text = c.com_monto.ToString();
            txtFecha.Text = c.com_fecha.ToString();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Compra c = new Compra(txtCodigo.Text, Double.Parse(txtMonto.Text), txtFecha.Text);
            collection.InsertOne(c);
            ReadAllCompras();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            var updateDef = Builders<Compra>.Update.Set("com_codigo", txtCodigo.Text).Set("com_monto", Double.Parse(txtMonto.Text)).Set("com_fecha", txtFecha.Text);
            collection.UpdateOne(c => c.Id == ObjectId.Parse(txtId.Text), updateDef);
            ReadAllCompras();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            collection.DeleteOne(b => b.Id == ObjectId.Parse(txtId.Text));
            ReadAllCompras();
        }
    }
}
