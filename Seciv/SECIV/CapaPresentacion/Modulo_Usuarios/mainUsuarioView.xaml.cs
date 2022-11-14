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

namespace CapaPresentacion.Modulo_Usuarios
{
    /// <summary>
    /// Lógica de interacción para mainUsuarioView.xaml
    /// </summary>
    public partial class mainUsuarioView : Page
    {
        public mainUsuarioView()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        public void insertarUsuario()
        {

            using (GestorUsuarios Usuario = new GestorUsuarios())
            {
                Usuario.InsertarUsuario(txtCedula.Text, txtNombre.Text,txtpApellido.Text, txtsApellido.Text, txtCorreo.Text, txtContraseña.Text, txtEstado.Text);
            }
        }


        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            insertarUsuario();
            ListarUsuarios();
        }

        public void ListarUsuarios()
        {
            using (GestorUsuarios Usuario = new GestorUsuarios())
            {
                dgridUsuarios.ItemsSource = Usuario.ListarUsuarios();

            }
            cargarTxts();
        }

        private void cargarTxts()
        {

            if (dgridUsuarios.Items.Count > 0)
            {
                Usuario usuario = (Usuario)dgridUsuarios.SelectedItem;
                if (usuario == null)
                {
                    usuario = (Usuario)dgridUsuarios.Items.GetItemAt(0);
                }
                txtId.Text = usuario.id;
                txtCedula.Text = usuario.usu_cedula;
                txtNombre.Text = usuario.usu_nombre;
                txtpApellido.Text = usuario.usu_primerApellido;
                txtsApellido.Text = usuario.usu_segundoApellido;
                txtCorreo.Text = usuario.usu_correo;
                txtContraseña.Text = usuario.usu_contrasena;
                txtEstado.Text = usuario.usu_estado;
            }
        }

        private void dgridUsuarios_MouseUp(object sender, MouseButtonEventArgs e)
        {
            cargarTxts();
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorUsuarios Usuario = new GestorUsuarios())
            {
                Usuario.ActualizarUsuario(txtId.Text, txtCedula.Text, txtNombre.Text,txtpApellido.Text, txtsApellido.Text, txtCorreo.Text, txtContraseña.Text, txtEstado.Text);
            }
            ListarUsuarios();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            using (GestorUsuarios Usuario = new GestorUsuarios())
            {
                if (txtId.Text != "")
                {
                    Usuario.EliminarUsuario(txtId.Text);
                }
            }
            ListarUsuarios();
        }

        private void LimpiarTxts()
        {
            txtId.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtpApellido.Text = "";
            txtsApellido.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtEstado.Text = "";
        }
        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarTxts();
        }

        private void dgridUsuarios_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            e.Column.Header = ((PropertyDescriptor)e.PropertyDescriptor)?.DisplayName ?? e.Column.Header;
            e.Cancel = e.PropertyName == "id";
            e.Column.Visibility = e.PropertyName == "usu_estado" ? Visibility.Hidden : Visibility.Visible;
        }
    }
}
