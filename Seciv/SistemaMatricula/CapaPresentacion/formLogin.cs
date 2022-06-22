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
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class formLogin : Form
    {
        private int IDUsuario = 0;
        DataSet dsUsuario = new DataSet();
        DataTable dtUsuario = new DataTable();

        public formLogin()
        {
            InitializeComponent();
        }

        // atributos que primites arratrar el form
        // codigo obtenido de https://www.youtube.com/watch?v=kWnJmdwQefc&ab_channel=RJCodeAdvance
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "CEDULA USUARIO:")  // manejo de texto para personalizacion
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "") // manejo de texto para personalizacion
            {
                txtUsuario.Text = "CEDULA USUARIO:";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA:") // manejo de texto para personalizacion
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "") // manejo de texto para personalizacion
            {
                txtContraseña.Text = "CONTRASEÑA:";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)  // validaciones para el ingreso del usuario
        {
            var vr = !string.IsNullOrEmpty(txtUsuario.Text) && txtUsuario.Text != "CEDULA USUARIO:" &&
                !string.IsNullOrEmpty(txtContraseña.Text) && txtContraseña.Text != "CONTRASEÑA:";

            if (vr) // si estan cargados
            {
                try
                {
                    BuscarUsuario(); // problemas si usuario no coicide

                    if (txtUsuario.Text == this.dtUsuario.Rows[0]["Usuario_cedula"].ToString() &&
                        txtContraseña.Text == this.dtUsuario.Rows[0]["Usuario_contrasenia"].ToString())
                    {   // si coincide

                        formPrincipal principal = new formPrincipal(); // paso a form principal
                        principal.IDUsuario1 = IDUsuario;
                        principal.Visible = false;
                        principal.FormClosed += MainForm_Closed;
                        principal.Show();
                        this.Close();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario o Contraseña Mal Digitados", "Error Digitacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Campo sin Rellenar", "Error Digitacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        void BuscarUsuario()
        {

            using (GestorUsuario Usuario = new GestorUsuario())
            {
                this.dsUsuario = Usuario.ConsultarUsuarioLogin(txtUsuario.Text, txtContraseña.Text);
                this.dtUsuario = this.dsUsuario.Tables[0];
            }

            IDUsuario = int.Parse(this.dtUsuario.Rows[0]["Usuario_id"].ToString());
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e) // metodo para cambio de forms sin cerrar programa
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }

        private void formLogin_MouseDown(object sender, MouseEventArgs e) //metodo para arrastrar login
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lnklblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // ir aform de registro
        {
            formUsuario usuario = new formUsuario();
            //usuario.Visible = false;
            usuario.FormClosed += MainForm_Closed; // agrega esto aquí
            usuario.Show();
            // this.Close();
        }
    }
}
