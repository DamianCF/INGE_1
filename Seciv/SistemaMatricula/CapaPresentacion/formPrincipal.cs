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
using SistemaMatricula.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class formPrincipal : Form
    {
        private int IDUsuario = 0;
        private string estadoUsuario = ""; // manejo de estado de tipo de usuario administrador o no entre forms
        DataSet dsUsuario = new DataSet();
        DataTable dtUsuario = new DataTable();
        private Form activeForm = null; // form activo en panel central 


        public formPrincipal()
        {
            InitializeComponent();
        }


        // arratrado de form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void formPrincipal_Load(object sender, EventArgs e)
        {
            //BuscarUsuario();
        }

        public int IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }
        public string EstadoUsuario { get => estadoUsuario; set => estadoUsuario = value; }

        private void btnEstudiantes_Click(object sender, EventArgs e)
        {
            formVenta form = new formVenta();
            form.EstadoUsuario = estadoUsuario;
            openChildForm(form); ;
        }

        private void BuscarUsuario()
        {

        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            formCompra form = new formCompra();
            form.EstadoUsuario = estadoUsuario;
            openChildForm(form); ;
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            //formCurso form = new formCurso();
            //form.EstadoUsuario = estadoUsuario; // eenvio de estado de usuario
            //openChildForm(form); ;
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            formCompra form = new formCompra();
            form.EstadoUsuario = estadoUsuario;
            openChildForm(form); ;
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            //formAula form = new formAula();
            //form.EstadoUsuario = estadoUsuario; // eenvio de estado de usuario
            //openChildForm(form);
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            //formHorario form = new formHorario();
            //form.EstadoUsuario = estadoUsuario;
            //openChildForm(form);
        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            //formMatricula form = new formMatricula();
            //form.EstadoUsuario = estadoUsuario;
            //openChildForm(form);
        }

        private void pctrMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pctrMazimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pctrCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e)// arrastrado de form
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void openChildForm(Form childForm)  // apertura de form dentro del panelCentral
        { // codigo obtenido de : https://www.youtube.com/watch?v=3ni0V-l3Auw&list=WL&index=175&ab_channel=RJCodeAdvance
            if (activeForm != null)
            {
                activeForm.Close();
                BuscarUsuario();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlCentral.Controls.Add(childForm);
            pnlCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            //apertura mantenimientod de usuario
            formUsuario form = new formUsuario();
            form.IDUsuario1 = IDUsuario1;
            form.EstadoUsuario = estadoUsuario;
            openChildForm(form);
        }


    }
}
