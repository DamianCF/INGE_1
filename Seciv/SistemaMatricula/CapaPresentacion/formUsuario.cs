using SistemaMatricula.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaMatricula.CapaPresentacion.Validar_TextBox;

/// <summary>
/// form utilizado para el registro de el usuario y para el mantenimiento de este
/// </summary>

namespace CapaPresentacion
{
    public partial class formUsuario : Form
    {
        private int IDUsuario = 0;
        private string estadoUsuario = "";
        DataSet dsUsuario = new DataSet();
        DataTable dtUsuario = new DataTable();

        public formUsuario()
        {
            InitializeComponent();
        }



        private void formUsuario_Load(object sender, EventArgs e)
        {
            if(IDUsuario == 0) //si el usuario esta o no cargado
            {
                //modo registro usuario
                btnModificar.Enabled = false;
                btnModificar.Visible = false;
                btnEliminar.Enabled = false;
                btnEliminar.Visible = false;

            }
            else
            {   // modo mantenimiento usuario
                this.FormBorderStyle = FormBorderStyle.None;
                btnRegistrar.Enabled = false;
                btnRegistrar.Visible = false;
                btnSalir.Enabled = false;
                btnSalir.Visible = false;

                BuscarUsuario();
            }

            validarCampo();
        }

        public int IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            using (GestorUsuario elUsuario = new GestorUsuario())
            {
                elUsuario.insertarUsuario(txtUsuario_cedula.Text, txtUsuario_nombre.Text, txtUsuario_primerApellido.Text,
                    txtUsuario_segundoApellido.Text,determinarTipoUsuario(), txtUsuario_telefono.Text, txtUsuario_correoElectronico.Text,
                    txtUsuario_direccion.Text,txtContraseña.Text, "A");
            }
            MessageBox.Show("Usuario Registrado correctamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnEliminar_Click_1(object sender, EventArgs e) // eliminacion de usuario y salida de la aplicacion
        {
           if( MessageBox.Show("Desea Eliminar Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)  == DialogResult.Yes)
            {
                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    elUsuario.InactivarUsuario(IDUsuario);
                }

                MessageBox.Show("Usuario Eliminado correctamente", "Eliminar Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (txtContraseña.Text == txtConfirmarContraseña.Text)
            {
                using (GestorUsuario elUsuario = new GestorUsuario())
                {                               //si cambia la variable a global Usuario_id y le manda esa funciona si se seleciona desde el grid
                    elUsuario.ModificarUsuario(IDUsuario, txtUsuario_cedula.Text, txtUsuario_nombre.Text, txtUsuario_primerApellido.Text,
                                                txtUsuario_segundoApellido.Text, determinarTipoUsuario(), txtUsuario_telefono.Text, txtUsuario_correoElectronico.Text,
                                                txtUsuario_direccion.Text, txtContraseña.Text, "A");
                }
                MessageBox.Show("Usuario Modificacado correctamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incoherencia validando contraseña", "Error Digitacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        string determinarTipoUsuario()
        {
            string tipoUsuario = "";
            if (chkbxAdministrador.Checked == true)
            {
                tipoUsuario = "A"; // usuario administrador
            }
            else
            {
                tipoUsuario = "F"; //usuario final
            }

            return tipoUsuario;
        }

        private void BuscarUsuario()
        {

            using (GestorUsuario Usuario = new GestorUsuario())
            {
                this.dsUsuario = Usuario.ConsultarUsuario(IDUsuario);
                this.dtUsuario = this.dsUsuario.Tables[0];
            }
            CargarDatosUsuario();
        }



        private void CargarDatosUsuario()
        {
            txtUsuario_cedula.Text = this.dtUsuario.Rows[0]["Usuario_cedula"].ToString();
            txtUsuario_nombre.Text = this.dtUsuario.Rows[0]["Usuario_nombre"].ToString();
            txtUsuario_primerApellido.Text = this.dtUsuario.Rows[0]["Usuario_primerApellido"].ToString();
            txtUsuario_segundoApellido.Text = this.dtUsuario.Rows[0]["Usuario_segundoApellido"].ToString();
            txtUsuario_telefono.Text = this.dtUsuario.Rows[0]["Usuario_telefono"].ToString();
            string estadoUsuario = this.dtUsuario.Rows[0]["Usuario_tipo"].ToString();
            if(estadoUsuario == "A") //modificadir chkbx administrador
            {
                chkbxAdministrador.Checked = true;
            }
            else
            {
                chkbxAdministrador.Checked = false;
            }
            txtUsuario_correoElectronico.Text = this.dtUsuario.Rows[0]["Usuario_correoElectronico"].ToString();
            txtUsuario_direccion.Text = this.dtUsuario.Rows[0]["Usuario_direccion"].ToString();
            txtContraseña.Text = this.dtUsuario.Rows[0]["Usuario_contrasenia"].ToString();
            txtConfirmarContraseña.Text = this.dtUsuario.Rows[0]["Usuario_contrasenia"].ToString();
        }



        private void validarCampo() // validacion de campos llenos 
        {
            var vr = !string.IsNullOrEmpty(txtUsuario_cedula.Text) &&
                !string.IsNullOrEmpty(txtUsuario_nombre.Text) &&
                !string.IsNullOrEmpty(txtUsuario_primerApellido.Text) &&
                !string.IsNullOrEmpty(txtUsuario_segundoApellido.Text) &&
                !string.IsNullOrEmpty(txtUsuario_telefono.Text) &&
                !string.IsNullOrEmpty(txtUsuario_correoElectronico.Text) &&
                !string.IsNullOrEmpty(txtUsuario_direccion.Text) &&
                !string.IsNullOrEmpty(txtContraseña.Text) &&
                !string.IsNullOrEmpty(txtConfirmarContraseña.Text) &&
                txtContraseña.Text == txtConfirmarContraseña.Text ;


            btnModificar.Enabled = vr;
            btnRegistrar.Enabled = vr;
            btnEliminar.Enabled = vr;
   
            if (vr)
            {
                btnModificar.BackColor = Color.CornflowerBlue;
                btnRegistrar.BackColor = Color.CornflowerBlue;
                btnEliminar.BackColor = Color.CornflowerBlue;
            }
            else
            {
                btnModificar.BackColor = Color.Gray;
                btnRegistrar.BackColor = Color.Gray;
                btnEliminar.BackColor = Color.Gray;
            }
        }

        private void txtUsuario_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();
        }

        private void txtUsuario_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtUsuario_primerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtUsuario_segundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
            validarCampo();
        }

        private void txtUsuario_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
            validarCampo();

        }

        private void txtUsuario_correoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();

        }

        private void txtUsuario_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();

        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();

        }

        private void txtConfirmarContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
